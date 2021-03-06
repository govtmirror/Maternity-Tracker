﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Patient;
using VA.Gov.Artemis.UI.Data.Models.Pregnancy;
using VA.Gov.Artemis.UI.Data.Brokers.Common; 

namespace VA.Gov.Artemis.UI.Data.Brokers.Pregnancy
{
    /// <summary>
    /// A broker operation result which contains a single pregnancy
    /// </summary>
    public class PregnancyResult: BrokerOperationResult
    {
        public PregnancyDetails Pregnancy { get; set; }
    }
}
