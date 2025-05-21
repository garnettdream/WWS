namespace HelloWindow
{
    partial class 氪金计算器
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(氪金计算器));
            this.确认计算 = new System.Windows.Forms.Button();
            this.亚服WG = new System.Windows.Forms.Label();
            this.Steam = new System.Windows.Forms.Label();
            this.其他渠道 = new System.Windows.Forms.Label();
            this.钱RMB = new System.Windows.Forms.Label();
            this.金币 = new System.Windows.Forms.Label();
            this.金价比 = new System.Windows.Forms.Label();
            this.亚服官网 = new System.Windows.Forms.LinkLabel();
            this.官网购买金币数 = new System.Windows.Forms.ComboBox();
            this.Steam购买金币数 = new System.Windows.Forms.ComboBox();
            this.其他渠道购买金币数 = new System.Windows.Forms.ComboBox();
            this.折扣 = new System.Windows.Forms.Label();
            this.WG官网默认价格 = new System.Windows.Forms.ComboBox();
            this.Steam默认价格 = new System.Windows.Forms.ComboBox();
            this.WG折扣 = new System.Windows.Forms.ComboBox();
            this.Steam折扣 = new System.Windows.Forms.ComboBox();
            this.WG金价比 = new System.Windows.Forms.Label();
            this.Steam金价比 = new System.Windows.Forms.Label();
            this.其他渠道金价比 = new System.Windows.Forms.Label();
            this.重置 = new System.Windows.Forms.Button();
            this.其他渠道价格 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.保存输入信息 = new System.Windows.Forms.SaveFileDialog();
            this.保存 = new System.Windows.Forms.Button();
            this.读取 = new System.Windows.Forms.Button();
            this.其他渠道折扣 = new System.Windows.Forms.TextBox();
            this.读取保存文件 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.其他渠道价格)).BeginInit();
            this.SuspendLayout();
            // 
            // 确认计算
            // 
            this.确认计算.Location = new System.Drawing.Point(830, 412);
            this.确认计算.Name = "确认计算";
            this.确认计算.Size = new System.Drawing.Size(90, 60);
            this.确认计算.TabIndex = 0;
            this.确认计算.Text = "计算";
            this.确认计算.UseVisualStyleBackColor = true;
            // 
            // 亚服WG
            // 
            this.亚服WG.AutoSize = true;
            this.亚服WG.BackColor = System.Drawing.Color.Transparent;
            this.亚服WG.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.亚服WG.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.亚服WG.Location = new System.Drawing.Point(170, 37);
            this.亚服WG.Name = "亚服WG";
            this.亚服WG.Size = new System.Drawing.Size(162, 47);
            this.亚服WG.TabIndex = 1;
            this.亚服WG.Text = "WG官网";
            // 
            // Steam
            // 
            this.Steam.AutoSize = true;
            this.Steam.BackColor = System.Drawing.Color.Transparent;
            this.Steam.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Steam.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Steam.Location = new System.Drawing.Point(390, 37);
            this.Steam.Name = "Steam";
            this.Steam.Size = new System.Drawing.Size(140, 47);
            this.Steam.TabIndex = 2;
            this.Steam.Text = "Steam";
            this.Steam.Click += new System.EventHandler(this.Steam氪金_Click);
            // 
            // 其他渠道
            // 
            this.其他渠道.AutoSize = true;
            this.其他渠道.BackColor = System.Drawing.Color.Transparent;
            this.其他渠道.Font = new System.Drawing.Font("宋体", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.其他渠道.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.其他渠道.Location = new System.Drawing.Point(590, 37);
            this.其他渠道.Name = "其他渠道";
            this.其他渠道.Size = new System.Drawing.Size(208, 47);
            this.其他渠道.TabIndex = 3;
            this.其他渠道.Text = "其他渠道";
            // 
            // 钱RMB
            // 
            this.钱RMB.AutoSize = true;
            this.钱RMB.BackColor = System.Drawing.Color.Transparent;
            this.钱RMB.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.钱RMB.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.钱RMB.Location = new System.Drawing.Point(18, 130);
            this.钱RMB.Name = "钱RMB";
            this.钱RMB.Size = new System.Drawing.Size(134, 34);
            this.钱RMB.TabIndex = 4;
            this.钱RMB.Text = "钱(RMB)";
            // 
            // 金币
            // 
            this.金币.AutoSize = true;
            this.金币.BackColor = System.Drawing.Color.Transparent;
            this.金币.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.金币.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.金币.Location = new System.Drawing.Point(18, 270);
            this.金币.Name = "金币";
            this.金币.Size = new System.Drawing.Size(117, 34);
            this.金币.TabIndex = 5;
            this.金币.Text = "达布隆";
            // 
            // 金价比
            // 
            this.金价比.AutoSize = true;
            this.金价比.BackColor = System.Drawing.Color.Transparent;
            this.金价比.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.金价比.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.金价比.Location = new System.Drawing.Point(18, 340);
            this.金价比.Name = "金价比";
            this.金价比.Size = new System.Drawing.Size(117, 68);
            this.金价比.TabIndex = 6;
            this.金价比.Text = "金价比\r\n(金/R)\r\n";
            this.金价比.Click += new System.EventHandler(this.金价比_Click);
            // 
            // 亚服官网
            // 
            this.亚服官网.AutoSize = true;
            this.亚服官网.BackColor = System.Drawing.Color.Transparent;
            this.亚服官网.LinkColor = System.Drawing.Color.Red;
            this.亚服官网.Location = new System.Drawing.Point(198, 86);
            this.亚服官网.Name = "亚服官网";
            this.亚服官网.Size = new System.Drawing.Size(91, 15);
            this.亚服官网.TabIndex = 7;
            this.亚服官网.TabStop = true;
            this.亚服官网.Text = "WWS亚服官网";
            // 
            // 官网购买金币数
            // 
            this.官网购买金币数.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.官网购买金币数.FormattingEnabled = true;
            this.官网购买金币数.Items.AddRange(new object[] {
            "50000",
            "25000",
            "12500",
            "7500",
            "5000",
            "2500",
            "1250"});
            this.官网购买金币数.Location = new System.Drawing.Point(196, 273);
            this.官网购买金币数.Name = "官网购买金币数";
            this.官网购买金币数.Size = new System.Drawing.Size(110, 28);
            this.官网购买金币数.TabIndex = 8;
            this.官网购买金币数.Text = "0";
            this.官网购买金币数.SelectedIndexChanged += new System.EventHandler(this.购买金币数_SelectedIndexChanged);
            // 
            // Steam购买金币数
            // 
            this.Steam购买金币数.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Steam购买金币数.FormattingEnabled = true;
            this.Steam购买金币数.Items.AddRange(new object[] {
            "50000",
            "25000",
            "12500",
            "7500",
            "5000",
            "2500",
            "1250"});
            this.Steam购买金币数.Location = new System.Drawing.Point(405, 273);
            this.Steam购买金币数.Name = "Steam购买金币数";
            this.Steam购买金币数.Size = new System.Drawing.Size(110, 28);
            this.Steam购买金币数.TabIndex = 9;
            this.Steam购买金币数.Text = "0";
            // 
            // 其他渠道购买金币数
            // 
            this.其他渠道购买金币数.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.其他渠道购买金币数.FormattingEnabled = true;
            this.其他渠道购买金币数.Items.AddRange(new object[] {
            "50000",
            "25000",
            "12500",
            "7500",
            "5000",
            "2500",
            "1250"});
            this.其他渠道购买金币数.Location = new System.Drawing.Point(639, 273);
            this.其他渠道购买金币数.Name = "其他渠道购买金币数";
            this.其他渠道购买金币数.Size = new System.Drawing.Size(110, 28);
            this.其他渠道购买金币数.TabIndex = 10;
            this.其他渠道购买金币数.Text = "0";
            // 
            // 折扣
            // 
            this.折扣.AutoSize = true;
            this.折扣.BackColor = System.Drawing.Color.Transparent;
            this.折扣.Font = new System.Drawing.Font("宋体", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.折扣.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.折扣.Location = new System.Drawing.Point(18, 200);
            this.折扣.Name = "折扣";
            this.折扣.Size = new System.Drawing.Size(151, 34);
            this.折扣.TabIndex = 11;
            this.折扣.Text = "折扣(-%)";
            // 
            // WG官网默认价格
            // 
            this.WG官网默认价格.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.WG官网默认价格.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WG官网默认价格.FormattingEnabled = true;
            this.WG官网默认价格.Location = new System.Drawing.Point(196, 133);
            this.WG官网默认价格.Name = "WG官网默认价格";
            this.WG官网默认价格.Size = new System.Drawing.Size(110, 28);
            this.WG官网默认价格.TabIndex = 12;
            this.WG官网默认价格.Text = "0";
            this.WG官网默认价格.SelectedIndexChanged += new System.EventHandler(this.WG官网默认价格_SelectedIndexChanged);
            // 
            // Steam默认价格
            // 
            this.Steam默认价格.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Steam默认价格.FormattingEnabled = true;
            this.Steam默认价格.Location = new System.Drawing.Point(405, 133);
            this.Steam默认价格.Name = "Steam默认价格";
            this.Steam默认价格.Size = new System.Drawing.Size(110, 28);
            this.Steam默认价格.TabIndex = 13;
            this.Steam默认价格.Text = "0";
            // 
            // WG折扣
            // 
            this.WG折扣.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.WG折扣.FormattingEnabled = true;
            this.WG折扣.Items.AddRange(new object[] {
            "-10%",
            "-15%",
            "-25%"});
            this.WG折扣.Location = new System.Drawing.Point(196, 203);
            this.WG折扣.Name = "WG折扣";
            this.WG折扣.Size = new System.Drawing.Size(110, 28);
            this.WG折扣.TabIndex = 15;
            this.WG折扣.Text = "0";
            // 
            // Steam折扣
            // 
            this.Steam折扣.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Steam折扣.FormattingEnabled = true;
            this.Steam折扣.Items.AddRange(new object[] {
            "-10%",
            "-15%",
            "-25%"});
            this.Steam折扣.Location = new System.Drawing.Point(405, 203);
            this.Steam折扣.Name = "Steam折扣";
            this.Steam折扣.Size = new System.Drawing.Size(110, 28);
            this.Steam折扣.TabIndex = 16;
            this.Steam折扣.Text = "0";
            // 
            // WG金价比
            // 
            this.WG金价比.AutoSize = true;
            this.WG金价比.Location = new System.Drawing.Point(216, 367);
            this.WG金价比.Name = "WG金价比";
            this.WG金价比.Size = new System.Drawing.Size(15, 15);
            this.WG金价比.TabIndex = 18;
            this.WG金价比.Text = "1";
            // 
            // Steam金价比
            // 
            this.Steam金价比.AutoSize = true;
            this.Steam金价比.Location = new System.Drawing.Point(432, 367);
            this.Steam金价比.Name = "Steam金价比";
            this.Steam金价比.Size = new System.Drawing.Size(55, 15);
            this.Steam金价比.TabIndex = 19;
            this.Steam金价比.Text = "label3";
            // 
            // 其他渠道金价比
            // 
            this.其他渠道金价比.AutoSize = true;
            this.其他渠道金价比.Location = new System.Drawing.Point(665, 367);
            this.其他渠道金价比.Name = "其他渠道金价比";
            this.其他渠道金价比.Size = new System.Drawing.Size(55, 15);
            this.其他渠道金价比.TabIndex = 20;
            this.其他渠道金价比.Text = "label4";
            // 
            // 重置
            // 
            this.重置.Location = new System.Drawing.Point(830, 41);
            this.重置.Name = "重置";
            this.重置.Size = new System.Drawing.Size(90, 60);
            this.重置.TabIndex = 21;
            this.重置.Text = "重置";
            this.重置.UseVisualStyleBackColor = true;
            // 
            // 其他渠道价格
            // 
            this.其他渠道价格.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.其他渠道价格.Location = new System.Drawing.Point(639, 133);
            this.其他渠道价格.Name = "其他渠道价格";
            this.其他渠道价格.Size = new System.Drawing.Size(110, 30);
            this.其他渠道价格.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(830, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 60);
            this.button1.TabIndex = 23;
            this.button1.Text = "日间/夜间";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // 保存
            // 
            this.保存.Location = new System.Drawing.Point(830, 322);
            this.保存.Name = "保存";
            this.保存.Size = new System.Drawing.Size(90, 60);
            this.保存.TabIndex = 24;
            this.保存.Text = "保存";
            this.保存.UseVisualStyleBackColor = true;
            // 
            // 读取
            // 
            this.读取.Location = new System.Drawing.Point(830, 226);
            this.读取.Name = "读取";
            this.读取.Size = new System.Drawing.Size(90, 60);
            this.读取.TabIndex = 25;
            this.读取.Text = "读取";
            this.读取.UseVisualStyleBackColor = true;
            // 
            // 其他渠道折扣
            // 
            this.其他渠道折扣.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.其他渠道折扣.Location = new System.Drawing.Point(639, 203);
            this.其他渠道折扣.Name = "其他渠道折扣";
            this.其他渠道折扣.Size = new System.Drawing.Size(110, 30);
            this.其他渠道折扣.TabIndex = 26;
            this.其他渠道折扣.Text = "还有折扣？";
            // 
            // 读取保存文件
            // 
            this.读取保存文件.FileName = "保存的文件";
            // 
            // 氪金计算器
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(945, 498);
            this.Controls.Add(this.其他渠道折扣);
            this.Controls.Add(this.读取);
            this.Controls.Add(this.保存);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.其他渠道价格);
            this.Controls.Add(this.重置);
            this.Controls.Add(this.其他渠道金价比);
            this.Controls.Add(this.Steam金价比);
            this.Controls.Add(this.WG金价比);
            this.Controls.Add(this.Steam折扣);
            this.Controls.Add(this.WG折扣);
            this.Controls.Add(this.Steam默认价格);
            this.Controls.Add(this.WG官网默认价格);
            this.Controls.Add(this.折扣);
            this.Controls.Add(this.其他渠道购买金币数);
            this.Controls.Add(this.Steam购买金币数);
            this.Controls.Add(this.官网购买金币数);
            this.Controls.Add(this.亚服官网);
            this.Controls.Add(this.金价比);
            this.Controls.Add(this.金币);
            this.Controls.Add(this.钱RMB);
            this.Controls.Add(this.其他渠道);
            this.Controls.Add(this.Steam);
            this.Controls.Add(this.亚服WG);
            this.Controls.Add(this.确认计算);
            this.Name = "氪金计算器";
            this.Text = "氪金计算器";
            ((System.ComponentModel.ISupportInitialize)(this.其他渠道价格)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button 确认计算;
        private System.Windows.Forms.Label 亚服WG;
        private System.Windows.Forms.Label Steam;
        private System.Windows.Forms.Label 其他渠道;
        private System.Windows.Forms.Label 钱RMB;
        private System.Windows.Forms.Label 金币;
        private System.Windows.Forms.Label 金价比;
        private System.Windows.Forms.LinkLabel 亚服官网;
        private System.Windows.Forms.ComboBox 官网购买金币数;
        private System.Windows.Forms.ComboBox Steam购买金币数;
        private System.Windows.Forms.ComboBox 其他渠道购买金币数;
        private System.Windows.Forms.Label 折扣;
        private System.Windows.Forms.ComboBox WG官网默认价格;
        private System.Windows.Forms.ComboBox Steam默认价格;
        private System.Windows.Forms.ComboBox WG折扣;
        private System.Windows.Forms.ComboBox Steam折扣;
        private System.Windows.Forms.Label WG金价比;
        private System.Windows.Forms.Label Steam金价比;
        private System.Windows.Forms.Label 其他渠道金价比;
        private System.Windows.Forms.Button 重置;
        private System.Windows.Forms.NumericUpDown 其他渠道价格;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.SaveFileDialog 保存输入信息;
        private System.Windows.Forms.Button 保存;
        private System.Windows.Forms.Button 读取;
        private System.Windows.Forms.TextBox 其他渠道折扣;
        private System.Windows.Forms.OpenFileDialog 读取保存文件;
    }
}

