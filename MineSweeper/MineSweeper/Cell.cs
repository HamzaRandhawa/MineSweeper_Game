using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeper
{
    class Cell : Button
    {
        public int ri,ci;
        public int value;
        public bool Is_open;



        public Cell(int r, int c, int w, int h, int d)
        {
            //iska yeh matlab to nahi
            ri = r;
            ci = c;

            value = 0;
            Is_open = false;

            this.Width = w / d - 10 ;
            this.Height = h / d - 10 ;



            //            this.Margin.Equals

            // this.Margin = (0,0,0,0);

            this.Margin.Horizontal.Equals(0);

            this.Margin.Horizontal.Equals(0);
            this.Margin.Size.Equals(0);

            this.Padding.All.Equals(0);
           
           // Padding.Left = 0;

  //          this.Margin = new margin(0,0,0,0);

            //this.SetAutoSizeMode.Margin=(0,0,0,0);
        }
    }
}
