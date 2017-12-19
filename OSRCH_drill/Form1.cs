using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSRCH_drill
{
    public partial class Form1 : Form
    {
        private List<Command> commands; 
        private Drill drill = Drill.Instance;

        public Form1()
        {
            InitializeComponent();
            drill.positionX = 0;
            drill.positionY = 0;
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
                    Command command = new Command();
                    string comm = str.Replace(">", "").Replace(@"\n", "");
                    string param = Regex.Match(str, @"\[(.*?)\]").Value.Replace("[", "").Replace("]","");
                    comm = comm.Substring(0, comm.IndexOf("["));
                    command.CommandName = comm;
                    command.Parameter = param;
                }
                sr.Close();
            }
        }
    }
}
