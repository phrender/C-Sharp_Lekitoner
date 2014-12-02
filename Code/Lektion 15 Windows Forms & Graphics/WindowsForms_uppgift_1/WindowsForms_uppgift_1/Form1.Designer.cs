namespace WindowsForms_uppgift_1
{
    partial class Form1
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
            this.lbValue2 = new System.Windows.Forms.Label();
            this.lbValue1 = new System.Windows.Forms.Label();
            this.tbValue2 = new System.Windows.Forms.TextBox();
            this.tbValue1 = new System.Windows.Forms.TextBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.btCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbValue2
            // 
            this.lbValue2.AutoSize = true;
            this.lbValue2.Location = new System.Drawing.Point(172, 46);
            this.lbValue2.Name = "lbValue2";
            this.lbValue2.Size = new System.Drawing.Size(46, 13);
            this.lbValue2.TabIndex = 11;
            this.lbValue2.Text = "Value 2:";
            // 
            // lbValue1
            // 
            this.lbValue1.AutoSize = true;
            this.lbValue1.Location = new System.Drawing.Point(12, 46);
            this.lbValue1.Name = "lbValue1";
            this.lbValue1.Size = new System.Drawing.Size(46, 13);
            this.lbValue1.TabIndex = 10;
            this.lbValue1.Text = "Value 1:";
            // 
            // tbValue2
            // 
            this.tbValue2.Location = new System.Drawing.Point(172, 65);
            this.tbValue2.Name = "tbValue2";
            this.tbValue2.Size = new System.Drawing.Size(100, 20);
            this.tbValue2.TabIndex = 9;
            // 
            // tbValue1
            // 
            this.tbValue1.Location = new System.Drawing.Point(12, 65);
            this.tbValue1.Name = "tbValue1";
            this.tbValue1.Size = new System.Drawing.Size(100, 20);
            this.tbValue1.TabIndex = 8;
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Location = new System.Drawing.Point(107, 139);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(0, 13);
            this.lbResult.TabIndex = 7;
            // 
            // btCompare
            // 
            this.btCompare.Location = new System.Drawing.Point(105, 194);
            this.btCompare.Name = "btCompare";
            this.btCompare.Size = new System.Drawing.Size(75, 23);
            this.btCompare.TabIndex = 6;
            this.btCompare.Text = "Compare";
            this.btCompare.UseVisualStyleBackColor = true;
            this.btCompare.Click += new System.EventHandler(this.btCompare_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbValue2);
            this.Controls.Add(this.lbValue1);
            this.Controls.Add(this.tbValue2);
            this.Controls.Add(this.tbValue1);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btCompare);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbValue2;
        private System.Windows.Forms.Label lbValue1;
        private System.Windows.Forms.TextBox tbValue2;
        private System.Windows.Forms.TextBox tbValue1;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Button btCompare;
    }
}

