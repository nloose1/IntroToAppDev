using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPsReview
{
    class Program
    {
        //assuming you kno whow to obtain user entered data
        static void Main(string[] args)
        {
            double height = 6.5;
            double width = 8.0;
            double linerarlength = 135.0;
            string style = "neighboor fiendly: spruce";
            double price = 108.00;

            //store panel data
            //declare storage area for fence data

            //create a non static instace of a class
            //use the new command to create the class instance
            // the new command refererences the class constructor
            FencePanel panelInfo = new FencePanel(height, width, style, price); //greedy

            //obtain and store gate data
            FenceGate gateInfo;
            List<FenceGate> gateList = new List<FenceGate>();

            //Assume looping to obtain all gate data
            //each loop is one gate
            //pass 1
            height = 6.25;
            width = 4.0;
            style = "Neighboor friendly 1/2 picket : spruce";
            price = 86.45;
            gateInfo = new FenceGate(); //default constructor OR system constructor

            //name of the instance followed by the dot opperator then is followed by the property name
            gateInfo.GateHeight = height; //set of the property
            gateInfo.GatePrice = price;
            gateInfo.GateStyle = style;
            gateInfo.GateWidth = width;
            gateList.Add(gateInfo);
            
            //Pass 2
            height = 6.25;
            width = 3.0;
            style = "Neighboor friendly: spruce";
            price = 72.95;
            gateInfo = new FenceGate(height, width, style, price);
            gateList.Add(gateInfo);

            //assume end of looping

            //create estimate
            Estimate theEstimate = new Estimate();
            theEstimate.LinearLength = linerarlength;
            theEstimate.Panel = panelInfo;
            theEstimate.Gates = gateList;
            theEstimate.CalculateTotalPrice();

            //client wishes a output of the estimate
            Console.WriteLine("the fence is to be a " + theEstimate.Panel.Style + " style");
            Console.WriteLine("The total cost of the estimate is {0:0.00}", theEstimate.TotalPrice); //get
            Console.WriteLine("Number of requred panels is {0}", theEstimate.Panel.EstimatedNumberOfPanels(theEstimate.LinearLength));
            Console.WriteLine("The number of gates is {0}", theEstimate.Gates.Count);
            double fenceArea = theEstimate.Panel.TotalArea(theEstimate.LinearLength);
            foreach(var item in theEstimate.Gates)
            {
                fenceArea += item.GateArea(); //item represents a single Gate instance in the colection
            }
            Console.WriteLine(string.Format("Total fence surface area {0:0.0}", fenceArea * 2));

            Console.ReadLine();
        }
    }
}
