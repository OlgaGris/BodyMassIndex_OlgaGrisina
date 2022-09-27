namespace BodyMassIndex
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.weight = new System.Windows.Forms.TextBox();
            this.height = new System.Windows.Forms.TextBox();
            this.result = new System.Windows.Forms.Label();
            this.calculate = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Weight(kg):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Height(cm):";
            // 
            // weight
            // 
            this.weight.Location = new System.Drawing.Point(124, 32);
            this.weight.Name = "weight";
            this.weight.Size = new System.Drawing.Size(88, 23);
            this.weight.TabIndex = 1;
            this.weight.TextChanged += new System.EventHandler(this.weight_TextChanged);
            // 
            // height
            // 
            this.height.Location = new System.Drawing.Point(126, 75);
            this.height.Name = "height";
            this.height.Size = new System.Drawing.Size(88, 23);
            this.height.TabIndex = 2;
            // 
            // result
            // 
            this.result.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.result.Location = new System.Drawing.Point(51, 115);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(293, 93);
            this.result.TabIndex = 2;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(241, 40);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(101, 43);
            this.calculate.TabIndex = 3;
            this.calculate.Text = "Calculate";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.calculate_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(156, 222);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 23);
            this.exit.TabIndex = 4;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 252);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.result);
            this.Controls.Add(this.height);
            this.Controls.Add(this.weight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Body mass index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox weight;
        private TextBox height;
        private Label result;
        private Button calculate;
        private Button exit;
    }
}