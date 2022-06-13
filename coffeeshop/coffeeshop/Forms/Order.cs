using coffeeshop.Extensions;
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
    public partial class Order : Form
    {
        public String EmployeeId { get; set; }

        private orders order = new orders();

        public Order(String employeeId)
        {
            EmployeeId = employeeId;
            InitializeComponent();
            listView1.View = View.List;
            listView1.MultiSelect = false;
        }

        private void searchClient_Click(object sender, EventArgs e)
        {
            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                String clientPhone = maskedTextBox1.Text;

                if (String.IsNullOrWhiteSpace(clientPhone))
                {
                    MessageBox.Show("Поля для поиска клиента заполнены некорректно");
                    return;
                }

                var client = db.clients.Where(x => x.phonenumber == clientPhone).FirstOrDefault();
                
                if (client is null)
                {
                    MessageBox.Show("Клиент не найден");
                    return;
                }

                DialogResult result = MessageBox.Show($"Добавить клиента: \nФИО - {client.name}?\nНомер телефона - {client.phonenumber}", "Подтвержение", MessageBoxButtons.YesNoCancel);
                if (result == DialogResult.Yes)
                {
                    order.clientid = client.userid;
                    label3.Text = $"Клиент: {client.name}";
                }
                return;
            }
        }

        private void Order_Load(object sender, EventArgs e)
        {
            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                order.id = db.orders.ToList().Last().id + 1;
            }
            var paymentTypes = Enum.GetValues(typeof(PaymentType)).Cast<PaymentType>()
                .Select(value => new
                {
                    Value = value.GetDisplayName(),
                    Key = (Int32)value
                })
                .ToList();

            comboBox1.DataSource = new BindingSource(paymentTypes, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderItems orderItemsForm = new OrderItems(order.id, order.orderitems.ToList());
            orderItemsForm.ShowDialog();

            List<ListViewItem> listViewItems = new List<ListViewItem>();

            order.orderitems = orderItemsForm.orderItems;
            order.cost = order.orderitems.Select(x => x.product).ToList().Sum(x => x.price * x.count);
            listView1.Items.Clear();;


            foreach (var item in orderItemsForm.orderItems)
            {
                ListViewItem listViewItem = new ListViewItem();
                listViewItem.Text = $"Товар: {item.product.name}, кол-во: {item.count}, стоимость: {item.product.price * item.count}";
                listViewItems.Add(listViewItem);
            }

            listView1.Items.AddRange(listViewItems.ToArray());

            label5.Text = $"Общая стоимость: {order.cost}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Int32 paymentType = (Int32)comboBox1.SelectedValue;  

            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                DateTime dateTime = DateTime.UtcNow;

                if (String.IsNullOrEmpty(order.clientid))
                {
                    MessageBox.Show("Клиент не выбран");
                    return;
                }

                if (order.orderitems.Count == 0)
                {
                    MessageBox.Show("В заказе отсутствуют товары");
                    return;
                }

                orders newOrder = new orders
                {
                    clientid = order.clientid,
                    date = dateTime,
                    employeeid = EmployeeId,
                    paymenttype = paymentType,
                    state = (Int32)OrderState.Payment,
                    cost = order.cost
                };

                db.orders.Add(newOrder);
                db.SaveChanges();

                List<orderitems> orderitems = new List<orderitems>();

                foreach (var item in order.orderitems)
                {
                    var product = db.product.Where(x => x.id == item.productid).FirstOrDefault();
                    orderitems.Add(new orderitems { 
                        orderid = newOrder.id,
                        productid = product.id,
                        count = item.count,
                    });
                    product.count -= item.count;
                }

                db.orderitems.AddRange(orderitems);

                db.SaveChanges();
            }

            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClientEditor clientEditor = new ClientEditor("");
            clientEditor.ShowDialog();

            if (clientEditor.addedClient != null)
            {
                label3.Text = $"Клиент: {clientEditor.addedClient.name}";
                order.clientid = clientEditor.addedClient.userid;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
