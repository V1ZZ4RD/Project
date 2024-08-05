
namespace Tipography
{
    partial class Add_FormClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_FormClient));
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Fio = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Organization = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.maskedTextBox_Phone = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(164, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(186, 151);
            this.textBox_Address.Multiline = true;
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(200, 23);
            this.textBox_Address.TabIndex = 3;
            // 
            // textBox_Fio
            // 
            this.textBox_Fio.Location = new System.Drawing.Point(186, 94);
            this.textBox_Fio.Multiline = true;
            this.textBox_Fio.Name = "textBox_Fio";
            this.textBox_Fio.Size = new System.Drawing.Size(200, 23);
            this.textBox_Fio.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(385, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(51, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label7.Location = new System.Drawing.Point(119, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Адрес:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label6.Location = new System.Drawing.Point(113, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 18;
            this.label6.Text = "Номер:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label3.Location = new System.Drawing.Point(127, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 15;
            this.label3.Text = "ФИО:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(439, 64);
            this.label1.TabIndex = 14;
            this.label1.Text = "Создание записи:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label2.Location = new System.Drawing.Point(61, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 23);
            this.label2.TabIndex = 27;
            this.label2.Text = "Организация:";
            // 
            // textBox_Organization
            // 
            this.textBox_Organization.Location = new System.Drawing.Point(186, 180);
            this.textBox_Organization.Multiline = true;
            this.textBox_Organization.Name = "textBox_Organization";
            this.textBox_Organization.Size = new System.Drawing.Size(200, 23);
            this.textBox_Organization.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label8.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(13, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Клиенты";
            // 
            // maskedTextBox_Phone
            // 
            this.maskedTextBox_Phone.Location = new System.Drawing.Point(186, 123);
            this.maskedTextBox_Phone.Mask = "+7 (000) 000-00-00";
            this.maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            this.maskedTextBox_Phone.Size = new System.Drawing.Size(200, 22);
            this.maskedTextBox_Phone.TabIndex = 2;
            // 
            // Add_FormClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(458, 282);
            this.Controls.Add(this.maskedTextBox_Phone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Organization);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_Address);
            this.Controls.Add(this.textBox_Fio);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Add_FormClient";
            this.Text = "Новая запись";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Fio;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Organization;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Phone;
    }
}