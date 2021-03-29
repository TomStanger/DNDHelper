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
    public partial class FormNPC : Form
    {
        public FormNPC()
        {
            InitializeComponent();
        }

        private void btnCreateMonster_Click(object sender, EventArgs e)
        {
            FormAddMonster myForm = new FormAddMonster(-1);
            myForm.ShowDialog();
        }

        private void btnCreateNPC_Click(object sender, EventArgs e)
        {
            FormAddNPC myForm = new FormAddNPC();
            myForm.ShowDialog();
        }

        private void btnMonsterList_Click(object sender, EventArgs e)
        {

        }
    }
}
