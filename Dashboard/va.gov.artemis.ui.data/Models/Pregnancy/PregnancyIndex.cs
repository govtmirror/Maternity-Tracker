﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Patient;

namespace VA.Gov.Artemis.UI.Data.Models.Pregnancy
{
    public class PregnancyIndex : PatientRelatedModel
    {
        //public List<PregnancyDetails> Items { get; set; }

        public PregnancyDetails CurrentPregnancy { get; set; }

        public List<PastPregnancy> PastPregnancies { get; set; }

        public PregnancyIndex()
        {
            //this.Items = new List<PregnancyDetails>();
            this.PastPregnancies = new List<PastPregnancy>(); 
        }
    }
}
