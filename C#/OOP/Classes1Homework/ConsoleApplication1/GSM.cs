using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes1Homework
{
    class GSM
    {
        private string manufacturer;
        private string model;
        private decimal price;
        private string owner;
        private Battery battery;
        private Display display;
        private static string IPhone4S = "IPhone 4S Info";

        public Display Display
        {
            get
            {
                return this.display;
            }
            set
            {
                this.display = value;
            }
        }
        public Battery Battery
        {
            get
            {
                return this.battery;
            }
            set
            {
                this.battery = value;
            }
        }
        public string Owner
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }
        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }
        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }
        public string Manufacturer
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }
        public static string IPhone4S1
        {
            get { return GSM.IPhone4S; }
            set { GSM.IPhone4S = value; }
        }

        public GSM(string manufacturer, string model)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = 0.0m;
            this.owner = null;
            this.battery = new Battery();
            this.display = new Display();
        }
        public GSM(string manufacturer, string model, decimal price)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = null;
            this.battery = new Battery();
            this.display = new Display();
        }
        public GSM(string manufacturer, string model, decimal price, string owner)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = new Battery();
            this.display = new Display();
        }
        public GSM(string manufacturer, string model, decimal price, string owner, Battery battery, Display display)
        {
            this.manufacturer = manufacturer;
            this.model = model;
            this.price = price;
            this.owner = owner;
            this.battery = battery;
            this.display = display;
        }

        public override string ToString()
        {
            string result, batteryInfo, displayInfo, touchScreeen;
            if (this.display.Touch) { touchScreeen = "Yes"; }
            else { touchScreeen = "No"; }

            batteryInfo = String.Format("Battery: {0} {1} mAh \nStandBy:{2} min, Call Time:{3} min\n", this.battery.Type, this.battery.MAh, this.battery.HIdle, this.battery.HTalk);
            displayInfo = String.Format("Display size: {0}\", Colors {1}\nResolution: {2}, DPI {3}, Touchscreen: {4}\n",
                this.display.DisplaySize, this.display.Colors, this.display.Resolution, this.display.Dpi, touchScreeen);

            result = String.Format("Manufacturer: {0}, Model: {1} \nPrice: {2:C} \nOwner: {3}\n", this.manufacturer, this.model, this.price, this.owner);
            return result + batteryInfo + displayInfo;
        }

    }
}
