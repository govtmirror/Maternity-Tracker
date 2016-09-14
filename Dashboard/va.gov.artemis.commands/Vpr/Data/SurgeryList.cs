﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;

namespace VA.Gov.Artemis.Commands.Vpr.Data
{
    [Serializable]
    public class SurgeryList: ListWithTotal
    {
        [XmlElement("surgery")]
        public List<SurgicalProcedure> List { get; set; }
    }
}
