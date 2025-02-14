// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

using RedFox.DocumentDb.Configuration;

namespace RedFox.DocumentDb.EventStore;

public class EventStore(IDocumentSession session, IMetadataContainer metadata) : IEventStore
{
    /// <inheritdoc />
    public async Task AppendEventAsync<TEvent>(
        string streamId,
        TEvent @event,
        CancellationToken cancellationToken = default
    )
        where TEvent : class
    {
        await Task.CompletedTask;

        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public async Task<IEnumerable<IEvent>> ReadStreamAsync(
        string streamId,
        CancellationToken cancellationToken = default
    )
    {
        await Task.CompletedTask;

        throw new NotImplementedException();
    }
}
