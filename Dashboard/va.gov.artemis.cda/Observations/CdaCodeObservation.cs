﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VA.Gov.Artemis.CDA.Common;

namespace VA.Gov.Artemis.CDA.Observations
{
    /// <summary>
    /// Simple observation where the value is a code
    /// </summary>
    public class CdaCodeObservation : CdaSimpleObservation
    {
        public CdaCode Value { get; set; }

        protected override ANY[] BaseValue
        {
            get { return new ANY[]{this.Value.ToCD()}; }
        }

        public override string DisplayValue
        {
            get { return this.Value.DisplayName; }
        }
    }
}
