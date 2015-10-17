namespace Saper
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.MSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Record = new System.Windows.Forms.ToolStripMenuItem();
            this.RecordClear = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mExit = new System.Windows.Forms.ToolStripMenuItem();
            this.Pole = new System.Windows.Forms.Panel();
            this.Morda = new System.Windows.Forms.Panel();
            this.NewGameBtn = new System.Windows.Forms.Button();
            this.TimerText = new System.Windows.Forms.TextBox();
            this.NumMineText = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.Morda.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mNewGame,
            this.toolStripSeparator3,
            this.MSettings,
            this.toolStripSeparator1,
            this.Record,
            this.RecordClear,
            this.toolStripSeparator2,
            this.mExit});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 20);
            this.toolStripMenuItem1.Text = "Игра";
            // 
            // mNewGame
            // 
            this.mNewGame.Name = "mNewGame";
            this.mNewGame.Size = new System.Drawing.Size(164, 22);
            this.mNewGame.Text = "Новая игра";
            this.mNewGame.Click += new System.EventHandler(this.mNewGame_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // MSettings
            // 
            this.MSettings.Name = "MSettings";
            this.MSettings.Size = new System.Drawing.Size(164, 22);
            this.MSettings.Text = "Настройки";
            this.MSettings.Click += new System.EventHandler(this.MSettings_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(161, 6);
            // 
            // Record
            // 
            this.Record.Name = "Record";
            this.Record.Size = new System.Drawing.Size(164, 22);
            this.Record.Text = "Рекорды";
            this.Record.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Record.Click += new System.EventHandler(this.Record_Click);
            // 
            // RecordClear
            // 
            this.RecordClear.Name = "RecordClear";
            this.RecordClear.Size = new System.Drawing.Size(164, 22);
            this.RecordClear.Text = "Сброс рекорвов";
            this.RecordClear.Click += new System.EventHandler(this.RecordClear_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(161, 6);
            // 
            // mExit
            // 
            this.mExit.Name = "mExit";
            this.mExit.Size = new System.Drawing.Size(164, 22);
            this.mExit.Text = "Выход";
            this.mExit.Click += new System.EventHandler(this.mExit_Click);
            // 
            // Pole
            // 
            this.Pole.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pole.Location = new System.Drawing.Point(0, 60);
            this.Pole.Name = "Pole";
            this.Pole.Size = new System.Drawing.Size(284, 187);
            this.Pole.TabIndex = 1;
            // 
            // Morda
            // 
            this.Morda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Morda.Controls.Add(this.NewGameBtn);
            this.Morda.Controls.Add(this.TimerText);
            this.Morda.Controls.Add(this.NumMineText);
            this.Morda.Location = new System.Drawing.Point(0, 27);
            this.Morda.Name = "Morda";
            this.Morda.Size = new System.Drawing.Size(284, 22);
            this.Morda.TabIndex = 2;
            // 
            // NewGameBtn
            // 
            this.NewGameBtn.Location = new System.Drawing.Point(37, 0);
            this.NewGameBtn.Name = "NewGameBtn";
            this.NewGameBtn.Size = new System.Drawing.Size(20, 20);
            this.NewGameBtn.TabIndex = 2;
            this.NewGameBtn.UseVisualStyleBackColor = true;
            this.NewGameBtn.Click += new System.EventHandler(this.NewGameBtn_Click);
            // 
            // TimerText
            // 
            this.TimerText.BackColor = System.Drawing.Color.Yellow;
            this.TimerText.Location = new System.Drawing.Point(69, 0);
            this.TimerText.Name = "TimerText";
            this.TimerText.ReadOnly = true;
            this.TimerText.Size = new System.Drawing.Size(37, 20);
            this.TimerText.TabIndex = 1;
            this.TimerText.TabStop = false;
            this.TimerText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NumMineText
            // 
            this.NumMineText.BackColor = System.Drawing.Color.Yellow;
            this.NumMineText.Location = new System.Drawing.Point(0, 0);
            this.NumMineText.Name = "NumMineText";
            this.NumMineText.ReadOnly = true;
            this.NumMineText.ShortcutsEnabled = false;
            this.NumMineText.Size = new System.Drawing.Size(31, 20);
            this.NumMineText.TabIndex = 0;
            this.NumMineText.TabStop = false;
            this.NumMineText.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.Morda);
            this.Controls.Add(this.Pole);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "WormSaper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Morda.ResumeLayout(false);
            this.Morda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MSettings;
        private System.Windows.Forms.ToolStripMenuItem Record;
        private System.Windows.Forms.Panel Pole;
        private System.Windows.Forms.Panel Morda;
        private System.Windows.Forms.TextBox TimerText;
        private System.Windows.Forms.TextBox NumMineText;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button NewGameBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem RecordClear;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mNewGame;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mExit;
    }
}

