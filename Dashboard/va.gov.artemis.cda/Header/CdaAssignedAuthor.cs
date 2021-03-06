﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.CDA.Common;

namespace VA.Gov.Artemis.CDA
{
    public abstract class CdaAssignedAuthor
    {
        public CdaAddress Address { get; set; }
        //public string WorkTelephone { get; set; }
        public CdaTelephoneList TelephoneList { get; set; }

        public CdaAssignedAuthor()
        {
            this.Address = new CdaAddress();
            this.TelephoneList = new CdaTelephoneList(); 
        }
    }
}
