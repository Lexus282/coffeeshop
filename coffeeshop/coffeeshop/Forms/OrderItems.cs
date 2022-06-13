using coffeeshop.Extensions;
using coffeeshop.Models;
using coffeeshop.Models.Enums;
using coffeeshop.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffeeshop.Forms
{
    public partial class OrderItems : Form
    {
        public Int32 OrderID { get; set; }
        public List<orderitems> orderItems;

        public OrderItems(Int32 orderId, List<orderitems> orderitems)
        {
            OrderID = orderId;
            orderItems = orderitems;
            InitializeComponent();
        }

        private void OrderItems_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData(String searchText = "")
        {
            using (CoffeeshopEntities db1 = new CoffeeshopEntities())
            {
                var products = (from product in db1.product
                                join type in db1.type on product.typeid equals type.id
                                select product).ToList();

                if (!String.IsNullOrWhiteSpace(searchText))
                    products = products.Where(x => x.name.Contains(searchText)).ToList();

                var productsList = products.Select(product => new ProductViewModel
                {
                    Id = product.id,
                    Name = product.name,
                    ProductType = ((ProductType)product.producttype).GetDisplayName(),
                    Type = product.type.name,
                    Origin = product.from,
                    Description = product.description,
                    Price = product.price,
                    Count = product.count
                }).ToList();

                dataGrid1.Bind(productsList);
                dataGrid1.DataSource = productsList;
            }

            foreach (DataGridViewRow row in dataGrid1.Rows)
            {           
                if (orderItems.Find(x => x.product.id == (row.DataBoundItem as ProductViewModel).Id) != null)
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Ivory;
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            String text = searchText.Text;
            loadData(text);
        }

        private void addProduct_Click(object sender, EventArgs e)
        {
            Int32 selectedRowIndex = dataGrid1.CurrentCell.RowIndex;

            ProductViewModel model = dataGrid1.Rows[selectedRowIndex].DataBoundItem as ProductViewModel;

            Int32 productCount = (Int32)numericUpDown1.Value;

            if (productCount == 0)
            {
                MessageBox.Show("Не указано кол-во товара");
                return;
            }

            if (model != null && productCount > 0)
            {
                orderitems existingItem = null;

                if (orderItems.Count > 0)
                {
                    existingItem = orderItems.Find(x => x.productid == model.Id);
                }

                if (existingItem != null)
                {
                    MessageBox.Show($"Товар {model.Name} уже добален");
                    return;
                }

                if (productCount > model.Count)
                {
                    MessageBox.Show("Указанное кол-во товара больше того, что имеется в наличии");
                    return;
                }

                ProductType productType = EnumExtensions.GetValueFromName<ProductType>(model.ProductType);

                orderItems.Add(new orderitems
                {
                    count = productCount,
                    productid = model.Id,
                    orderid = OrderID,
                    product = new product {
                        count = productCount,
                        id = model.Id,
                        from = model.Origin,
                        name = model.Name,
                        price = model.Price,
                        description = model.Description,
                        producttype = (Int32)productType
                    }
                });

                numericUpDown1.Value = 0;

                dataGrid1.Rows[selectedRowIndex].DefaultCellStyle.BackColor = Color.Green;
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void removeProduct_Click(object sender, EventArgs e)
        {
            Int32 selectedRowIndex = dataGrid1.CurrentCell.RowIndex;

            ProductViewModel model = dataGrid1.Rows[selectedRowIndex].DataBoundItem as ProductViewModel;

            if (model == null)
            {
                MessageBox.Show("Товар не выбран");
                return;
            }

            var removeProduct = orderItems.Find(x => x.productid == model.Id);
            orderItems.Remove(removeProduct);
            dataGrid1.Rows[selectedRowIndex].DefaultCellStyle.BackColor = Color.Ivory;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
