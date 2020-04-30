namespace Conway_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.totalDomestic = new System.Windows.Forms.RichTextBox();
            this.totalInternational = new System.Windows.Forms.RichTextBox();
            this.totalCompany = new System.Windows.Forms.RichTextBox();
            this.btnTotal = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Domestic:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total International:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Company:";
            // 
            // totalDomestic
            // 
            this.totalDomestic.Location = new System.Drawing.Point(197, 33);
            this.totalDomestic.Name = "totalDomestic";
            this.totalDomestic.Size = new System.Drawing.Size(140, 28);
            this.totalDomestic.TabIndex = 3;
            this.totalDomestic.Text = "";
            // 
            // totalInternational
            // 
            this.totalInternational.Location = new System.Drawing.Point(197, 86);
            this.totalInternational.Name = "totalInternational";
            this.totalInternational.Size = new System.Drawing.Size(140, 28);
            this.totalInternational.TabIndex = 4;
            this.totalInternational.Text = "";
            // 
            // totalCompany
            // 
            this.totalCompany.Location = new System.Drawing.Point(197, 138);
            this.totalCompany.Name = "totalCompany";
            this.totalCompany.Size = new System.Drawing.Size(140, 28);
            this.totalCompany.TabIndex = 5;
            this.totalCompany.Text = "";
            // 
            // btnTotal
            // 
            this.btnTotal.Location = new System.Drawing.Point(55, 203);
            this.btnTotal.Name = "btnTotal";
            this.btnTotal.Size = new System.Drawing.Size(104, 23);
            this.btnTotal.TabIndex = 6;
            this.btnTotal.Text = "Display Totals";
            this.btnTotal.UseVisualStyleBackColor = true;
            this.btnTotal.Click += new System.EventHandler(this.btnTotal_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(177, 203);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(104, 23);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseMnemonic = false;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 249);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnTotal);
            this.Controls.Add(this.totalCompany);
            this.Controls.Add(this.totalInternational);
            this.Controls.Add(this.totalDomestic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Conway Enterprises";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox totalDomestic;
        private System.Windows.Forms.RichTextBox totalInternational;
        private System.Windows.Forms.RichTextBox totalCompany;
        private System.Windows.Forms.Button btnTotal;
        private System.Windows.Forms.Button btnExit;
    }
}

