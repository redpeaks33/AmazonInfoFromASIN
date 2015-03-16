namespace ProductInfoFromASIN
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_Export = new System.Windows.Forms.Button();
            this.button_GetProductInfo = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.button_SetID = new System.Windows.Forms.Button();
            this.productInfoDataGridView = new ProductInfoFromASIN.ProductInfoDataGridView();
            this.ASINCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.ImageLinkColumn = new System.Windows.Forms.DataGridViewLinkColumn();
            this.URL = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmazonRank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price_Japan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productInfoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_Export);
            this.splitContainer1.Panel1.Controls.Add(this.button_SetID);
            this.splitContainer1.Panel1.Controls.Add(this.button_GetProductInfo);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(784, 562);
            this.splitContainer1.SplitterDistance = 43;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_Export
            // 
            this.button_Export.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button_Export.Location = new System.Drawing.Point(664, 4);
            this.button_Export.Name = "button_Export";
            this.button_Export.Size = new System.Drawing.Size(117, 37);
            this.button_Export.TabIndex = 0;
            this.button_Export.Text = "ExportToExcel";
            this.button_Export.UseVisualStyleBackColor = true;
            this.button_Export.Click += new System.EventHandler(this.ButtonClick_ExportToExcel);
            // 
            // button_GetProductInfo
            // 
            this.button_GetProductInfo.Location = new System.Drawing.Point(124, 4);
            this.button_GetProductInfo.Name = "button_GetProductInfo";
            this.button_GetProductInfo.Size = new System.Drawing.Size(117, 37);
            this.button_GetProductInfo.TabIndex = 0;
            this.button_GetProductInfo.Text = "Get ProductInfo";
            this.button_GetProductInfo.UseVisualStyleBackColor = true;
            this.button_GetProductInfo.Click += new System.EventHandler(this.ButtonClick_GetProductInfo);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.richTextBox);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.AutoScroll = true;
            this.splitContainer2.Panel2.Controls.Add(this.productInfoDataGridView);
            this.splitContainer2.Size = new System.Drawing.Size(784, 515);
            this.splitContainer2.SplitterDistance = 120;
            this.splitContainer2.TabIndex = 0;
            // 
            // richTextBox
            // 
            this.richTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox.Location = new System.Drawing.Point(0, 0);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(120, 515);
            this.richTextBox.TabIndex = 0;
            this.richTextBox.Text = "";
            // 
            // button_SetID
            // 
            this.button_SetID.Location = new System.Drawing.Point(3, 4);
            this.button_SetID.Name = "button_SetID";
            this.button_SetID.Size = new System.Drawing.Size(117, 37);
            this.button_SetID.TabIndex = 0;
            this.button_SetID.Text = "Set ID";
            this.button_SetID.UseVisualStyleBackColor = true;
            this.button_SetID.Click += new System.EventHandler(this.ButtonClick_SetID);
            // 
            // productInfoDataGridView
            // 
            this.productInfoDataGridView.AllowUserToAddRows = false;
            this.productInfoDataGridView.AllowUserToDeleteRows = false;
            this.productInfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productInfoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ASINCode,
            this.ImageColumn,
            this.ImageLinkColumn,
            this.URL,
            this.Category,
            this.AmazonRank,
            this.Price_Japan});
            this.productInfoDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productInfoDataGridView.Location = new System.Drawing.Point(0, 0);
            this.productInfoDataGridView.Name = "productInfoDataGridView";
            this.productInfoDataGridView.RowHeadersVisible = false;
            this.productInfoDataGridView.RowTemplate.Height = 100;
            this.productInfoDataGridView.Size = new System.Drawing.Size(660, 515);
            this.productInfoDataGridView.TabIndex = 0;
            // 
            // ASINCode
            // 
            this.ASINCode.HeaderText = "Code";
            this.ASINCode.Name = "ASINCode";
            // 
            // ImageColumn
            // 
            this.ImageColumn.HeaderText = "Image";
            this.ImageColumn.Name = "ImageColumn";
            this.ImageColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // ImageLinkColumn
            // 
            this.ImageLinkColumn.HeaderText = "ImageLink";
            this.ImageLinkColumn.Name = "ImageLinkColumn";
            this.ImageLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ImageLinkColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // URL
            // 
            this.URL.HeaderText = "URL";
            this.URL.Name = "URL";
            this.URL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.URL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.Name = "Category";
            // 
            // AmazonRank
            // 
            this.AmazonRank.HeaderText = "AmazonRank";
            this.AmazonRank.Name = "AmazonRank";
            // 
            // Price_Japan
            // 
            this.Price_Japan.HeaderText = "JPrice";
            this.Price_Japan.Name = "Price_Japan";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductInfoFromASIN";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.productInfoDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button_Export;
        private System.Windows.Forms.Button button_GetProductInfo;
        private ProductInfoDataGridView productInfoDataGridView;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ASINCode;
        private System.Windows.Forms.DataGridViewImageColumn ImageColumn;
        private System.Windows.Forms.DataGridViewLinkColumn ImageLinkColumn;
        private System.Windows.Forms.DataGridViewLinkColumn URL;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmazonRank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price_Japan;
        private System.Windows.Forms.Button button_SetID;
    }
}

