namespace DungeonMasterHelper
{
    partial class FormNotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNotes));
            this.txtPage1 = new System.Windows.Forms.RichTextBox();
            this.txtPage2 = new System.Windows.Forms.RichTextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPage1
            // 
            this.txtPage1.BackColor = System.Drawing.SystemColors.Info;
            this.txtPage1.Location = new System.Drawing.Point(32, 12);
            this.txtPage1.Name = "txtPage1";
            this.txtPage1.Size = new System.Drawing.Size(359, 413);
            this.txtPage1.TabIndex = 0;
            this.txtPage1.Text = "";
            this.txtPage1.TextChanged += new System.EventHandler(this.txtPage1_TextChanged);
            // 
            // txtPage2
            // 
            this.txtPage2.BackColor = System.Drawing.SystemColors.Info;
            this.txtPage2.Location = new System.Drawing.Point(397, 12);
            this.txtPage2.Name = "txtPage2";
            this.txtPage2.Size = new System.Drawing.Size(360, 413);
            this.txtPage2.TabIndex = 1;
            this.txtPage2.Text = "";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(140, 437);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(530, 437);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 3;
            this.btnLoad.Text = "LOAD";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // FormNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 472);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtPage2);
            this.Controls.Add(this.txtPage1);
            this.Name = "FormNotes";
            this.Text = "FormNotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txtPage1;
        private System.Windows.Forms.RichTextBox txtPage2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
    }
}