// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

using RedFox.DocumentDb.DocumentStore;

// ReSharper disable once CheckNamespace
namespace RedFox.DocumentDb;

public interface IDocumentStore
{
    Task<T?> GetAsync<T>(
        string id,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class;

    Task UpsertAsync<T>(
        string id,
        T document,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class;

    Task DeleteAsync<T>(
        string id,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class;

    Task PatchAsync<T>(
        string id,
        IReadOnlyList<PatchOperation> patchOperations,
        PartitionKey? partitionKey = default,
        CancellationToken cancellationToken = default
    )
        where T : class;
}
