namespace DungeonMasterHelper
{
    partial class FormAddPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddPlayer));
            this.lblPName = new System.Windows.Forms.Label();
            this.txtPlayer = new System.Windows.Forms.TextBox();
            this.lblLvl = new System.Windows.Forms.Label();
            this.lblClass = new System.Windows.Forms.Label();
            this.lblDNDB = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.txtLvl = new System.Windows.Forms.TextBox();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.txtDNDBeyond = new System.Windows.Forms.TextBox();
            this.txtCharName = new System.Windows.Forms.TextBox();
            this.txtRace = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(26, 9);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(67, 13);
            this.lblPName.TabIndex = 0;
            this.lblPName.Text = "Player Name";
            this.lblPName.Click += new System.EventHandler(this.lblPName_Click);
            // 
            // txtPlayer
            // 
            this.txtPlayer.Location = new System.Drawing.Point(29, 25);
            this.txtPlayer.Name = "txtPlayer";
            this.txtPlayer.Size = new System.Drawing.Size(64, 20);
            this.txtPlayer.TabIndex = 1;
            this.txtPlayer.TextChanged += new System.EventHandler(this.txtPlayer_TextChanged);
            // 
            // lblLvl
            // 
            this.lblLvl.AutoSize = true;
            this.lblLvl.Location = new System.Drawing.Point(297, 9);
            this.lblLvl.Name = "lblLvl";
            this.lblLvl.Size = new System.Drawing.Size(33, 13);
            this.lblLvl.TabIndex = 2;
            this.lblLvl.Text = "Level";
            this.lblLvl.Click += new System.EventHandler(this.lblLvl_Click);
            // 
            // lblClass
            // 
            this.lblClass.AutoSize = true;
            this.lblClass.Location = new System.Drawing.Point(166, 58);
            this.lblClass.Name = "lblClass";
            this.lblClass.Size = new System.Drawing.Size(32, 13);
            this.lblClass.TabIndex = 4;
            this.lblClass.Text = "Class";
            this.lblClass.Click += new System.EventHandler(this.lblClass_Click);
            // 
            // lblDNDB
            // 
            this.lblDNDB.AutoSize = true;
            this.lblDNDB.Location = new System.Drawing.Point(144, 156);
            this.lblDNDB.Name = "lblDNDB";
            this.lblDNDB.Size = new System.Drawing.Size(70, 13);
            this.lblDNDB.TabIndex = 10;
            this.lblDNDB.Text = "DND Beyond";
            this.lblDNDB.Click += new System.EventHandler(this.lblDNDB_Click);
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(144, 9);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(84, 13);
            this.lblCName.TabIndex = 8;
            this.lblCName.Text = "Character Name";
            this.lblCName.Click += new System.EventHandler(this.lblCName_Click);
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(166, 97);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 6;
            this.lblRace.Text = "Race";
            this.lblRace.Click += new System.EventHandler(this.lblRace_Click);
            // 
            // txtLvl
            // 
            this.txtLvl.Location = new System.Drawing.Point(284, 25);
            this.txtLvl.Name = "txtLvl";
            this.txtLvl.Size = new System.Drawing.Size(64, 20);
            this.txtLvl.TabIndex = 11;
            this.txtLvl.TextChanged += new System.EventHandler(this.txtLvl_TextChanged);
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(115, 74);
            this.txtClass.Name = "txtClass";
            this.txtClass.Size = new System.Drawing.Size(143, 20);
            this.txtClass.TabIndex = 12;
            this.txtClass.TextChanged += new System.EventHandler(this.txtClass_TextChanged);
            // 
            // txtDNDBeyond
            // 
            this.txtDNDBeyond.Location = new System.Drawing.Point(78, 172);
            this.txtDNDBeyond.Name = "txtDNDBeyond";
            this.txtDNDBeyond.Size = new System.Drawing.Size(209, 20);
            this.txtDNDBeyond.TabIndex = 13;
            this.txtDNDBeyond.TextChanged += new System.EventHandler(this.txtDNDBeyond_TextChanged);
            // 
            // txtCharName
            // 
            this.txtCharName.Location = new System.Drawing.Point(115, 25);
            this.txtCharName.Name = "txtCharName";
            this.txtCharName.Size = new System.Drawing.Size(143, 20);
            this.txtCharName.TabIndex = 14;
            this.txtCharName.TextChanged += new System.EventHandler(this.txtCharName_TextChanged);
            // 
            // txtRace
            // 
            this.txtRace.Location = new System.Drawing.Point(115, 113);
            this.txtRace.Name = "txtRace";
            this.txtRace.Size = new System.Drawing.Size(143, 20);
            this.txtRace.TabIndex = 15;
            this.txtRace.TextChanged += new System.EventHandler(this.txtRace_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(147, 215);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FormAddPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(372, 250);
            this.Controls.Add(this.txtRace);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.txtCharName);
            this.Controls.Add(this.lblPName);
            this.Controls.Add(this.txtDNDBeyond);
            this.Controls.Add(this.txtPlayer);
            this.Controls.Add(this.txtClass);
            this.Controls.Add(this.lblLvl);
            this.Controls.Add(this.txtLvl);
            this.Controls.Add(this.lblClass);
            this.Controls.Add(this.lblDNDB);
            this.Controls.Add(this.lblRace);
            this.Name = "FormAddPlayer";
            this.Text = "..";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox txtPlayer;
        private System.Windows.Forms.Label lblLvl;
        private System.Windows.Forms.Label lblClass;
        private System.Windows.Forms.Label lblDNDB;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.TextBox txtLvl;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.TextBox txtDNDBeyond;
        private System.Windows.Forms.TextBox txtCharName;
        private System.Windows.Forms.TextBox txtRace;
        private System.Windows.Forms.Button btnAdd;
    }
}