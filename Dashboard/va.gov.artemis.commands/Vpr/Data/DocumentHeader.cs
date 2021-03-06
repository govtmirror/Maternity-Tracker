﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VA.Gov.Artemis.Commands.Vpr.Data
{
    [Serializable]
    [XmlRoot("document")]
    public class DocumentHeader
    {
        [XmlAttribute("id")]
        public string DocumentHeaderId { get; set; }

        [XmlAttribute("localTitle")]
        public string LocalTitle { get; set; }

        [XmlAttribute("status")]
        public string Status { get; set; }
    }
}
