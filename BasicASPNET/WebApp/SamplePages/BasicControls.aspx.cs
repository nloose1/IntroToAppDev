using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp.SamplePages
{
    public partial class BasicControls : System.Web.UI.Page
    {
        //global variable available to the entire page and will temporarily represent data fromt he database
        public static List<DDLClass> DataCollection;
        protected void Page_Load(object sender, EventArgs e)
        {
            //this event will happen each and every time your page is executed
            //this event will bhappen before any of you control events happen
            //this is a great place to enitiallize items (controls) that are common to many events and need to be done every time

            //example: old messages should be cleared out on every pass. you can empty the message label control under each event OR do it once here for all events
            MessageLabel.Text = "";

            //this is a great place to do first time initialization of controls
            //(similar to the else side of the IsPost from Razor)
            if(!Page.IsPostBack)//(Page.IsPostBack == false)
            {
                //load the DDL of the first pass
                //create an instance of a collection (List<T>)(T == class called DDLCLass)
                //create four instances of DDL class for the collection
                //place the collection into the DDL
                DataCollection = new List<DDLClass>();
                DataCollection.Add(new DDLClass(1, "COMP1008"));
                DataCollection.Add(new DDLClass(2, "CPSC1517"));
                DataCollection.Add(new DDLClass(3, "DMIT1508"));
                DataCollection.Add(new DDLClass(4, "DMIT2018"));

                //sort the data collection for the ddl by program course name
                //syntax collectionname.Sort((x,y) => x.fieldname.CompareTo(y.fieldname))
                //collectionname is there your List<T> resides
                //(x,y) represents any two values (records) in your collection at any point in time
                //=> (lamda) can be thought of as "do the following to x and y" (delegate)
                //our delegate for lamda is comparing x and y on the fieldname
                //x CompareTo y is an ascending sort
                //y CompareTo x is a descending sort
                DataCollection.Sort((x, y) => x.DisplayField.CompareTo(y.DisplayField));



                //steps in loading your DDL
                //assume that the DataCollection is actually database data
                //A) assign the data source to the control
                CollectionChoiceList.DataSource = DataCollection;//just the data

                //<option value =theValue> theDisplay </option>
                //B) indicate the display field to the controller
                CollectionChoiceList.DataTextField = "DisplayField"; //non object style
                //C) indicate the calue field to the controller
                CollectionChoiceList.DataTextField = nameof(DDLClass.DisplayField); //object style
                //D) physically bind the data to the control
                CollectionChoiceList.DataBind();

                //optional promp line 
                CollectionChoiceList.Items.Insert(0, "Select...");
            }

        }

        protected void SubmitNumberChoice_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "You pressed the submit button";

            //to grab the contents of a control will depend on the control access tyoe
            //for TextBox, Label, Literal use .Text
            //for lists (RadioButtonList, DropDownList) you may use one of
            //  .SelectedValue (best), .SelectedIndex (physically), .SelectedItem.Test
            //for CheckBox use .Checked

            //for the most part,all data from a control returns a STRING
            //Except for boolean type controls

            //since the control (object) is on the "RIGHT" side of an assignment statement the object Property uses the GET
            string submitchoice = NumberChoice.Text;

            if (string.IsNullOrEmpty(submitchoice))
            {
                //"LEFT" side uses the properties set 
                MessageLabel.Text = "You did not enter a value for your program choice";
                ResetFields();
            }
            else
            {
                //you can set the radio buttonlist choice by either using
                // .SelectedValue or .SelectedIndex or .SelectedItem.Text
                //it is best to use .SelectedValue
                ChoiceList.SelectedValue = submitchoice;

                //place a check mark in the checkbox if the chosen course is a program
                if(submitchoice.Equals("2") || submitchoice.Equals("4"))
                {
                    ProgrammingCourseActive.Checked = true;
                    AlterLabel.ForeColor = System.Drawing.Color.BlueViolet;
                }
                else
                {
                    ProgrammingCourseActive.Checked = false;
                    AlterLabel.ForeColor = System.Drawing.Color.Black;
                }

                //DDL can the positioned using 
                // .SelectedValue or .SelectedIndex or .SelectedItem.Text
                //it is best to use .SelectedValue
                CollectionChoiceList.SelectedValue = submitchoice;

                //demonstration of what is obtained by the different .Selectedxxxxx
                //.SelectedValue returns the value of the DataValueField
                //.SelectedIndex returns the value of the selected row
                //.SelectedItem.Text returns the value of the DataDisplayField
                DisplayDataRO.Text = CollectionChoiceList.SelectedItem.Text + " at index" + CollectionChoiceList.SelectedIndex + " having a value of " + CollectionChoiceList.SelectedValue;
            }
        }

        protected void CollectionSubmit_Click(object sender, EventArgs e)
        {
            MessageLabel.Text = "You pressed the link button Selection Submit";
        }

        protected void ResetFields()
        {
            NumberChoice.Text = "";
            ChoiceList.ClearSelection();
            //ChoiceList.SelectedIndex = -1; //index -1 will not be found, optional way
            CollectionChoiceList.ClearSelection();
            ProgrammingCourseActive.Checked = false;
            AlterLabel.ForeColor = System.Drawing.Color.Black;
        }
    }
}