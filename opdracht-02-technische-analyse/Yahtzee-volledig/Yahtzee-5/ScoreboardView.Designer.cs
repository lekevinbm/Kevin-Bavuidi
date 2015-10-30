namespace Yahtzee_5
{
    partial class ScoreboardView
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
        private void InitializeComponent()
        {
      this.scoreLabel = new System.Windows.Forms.Label();
      this.aantalWorpenLabel = new System.Windows.Forms.Label();
      this.scoreValueLabel = new System.Windows.Forms.Label();
      this.aantalWorpenValueLabel = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.maxWorpenLabel = new System.Windows.Forms.Label();
      this.highscoreLabel = new System.Windows.Forms.Label();
      this.highscoreValueLabel = new System.Windows.Forms.Label();
      this.SuspendLayout();
      // 
      // scoreLabel
      // 
      this.scoreLabel.AutoSize = true;
      this.scoreLabel.Location = new System.Drawing.Point(49, 10);
      this.scoreLabel.Name = "scoreLabel";
      this.scoreLabel.Size = new System.Drawing.Size(38, 13);
      this.scoreLabel.TabIndex = 0;
      this.scoreLabel.Text = "Score:";
      // 
      // aantalWorpenLabel
      // 
      this.aantalWorpenLabel.AutoSize = true;
      this.aantalWorpenLabel.Location = new System.Drawing.Point(9, 36);
      this.aantalWorpenLabel.Name = "aantalWorpenLabel";
      this.aantalWorpenLabel.Size = new System.Drawing.Size(78, 13);
      this.aantalWorpenLabel.TabIndex = 1;
      this.aantalWorpenLabel.Text = "Aantal worpen:";
      // 
      // scoreValueLabel
      // 
      this.scoreValueLabel.AutoSize = true;
      this.scoreValueLabel.Location = new System.Drawing.Point(94, 10);
      this.scoreValueLabel.Name = "scoreValueLabel";
      this.scoreValueLabel.Size = new System.Drawing.Size(13, 13);
      this.scoreValueLabel.TabIndex = 2;
      this.scoreValueLabel.Text = "0";
      this.scoreValueLabel.UseMnemonic = false;
      // 
      // aantalWorpenValueLabel
      // 
      this.aantalWorpenValueLabel.AutoSize = true;
      this.aantalWorpenValueLabel.Location = new System.Drawing.Point(94, 36);
      this.aantalWorpenValueLabel.Name = "aantalWorpenValueLabel";
      this.aantalWorpenValueLabel.Size = new System.Drawing.Size(13, 13);
      this.aantalWorpenValueLabel.TabIndex = 3;
      this.aantalWorpenValueLabel.Text = "0";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(105, 36);
      this.label1.Margin = new System.Windows.Forms.Padding(0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(12, 13);
      this.label1.TabIndex = 4;
      this.label1.Text = "/";
      // 
      // maxWorpenLabel
      // 
      this.maxWorpenLabel.AutoSize = true;
      this.maxWorpenLabel.Location = new System.Drawing.Point(115, 36);
      this.maxWorpenLabel.Name = "maxWorpenLabel";
      this.maxWorpenLabel.Size = new System.Drawing.Size(13, 13);
      this.maxWorpenLabel.TabIndex = 5;
      this.maxWorpenLabel.Text = "0";
      // 
      // highscoreLabel
      // 
      this.highscoreLabel.AutoSize = true;
      this.highscoreLabel.Location = new System.Drawing.Point(163, 10);
      this.highscoreLabel.Name = "highscoreLabel";
      this.highscoreLabel.Size = new System.Drawing.Size(58, 13);
      this.highscoreLabel.TabIndex = 6;
      this.highscoreLabel.Text = "Highscore:";
      // 
      // highscoreValueLabel
      // 
      this.highscoreValueLabel.AutoSize = true;
      this.highscoreValueLabel.Location = new System.Drawing.Point(227, 10);
      this.highscoreValueLabel.Name = "highscoreValueLabel";
      this.highscoreValueLabel.Size = new System.Drawing.Size(13, 13);
      this.highscoreValueLabel.TabIndex = 7;
      this.highscoreValueLabel.Text = "0";
      this.highscoreValueLabel.UseMnemonic = false;
      // 
      // ScoreboardView
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.highscoreValueLabel);
      this.Controls.Add(this.highscoreLabel);
      this.Controls.Add(this.maxWorpenLabel);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.aantalWorpenValueLabel);
      this.Controls.Add(this.scoreValueLabel);
      this.Controls.Add(this.aantalWorpenLabel);
      this.Controls.Add(this.scoreLabel);
      this.Name = "ScoreboardView";
      this.Size = new System.Drawing.Size(314, 62);
      this.Load += new System.EventHandler(this.ScoreboardView_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label aantalWorpenLabel;
        private System.Windows.Forms.Label scoreValueLabel;
        private System.Windows.Forms.Label aantalWorpenValueLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label maxWorpenLabel;
        private System.Windows.Forms.Label highscoreLabel;
        private System.Windows.Forms.Label highscoreValueLabel;
    }
}
