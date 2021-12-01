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
            public Komplektyushie(int pricee, string godvipyskk, artikyl art)
            {
                price = pricee;
                godvipysk = godvipyskk;
                artikyll = art;
            }
             class CPU : Komplektyushie
            {
                public int mhz;
                public int cores;
                public int streams;
                public override void Display(ListBox listBox1);
            } 



           
            

        }
    }
}
