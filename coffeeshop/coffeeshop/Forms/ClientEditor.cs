using coffeeshop.Repository;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace coffeeshop.Forms
{
    public partial class ClientEditor : Form
    {
        public String UserId { get; }
        public clients addedClient;
        public ClientEditor(String userId)
        {
            UserId = userId;
            InitializeComponent();
        }

        private void ClientEditor_Load(object sender, EventArgs e)
        {
            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                if (!String.IsNullOrEmpty(UserId))
                {
                    var client = db.clients.Where(x => x.userid == UserId).FirstOrDefault();

                    textBox1.Text = client.name;
                    textBox2.Text = client.email;
                    maskedTextBox1.Text = client.phonenumber;
                }
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text) || String.IsNullOrWhiteSpace(textBox2.Text) || String.IsNullOrWhiteSpace(maskedTextBox1.Text))
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
                        addedClient = new clients
                        {
                            userid = Guid.NewGuid().ToString(),
                            name = textBox1.Text,
                            email = textBox2.Text,
                            phonenumber = maskedTextBox1.Text,
                        };

                        db.clients.Add(addedClient);
                        db.SaveChanges();
                    }
                }
                else
                {
                    using (CoffeeshopEntities db = new CoffeeshopEntities())
                    {
                        var client = db.clients.Where(x => x.userid == UserId).FirstOrDefault();
                        if (client == null)
                        {
                            MessageBox.Show("Клиент не найден");
                            return;
                        }

                        client.name = textBox1.Text;
                        client.email = textBox2.Text;
                        client.phonenumber = maskedTextBox1.Text;

                        addedClient = client;

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
