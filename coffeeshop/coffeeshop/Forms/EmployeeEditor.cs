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
    public partial class EmployeeEditor : Form
    {
        public String UserId { get; }

        public EmployeeEditor(String userId)
        {
            UserId = userId;
            InitializeComponent();
        }

        private void EmployeeEditor_Load(object sender, EventArgs e)
        {
            var roles = Enum.GetValues(typeof(AccessRole)).Cast<AccessRole>()
             .Select(value => new
             {
                 Value = value.GetDisplayName(),
                 Key = (Int32)value
             })
            .ToList();

            comboBox1.DataSource = new BindingSource(roles, null);
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";

            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                if (!String.IsNullOrEmpty(UserId))
                {
                    var emp = db.employees.Where(x => x.userid == UserId).FirstOrDefault();

                    comboBox1.SelectedValue = Convert.ToInt32((AccessRole)emp.role);

                    textBox1.Text = emp.name;
                    textBox2.Text = emp.email;
                    maskedTextBox1.Text = emp.phonenumber;
                    textBox3.Text = emp.password;
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) 
                || String.IsNullOrWhiteSpace(textBox3.Text) || String.IsNullOrWhiteSpace(maskedTextBox1.Text))
            {
                MessageBox.Show("Неверный формат");
                return;
            }

            try
            {
                if (String.IsNullOrEmpty(UserId))
                {
                    using (CoffeeshopEntities db = new CoffeeshopEntities())
                    {
                        db.employees.Add(new employees
                        {
                            userid = Guid.NewGuid().ToString(),
                            name = textBox1.Text,
                            email = textBox2.Text,
                            phonenumber = maskedTextBox1.Text,
                            password = textBox3.Text,
                            role = (Int32)comboBox1.SelectedValue
                        });
                        db.SaveChanges();
                    }
                }
                else
                {
                    using (CoffeeshopEntities db = new CoffeeshopEntities())
                    {
                        var emp = db.employees.Where(x => x.userid == UserId).FirstOrDefault();
                        if (emp == null)
                        {
                            MessageBox.Show("Сотрудник не найден");
                            return;
                        }

                        emp.name = textBox1.Text;
                        emp.email = textBox2.Text;
                        emp.phonenumber = maskedTextBox1.Text;
                        emp.role = (Int32)comboBox1.SelectedValue;
                        emp.password = textBox3.Text;

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
