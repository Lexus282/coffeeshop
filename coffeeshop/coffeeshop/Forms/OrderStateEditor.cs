using coffeeshop.Extensions;
using coffeeshop.Models.Enums;
using coffeeshop.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace coffeeshop.Forms
{
    public partial class OrderStateEditor : Form
    {
        public Int32? OrderID { get; set; }

        public OrderStateEditor(Int32 orderId)
        {
            OrderID = orderId;
            InitializeComponent();
        }

        private void OrderState_Load(object sender, EventArgs e)
        {
            var orderStates = Enum.GetValues(typeof(OrderState)).Cast<OrderState>()
             .Select(value => new
             {
                 Value = value.GetDisplayName(),
                 Key = (Int32)value
             })
            .ToList();

            comboBox1.DataSource = new BindingSource(orderStates, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                if (OrderID != null)
                {
                    var order = db.orders.Where(x => x.id == OrderID).FirstOrDefault();

                    comboBox1.SelectedValue = Convert.ToInt32((OrderState)order.state);
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                if (OrderID != null)
                {
                    var order = db.orders.Where(x => x.id == OrderID).FirstOrDefault();
                    Int32 state = (Int32)comboBox1.SelectedValue;
                    order.state = state;
                    db.SaveChanges();
                }
            }

            Close();
        }
    }
}
