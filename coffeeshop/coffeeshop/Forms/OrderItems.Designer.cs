namespace coffeeshop.Forms
{
    partial class OrderItems
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
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.find = new System.Windows.Forms.Button();
            this.addProduct = new System.Windows.Forms.Button();
            this.removeProduct = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersWidth = 51;
            this.dataGrid1.RowTemplate.Height = 24;
            this.dataGrid1.Size = new System.Drawing.Size(1003, 411);
            this.dataGrid1.TabIndex = 7;
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText.Location = new System.Drawing.Point(9, 442);
            this.searchText.Margin = new System.Windows.Forms.Padding(0);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(245, 32);
            this.searchText.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 423);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Поиск по названию";
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find.Location = new System.Drawing.Point(265, 442);
            this.find.Margin = new System.Windows.Forms.Padding(0);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(152, 32);
            this.find.TabIndex = 8;
            this.find.Text = "Найти";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // addProduct
            // 
            this.addProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addProduct.Location = new System.Drawing.Point(609, 442);
            this.addProduct.Margin = new System.Windows.Forms.Padding(0);
            this.addProduct.Name = "addProduct";
            this.addProduct.Size = new System.Drawing.Size(227, 32);
            this.addProduct.TabIndex = 13;
            this.addProduct.Text = "Добавить товар";
            this.addProduct.UseVisualStyleBackColor = true;
            this.addProduct.Click += new System.EventHandler(this.addProduct_Click);
            // 
            // removeProduct
            // 
            this.removeProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeProduct.Location = new System.Drawing.Point(842, 442);
            this.removeProduct.Margin = new System.Windows.Forms.Padding(0);
            this.removeProduct.Name = "removeProduct";
            this.removeProduct.Size = new System.Drawing.Size(152, 32);
            this.removeProduct.TabIndex = 14;
            this.removeProduct.Text = "Убрать товар";
            this.removeProduct.UseVisualStyleBackColor = true;
            this.removeProduct.Click += new System.EventHandler(this.removeProduct_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(474, 442);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 32);
            this.numericUpDown1.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(471, 422);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Кол-во";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(9, 503);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(152, 32);
            this.button1.TabIndex = 17;
            this.button1.Text = "<< Назад";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // OrderItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 544);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.removeProduct);
            this.Controls.Add(this.addProduct);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.find);
            this.Controls.Add(this.dataGrid1);
            this.Name = "OrderItems";
            this.Text = "OrderItems";
            this.Load += new System.EventHandler(this.OrderItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.Button addProduct;
        private System.Windows.Forms.Button removeProduct;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}