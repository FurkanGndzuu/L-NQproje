using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LİNQproje
{
    public partial class Form1 : Form
    {

        private int[] Sayilar = { -9, -6, -5, 4, 3, 2, 1 };
        List<string> isimler = new List<string>();
        public Form1()
        {
            InitializeComponent();

            isimler.Add("Furkan");
            isimler.Add("Merve");
            isimler.Add("Melek");
            isimler.Add("Cansu");
            isimler.Add("Ahmet");
            isimler.Add("Mehmet");
            isimler.Add("Zeynep");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSayilarTam_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = Sayilar.ToList();
        }

        private void btnNegatif_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = Sayilar.Where(x => x < 0).Select(x => x);
            listBox1.DataSource = null;
            listBox1.DataSource= n.ToList();
        }

        private void btnPozitif_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = Sayilar.Where(x => x > 0).Select(x => x);
            listBox1.DataSource = null;
            listBox1.DataSource=n.ToList();
        }

        private void ciftBtn_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = Sayilar.Where(x => x % 2==0 ).Select(x => x);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void btnTek_Click(object sender, EventArgs e)
        {
            IEnumerable<int> n = Sayilar.Where(x => x % 2 == 1 || x % 2 == -1).Select(x => x);
            listBox1.DataSource = null;
            listBox1.DataSource = n.ToList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int max = Sayilar.Max();
            MessageBox.Show(max.ToString());
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = Sayilar.Min();
            MessageBox.Show(min.ToString());
        }

        private void AdetBtn_Click(object sender, EventArgs e)
        {
            int Adet = Sayilar.Count();
            MessageBox.Show(Adet.ToString());
        }

        private void Alfabetik_Click(object sender, EventArgs e)
        {
            listBox1.DataSource=null;
            listBox1.DataSource = isimler.OrderBy(x => x).ToList();
        }

        private void Ters_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.OrderByDescending(x => x).ToList();   
        }

        private void Uzunluk_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Select(x => x.Length).ToList();
        }

        private void btnBulunan_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = null;
            listBox1.DataSource = isimler.Where(x => x.Contains("m")|| x.Contains("M")).Select(x=>x).ToList();
        }

        private void btnSiparis_Click(object sender, EventArgs e)
        {
            

            List<Order> orders =new Order().GetOrders();

            var result = orders.Select(x => new
            {
                siparisNo = x.OrderID,
                Tarih = x.OrderDate,
                Musteri = x.Customers.ContactName
            }) ;

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = result.ToList();  

        }

        private void SadeceTarih_Click(object sender, EventArgs e)
        {
            List<Order> orders=new Order().GetOrders();

            var result = orders.Select(x => x.OrderDate);

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = result.ToList();
        }

        private void Top5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = orders.Take(5).ToList();
        }

        private void Son5_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();
            dataGridView1.DataSource = null;

            dataGridView1.DataSource = orders.OrderByDescending(x=>x.OrderID).Take(5).ToList();
        }

        private void YangWang_Click(object sender, EventArgs e)
        {
            List<Order> orders = new Order().GetOrders();

            dataGridView1.DataSource = null;

            dataGridView1.DataSource = orders.Where(x=>x.Customers.ContactName=="Yang Wang").Select(x=>x).ToList();

        }
    }
}
