﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Patient;

namespace VA.Gov.Artemis.UI.Data.Models.Notes
{
    public class DeleteNoteModel: PatientRelatedModel
    {
        //public BasePatient Patient { get; set; }
        public string NoteIen { get; set; }

        [Required]
        public string DeleteReason { get; set; }

        public string ReturnUrl { get; set; }
    }
}
