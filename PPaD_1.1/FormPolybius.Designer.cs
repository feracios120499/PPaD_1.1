﻿namespace PPaD_1._1
{
    partial class FormPolybius
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
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.textBoxDecrypt = new System.Windows.Forms.TextBox();
            this.textBoxDecryptOriginal = new System.Windows.Forms.TextBox();
            this.textBoxEncrypt = new System.Windows.Forms.TextBox();
            this.textBoxEncryptOriginal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxKey
            // 
            this.textBoxKey.Location = new System.Drawing.Point(207, 27);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(132, 22);
            this.textBoxKey.TabIndex = 27;
            this.textBoxKey.Text = "ключ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Key";
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(134, 463);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(585, 39);
            this.buttonDecrypt.TabIndex = 24;
            this.buttonDecrypt.Text = "Decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.ButtonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(134, 249);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(585, 39);
            this.buttonEncrypt.TabIndex = 25;
            this.buttonEncrypt.Text = "Encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.ButtonEncrypt_Click);
            // 
            // textBoxDecrypt
            // 
            this.textBoxDecrypt.Location = new System.Drawing.Point(134, 397);
            this.textBoxDecrypt.Multiline = true;
            this.textBoxDecrypt.Name = "textBoxDecrypt";
            this.textBoxDecrypt.ReadOnly = true;
            this.textBoxDecrypt.Size = new System.Drawing.Size(585, 48);
            this.textBoxDecrypt.TabIndex = 20;
            // 
            // textBoxDecryptOriginal
            // 
            this.textBoxDecryptOriginal.Location = new System.Drawing.Point(134, 333);
            this.textBoxDecryptOriginal.Multiline = true;
            this.textBoxDecryptOriginal.Name = "textBoxDecryptOriginal";
            this.textBoxDecryptOriginal.Size = new System.Drawing.Size(585, 48);
            this.textBoxDecryptOriginal.TabIndex = 21;
            // 
            // textBoxEncrypt
            // 
            this.textBoxEncrypt.Location = new System.Drawing.Point(134, 183);
            this.textBoxEncrypt.Multiline = true;
            this.textBoxEncrypt.Name = "textBoxEncrypt";
            this.textBoxEncrypt.ReadOnly = true;
            this.textBoxEncrypt.Size = new System.Drawing.Size(585, 48);
            this.textBoxEncrypt.TabIndex = 22;
            // 
            // textBoxEncryptOriginal
            // 
            this.textBoxEncryptOriginal.Location = new System.Drawing.Point(134, 119);
            this.textBoxEncryptOriginal.Multiline = true;
            this.textBoxEncryptOriginal.Name = "textBoxEncryptOriginal";
            this.textBoxEncryptOriginal.Size = new System.Drawing.Size(585, 48);
            this.textBoxEncryptOriginal.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(25, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "Decrypt";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 32);
            this.label1.TabIndex = 18;
            this.label1.Text = "Encrypt";
            // 
            // FormPolybius
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 541);
            this.Controls.Add(this.textBoxKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.textBoxDecrypt);
            this.Controls.Add(this.textBoxDecryptOriginal);
            this.Controls.Add(this.textBoxEncrypt);
            this.Controls.Add(this.textBoxEncryptOriginal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormPolybius";
            this.Text = "FormPolybius";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.TextBox textBoxDecrypt;
        private System.Windows.Forms.TextBox textBoxDecryptOriginal;
        private System.Windows.Forms.TextBox textBoxEncrypt;
        private System.Windows.Forms.TextBox textBoxEncryptOriginal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}