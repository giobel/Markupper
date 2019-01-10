using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {

        private FileInfo[] Files { get; set; }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void Form1_Load_1(object sender, EventArgs e)
        {

        }


        private FileInfo[] GetDirectoryContent(string Folder, string FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            return dinfo.GetFiles(FileType);
            
        }

        private void markupFolder_Leave(object sender, EventArgs e)
        {
            try
            {
                Files = GetDirectoryContent(markupFolder.Text, "*.pdf");

                foreach (FileInfo file in Files)
                {
                    this.listBox.Items.Add(Path.GetFileNameWithoutExtension(file.Name));
                }
            }
            catch
            {
                markupFolder.Text = "Please insert a markup filepath";
                this.listBox.Items.Clear();
            }


        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            string selected = this.listBox.GetItemText(this.listBox.SelectedItem);
            
            if (selected.Length == 0)
            {
                MessageBox.Show("Please select a file to be opened.");
            }
            else
            {
                foreach (FileInfo file in Files)
                {
                    if (Path.GetFileNameWithoutExtension(file.Name) == selected)
                    {
                        try
                        {
                            string newName = string.Format(@"{0}\{1}_{2}.pdf", file.Directory.FullName, selected, this.textBoxInitials.Text);
                            file.MoveTo(newName);
                            Process.Start(newName);
                            this.listBox.Items.Remove(selected);
                            this.listBoxWip.Items.Add(string.Format("{0}_{1}.pdf", selected, this.textBoxInitials.Text));
                        }
                        catch
                        {
                            MessageBox.Show("The file can't be renamed." + Environment.NewLine + "Please check that the pdf is not open.");
                        }

                    }

                }
            }

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (listBoxWip.Items.Count == 0)
            {
                MessageBox.Show("What are you trying to do does not make any sense.");
            }
            else
            {
                foreach (FileInfo file in Files)
                {
                    if (this.listBoxWip.Items.Contains(file.Name))
                    {
                        try
                        {
                            File.Move(file.FullName, string.Format(@"{0}\{1}", this.completedFolder.Text, file.Name));
                            string removeFile = string.Format("{0}.pdf", Path.GetFileNameWithoutExtension(file.Name));
                            this.listBoxWip.Items.Remove(removeFile);
                        }
                        catch
                        {
                            MessageBox.Show("The file cannot be moved to the destination folder." + Environment.NewLine + "Please check that the file is closed.");
                        }
                    }
                }
            }
            
        }
    }
}
