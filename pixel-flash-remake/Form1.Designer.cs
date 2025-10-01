namespace pixel_flash_remake;

partial class Form1
{
    
    private System.Windows.Forms.PictureBox pictureBox;
    private System.ComponentModel.IContainer components = null;
    
    
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        this.pictureBox = new System.Windows.Forms.PictureBox();
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
        this.SuspendLayout();
        // 
        // pictureBox1
        // 
        this.pictureBox.Location = new System.Drawing.Point(12, 12);
        this.pictureBox.Name = "pictureBox";
        this.pictureBox.Size = new System.Drawing.Size(951, 543);
        this.pictureBox.BorderStyle = BorderStyle.FixedSingle;
        this.pictureBox.TabIndex = 0;
        this.pictureBox.TabStop = false;
        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(975, 567);
        this.Controls.Add(this.pictureBox);
        this.Name = "Form1";
        this.Text = "Form1";
        ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
        this.ResumeLayout(false);

    }

    #endregion
}