namespace coffeeshop.Forms
{
    partial class Main
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
            this.mainTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGrid1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGrid2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGrid3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGrid4 = new System.Windows.Forms.DataGridView();
            this.add = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.remove = new System.Windows.Forms.Button();
            this.find = new System.Windows.Forms.Button();
            this.searchText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.filter = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGrid5 = new System.Windows.Forms.DataGridView();
            this.mainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).BeginInit();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.tabPage1);
            this.mainTabs.Controls.Add(this.tabPage2);
            this.mainTabs.Controls.Add(this.tabPage3);
            this.mainTabs.Controls.Add(this.tabPage4);
            this.mainTabs.Controls.Add(this.tabPage5);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.mainTabs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.mainTabs.Location = new System.Drawing.Point(0, 0);
            this.mainTabs.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mainTabs.SelectedIndex = 0;
            this.mainTabs.Size = new System.Drawing.Size(1182, 504);
            this.mainTabs.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.mainTabs.TabIndex = 0;
            this.mainTabs.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.mainTabs_Selecting);
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.dataGrid1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1174, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ассортимент";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGrid1
            // 
            this.dataGrid1.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid1.Location = new System.Drawing.Point(0, 0);
            this.dataGrid1.Name = "dataGrid1";
            this.dataGrid1.RowHeadersWidth = 51;
            this.dataGrid1.RowTemplate.Height = 24;
            this.dataGrid1.Size = new System.Drawing.Size(1172, 473);
            this.dataGrid1.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGrid2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1174, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Заказы";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGrid2
            // 
            this.dataGrid2.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid2.Location = new System.Drawing.Point(0, 0);
            this.dataGrid2.Name = "dataGrid2";
            this.dataGrid2.RowHeadersWidth = 51;
            this.dataGrid2.RowTemplate.Height = 24;
            this.dataGrid2.Size = new System.Drawing.Size(1174, 475);
            this.dataGrid2.TabIndex = 7;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGrid3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1174, 475);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Клиенты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGrid3
            // 
            this.dataGrid3.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid3.Location = new System.Drawing.Point(0, 0);
            this.dataGrid3.Name = "dataGrid3";
            this.dataGrid3.RowHeadersWidth = 51;
            this.dataGrid3.RowTemplate.Height = 24;
            this.dataGrid3.Size = new System.Drawing.Size(1174, 475);
            this.dataGrid3.TabIndex = 7;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGrid4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1174, 475);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Сотрудники";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGrid4
            // 
            this.dataGrid4.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGrid4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid4.Location = new System.Drawing.Point(0, 0);
            this.dataGrid4.Name = "dataGrid4";
            this.dataGrid4.RowHeadersWidth = 51;
            this.dataGrid4.RowTemplate.Height = 24;
            this.dataGrid4.Size = new System.Drawing.Size(1174, 475);
            this.dataGrid4.TabIndex = 7;
            // 
            // add
            // 
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add.Location = new System.Drawing.Point(9, 529);
            this.add.Margin = new System.Windows.Forms.Padding(0);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(152, 32);
            this.add.TabIndex = 1;
            this.add.Text = "Добавить";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // edit
            // 
            this.edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit.Location = new System.Drawing.Point(203, 529);
            this.edit.Margin = new System.Windows.Forms.Padding(0);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(152, 32);
            this.edit.TabIndex = 2;
            this.edit.Text = "Изменить";
            this.edit.UseVisualStyleBackColor = true;
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // remove
            // 
            this.remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remove.Location = new System.Drawing.Point(390, 529);
            this.remove.Margin = new System.Windows.Forms.Padding(0);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(152, 32);
            this.remove.TabIndex = 3;
            this.remove.Text = "Удалить";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // find
            // 
            this.find.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.find.Location = new System.Drawing.Point(1017, 529);
            this.find.Margin = new System.Windows.Forms.Padding(0);
            this.find.Name = "find";
            this.find.Size = new System.Drawing.Size(152, 32);
            this.find.TabIndex = 4;
            this.find.Text = "Найти";
            this.find.UseVisualStyleBackColor = true;
            this.find.Click += new System.EventHandler(this.find_Click);
            // 
            // searchText
            // 
            this.searchText.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchText.Location = new System.Drawing.Point(761, 529);
            this.searchText.Margin = new System.Windows.Forms.Padding(0);
            this.searchText.Name = "searchText";
            this.searchText.Size = new System.Drawing.Size(245, 32);
            this.searchText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(758, 510);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Поиск по названию";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.filter);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 582);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1157, 159);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Фильтры ассортимента";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.numericUpDown1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.numericUpDown1.Location = new System.Drawing.Point(285, 114);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(245, 32);
            this.numericUpDown1.TabIndex = 8;
            this.numericUpDown1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericUpDown1_KeyPress);
            // 
            // filter
            // 
            this.filter.Location = new System.Drawing.Point(560, 114);
            this.filter.Margin = new System.Windows.Forms.Padding(0);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(245, 32);
            this.filter.TabIndex = 14;
            this.filter.Text = "Показать";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(281, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(281, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Стоимость";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(285, 53);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 32);
            this.textBox1.TabIndex = 8;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(15, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Вид продукта";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(19, 113);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(250, 34);
            this.comboBox2.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(19, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Тип продукта";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(19, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(250, 34);
            this.comboBox1.TabIndex = 8;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGrid5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1174, 475);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Типы продуктов";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGrid5
            // 
            this.dataGrid5.BackgroundColor = System.Drawing.Color.Gray;
            this.dataGrid5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid5.Location = new System.Drawing.Point(0, 0);
            this.dataGrid5.Name = "dataGrid5";
            this.dataGrid5.RowHeadersWidth = 51;
            this.dataGrid5.RowTemplate.Height = 24;
            this.dataGrid5.Size = new System.Drawing.Size(1174, 475);
            this.dataGrid5.TabIndex = 7;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchText);
            this.Controls.Add(this.find);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.add);
            this.Controls.Add(this.mainTabs);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(1200, 800);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.mainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid4)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl mainTabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button find;
        private System.Windows.Forms.TextBox searchText;
        private System.Windows.Forms.DataGridView dataGrid1;
        private System.Windows.Forms.DataGridView dataGrid2;
        private System.Windows.Forms.DataGridView dataGrid3;
        private System.Windows.Forms.DataGridView dataGrid4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.DataGridView dataGrid5;
    }
}