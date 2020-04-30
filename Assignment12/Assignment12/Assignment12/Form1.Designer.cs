namespace Assignment12
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
            this.btnInterest = new System.Windows.Forms.Button();
            this.boxInterest = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnInterest
            // 
            this.btnInterest.Location = new System.Drawing.Point(13, 23);
            this.btnInterest.Name = "btnInterest";
            this.btnInterest.Size = new System.Drawing.Size(120, 44);
            this.btnInterest.TabIndex = 0;
            this.btnInterest.Text = "Total Interest";
            this.btnInterest.UseVisualStyleBackColor = true;
            this.btnInterest.Click += new System.EventHandler(this.btnInterest_Click);
            // 
            // boxInterest
            // 
            this.boxInterest.Location = new System.Drawing.Point(165, 23);
            this.boxInterest.Name = "boxInterest";
            this.boxInterest.Size = new System.Drawing.Size(126, 44);
            this.boxInterest.TabIndex = 1;
            this.boxInterest.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 391);
            this.Controls.Add(this.boxInterest);
            this.Controls.Add(this.btnInterest);
            this.Name = "Form1";
            this.Text = "What I\'ve Learned";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnInterest;
        private System.Windows.Forms.RichTextBox boxInterest;
    }
}

