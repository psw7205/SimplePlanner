namespace SimplePlanner.View
{
    partial class WorkForm
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
            this.label1 = new MaterialSkin.Controls.MaterialLabel();
            this.label2 = new MaterialSkin.Controls.MaterialLabel();
            this.nameTextBox = new MetroFramework.Controls.MetroTextBox();
            this.contentTextBox = new MetroFramework.Controls.MetroTextBox();
            this.OK = new MaterialSkin.Controls.MaterialFlatButton();
            this.delBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label3 = new MaterialSkin.Controls.MaterialLabel();
            this.colorLabel = new System.Windows.Forms.Label();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.dateTime = new MetroFramework.Controls.MetroDateTime();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Depth = 0;
            this.label1.Font = new System.Drawing.Font("Roboto", 11F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(15, 9);
            this.label1.MouseState = MaterialSkin.MouseState.HOVER;
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Depth = 0;
            this.label2.Font = new System.Drawing.Font("Roboto", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(15, 121);
            this.label2.MouseState = MaterialSkin.MouseState.HOVER;
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contents";
            // 
            // nameTextBox
            // 
            // 
            // 
            // 
            this.nameTextBox.CustomButton.Image = null;
            this.nameTextBox.CustomButton.Location = new System.Drawing.Point(320, 1);
            this.nameTextBox.CustomButton.Name = "";
            this.nameTextBox.CustomButton.Size = new System.Drawing.Size(23, 23);
            this.nameTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nameTextBox.CustomButton.TabIndex = 1;
            this.nameTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nameTextBox.CustomButton.UseSelectable = true;
            this.nameTextBox.CustomButton.Visible = false;
            this.nameTextBox.Lines = new string[0];
            this.nameTextBox.Location = new System.Drawing.Point(11, 36);
            this.nameTextBox.MaxLength = 32767;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.PasswordChar = '\0';
            this.nameTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nameTextBox.SelectedText = "";
            this.nameTextBox.SelectionLength = 0;
            this.nameTextBox.SelectionStart = 0;
            this.nameTextBox.ShortcutsEnabled = true;
            this.nameTextBox.Size = new System.Drawing.Size(344, 25);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.UseSelectable = true;
            this.nameTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nameTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // contentTextBox
            // 
            // 
            // 
            // 
            this.contentTextBox.CustomButton.Image = null;
            this.contentTextBox.CustomButton.Location = new System.Drawing.Point(58, 2);
            this.contentTextBox.CustomButton.Name = "";
            this.contentTextBox.CustomButton.Size = new System.Drawing.Size(283, 283);
            this.contentTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.contentTextBox.CustomButton.TabIndex = 1;
            this.contentTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.contentTextBox.CustomButton.UseSelectable = true;
            this.contentTextBox.CustomButton.Visible = false;
            this.contentTextBox.Lines = new string[0];
            this.contentTextBox.Location = new System.Drawing.Point(11, 148);
            this.contentTextBox.MaxLength = 32767;
            this.contentTextBox.Multiline = true;
            this.contentTextBox.Name = "contentTextBox";
            this.contentTextBox.PasswordChar = '\0';
            this.contentTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contentTextBox.SelectedText = "";
            this.contentTextBox.SelectionLength = 0;
            this.contentTextBox.SelectionStart = 0;
            this.contentTextBox.ShortcutsEnabled = true;
            this.contentTextBox.Size = new System.Drawing.Size(344, 288);
            this.contentTextBox.TabIndex = 3;
            this.contentTextBox.UseSelectable = true;
            this.contentTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.contentTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // OK
            // 
            this.OK.AutoSize = true;
            this.OK.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.OK.Depth = 0;
            this.OK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK.Location = new System.Drawing.Point(245, 445);
            this.OK.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.OK.MouseState = MaterialSkin.MouseState.HOVER;
            this.OK.Name = "OK";
            this.OK.Primary = false;
            this.OK.Size = new System.Drawing.Size(36, 36);
            this.OK.TabIndex = 4;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.AutoSize = true;
            this.delBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.delBtn.Depth = 0;
            this.delBtn.Location = new System.Drawing.Point(312, 445);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.delBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.delBtn.Name = "delBtn";
            this.delBtn.Primary = false;
            this.delBtn.Size = new System.Drawing.Size(43, 36);
            this.delBtn.TabIndex = 5;
            this.delBtn.Text = "DEL";
            this.delBtn.UseVisualStyleBackColor = true;
            this.delBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Depth = 0;
            this.label3.Font = new System.Drawing.Font("Roboto", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(15, 64);
            this.label3.MouseState = MaterialSkin.MouseState.HOVER;
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Label";
            // 
            // colorLabel
            // 
            this.colorLabel.BackColor = System.Drawing.Color.White;
            this.colorLabel.Location = new System.Drawing.Point(16, 88);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(70, 23);
            this.colorLabel.TabIndex = 7;
            this.colorLabel.Click += new System.EventHandler(this.ColorLabel_Click);
            // 
            // dateTime
            // 
            this.dateTime.CalendarFont = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTime.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTime.CalendarTitleForeColor = System.Drawing.Color.AliceBlue;
            this.dateTime.Location = new System.Drawing.Point(133, 88);
            this.dateTime.MinimumSize = new System.Drawing.Size(0, 30);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(222, 30);
            this.dateTime.Style = MetroFramework.MetroColorStyle.Black;
            this.dateTime.TabIndex = 8;
            // 
            // WorkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 495);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.contentTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "WorkForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WorkForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel label1;
        private MaterialSkin.Controls.MaterialLabel label2;
        private MetroFramework.Controls.MetroTextBox nameTextBox;
        private MetroFramework.Controls.MetroTextBox contentTextBox;
        private MaterialSkin.Controls.MaterialFlatButton OK;
        private MaterialSkin.Controls.MaterialFlatButton delBtn;
        private MaterialSkin.Controls.MaterialLabel label3;
        public System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.ColorDialog colorDialog;
        private MetroFramework.Controls.MetroDateTime dateTime;
    }
}