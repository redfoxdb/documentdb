// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

namespace RedFox.DocumentDb;

public class DocumentDbDocumentSession : IDocumentSession
{
    /// <inheritdoc />
    public async Task SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        await Task.CompletedTask;

        throw new NotImplementedException();
    }

    /// <inheritdoc />
    public IDocumentStore Documents { get; } = null!;
}
