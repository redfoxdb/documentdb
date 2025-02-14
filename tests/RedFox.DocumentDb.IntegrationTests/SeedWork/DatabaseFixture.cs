// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

using System;
using System.Threading;
using System.Threading.Tasks;
using Aspire.Hosting;
using Aspire.Hosting.ApplicationModel;
using Microsoft.Extensions.Hosting;
using Npgsql;

namespace RedFox.DocumentDb.IntegrationTests.SeedWork;

public class DatabaseFixture : IAsyncLifetime
{
    private readonly IHost _aspireApp;

    private string? _postgresConnectionString;

    private IResourceBuilder<PostgresServerResource> Postgres { get; }

    public DatabaseFixture()
    {
        IDistributedApplicationBuilder appBuilder = DistributedApplication.CreateBuilder(
            new DistributedApplicationOptions
            {
                AssemblyName = typeof(RedFox.DocumentDb.IDocumentSession).Assembly.FullName,
                DisableDashboard = true,
            }
        );

        Postgres = appBuilder
            .AddPostgres($"postgres")
            .WithImage("postgres")
            .WithImageTag("17.0-alpine");

        _aspireApp = appBuilder.Build();
    }

    public async Task InitializeAsync()
    {
        await _aspireApp.StartAsync();

        _postgresConnectionString = await Postgres.Resource.GetConnectionStringAsync();

        await WaitForDatabaseAsync();
    }

    public async Task DisposeAsync()
    {
        await _aspireApp.StopAsync();

        if (_aspireApp is IAsyncDisposable asyncDisposable)
        {
            await asyncDisposable.DisposeAsync().ConfigureAwait(false);
        }
        else
        {
            _aspireApp.Dispose();
        }
    }

    private async Task WaitForDatabaseAsync()
    {
        using CancellationTokenSource cancellationTokenSource = new();

        const int limit = 30;
        int attempts = 0;

        string? connectionString = await Postgres.Resource.GetConnectionStringAsync(
            cancellationTokenSource.Token
        );

        if (connectionString is null)
        {
            throw new InvalidOperationException("Postgres connection string is null.");
        }

        await using NpgsqlConnection connection = new(_postgresConnectionString);

        while (!cancellationTokenSource.Token.IsCancellationRequested || attempts > limit)
        {
            try
            {
                await connection.OpenAsync(cancellationTokenSource.Token);

                break;
            }
            catch (NpgsqlException)
            {
                await Task.Delay(1000, cancellationTokenSource.Token);
            }

            attempts++;
        }
    }
}
