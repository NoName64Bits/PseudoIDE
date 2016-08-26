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
    public partial class Form3 : Form
    {
        String codePpath = "";

        public Form3(String path)
        {
            codePpath = path;
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            editor.Text = File.ReadAllText(codePpath + ".cpp");   
        }

        private void textEditorControl1_Load(object sender, EventArgs e)
        {
            string dirc = Application.StartupPath + "/lang";
            FileSyntaxModeProvider fsmp;
            if (Directory.Exists(dirc))
            {
                fsmp = new FileSyntaxModeProvider(dirc);
                HighlightingManager.Manager.AddSyntaxModeFileProvider(fsmp);
                editor.SetHighlighting("C/C++");
            }
        }
    }
}
