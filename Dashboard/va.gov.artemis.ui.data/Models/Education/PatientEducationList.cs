﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA.Gov.Artemis.UI.Data.Models.Education
{
    public class PatientEducationList: List<PatientEducationChecklistItem>
    {
        public void AddPregnancyDates(DateTime edd, DateTime pregnancyEndDate)
        {
            // *** Add dates to existing items ***

            // *** NOTE: MUST COME AFTER ITEMS EXIST ***

            foreach (PatientEducationChecklistItem item in this)
            {
                if (item.PregnancyChecklistItem != null)
                {
                    item.PregnancyChecklistItem.PregnancyEndDate = pregnancyEndDate;
                    item.PregnancyChecklistItem.Edd = edd;
                }
            }
        }
    }
}
