using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace InventoryMangm
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\davic\OneDrive\Documentos\Inventorydb.mdf;Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from CustomerTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                CustomersGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }
        void populateproducts()
        {
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
        }

        DataTable cartTbl = new DataTable();

        void newcart()
        {
            OrderGv.DataSource = cartTbl;
            cartTbl.Clear();
            cartTbl.Columns.Clear();
            cartTbl.Columns.Add("ID", typeof(int));
            cartTbl.Columns.Add("Produto", typeof(string));
            cartTbl.Columns.Add("Quantidade", typeof(int));
            cartTbl.Columns.Add("Preço Unitário", typeof(decimal));
            cartTbl.Columns.Add("Preço Total", typeof(decimal));

        }
        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void fillcategory()
        {
            string query = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            try
            {
                Con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CatName", typeof(string));
                rdr = cmd.ExecuteReader();
                dt.Load(rdr);
                SearchCombo.ValueMember = "CatName";
                SearchCombo.DataSource = dt;
                Con.Close();
            }
            catch
            {

            }
        }

        void updateproduct()
        {
            
            int id =Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[0].Value.ToString());
            int newQty = stock - Convert.ToInt32(QtyTb.Text);
            if (newQty < 0)
            {
                MessageBox.Show("Falha na Compra!");
            }
            else
            {
                Con.Open();
                string query = "update ProductTbl set ProdQty = " + newQty + " where ProdId = " + id;
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                Con.Close();
                populateproducts();
            }
        }

        int num = 0;
        int uprice, totprice, qty;
        string product;

        private void ManageOrders_Load(object sender, EventArgs e)
        {
            populate();
            populateproducts();
            fillcategory();
            newcart();
        }

        private void CustomersGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustId.Text = CustomersGV.SelectedRows[0].Cells[0].Value.ToString();
            CustName.Text = CustomersGV.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        int flag = 0;
        int stock;
        private void ProductsGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            product = ProductsGV.SelectedRows[0].Cells[1].Value.ToString();
            stock = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[2].Value.ToString());
            uprice = Convert.ToInt32(ProductsGV.SelectedRows[0].Cells[3].Value.ToString());
            flag = 1;

        }
        int sum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            
            if(QtyTb.Text == "")
            {
                MessageBox.Show("Insira uma quantidade válida de produtos");
            }
            else if(flag == 0)
            {
                MessageBox.Show("Selecione o produto");
            }
            else if(Convert.ToInt32(QtyTb.Text) > stock)
            {
                MessageBox.Show("Sem estoque suficiente!");
            }
            else
            {
                num = num + 1;
                qty = Convert.ToInt32(QtyTb.Text);
                totprice = qty * uprice;
                cartTbl.Rows.Add(num, product, qty, uprice, totprice);
                OrderGv.DataSource = cartTbl;
                flag = 0;
            }
            sum = sum + totprice;
            TotAmount.Text = "R$" + sum.ToString();
            updateproduct();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            newcart();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OrderIdTb.Text==""||CustId.Text==""||CustName.Text==""||TotAmount.Text=="")
            {
                MessageBox.Show("Preencha as informações que faltam!");
            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into OrderTbl values('" + OrderIdTb.Text + "','" + CustId.Text + "','" + CustName.Text + "','" + OrderDate.Text + "','" + sum + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Compra inserida com sucesso!");
                Con.Close();
                populate();
                
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            
            try
            {
                Con.Open();
                string Myquery = "select * from ProductTbl where ProdCat='" + SearchCombo.SelectedValue.ToString() + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ProductsGV.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch
            {

            }
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
