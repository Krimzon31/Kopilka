namespace Kopilka
{
    partial class Main_Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Window));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.payment_for_housing = new System.Windows.Forms.TextBox();
            this.communal_payments = new System.Windows.Forms.TextBox();
            this.taxes = new System.Windows.Forms.TextBox();
            this.other_expenses = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calculation = new System.Windows.Forms.Button();
            this.get_file = new System.Windows.Forms.Button();
            this.total_income = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.savings_history = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1270, 85);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(542, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 2;
            this.label1.Text = "Копилка";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 78);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // payment_for_housing
            // 
            this.payment_for_housing.Location = new System.Drawing.Point(393, 289);
            this.payment_for_housing.Name = "payment_for_housing";
            this.payment_for_housing.Size = new System.Drawing.Size(157, 22);
            this.payment_for_housing.TabIndex = 1;
            // 
            // communal_payments
            // 
            this.communal_payments.Location = new System.Drawing.Point(393, 367);
            this.communal_payments.Name = "communal_payments";
            this.communal_payments.Size = new System.Drawing.Size(157, 22);
            this.communal_payments.TabIndex = 2;
            // 
            // taxes
            // 
            this.taxes.Location = new System.Drawing.Point(751, 364);
            this.taxes.Name = "taxes";
            this.taxes.Size = new System.Drawing.Size(157, 22);
            this.taxes.TabIndex = 3;
            // 
            // other_expenses
            // 
            this.other_expenses.Location = new System.Drawing.Point(751, 289);
            this.other_expenses.Name = "other_expenses";
            this.other_expenses.Size = new System.Drawing.Size(157, 22);
            this.other_expenses.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Оплата за жильё";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(234, 370);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Коммунальные услуги";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(690, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Налоги";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 295);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Прочие расходы";
            // 
            // calculation
            // 
            this.calculation.BackColor = System.Drawing.Color.White;
            this.calculation.Location = new System.Drawing.Point(393, 484);
            this.calculation.Name = "calculation";
            this.calculation.Size = new System.Drawing.Size(140, 55);
            this.calculation.TabIndex = 12;
            this.calculation.Text = "Рассчитать";
            this.calculation.UseVisualStyleBackColor = false;
            this.calculation.Click += new System.EventHandler(this.calculation_Click);
            // 
            // get_file
            // 
            this.get_file.BackColor = System.Drawing.Color.White;
            this.get_file.Location = new System.Drawing.Point(768, 484);
            this.get_file.Name = "get_file";
            this.get_file.Size = new System.Drawing.Size(140, 55);
            this.get_file.TabIndex = 13;
            this.get_file.Text = "Получить файл";
            this.get_file.UseVisualStyleBackColor = false;
            this.get_file.Click += new System.EventHandler(this.get_file_Click);
            // 
            // total_income
            // 
            this.total_income.Location = new System.Drawing.Point(561, 205);
            this.total_income.Name = "total_income";
            this.total_income.Size = new System.Drawing.Size(157, 22);
            this.total_income.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(596, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "Общий доход";
            // 
            // savings_history
            // 
            this.savings_history.BackColor = System.Drawing.Color.White;
            this.savings_history.Location = new System.Drawing.Point(584, 484);
            this.savings_history.Name = "savings_history";
            this.savings_history.Size = new System.Drawing.Size(140, 55);
            this.savings_history.TabIndex = 16;
            this.savings_history.Text = "История накоплений";
            this.savings_history.UseVisualStyleBackColor = false;
            this.savings_history.Click += new System.EventHandler(this.savings_history_Click);
            // 
            // Main_Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1270, 693);
            this.Controls.Add(this.savings_history);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.total_income);
            this.Controls.Add(this.get_file);
            this.Controls.Add(this.calculation);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.other_expenses);
            this.Controls.Add(this.taxes);
            this.Controls.Add(this.communal_payments);
            this.Controls.Add(this.payment_for_housing);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1288, 740);
            this.MinimumSize = new System.Drawing.Size(1288, 740);
            this.Name = "Main_Window";
            this.Text = "Main_Menu";
            this.Load += new System.EventHandler(this.Main_Window_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox payment_for_housing;
        private System.Windows.Forms.TextBox communal_payments;
        private System.Windows.Forms.TextBox taxes;
        private System.Windows.Forms.TextBox other_expenses;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button calculation;
        private System.Windows.Forms.Button get_file;
        private System.Windows.Forms.TextBox total_income;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button savings_history;
    }
}

