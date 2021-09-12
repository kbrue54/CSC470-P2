
namespace CSC470_P2
{
    partial class FormSeeFish
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cancel_bt = new System.Windows.Forms.Button();
            this.keepIt_bt = new System.Windows.Forms.Button();
            this.throwItBack_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(322, 220);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cancel_bt
            // 
            this.cancel_bt.Location = new System.Drawing.Point(12, 266);
            this.cancel_bt.Name = "cancel_bt";
            this.cancel_bt.Size = new System.Drawing.Size(96, 27);
            this.cancel_bt.TabIndex = 1;
            this.cancel_bt.Text = "Cancel";
            this.cancel_bt.UseVisualStyleBackColor = true;
            // 
            // keepIt_bt
            // 
            this.keepIt_bt.Location = new System.Drawing.Point(238, 266);
            this.keepIt_bt.Name = "keepIt_bt";
            this.keepIt_bt.Size = new System.Drawing.Size(96, 27);
            this.keepIt_bt.TabIndex = 2;
            this.keepIt_bt.Text = "Keep It";
            this.keepIt_bt.UseVisualStyleBackColor = true;
            // 
            // throwItBack_bt
            // 
            this.throwItBack_bt.Location = new System.Drawing.Point(125, 266);
            this.throwItBack_bt.Name = "throwItBack_bt";
            this.throwItBack_bt.Size = new System.Drawing.Size(96, 27);
            this.throwItBack_bt.TabIndex = 3;
            this.throwItBack_bt.Text = "Throw it Back";
            this.throwItBack_bt.UseVisualStyleBackColor = true;
            // 
            // FormSeeFish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 337);
            this.Controls.Add(this.throwItBack_bt);
            this.Controls.Add(this.keepIt_bt);
            this.Controls.Add(this.cancel_bt);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormSeeFish";
            this.Text = "Keep it or let it go";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cancel_bt;
        private System.Windows.Forms.Button keepIt_bt;
        private System.Windows.Forms.Button throwItBack_bt;
    }
}