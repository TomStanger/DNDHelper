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
    public partial class FormAddMonster : Form
    {
        public int MonsterId { get; set; }

        public FormAddMonster(int monsterId)
        {
            InitializeComponent();
            
            this.MonsterId = monsterId;
            this.CorrectUI();
        }

        private void CorrectUI()
        {
            if (this.MonsterId == -1)
            {

            }
            else
            {
                this.btnAdd.Text = "Update";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtMonsterName.Text;

            string armorClass = txtAC.Text;
            string hitpoints = txtHP.Text;

            string constitution = txtCon.Text;
            string charisma = txtCha.Text;
            string strength = txtStr.Text;
            string dexterity = txtDex.Text;
            string intelligence = txtInt.Text;
            string wisdom = txtWis.Text;

            string monsterRace = txtMonsterRace.Text;
            string monsterType = txtMonsterType.Text;
            string crating = txtCR.Text;

            string abilities = txtAbilities.Text;

            List<string> error = new List<string>();

            if (string.IsNullOrEmpty(name))
            {
                error.Add("It needs a name you fool!");
            }

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

            if (string.IsNullOrEmpty(monsterRace))
            {
                error.Add("monsterRace cant be empty you dollop!");
            }

            if (string.IsNullOrEmpty(monsterType))
            {
                error.Add("monsterType cant be empty you dollop!");
            }


            if (string.IsNullOrEmpty(crating))
            {
                error.Add("crating cant be empty you dollop!");
            }
                     
            if (error.Count > 0)
            {
                MessageBox.Show(string.Join("\n", error));
            }
            else
            {
                //new sql statement 
                var sql = string.Empty;

                // -1 because once one is added in, it will never pass that criteria again

                if (this.MonsterId == -1)
                    //Adding Rows into the Monster Table
                {
                    sql = @$"
                    INSERT INTO 
                        Monster (
                            MonsterName, 
                            Type, 
                            Race, 
                            Abilities, 
                            ChallengeRating, 
                            HitPoints, 
                            ArmorClass, 
                            Strength, 
                            Dexterity, 
                            Constitution, 
                            Intelligence, 
                            Wisdom, 
                            Charisma)
                        VALUES (
                            '{name}', -- This will put in all the local stored variables
                            '{monsterType}',
                            '{monsterRace}',
                            '{abilities}',
                            '{crating}',
                            {hitpoints},
                            {armorClass},
                            {strength},
                            {dexterity},
                            {constitution},
                            {intelligence},
                            {wisdom},
                            {charisma}
                        );";
                }
                else
                // If the id is not -1, the monster already exists and therefore will be updated NOT added.
                //Fill in all the other stats next to name.
                {
                    sql = $@"
                    UPDATE
                        Monster
                    SET
                        MonsterName = '{name}'
                        MonsterType = '{monsterType}'
                        MonsterRace = '{monsterRace}'
                        Abilities = '{abilities}'
                        CRating = '{crating}'
                        HitPoints = {hitpoints}
                        ArmorClass = {armorClass}
                        Strength = {strength}
                        Dexterity = {dexterity}
                        Constitution = {constitution}
                        Intelligence = {intelligence}
                        Wisdom = {wisdom}
                        Charisma = {charisma}
                    WHERE
                        MonsterID = {this.MonsterId};";
                }

                var addorupdate = new Sqlmanagement();
                addorupdate.Start(sql);
                addorupdate.Close();

                if (this.MonsterId == -1)
                    // Finds monster with name we've added and gets the ID to match it
                {
                    var getnewest = new Sqlmanagement();

                    //Gets the monster with the MonsterName as search criteria
                    var response = getnewest.Start($"Select * FROM Monster WHERE MonsterName = '{name}'");
                    
                    //if the results has rows (information)
                    if (response.HasRows)
                        //while loop for every row that has been returned
                        while (response.Read())
                            //Response will be the row with the MonsterID to match (int) is used to cast the result as Integer to match the local variable
                            this.MonsterId = (int)response["MonsterID"];

                    getnewest.Close();
                    //Close Connection
                    MessageBox.Show("Successfully added");
                    //Inform user
                }
                else
                {
                    MessageBox.Show("Successfully updated");
                }

                CorrectUI();
            }

            //MessageBox.Show("RAN");
        }

        private void lblAbilities_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAC_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtHP_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCha_Click(object sender, EventArgs e)
        {

        }

        private void txtCha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblWis_Click(object sender, EventArgs e)
        {

        }

        private void txtWis_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblInt_Click(object sender, EventArgs e)
        {

        }

        private void txtInt_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCon_Click(object sender, EventArgs e)
        {

        }

        private void txtCon_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblDex_Click(object sender, EventArgs e)
        {

        }

        private void txtDex_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStr_Click(object sender, EventArgs e)
        {

        }

        private void txtStr_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonsterRace_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAbilities_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMName_Click(object sender, EventArgs e)
        {

        }

        private void txtMonsterName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMonsterType_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCR_Click(object sender, EventArgs e)
        {

        }

        private void txtCR_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblType_Click(object sender, EventArgs e)
        {

        }

        private void lblRace_Click(object sender, EventArgs e)
        {

        }
    }
}
