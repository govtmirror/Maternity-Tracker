﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VA.Gov.Artemis.Vista.Broker;

namespace VA.Gov.Artemis.Vista.Tests
{
    [TestClass]
    public class TestRpcBroker
    {
        // TODO: Use these, or move to config file...
        private const string validServerName = "localhost"; 
        private const int validServerPort = 9000; 

        [TestMethod]
        public void TestConnectNoServer()
        {
            if (TestConnect("",0)) 
                Assert.Fail("Connected without valid server name/port");
        }

        [TestMethod]
        public void TestConnectValidServer()
        {
            if (!TestConnect(validServerName, validServerPort))
                Assert.Fail("Could not connect to localhost:9000");

        }

        [TestMethod]
        public void TestInvalidPort()
        {
            if (TestConnect(validServerName, 342))
                Assert.Fail("Connected to invalid port"); 
        }

        [TestMethod]
        public void TestInvalidServer()
        {
            if (TestConnect("noserver", validServerPort))
                Assert.Fail("Connected to invalid server"); 
        }

        [TestMethod]
        public void TestInvalidChars()
        {
            if (TestConnect("/\\\\*^(^$%@$)(*';,", 0))
                Assert.Fail(); 
        }

        [TestMethod]
        public void TestDefaultServer() 
        {
            if (!TestConnect("", validServerPort))
                Assert.Fail("Could not connect to localhost:9000");
        }

        [TestMethod]
        public void TestEmptyRpcName()
        {
            using (RpcBroker broker = new RpcBroker("", validServerPort))
            {
                if (broker.Connect())
                {
                    broker.CallRpc("", "", "", null);

                    broker.Disconnect();
                }
                else
                    Assert.Fail("No connection");
            }
        }

        [TestMethod]
        public void TestCreateContext()
        {
            using (RpcBroker broker = new RpcBroker("", validServerPort))
            {
                if (broker.Connect())
                {
                    RpcResponse response = broker.CreateContext("XUS SIGNON");

                    Assert.AreSame(broker.CurrentContext, "XUS SIGNON"); 

                    broker.Disconnect(); 
                }
                else
                    Assert.Fail("No connection");
            }
        }

        [TestMethod]
        public void TestValidRpc()
        {
            using (RpcBroker broker = new RpcBroker("", validServerPort))
            {
                if (broker.Connect())
                {
                    RpcResponse response = broker.CallRpc("", "XUS INTRO MSG", "0", null);

                    Assert.AreEqual(RpcResponseStatus.Success, response.Status);

                    broker.Disconnect();
                }
                else
                    Assert.Fail("No connection");
            }
            
        }

        [TestMethod]
        public void TestInvalidRpc()
        {
            using (RpcBroker broker = new RpcBroker("", validServerPort))
            {
                if (broker.Connect())
                {
                    RpcResponse response = broker.CallRpc("", "XXXXXX", "0", null);

                    if (response.Status == RpcResponseStatus.Success)
                        Assert.Fail("Success"); 

                    broker.Disconnect();
                }
                else
                    Assert.Fail("No connection");
            }

        }

        // TODO: Add test for SocketTimeout 
        [TestMethod]
        public void TestSocketTimeout()
        {
            using (RpcBroker broker = new RpcBroker("", validServerPort))
            {
                if (broker.Connect())
                {
                    string msg = string.Format("Socket Timeout [{0}] is invalid", broker.SocketInactivityTimeout); 

                    Assert.IsTrue((broker.SocketInactivityTimeout > 0), msg );

                    broker.Disconnect();
                }
                else
                    Assert.Fail("No connection");
            }

        }

        [TestMethod]
        public void TestDisconnectNotConnected()
        {
            using (RpcBroker broker = new RpcBroker(validServerName, validServerPort))
                broker.Disconnect();

        }

        private bool TestConnect(string server, int port)
        {
            bool returnVal = false; 

            using (RpcBroker broker = new RpcBroker(server, port))
            {
                returnVal = broker.Connect();

                if (returnVal)
                    broker.Disconnect();
            }

            return returnVal; 
        }
        
    }
}
