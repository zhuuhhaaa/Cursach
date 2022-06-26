using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace WpfApp1
{
    [DataContract]
    public class Vehicle
    {
        public Vehicle() { hyperlinkText = "More..."; }
        [DataMember]
        private int id;
        [DataMember]
        private string brand;
        [DataMember]
        private string model;
        [DataMember]
        private string color;
        [DataMember]
        private string yearOfIssue;
        [DataMember]
        private string typeOfEngine;
        [DataMember]
        private string powerOfEngine;
        [DataMember]
        private string sizeOfEngine;
        [DataMember]
        private string hyperlinkText;
        [DataMember]
        private string imageAdr;
        [DataMember]
        private string count;
        [DataMember]
        private string cost;
        [DataMember]
        private string condition;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public string Count
        {
            get { return count; }
            set { count = value; }
        }
        public string Cost
        {
            get { return cost; }
            set { cost = value; }
        }
        public string ImageAdr
        {
            get { return imageAdr; }
            set { imageAdr = value; }
        }
        public string TypeOfEngine
        {
            get { return typeOfEngine; }
            set { typeOfEngine = value; }
        }
        public string PowerOfEngine
        {
            get { return powerOfEngine; }
            set { powerOfEngine = value; }
        }
        public string SizeOfEngine
        {
            get { return sizeOfEngine; }
            set { sizeOfEngine = value; }
        }
        public string YearOfIssue
        {
            get { return yearOfIssue; }
            set { yearOfIssue = value; }
        }
        public string HyperlinkText
        {
            get { return hyperlinkText; }
            set { hyperlinkText = value; }
        }
        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }

}
}
