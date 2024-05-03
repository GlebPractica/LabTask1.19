namespace Task1.Forms
{
    partial class Reflection
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BttnSaveMemCl = new System.Windows.Forms.Button();
            this.BttnPubMeth = new System.Windows.Forms.Button();
            this.BttnFieldsAndProp = new System.Windows.Forms.Button();
            this.BttnInterfaces = new System.Windows.Forms.Button();
            this.BttnMethWithPar = new System.Windows.Forms.Button();
            this.BttnExeMeth = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите название класса с указанием пространства имен";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 20);
            this.textBox1.TabIndex = 1;
            // 
            // BttnSaveMemCl
            // 
            this.BttnSaveMemCl.Location = new System.Drawing.Point(16, 66);
            this.BttnSaveMemCl.Name = "BttnSaveMemCl";
            this.BttnSaveMemCl.Size = new System.Drawing.Size(125, 40);
            this.BttnSaveMemCl.TabIndex = 2;
            this.BttnSaveMemCl.Text = "Сохранить содержимое класса";
            this.BttnSaveMemCl.UseVisualStyleBackColor = true;
            this.BttnSaveMemCl.Click += new System.EventHandler(this.BttnSaveMemCl_Click);
            // 
            // BttnPubMeth
            // 
            this.BttnPubMeth.Location = new System.Drawing.Point(16, 112);
            this.BttnPubMeth.Name = "BttnPubMeth";
            this.BttnPubMeth.Size = new System.Drawing.Size(125, 40);
            this.BttnPubMeth.TabIndex = 3;
            this.BttnPubMeth.Text = "Публичные методы";
            this.BttnPubMeth.UseVisualStyleBackColor = true;
            this.BttnPubMeth.Click += new System.EventHandler(this.BttnPubMeth_Click);
            // 
            // BttnFieldsAndProp
            // 
            this.BttnFieldsAndProp.Location = new System.Drawing.Point(147, 66);
            this.BttnFieldsAndProp.Name = "BttnFieldsAndProp";
            this.BttnFieldsAndProp.Size = new System.Drawing.Size(125, 40);
            this.BttnFieldsAndProp.TabIndex = 4;
            this.BttnFieldsAndProp.Text = "Поля и свойства";
            this.BttnFieldsAndProp.UseVisualStyleBackColor = true;
            this.BttnFieldsAndProp.Click += new System.EventHandler(this.BttnFieldsAndProp_Click);
            // 
            // BttnInterfaces
            // 
            this.BttnInterfaces.Location = new System.Drawing.Point(147, 112);
            this.BttnInterfaces.Name = "BttnInterfaces";
            this.BttnInterfaces.Size = new System.Drawing.Size(125, 40);
            this.BttnInterfaces.TabIndex = 5;
            this.BttnInterfaces.Text = "Интерфейсы";
            this.BttnInterfaces.UseVisualStyleBackColor = true;
            this.BttnInterfaces.Click += new System.EventHandler(this.BttnInterfaces_Click);
            // 
            // BttnMethWithPar
            // 
            this.BttnMethWithPar.Location = new System.Drawing.Point(278, 66);
            this.BttnMethWithPar.Name = "BttnMethWithPar";
            this.BttnMethWithPar.Size = new System.Drawing.Size(125, 40);
            this.BttnMethWithPar.TabIndex = 6;
            this.BttnMethWithPar.Text = "Метод с параметром";
            this.BttnMethWithPar.UseVisualStyleBackColor = true;
            this.BttnMethWithPar.Click += new System.EventHandler(this.BttnMethWithPar_Click);
            // 
            // BttnExeMeth
            // 
            this.BttnExeMeth.Location = new System.Drawing.Point(278, 112);
            this.BttnExeMeth.Name = "BttnExeMeth";
            this.BttnExeMeth.Size = new System.Drawing.Size(125, 40);
            this.BttnExeMeth.TabIndex = 7;
            this.BttnExeMeth.Text = "Вызов метода";
            this.BttnExeMeth.UseVisualStyleBackColor = true;
            this.BttnExeMeth.Click += new System.EventHandler(this.BttnExeMeth_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(16, 169);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(545, 173);
            this.listBox1.TabIndex = 8;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(409, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(152, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(409, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Выберите тип параметра";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(409, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 20);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(409, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Введите название метода";
            // 
            // Reflection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 350);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.BttnExeMeth);
            this.Controls.Add(this.BttnMethWithPar);
            this.Controls.Add(this.BttnInterfaces);
            this.Controls.Add(this.BttnFieldsAndProp);
            this.Controls.Add(this.BttnPubMeth);
            this.Controls.Add(this.BttnSaveMemCl);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Reflection";
            this.Text = "Reflection";
            this.Load += new System.EventHandler(this.Reflection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BttnSaveMemCl;
        private System.Windows.Forms.Button BttnPubMeth;
        private System.Windows.Forms.Button BttnFieldsAndProp;
        private System.Windows.Forms.Button BttnInterfaces;
        private System.Windows.Forms.Button BttnMethWithPar;
        private System.Windows.Forms.Button BttnExeMeth;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
    }
}