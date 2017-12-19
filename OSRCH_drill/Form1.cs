using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSRCH_drill
{
    public partial class Form1 : Form
    {
        private Dictionary<string, string> commands; 
        public Form1()
        {
            InitializeComponent();
            
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                   System.IO.StreamReader(openFileDialog1.FileName);
                string content = sr.ReadToEnd();
                string[] split = content.Split(new[] {'>'}, StringSplitOptions.RemoveEmptyEntries);
                foreach (var str in split)
                {
                    
                }
                //MessageBox.Show(content);
                sr.Close();
            }
        }
    }
}
