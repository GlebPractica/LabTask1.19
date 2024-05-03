namespace Task1.Forms
{
    partial class Auth
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BttnReg = new System.Windows.Forms.Button();
            this.BttnEnter = new System.Windows.Forms.Button();
            this.BttnExit = new System.Windows.Forms.Button();
            this.BttnRefl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(13, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(13, 72);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(259, 20);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль";
            // 
            // BttnReg
            // 
            this.BttnReg.Location = new System.Drawing.Point(13, 139);
            this.BttnReg.Name = "BttnReg";
            this.BttnReg.Size = new System.Drawing.Size(259, 35);
            this.BttnReg.TabIndex = 4;
            this.BttnReg.Text = "Регистрация";
            this.BttnReg.UseVisualStyleBackColor = true;
            this.BttnReg.Click += new System.EventHandler(this.BttnReg_Click);
            // 
            // BttnEnter
            // 
            this.BttnEnter.Location = new System.Drawing.Point(13, 98);
            this.BttnEnter.Name = "BttnEnter";
            this.BttnEnter.Size = new System.Drawing.Size(259, 35);
            this.BttnEnter.TabIndex = 5;
            this.BttnEnter.Text = "Войти";
            this.BttnEnter.UseVisualStyleBackColor = true;
            this.BttnEnter.Click += new System.EventHandler(this.BttnEnter_Click);
            // 
            // BttnExit
            // 
            this.BttnExit.Location = new System.Drawing.Point(13, 180);
            this.BttnExit.Name = "BttnExit";
            this.BttnExit.Size = new System.Drawing.Size(259, 35);
            this.BttnExit.TabIndex = 6;
            this.BttnExit.Text = "Выйти";
            this.BttnExit.UseVisualStyleBackColor = true;
            this.BttnExit.Click += new System.EventHandler(this.BttnExit_Click);
            // 
            // BttnRefl
            // 
            this.BttnRefl.Location = new System.Drawing.Point(12, 221);
            this.BttnRefl.Name = "BttnRefl";
            this.BttnRefl.Size = new System.Drawing.Size(259, 35);
            this.BttnRefl.TabIndex = 7;
            this.BttnRefl.Text = "Рефлексия";
            this.BttnRefl.UseVisualStyleBackColor = true;
            this.BttnRefl.Click += new System.EventHandler(this.BttnRefl_Click);
            // 
            // Auth
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 263);
            this.Controls.Add(this.BttnRefl);
            this.Controls.Add(this.BttnExit);
            this.Controls.Add(this.BttnEnter);
            this.Controls.Add(this.BttnReg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Auth";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Задание";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BttnReg;
        private System.Windows.Forms.Button BttnEnter;
        private System.Windows.Forms.Button BttnExit;
        private System.Windows.Forms.Button BttnRefl;
    }
}

