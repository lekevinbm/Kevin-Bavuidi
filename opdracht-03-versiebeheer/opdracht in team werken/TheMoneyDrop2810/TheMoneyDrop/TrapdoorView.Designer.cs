namespace TheMoneyDrop
{
  partial class TrapdoorView
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
            this.lblTrapdoor = new System.Windows.Forms.Label();
            this.lblIngezet = new System.Windows.Forms.Label();
            this.txtInzet = new System.Windows.Forms.TextBox();
            this.btnInzetten = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTrapdoor
            // 
            this.lblTrapdoor.AutoSize = true;
            this.lblTrapdoor.Location = new System.Drawing.Point(44, 19);
            this.lblTrapdoor.Name = "lblTrapdoor";
            this.lblTrapdoor.Size = new System.Drawing.Size(50, 13);
            this.lblTrapdoor.TabIndex = 0;
            this.lblTrapdoor.Text = "Trapdoor";
            this.lblTrapdoor.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIngezet
            // 
            this.lblIngezet.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngezet.Location = new System.Drawing.Point(0, 32);
            this.lblIngezet.Name = "lblIngezet";
            this.lblIngezet.Size = new System.Drawing.Size(150, 69);
            this.lblIngezet.TabIndex = 1;
            this.lblIngezet.Text = "0";
            this.lblIngezet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIngezet.Click += new System.EventHandler(this.lblIngezet_Click);
            // 
            // txtInzet
            // 
            this.txtInzet.Location = new System.Drawing.Point(24, 95);
            this.txtInzet.Name = "txtInzet";
            this.txtInzet.Size = new System.Drawing.Size(100, 20);
            this.txtInzet.TabIndex = 2;
            this.txtInzet.Text = "0";
            this.txtInzet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInzet.TextChanged += new System.EventHandler(this.txtInzet_TextChanged);
            // 
            // btnInzetten
            // 
            this.btnInzetten.Enabled = false;
            this.btnInzetten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInzetten.Location = new System.Drawing.Point(41, 121);
            this.btnInzetten.Name = "btnInzetten";
            this.btnInzetten.Size = new System.Drawing.Size(63, 26);
            this.btnInzetten.TabIndex = 3;
            this.btnInzetten.Text = "Zet in";
            this.btnInzetten.UseVisualStyleBackColor = true;
            this.btnInzetten.Click += new System.EventHandler(this.btnInzetten_Click);
            // 
            // TrapdoorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnInzetten);
            this.Controls.Add(this.txtInzet);
            this.Controls.Add(this.lblIngezet);
            this.Controls.Add(this.lblTrapdoor);
            this.Name = "TrapdoorView";
            this.Load += new System.EventHandler(this.TrapdoorView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label lblTrapdoor;
    private System.Windows.Forms.Label lblIngezet;
    private System.Windows.Forms.TextBox txtInzet;
        private System.Windows.Forms.Button btnInzetten;
    }
}
