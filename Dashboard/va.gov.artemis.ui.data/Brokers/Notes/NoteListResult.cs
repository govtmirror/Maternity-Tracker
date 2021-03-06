﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Notes;
using VA.Gov.Artemis.UI.Data.Brokers.Common; 

namespace VA.Gov.Artemis.UI.Data.Brokers.Notes
{
    public class NoteListResult: BrokerOperationResult
    {
        public List<TiuNote> Notes { get; set; }

        public int TotalResults { get; set; }

        public NoteListResult()
        {
            this.Notes = new List<TiuNote>(); 
        }
    }
}
