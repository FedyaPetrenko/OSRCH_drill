using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSRCH_drill
{
    public partial class Form1 : Form
    {
        private List<Command> commands;
        private Drill drill = Drill.Instance;

        private Bitmap headLeft;
        private Bitmap headRight;
        private Bitmap railLeft;
        private Bitmap railRight;

        private bool CanWork = true;

        private readonly int _headLeftPositionX = 182;
        private readonly int _headLeftPositionY = 184;

        private readonly int _railLeftPositionX = 134;
        private readonly int _railLeftPositionY = 307;

        private readonly int _headRightPositionX = 88;
        private readonly int _headRightPositionY = 184;

        private readonly int _railRightPositionX = 40;
        private readonly int _railRightPositionY = 307;

        public Form1()
        {
            InitializeComponent();
            drill.positionX = 0;
            drill.positionY = 0;
            drill.positionZ = 0;

            headLeft = new Bitmap(drill.ActiveBit.Image);
            railLeft = new Bitmap("Images/rail.jpg");

            headRight = new Bitmap(drill.ActiveBit.Image);
            railRight = new Bitmap("Images/rail.jpg");

            commands = new List<Command>();
            backgroundWorker.DoWork += BackgroundWorker_DoWork;

            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void BackgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            RunComands();
        }

        private void loadBtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.InitialDirectory = Directory.GetCurrentDirectory();
                ofd.Filter = "*.txt|*.txt;";
                ofd.AddExtension = true;
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamReader sr = new StreamReader(ofd.FileName))
                    {
                        string content = sr.ReadToEnd();
                        string[] split = content.Split(new[] { '>' }, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var str in split)
                        {
                            Command command = new Command();
                            string comm = str.Replace(">", "").Replace(@"\n", "");
                            string param = Regex.Match(str, @"\[(.*?)\]").Value.Replace("[", "").Replace("]", "");
                            comm = comm.Substring(0, comm.IndexOf("["));
                            command.Name = comm;

                            if (!string.IsNullOrEmpty(param))
                                command.Parameter = Convert.ToInt32(param);

                            commands.Add(command);
                        }
                        sr.Close();
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WriteLogMessage($"LaunchMachine");
        }

        private void poweroffBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mainPictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(headLeft, _headLeftPositionX, _headLeftPositionY + drill.positionX, 45, 85);
            e.Graphics.DrawImage(railLeft, _railLeftPositionX + drill.positionY, _railLeftPositionY, 220, 30);

        }

        private void profilePictureBox_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(headRight, _headRightPositionX, _headRightPositionY + drill.positionX, 45, 85);
            e.Graphics.DrawImage(railRight, _railRightPositionX + drill.positionZ, _railRightPositionY, 144, 30);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            CanWork = true;

            backgroundWorker.RunWorkerAsync();
        }

        private void RunComands()
        {
            foreach (var command in commands)
            {
                if (CanWork)
                {
                    try
                    {
                        WriteLogMessage($"CommandName: {command.Name}, Parameter: {command.Parameter}");

                        var method = typeof(Drill).GetMethod(command.Name);
                        if (method.GetParameters() != null && method.GetParameters().Length > 0)
                        {
                            if (method.ReturnParameter != null)
                            {
                                var result = method.Invoke(drill, new object[] { command.Parameter });
                                WriteLogMessage(result.ToString());
                            }
                            else
                            {
                                method.Invoke(drill, new object[] { command.Parameter });
                            }
                        }
                        else
                        {
                            var result = method.Invoke(drill, null);
                            WriteLogMessage(result.ToString());
                        }

                        if (command.Name == "ChangeDrill")
                        {
                            headLeft = new Bitmap(drill.ActiveBit.Image);
                            headRight = new Bitmap(drill.ActiveBit.Image);
                        }

                        Thread.Sleep(200);
                        mainPictureBox.Refresh();
                        profilePictureBox.Refresh();
                    }
                    catch (Exception ex)
                    {
                        WriteLogMessage($"Error!!! Wrong command! CommandName: {command.Name}, Parameter: {command.Parameter}");
                        break;
                    }
                }
                else
                {
                    drill.positionX = 0;
                    drill.positionY = 0;
                    drill.positionZ = 0;

                    CanWork = true;
                    mainPictureBox.Refresh();
                    profilePictureBox.Refresh();

                    break;
                }
            }
            commands = new List<Command>();
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            CanWork = false;
            WriteLogMessage($"StopMachine");
            drill.positionX = 0;
            drill.positionY = 0;
            drill.positionZ = 0;
            mainPictureBox.Refresh();
            profilePictureBox.Refresh();
        }

        private void WriteLogMessage(string message)
        {
            richTextBox1.Text += $"[{DateTime.Now.ToString()}] {message};\r\n";
        }

        private void resetLogBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void overheatBtn_Click(object sender, EventArgs e)
        {
            CanWork = false;
            WriteLogMessage($"Overheating");
            WriteLogMessage($"StopMachine");
        }

        private void overheightBtn_Click(object sender, EventArgs e)
        {
            CanWork = false;
            WriteLogMessage($"OverHeight");
            WriteLogMessage($"StopMachine");
        }

        private void wearoutBtn_Click(object sender, EventArgs e)
        {
            CanWork = false;
            WriteLogMessage($"Wearout");
            WriteLogMessage($"StopMachine");
        }

        private void saveLogBtn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "*.txt|*.txt;";
                sfd.InitialDirectory = Directory.GetCurrentDirectory();
                sfd.AddExtension = true;
                sfd.FileName = "Log " + DateTime.Now.ToString("yyyy-dd-M--HH-mm-ss");
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(sfd.FileName, FileMode.Create))
                    {
                        using (StreamWriter writer = new StreamWriter(fs, Encoding.Default))
                        {
                            writer.Write(richTextBox1.Text);

                            writer.Close();
                        }
                        fs.Close();
                    }

                }
            }
        }
    }
}
