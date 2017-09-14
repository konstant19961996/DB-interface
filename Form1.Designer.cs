namespace DB_interface
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.аэропортыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.самолётыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокСамолётовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типыСамолётовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейсыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокРейсовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.рейсыНаКонкретнуюДатуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тОToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.плановыеТОДляМоделиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тОКонкретногоСамолётаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.аэропортыToolStripMenuItem,
            this.самолётыToolStripMenuItem,
            this.маршрутыToolStripMenuItem,
            this.рейсыToolStripMenuItem,
            this.тОToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(418, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // аэропортыToolStripMenuItem
            // 
            this.аэропортыToolStripMenuItem.Name = "аэропортыToolStripMenuItem";
            this.аэропортыToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.аэропортыToolStripMenuItem.Text = "Аэропорты";
            this.аэропортыToolStripMenuItem.Click += new System.EventHandler(this.аэропортыToolStripMenuItem_Click);
            // 
            // самолётыToolStripMenuItem
            // 
            this.самолётыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокСамолётовToolStripMenuItem,
            this.типыСамолётовToolStripMenuItem});
            this.самолётыToolStripMenuItem.Name = "самолётыToolStripMenuItem";
            this.самолётыToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.самолётыToolStripMenuItem.Text = "Самолёты";
            // 
            // списокСамолётовToolStripMenuItem
            // 
            this.списокСамолётовToolStripMenuItem.Name = "списокСамолётовToolStripMenuItem";
            this.списокСамолётовToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.списокСамолётовToolStripMenuItem.Text = "Список самолётов";
            this.списокСамолётовToolStripMenuItem.Click += new System.EventHandler(this.списокСамолётовToolStripMenuItem_Click);
            // 
            // типыСамолётовToolStripMenuItem
            // 
            this.типыСамолётовToolStripMenuItem.Name = "типыСамолётовToolStripMenuItem";
            this.типыСамолётовToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.типыСамолётовToolStripMenuItem.Text = "Типы самолётов";
            this.типыСамолётовToolStripMenuItem.Click += new System.EventHandler(this.типыСамолётовToolStripMenuItem_Click);
            // 
            // маршрутыToolStripMenuItem
            // 
            this.маршрутыToolStripMenuItem.Name = "маршрутыToolStripMenuItem";
            this.маршрутыToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.маршрутыToolStripMenuItem.Text = "Маршруты";
            this.маршрутыToolStripMenuItem.Click += new System.EventHandler(this.маршрутыToolStripMenuItem_Click);
            // 
            // рейсыToolStripMenuItem
            // 
            this.рейсыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.списокРейсовToolStripMenuItem,
            this.рейсыНаКонкретнуюДатуToolStripMenuItem});
            this.рейсыToolStripMenuItem.Name = "рейсыToolStripMenuItem";
            this.рейсыToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.рейсыToolStripMenuItem.Text = "Рейсы";
            // 
            // списокРейсовToolStripMenuItem
            // 
            this.списокРейсовToolStripMenuItem.Name = "списокРейсовToolStripMenuItem";
            this.списокРейсовToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.списокРейсовToolStripMenuItem.Text = "Список рейсов";
            this.списокРейсовToolStripMenuItem.Click += new System.EventHandler(this.списокРейсовToolStripMenuItem_Click);
            // 
            // рейсыНаКонкретнуюДатуToolStripMenuItem
            // 
            this.рейсыНаКонкретнуюДатуToolStripMenuItem.Name = "рейсыНаКонкретнуюДатуToolStripMenuItem";
            this.рейсыНаКонкретнуюДатуToolStripMenuItem.Size = new System.Drawing.Size(221, 22);
            this.рейсыНаКонкретнуюДатуToolStripMenuItem.Text = "Рейсы на конкретную дату";
            this.рейсыНаКонкретнуюДатуToolStripMenuItem.Click += new System.EventHandler(this.рейсыНаКонкретнуюДатуToolStripMenuItem_Click);
            // 
            // тОToolStripMenuItem
            // 
            this.тОToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.плановыеТОДляМоделиToolStripMenuItem,
            this.тОКонкретногоСамолётаToolStripMenuItem});
            this.тОToolStripMenuItem.Name = "тОToolStripMenuItem";
            this.тОToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.тОToolStripMenuItem.Text = "ТО";
            // 
            // плановыеТОДляМоделиToolStripMenuItem
            // 
            this.плановыеТОДляМоделиToolStripMenuItem.Name = "плановыеТОДляМоделиToolStripMenuItem";
            this.плановыеТОДляМоделиToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.плановыеТОДляМоделиToolStripMenuItem.Text = "Плановые ТО для модели";
            this.плановыеТОДляМоделиToolStripMenuItem.Click += new System.EventHandler(this.плановыеТОДляМоделиToolStripMenuItem_Click);
            // 
            // тОКонкретногоСамолётаToolStripMenuItem
            // 
            this.тОКонкретногоСамолётаToolStripMenuItem.Name = "тОКонкретногоСамолётаToolStripMenuItem";
            this.тОКонкретногоСамолётаToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.тОКонкретногоСамолётаToolStripMenuItem.Text = "ТО конкретного самолёта";
            this.тОКонкретногоСамолётаToolStripMenuItem.Click += new System.EventHandler(this.тОКонкретногоСамолётаToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem аэропортыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem самолётыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокСамолётовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типыСамолётовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem маршрутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейсыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокРейсовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem рейсыНаКонкретнуюДатуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тОToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem плановыеТОДляМоделиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тОКонкретногоСамолётаToolStripMenuItem;
    }
}

