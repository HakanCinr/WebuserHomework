using Microsoft.VisualBasic.ApplicationServices;
using System.Drawing;
using System.Xml.Linq;
using Webuser.models;
using Webuser.services;

namespace Webuser
{
    public partial class Form1 : Form
    {
        void LoadData()
        {
            // 1- Add New Supplier Form and List ( Grid View )


            dataGridView1.DataSource = null;
            Hakancontext context = new Hakancontext();
            dataGridView1.DataSource = context.Products.ToList();

        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebUser user = new WebUser();
            user.Name = txtname.Text;
            user.Surname = txtsurname.Text;
            user.Phone = txtphone.Text;
            user.Email = txteposta.Text;
            user.Password = txtpassword.Text;
            bool result = WebUserServices.Add(user);


            if (result)
            {
                MessageBox.Show("Baþarýlý.");
                LoadData();

            }
            else
            {
                MessageBox.Show("Hatalý kayýt");
            }


        }
        int selectedProductId = 0;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnget_Click(object sender, EventArgs e)
        {
            //2 Search Supplier By Id

            //Ekrana bir input ve bir buton konulacak.Input a ID deðeri girecek.Butona týkladýðýnda o id ye ait supplier özelliklerini ekranda gösterecek(labellar üzerinde)


            int get = int.Parse(txtget.Text);
            Hakancontext db = new Hakancontext();
            Product product = db.Products.Find(get);

            if (ProductServices.get != null)
            {

                lblcnname.Text = product.CompanyName;
                lblctnar.Text = product.ContactName;
                lblctttl.Text = product.ContactTitle;
                adres.Text = product.Address;
            }
            else
            {
                MessageBox.Show("veri bulunamadý");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //2- Delete Supplier By Id
           // Ekrana bir input ve bir buton konulacak.Input a ID deðeri girecek.Butona týkladýðýnda o id ye ait supplier db den silinecek ve ekranda bir mesaj gösterilecek



            int get = int.Parse(txtget.Text);

            Hakancontext db = new Hakancontext();
            Product product = db.Products.Find(get);

            db.Remove(product);
            MessageBox.Show("liste silindi");
            db.SaveChanges();

        }
    }
}