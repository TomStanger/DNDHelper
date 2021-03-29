using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonMasterHelper
{
    public partial class FormNotes : Form
    {
        public FormNotes()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {


            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dialog.FilterIndex = 2;
                dialog.RestoreDirectory = true;

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    // Can use dialog.FileName
                    using (Stream stream = dialog.OpenFile())
                    {

                        //  File.WriteAllText("C:\\")
                     
                        //Use StreamWriter class.
                        //StreamWriter sw = new StreamWriter("C:\\Users\\Toms-PC\\Documents\\DungeonMasterHelper\\Notes\\SessionNotes.txt");
                        StreamWriter file = new System.IO.StreamWriter(dialog.FileName.ToString());
                       // StreamWriter sw = new StreamWriter("E:\\test.txt");
                        //Use write method to write the text
                        file.Write(txtPage1.Text);

                        //always close your stream
                        file.Close();
                    }
                }
            }
        }

        

        private void txtPage1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // txtPage1.Text = File.ReadAllText(openFileDialog1.FileName);
            // https://stackoverflow.com/questions/13900441/c-sharp-read-txt-file-into-textbox
        }
    }
}
