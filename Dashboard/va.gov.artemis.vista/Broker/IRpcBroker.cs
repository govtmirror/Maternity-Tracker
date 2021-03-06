﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA.Gov.Artemis.Vista.Broker
{
    public interface IRpcBroker
    {
        string CurrentContext { get; }

        bool Connect();

        RpcResponse CallRpc(string context, string rpcName, string rpcVersion, object[] args);

        RpcResponse CreateContext(string context);

        string GetXmlDescription(bool partial);

        int SocketInactivityTimeout { get; }

        void Disconnect();

    }
}
