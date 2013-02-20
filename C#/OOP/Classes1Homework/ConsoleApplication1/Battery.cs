using System;
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
                if (value < 0) this.mAh = 0;
                else this.mAh = value;
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
                if (value == null ||value.Length > 3) this.model = value;
                else this.model = null;
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
                if (value < 0) this.hTalk = 0;
                else this.hTalk = value;
            }
        }
        public int HIdle
        {
            get { return this.hIdle; }
            set 
            {
                if (value < 0) this.hIdle = 0;
                else this.hIdle = value;
            }
        }


        public Battery()
        {}
        public Battery(string model) :this(model,0,0)
        {}
        public Battery(int hIdle,int hTalk) :this("",hIdle,hTalk)
        {}
        public Battery(string model,int hIdle, int hTalk ) :this(model,hIdle,hTalk,0,BatteryType.Unknown)
        {}
        public Battery(string model, int hIdle, int hTalk, int mAh, BatteryType type) 
        {
            this.MAh = mAh;
            this.Type = type;
            this.HIdle = hIdle;
            this.HTalk = hTalk;
            this.Model = model;
        }
    }
    enum BatteryType
    {
        Unknown, Li_ion, NiMH, Nicd, Li_Poly
    };
}
