namespace SimplePlanner.View
{
    partial class MoveWorkForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.applyBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(350, 350);
            this.tabControl1.TabIndex = 0;
            // 
            // tabControl2
            // 
            this.tabControl2.Location = new System.Drawing.Point(420, 12);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(350, 350);
            this.tabControl2.TabIndex = 1;
            // 
            // applyBtn
            // 
            this.applyBtn.Location = new System.Drawing.Point(508, 409);
            this.applyBtn.Name = "applyBtn";
            this.applyBtn.Size = new System.Drawing.Size(128, 32);
            this.applyBtn.TabIndex = 2;
            this.applyBtn.Text = "적용";
            this.applyBtn.UseVisualStyleBackColor = true;
            this.applyBtn.Click += new System.EventHandler(this.applyBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(642, 409);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(128, 32);
            this.cancelBtn.TabIndex = 3;
            this.cancelBtn.Text = "취소";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // MoveWorkForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.applyBtn);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.tabControl1);
            this.Name = "MoveWorkForm";
            this.Text = "MoveWorkForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.Button applyBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}