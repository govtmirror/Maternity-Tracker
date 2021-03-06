﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Common;
using VA.Gov.Artemis.UI.Data.Models.Patient;

namespace VA.Gov.Artemis.UI.Data.Models.Radiology
{
    public class RadiologyIndex: PatientRelatedModel
    {
        public Paging Paging { get; set; }

        public List<RadiologyReport> ReportList { get; set; }

        public RadiologyIndex()
        {
            this.Paging = new Paging();
            this.ReportList = new List<RadiologyReport>(); 
        }
    }
}
