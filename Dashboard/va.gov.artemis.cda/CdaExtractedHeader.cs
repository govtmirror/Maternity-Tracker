﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VA.Gov.Artemis.CDA
{
    public class CdaExtractedHeader
    {
        public string Id { get; set; } // GUID for exchange
        public DateTime CreationDateTime { get; set; }
        public IheDocumentType DocumentType { get; set; }
        public string Title { get; set; }
        public string IntendedRecipient { get; set; }
        public string Sender { get; set; }
    }
}
