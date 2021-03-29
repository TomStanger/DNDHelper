namespace DungeonMasterHelper
{
    partial class FormAddMonster
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
            this.txtMonsterRace = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblMName = new System.Windows.Forms.Label();
            this.txtMonsterName = new System.Windows.Forms.TextBox();
            this.txtMonsterType = new System.Windows.Forms.TextBox();
            this.lblCR = new System.Windows.Forms.Label();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblRace = new System.Windows.Forms.Label();
            this.lblStr = new System.Windows.Forms.Label();
            this.txtStr = new System.Windows.Forms.TextBox();
            this.lblDex = new System.Windows.Forms.Label();
            this.txtDex = new System.Windows.Forms.TextBox();
            this.lblCon = new System.Windows.Forms.Label();
            this.txtCon = new System.Windows.Forms.TextBox();
            this.lblCha = new System.Windows.Forms.Label();
            this.txtCha = new System.Windows.Forms.TextBox();
            this.lblWis = new System.Windows.Forms.Label();
            this.txtWis = new System.Windows.Forms.TextBox();
            this.lblInt = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAC = new System.Windows.Forms.TextBox();
            this.txtAbilities = new System.Windows.Forms.TextBox();
            this.lblAbilities = new System.Windows.Forms.Label();
            this.picMonster = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMonsterRace
            // 
            this.txtMonsterRace.Location = new System.Drawing.Point(94, 335);
            this.txtMonsterRace.Name = "txtMonsterRace";
            this.txtMonsterRace.Size = new System.Drawing.Size(143, 20);
            this.txtMonsterRace.TabIndex = 28;
            this.txtMonsterRace.TextChanged += new System.EventHandler(this.txtMonsterRace_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(126, 415);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 29;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblMName
            // 
            this.lblMName.AutoSize = true;
            this.lblMName.Location = new System.Drawing.Point(123, 239);
            this.lblMName.Name = "lblMName";
            this.lblMName.Size = new System.Drawing.Size(76, 13);
            this.lblMName.TabIndex = 22;
            this.lblMName.Text = "Monster Name";
            this.lblMName.Click += new System.EventHandler(this.lblMName_Click);
            // 
            // txtMonsterName
            // 
            this.txtMonsterName.Location = new System.Drawing.Point(94, 257);
            this.txtMonsterName.Name = "txtMonsterName";
            this.txtMonsterName.Size = new System.Drawing.Size(143, 20);
            this.txtMonsterName.TabIndex = 27;
            this.txtMonsterName.TextChanged += new System.EventHandler(this.txtMonsterName_TextChanged);
            // 
            // txtMonsterType
            // 
            this.txtMonsterType.Location = new System.Drawing.Point(94, 296);
            this.txtMonsterType.Name = "txtMonsterType";
            this.txtMonsterType.Size = new System.Drawing.Size(143, 20);
            this.txtMonsterType.TabIndex = 25;
            this.txtMonsterType.TextChanged += new System.EventHandler(this.txtMonsterType_TextChanged);
            // 
            // lblCR
            // 
            this.lblCR.AutoSize = true;
            this.lblCR.Location = new System.Drawing.Point(17, 180);
            this.lblCR.Name = "lblCR";
            this.lblCR.Size = new System.Drawing.Size(88, 13);
            this.lblCR.TabIndex = 19;
            this.lblCR.Text = "Challenge Rating";
            this.lblCR.Click += new System.EventHandler(this.lblCR_Click);
            // 
            // txtCR
            // 
            this.txtCR.Location = new System.Drawing.Point(25, 196);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(80, 20);
            this.txtCR.TabIndex = 24;
            this.txtCR.TextChanged += new System.EventHandler(this.txtCR_TextChanged);
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(145, 280);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(31, 13);
            this.lblType.TabIndex = 20;
            this.lblType.Text = "Type";
            this.lblType.Click += new System.EventHandler(this.lblType_Click);
            // 
            // lblRace
            // 
            this.lblRace.AutoSize = true;
            this.lblRace.Location = new System.Drawing.Point(145, 319);
            this.lblRace.Name = "lblRace";
            this.lblRace.Size = new System.Drawing.Size(33, 13);
            this.lblRace.TabIndex = 21;
            this.lblRace.Text = "Race";
            this.lblRace.Click += new System.EventHandler(this.lblRace_Click);
            // 
            // lblStr
            // 
            this.lblStr.AutoSize = true;
            this.lblStr.Location = new System.Drawing.Point(138, 21);
            this.lblStr.Name = "lblStr";
            this.lblStr.Size = new System.Drawing.Size(67, 13);
            this.lblStr.TabIndex = 30;
            this.lblStr.Text = "STRENGTH";
            this.lblStr.Click += new System.EventHandler(this.lblStr_Click);
            // 
            // txtStr
            // 
            this.txtStr.Location = new System.Drawing.Point(141, 43);
            this.txtStr.Name = "txtStr";
            this.txtStr.Size = new System.Drawing.Size(64, 20);
            this.txtStr.TabIndex = 31;
            this.txtStr.TextChanged += new System.EventHandler(this.txtStr_TextChanged);
            // 
            // lblDex
            // 
            this.lblDex.AutoSize = true;
            this.lblDex.Location = new System.Drawing.Point(137, 69);
            this.lblDex.Name = "lblDex";
            this.lblDex.Size = new System.Drawing.Size(68, 13);
            this.lblDex.TabIndex = 32;
            this.lblDex.Text = "DEXTERITY";
            this.lblDex.Click += new System.EventHandler(this.lblDex_Click);
            // 
            // txtDex
            // 
            this.txtDex.Location = new System.Drawing.Point(140, 85);
            this.txtDex.Name = "txtDex";
            this.txtDex.Size = new System.Drawing.Size(64, 20);
            this.txtDex.TabIndex = 33;
            this.txtDex.TextChanged += new System.EventHandler(this.txtDex_TextChanged);
            // 
            // lblCon
            // 
            this.lblCon.AutoSize = true;
            this.lblCon.Location = new System.Drawing.Point(132, 114);
            this.lblCon.Name = "lblCon";
            this.lblCon.Size = new System.Drawing.Size(88, 13);
            this.lblCon.TabIndex = 34;
            this.lblCon.Text = "CONSTITUTION";
            this.lblCon.Click += new System.EventHandler(this.lblCon_Click);
            // 
            // txtCon
            // 
            this.txtCon.Location = new System.Drawing.Point(141, 134);
            this.txtCon.Name = "txtCon";
            this.txtCon.Size = new System.Drawing.Size(64, 20);
            this.txtCon.TabIndex = 35;
            this.txtCon.TextChanged += new System.EventHandler(this.txtCon_TextChanged);
            // 
            // lblCha
            // 
            this.lblCha.AutoSize = true;
            this.lblCha.Location = new System.Drawing.Point(226, 114);
            this.lblCha.Name = "lblCha";
            this.lblCha.Size = new System.Drawing.Size(63, 13);
            this.lblCha.TabIndex = 40;
            this.lblCha.Text = "CHARISMA";
            this.lblCha.Click += new System.EventHandler(this.lblCha_Click);
            // 
            // txtCha
            // 
            this.txtCha.Location = new System.Drawing.Point(229, 134);
            this.txtCha.Name = "txtCha";
            this.txtCha.Size = new System.Drawing.Size(64, 20);
            this.txtCha.TabIndex = 41;
            this.txtCha.TextChanged += new System.EventHandler(this.txtCha_TextChanged);
            // 
            // lblWis
            // 
            this.lblWis.AutoSize = true;
            this.lblWis.Location = new System.Drawing.Point(226, 69);
            this.lblWis.Name = "lblWis";
            this.lblWis.Size = new System.Drawing.Size(53, 13);
            this.lblWis.TabIndex = 38;
            this.lblWis.Text = "WISDOM";
            this.lblWis.Click += new System.EventHandler(this.lblWis_Click);
            // 
            // txtWis
            // 
            this.txtWis.Location = new System.Drawing.Point(229, 85);
            this.txtWis.Name = "txtWis";
            this.txtWis.Size = new System.Drawing.Size(64, 20);
            this.txtWis.TabIndex = 39;
            this.txtWis.TextChanged += new System.EventHandler(this.txtWis_TextChanged);
            // 
            // lblInt
            // 
            this.lblInt.AutoSize = true;
            this.lblInt.Location = new System.Drawing.Point(226, 21);
            this.lblInt.Name = "lblInt";
            this.lblInt.Size = new System.Drawing.Size(84, 13);
            this.lblInt.TabIndex = 36;
            this.lblInt.Text = "INTELLIGENCE";
            this.lblInt.Click += new System.EventHandler(this.lblInt_Click);
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(229, 43);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(64, 20);
            this.txtInt.TabIndex = 37;
            this.txtInt.TextChanged += new System.EventHandler(this.txtInt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(145, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Hit Points";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtHP
            // 
            this.txtHP.Location = new System.Drawing.Point(126, 196);
            this.txtHP.Name = "txtHP";
            this.txtHP.Size = new System.Drawing.Size(81, 20);
            this.txtHP.TabIndex = 43;
            this.txtHP.TextChanged += new System.EventHandler(this.txtHP_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(239, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "Armor Class";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtAC
            // 
            this.txtAC.Location = new System.Drawing.Point(229, 196);
            this.txtAC.Name = "txtAC";
            this.txtAC.Size = new System.Drawing.Size(81, 20);
            this.txtAC.TabIndex = 45;
            this.txtAC.TextChanged += new System.EventHandler(this.txtAC_TextChanged);
            // 
            // txtAbilities
            // 
            this.txtAbilities.Location = new System.Drawing.Point(94, 374);
            this.txtAbilities.Name = "txtAbilities";
            this.txtAbilities.Size = new System.Drawing.Size(143, 20);
            this.txtAbilities.TabIndex = 47;
            this.txtAbilities.TextChanged += new System.EventHandler(this.txtAbilities_TextChanged);
            // 
            // lblAbilities
            // 
            this.lblAbilities.AutoSize = true;
            this.lblAbilities.Location = new System.Drawing.Point(145, 358);
            this.lblAbilities.Name = "lblAbilities";
            this.lblAbilities.Size = new System.Drawing.Size(42, 13);
            this.lblAbilities.TabIndex = 46;
            this.lblAbilities.Text = "Abilities";
            this.lblAbilities.Click += new System.EventHandler(this.lblAbilities_Click);
            // 
            // picMonster
            // 
            this.picMonster.Location = new System.Drawing.Point(12, 43);
            this.picMonster.Name = "picMonster";
            this.picMonster.Size = new System.Drawing.Size(111, 111);
            this.picMonster.TabIndex = 48;
            this.picMonster.TabStop = false;
            // 
            // FormAddMonster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.picMonster);
            this.Controls.Add(this.txtAbilities);
            this.Controls.Add(this.lblAbilities);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtHP);
            this.Controls.Add(this.lblCha);
            this.Controls.Add(this.txtCha);
            this.Controls.Add(this.lblWis);
            this.Controls.Add(this.txtWis);
            this.Controls.Add(this.lblInt);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.lblCon);
            this.Controls.Add(this.txtCon);
            this.Controls.Add(this.lblDex);
            this.Controls.Add(this.txtDex);
            this.Controls.Add(this.lblStr);
            this.Controls.Add(this.txtStr);
            this.Controls.Add(this.txtMonsterRace);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblMName);
            this.Controls.Add(this.txtMonsterName);
            this.Controls.Add(this.txtMonsterType);
            this.Controls.Add(this.lblCR);
            this.Controls.Add(this.txtCR);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.lblRace);
            this.Name = "FormAddMonster";
            this.Text = "FormAddMonster";
            ((System.ComponentModel.ISupportInitialize)(this.picMonster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMonsterRace;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblMName;
        private System.Windows.Forms.TextBox txtMonsterName;
        private System.Windows.Forms.TextBox txtMonsterType;
        private System.Windows.Forms.Label lblCR;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblRace;
        private System.Windows.Forms.Label lblStr;
        private System.Windows.Forms.TextBox txtStr;
        private System.Windows.Forms.Label lblDex;
        private System.Windows.Forms.TextBox txtDex;
        private System.Windows.Forms.Label lblCon;
        private System.Windows.Forms.TextBox txtCon;
        private System.Windows.Forms.Label lblCha;
        private System.Windows.Forms.TextBox txtCha;
        private System.Windows.Forms.Label lblWis;
        private System.Windows.Forms.TextBox txtWis;
        private System.Windows.Forms.Label lblInt;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAC;
        private System.Windows.Forms.TextBox txtAbilities;
        private System.Windows.Forms.Label lblAbilities;
        private System.Windows.Forms.PictureBox picMonster;
    }
}