using SimpleEditor.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleEditor
{
    public partial class MainWindow : Form
    {
        public static int counter = 0;

        public static string filePath;
        public static string fileName;
        public static string editorTitle;

        public static Icon newFileIcon = Resources.new_file;
        public static Icon editFileIcon = Resources.edit_file;
        public static Icon saveFileIcon = Resources.save;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            CreateNewFile();
        }

        #region MenuStripItem Functions
        private void newFileTSMI_Click(object sender, EventArgs e)
        {
            CreateNewFile();
        }

        private void newWindowTSMI_Click(object sender, EventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
        }

        private void openFileTSMI_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void saveFileTSMI_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void saveFileAsTSMI_Click(object sender, EventArgs e)
        {
            SaveFileAs();
        }

        private void printSMI_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            printDialog.ShowDialog();
        }

        private void closeTSMI_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion MenuStripItem Functions

        #region Functions 

        public void CreateNewFile()
        {
            fileName = "Unbenannt";
            filePath = "";
            editorTitle = fileName + " - Editor";
            editorTxt.Text = "";
            this.Icon = newFileIcon;
            this.Text = editorTitle;

        }

        public void SaveFile()
        {
            if (filePath != "")
            {
                StreamWriter sw = new StreamWriter(filePath);
                sw.WriteLine(editorTxt.Text);
                sw.Close();
                timer.Start();
            }
            else
            {
                SaveFileAs();
            }
        }

        public void OpenFile()
        {
            OpenFileDialog of = new OpenFileDialog();
            of.ShowDialog();

            filePath = of.FileName;
            fileName = of.SafeFileName;
            StreamReader sr = new StreamReader(filePath);
            editorTxt.Text = sr.ReadToEnd();
            sr.Close();

            this.Icon = editFileIcon; 
            this.Text = fileName + " - Editor";
            
        }

        public void SaveFileAs()
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.Filter = "Text File | *.txt";
            sf.ShowDialog();
            filePath = sf.FileName;
            fileName = sf.FileNames[0];

            StreamWriter sw = new StreamWriter(filePath);
            sw.WriteLine(editorTxt.Text);
            sw.Close();

            timer.Start();
        }


        #endregion Functions

        private void timer_Tick(object sender, EventArgs e)
        {
            if (counter > 3)
            {
                this.Icon = editFileIcon;
                this.Text = fileName + " - Editor";
                
                counter = 0;
                timer.Stop();
            }
            else
            {
                this.Icon = saveFileIcon;
                this.Text = "Saved!";
                counter++;
            }
            
        }
    }
}
