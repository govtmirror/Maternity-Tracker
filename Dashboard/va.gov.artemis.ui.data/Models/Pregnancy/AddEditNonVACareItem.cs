﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.NonVACare;
using VA.Gov.Artemis.UI.Data.Models.Patient;

namespace VA.Gov.Artemis.UI.Data.Models.Pregnancy
{
    public class AddEditNonVACareItem: PatientRelatedModel
    {
        //public BasePatient Patient { get; set; }

        public string PregnancyIen { get; set; }

        public NonVACareItem Item { get; set; }

        public string ReturnUrl { get; set; }
    }
}
