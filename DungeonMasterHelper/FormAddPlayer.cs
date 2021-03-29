using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DungeonMasterHelper
{
    public partial class FormAddPlayer : Form
    {
        public FormAddPlayer()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string charName = txtCharName.Text;
            string playerName = txtPlayer.Text;
            string level = txtLvl.Text;
            string race = txtRace.Text;
            string _class = txtClass.Text;
            string dndBeyond = txtDNDBeyond.Text;

            //All this list allows is strings, shown in List<string>();
            List<string> error = new List<string>();

            if (string.IsNullOrEmpty(charName))
            {
                error.Add("char name cant be empty you dollop! ");
            }

            // You dont need to use {} for single line if statements! 
            if (string.IsNullOrEmpty(playerName)) 
                error.Add("player name cant be empty you dollop!");
            
            if (string.IsNullOrEmpty(level))
            {
                error.Add("level cant be empty you dollop!");
            }
            /* Else if it is not an integer, it checks if  the string "Level" is parse-able into an Int
            */
            else if (!int.TryParse(level, out _))
            {
                error.Add("Input a number you baffoon into level! ");
            }

            if (string.IsNullOrEmpty(race))
            {
                error.Add("race cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(_class))
            {
                error.Add("class cant be empty you dollop!");
            }

            if (error.Count > 0)
            {
                MessageBox.Show(string.Join("\n", error));
            }

            //MessageBox.Show("RAN");
        }

        private void txtRace_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCName_Click(object sender, EventArgs e)
        {

        }

        private void txtCharName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPName_Click(object sender, EventArgs e)
        {

        }

        private void txtDNDBeyond_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPlayer_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLvl_Click(object sender, EventArgs e)
        {

        }

        private void txtLvl_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblClass_Click(object sender, EventArgs e)
        {

        }

        private void lblDNDB_Click(object sender, EventArgs e)
        {

        }

        private void lblRace_Click(object sender, EventArgs e)
        {

        }
    }
}
