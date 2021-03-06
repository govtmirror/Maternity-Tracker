﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Common;

namespace VA.Gov.Artemis.UI.Data.Models.NonVACare
{
    public class NonVACareItemList
    {
        public Paging Paging { get; set; }

        public List<NonVACareItem> Items { get; set; }

        public NonVACareItemList()
        {
            this.Paging = new Paging();
            this.Items = new List<NonVACareItem>(); 
        }

        public string CurrentPatientDfn { get; set; }

        public string CurrentPregnancyIen { get; set; }

        public string CurrentItemType { get; set; }

        public string FinishedLink { get; set; }
    }
}
