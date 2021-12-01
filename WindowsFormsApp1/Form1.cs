using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        abstract class Komplektyushie<artikyl>
        {
            public int price;
            public string godvipysk;
            public artikyl artikyll;
            public abstract void Display(ListBox listBox1);
            public Komplektyushie(int pricee, string godvipyskk, artikyl artik)
            {
                price = pricee;
                godvipysk = godvipyskk;
                artikyll = artik;
            }
             abstract class CPU : Komplektyushie<string>
            {
                private static string artik;
                protected int mhz;
                protected int cores;
                protected int streams;
                public  CPU (int pricee, string godvipyskk, int mhzz, int coress, int streamss) : base(pricee, godvipyskk, artik)
                {
                    mhz = mhzz;
                    cores = coress;
                    streams = streamss;
            }
                    public abstract override void Display(ListBox listBox1);

            }
           class video : Komplektyushie
            {
                private int mhzCPU;
                private string proizv;
                private int memory;
                private extern  video (int mhzCPUU, string proizvv, int memoryy)
            }
             

           






        }
    }
}
