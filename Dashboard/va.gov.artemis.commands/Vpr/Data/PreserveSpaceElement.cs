﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace VA.Gov.Artemis.Commands.Vpr.Data
{
    [Serializable]
    public class PreserveSpaceElement
    {
        public PreserveSpaceElement()
        {
            this.PreseveSpace = "preserve"; 
        }

        [XmlAttribute("xml:space")]
        public string PreseveSpace {get; set;}

        [XmlText]
        public string Value { get; set; }
    }
}
