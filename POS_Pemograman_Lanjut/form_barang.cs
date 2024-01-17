using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Xml.Linq;


namespace POS_Pemograman_Lanjut
{
    public partial class form_barang : Form
    {
        public form_barang()
        {
            InitializeComponent();
        }

        private SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        private SQLiteDataAdapter DB;
        private DataSet DS = new DataSet();
        private DataTable DT = new DataTable();

        private void SetConnection()
        {

            sql_con = new SQLiteConnection(@"Data Source=" + Application.StartupPath + "./db_pos.db;");
            SQLiteConnection connection = new SQLiteConnection(sql_con);

        }

        private void ExecuteQuery(string txtQuery)
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            sql_cmd.CommandText = txtQuery;
            sql_cmd.ExecuteNonQuery();
            sql_con.Close();
        }

        //load data into dgv

        private void LoadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from product";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dgv1.DataSource = DT;
            sql_con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tid.Text = string.Empty;
            tnm_brg.Text = string.Empty; 
            tharga.Text = string.Empty;

        }

        private void form_barang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var dateTime = DateTime.Now;
            var date = DateOnly.FromDateTime(dateTime);
            string txtQuery = "insert into product (id, name, stok, price, created_date, updated_date) values('" + tid.Text + "','" + tnm_brg.Text + "','0','" + tharga.Text + "','" + dateTime + "','')";
            ExecuteQuery(txtQuery);
            MessageBox.Show("Berhasil menambahkan barang");
            LoadData();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv1.Rows[e.RowIndex];
                tid.Text = row.Cells[0].Value.ToString();
                tnm_brg.Text = row.Cells[1].Value.ToString(); 
                tharga.Text = row.Cells[3].Value.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string id = tid.Text;
            string txtQuery = "delete from product where id = '" + id + "'";
            ExecuteQuery(txtQuery);
            LoadData();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            string strId = tid.Text;
            string strNama = tnm_brg.Text; 
            string strHarga = tharga.Text;
            string txtquery = "update product set name = '" + strNama + "', price = '" + strHarga + "' where id = '" + strId + "'";
            ExecuteQuery(txtquery);
            LoadData();
        }
    }
}
