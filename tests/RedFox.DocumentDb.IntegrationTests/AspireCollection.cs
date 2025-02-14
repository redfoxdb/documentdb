// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

using RedFox.DocumentDb.IntegrationTests.SeedWork;

namespace RedFox.DocumentDb.IntegrationTests;

// NOTE: https://xunit.net/docs/shared-context
[CollectionDefinition("Aspire Collection")]
public sealed class AspireCollection : ICollectionFixture<DatabaseFixture>;
