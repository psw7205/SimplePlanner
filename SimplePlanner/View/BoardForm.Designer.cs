namespace SimplePlanner.View
{
    partial class BoardForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.boardName = new MaterialSkin.Controls.MaterialLabel();
            this.AddBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.EditBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.tabControl = new MetroFramework.Controls.MetroTabControl();
            this.DelBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.SuspendLayout();
            // 
            // boardName
            // 
            this.boardName.AutoSize = true;
            this.boardName.Depth = 0;
            this.boardName.Font = new System.Drawing.Font("Roboto", 11F);
            this.boardName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.boardName.Location = new System.Drawing.Point(20, 14);
            this.boardName.MouseState = MaterialSkin.MouseState.HOVER;
            this.boardName.Name = "boardName";
            this.boardName.Size = new System.Drawing.Size(125, 24);
            this.boardName.TabIndex = 1;
            this.boardName.Text = "BOARDNAME";
            // 
            // AddBtn
            // 
            this.AddBtn.AutoSize = true;
            this.AddBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddBtn.Depth = 0;
            this.AddBtn.Location = new System.Drawing.Point(152, 4);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.AddBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Primary = false;
            this.AddBtn.Size = new System.Drawing.Size(47, 36);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "ADD";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.AutoSize = true;
            this.EditBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.EditBtn.Depth = 0;
            this.EditBtn.Location = new System.Drawing.Point(207, 2);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.EditBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Primary = false;
            this.EditBtn.Size = new System.Drawing.Size(49, 36);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "EDIT";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(12, 49);
            this.tabControl.Name = "tabControl";
            this.tabControl.Size = new System.Drawing.Size(1043, 544);
            this.tabControl.TabIndex = 0;
            this.tabControl.UseSelectable = true;
            this.tabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl_Selected);
            // 
            // DelBtn
            // 
            this.DelBtn.AutoSize = true;
            this.DelBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DelBtn.Depth = 0;
            this.DelBtn.Location = new System.Drawing.Point(264, 2);
            this.DelBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.DelBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Primary = false;
            this.DelBtn.Size = new System.Drawing.Size(43, 36);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "DEL";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(954, 4);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(100, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Calendar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // BoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 605);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.boardName);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BoardForm";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BoardForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MaterialSkin.Controls.MaterialLabel boardName;
        private MaterialSkin.Controls.MaterialFlatButton AddBtn;
        private MaterialSkin.Controls.MaterialFlatButton EditBtn;
        private MetroFramework.Controls.MetroTabControl tabControl;
        private MaterialSkin.Controls.MaterialFlatButton DelBtn;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
    }
}

