﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models;
using VA.Gov.Artemis.UI.Data.Models.Reminders;
using VA.Gov.Artemis.UI.Data.Brokers.Common; 

namespace VA.Gov.Artemis.UI.Data.Brokers.Reminders
{
    public class ReminderListResult: BrokerOperationResult
    {
        public int TotalResults { get; set; }
        public List<Reminder> Reminders { get; set; }

        public ReminderListResult()
        {
            this.Reminders = new List<Reminder>(); 
        }


    }
}
