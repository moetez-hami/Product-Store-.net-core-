using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public class Chemical : Product
    {
        public string City { get; set; }
        public string LabName { get; set; }
        public string StreetAddress { get; set; }

        override
        public string GetMyType()
        {
            return "Chemical";
        }
    }
}
