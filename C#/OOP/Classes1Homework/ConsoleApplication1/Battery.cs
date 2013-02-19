using System;
using System.Collections.Generic;
using System.Linq;


namespace Classes1Homework
{  
    class Battery
    {
        private int hIdle;
        private int hTalk;
        private string model;
        private int mAh;
        private BatteryType type;

        public BatteryType Type
        {
            get
            {
                return this.type;
            }
            set
            {
                this.type = value;
            }
        }
        public int MAh
        {
            get
            {
                return this.mAh;
            }
            set
            {
                this.mAh = value;
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
        public int HTalk
        {
            get
            {
                return this.hTalk;
            }
            set
            {
                this.hTalk = value;
            }
        }
        public int HIdle
        {
            get { return hIdle; }
            set { hIdle = value; }
        }


        public Battery()
        {
            this.hIdle = 0;
            this.hTalk = 0;
            this.model = null;
            this.mAh = 0;
            this.type = BatteryType.Unknown;
        }
        public Battery(string model)
        {
            this.hIdle = 0;
            this.hTalk = 0;
            this.model = model;
            this.mAh = 0;
            this.type = BatteryType.Unknown;
        }
        public Battery(int hIdle,int hTalk)
        {
            this.hIdle = hIdle;
            this.hTalk = hTalk;
            this.model = null;
            this.mAh = 0;
            this.type = BatteryType.Unknown;
        }
        public Battery(int hIdle, int hTalk, string model)
        {
            this.hIdle = hIdle;
            this.hTalk = hTalk;
            this.model = model;
            this.mAh = 0;
            this.type = BatteryType.Unknown;
        }
        public Battery(int hIdle, int hTalk, string model, int mAh, BatteryType type)
        {
            this.hIdle = hIdle;
            this.hTalk = hTalk;
            this.model = model;
            this.mAh = mAh;
            this.type = type;
        }
    }
    enum BatteryType
    {
        Li_ion, NiMH, Nicd, Li_Poly, Unknown
    };
}
