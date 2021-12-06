using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class Biological : Product
    {
        public string Herbs { get; set; }

        override
        public string GetMyType()
        {
            return "Biological";
        }
    }
}
