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
    public partial class HomePage : Form
        
    {
        
        public HomePage()
        {
            InitializeComponent();
        }

      
        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnPlayers_Click(object sender, EventArgs e)
        {
            FormPlayer myForm = new FormPlayer();
           // this.Hide();
            myForm.ShowDialog();
            //this.Close();
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            FormNPC myForm = new FormNPC();
            //this.Hide();
            myForm.ShowDialog();
            //this.Close();
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            FormBattle myForm = new FormBattle();
          //  this.Hide();
            myForm.ShowDialog();
            //this.Close();
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            FormMap myForm = new FormMap();
           // this.Hide();
            myForm.ShowDialog();
            //this.Close();
        }

        private void btnNotes_Click(object sender, EventArgs e)
        {
            FormNotes myForm = new FormNotes();
             //  this.Hide();
            myForm.ShowDialog();
            //this.Close();
        }
    }
}
