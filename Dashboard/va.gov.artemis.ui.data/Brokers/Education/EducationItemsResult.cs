﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Education;
using VA.Gov.Artemis.UI.Data.Brokers.Common; 

namespace VA.Gov.Artemis.UI.Data.Brokers.Education
{
    public class EducationItemsResult: BrokerOperationResult
    {
        public int TotalResults { get; set; }

        public List<EducationItem> EducationItems { get; set; }

        public EducationItemsResult()
        {
            this.EducationItems = new List<EducationItem>(); 
        }
    }
}
