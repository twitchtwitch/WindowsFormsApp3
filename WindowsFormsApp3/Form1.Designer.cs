namespace WindowsFormsApp3
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.status = new System.Windows.Forms.TextBox();
            this.chance = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 90);
            this.button1.TabIndex = 0;
            this.button1.Text = "攻撃";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "現在の命中率";
            // 
            // status
            // 
            this.status.Location = new System.Drawing.Point(320, 109);
            this.status.Multiline = true;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(100, 65);
            this.status.TabIndex = 2;
            // 
            // chance
            // 
            this.chance.Location = new System.Drawing.Point(47, 120);
            this.chance.Multiline = true;
            this.chance.Name = "chance";
            this.chance.Size = new System.Drawing.Size(65, 49);
            this.chance.TabIndex = 3;
            this.chance.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(356, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "結果";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // title
            // 
            this.title.Location = new System.Drawing.Point(73, 12);
            this.title.Multiline = true;
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(347, 44);
            this.title.TabIndex = 5;
            this.title.Text = "　　　　　　　　　　　　　　　　　　　Hello";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 224);
            this.Controls.Add(this.title);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chance);
            this.Controls.Add(this.status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox status;
        private System.Windows.Forms.TextBox chance;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox title;
    }
}

