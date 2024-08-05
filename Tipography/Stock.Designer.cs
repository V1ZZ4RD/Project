
namespace Tipography
{
    partial class Stock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_New = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_Name = new System.Windows.Forms.ComboBox();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_Amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.imgSearch = new System.Windows.Forms.PictureBox();
            this.imgUpdate = new System.Windows.Forms.PictureBox();
            this.imgClear = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox2.Controls.Add(this.button_Save);
            this.groupBox2.Controls.Add(this.button_Update);
            this.groupBox2.Controls.Add(this.button_New);
            this.groupBox2.Location = new System.Drawing.Point(603, 504);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 166);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // button_Save
            // 
            this.button_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Save.Location = new System.Drawing.Point(24, 113);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(142, 40);
            this.button_Save.TabIndex = 2;
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
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.groupBox1.Controls.Add(this.comboBox_Name);
            this.groupBox1.Controls.Add(this.textBox_id);
            this.groupBox1.Controls.Add(this.textBox_Amount);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 169);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // comboBox_Name
            // 
            this.comboBox_Name.FormattingEnabled = true;
            this.comboBox_Name.Location = new System.Drawing.Point(193, 92);
            this.comboBox_Name.Name = "comboBox_Name";
            this.comboBox_Name.Size = new System.Drawing.Size(263, 24);
            this.comboBox_Name.TabIndex = 3;
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
            this.textBox_Amount.Location = new System.Drawing.Point(193, 122);
            this.textBox_Amount.Name = "textBox_Amount";
            this.textBox_Amount.Size = new System.Drawing.Size(263, 22);
            this.textBox_Amount.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic", 10.2F);
            this.label4.Location = new System.Drawing.Point(81, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Количество:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наименование:";
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
            this.dataGridView1.TabIndex = 23;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(545, 27);
            this.textBox_Search.Multiline = true;
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(320, 37);
            this.textBox_Search.TabIndex = 5;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // imgSearch
            // 
            this.imgSearch.Image = ((System.Drawing.Image)(resources.GetObject("imgSearch.Image")));
            this.imgSearch.Location = new System.Drawing.Point(486, 27);
            this.imgSearch.Name = "imgSearch";
            this.imgSearch.Size = new System.Drawing.Size(53, 37);
            this.imgSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgSearch.TabIndex = 21;
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
            this.imgUpdate.TabIndex = 20;
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
            this.imgClear.TabIndex = 19;
            this.imgClear.TabStop = false;
            this.imgClear.Click += new System.EventHandler(this.imgClear_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.label1.Font = new System.Drawing.Font("Impact", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 71);
            this.label1.TabIndex = 18;
            this.label1.Text = "Склад";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(551, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(288, 35);
            this.label8.TabIndex = 26;
            this.label8.Text = "Управление записями";
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(894, 731);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.imgSearch);
            this.Controls.Add(this.imgUpdate);
            this.Controls.Add(this.imgClear);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "Stock";
            this.Text = "Склад";
            this.Load += new System.EventHandler(this.Stock_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgClear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_New;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_Amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.PictureBox imgSearch;
        private System.Windows.Forms.PictureBox imgUpdate;
        private System.Windows.Forms.PictureBox imgClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox_Name;
    }
}