namespace ProductInfoFromASIN
{
    partial class IDInputForm
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
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.Label_marketplaceId = new System.Windows.Forms.Label();
            this.Label_sellerId = new System.Windows.Forms.Label();
            this.Label_SecretKey = new System.Windows.Forms.Label();
            this.textBox_SellerID = new System.Windows.Forms.TextBox();
            this.textBox_MarketplaceID = new System.Windows.Forms.TextBox();
            this.Label_AccessKey = new System.Windows.Forms.Label();
            this.textBox_SecretKey = new System.Windows.Forms.TextBox();
            this.textBox_AccessKey = new System.Windows.Forms.TextBox();
            this.button_OK = new System.Windows.Forms.Button();
            this.button_cancel = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.51456F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.48544F));
            this.tableLayoutPanel.Controls.Add(this.Label_marketplaceId, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.Label_sellerId, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.Label_SecretKey, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.textBox_SellerID, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBox_MarketplaceID, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.Label_AccessKey, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBox_SecretKey, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.textBox_AccessKey, 1, 0);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 4;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(315, 129);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // Label_marketplaceId
            // 
            this.Label_marketplaceId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_marketplaceId.AutoSize = true;
            this.Label_marketplaceId.Location = new System.Drawing.Point(8, 106);
            this.Label_marketplaceId.Name = "Label_marketplaceId";
            this.Label_marketplaceId.Size = new System.Drawing.Size(75, 13);
            this.Label_marketplaceId.TabIndex = 7;
            this.Label_marketplaceId.Text = "MarketplaceId";
            // 
            // Label_sellerId
            // 
            this.Label_sellerId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_sellerId.AutoSize = true;
            this.Label_sellerId.Location = new System.Drawing.Point(25, 73);
            this.Label_sellerId.Name = "Label_sellerId";
            this.Label_sellerId.Size = new System.Drawing.Size(42, 13);
            this.Label_sellerId.TabIndex = 6;
            this.Label_sellerId.Text = "SellerId";
            // 
            // Label_SecretKey
            // 
            this.Label_SecretKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_SecretKey.AutoSize = true;
            this.Label_SecretKey.Location = new System.Drawing.Point(18, 41);
            this.Label_SecretKey.Name = "Label_SecretKey";
            this.Label_SecretKey.Size = new System.Drawing.Size(56, 13);
            this.Label_SecretKey.TabIndex = 5;
            this.Label_SecretKey.Text = "SecretKey";
            // 
            // textBox_SellerID
            // 
            this.textBox_SellerID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SellerID.Location = new System.Drawing.Point(124, 70);
            this.textBox_SellerID.Name = "textBox_SellerID";
            this.textBox_SellerID.Size = new System.Drawing.Size(159, 20);
            this.textBox_SellerID.TabIndex = 2;
            // 
            // textBox_MarketplaceID
            // 
            this.textBox_MarketplaceID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_MarketplaceID.Location = new System.Drawing.Point(124, 102);
            this.textBox_MarketplaceID.Name = "textBox_MarketplaceID";
            this.textBox_MarketplaceID.Size = new System.Drawing.Size(159, 20);
            this.textBox_MarketplaceID.TabIndex = 3;
            // 
            // Label_AccessKey
            // 
            this.Label_AccessKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Label_AccessKey.AutoSize = true;
            this.Label_AccessKey.Location = new System.Drawing.Point(16, 9);
            this.Label_AccessKey.Name = "Label_AccessKey";
            this.Label_AccessKey.Size = new System.Drawing.Size(60, 13);
            this.Label_AccessKey.TabIndex = 4;
            this.Label_AccessKey.Text = "AccessKey";
            // 
            // textBox_SecretKey
            // 
            this.textBox_SecretKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_SecretKey.Location = new System.Drawing.Point(124, 38);
            this.textBox_SecretKey.Name = "textBox_SecretKey";
            this.textBox_SecretKey.Size = new System.Drawing.Size(159, 20);
            this.textBox_SecretKey.TabIndex = 1;
            // 
            // textBox_AccessKey
            // 
            this.textBox_AccessKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_AccessKey.Location = new System.Drawing.Point(124, 6);
            this.textBox_AccessKey.Name = "textBox_AccessKey";
            this.textBox_AccessKey.Size = new System.Drawing.Size(159, 20);
            this.textBox_AccessKey.TabIndex = 0;
            // 
            // button_OK
            // 
            this.button_OK.Location = new System.Drawing.Point(28, 138);
            this.button_OK.Name = "button_OK";
            this.button_OK.Size = new System.Drawing.Size(109, 28);
            this.button_OK.TabIndex = 1;
            this.button_OK.Text = "OK";
            this.button_OK.UseVisualStyleBackColor = true;
            this.button_OK.Click += new System.EventHandler(this.Button_OK);
            // 
            // button_cancel
            // 
            this.button_cancel.Location = new System.Drawing.Point(174, 138);
            this.button_cancel.Name = "button_cancel";
            this.button_cancel.Size = new System.Drawing.Size(109, 28);
            this.button_cancel.TabIndex = 1;
            this.button_cancel.Text = "Cancel";
            this.button_cancel.UseVisualStyleBackColor = true;
            this.button_cancel.Click += new System.EventHandler(this.Button_Cancel);
            // 
            // IDInputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 173);
            this.Controls.Add(this.button_cancel);
            this.Controls.Add(this.button_OK);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "IDInputForm";
            this.Text = "IDInputForm";
            this.Load += new System.EventHandler(this.IDInputForm_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label Label_marketplaceId;
        private System.Windows.Forms.Label Label_sellerId;
        private System.Windows.Forms.Label Label_SecretKey;
        private System.Windows.Forms.TextBox textBox_SellerID;
        private System.Windows.Forms.TextBox textBox_MarketplaceID;
        private System.Windows.Forms.Label Label_AccessKey;
        private System.Windows.Forms.TextBox textBox_SecretKey;
        private System.Windows.Forms.TextBox textBox_AccessKey;
        private System.Windows.Forms.Button button_OK;
        private System.Windows.Forms.Button button_cancel;
    }
}