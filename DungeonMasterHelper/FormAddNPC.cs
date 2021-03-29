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
    public partial class FormAddNPC : Form
    {
        public FormAddNPC()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string armorClass = txtAC.Text;
            string hitpoints = txtHP.Text;

            string constitution = txtCon.Text;
            string charisma = txtCha.Text;
            string strength = txtStr.Text;
            string dexterity = txtDex.Text;
            string intelligence = txtNPCFaction.Text;
            string wisdom = txtWis.Text;

           // string religion = txtNP.Text;
            string npcReligion = txtNPCReligion.Text;
            string npcFaction = txtNPCFaction.Text;
            string npcName = txtNPCName.Text;
            string npcProfession = txtNPCProfession.Text;

            List<string> error = new List<string>();

            if (string.IsNullOrEmpty(armorClass))
            {
                error.Add("armorClass cant be empty you dollop! ");
            }

            // You dont need to use {} for single line if statements! 
            if (string.IsNullOrEmpty(constitution))
                error.Add("hitpoints cant be empty you dollop!");

            if (string.IsNullOrEmpty(hitpoints))
            {
                error.Add("hitpoints cant be empty you dollop!");
            }
            /* Else if it is not an integer, it checks if  the string "Level" is parse-able into an Int
            */
            else if (!int.TryParse(hitpoints, out _))
            {
                error.Add("Input a number for hitpoints you baffoon! ");
            }

            if (string.IsNullOrEmpty(charisma))
            {
                error.Add("charisma cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(strength))
            {
                error.Add("strength cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(dexterity))
            {
                error.Add("dexterity cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(intelligence))
            {
                error.Add("intelligence cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(wisdom))
            {
                error.Add("wisdom cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(npcFaction))
            {
                error.Add("NPC Faction cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(npcReligion))
            {
                error.Add("npcReligion cant be empty you dollop!");
            }


            if (string.IsNullOrEmpty(npcName))
            {
                error.Add("npcName cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(npcProfession))
            {
                error.Add("npcProfessionnpcProfession cant be empty you dollop!");
            }

            if (error.Count > 0)
            {
                MessageBox.Show(string.Join("\n", error));
            }

            //MessageBox.Show("RAN");
        }
    }
}
