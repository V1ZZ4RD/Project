
namespace Tipography
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.imgUpdate = new System.Windows.Forms.PictureBox();
            this.imgClear = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox_Phone = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_Organization = new System.Windows.Forms.TextBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_Address = new System.Windows.Forms.TextBox();
            this.textBox_Fio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClear)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(865, 71);
            this.label1.TabIndex = 1;
            this.label1.Text = "Клиенты";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(551, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 35);
            this.label8.TabIndex = 16;
            this.label8.Text = "Управление записями";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.Controls.Add(this.button_Save);
            this.groupBox2.Controls.Add(this.button_Update);
            this.groupBox2.Controls.Add(this.button_Delete);
            this.groupBox2.Controls.Add(this.button_New);
            this.groupBox2.Location = new System.Drawing.Point(603, 504);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 212);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // button_Save
            // 
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.Location = new System.Drawing.Point(24, 159);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(142, 40);
            this.button_Save.TabIndex = 3;
            this.button_Save.Text = "Сохранить";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_Update
            // 
            this.button_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Update.Location = new System.Drawing.Point(24, 67);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(142, 40);
            this.button_Update.TabIndex = 1;
            this.button_Update.Text = "Изменить";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Delete.Location = new System.Drawing.Point(24, 113);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(142, 40);
            this.button_Delete.TabIndex = 2;
            this.button_Delete.Text = "Удалить";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_New
            // 
            this.button_New.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_New.Location = new System.Drawing.Point(24, 21);
            this.button_New.Name = "button_New";
            this.button_New.Size = new System.Drawing.Size(142, 40);
            this.button_New.TabIndex = 0;
            this.button_New.Text = "Новая запись";
            this.button_New.UseVisualStyleBackColor = true;
            this.button_New.Click += new System.EventHandler(this.button_New_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 83);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(867, 362);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(545, 27);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(320, 37);
            this.textBox_Search.TabIndex = 8;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // imgSearch
            // 
            this.imgSearch.Image = ((System.Drawing.Image)(resources.GetObject("imgSearch.Image")));
            this.imgSearch.Location = new System.Drawing.Point(486, 27);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(53, 37);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearch.TabIndex = 11;
            this.imgSearch.TabStop = false;
            // 
            // imgUpdate
            // 
            this.imgUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgUpdate.Image = ((System.Drawing.Image)(resources.GetObject("imgUpdate.Image")));
            this.imgUpdate.Location = new System.Drawing.Point(393, 27);
            this.imgUpdate.Name = "imgUpdate";
            this.imgUpdate.Size = new System.Drawing.Size(53, 37);
            this.imgUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUpdate.TabIndex = 10;
            this.imgUpdate.TabStop = false;
            this.imgUpdate.Click += new System.EventHandler(this.imgUpdate_Click);
            // 
            // imgClear
            // 
            this.imgClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClear.Image = ((System.Drawing.Image)(resources.GetObject("imgClear.Image")));
            this.imgClear.Location = new System.Drawing.Point(334, 27);
            this.imgClear.Name = "imgClear";
            this.imgClear.Size = new System.Drawing.Size(53, 37);
            this.imgClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClear.TabIndex = 9;
            this.imgClear.TabStop = false;
            this.imgClear.Click += new System.EventHandler(this.imgClear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.maskedTextBox_Phone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBox_Organization);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.textBox_Address);
            this.groupBox1.Controls.Add(this.textBox_Fio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 300);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // maskedTextBox_Phone
            // 
            this.maskedTextBox_Phone.Location = new System.Drawing.Point(193, 129);
            this.maskedTextBox_Phone.Mask = "+7 (000) 000-00-00";
            this.maskedTextBox_Phone.Name = "maskedTextBox_Phone";
            this.maskedTextBox_Phone.Size = new System.Drawing.Size(263, 22);
            this.maskedTextBox_Phone.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label10.Location = new System.Drawing.Point(63, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(119, 23);
            this.label10.TabIndex = 15;
            this.label10.Text = "Организация:";
            // 
            // textBox_Organization
            // 
            this.textBox_Organization.Location = new System.Drawing.Point(193, 202);
            this.textBox_Organization.Name = "textBox_Organization";
            this.textBox_Organization.Size = new System.Drawing.Size(263, 22);
            this.textBox_Organization.TabIndex = 7;
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(193, 61);
            this.textBox_id.Multiline = true;
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(41, 23);
            this.textBox_id.TabIndex = 12;
            this.textBox_id.Visible = false;
            // 
            // textBox_Address
            // 
            this.textBox_Address.Location = new System.Drawing.Point(193, 166);
            this.textBox_Address.Name = "textBox_Address";
            this.textBox_Address.Size = new System.Drawing.Size(263, 22);
            this.textBox_Address.TabIndex = 6;
            // 
            // textBox_Fio
            // 
            this.textBox_Fio.Location = new System.Drawing.Point(193, 93);
            this.textBox_Fio.Multiline = true;
            this.textBox_Fio.Name = "textBox_Fio";
            this.textBox_Fio.Size = new System.Drawing.Size(263, 22);
            this.textBox_Fio.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label7.Location = new System.Drawing.Point(126, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Адрес:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label6.Location = new System.Drawing.Point(105, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Телефон:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(134, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "ФИО:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Редактирование";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(888, 767);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.imgSearch);
            this.Controls.Add(this.imgUpdate);
            this.Controls.Add(this.imgClear);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Client";
            this.Text = "Клиенты";
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClear)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.PictureBox imgUpdate;
        private System.Windows.Forms.PictureBox imgClear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_Address;
        private System.Windows.Forms.TextBox textBox_Fio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_Organization;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_Phone;
        private System.Windows.Forms.TextBox textBox_id;
    }
}