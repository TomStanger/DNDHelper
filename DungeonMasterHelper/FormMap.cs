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
    public partial class FormMap : Form
    {
        public FormMap()
        {
            InitializeComponent();
            this.Paint += new System.Windows.Forms.PaintEventHandler(f1_paint);
           
        }
        private void f1_paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    g.DrawRectangle(Pens.Black, x * 64, y * 64, 64, 64);
                }
            }
        }
            private void runMap()
        {
            Application.Run(new FormMap());
        }

        private void FormMap_Load(object sender, EventArgs e)
        {

        }
        // End of class  
    }

}