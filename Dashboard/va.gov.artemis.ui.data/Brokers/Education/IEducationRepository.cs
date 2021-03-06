﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.UI.Data.Models.Education;
using VA.Gov.Artemis.UI.Data.Brokers.Common;

namespace VA.Gov.Artemis.UI.Data.Brokers.Education
{
    public interface IEducationRepository
    {
        IenResult SaveEducationItem(EducationItem item);

        EducationItemsResult GetEducationItems(string ien, string category, EducationItemType itemType, int page, int pageSize, EducationItemSort sort);

        BrokerOperationResult DeleteEducationItem(string ien);

        IenResult SavePatientItem(PatientEducationItem item);

        PatientEducationItemsResult GetPatientItems(string patientDfn, string ien, DateTime fromDate, DateTime toDate, EducationItemType itemType, int page, int itemsPerPage); 

        BrokerOperationResult DeletePatientItem(string ien);

        Dictionary<string, string> GetItemSelection();

        EducationItemsResult LoadDefaults();

    }
}
