namespace EntityFrameworkDBConnectionSample
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.DataTableReadButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ReaderReadButton = new System.Windows.Forms.Button();
            this.ProductIdTextBox = new System.Windows.Forms.TextBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductPriceTextBox = new System.Windows.Forms.TextBox();
            this.ProductIdLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductPriceLabel = new System.Windows.Forms.Label();
            this.InsertCommandButton = new System.Windows.Forms.Button();
            this.UpdateCommandButton = new System.Windows.Forms.Button();
            this.UpsertCommandButton = new System.Windows.Forms.Button();
            this.DeleteCommandButton = new System.Windows.Forms.Button();
            this.DapperReadButton = new System.Windows.Forms.Button();
            this.DapperInsertButton = new System.Windows.Forms.Button();
            this.DapperUpdateButton = new System.Windows.Forms.Button();
            this.DapperDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableReadButton
            // 
            this.DataTableReadButton.Location = new System.Drawing.Point(12, 116);
            this.DataTableReadButton.Name = "DataTableReadButton";
            this.DataTableReadButton.Size = new System.Drawing.Size(239, 47);
            this.DataTableReadButton.TabIndex = 0;
            this.DataTableReadButton.Text = "Data Table Read";
            this.DataTableReadButton.UseVisualStyleBackColor = true;
            this.DataTableReadButton.Click += new System.EventHandler(this.DataTableReadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(272, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(736, 576);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReaderReadButton
            // 
            this.ReaderReadButton.Location = new System.Drawing.Point(12, 178);
            this.ReaderReadButton.Name = "ReaderReadButton";
            this.ReaderReadButton.Size = new System.Drawing.Size(239, 47);
            this.ReaderReadButton.TabIndex = 2;
            this.ReaderReadButton.Text = "Reader Read";
            this.ReaderReadButton.UseVisualStyleBackColor = true;
            this.ReaderReadButton.Click += new System.EventHandler(this.ReaderReadButton_Click);
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Location = new System.Drawing.Point(333, 82);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(100, 25);
            this.ProductIdTextBox.TabIndex = 3;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(508, 82);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(100, 25);
            this.ProductNameTextBox.TabIndex = 4;
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(747, 82);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(100, 25);
            this.ProductPriceTextBox.TabIndex = 5;
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(313, 61);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(80, 18);
            this.ProductIdLabel.TabIndex = 6;
            this.ProductIdLabel.Text = "ProductId";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(488, 61);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(110, 18);
            this.ProductNameLabel.TabIndex = 7;
            this.ProductNameLabel.Text = "ProductName";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(704, 61);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(106, 18);
            this.ProductPriceLabel.TabIndex = 8;
            this.ProductPriceLabel.Text = "ProductPrice";
            // 
            // InsertCommandButton
            // 
            this.InsertCommandButton.Location = new System.Drawing.Point(29, 244);
            this.InsertCommandButton.Name = "InsertCommandButton";
            this.InsertCommandButton.Size = new System.Drawing.Size(212, 42);
            this.InsertCommandButton.TabIndex = 9;
            this.InsertCommandButton.Text = "InsertCommandButton";
            this.InsertCommandButton.UseVisualStyleBackColor = true;
            this.InsertCommandButton.Click += new System.EventHandler(this.InsertCommandButton_Click);
            // 
            // UpdateCommandButton
            // 
            this.UpdateCommandButton.Location = new System.Drawing.Point(29, 302);
            this.UpdateCommandButton.Name = "UpdateCommandButton";
            this.UpdateCommandButton.Size = new System.Drawing.Size(212, 39);
            this.UpdateCommandButton.TabIndex = 10;
            this.UpdateCommandButton.Text = "UpdateCommandButton";
            this.UpdateCommandButton.UseVisualStyleBackColor = true;
            this.UpdateCommandButton.Click += new System.EventHandler(this.UpdateCommandButton_Click);
            // 
            // UpsertCommandButton
            // 
            this.UpsertCommandButton.Location = new System.Drawing.Point(29, 347);
            this.UpsertCommandButton.Name = "UpsertCommandButton";
            this.UpsertCommandButton.Size = new System.Drawing.Size(212, 39);
            this.UpsertCommandButton.TabIndex = 11;
            this.UpsertCommandButton.Text = "UpsertCommandButton";
            this.UpsertCommandButton.UseVisualStyleBackColor = true;
            this.UpsertCommandButton.Click += new System.EventHandler(this.UpsertCommandButton_Click);
            // 
            // DeleteCommandButton
            // 
            this.DeleteCommandButton.Location = new System.Drawing.Point(29, 392);
            this.DeleteCommandButton.Name = "DeleteCommandButton";
            this.DeleteCommandButton.Size = new System.Drawing.Size(212, 39);
            this.DeleteCommandButton.TabIndex = 12;
            this.DeleteCommandButton.Text = "DeleteCommandButton";
            this.DeleteCommandButton.UseVisualStyleBackColor = true;
            this.DeleteCommandButton.Click += new System.EventHandler(this.DeleteCommandButton_Click);
            // 
            // DapperReadButton
            // 
            this.DapperReadButton.Location = new System.Drawing.Point(29, 515);
            this.DapperReadButton.Name = "DapperReadButton";
            this.DapperReadButton.Size = new System.Drawing.Size(212, 39);
            this.DapperReadButton.TabIndex = 13;
            this.DapperReadButton.Text = "DapperReadButton";
            this.DapperReadButton.UseVisualStyleBackColor = true;
            this.DapperReadButton.Click += new System.EventHandler(this.DapperReadButton_Click);
            // 
            // DapperInsertButton
            // 
            this.DapperInsertButton.Location = new System.Drawing.Point(29, 560);
            this.DapperInsertButton.Name = "DapperInsertButton";
            this.DapperInsertButton.Size = new System.Drawing.Size(212, 39);
            this.DapperInsertButton.TabIndex = 14;
            this.DapperInsertButton.Text = "DapperInsertButton";
            this.DapperInsertButton.UseVisualStyleBackColor = true;
            this.DapperInsertButton.Click += new System.EventHandler(this.DapperInsertButton_Click);
            // 
            // DapperUpdateButton
            // 
            this.DapperUpdateButton.Location = new System.Drawing.Point(29, 605);
            this.DapperUpdateButton.Name = "DapperUpdateButton";
            this.DapperUpdateButton.Size = new System.Drawing.Size(212, 39);
            this.DapperUpdateButton.TabIndex = 15;
            this.DapperUpdateButton.Text = "DapperUpdateButton";
            this.DapperUpdateButton.UseVisualStyleBackColor = true;
            this.DapperUpdateButton.Click += new System.EventHandler(this.DapperUpdateButton_Click);
            // 
            // DapperDeleteButton
            // 
            this.DapperDeleteButton.Location = new System.Drawing.Point(29, 650);
            this.DapperDeleteButton.Name = "DapperDeleteButton";
            this.DapperDeleteButton.Size = new System.Drawing.Size(212, 39);
            this.DapperDeleteButton.TabIndex = 16;
            this.DapperDeleteButton.Text = "DapperDeleteButton";
            this.DapperDeleteButton.UseVisualStyleBackColor = true;
            this.DapperDeleteButton.Click += new System.EventHandler(this.DapperDeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 701);
            this.Controls.Add(this.DapperDeleteButton);
            this.Controls.Add(this.DapperUpdateButton);
            this.Controls.Add(this.DapperInsertButton);
            this.Controls.Add(this.DapperReadButton);
            this.Controls.Add(this.DeleteCommandButton);
            this.Controls.Add(this.UpsertCommandButton);
            this.Controls.Add(this.UpdateCommandButton);
            this.Controls.Add(this.InsertCommandButton);
            this.Controls.Add(this.ProductPriceLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductIdLabel);
            this.Controls.Add(this.ProductPriceTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductIdTextBox);
            this.Controls.Add(this.ReaderReadButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DataTableReadButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DataTableReadButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button ReaderReadButton;
        private System.Windows.Forms.TextBox ProductIdTextBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox ProductPriceTextBox;
        private System.Windows.Forms.Label ProductIdLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductPriceLabel;
        private System.Windows.Forms.Button InsertCommandButton;
        private System.Windows.Forms.Button UpdateCommandButton;
        private System.Windows.Forms.Button UpsertCommandButton;
        private System.Windows.Forms.Button DeleteCommandButton;
        private System.Windows.Forms.Button DapperReadButton;
        private System.Windows.Forms.Button DapperInsertButton;
        private System.Windows.Forms.Button DapperUpdateButton;
        private System.Windows.Forms.Button DapperDeleteButton;
    }
}

