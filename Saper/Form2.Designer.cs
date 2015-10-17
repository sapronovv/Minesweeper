namespace Saper
{
    partial class Settings
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
            this.Level1 = new System.Windows.Forms.RadioButton();
            this.Level2 = new System.Windows.Forms.RadioButton();
            this.Level3 = new System.Windows.Forms.RadioButton();
            this.Level4 = new System.Windows.Forms.RadioButton();
            this.PrXLabel = new System.Windows.Forms.Label();
            this.PrYLabel = new System.Windows.Forms.Label();
            this.PrNLabel = new System.Windows.Forms.Label();
            this.PrXVal = new System.Windows.Forms.MaskedTextBox();
            this.PrYVal = new System.Windows.Forms.MaskedTextBox();
            this.PrNVal = new System.Windows.Forms.MaskedTextBox();
            this.SetBtnOK = new System.Windows.Forms.Button();
            this.SetBtnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Level1
            // 
            this.Level1.AutoSize = true;
            this.Level1.Location = new System.Drawing.Point(21, 24);
            this.Level1.Name = "Level1";
            this.Level1.Size = new System.Drawing.Size(68, 17);
            this.Level1.TabIndex = 0;
            this.Level1.TabStop = true;
            this.Level1.Text = "Новичок";
            this.Level1.UseVisualStyleBackColor = true;
            this.Level1.CheckedChanged += new System.EventHandler(this.Level1_CheckedChanged);
            // 
            // Level2
            // 
            this.Level2.AutoSize = true;
            this.Level2.Location = new System.Drawing.Point(21, 58);
            this.Level2.Name = "Level2";
            this.Level2.Size = new System.Drawing.Size(72, 17);
            this.Level2.TabIndex = 1;
            this.Level2.TabStop = true;
            this.Level2.Text = "Опытный";
            this.Level2.UseVisualStyleBackColor = true;
            this.Level2.CheckedChanged += new System.EventHandler(this.Level2_CheckedChanged);
            // 
            // Level3
            // 
            this.Level3.AutoSize = true;
            this.Level3.Location = new System.Drawing.Point(21, 92);
            this.Level3.Name = "Level3";
            this.Level3.Size = new System.Drawing.Size(55, 17);
            this.Level3.TabIndex = 2;
            this.Level3.TabStop = true;
            this.Level3.Text = "Элита";
            this.Level3.UseVisualStyleBackColor = true;
            this.Level3.CheckedChanged += new System.EventHandler(this.Level3_CheckedChanged);
            // 
            // Level4
            // 
            this.Level4.AutoSize = true;
            this.Level4.Location = new System.Drawing.Point(21, 124);
            this.Level4.Name = "Level4";
            this.Level4.Size = new System.Drawing.Size(101, 17);
            this.Level4.TabIndex = 3;
            this.Level4.TabStop = true;
            this.Level4.Text = "Произвольный";
            this.Level4.UseVisualStyleBackColor = true;
            this.Level4.CheckedChanged += new System.EventHandler(this.Level4_CheckedChanged);
            // 
            // PrXLabel
            // 
            this.PrXLabel.AutoSize = true;
            this.PrXLabel.Location = new System.Drawing.Point(39, 143);
            this.PrXLabel.Name = "PrXLabel";
            this.PrXLabel.Size = new System.Drawing.Size(45, 13);
            this.PrXLabel.TabIndex = 7;
            this.PrXLabel.Text = "ширина";
            this.PrXLabel.Visible = false;
            // 
            // PrYLabel
            // 
            this.PrYLabel.AutoSize = true;
            this.PrYLabel.Location = new System.Drawing.Point(97, 144);
            this.PrYLabel.Name = "PrYLabel";
            this.PrYLabel.Size = new System.Drawing.Size(44, 13);
            this.PrYLabel.TabIndex = 8;
            this.PrYLabel.Text = "высота";
            this.PrYLabel.Visible = false;
            // 
            // PrNLabel
            // 
            this.PrNLabel.AutoSize = true;
            this.PrNLabel.Location = new System.Drawing.Point(151, 144);
            this.PrNLabel.Name = "PrNLabel";
            this.PrNLabel.Size = new System.Drawing.Size(88, 13);
            this.PrNLabel.TabIndex = 9;
            this.PrNLabel.Text = "количество мин";
            this.PrNLabel.Visible = false;
            // 
            // PrXVal
            // 
            this.PrXVal.Location = new System.Drawing.Point(42, 159);
            this.PrXVal.Mask = "00";
            this.PrXVal.Name = "PrXVal";
            this.PrXVal.Size = new System.Drawing.Size(34, 20);
            this.PrXVal.TabIndex = 10;
            this.PrXVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrXVal.Visible = false;
            // 
            // PrYVal
            // 
            this.PrYVal.Location = new System.Drawing.Point(100, 159);
            this.PrYVal.Mask = "00";
            this.PrYVal.Name = "PrYVal";
            this.PrYVal.Size = new System.Drawing.Size(34, 20);
            this.PrYVal.TabIndex = 11;
            this.PrYVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrYVal.Visible = false;
            // 
            // PrNVal
            // 
            this.PrNVal.Location = new System.Drawing.Point(154, 160);
            this.PrNVal.Mask = "0000";
            this.PrNVal.Name = "PrNVal";
            this.PrNVal.Size = new System.Drawing.Size(34, 20);
            this.PrNVal.TabIndex = 12;
            this.PrNVal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PrNVal.Visible = false;
            // 
            // SetBtnOK
            // 
            this.SetBtnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SetBtnOK.Location = new System.Drawing.Point(47, 204);
            this.SetBtnOK.Name = "SetBtnOK";
            this.SetBtnOK.Size = new System.Drawing.Size(75, 23);
            this.SetBtnOK.TabIndex = 13;
            this.SetBtnOK.Text = "OK";
            this.SetBtnOK.UseVisualStyleBackColor = true;
            this.SetBtnOK.Click += new System.EventHandler(this.SetBtnOK_Click);
            // 
            // SetBtnCancel
            // 
            this.SetBtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.SetBtnCancel.Location = new System.Drawing.Point(154, 204);
            this.SetBtnCancel.Name = "SetBtnCancel";
            this.SetBtnCancel.Size = new System.Drawing.Size(75, 23);
            this.SetBtnCancel.TabIndex = 14;
            this.SetBtnCancel.Text = "Cancel";
            this.SetBtnCancel.UseVisualStyleBackColor = true;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.SetBtnCancel);
            this.Controls.Add(this.SetBtnOK);
            this.Controls.Add(this.PrNVal);
            this.Controls.Add(this.PrYVal);
            this.Controls.Add(this.PrXVal);
            this.Controls.Add(this.PrNLabel);
            this.Controls.Add(this.PrYLabel);
            this.Controls.Add(this.PrXLabel);
            this.Controls.Add(this.Level4);
            this.Controls.Add(this.Level3);
            this.Controls.Add(this.Level2);
            this.Controls.Add(this.Level1);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Level4;
        private System.Windows.Forms.Label PrXLabel;
        private System.Windows.Forms.Label PrYLabel;
        private System.Windows.Forms.Label PrNLabel;
        private System.Windows.Forms.MaskedTextBox PrXVal;
        private System.Windows.Forms.MaskedTextBox PrYVal;
        private System.Windows.Forms.MaskedTextBox PrNVal;
        private System.Windows.Forms.Button SetBtnOK;
        private System.Windows.Forms.Button SetBtnCancel;
        private System.Windows.Forms.RadioButton Level1;
        private System.Windows.Forms.RadioButton Level2;
        private System.Windows.Forms.RadioButton Level3;


    }
}