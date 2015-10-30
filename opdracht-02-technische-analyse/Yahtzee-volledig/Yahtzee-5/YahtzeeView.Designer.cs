namespace Yahtzee_5
{
    partial class YahtzeeView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      this.werpAlleTeerlingenButton = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // werpAlleTeerlingenButton
      // 
      this.werpAlleTeerlingenButton.AutoSize = true;
      this.werpAlleTeerlingenButton.Location = new System.Drawing.Point(14, 114);
      this.werpAlleTeerlingenButton.Name = "werpAlleTeerlingenButton";
      this.werpAlleTeerlingenButton.Size = new System.Drawing.Size(97, 23);
      this.werpAlleTeerlingenButton.TabIndex = 0;
      this.werpAlleTeerlingenButton.Text = "Smijt ze allemaal!";
      this.werpAlleTeerlingenButton.UseVisualStyleBackColor = true;
      this.werpAlleTeerlingenButton.Click += new System.EventHandler(this.smijtAlleTeerlingenButton_click);
      // 
      // button1
      // 
      this.button1.AutoSize = true;
      this.button1.Enabled = false;
      this.button1.Location = new System.Drawing.Point(148, 190);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(97, 23);
      this.button1.TabIndex = 1;
      this.button1.Text = "Opnieuw";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // YahtzeeView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.Controls.Add(this.button1);
      this.Controls.Add(this.werpAlleTeerlingenButton);
      this.Name = "YahtzeeView";
      this.Size = new System.Drawing.Size(405, 216);
      this.Load += new System.EventHandler(this.YahtzeeView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button werpAlleTeerlingenButton;
        private System.Windows.Forms.Button button1;
    }
}
