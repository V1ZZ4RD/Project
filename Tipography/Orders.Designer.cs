
namespace Tipography
{
    partial class Orders
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders));
            this.label1 = new System.Windows.Forms.Label();
            this.imgClear = new System.Windows.Forms.PictureBox();
            this.imgUpdate = new System.Windows.Forms.PictureBox();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.comboBox_Service = new System.Windows.Forms.ComboBox();
            this.comboBox_Employee = new System.Windows.Forms.ComboBox();
            this.comboBox_Client = new System.Windows.Forms.ComboBox();
            this.dateTimePicker_Date = new System.Windows.Forms.DateTimePicker();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Report = new System.Windows.Forms.Button();
            this.button_Check = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.checkBoxIsNotReady = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1071, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заказы";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // imgClear
            // 
            this.imgClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgClear.Image = ((System.Drawing.Image)(resources.GetObject("imgClear.Image")));
            this.imgClear.Location = new System.Drawing.Point(540, 39);
            this.imgClear.Name = "imgClear";
            this.imgClear.Size = new System.Drawing.Size(53, 37);
            this.imgClear.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgClear.TabIndex = 1;
            this.imgClear.TabStop = false;
            this.imgClear.Click += new System.EventHandler(this.imgClear_Click);
            // 
            // imgUpdate
            // 
            this.imgUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgUpdate.Image = ((System.Drawing.Image)(resources.GetObject("imgUpdate.Image")));
            this.imgUpdate.Location = new System.Drawing.Point(599, 39);
            this.imgUpdate.Name = "imgUpdate";
            this.imgUpdate.Size = new System.Drawing.Size(53, 37);
            this.imgUpdate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgUpdate.TabIndex = 2;
            this.imgUpdate.TabStop = false;
            this.imgUpdate.Click += new System.EventHandler(this.imgUpdate_Click);
            // 
            // imgSearch
            // 
            this.imgSearch.Image = ((System.Drawing.Image)(resources.GetObject("imgSearch.Image")));
            this.imgSearch.Location = new System.Drawing.Point(692, 39);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(53, 37);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearch.TabIndex = 3;
            this.imgSearch.TabStop = false;
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(751, 39);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(320, 37);
            this.textBox_Search.TabIndex = 11;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1071, 362);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.checkBoxIsNotReady);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.comboBox_Status);
            this.groupBox1.Controls.Add(this.comboBox_Service);
            this.groupBox1.Controls.Add(this.comboBox_Employee);
            this.groupBox1.Controls.Add(this.comboBox_Client);
            this.groupBox1.Controls.Add(this.dateTimePicker_Date);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.textBox_Amount);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 462);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 314);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label9.Location = new System.Drawing.Point(65, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 23);
            this.label9.TabIndex = 13;
            this.label9.Text = "Статус заказа:";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "Выполнен",
            "Не выполнен"});
            this.comboBox_Status.Location = new System.Drawing.Point(193, 253);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(263, 24);
            this.comboBox_Status.TabIndex = 12;
            // 
            // comboBox_Service
            // 
            this.comboBox_Service.FormattingEnabled = true;
            this.comboBox_Service.Location = new System.Drawing.Point(193, 157);
            this.comboBox_Service.Name = "comboBox_Service";
            this.comboBox_Service.Size = new System.Drawing.Size(263, 24);
            this.comboBox_Service.TabIndex = 8;
            // 
            // comboBox_Employee
            // 
            this.comboBox_Employee.FormattingEnabled = true;
            this.comboBox_Employee.Location = new System.Drawing.Point(193, 125);
            this.comboBox_Employee.Name = "comboBox_Employee";
            this.comboBox_Employee.Size = new System.Drawing.Size(263, 24);
            this.comboBox_Employee.TabIndex = 7;
            // 
            // comboBox_Client
            // 
            this.comboBox_Client.FormattingEnabled = true;
            this.comboBox_Client.Location = new System.Drawing.Point(193, 95);
            this.comboBox_Client.Name = "comboBox_Client";
            this.comboBox_Client.Size = new System.Drawing.Size(263, 24);
            this.comboBox_Client.TabIndex = 6;
            // 
            // dateTimePicker_Date
            // 
            this.dateTimePicker_Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Date.Location = new System.Drawing.Point(193, 188);
            this.dateTimePicker_Date.Name = "dateTimePicker_Date";
            this.dateTimePicker_Date.Size = new System.Drawing.Size(263, 22);
            this.dateTimePicker_Date.TabIndex = 9;
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
            // textBox_Amount
            // 
            this.textBox_Amount.Location = new System.Drawing.Point(193, 224);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(263, 22);
            this.textBox_Amount.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label7.Location = new System.Drawing.Point(72, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 6;
            this.label7.Text = "Кол-во услуг:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label6.Location = new System.Drawing.Point(78, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата заказа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label5.Location = new System.Drawing.Point(121, 154);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 23);
            this.label5.TabIndex = 4;
            this.label5.Text = "Услуга:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(89, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Сотрудник:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(118, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Клиент:";
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
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.Controls.Add(this.button_Report);
            this.groupBox2.Controls.Add(this.button_Check);
            this.groupBox2.Controls.Add(this.button_Save);
            this.groupBox2.Controls.Add(this.button_Update);
            this.groupBox2.Controls.Add(this.button_Delete);
            this.groupBox2.Controls.Add(this.button_New);
            this.groupBox2.Location = new System.Drawing.Point(816, 510);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 317);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // button_Report
            // 
            this.button_Report.Location = new System.Drawing.Point(24, 253);
            this.button_Report.Name = "button_Report";
            this.button_Report.Size = new System.Drawing.Size(142, 42);
            this.button_Report.TabIndex = 5;
            this.button_Report.Text = "Отчет";
            this.button_Report.UseVisualStyleBackColor = true;
            this.button_Report.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Check
            // 
            this.button_Check.Location = new System.Drawing.Point(24, 205);
            this.button_Check.Name = "button_Check";
            this.button_Check.Size = new System.Drawing.Size(142, 42);
            this.button_Check.TabIndex = 4;
            this.button_Check.Text = "Квитанция";
            this.button_Check.UseVisualStyleBackColor = true;
            this.button_Check.Click += new System.EventHandler(this.button_Check_Click);
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(764, 472);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 35);
            this.label8.TabIndex = 8;
            this.label8.Text = "Управление записями";
            // 
            // checkBoxIsNotReady
            // 
            this.checkBoxIsNotReady.AutoSize = true;
            this.checkBoxIsNotReady.Location = new System.Drawing.Point(261, 63);
            this.checkBoxIsNotReady.Name = "checkBoxIsNotReady";
            this.checkBoxIsNotReady.Size = new System.Drawing.Size(195, 21);
            this.checkBoxIsNotReady.TabIndex = 15;
            this.checkBoxIsNotReady.Text = "Только активные заказы";
            this.checkBoxIsNotReady.UseVisualStyleBackColor = true;
            this.checkBoxIsNotReady.CheckedChanged += new System.EventHandler(this.checkBoxIsNotReady_CheckedChanged);
            // 
            // Orders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1095, 839);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.imgSearch);
            this.Controls.Add(this.imgUpdate);
            this.Controls.Add(this.imgClear);
            this.Controls.Add(this.label1);
            this.Name = "Orders";
            this.Text = "Заказы";
            this.Load += new System.EventHandler(this.Orders_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgClear;
        private System.Windows.Forms.PictureBox imgUpdate;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Date;
        private System.Windows.Forms.ComboBox comboBox_Service;
        private System.Windows.Forms.ComboBox comboBox_Employee;
        private System.Windows.Forms.ComboBox comboBox_Client;
        private System.Windows.Forms.Button button_Check;
        private System.Windows.Forms.Button button_Report;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.CheckBox checkBoxIsNotReady;
    }
}