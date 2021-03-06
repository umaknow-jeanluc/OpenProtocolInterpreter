﻿namespace OpenProtocolInterpreter.MultiSpindle
{
    /// <summary>
    /// Represents a Spindle Status entity
    /// </summary>
    public class SpindleStatus
    {
        public int SpindleNumber { get; set; }
        public int ChannelId { get; set; }
        public bool SyncOverallStatus { get; set; }
    }
}
