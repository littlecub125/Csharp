using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CombinedFunction
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Open file and save file in .xls form
        /// </summary>
        /// begin ///
        string fn, fn2;
        private void button1_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.ShowDialog();
          
            fn = this.openFileDialog1.FileName;
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
                
            Console.WriteLine("please put new file directory");
            this.saveFileDialog1.ShowDialog();
            fn2 = this.saveFileDialog1.FileName;
            System.IO.File.Copy(fn, fn2+".xls", true);
        }

        /// end ///
        

    }
}
