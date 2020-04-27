namespace EkstraArray
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTask3 = new System.Windows.Forms.TextBox();
            this.labelInfoTask3 = new System.Windows.Forms.Label();
            this.buttonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(67, 83);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(258, 404);
            this.listBox1.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 25;
            this.listBox2.Location = new System.Drawing.Point(359, 83);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(258, 404);
            this.listBox2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "Task 1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(669, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "Task 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(669, 328);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(159, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "Task 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 6;
            // 
            // textBoxTask3
            // 
            this.textBoxTask3.Location = new System.Drawing.Point(669, 291);
            this.textBoxTask3.Name = "textBoxTask3";
            this.textBoxTask3.Size = new System.Drawing.Size(159, 31);
            this.textBoxTask3.TabIndex = 7;
            // 
            // labelInfoTask3
            // 
            this.labelInfoTask3.AutoSize = true;
            this.labelInfoTask3.Location = new System.Drawing.Point(834, 294);
            this.labelInfoTask3.Name = "labelInfoTask3";
            this.labelInfoTask3.Size = new System.Drawing.Size(326, 25);
            this.labelInfoTask3.TabIndex = 8;
            this.labelInfoTask3.Text = "Write a number and click Task 3.";
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(669, 438);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(159, 49);
            this.buttonClear.TabIndex = 9;
            this.buttonClear.Text = "Clear Boxes";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 621);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.labelInfoTask3);
            this.Controls.Add(this.textBoxTask3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTask3;
        private System.Windows.Forms.Label labelInfoTask3;
        private System.Windows.Forms.Button buttonClear;
    }
}

