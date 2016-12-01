﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VA.Gov.Artemis.Commands.Vpr.Data
{
    [Serializable]    
    public class EducationTopic: ClinicalItem
    {
        [XmlElement("dateTime")]
        public VprDateTime EducationTopicDateTime { get; set; }

        [XmlElement("encounter")]
        public ValueElement Encounter { get; set; }

    }
}