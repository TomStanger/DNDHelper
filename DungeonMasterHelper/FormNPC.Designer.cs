namespace DungeonMasterHelper
{
    partial class FormNPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNPC));
            this.btnAddMonster = new System.Windows.Forms.Button();
            this.btnAddNPC = new System.Windows.Forms.Button();
            this.btnMonsterList = new System.Windows.Forms.Button();
            this.btnNPCList = new System.Windows.Forms.Button();
            this.btnCreateNPC = new System.Windows.Forms.Button();
            this.btnCreateMonster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddMonster
            // 
            this.btnAddMonster.Location = new System.Drawing.Point(12, 12);
            this.btnAddMonster.Name = "btnAddMonster";
            this.btnAddMonster.Size = new System.Drawing.Size(75, 23);
            this.btnAddMonster.TabIndex = 0;
            this.btnAddMonster.Text = "Add Monster";
            this.btnAddMonster.UseVisualStyleBackColor = true;
            // 
            // btnAddNPC
            // 
            this.btnAddNPC.Location = new System.Drawing.Point(431, 12);
            this.btnAddNPC.Name = "btnAddNPC";
            this.btnAddNPC.Size = new System.Drawing.Size(75, 23);
            this.btnAddNPC.TabIndex = 1;
            this.btnAddNPC.Text = "Add NPC";
            this.btnAddNPC.UseVisualStyleBackColor = true;
            // 
            // btnMonsterList
            // 
            this.btnMonsterList.Location = new System.Drawing.Point(308, 12);
            this.btnMonsterList.Name = "btnMonsterList";
            this.btnMonsterList.Size = new System.Drawing.Size(75, 23);
            this.btnMonsterList.TabIndex = 2;
            this.btnMonsterList.Text = "Monster List";
            this.btnMonsterList.UseVisualStyleBackColor = true;
            this.btnMonsterList.Click += new System.EventHandler(this.btnMonsterList_Click);
            // 
            // btnNPCList
            // 
            this.btnNPCList.Location = new System.Drawing.Point(713, 12);
            this.btnNPCList.Name = "btnNPCList";
            this.btnNPCList.Size = new System.Drawing.Size(75, 23);
            this.btnNPCList.TabIndex = 3;
            this.btnNPCList.Text = "NPC List";
            this.btnNPCList.UseVisualStyleBackColor = true;
            // 
            // btnCreateNPC
            // 
            this.btnCreateNPC.Location = new System.Drawing.Point(568, 401);
            this.btnCreateNPC.Name = "btnCreateNPC";
            this.btnCreateNPC.Size = new System.Drawing.Size(129, 37);
            this.btnCreateNPC.TabIndex = 4;
            this.btnCreateNPC.Text = "Create a NPC!";
            this.btnCreateNPC.UseVisualStyleBackColor = true;
            this.btnCreateNPC.Click += new System.EventHandler(this.btnCreateNPC_Click);
            // 
            // btnCreateMonster
            // 
            this.btnCreateMonster.Location = new System.Drawing.Point(120, 401);
            this.btnCreateMonster.Name = "btnCreateMonster";
            this.btnCreateMonster.Size = new System.Drawing.Size(129, 37);
            this.btnCreateMonster.TabIndex = 5;
            this.btnCreateMonster.Text = "Create a Monster!";
            this.btnCreateMonster.UseVisualStyleBackColor = true;
            this.btnCreateMonster.Click += new System.EventHandler(this.btnCreateMonster_Click);
            // 
            // FormNPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(808, 450);
            this.Controls.Add(this.btnCreateMonster);
            this.Controls.Add(this.btnCreateNPC);
            this.Controls.Add(this.btnNPCList);
            this.Controls.Add(this.btnMonsterList);
            this.Controls.Add(this.btnAddNPC);
            this.Controls.Add(this.btnAddMonster);
            this.Name = "FormNPC";
            this.Text = "FormNPC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddMonster;
        private System.Windows.Forms.Button btnAddNPC;
        private System.Windows.Forms.Button btnMonsterList;
        private System.Windows.Forms.Button btnNPCList;
        private System.Windows.Forms.Button btnCreateNPC;
        private System.Windows.Forms.Button btnCreateMonster;
    }
}