namespace DungeonMasterHelper
{
    partial class HomePage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.btnPlayers = new System.Windows.Forms.Button();
            this.btnNPC = new System.Windows.Forms.Button();
            this.btnBattle = new System.Windows.Forms.Button();
            this.btnMap = new System.Windows.Forms.Button();
            this.btnNotes = new System.Windows.Forms.Button();
            this.btnObjects = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlayers
            // 
            this.btnPlayers.Location = new System.Drawing.Point(20, 357);
            this.btnPlayers.Name = "btnPlayers";
            this.btnPlayers.Size = new System.Drawing.Size(114, 42);
            this.btnPlayers.TabIndex = 0;
            this.btnPlayers.Text = "Players";
            this.btnPlayers.UseVisualStyleBackColor = true;
            this.btnPlayers.Click += new System.EventHandler(this.btnPlayers_Click);
            // 
            // btnNPC
            // 
            this.btnNPC.Location = new System.Drawing.Point(20, 428);
            this.btnNPC.Name = "btnNPC";
            this.btnNPC.Size = new System.Drawing.Size(114, 42);
            this.btnNPC.TabIndex = 1;
            this.btnNPC.Text = "Monsters / NPCs";
            this.btnNPC.UseVisualStyleBackColor = true;
            this.btnNPC.Click += new System.EventHandler(this.btnNPC_Click);
            // 
            // btnBattle
            // 
            this.btnBattle.Location = new System.Drawing.Point(188, 357);
            this.btnBattle.Name = "btnBattle";
            this.btnBattle.Size = new System.Drawing.Size(114, 42);
            this.btnBattle.TabIndex = 2;
            this.btnBattle.Text = "Battle Map";
            this.btnBattle.UseVisualStyleBackColor = true;
            this.btnBattle.Click += new System.EventHandler(this.btnBattle_Click);
            // 
            // btnMap
            // 
            this.btnMap.Location = new System.Drawing.Point(188, 428);
            this.btnMap.Name = "btnMap";
            this.btnMap.Size = new System.Drawing.Size(114, 42);
            this.btnMap.TabIndex = 3;
            this.btnMap.Text = "Map";
            this.btnMap.UseVisualStyleBackColor = true;
            this.btnMap.Click += new System.EventHandler(this.btnMap_Click);
            // 
            // btnNotes
            // 
            this.btnNotes.Location = new System.Drawing.Point(353, 357);
            this.btnNotes.Name = "btnNotes";
            this.btnNotes.Size = new System.Drawing.Size(114, 42);
            this.btnNotes.TabIndex = 4;
            this.btnNotes.Text = "Notes";
            this.btnNotes.UseVisualStyleBackColor = true;
            this.btnNotes.Click += new System.EventHandler(this.btnNotes_Click);
            // 
            // btnObjects
            // 
            this.btnObjects.Location = new System.Drawing.Point(353, 428);
            this.btnObjects.Name = "btnObjects";
            this.btnObjects.Size = new System.Drawing.Size(114, 42);
            this.btnObjects.TabIndex = 5;
            this.btnObjects.Text = "Objects";
            this.btnObjects.UseVisualStyleBackColor = true;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(870, 491);
            this.Controls.Add(this.btnObjects);
            this.Controls.Add(this.btnNotes);
            this.Controls.Add(this.btnMap);
            this.Controls.Add(this.btnBattle);
            this.Controls.Add(this.btnNPC);
            this.Controls.Add(this.btnPlayers);
            this.Name = "HomePage";
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlayers;
        private System.Windows.Forms.Button btnNPC;
        private System.Windows.Forms.Button btnBattle;
        private System.Windows.Forms.Button btnMap;
        private System.Windows.Forms.Button btnNotes;
        private System.Windows.Forms.Button btnObjects;
    }
}

