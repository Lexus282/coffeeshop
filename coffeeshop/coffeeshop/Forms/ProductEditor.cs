using coffeeshop.Extensions;
using coffeeshop.Models.Enums;
using coffeeshop.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace coffeeshop.Forms
{
    public partial class ProductEditor : Form
    {
        public Int32? ProductId { get; }

        public ProductEditor(Int32? productId)
        {
            ProductId = productId;

            InitializeComponent();
        }

        private void ProductEditor_Load(object sender, System.EventArgs e)
        {
            var productTypes = Enum.GetValues(typeof(ProductType)).Cast<ProductType>()
             .Select(value => new
             {
                 Value = value.GetDisplayName(),
                 Key = (Int32)value
             })
            .ToList();

            comboBox1.DataSource = new BindingSource(productTypes, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {

                var types = db.type.ToList();

                comboBox2.DataSource = types;
                comboBox2.DisplayMember = "name";
                comboBox2.ValueMember = "id";

                if (ProductId != null)
                {
                    var product = db.product.Where(x => x.id == ProductId).FirstOrDefault();

                    comboBox1.SelectedValue = Convert.ToInt32((ProductType)product.producttype);
                    comboBox2.SelectedValue = product.type.id;

                    textBox1.Text = product.name;
                    textBox4.Text = product.from;
                    textBox5.Text = product.price.ToString();
                    textBox6.Text = product.count.ToString();
                    richTextBox1.Text = product.description;
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox4.Text) || String.IsNullOrWhiteSpace(textBox5.Text) ||
                String.IsNullOrWhiteSpace(textBox6.Text) || comboBox1.SelectedValue == null || comboBox2.SelectedValue == null)
            {
                MessageBox.Show("Неверный формат");
                return;
            }

            try
            {
                if (ProductId == null)
                {
                    using (CoffeeshopEntities db = new CoffeeshopEntities())
                    {
                        db.product.Add(new product
                        {
                            name = textBox1.Text,
                            producttype = (Int32)comboBox1.SelectedValue,
                            typeid = (Int32)comboBox2.SelectedValue,
                            from = textBox4.Text,
                            price = Convert.ToDecimal(textBox5.Text),
                            count = Convert.ToInt32(textBox6.Text),
                            description = richTextBox1.Text
                        });
                        db.SaveChanges();
                    }
                }
                else
                {
                    using (CoffeeshopEntities db = new CoffeeshopEntities())
                    {
                        var product = db.product.Where(x => x.id == ProductId).FirstOrDefault();
                        if (product == null)
                        {
                            MessageBox.Show("Продукт не найден");
                            return;
                        }

                        product.name = textBox1.Text;
                        product.producttype = (Int32)comboBox1.SelectedValue;
                        product.typeid = (Int32)comboBox2.SelectedValue;
                        product.from = textBox4.Text;
                        product.price = Convert.ToDecimal(textBox5.Text);
                        product.count = Convert.ToInt32(textBox6.Text);
                        product.description = richTextBox1.Text;

                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Неверный формат");
                return;
            }
            
            Close();
        }
    }
}
