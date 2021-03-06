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
    /// A broker operation result which contains a list of pregnancies
    /// </summary>
    public class PregnancyListResult: BrokerOperationResult
    {
        public List<PregnancyDetails> Pregnancies { get; set; }
    }
}
