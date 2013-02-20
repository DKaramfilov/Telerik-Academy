using System;
using System.Linq;

namespace Classes1Homework
{
    class Display
    {
        private float displaySize;
        private string colors;
        private string resolution;
        private int dpi;
        private bool touch;

        public bool Touch
        {
            get
            {
                return this.touch;
            }
            set
            {
                this.touch = value;
            }
        }
        public int Dpi
        {
            get
            {
                return this.dpi;
            }
            set
            {
                if (value < 0) this.dpi = 0;
                else this.dpi = value;
            }
        }
        public string Resolution
        {
            get
            {
                return this.resolution;
            }
            set
            {
                if (value == null || value.Length > 3) this.resolution = value;
                else this.resolution = null;
            }
        }
        public string Colors
        {
            get
            {
                return this.colors;
            }
            set
            {
                if (value == null || value.Length > 3) this.colors = value;
                else this.colors = null;
            }
        }
        public float DisplaySize
        {
            get
            {
                return this.displaySize;
            }
            set
            {
                if (value < 0) this.displaySize = 0.0f;
                else this.displaySize = value;
            }
        }


        public Display()
        {}
        public Display(float displaySize): this(displaySize,null)
        {}
        public Display(float displaySize, string colors):this(displaySize,colors,null)
        {}
        public Display(float displaySize, string colors, string resolution):this(displaySize,colors,resolution,0,false)
        {}
        public Display(float displaySize, string colors, string resolution, int dpi, bool touch)
        {
            this.DisplaySize = displaySize;
            this.Colors = colors;
            this.Resolution = resolution;
            this.Dpi = dpi;
            this.Touch = touch;
        }
    }
}
