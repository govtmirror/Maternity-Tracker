﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VA.Gov.Artemis.Vista.Broker;
using VA.Gov.Artemis.Commands.Dsio.Pregnancy;
using VA.Gov.Artemis.Commands.Dsio.Orders;

namespace VA.Gov.Artemis.Commands.Tests.Real
{
    [TestClass]
    public class TestDsioOrderCommands: TestCommandsBase
    {
        [TestMethod]
        public void TestGetOrderList()
        {
            using (RpcBroker broker = this.GetConnectedBroker())
            {
                this.SignonToBroker(broker, 2);

                DsioGetOrderListCommand command = new DsioGetOrderListCommand(broker);

                command.AddCommandArguments("711", 1, 10);
                //command.AddCommandArguments("715"); 

                RpcResponse response = command.Execute();

                Assert.AreEqual(RpcResponseStatus.Success, response.Status);

            }

        }
    }
}
