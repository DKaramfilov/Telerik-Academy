using System;
using System.Collections.Generic;
using System.Linq;

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
        private static string iPhone4S = "IPhone 4S Info";
        List<Call> callHistroy = new List<Call>();


        public static string IPhone4S
        {
            get
            {
                return iPhone4S;
            }
            set
            {
                if (value == null || value.Length >= 3) iPhone4S = value;
                else iPhone4S = null;
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
                if (value == null || value.Length >= 3) this.manufacturer = value;
                else this.Manufacturer = null;
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
                if (value == null || value.Length >= 3) this.owner = value;
                else this.owner = null;
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
                if (value < 3) value = 0m;
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
                if (value.Length < 3) value = null;
                this.model = value;
            }
        }
        public List<Call> CallHistroy
        {
            get
            {
                return this.callHistroy;
            }
            set
            {
                this.callHistroy = value;
            }
        }
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


        public GSM(string manufacturer, string model)
            : this(manufacturer, model, 0m)
        { }
        public GSM(string manufacturer, string model, decimal price)
            : this(manufacturer, model, price, null)
        { }
        public GSM(string manufacturer, string model, decimal price, string owner)
            : this(manufacturer, model, price, owner, new Battery(), new Display())
        { }
        public GSM(string manufacturer, string model, decimal price, string owner, Battery battery, Display display)
        {
            this.Manufacturer = manufacturer;
            this.Model = model;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
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
        public void AddCall(Call c)
        {
            callHistroy.Add(c);
        }
        public void RemoveCall(Call c)
        {
            callHistroy.Remove(c);
        }
        public void ClearAllCalls()
        {
            callHistroy.Clear();
        }
        public decimal CalculateCallsCosts(decimal pricePerMinute)
        {
            int overalDuration = 0;
            foreach (var call in callHistroy)
            {
                overalDuration += call.Duration;
            }
            return ((decimal)overalDuration / 60m) * pricePerMinute;
        }
        public void PrintCallsHistory()
        {
            foreach (var call in CallHistroy)
            {
                Console.WriteLine("Phone numbe:r {0}, Duration : {1} seconds\nDialed At: {2}\n",
                                    call.DialedNumber, call.Duration, call.DialedAt);
            }
        }
    }
}
