using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class FenceGate
    {
        private double _GateHeight;
        public double GateHeight
        {
            get
            {
                return _GateHeight;
            }
            set
            {
                if (value > 0.0 && value <= 8.0)
                {
                    _GateHeight = value;
                }
                else
                {
                    throw new Exception("Invalid height");
                }
            }
        }

        public double GateWidth { get; set; }

        private string _GateStyle;
        public string GateStyle
        {
            get
            {
                return _GateStyle;
            }
            set
            {
                //incoming data is located in the keyword value
                if (string.IsNullOrEmpty(value))
                {
                    _GateStyle = null;
                }
                else
                {
                    _GateStyle = value;
                }
            }
        }

        public double GatePrice { get; set; }

        public FenceGate()
        {
            //optionally you could assign your own hard coded initial value 
            GateHeight = 6.0;
            GateWidth = 4.0;
            GatePrice = 0.0;
        }

        public FenceGate(double gateheight, double gatewidth, string gatestyle, double gateprice)
        {
            GateHeight = gateheight;
            GateWidth = gatewidth;
            GateStyle = gatestyle;
            GatePrice = gateprice;
        }

        public double GateArea()
        {
            return GateHeight * GateWidth;
        }

    }
}
