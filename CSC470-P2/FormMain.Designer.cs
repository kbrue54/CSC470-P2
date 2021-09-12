
namespace CSC470_P2
{
    partial class FormMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seeFish_bt = new System.Windows.Forms.Button();
            this.crappieSelected_rbt = new System.Windows.Forms.RadioButton();
            this.perchSelected_rbt = new System.Windows.Forms.RadioButton();
            this.walleySelected_rbt = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.walleySelected_rbt);
            this.groupBox1.Controls.Add(this.perchSelected_rbt);
            this.groupBox1.Controls.Add(this.crappieSelected_rbt);
            this.groupBox1.Location = new System.Drawing.Point(29, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 140);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose a fish to see";
            // 
            // seeFish_bt
            // 
            this.seeFish_bt.Location = new System.Drawing.Point(182, 188);
            this.seeFish_bt.Name = "seeFish_bt";
            this.seeFish_bt.Size = new System.Drawing.Size(75, 23);
            this.seeFish_bt.TabIndex = 1;
            this.seeFish_bt.Text = "See Fish";
            this.seeFish_bt.UseVisualStyleBackColor = true;
            // 
            // crappieSelected_rbt
            // 
            this.crappieSelected_rbt.AutoSize = true;
            this.crappieSelected_rbt.Location = new System.Drawing.Point(33, 32);
            this.crappieSelected_rbt.Name = "crappieSelected_rbt";
            this.crappieSelected_rbt.Size = new System.Drawing.Size(61, 17);
            this.crappieSelected_rbt.TabIndex = 0;
            this.crappieSelected_rbt.TabStop = true;
            this.crappieSelected_rbt.Text = "Crappie";
            this.crappieSelected_rbt.UseVisualStyleBackColor = true;
            // 
            // perchSelected_rbt
            // 
            this.perchSelected_rbt.AutoSize = true;
            this.perchSelected_rbt.Location = new System.Drawing.Point(33, 66);
            this.perchSelected_rbt.Name = "perchSelected_rbt";
            this.perchSelected_rbt.Size = new System.Drawing.Size(53, 17);
            this.perchSelected_rbt.TabIndex = 1;
            this.perchSelected_rbt.TabStop = true;
            this.perchSelected_rbt.Text = "Perch";
            this.perchSelected_rbt.UseVisualStyleBackColor = true;
            // 
            // walleySelected_rbt
            // 
            this.walleySelected_rbt.AutoSize = true;
            this.walleySelected_rbt.Location = new System.Drawing.Point(33, 99);
            this.walleySelected_rbt.Name = "walleySelected_rbt";
            this.walleySelected_rbt.Size = new System.Drawing.Size(63, 17);
            this.walleySelected_rbt.TabIndex = 2;
            this.walleySelected_rbt.TabStop = true;
            this.walleySelected_rbt.Text = "Walleye";
            this.walleySelected_rbt.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(299, 223);
            this.Controls.Add(this.seeFish_bt);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormMain";
            this.Text = "CSC470 - P2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button seeFish_bt;
        private System.Windows.Forms.RadioButton walleySelected_rbt;
        private System.Windows.Forms.RadioButton perchSelected_rbt;
        private System.Windows.Forms.RadioButton crappieSelected_rbt;
    }
}

