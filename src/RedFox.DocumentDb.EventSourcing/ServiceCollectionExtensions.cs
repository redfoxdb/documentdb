// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

using RedFox.DocumentDb.EventSourcing.Configuration;

namespace RedFox.DocumentDb.EventSourcing;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDocumentDbEventStore(
        this IServiceCollection services,
        Action<DocumentDbEventStoreOptions> configure
    )
    {
        return services;
    }
}
