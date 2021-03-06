﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.Commands.Dsio.Observation;
using VA.Gov.Artemis.UI.Data.Models.Common;
using VA.Gov.Artemis.UI.Data.Models.Patient;
using VA.Gov.Artemis.UI.Data.Models.Pregnancy;
using VA.Gov.Artemis.UI.Data.Brokers.Common;
using VA.Gov.Artemis.UI.Data.Brokers.Observations; 

namespace VA.Gov.Artemis.UI.Data.Brokers.Pregnancy
{
    public interface IPregnancyRepository
    {
        IenResult SavePerson(string patientDfn, Person fof);

        PersonListResult GetPersons(string patientDfn, string personIen); 

        IenResult SavePregnancy(PregnancyDetails pregnancy);

        PregnancyResult GetCurrentPregnancy(string patientDfn);

        PregnancyResult GetCurrentOrMostRecentPregnancy(string patientDfn); 

        PregnancyListResult GetPregnancies(string patientDfn, string pregnancyIen);

        PregnancyHistoryResult GetPregnancyHistory(string patientDfn);

        BrokerOperationResult SavePregnancyHistory(string patientDfn, PregnancyHistory pregnancyHistory);

        ObservationListResult GetObservations(string patientDfn, string pregnancyIen, string babyIen, string fromDate, string toDate, string category, int page, int itemsPerPage);

        AddBabyResult AddBabyToPregnancy(string patientDfn, string pregnancyIen);

        BrokerOperationResult Delete(string pregIen);

        PregnancyOutcomeResult GetPregnancyOutcomes(DateTime fromDate, DateTime toDate, int page, int itemsPerPage); 
    }
}
