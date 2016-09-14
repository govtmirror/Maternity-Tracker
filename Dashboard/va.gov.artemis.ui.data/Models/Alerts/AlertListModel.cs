﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.Commands.Dsio.Alerts;
using VA.Gov.Artemis.UI.Data.Models.Common;

namespace VA.Gov.Artemis.UI.Data.Models.Alerts
{
    public class AlertListModel
    {
        public List<DsioAlert> Alerts { get; set; }
        
        public Paging Paging { get; set; }

        public AlertListModel()
        {
            this.Paging = new Paging();
            this.Alerts = new List<DsioAlert>(); 
        }
    }
}
