namespace EdgeProfileViewer
{
    partial class EdgeProfileViewer
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnLoadProfile = new System.Windows.Forms.Button();
            this.Music = new System.Windows.Forms.CheckBox();
            this.Sound = new System.Windows.Forms.CheckBox();
            this.Lang = new System.Windows.Forms.Label();
            this.ProfilePath = new System.Windows.Forms.TextBox();
            this.BestEdgeTime = new System.Windows.Forms.Label();
            this.LevelData = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LevelName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPlusTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ATime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prisms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrismsCollected = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RankIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NormalTotal = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.Ghost = new System.Windows.Forms.CheckBox();
            this.Turbo = new System.Windows.Forms.CheckBox();
            this.Orientation = new System.Windows.Forms.Label();
            this.BonusTotal = new System.Windows.Forms.Label();
            this.AllTotal = new System.Windows.Forms.Label();
            this.lbEnterProfilePath = new System.Windows.Forms.LinkLabel();
            this.Control = new System.Windows.Forms.Label();
            this.ShowPassword = new System.Windows.Forms.CheckBox();
            this.Password = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LevelData)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFileDialog
            // 
            this.OpenFileDialog.FileName = "option8";
            this.OpenFileDialog.Filter = "手机版存档文件|option8";
            this.OpenFileDialog.Title = "请选择存档文件";
            // 
            // btnLoadProfile
            // 
            this.btnLoadProfile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLoadProfile.Location = new System.Drawing.Point(748, 6);
            this.btnLoadProfile.Name = "btnLoadProfile";
            this.btnLoadProfile.Size = new System.Drawing.Size(74, 22);
            this.btnLoadProfile.TabIndex = 2;
            this.btnLoadProfile.Text = "加载存档";
            this.btnLoadProfile.UseVisualStyleBackColor = true;
            this.btnLoadProfile.Click += new System.EventHandler(this.btnLoadProfile_Click);
            // 
            // Music
            // 
            this.Music.AutoCheck = false;
            this.Music.AutoSize = true;
            this.Music.Location = new System.Drawing.Point(12, 50);
            this.Music.Name = "Music";
            this.Music.Size = new System.Drawing.Size(48, 16);
            this.Music.TabIndex = 8;
            this.Music.Text = "音乐";
            this.Music.UseVisualStyleBackColor = true;
            // 
            // Sound
            // 
            this.Sound.AutoCheck = false;
            this.Sound.AutoSize = true;
            this.Sound.Location = new System.Drawing.Point(66, 50);
            this.Sound.Name = "Sound";
            this.Sound.Size = new System.Drawing.Size(48, 16);
            this.Sound.TabIndex = 9;
            this.Sound.Text = "声音";
            this.Sound.UseVisualStyleBackColor = true;
            // 
            // Lang
            // 
            this.Lang.AutoSize = true;
            this.Lang.Location = new System.Drawing.Point(10, 34);
            this.Lang.Name = "Lang";
            this.Lang.Size = new System.Drawing.Size(41, 12);
            this.Lang.TabIndex = 3;
            this.Lang.Text = "语言：";
            // 
            // ProfilePath
            // 
            this.ProfilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProfilePath.Location = new System.Drawing.Point(190, 6);
            this.ProfilePath.Name = "ProfilePath";
            this.ProfilePath.Size = new System.Drawing.Size(552, 21);
            this.ProfilePath.TabIndex = 1;
            // 
            // BestEdgeTime
            // 
            this.BestEdgeTime.AutoSize = true;
            this.BestEdgeTime.Location = new System.Drawing.Point(540, 34);
            this.BestEdgeTime.Name = "BestEdgeTime";
            this.BestEdgeTime.Size = new System.Drawing.Size(101, 12);
            this.BestEdgeTime.TabIndex = 6;
            this.BestEdgeTime.Text = "最佳 Edge Time：";
            // 
            // LevelData
            // 
            this.LevelData.AllowUserToAddRows = false;
            this.LevelData.AllowUserToDeleteRows = false;
            this.LevelData.AllowUserToOrderColumns = true;
            this.LevelData.AllowUserToResizeRows = false;
            this.LevelData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LevelData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.LevelData.BackgroundColor = System.Drawing.Color.White;
            this.LevelData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LevelData.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LevelData.ColumnHeadersHeight = 19;
            this.LevelData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.LevelData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.ID,
            this.LevelName,
            this.Time,
            this.SPlusTime,
            this.STime,
            this.ATime,
            this.BTime,
            this.CTime,
            this.Prisms,
            this.PrismsCollected,
            this.Rank,
            this.RankIndex});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.LevelData.DefaultCellStyle = dataGridViewCellStyle9;
            this.LevelData.Location = new System.Drawing.Point(12, 72);
            this.LevelData.Name = "LevelData";
            this.LevelData.ReadOnly = true;
            this.LevelData.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.LevelData.RowHeadersWidth = 10;
            this.LevelData.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.LevelData.RowTemplate.Height = 18;
            this.LevelData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.LevelData.Size = new System.Drawing.Size(810, 335);
            this.LevelData.TabIndex = 15;
            this.LevelData.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.LevelData_SortCompare);
            // 
            // Number
            // 
            this.Number.FillWeight = 85F;
            this.Number.HeaderText = "#";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.FillWeight = 115F;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // LevelName
            // 
            this.LevelName.HeaderText = "关卡名";
            this.LevelName.Name = "LevelName";
            this.LevelName.ReadOnly = true;
            // 
            // Time
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.Time.DefaultCellStyle = dataGridViewCellStyle1;
            this.Time.FillWeight = 80F;
            this.Time.HeaderText = "时间";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // SPlusTime
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.SPlusTime.DefaultCellStyle = dataGridViewCellStyle2;
            this.SPlusTime.FillWeight = 60F;
            this.SPlusTime.HeaderText = "S+ 标准";
            this.SPlusTime.Name = "SPlusTime";
            this.SPlusTime.ReadOnly = true;
            // 
            // STime
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.STime.DefaultCellStyle = dataGridViewCellStyle3;
            this.STime.FillWeight = 60F;
            this.STime.HeaderText = "S 标准";
            this.STime.Name = "STime";
            this.STime.ReadOnly = true;
            // 
            // ATime
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.ATime.DefaultCellStyle = dataGridViewCellStyle4;
            this.ATime.FillWeight = 60F;
            this.ATime.HeaderText = "A 标准";
            this.ATime.Name = "ATime";
            this.ATime.ReadOnly = true;
            // 
            // BTime
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.BTime.DefaultCellStyle = dataGridViewCellStyle5;
            this.BTime.FillWeight = 60F;
            this.BTime.HeaderText = "B 标准";
            this.BTime.Name = "BTime";
            this.BTime.ReadOnly = true;
            // 
            // CTime
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.CTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.CTime.FillWeight = 60F;
            this.CTime.HeaderText = "C 标准";
            this.CTime.Name = "CTime";
            this.CTime.ReadOnly = true;
            // 
            // Prisms
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.NullValue = null;
            this.Prisms.DefaultCellStyle = dataGridViewCellStyle7;
            this.Prisms.FillWeight = 60F;
            this.Prisms.HeaderText = "棱柱数";
            this.Prisms.Name = "Prisms";
            this.Prisms.ReadOnly = true;
            // 
            // PrismsCollected
            // 
            this.PrismsCollected.HeaderText = "已收集棱柱数";
            this.PrismsCollected.Name = "PrismsCollected";
            this.PrismsCollected.ReadOnly = true;
            this.PrismsCollected.Visible = false;
            // 
            // Rank
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Rank.DefaultCellStyle = dataGridViewCellStyle8;
            this.Rank.FillWeight = 50F;
            this.Rank.HeaderText = "等级";
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            // 
            // RankIndex
            // 
            this.RankIndex.HeaderText = "等级序号";
            this.RankIndex.Name = "RankIndex";
            this.RankIndex.ReadOnly = true;
            this.RankIndex.Visible = false;
            // 
            // NormalTotal
            // 
            this.NormalTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NormalTotal.AutoSize = true;
            this.NormalTotal.Location = new System.Drawing.Point(10, 410);
            this.NormalTotal.Name = "NormalTotal";
            this.NormalTotal.Size = new System.Drawing.Size(53, 12);
            this.NormalTotal.TabIndex = 16;
            this.NormalTotal.Text = "标准关：";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Location = new System.Drawing.Point(344, 50);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(65, 12);
            this.UserName.TabIndex = 12;
            this.UserName.Text = "用户名：  ";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(540, 50);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(41, 12);
            this.PasswordLabel.TabIndex = 13;
            this.PasswordLabel.Text = "密码：";
            // 
            // Ghost
            // 
            this.Ghost.AutoCheck = false;
            this.Ghost.AutoSize = true;
            this.Ghost.Location = new System.Drawing.Point(120, 50);
            this.Ghost.Name = "Ghost";
            this.Ghost.Size = new System.Drawing.Size(72, 16);
            this.Ghost.TabIndex = 10;
            this.Ghost.Text = "幽灵方块";
            this.Ghost.UseVisualStyleBackColor = true;
            // 
            // Turbo
            // 
            this.Turbo.AutoCheck = false;
            this.Turbo.AutoSize = true;
            this.Turbo.Location = new System.Drawing.Point(198, 50);
            this.Turbo.Name = "Turbo";
            this.Turbo.Size = new System.Drawing.Size(72, 16);
            this.Turbo.TabIndex = 11;
            this.Turbo.Text = "涡轮模式";
            this.Turbo.UseVisualStyleBackColor = true;
            // 
            // Orientation
            // 
            this.Orientation.AutoSize = true;
            this.Orientation.Location = new System.Drawing.Point(344, 34);
            this.Orientation.Name = "Orientation";
            this.Orientation.Size = new System.Drawing.Size(125, 12);
            this.Orientation.TabIndex = 5;
            this.Orientation.Text = "游戏内界面旋转角度：";
            // 
            // BonusTotal
            // 
            this.BonusTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BonusTotal.AutoSize = true;
            this.BonusTotal.Location = new System.Drawing.Point(10, 425);
            this.BonusTotal.Name = "BonusTotal";
            this.BonusTotal.Size = new System.Drawing.Size(53, 12);
            this.BonusTotal.TabIndex = 17;
            this.BonusTotal.Text = "奖励关：";
            // 
            // AllTotal
            // 
            this.AllTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.AllTotal.AutoSize = true;
            this.AllTotal.Location = new System.Drawing.Point(10, 440);
            this.AllTotal.Name = "AllTotal";
            this.AllTotal.Size = new System.Drawing.Size(53, 12);
            this.AllTotal.TabIndex = 18;
            this.AllTotal.Text = "所有关：";
            // 
            // lbEnterProfilePath
            // 
            this.lbEnterProfilePath.AutoSize = true;
            this.lbEnterProfilePath.LinkArea = new System.Windows.Forms.LinkArea(3, 2);
            this.lbEnterProfilePath.Location = new System.Drawing.Point(12, 9);
            this.lbEnterProfilePath.Name = "lbEnterProfilePath";
            this.lbEnterProfilePath.Size = new System.Drawing.Size(177, 19);
            this.lbEnterProfilePath.TabIndex = 0;
            this.lbEnterProfilePath.TabStop = true;
            this.lbEnterProfilePath.Text = "输入或浏览你的存档文件路径：";
            this.lbEnterProfilePath.UseCompatibleTextRendering = true;
            this.lbEnterProfilePath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbEnterProfilePath_LinkClicked);
            // 
            // Control
            // 
            this.Control.AutoSize = true;
            this.Control.Location = new System.Drawing.Point(153, 34);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(65, 12);
            this.Control.TabIndex = 4;
            this.Control.Text = "控制方式：";
            // 
            // ShowPassword
            // 
            this.ShowPassword.AutoSize = true;
            this.ShowPassword.Location = new System.Drawing.Point(748, 34);
            this.ShowPassword.Name = "ShowPassword";
            this.ShowPassword.Size = new System.Drawing.Size(72, 16);
            this.ShowPassword.TabIndex = 7;
            this.ShowPassword.Text = "显示密码";
            this.ShowPassword.UseVisualStyleBackColor = true;
            this.ShowPassword.CheckedChanged += new System.EventHandler(this.ShowPassword_CheckedChanged);
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(582, 50);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(0, 12);
            this.Password.TabIndex = 14;
            this.Password.Visible = false;
            // 
            // EdgeProfileViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(834, 461);
            this.Controls.Add(this.lbEnterProfilePath);
            this.Controls.Add(this.ProfilePath);
            this.Controls.Add(this.btnLoadProfile);
            this.Controls.Add(this.Lang);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.Orientation);
            this.Controls.Add(this.BestEdgeTime);
            this.Controls.Add(this.Music);
            this.Controls.Add(this.Sound);
            this.Controls.Add(this.Ghost);
            this.Controls.Add(this.Turbo);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ShowPassword);
            this.Controls.Add(this.LevelData);
            this.Controls.Add(this.NormalTotal);
            this.Controls.Add(this.BonusTotal);
            this.Controls.Add(this.AllTotal);
            this.DoubleBuffered = true;
            this.MinimumSize = new System.Drawing.Size(850, 300);
            this.Name = "EdgeProfileViewer";
            this.Text = "Edge手机版存档读取器 V1.0";
            ((System.ComponentModel.ISupportInitialize)(this.LevelData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFileDialog;
        private System.Windows.Forms.Button btnLoadProfile;
        private System.Windows.Forms.CheckBox Music;
        private System.Windows.Forms.CheckBox Sound;
        private System.Windows.Forms.Label Lang;
        private System.Windows.Forms.TextBox ProfilePath;
        private System.Windows.Forms.Label BestEdgeTime;
        private System.Windows.Forms.DataGridView LevelData;
        private System.Windows.Forms.Label NormalTotal;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.CheckBox Ghost;
        private System.Windows.Forms.CheckBox Turbo;
        private System.Windows.Forms.Label Orientation;
        private System.Windows.Forms.Label BonusTotal;
        private System.Windows.Forms.Label AllTotal;
        private System.Windows.Forms.LinkLabel lbEnterProfilePath;
        private System.Windows.Forms.Label Control;
        private System.Windows.Forms.CheckBox ShowPassword;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LevelName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPlusTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn STime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ATime;
        private System.Windows.Forms.DataGridViewTextBoxColumn BTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn CTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prisms;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrismsCollected;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn RankIndex;

    }
}

