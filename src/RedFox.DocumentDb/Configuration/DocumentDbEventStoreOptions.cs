// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

namespace RedFox.DocumentDb.Configuration;

public class DocumentDbEventStoreOptions
{
    public string? ConnectionString { get; set; }

    public string? EventsPartitionKey { get; set; }

    public string? StreamsPartitionKey { get; set; }
}
