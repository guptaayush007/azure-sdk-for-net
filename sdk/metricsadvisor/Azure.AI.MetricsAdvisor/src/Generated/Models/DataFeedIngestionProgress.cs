// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.MetricsAdvisor.Models
{
    /// <summary> The DataFeedIngestionProgress. </summary>
    public partial class DataFeedIngestionProgress
    {
        /// <summary> Initializes a new instance of <see cref="DataFeedIngestionProgress"/>. </summary>
        internal DataFeedIngestionProgress()
        {
        }

        /// <summary> Initializes a new instance of <see cref="DataFeedIngestionProgress"/>. </summary>
        /// <param name="latestSuccessTimestamp">
        /// the timestamp of latest success ingestion job.
        /// null indicates not available
        /// </param>
        /// <param name="latestActiveTimestamp">
        /// the timestamp of latest ingestion job with status update.
        /// null indicates not available
        /// </param>
        internal DataFeedIngestionProgress(DateTimeOffset? latestSuccessTimestamp, DateTimeOffset? latestActiveTimestamp)
        {
            LatestSuccessTimestamp = latestSuccessTimestamp;
            LatestActiveTimestamp = latestActiveTimestamp;
        }
    }
}
