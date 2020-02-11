namespace Geometric_Shapes
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
            this.txtRadius = new System.Windows.Forms.TextBox();
            this.txtHeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxSurface = new System.Windows.Forms.CheckBox();
            this.checkBoxVolume = new System.Windows.Forms.CheckBox();
            this.radioSphere = new System.Windows.Forms.RadioButton();
            this.radioCylinder = new System.Windows.Forms.RadioButton();
            this.radioCone = new System.Windows.Forms.RadioButton();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.solutionTextBox = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.Location = new System.Drawing.Point(24, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Radius";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label2.Location = new System.Drawing.Point(24, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // txtRadius
            // 
            this.txtRadius.Location = new System.Drawing.Point(98, 41);
            this.txtRadius.Name = "txtRadius";
            this.txtRadius.Size = new System.Drawing.Size(102, 20);
            this.txtRadius.TabIndex = 2;
            // 
            // txtHeight
            // 
            this.txtHeight.Location = new System.Drawing.Point(98, 79);
            this.txtHeight.Name = "txtHeight";
            this.txtHeight.Size = new System.Drawing.Size(102, 20);
            this.txtHeight.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label3.Location = new System.Drawing.Point(24, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(282, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Please select a geometric shape";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label4.Location = new System.Drawing.Point(24, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(331, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Please select parameter(s) to calculate";
            // 
            // checkBoxSurface
            // 
            this.checkBoxSurface.AutoSize = true;
            this.checkBoxSurface.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxSurface.Location = new System.Drawing.Point(28, 324);
            this.checkBoxSurface.Name = "checkBoxSurface";
            this.checkBoxSurface.Size = new System.Drawing.Size(110, 21);
            this.checkBoxSurface.TabIndex = 6;
            this.checkBoxSurface.Text = "Surface Area";
            this.checkBoxSurface.UseVisualStyleBackColor = true;
            // 
            // checkBoxVolume
            // 
            this.checkBoxVolume.AutoSize = true;
            this.checkBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxVolume.Location = new System.Drawing.Point(28, 351);
            this.checkBoxVolume.Name = "checkBoxVolume";
            this.checkBoxVolume.Size = new System.Drawing.Size(74, 21);
            this.checkBoxVolume.TabIndex = 7;
            this.checkBoxVolume.Text = "Volume";
            this.checkBoxVolume.UseVisualStyleBackColor = true;
            // 
            // radioSphere
            // 
            this.radioSphere.AutoSize = true;
            this.radioSphere.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioSphere.Location = new System.Drawing.Point(28, 183);
            this.radioSphere.Name = "radioSphere";
            this.radioSphere.Size = new System.Drawing.Size(72, 21);
            this.radioSphere.TabIndex = 8;
            this.radioSphere.TabStop = true;
            this.radioSphere.Text = "Sphere";
            this.radioSphere.UseVisualStyleBackColor = true;
            // 
            // radioCylinder
            // 
            this.radioCylinder.AutoSize = true;
            this.radioCylinder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioCylinder.Location = new System.Drawing.Point(28, 210);
            this.radioCylinder.Name = "radioCylinder";
            this.radioCylinder.Size = new System.Drawing.Size(77, 21);
            this.radioCylinder.TabIndex = 9;
            this.radioCylinder.TabStop = true;
            this.radioCylinder.Text = "Cylinder";
            this.radioCylinder.UseVisualStyleBackColor = true;
            // 
            // radioCone
            // 
            this.radioCone.AutoSize = true;
            this.radioCone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.radioCone.Location = new System.Drawing.Point(28, 237);
            this.radioCone.Name = "radioCone";
            this.radioCone.Size = new System.Drawing.Size(59, 21);
            this.radioCone.TabIndex = 10;
            this.radioCone.TabStop = true;
            this.radioCone.Text = "Cone";
            this.radioCone.UseVisualStyleBackColor = true;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnCalculate.Location = new System.Drawing.Point(439, 144);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(129, 48);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnExit.Location = new System.Drawing.Point(439, 222);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(129, 48);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // solutionTextBox
            // 
            this.solutionTextBox.Location = new System.Drawing.Point(28, 400);
            this.solutionTextBox.Name = "solutionTextBox";
            this.solutionTextBox.Size = new System.Drawing.Size(540, 96);
            this.solutionTextBox.TabIndex = 13;
            this.solutionTextBox.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(376, 527);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(192, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "Created by: Timon Nadarevic";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 553);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.solutionTextBox);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.radioCone);
            this.Controls.Add(this.radioCylinder);
            this.Controls.Add(this.radioSphere);
            this.Controls.Add(this.checkBoxVolume);
            this.Controls.Add(this.checkBoxSurface);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHeight);
            this.Controls.Add(this.txtRadius);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Geometric Shapes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRadius;
        private System.Windows.Forms.TextBox txtHeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxSurface;
        private System.Windows.Forms.CheckBox checkBoxVolume;
        private System.Windows.Forms.RadioButton radioSphere;
        private System.Windows.Forms.RadioButton radioCylinder;
        private System.Windows.Forms.RadioButton radioCone;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RichTextBox solutionTextBox;
        private System.Windows.Forms.Label label5;
    }
}

