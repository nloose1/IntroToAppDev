using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    //default for all classes is private
    //if an outside user of the class is to have access to the class then you need to make that class public
    public class FencePanel
    {
        //Properties
        //a property is a associated with a single peice of data 
        //a property has two sub components
        //    get: returns the data value to the outide user
        //    set: receive a data value and store it
        //a property does NOT have a parameter
        // the set of the property use a keyword (value) to hold the incoming data value

        //Auto implemented property deos NOT need a data memeber coded
        //the system will create an internal data storage element equivalent to the property return data type
        //no additional processing 
        //public double Height { get; set; } one could put data validation inside a property
        //Validation must be greater than 0.0 and less than or equal to 8.0
        //validation requires a fully implemented property
        private double _Height;
        public double Height
        {
            get
            {
                return _Height;
            }
            set
            {
                if(value > 0.0 && value <= 8.0)
                {
                    _Height = value;
                }
                else
                {
                    throw new Exception("Invalid height");
                }
            }
        } 

        public double Width { get; set; }

        //Fully implemented property
        //does NEED a data memeber coded, usually private
        //these properties usually contain additional logical processing
        //this processing could be validation, ensuring approptiate data stored


        //Example: the style of fence is a string that either has characters or no data (null)
        private string _Style;
        public string Style
        {
            get
            {
                return _Style;
            }
            set
            {
                //incoming data is located in the keyword value
                if (string.IsNullOrEmpty(value))
                {
                    _Style = null;
                }
                else
                {
                    _Style = value;
                }
            }
        }

        //handling nullable numberic
        //only two possibilities: a) a numeric or b)null
        public double? Price { get; set; }

        //Constructors
        //are used to place the instance of your class in a known state when it is created
        //if you DO NOT code a sonstructor in your class then the ststem will initialize your data memebers to their natural initialized state
        //if you DO code a cnstructor then you are responsible for all constructors within the class
        //a constructor does NOT have a return data type (rdt)  

        //default constructor
        //similar to the system constructor
        public FencePanel()
        {
            //optionally you could assign your own hard coded initial value 
            Height = 6.0;
            Width = 8.0;
            Price = null;
        }
    }
}
