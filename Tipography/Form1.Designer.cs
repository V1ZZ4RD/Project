
namespace Tipography
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonEmployee = new System.Windows.Forms.Button();
            this.buttonService = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Impact", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(56, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Типография";
            // 
            // buttonOrders
            // 
            this.buttonOrders.Font = new System.Drawing.Font("Impact", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOrders.Location = new System.Drawing.Point(96, 81);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(186, 50);
            this.buttonOrders.TabIndex = 1;
            this.buttonOrders.Text = "Заказы";
            this.buttonOrders.UseVisualStyleBackColor = true;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Font = new System.Drawing.Font("Impact", 13.8F);
            this.buttonClient.Location = new System.Drawing.Point(96, 137);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(186, 50);
            this.buttonClient.TabIndex = 2;
            this.buttonClient.Text = "Клиенты";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonEmployee
            // 
            this.buttonEmployee.Font = new System.Drawing.Font("Impact", 13.8F);
            this.buttonEmployee.Location = new System.Drawing.Point(96, 193);
            this.buttonEmployee.Name = "buttonEmployee";
            this.buttonEmployee.Size = new System.Drawing.Size(186, 50);
            this.buttonEmployee.TabIndex = 3;
            this.buttonEmployee.Text = "Сотрудники";
            this.buttonEmployee.UseVisualStyleBackColor = true;
            this.buttonEmployee.Click += new System.EventHandler(this.buttonEmployee_Click);
            // 
            // buttonService
            // 
            this.buttonService.Font = new System.Drawing.Font("Impact", 13.8F);
            this.buttonService.Location = new System.Drawing.Point(96, 249);
            this.buttonService.Name = "buttonService";
            this.buttonService.Size = new System.Drawing.Size(186, 50);
            this.buttonService.TabIndex = 4;
            this.buttonService.Text = "Услуги";
            this.buttonService.UseVisualStyleBackColor = true;
            this.buttonService.Click += new System.EventHandler(this.buttonService_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Impact", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(96, 381);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(186, 38);
            this.buttonBack.TabIndex = 6;
            this.buttonBack.Text = "Выход";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonStock
            // 
            this.buttonStock.Font = new System.Drawing.Font("Impact", 13.8F);
            this.buttonStock.Location = new System.Drawing.Point(96, 305);
            this.buttonStock.Name = "buttonStock";
            this.buttonStock.Size = new System.Drawing.Size(186, 50);
            this.buttonStock.TabIndex = 5;
            this.buttonStock.Text = "Склад";
            this.buttonStock.UseVisualStyleBackColor = true;
            this.buttonStock.Click += new System.EventHandler(this.buttonStock_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(374, 434);
            this.Controls.Add(this.buttonStock);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonService);
            this.Controls.Add(this.buttonEmployee);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Типография";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonOrders;
        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonEmployee;
        private System.Windows.Forms.Button buttonService;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonStock;
    }
}

