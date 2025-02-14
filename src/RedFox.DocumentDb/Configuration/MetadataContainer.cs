// This Source Code Form is subject to the terms of the MIT License.
// If a copy of the MIT was not distributed with this file, You can obtain one at https://opensource.org/licenses/MIT.
// Copyright (C) RedFox and Open-Source Contributors.
// All Rights Reserved.

namespace RedFox.DocumentDb.Configuration;

public class MetadataContainer(DocumentDbEventStoreOptions options) : IMetadataContainer
{
    public const string DefaultEventsPartitionKey = "rf_events";

    public const string DefaultStreamsPartitionKey = "rf_streams";

    /// <inheritdoc />
    public string? Get(string key)
    {
        return key switch
        {
            "connection_string" => options.ConnectionString,
            "events_partition_key" => options.EventsPartitionKey ?? DefaultEventsPartitionKey,
            "streams_partition_key" => options.StreamsPartitionKey ?? DefaultStreamsPartitionKey,
            _ => throw new ArgumentException($"Metadata key '{key}' is not supported."),
        };
    }
}
