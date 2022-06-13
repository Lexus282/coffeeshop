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
    public partial class TypeEditor : Form
    {
        public Int32? TypeID { get; set; }

        public TypeEditor(Int32? typeId)
        {
            TypeID = typeId;
            InitializeComponent();
        }

        private void TypeEditor_Load(object sender, EventArgs e)
        {
            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                if (TypeID != null)
                {
                    var type = db.type.Where(x => x.id == TypeID).FirstOrDefault();

                    textBox1.Text = type.name;
                }
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Некорректный формат");
                return;
            }

            using (CoffeeshopEntities db = new CoffeeshopEntities())
            {
                if (TypeID != null)
                {
                    var type = db.type.Where(x => x.id == TypeID).FirstOrDefault();
                    type.name = textBox1.Text;
                    db.SaveChanges();
                }
                else
                {
                    db.type.Add(new type { name = textBox1.Text });
                    db.SaveChanges();
                }
            }

            Close();
        }
    }
}
