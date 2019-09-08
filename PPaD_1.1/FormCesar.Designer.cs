namespace PPaD_1._1
{
    partial class FormCesar
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
            this.numericUpDownShift = new System.Windows.Forms.NumericUpDown();
            this.textBoxEncryptOriginal = new System.Windows.Forms.TextBox();
            this.textBoxEncrypt = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxDecryptOriginal = new System.Windows.Forms.TextBox();
            this.textBoxDecrypt = new System.Windows.Forms.TextBox();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShift)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(33, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Encrypt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(33, 288);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Decrypt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "shift";
            // 
            // numericUpDownShift
            // 
            this.numericUpDownShift.Location = new System.Drawing.Point(299, 22);
            this.numericUpDownShift.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownShift.Name = "numericUpDownShift";
            this.numericUpDownShift.ReadOnly = true;
            this.numericUpDownShift.Size = new System.Drawing.Size(67, 22);
            this.numericUpDownShift.TabIndex = 3;
            this.numericUpDownShift.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // textBoxEncryptOriginal
            // 
            this.textBoxEncryptOriginal.Location = new System.Drawing.Point(142, 116);
            this.textBoxEncryptOriginal.Multiline = true;
            this.textBoxEncryptOriginal.Name = "textBoxEncryptOriginal";
            this.textBoxEncryptOriginal.Size = new System.Drawing.Size(585, 48);
            this.textBoxEncryptOriginal.TabIndex = 4;
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Location = new System.Drawing.Point(142, 180);
            this.textBoxEncrypt.Multiline = true;
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.ReadOnly = true;
            this.textBoxEncrypt.Size = new System.Drawing.Size(585, 48);
            this.textBoxEncrypt.TabIndex = 4;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(142, 246);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(585, 39);
            this.buttonEncrypt.TabIndex = 5;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // textBoxDecryptOriginal
            // 
            this.textBoxDecryptOriginal.Location = new System.Drawing.Point(142, 330);
            this.textBoxDecryptOriginal.Multiline = true;
            this.textBoxDecryptOriginal.Name = "textBoxDecryptOriginal";
            this.textBoxDecryptOriginal.Size = new System.Drawing.Size(585, 48);
            this.textBoxDecryptOriginal.TabIndex = 4;
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Location = new System.Drawing.Point(142, 394);
            this.textBoxDecrypt.Multiline = true;
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.ReadOnly = true;
            this.textBoxDecrypt.Size = new System.Drawing.Size(585, 48);
            this.textBoxDecrypt.TabIndex = 4;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(142, 460);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(585, 39);
            this.buttonDecrypt.TabIndex = 5;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // FormCesar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 539);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxDecrypt);
            this.Controls.Add(this.textBoxDecryptOriginal);
            this.Controls.Add(this.textBoxEncrypt);
            this.Controls.Add(this.textBoxEncryptOriginal);
            this.Controls.Add(this.numericUpDownShift);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormCesar";
            this.Text = "FormCesar";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShift)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownShift;
        private System.Windows.Forms.TextBox textBoxEncryptOriginal;
        private System.Windows.Forms.TextBox textBoxEncrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxDecryptOriginal;
        private System.Windows.Forms.TextBox textBoxDecrypt;
        private System.Windows.Forms.Button buttonDecrypt;
    }
}