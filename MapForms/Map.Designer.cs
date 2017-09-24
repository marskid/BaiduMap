namespace MapForms
{
    partial class MapContainer
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
            this.components = new System.ComponentModel.Container();
            this.BaiduMap = new System.Windows.Forms.WebBrowser();
            this.CityNum = new System.Windows.Forms.Label();
            this.CityNumVal = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.CitySelect = new System.Windows.Forms.ComboBox();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BaiduMap
            // 
            this.BaiduMap.Dock = System.Windows.Forms.DockStyle.Right;
            this.BaiduMap.IsWebBrowserContextMenuEnabled = false;
            this.BaiduMap.Location = new System.Drawing.Point(125, 0);
            this.BaiduMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.BaiduMap.Name = "BaiduMap";
            this.BaiduMap.ScrollBarsEnabled = false;
            this.BaiduMap.Size = new System.Drawing.Size(659, 561);
            this.BaiduMap.TabIndex = 0;
            this.BaiduMap.WebBrowserShortcutsEnabled = false;
            // 
            // CityNum
            // 
            this.CityNum.AutoSize = true;
            this.CityNum.Location = new System.Drawing.Point(13, 13);
            this.CityNum.Name = "CityNum";
            this.CityNum.Size = new System.Drawing.Size(61, 13);
            this.CityNum.TabIndex = 1;
            this.CityNum.Text = "城市数量：";
            // 
            // CityNumVal
            // 
            this.CityNumVal.AutoSize = true;
            this.CityNumVal.Location = new System.Drawing.Point(80, 13);
            this.CityNumVal.Name = "CityNumVal";
            this.CityNumVal.Size = new System.Drawing.Size(13, 13);
            this.CityNumVal.TabIndex = 2;
            this.CityNumVal.Text = "0";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Location = new System.Drawing.Point(16, 39);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(75, 23);
            this.RefreshBtn.TabIndex = 3;
            this.RefreshBtn.Text = "刷新";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // CitySelect
            // 
            this.CitySelect.DataSource = this.cityBindingSource;
            this.CitySelect.DisplayMember = "Name";
            this.CitySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CitySelect.FormattingEnabled = true;
            this.CitySelect.Location = new System.Drawing.Point(16, 82);
            this.CitySelect.Name = "CitySelect";
            this.CitySelect.Size = new System.Drawing.Size(77, 21);
            this.CitySelect.TabIndex = 4;
            this.CitySelect.ValueMember = "Id";
            this.CitySelect.SelectedIndexChanged += new System.EventHandler(this.CitySelect_SelectedIndexChanged);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(MapForms.MapService.City);
            // 
            // MapContainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.CitySelect);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.CityNumVal);
            this.Controls.Add(this.CityNum);
            this.Controls.Add(this.BaiduMap);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MapContainer";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "地图";
            this.Load += new System.EventHandler(this.MapContainer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser BaiduMap;
        private System.Windows.Forms.Label CityNum;
        private System.Windows.Forms.Label CityNumVal;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.ComboBox CitySelect;
        private System.Windows.Forms.BindingSource cityBindingSource;
    }
}

