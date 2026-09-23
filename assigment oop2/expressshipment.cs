using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assigment_oop2
{
    internal class expressshipment : Shipment
    {
        private decimal _extrafee;
        public decimal Extrafee
        {
            get
            {
                return _extrafee;
            }
            set
            {
                if (value>=0)
                {
                    _extrafee= value;
                }
            }
        }
        public expressshipment(decimal extrafee,string Trackingcode, string Description, decimal Weight, decimal Delevaryfee, Delevaryadress Destiontion) : base(Trackingcode, Description, Weight, Delevaryfee, Destiontion)
        {
            extrafee = Extrafee;
        }
        public override decimal estimatedcost 
        {
            get
            {
                return delevaryfee + (weight * 5) + Extrafee;
            }
        }
    }

}
