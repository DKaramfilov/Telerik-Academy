using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                this.dpi = value;
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
                this.resolution = value;
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
                this.colors = value;
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
                this.displaySize = value;
            }
        }


        public Display()
        {
            this.displaySize = 0;
            this.colors = null;
            this.resolution = null;
            this.dpi = 0;
            this.touch = false;
        }
        public Display(float displaySize)
        {
            this.displaySize = displaySize;
            this.colors = null;
            this.resolution = null;
            this.dpi = 0;
            this.touch = false;
        }
        public Display(float displaySize, string colors)
        {
            this.displaySize = displaySize;
            this.colors = colors;
            this.resolution = null;
            this.dpi = 0;
            this.touch = false;
        }
        public Display(float displaySize, string colors, string resolution)
        {
            this.displaySize = displaySize;
            this.colors = colors;
            this.resolution = resolution;
            this.dpi = 0;
            this.touch = false;
        }
        public Display(float displaySize, string colors, string resolution, int dpi, bool touch)
        {
            this.displaySize = displaySize;
            this.colors = colors;
            this.resolution = resolution;
            this.dpi = dpi;
            this.touch = touch;
        }
    }
}
