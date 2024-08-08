﻿namespace HTX.Net.Objects.Models.Socket
{
    /// <summary>
    /// Incremental order book update
    /// </summary>
    public record HTXIncrementalOrderBookUpdate : HTXOrderBookUpdate
    {
        /// <summary>
        /// Event
        /// </summary>
        [JsonPropertyName("event")]
        public string Event { get; set; } = string.Empty;
    }
}
