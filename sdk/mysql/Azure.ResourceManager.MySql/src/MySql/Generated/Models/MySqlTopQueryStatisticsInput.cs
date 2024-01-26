// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.MySql.Models
{
    /// <summary> Input to get top query statistics. </summary>
    public partial class MySqlTopQueryStatisticsInput
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="MySqlTopQueryStatisticsInput"/>. </summary>
        /// <param name="numberOfTopQueries"> Max number of top queries to return. </param>
        /// <param name="aggregationFunction"> Aggregation function name. </param>
        /// <param name="observedMetric"> Observed metric name. </param>
        /// <param name="observationStartOn"> Observation start time. </param>
        /// <param name="observationEndOn"> Observation end time. </param>
        /// <param name="aggregationWindow"> Aggregation interval type in ISO 8601 format. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="aggregationFunction"/>, <paramref name="observedMetric"/> or <paramref name="aggregationWindow"/> is null. </exception>
        public MySqlTopQueryStatisticsInput(int numberOfTopQueries, string aggregationFunction, string observedMetric, DateTimeOffset observationStartOn, DateTimeOffset observationEndOn, string aggregationWindow)
        {
            Argument.AssertNotNull(aggregationFunction, nameof(aggregationFunction));
            Argument.AssertNotNull(observedMetric, nameof(observedMetric));
            Argument.AssertNotNull(aggregationWindow, nameof(aggregationWindow));

            NumberOfTopQueries = numberOfTopQueries;
            AggregationFunction = aggregationFunction;
            ObservedMetric = observedMetric;
            ObservationStartOn = observationStartOn;
            ObservationEndOn = observationEndOn;
            AggregationWindow = aggregationWindow;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlTopQueryStatisticsInput"/>. </summary>
        /// <param name="numberOfTopQueries"> Max number of top queries to return. </param>
        /// <param name="aggregationFunction"> Aggregation function name. </param>
        /// <param name="observedMetric"> Observed metric name. </param>
        /// <param name="observationStartOn"> Observation start time. </param>
        /// <param name="observationEndOn"> Observation end time. </param>
        /// <param name="aggregationWindow"> Aggregation interval type in ISO 8601 format. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal MySqlTopQueryStatisticsInput(int numberOfTopQueries, string aggregationFunction, string observedMetric, DateTimeOffset observationStartOn, DateTimeOffset observationEndOn, string aggregationWindow, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NumberOfTopQueries = numberOfTopQueries;
            AggregationFunction = aggregationFunction;
            ObservedMetric = observedMetric;
            ObservationStartOn = observationStartOn;
            ObservationEndOn = observationEndOn;
            AggregationWindow = aggregationWindow;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="MySqlTopQueryStatisticsInput"/> for deserialization. </summary>
        internal MySqlTopQueryStatisticsInput()
        {
        }

        /// <summary> Max number of top queries to return. </summary>
        public int NumberOfTopQueries { get; }
        /// <summary> Aggregation function name. </summary>
        public string AggregationFunction { get; }
        /// <summary> Observed metric name. </summary>
        public string ObservedMetric { get; }
        /// <summary> Observation start time. </summary>
        public DateTimeOffset ObservationStartOn { get; }
        /// <summary> Observation end time. </summary>
        public DateTimeOffset ObservationEndOn { get; }
        /// <summary> Aggregation interval type in ISO 8601 format. </summary>
        public string AggregationWindow { get; }
    }
}
