// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

using RedFox.DocumentDb.Operations;

namespace RedFox.DocumentDb;

public interface IProjection
{
    public Task ApplyAsync(IDocumentSession documentSession, DatabaseOperation[] operations);
}
