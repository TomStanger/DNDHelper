using System;
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
    public partial class FormPlayer : Form
    {
        public FormPlayer()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            // DIALOGUE BOXES TO ASK FOR CHARACTER NAME, RACE AND CLASS.
            FormAddPlayer myForm = new FormAddPlayer();
            // this.Hide();
            myForm.ShowDialog();
            //this.Close();
        }
    }
}
