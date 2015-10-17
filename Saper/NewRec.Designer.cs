namespace Saper
{
    partial class NewRec
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
            this.NewRecordText = new System.Windows.Forms.Label();
            this.NewRecordName = new System.Windows.Forms.TextBox();
            this.NewRecordOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NewRecordText
            // 
            this.NewRecordText.AutoSize = true;
            this.NewRecordText.Location = new System.Drawing.Point(34, 9);
            this.NewRecordText.Name = "NewRecordText";
            this.NewRecordText.Size = new System.Drawing.Size(106, 26);
            this.NewRecordText.TabIndex = 0;
            this.NewRecordText.Text = "Вы новый чемпион.\r\nПредставьтесь\r\n";
            this.NewRecordText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NewRecordName
            // 
            this.NewRecordName.Location = new System.Drawing.Point(40, 96);
            this.NewRecordName.Name = "NewRecordName";
            this.NewRecordName.Size = new System.Drawing.Size(100, 20);
            this.NewRecordName.TabIndex = 1;
            // 
            // NewRecordOK
            // 
            this.NewRecordOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.NewRecordOK.Location = new System.Drawing.Point(51, 138);
            this.NewRecordOK.Name = "NewRecordOK";
            this.NewRecordOK.Size = new System.Drawing.Size(75, 23);
            this.NewRecordOK.TabIndex = 2;
            this.NewRecordOK.Text = "OK";
            this.NewRecordOK.UseVisualStyleBackColor = true;
            // 
            // NewRec
            // 
            this.AcceptButton = this.NewRecordOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 183);
            this.Controls.Add(this.NewRecordOK);
            this.Controls.Add(this.NewRecordName);
            this.Controls.Add(this.NewRecordText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NewRec";
            this.Text = "Новый рекорд";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button NewRecordOK;
        private System.Windows.Forms.TextBox NewRecordName;
        private System.Windows.Forms.Label NewRecordText;
    }
}