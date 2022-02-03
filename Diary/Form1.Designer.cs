
namespace Diary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Поиск = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Изменить_заметки = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.Сохранить = new System.Windows.Forms.Button();
            this.отменить = new System.Windows.Forms.Button();
            this.изменить_запись = new System.Windows.Forms.Button();
            this.Очистить = new System.Windows.Forms.Button();
            this.about = new System.Windows.Forms.Button();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.settings = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(-73, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 45);
            this.label7.TabIndex = 38;
            this.label7.Text = "Календарь";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(-25, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 45);
            this.label6.TabIndex = 37;
            this.label6.Text = "Заметки";
            // 
            // Поиск
            // 
            this.Поиск.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Поиск.BackColor = System.Drawing.SystemColors.Window;
            this.Поиск.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Поиск.BackgroundImage")));
            this.Поиск.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Поиск.Location = new System.Drawing.Point(328, -40);
            this.Поиск.Name = "Поиск";
            this.Поиск.Size = new System.Drawing.Size(59, 52);
            this.Поиск.TabIndex = 36;
            this.Поиск.UseVisualStyleBackColor = false;
            this.Поиск.Click += new System.EventHandler(this.Поиск_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label5.Location = new System.Drawing.Point(1104, 675);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 32);
            this.label5.TabIndex = 35;
            this.label5.Text = "Очистить";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label4.Location = new System.Drawing.Point(520, 675);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 32);
            this.label4.TabIndex = 34;
            this.label4.Text = "Изменить запись";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label3.Location = new System.Drawing.Point(805, 675);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(229, 32);
            this.label3.TabIndex = 33;
            this.label3.Text = "Изменить заметки";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 40;
            // 
            // Изменить_заметки
            // 
            this.Изменить_заметки.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Изменить_заметки.BackColor = System.Drawing.Color.White;
            this.Изменить_заметки.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Изменить_заметки.BackgroundImage")));
            this.Изменить_заметки.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Изменить_заметки.Location = new System.Drawing.Point(846, 708);
            this.Изменить_заметки.Name = "Изменить_заметки";
            this.Изменить_заметки.Size = new System.Drawing.Size(126, 126);
            this.Изменить_заметки.TabIndex = 31;
            this.Изменить_заметки.UseVisualStyleBackColor = false;
            this.Изменить_заметки.Click += new System.EventHandler(this.Изменить_заметки_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15F);
            this.label1.Location = new System.Drawing.Point(1363, 673);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 32);
            this.label1.TabIndex = 30;
            this.label1.Text = "Cохранить";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox3.Location = new System.Drawing.Point(-186, -40);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(487, 52);
            this.richTextBox3.TabIndex = 29;
            this.richTextBox3.Text = "";
            // 
            // Сохранить
            // 
            this.Сохранить.AllowDrop = true;
            this.Сохранить.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Сохранить.BackColor = System.Drawing.Color.White;
            this.Сохранить.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Сохранить.BackgroundImage")));
            this.Сохранить.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Сохранить.Location = new System.Drawing.Point(1369, 708);
            this.Сохранить.Name = "Сохранить";
            this.Сохранить.Size = new System.Drawing.Size(126, 126);
            this.Сохранить.TabIndex = 28;
            this.Сохранить.UseVisualStyleBackColor = false;
            this.Сохранить.Click += new System.EventHandler(this.Сохранить_Click);
            this.Сохранить.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            // 
            // отменить
            // 
            this.отменить.Location = new System.Drawing.Point(0, 0);
            this.отменить.Name = "отменить";
            this.отменить.Size = new System.Drawing.Size(75, 23);
            this.отменить.TabIndex = 41;
            // 
            // изменить_запись
            // 
            this.изменить_запись.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.изменить_запись.BackColor = System.Drawing.Color.White;
            this.изменить_запись.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("изменить_запись.BackgroundImage")));
            this.изменить_запись.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.изменить_запись.Location = new System.Drawing.Point(558, 708);
            this.изменить_запись.Name = "изменить_запись";
            this.изменить_запись.Size = new System.Drawing.Size(126, 126);
            this.изменить_запись.TabIndex = 26;
            this.изменить_запись.UseVisualStyleBackColor = false;
            this.изменить_запись.Click += new System.EventHandler(this.изменить_запись_Click);
            // 
            // Очистить
            // 
            this.Очистить.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Очистить.BackColor = System.Drawing.Color.White;
            this.Очистить.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Очистить.BackgroundImage")));
            this.Очистить.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Очистить.Location = new System.Drawing.Point(1109, 708);
            this.Очистить.Name = "Очистить";
            this.Очистить.Size = new System.Drawing.Size(126, 126);
            this.Очистить.TabIndex = 25;
            this.Очистить.UseVisualStyleBackColor = false;
            this.Очистить.Click += new System.EventHandler(this.Очистить_Click);
            // 
            // about
            // 
            this.about.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.about.BackColor = System.Drawing.Color.Thistle;
            this.about.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("about.BackgroundImage")));
            this.about.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.about.FlatAppearance.BorderSize = 0;
            this.about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.about.Location = new System.Drawing.Point(1383, -79);
            this.about.Name = "about";
            this.about.Size = new System.Drawing.Size(100, 100);
            this.about.TabIndex = 24;
            this.about.UseVisualStyleBackColor = false;
            this.about.Click += new System.EventHandler(this.справка_Click);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox2.Enabled = false;
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox2.Location = new System.Drawing.Point(-186, 87);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(487, 233);
            this.richTextBox2.TabIndex = 23;
            this.richTextBox2.Text = "";
            // 
            // settings
            // 
            this.settings.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.settings.BackColor = System.Drawing.Color.Thistle;
            this.settings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("settings.BackgroundImage")));
            this.settings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.settings.FlatAppearance.BorderSize = 0;
            this.settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settings.Location = new System.Drawing.Point(1489, -79);
            this.settings.Name = "settings";
            this.settings.Size = new System.Drawing.Size(100, 100);
            this.settings.TabIndex = 22;
            this.settings.UseVisualStyleBackColor = false;
            this.settings.Click += new System.EventHandler(this.настройки_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(474, 87);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(1080, 556);
            this.richTextBox1.TabIndex = 21;
            this.richTextBox1.Text = "";
            this.richTextBox1.Click += new System.EventHandler(this.Изменить_заметки_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthCalendar1.BackColor = System.Drawing.Color.Thistle;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(2, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(-87, 487);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.TabStop = false;
            this.monthCalendar1.TitleBackColor = System.Drawing.Color.Thistle;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 20F);
            this.label8.Location = new System.Drawing.Point(875, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(267, 45);
            this.label8.TabIndex = 39;
            this.label8.Text = "Записи на день";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1566, 785);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Поиск);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Изменить_заметки);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.Сохранить);
            this.Controls.Add(this.отменить);
            this.Controls.Add(this.изменить_запись);
            this.Controls.Add(this.Очистить);
            this.Controls.Add(this.about);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.settings);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.monthCalendar1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Поиск;
        private System.Windows.Forms.Button Изменить_заметки;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Button Сохранить;
        private System.Windows.Forms.Button отменить;
        private System.Windows.Forms.Button изменить_запись;
        private System.Windows.Forms.Button Очистить;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        internal System.Windows.Forms.Button about;
        internal System.Windows.Forms.Button settings;
        internal System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Label label8;
        internal System.Windows.Forms.RichTextBox richTextBox1;
    }
}

