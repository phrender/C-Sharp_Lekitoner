namespace WinFormsGraphics_uppgift_2
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
            this.btnBottomLane = new System.Windows.Forms.Button();
            this.btnTopLaneDrive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBottomLane
            // 
            this.btnBottomLane.Location = new System.Drawing.Point(297, 41);
            this.btnBottomLane.Name = "btnBottomLane";
            this.btnBottomLane.Size = new System.Drawing.Size(75, 23);
            this.btnBottomLane.TabIndex = 3;
            this.btnBottomLane.Text = "Bottom Lane";
            this.btnBottomLane.UseVisualStyleBackColor = true;
            this.btnBottomLane.Click += new System.EventHandler(this.btnBottomLane_Click);
            // 
            // btnTopLaneDrive
            // 
            this.btnTopLaneDrive.Location = new System.Drawing.Point(297, 12);
            this.btnTopLaneDrive.Name = "btnTopLaneDrive";
            this.btnTopLaneDrive.Size = new System.Drawing.Size(75, 23);
            this.btnTopLaneDrive.TabIndex = 2;
            this.btnTopLaneDrive.Text = "Top lane";
            this.btnTopLaneDrive.UseVisualStyleBackColor = true;
            this.btnTopLaneDrive.Click += new System.EventHandler(this.btnTopLaneDrive_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 362);
            this.Controls.Add(this.btnBottomLane);
            this.Controls.Add(this.btnTopLaneDrive);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBottomLane;
        private System.Windows.Forms.Button btnTopLaneDrive;
    }
}

