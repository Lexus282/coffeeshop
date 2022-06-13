using coffeeshop.Forms;
using coffeeshop.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace coffeeshop
{
    public partial class Auth : Form
    {
        public String EmployeeId { get; set; }

        public Auth()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            String login = this.login_box.Text;
            String password = this.password_box.Text;

            if (String.IsNullOrWhiteSpace(login))
            {
                MessageBox.Show("Логин введен не корректно");
                return;
            }

            if (String.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пароль введен не корректно");
                return;
            }

            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {

                var user = db.employees.Where(u => u.email == login && u.password == password).FirstOrDefault();

                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }

                EmployeeId = user.userid;
            }

            Main mainForm = new Main(EmployeeId);
            this.Hide();
            mainForm.ShowDialog();
            this.Show();
        }
    }
}
