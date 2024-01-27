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
using System.IO;
using System.Security.Cryptography;


namespace POS_Pemograman_Lanjut
{
    public partial class form_brg_msk : Form
    {
        public form_brg_msk()
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

        private void loadCombobox()
        {

            string sql = "select * from product";
            ExecuteQuery(sql);
            SQLiteDataReader myReader;

            try
            {
                sql_con.Open();
                myReader = sql_cmd.ExecuteReader();
                while (myReader.Read())
                {
                    int idBrg = myReader.GetInt32(0);
                    string nmBrg = myReader.GetString(1);
                    cb_brg.Items.Add(idBrg);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }


        private void loadData()
        {
            SetConnection();
            sql_con.Open();
            sql_cmd = sql_con.CreateCommand();
            string CommandText = "select * from incoming_product";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dgv1.DataSource = DT;
            sql_con.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tnm_brg.Text = String.Empty;
            tstok.Text = String.Empty;
            tstok_msk.Text = String.Empty;
        }

        private void tnm_brg_TextChanged(object sender, EventArgs e)
        {

        }

        private void form_brg_msk_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadData();
        }

        private void cb_brg_SelectedIndexChanged(object sender, EventArgs e)
        {


            string sql = "select * from product where id ='" + cb_brg.Text + "'";
            ExecuteQuery(sql);
            SQLiteDataReader myReader;

            try
            {
                sql_con.Open();
                myReader = sql_cmd.ExecuteReader();
                while (myReader.Read())
                {
                    int idBrg = myReader.GetInt32(0);
                    string nmBrg = myReader.GetString(1);
                    int stokBrg = myReader.GetInt32(2);

                    tid_brg.Text = idBrg.ToString();
                    tbarang_1.Text = nmBrg.ToString();
                    tnm_brg.Text = nmBrg.ToString();
                    tstok.Text = stokBrg.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_msk = tid_msk.Text;
            string idBrg = tid_brg.Text;
            string nmBrg = tnm_brg.Text;
            int stokBrg = Convert.ToInt32(tstok.Text);
            int stokMsk = Convert.ToInt32(tstok_msk.Text);

            DateTime dt = DateTime.Now;




            int newStok = stokBrg + stokMsk;

            //UPDATE STOK

            string txtquery = "update product set stok = '" + newStok + "' where id = '" + idBrg + "'";
            ExecuteQuery(txtquery);


            //INSERT 
            string txtQuery2 = "insert into incoming_product (id, product_id, number_of_item, created_date) values('" + id_msk + "','" + idBrg + "', '" + stokMsk + "','" + dt + "')";
            ExecuteQuery(txtQuery2);

            MessageBox.Show("Berhasil menambahkan stok");

            loadData();




        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv1.Rows[e.RowIndex];
                tid_msk.Text = row.Cells[0].Value.ToString();
                tid_brg.Text = row.Cells[1].Value.ToString();
                tnm_brg.Text = row.Cells[2].Value.ToString();
                tstok.Text = row.Cells[3].Value.ToString();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = tid_msk.Text;
            string txtQuery = "delete from incoming_product where id = '" + id + "'";
            ExecuteQuery(txtQuery);
            loadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void tstok_TextChanged(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void tstok_msk_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void tid_brg_TextChanged(object sender, EventArgs e)
        {
        }

        private void tid_msk_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
