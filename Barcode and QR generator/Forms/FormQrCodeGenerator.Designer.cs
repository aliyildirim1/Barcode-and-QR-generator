namespace Barcode_and_QR_generator.Forms
{
    partial class FormQrCodeGenerator
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
            this.btnGenerateQr = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxQrImageData = new System.Windows.Forms.TextBox();
            this.tbxQrImageFileName = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenerateQr
            // 
            this.btnGenerateQr.BackColor = System.Drawing.Color.White;
            this.btnGenerateQr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGenerateQr.Location = new System.Drawing.Point(304, 153);
            this.btnGenerateQr.Name = "btnGenerateQr";
            this.btnGenerateQr.Size = new System.Drawing.Size(154, 43);
            this.btnGenerateQr.TabIndex = 0;
            this.btnGenerateQr.Text = "Qr Kod Oluştur";
            this.btnGenerateQr.UseVisualStyleBackColor = false;
            this.btnGenerateQr.Click += new System.EventHandler(this.btnGenerateQr_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Qr kod linkini giriniz : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Qr kod dosya ismini giriniz :";
            // 
            // tbxQrImageData
            // 
            this.tbxQrImageData.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxQrImageData.Location = new System.Drawing.Point(242, 37);
            this.tbxQrImageData.Name = "tbxQrImageData";
            this.tbxQrImageData.Size = new System.Drawing.Size(216, 30);
            this.tbxQrImageData.TabIndex = 5;
            // 
            // tbxQrImageFileName
            // 
            this.tbxQrImageFileName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbxQrImageFileName.Location = new System.Drawing.Point(242, 91);
            this.tbxQrImageFileName.Name = "tbxQrImageFileName";
            this.tbxQrImageFileName.Size = new System.Drawing.Size(216, 30);
            this.tbxQrImageFileName.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(242, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // FormQrCodeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbxQrImageFileName);
            this.Controls.Add(this.tbxQrImageData);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerateQr);
            this.Name = "FormQrCodeGenerator";
            this.Text = "QR Uygulaması";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnGenerateQr;
        private Label label1;
        private Label label2;
        private TextBox tbxQrImageData;
        private TextBox tbxQrImageFileName;
        private PictureBox pictureBox1;
    }
}