﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Brokers.Common; 

namespace VA.Gov.Artemis.UI.Data.Brokers.Account
{
    public class AdminResult: BrokerOperationResult
    {
        public bool UserHasAdminSecurityKey { get; set; }
    }
}
