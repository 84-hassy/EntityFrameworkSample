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
            this.EFReadButton = new System.Windows.Forms.Button();
            this.EFInsertButton = new System.Windows.Forms.Button();
            this.EFUpdateButton = new System.Windows.Forms.Button();
            this.EFDeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataTableReadButton
            // 
            this.DataTableReadButton.Location = new System.Drawing.Point(7, 31);
            this.DataTableReadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DataTableReadButton.Name = "DataTableReadButton";
            this.DataTableReadButton.Size = new System.Drawing.Size(143, 31);
            this.DataTableReadButton.TabIndex = 0;
            this.DataTableReadButton.Text = "Data Table Read";
            this.DataTableReadButton.UseVisualStyleBackColor = true;
            this.DataTableReadButton.Click += new System.EventHandler(this.DataTableReadButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(163, 75);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(442, 384);
            this.dataGridView1.TabIndex = 1;
            // 
            // ReaderReadButton
            // 
            this.ReaderReadButton.Location = new System.Drawing.Point(7, 67);
            this.ReaderReadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ReaderReadButton.Name = "ReaderReadButton";
            this.ReaderReadButton.Size = new System.Drawing.Size(143, 31);
            this.ReaderReadButton.TabIndex = 2;
            this.ReaderReadButton.Text = "Reader Read";
            this.ReaderReadButton.UseVisualStyleBackColor = true;
            this.ReaderReadButton.Click += new System.EventHandler(this.ReaderReadButton_Click);
            // 
            // ProductIdTextBox
            // 
            this.ProductIdTextBox.Location = new System.Drawing.Point(200, 55);
            this.ProductIdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductIdTextBox.Name = "ProductIdTextBox";
            this.ProductIdTextBox.Size = new System.Drawing.Size(62, 19);
            this.ProductIdTextBox.TabIndex = 3;
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(305, 55);
            this.ProductNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(62, 19);
            this.ProductNameTextBox.TabIndex = 4;
            // 
            // ProductPriceTextBox
            // 
            this.ProductPriceTextBox.Location = new System.Drawing.Point(448, 55);
            this.ProductPriceTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ProductPriceTextBox.Name = "ProductPriceTextBox";
            this.ProductPriceTextBox.Size = new System.Drawing.Size(62, 19);
            this.ProductPriceTextBox.TabIndex = 5;
            // 
            // ProductIdLabel
            // 
            this.ProductIdLabel.AutoSize = true;
            this.ProductIdLabel.Location = new System.Drawing.Point(188, 41);
            this.ProductIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductIdLabel.Name = "ProductIdLabel";
            this.ProductIdLabel.Size = new System.Drawing.Size(53, 12);
            this.ProductIdLabel.TabIndex = 6;
            this.ProductIdLabel.Text = "ProductId";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(293, 41);
            this.ProductNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(73, 12);
            this.ProductNameLabel.TabIndex = 7;
            this.ProductNameLabel.Text = "ProductName";
            // 
            // ProductPriceLabel
            // 
            this.ProductPriceLabel.AutoSize = true;
            this.ProductPriceLabel.Location = new System.Drawing.Point(422, 41);
            this.ProductPriceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProductPriceLabel.Name = "ProductPriceLabel";
            this.ProductPriceLabel.Size = new System.Drawing.Size(70, 12);
            this.ProductPriceLabel.TabIndex = 8;
            this.ProductPriceLabel.Text = "ProductPrice";
            // 
            // InsertCommandButton
            // 
            this.InsertCommandButton.Location = new System.Drawing.Point(7, 114);
            this.InsertCommandButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.InsertCommandButton.Name = "InsertCommandButton";
            this.InsertCommandButton.Size = new System.Drawing.Size(143, 22);
            this.InsertCommandButton.TabIndex = 9;
            this.InsertCommandButton.Text = "InsertCommandButton";
            this.InsertCommandButton.UseVisualStyleBackColor = true;
            this.InsertCommandButton.Click += new System.EventHandler(this.InsertCommandButton_Click);
            // 
            // UpdateCommandButton
            // 
            this.UpdateCommandButton.Location = new System.Drawing.Point(7, 140);
            this.UpdateCommandButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpdateCommandButton.Name = "UpdateCommandButton";
            this.UpdateCommandButton.Size = new System.Drawing.Size(143, 20);
            this.UpdateCommandButton.TabIndex = 10;
            this.UpdateCommandButton.Text = "UpdateCommandButton";
            this.UpdateCommandButton.UseVisualStyleBackColor = true;
            this.UpdateCommandButton.Click += new System.EventHandler(this.UpdateCommandButton_Click);
            // 
            // UpsertCommandButton
            // 
            this.UpsertCommandButton.Location = new System.Drawing.Point(7, 164);
            this.UpsertCommandButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.UpsertCommandButton.Name = "UpsertCommandButton";
            this.UpsertCommandButton.Size = new System.Drawing.Size(143, 20);
            this.UpsertCommandButton.TabIndex = 11;
            this.UpsertCommandButton.Text = "UpsertCommandButton";
            this.UpsertCommandButton.UseVisualStyleBackColor = true;
            this.UpsertCommandButton.Click += new System.EventHandler(this.UpsertCommandButton_Click);
            // 
            // DeleteCommandButton
            // 
            this.DeleteCommandButton.Location = new System.Drawing.Point(7, 188);
            this.DeleteCommandButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DeleteCommandButton.Name = "DeleteCommandButton";
            this.DeleteCommandButton.Size = new System.Drawing.Size(143, 20);
            this.DeleteCommandButton.TabIndex = 12;
            this.DeleteCommandButton.Text = "DeleteCommandButton";
            this.DeleteCommandButton.UseVisualStyleBackColor = true;
            this.DeleteCommandButton.Click += new System.EventHandler(this.DeleteCommandButton_Click);
            // 
            // DapperReadButton
            // 
            this.DapperReadButton.Location = new System.Drawing.Point(7, 243);
            this.DapperReadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DapperReadButton.Name = "DapperReadButton";
            this.DapperReadButton.Size = new System.Drawing.Size(127, 23);
            this.DapperReadButton.TabIndex = 13;
            this.DapperReadButton.Text = "DapperReadButton";
            this.DapperReadButton.UseVisualStyleBackColor = true;
            this.DapperReadButton.Click += new System.EventHandler(this.DapperReadButton_Click);
            // 
            // DapperInsertButton
            // 
            this.DapperInsertButton.Location = new System.Drawing.Point(7, 270);
            this.DapperInsertButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DapperInsertButton.Name = "DapperInsertButton";
            this.DapperInsertButton.Size = new System.Drawing.Size(127, 23);
            this.DapperInsertButton.TabIndex = 14;
            this.DapperInsertButton.Text = "DapperInsertButton";
            this.DapperInsertButton.UseVisualStyleBackColor = true;
            this.DapperInsertButton.Click += new System.EventHandler(this.DapperInsertButton_Click);
            // 
            // DapperUpdateButton
            // 
            this.DapperUpdateButton.Location = new System.Drawing.Point(7, 297);
            this.DapperUpdateButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DapperUpdateButton.Name = "DapperUpdateButton";
            this.DapperUpdateButton.Size = new System.Drawing.Size(127, 23);
            this.DapperUpdateButton.TabIndex = 15;
            this.DapperUpdateButton.Text = "DapperUpdateButton";
            this.DapperUpdateButton.UseVisualStyleBackColor = true;
            this.DapperUpdateButton.Click += new System.EventHandler(this.DapperUpdateButton_Click);
            // 
            // DapperDeleteButton
            // 
            this.DapperDeleteButton.Location = new System.Drawing.Point(7, 324);
            this.DapperDeleteButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DapperDeleteButton.Name = "DapperDeleteButton";
            this.DapperDeleteButton.Size = new System.Drawing.Size(127, 23);
            this.DapperDeleteButton.TabIndex = 16;
            this.DapperDeleteButton.Text = "DapperDeleteButton";
            this.DapperDeleteButton.UseVisualStyleBackColor = true;
            this.DapperDeleteButton.Click += new System.EventHandler(this.DapperDeleteButton_Click);
            // 
            // EFReadButton
            // 
            this.EFReadButton.Location = new System.Drawing.Point(7, 361);
            this.EFReadButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EFReadButton.Name = "EFReadButton";
            this.EFReadButton.Size = new System.Drawing.Size(127, 19);
            this.EFReadButton.TabIndex = 17;
            this.EFReadButton.Text = "EFReadButton";
            this.EFReadButton.UseVisualStyleBackColor = true;
            this.EFReadButton.Click += new System.EventHandler(this.EFReadButton_Click);
            // 
            // EFInsertButton
            // 
            this.EFInsertButton.Location = new System.Drawing.Point(7, 384);
            this.EFInsertButton.Margin = new System.Windows.Forms.Padding(2);
            this.EFInsertButton.Name = "EFInsertButton";
            this.EFInsertButton.Size = new System.Drawing.Size(127, 19);
            this.EFInsertButton.TabIndex = 18;
            this.EFInsertButton.Text = "EFInsertButton";
            this.EFInsertButton.UseVisualStyleBackColor = true;
            this.EFInsertButton.Click += new System.EventHandler(this.EFInsertButton_Click);
            // 
            // EFUpdateButton
            // 
            this.EFUpdateButton.Location = new System.Drawing.Point(7, 407);
            this.EFUpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.EFUpdateButton.Name = "EFUpdateButton";
            this.EFUpdateButton.Size = new System.Drawing.Size(127, 19);
            this.EFUpdateButton.TabIndex = 19;
            this.EFUpdateButton.Text = "EFUpdateButton";
            this.EFUpdateButton.UseVisualStyleBackColor = true;
            this.EFUpdateButton.Click += new System.EventHandler(this.EFUpdateButton_Click);
            // 
            // EFDeleteButton
            // 
            this.EFDeleteButton.Location = new System.Drawing.Point(7, 430);
            this.EFDeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.EFDeleteButton.Name = "EFDeleteButton";
            this.EFDeleteButton.Size = new System.Drawing.Size(127, 19);
            this.EFDeleteButton.TabIndex = 20;
            this.EFDeleteButton.Text = "EFDeleteButton";
            this.EFDeleteButton.UseVisualStyleBackColor = true;
            this.EFDeleteButton.Click += new System.EventHandler(this.EFDeleteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 467);
            this.Controls.Add(this.EFDeleteButton);
            this.Controls.Add(this.EFUpdateButton);
            this.Controls.Add(this.EFInsertButton);
            this.Controls.Add(this.EFReadButton);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button EFReadButton;
        private System.Windows.Forms.Button EFInsertButton;
        private System.Windows.Forms.Button EFUpdateButton;
        private System.Windows.Forms.Button EFDeleteButton;
    }
}

