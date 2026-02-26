using System;

namespace TESTBAG.Protocol
{
    /// <summary>
    /// Provide data for the ConnectionStatusChanged event
    /// </summary>
    public class ConnectionStatusEventArgs : EventArgs
    {
        public ConnectionStatus Status { get; }

        public ConnectionStatusEventArgs(ConnectionStatus status)
        {
            Status = status;
        }
    }
}
