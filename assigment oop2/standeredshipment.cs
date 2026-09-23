using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_oop2
{
    internal class standeredshipment : Shipment
    {
        public standeredshipment(string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion) : base(Trackingcode, Description, Weight, Delevaryfee, Destiontion)
        {
        }
    }
}
