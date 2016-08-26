using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ICSharpCode.TextEditor.Document;
using System.IO;
using System.Diagnostics;

namespace PseudoIDE
{
    public partial class Form1 : Form
    {
        Components cmps = new Components();
        Logic lg = new Logic();

        public Form1()
        {
            InitializeComponent();
        }

        private void editor_Load(object sender, EventArgs e)
        {
            string dirc = Application.StartupPath + "/lang";
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dirc))
            {
                fsmp = new FileSyntaxModeProvider(dirc);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                editor.SetHighlighting("PSC");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStripComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            infoRich.ReadOnly = true;
            gppRich.ReadOnly = true;

            Comms.info = infoRich;
            Comms.gpp = gppRich;

            cmps.appendTextToConsole(infoRich, "Initialization done!");
            cmps.appendTextToConsole(infoRich, "New project created!");
        }

        private void compileTool_Click(object sender, EventArgs e)
        {
            /*
                Build
                Build and run
                Generate C++ Code 
             */
            if (toolStripComboBox1.Text == "Generate C++ code")
            {
                lg.saveToTemp(editor.Text);
                cmps.appendTextToConsole(infoRich, "Starting parsing!");
                lg.Parse();
                cmps.appendTextToConsole(infoRich, "Parsing done!");
                cmps.appendTextToConsole(infoRich, "Opening C++ generated code ...");
                Form3 frm = new Form3(lg.currentTemp);
                frm.Show();
            }
            else
            {
                lg.saveToTemp(editor.Text);
                cmps.appendTextToConsole(infoRich, "Starting parsing!");
                lg.Parse();
                cmps.appendTextToConsole(infoRich, "Parsing done!");
                cmps.appendTextToConsole(infoRich, "Starting compiling the C++ code!");
                cmps.appendTextToConsole(infoRich, "Check the G++ Output tab for more info!");
                lg.Compile(cmps, tabControl1, gppTab);
                if (Comms.errors == 0 && toolStripComboBox1.Text == "Build and run")
                {
                    cmps.appendTextToConsole(infoRich, "Running the application!");
                    lg.Run();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFile.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFile.FileName, editor.Text);
            cmps.appendTextToConsole(Comms.info, "Succesfully saved code to: " + saveFile.FileName);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveAsFile.ShowDialog();
        }

        private void saveAsFile_FileOk(object sender, CancelEventArgs e)
        {
            File.WriteAllText(saveFile.FileName, editor.Text);
            cmps.appendTextToConsole(Comms.info, "Succesfully saved code to: " + saveFile.FileName);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFile.ShowDialog();
        }

        private void openFile_FileOk(object sender, CancelEventArgs e)
        {
            editor.Text = File.ReadAllText(openFile.FileName);
            cmps.appendTextToConsole(infoRich, "Project file " + openFile.FileName + " has been successfuly opened.");
        }

        private void runTool_Click(object sender, EventArgs e)
        {
            lg.Run();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            lg.cleanExit();
        }
    }

    public class Components
    {
        public Components()
        {

        }

        public void appendTextToConsole(RichTextBox txt, String text)
        {
            if (txt.Text != "") txt.Text += "\n";
            txt.Text += ("[" + DateTime.Now.ToString() + "] " + text);
            txt.SelectionStart = txt.Text.Length;
            txt.ScrollToCaret();
        }
    }

    public class Comms
    {
        public static RichTextBox info { get; set; }
        public static RichTextBox gpp { get; set; }
        public static int errors { get; set; }
    }

    public class Logic
    {
        public String currentTemp { get; set; }
        public String runnedTemps { get; set; }

        public Logic()
        {
            currentTemp = "";
            runnedTemps = "";
        }

        public String runShell(String command, Boolean wait)
        {
            Process shell = new Process();
            shell.StartInfo.CreateNoWindow = true;
            shell.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            shell.StartInfo.FileName = command;
            shell.StartInfo.UseShellExecute = false;
            shell.StartInfo.RedirectStandardError = true;
            shell.Start();
            if(wait) shell.WaitForExit();
            
            string text = shell.StandardError.ReadToEnd();

            return text;
        }

        public void saveToTemp(String text)
        {
            Components mp = new Components();
            if (currentTemp != "")
            {
                File.Delete(currentTemp);
                File.Delete(currentTemp + ".cpp");
            }

            String[] dateTimeStrings = DateTime.Now.ToString().Split(' ');
            String[] dateSplit = dateTimeStrings[0].Split('/');
            String[] timeSplit = dateTimeStrings[1].Split(':');
            String saving = Application.StartupPath + "\\temp\\tmp";
            for (int i = 0; i < dateSplit.Length; i++)
            {
                saving += "_";
                saving += dateSplit[i];
            }
            for (int i = 0; i < timeSplit.Length; i++)
            {
                saving += "_";
                saving += timeSplit[i];
            }
            saving += dateTimeStrings[2];
            saving += ".cde";
            File.WriteAllText(saving, text);
            currentTemp = saving;
            runnedTemps += saving;
            runnedTemps += "|";
        }

        public void Parse()
        {
            String path = currentTemp + "_parse.bat";
            String batContent = "\"" + Application.StartupPath + "\\compiler\\compiler.exe\" < \"" + currentTemp + "\" > \"" + currentTemp + ".cpp\"";
            File.WriteAllText(path, batContent);
            runShell(path, true);
            File.Delete(path);
        }

        public void Compile(Components cmp, TabControl tabCTRL, TabPage gppTabCTRL)
        {
            Comms.gpp.Text = "";
            String standardError = "The handle is invalid.";
            String path = currentTemp + "_compile.bat";
            File.Delete(currentTemp + ".exe");
            String batContent = "g++ -o \"" + currentTemp + ".exe\" \"" + currentTemp + ".cpp\"";
            File.WriteAllText(path, batContent);
            String gppOut = runShell(path, true);
            File.Delete(path);
            Comms.errors = 0;
            String[] errors = gppOut.Split('\n');
            foreach (String error in errors)
            {
                if (error != standardError)
                {
                    Comms.errors++;
                    if(Comms.errors > 6)
                        Comms.gpp.Text += error;
                }
            }

            Comms.errors -= 6;

            if (Comms.errors == 0)
            {
                cmp.appendTextToConsole(Comms.info, "Compiling done!");
            }
            else
            {
                tabCTRL.SelectedTab = gppTabCTRL;
                cmp.appendTextToConsole(Comms.info, "You've got " + Comms.errors.ToString() + " errors. Yaykes! :(");
                cmp.appendTextToConsole(Comms.info, "Compiation faild! Check your code and G++ Output tab for more info!");
                cmp.appendTextToConsole(Comms.info, "You can also try to use the Generate C++ Code compilation mode to debug!");
            }
        }

        public void Run()
        {
            Process.Start(currentTemp + ".exe");
        }

        public void cleanExit()
        {
            if (runnedTemps != "")
            {
                String[] temps = runnedTemps.Split('|');
                foreach (String temp in temps)
                {
                    if (temp != "" && temp != " " && temp != "|")
                    {
                        File.Delete(temp);
                        File.Delete(temp + ".exe");
                        File.Delete(temp + ".cpp");
                    }
                }
            }
        }
    }
}
