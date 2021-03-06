﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Patient;

namespace VA.Gov.Artemis.UI.Data.Models.Pregnancy
{
    public class SelectFatherModel: PatientRelatedModel
    {
        //public BasePatient Patient { get; set; }

        public Dictionary<string, string> Choices { get; set; }

        public string PregnancyIen { get; set; }

        public string CurrentSelection { get; set; }

        public SelectFatherModel()
        {
            this.Choices = new Dictionary<string, string>(); 
        }
    }
}
