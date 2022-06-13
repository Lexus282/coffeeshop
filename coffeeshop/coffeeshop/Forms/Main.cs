using coffeeshop.Extensions;
using coffeeshop.Models;
using coffeeshop.Models.Enums;
using coffeeshop.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace coffeeshop.Forms
{
    public partial class Main : Form
    {

        public String EmployeeId { get; set; }

        public Main(String employeeId)
        {
            EmployeeId = employeeId;
            InitializeComponent();
        }

        private void loadData(String searchText = "")
        {
            groupBox1.Visible = false;

            String currentTab = mainTabs.SelectedTab.Text;
            using (CoffeeshopEntities db1 = new CoffeeshopEntities())
            {
                switch (currentTab)
                {
                    case "Ассортимент":

                        groupBox1.Visible = true;

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

                        var types = db1.type.ToList();

                        comboBox2.DataSource = types;
                        comboBox2.DisplayMember = "name";
                        comboBox2.ValueMember = "id";

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

                        break;
                    case "Заказы":
                        var orders = (from order in db1.orders
                                      join employee in db1.employees on order.employeeid equals employee.userid
                                      join client in db1.clients on order.clientid equals client.userid
                                      select order).ToList();

                        if (!String.IsNullOrWhiteSpace(searchText))
                            orders = orders.Where(x => x.clients.name.Contains(searchText)).ToList();

                        var ordersList = orders.Select(order => new OrderViewModel
                        {
                            Id = order.id,
                            Date = order.date.ToShortDateString(),
                            ClientName = order.clients.name,
                            EmployeeName = order.employees.name,
                            Cost = order.cost,
                            PaymentType = ((PaymentType)order.paymenttype).GetDisplayName(),
                            State = ((OrderState)order.state).GetDisplayName(),
                        }).ToList();

                        dataGrid2.Bind(ordersList);
                        dataGrid2.DataSource = ordersList;
                        DataGridViewButtonColumn detailsButtonColumn = new DataGridViewButtonColumn();

                        detailsButtonColumn.UseColumnTextForButtonValue = true;
                        detailsButtonColumn.Name = "orderDetails";
                        detailsButtonColumn.Text = "Подробнее";
                        detailsButtonColumn.HeaderText = "Детали заказа";
                        int columnIndex = 7;


                        if (dataGrid2.Columns["orderDetails"] == null)
                        {
                            dataGrid2.Columns.Insert(columnIndex, detailsButtonColumn);
                        }
                        dataGrid2.CellClick += dataGrid2_CellClick;

                        break;
                    case "Клиенты":
                        var clients = db1.clients.ToList();

                        if (!String.IsNullOrWhiteSpace(searchText))
                            clients = clients.Where(x => x.name.Contains(searchText)).ToList();

                        var clientsList = clients.Select(client => new ClientViewModel
                        {
                            Id = client.userid,
                            Name = client.name,
                            Email = client.email,
                            PhoneNumber = client.phonenumber

                        }).ToList();

                        dataGrid3.Bind(clientsList);
                        dataGrid3.DataSource = clientsList;

                        break;
                    case "Сотрудники":
                        var employees = db1.employees.ToList();

                        if (!String.IsNullOrWhiteSpace(searchText))
                            employees = employees.Where(x => x.name.Contains(searchText)).ToList();

                        var employeesList = employees.Select(employee => new EmployeeViewModel
                        {
                            Id = employee.userid,
                            Name = employee.name,
                            Email = employee.email,
                            PhoneNumber = employee.phonenumber,
                            Role = ((AccessRole)employee.role).GetDisplayName()
                        }).ToList();

                        dataGrid4.Bind(employeesList);
                        dataGrid4.DataSource = employeesList;

                        break;
                    case "Типы продуктов":
                        var typeList = db1.type.ToList();

                        if (!String.IsNullOrWhiteSpace(searchText))
                            typeList = typeList.Where(x => x.name.Contains(searchText)).ToList();

                        var typeList1 = typeList.Select(type => new TypeViewModel
                        {
                            Id = type.id,
                            Name = type.name,
                        }).ToList();

                        dataGrid5.Bind(typeList1);
                        dataGrid5.DataSource = typeList1;

                        break;
                }
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (CoffeeshopEntities db1 = new CoffeeshopEntities())
            {
                employees emp = db1.employees.Where(x => x.userid == EmployeeId).FirstOrDefault();

                if ((AccessRole)emp.role != AccessRole.Admin)
                    mainTabs.TabPages.RemoveByKey("tabPage4");

            }
            loadData();
        }

        private void mainTabs_Selecting(object sender, TabControlCancelEventArgs e)
        {
            String currentTab = mainTabs.SelectedTab.Text;
            edit.Text = "Изменить";
            edit.Width = 116;
            remove.Visible = true;

            switch (currentTab)
            {
                case "Ассортимент":
                    label1.Text = "Поиск по названию";
                    break;
                case "Заказы":
                    label1.Text = "Поиск по клиенту";
                    edit.Text = "Изменить статус";
                    edit.Width = 200;
                    remove.Visible = false;
                    break;
                case "Клиенты":
                    label1.Text = "Поиск по ФИО";
                    break;
                case "Сотрудники":
                    label1.Text = "Поиск по ФИО";
                    break;
                case "Типы продуктов":
                    label1.Text = "Поиск по названию";
                    break;
            }

            loadData();
        }

        private void dataGrid2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGrid2.Columns["orderDetails"].Index)
            {
                OrderViewModel model = this.dataGrid2.Rows[e.RowIndex].DataBoundItem as OrderViewModel;
                using (CoffeeshopEntities db1 = new CoffeeshopEntities())
                {
                    var details = (from order in db1.orders
                                   join orderitem in db1.orderitems on order.id equals orderitem.orderid where order.id == model.Id
                                   select order).FirstOrDefault();

                    if (details is null || details.orderitems.Count == 0)
                    {
                        MessageBox.Show("В заказе отсутствуют товары");
                        return;
                    }

                    String orderDetails = $"Заказ №{details.id}\n" +
                        $"\nДата заказа: {details.date}\n" +
                        $"Клиент: {details.clients.name}\n" +
                        $"Сотрудник: {details.employees.name}\n" +
                        $"Способ оплаты: {((PaymentType)details.paymenttype).GetDisplayName()}\n" +
                        $"Стоимость: {details.cost} руб.\n" +
                        $"Статус заказа: {((OrderState)details.state).GetDisplayName()}\n" +
                        $"\nТовары:\n";

                    foreach (var item in details.orderitems)
                    {
                        orderDetails += $"- {item.product.name} (кол-во: {item.count})";
                    }

                    MessageBox.Show(orderDetails);
                }
            }
        }

        private void find_Click(object sender, EventArgs e)
        {
            String text = searchText.Text;
            loadData(text);
        }

        private void add_Click(object sender, EventArgs e)
        {
            String currentTab = mainTabs.SelectedTab.Text;

            switch (currentTab)
            {
                case "Ассортимент":
                    ProductEditor productEditor = new ProductEditor(null);
                    productEditor.ShowDialog();

                    break;
                case "Заказы":
                    Order orderForm = new Order(EmployeeId);
                    orderForm.ShowDialog();

                    break;
                case "Клиенты":
                    ClientEditor clientEditor = new ClientEditor("");
                    clientEditor.ShowDialog();

                    break;
                case "Сотрудники":
                    EmployeeEditor employeeEditor = new EmployeeEditor("");
                    employeeEditor.ShowDialog();
                    break;
                case "Типы продуктов":
                    TypeEditor typeEditor = new TypeEditor(null);
                    typeEditor.ShowDialog();
                    break;
            }

            loadData();
        }

        private void edit_Click(object sender, EventArgs e)
        {
            String currentTab = mainTabs.SelectedTab.Text;

            switch (currentTab)
            {
                case "Ассортимент":
                    Int32 selectedProductIndex = dataGrid1.CurrentCell.RowIndex;

                    ProductViewModel productModel = dataGrid1.Rows[selectedProductIndex].DataBoundItem as ProductViewModel;

                    ProductEditor productEditor = new ProductEditor(productModel.Id);
                    productEditor.ShowDialog();

                    break;
                case "Заказы":
                    Int32 selectedOrderIndex = dataGrid2.CurrentCell.RowIndex;

                    OrderViewModel orderModel = dataGrid2.Rows[selectedOrderIndex].DataBoundItem as OrderViewModel;

                    OrderStateEditor orderStateEditor = new OrderStateEditor(orderModel.Id);
                    orderStateEditor.ShowDialog();

                    break;
                case "Клиенты":
                    Int32 selectedClientIndex = dataGrid3.CurrentCell.RowIndex;

                    ClientViewModel clientModel = dataGrid3.Rows[selectedClientIndex].DataBoundItem as ClientViewModel;

                    ClientEditor clientEditor = new ClientEditor(clientModel.Id);
                    clientEditor.ShowDialog();
                    
                    break;
                case "Сотрудники":
                    Int32 selectedEmpIndex = dataGrid4.CurrentCell.RowIndex;

                    EmployeeViewModel empModel = dataGrid4.Rows[selectedEmpIndex].DataBoundItem as EmployeeViewModel;

                    EmployeeEditor employeeEditor = new EmployeeEditor(empModel.Id);
                    employeeEditor.ShowDialog();
                    break;
                case "Типы продуктов":
                    Int32 selectedTypeIndex = dataGrid5.CurrentCell.RowIndex;

                    TypeViewModel typeModel = dataGrid5.Rows[selectedTypeIndex].DataBoundItem as TypeViewModel;

                    TypeEditor typeEditor = new TypeEditor(typeModel.Id);
                    typeEditor.ShowDialog();
                    break;
            }

            loadData();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            String currentTab = mainTabs.SelectedTab.Text;

            switch (currentTab)
            {
                case "Ассортимент":
                    Int32 selectedProductIndex = dataGrid1.CurrentCell.RowIndex;

                    ProductViewModel model = dataGrid1.Rows[selectedProductIndex].DataBoundItem as ProductViewModel;

                    using (CoffeeshopEntities db1 = new CoffeeshopEntities())
                    {
                        var product = db1.product.Where(x => x.id == model.Id).FirstOrDefault();

                        if (product.orderitems.Count > 0)
                        {
                            MessageBox.Show("Выбранный продукт внесен в заказы. Удаление невозможно");
                            return;
                        }

                        DialogResult result = MessageBox.Show($"Удалить продукт {product.name}?", "Удаление", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            db1.product.Remove(product);
                            db1.SaveChanges();
                        }
                    }

                    break;
                case "Клиенты":
                    Int32 selectedClientIndex = dataGrid3.CurrentCell.RowIndex;

                    ClientViewModel clientModel = dataGrid3.Rows[selectedClientIndex].DataBoundItem as ClientViewModel;

                    using (CoffeeshopEntities db1 = new CoffeeshopEntities())
                    {
                        var cilent = db1.clients.Where(x => x.userid == clientModel.Id).FirstOrDefault();

                        if (cilent.orders.Count > 0)
                        {
                            MessageBox.Show("Выбранный клиент внесен в заказы. Удаление невозможно");
                            return;
                        }

                        DialogResult result = MessageBox.Show($"Удалить пользователя {clientModel.Name}?", "Удаление", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            db1.clients.Remove(cilent);
                            db1.SaveChanges();
                        }
                    }

                    break;
                case "Сотрудники":

                    Int32 selectedEmpIndex = dataGrid4.CurrentCell.RowIndex;

                    EmployeeViewModel empModel = dataGrid4.Rows[selectedEmpIndex].DataBoundItem as EmployeeViewModel;

                    using (CoffeeshopEntities db1 = new CoffeeshopEntities())
                    {
                        var emp = db1.employees.Where(x => x.userid == empModel.Id).FirstOrDefault();

                        if (emp.orders.Count > 0)
                        {
                            MessageBox.Show("Выбранный сотрудник внесен в заказы. Удаление невозможно");
                            return;
                        }

                        DialogResult result = MessageBox.Show($"Удалить сотрудника {empModel.Name}?", "Удаление", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            db1.employees.Remove(emp);
                            db1.SaveChanges();
                        }
                    }
                    break;
                case "Типы продуктов":

                    Int32 selectedTypeIndex = dataGrid5.CurrentCell.RowIndex;

                    TypeViewModel typeModel = dataGrid5.Rows[selectedTypeIndex].DataBoundItem as TypeViewModel;

                    using (CoffeeshopEntities db1 = new CoffeeshopEntities())
                    {
                        var type = db1.type.Where(x => x.id == typeModel.Id).FirstOrDefault();

                        if (type.product.Count > 0)
                        {
                            MessageBox.Show("Выбранный тип используется. Удаление невозможно");
                            return;
                        }

                        DialogResult result = MessageBox.Show($"Удалить тип {typeModel.Name}?", "Удаление", MessageBoxButtons.YesNoCancel);
                        if (result == DialogResult.Yes)
                        {
                            db1.type.Remove(type);
                            db1.SaveChanges();
                        }
                    }
                    break;
            }

            loadData();
        }

        private void filter_Click(object sender, EventArgs e)
        {

            Int32 productType = (Int32)comboBox1.SelectedValue;
            Int32 type = (Int32)comboBox2.SelectedValue;

            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                var products = db.product.Where(x => x.type.id == type && x.producttype == productType).ToList();

                if (!String.IsNullOrWhiteSpace(textBox1.Text))
                {
                    Decimal price = String.IsNullOrWhiteSpace(textBox1.Text) ? 0 : Convert.ToDecimal(textBox1.Text);
                    products = products.Where(x => x.price == price).ToList();
                }

                if (numericUpDown1.Value != 0)
                {
                    Int32 count = Convert.ToInt32(numericUpDown1.Value);
                    products = products.Where(x => x.count == count).ToList();
                }

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
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.' || e.KeyChar != (char)8))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void numericUpDown1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }
    }
}
