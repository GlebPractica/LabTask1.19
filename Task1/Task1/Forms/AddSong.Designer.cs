namespace Task1.Forms
{
    partial class AddSong
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BttnEnter = new System.Windows.Forms.Button();
            this.BttnCheckResults = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Название песни";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Автор";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(352, 20);
            this.textBox2.TabIndex = 2;
            // 
            // BttnEnter
            // 
            this.BttnEnter.Location = new System.Drawing.Point(13, 102);
            this.BttnEnter.Name = "BttnEnter";
            this.BttnEnter.Size = new System.Drawing.Size(351, 39);
            this.BttnEnter.TabIndex = 4;
            this.BttnEnter.Text = "Принять";
            this.BttnEnter.UseVisualStyleBackColor = true;
            this.BttnEnter.Click += new System.EventHandler(this.BttnEnter_Click);
            // 
            // BttnCheckResults
            // 
            this.BttnCheckResults.Location = new System.Drawing.Point(13, 148);
            this.BttnCheckResults.Name = "BttnCheckResults";
            this.BttnCheckResults.Size = new System.Drawing.Size(351, 40);
            this.BttnCheckResults.TabIndex = 5;
            this.BttnCheckResults.Text = "Просмотреть результаты";
            this.BttnCheckResults.UseVisualStyleBackColor = true;
            this.BttnCheckResults.Click += new System.EventHandler(this.BttnCheckResults_Click);
            // 
            // AddSong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 200);
            this.Controls.Add(this.BttnCheckResults);
            this.Controls.Add(this.BttnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "AddSong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Проголосовать за песню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BttnEnter;
        private System.Windows.Forms.Button BttnCheckResults;
    }
}