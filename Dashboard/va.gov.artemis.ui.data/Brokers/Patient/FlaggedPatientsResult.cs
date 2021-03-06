﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models;
using VA.Gov.Artemis.UI.Data.Models.FlaggedPatients;
using VA.Gov.Artemis.UI.Data.Brokers.Common; 

namespace VA.Gov.Artemis.UI.Data.Brokers.Patient
{
    public class FlaggedPatientsResult: BrokerOperationResult
    {
        public int TotalResults { get; set; }

        public List<FlaggedPatient> Patients { get; set; }

        public FlaggedPatientsResult()
        {
            this.Patients = new List<FlaggedPatient>();
        }
    }
}
