using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Pemograman_Lanjut
{
    public partial class form_brg_out : Form
    {
        public form_brg_out()
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
            string CommandText = "select * from outcoming_table";
            DB = new SQLiteDataAdapter(CommandText, sql_con);
            DS.Reset();
            DB.Fill(DS);
            DT = DS.Tables[0];
            dgv1.DataSource = DT;
            sql_con.Close();

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            tid_out.Text = String.Empty;
            tnm_brg.Text = String.Empty;
            tstok.Text = String.Empty;
            tstok_out.Text = String.Empty;
        }

        private void cb_brg_SelectedIndexChanged(object sender, EventArgs e)
        {
            string sql = "select * from product where id='" + cb_brg.Text + "'";
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
                    tnm_brg.Text = nmBrg.ToString();
                    tbarang_1.Text = nmBrg.ToString();
                    tstok.Text = stokBrg.ToString();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void form_brg_out_Load(object sender, EventArgs e)
        {
            loadCombobox();
            loadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id_msk = tid_out.Text;
            string idBrg = tid_brg.Text;
            string nmBrg = tnm_brg.Text;
            int stokBrg = Convert.ToInt32(tstok.Text);
            int stokOut = Convert.ToInt32(tstok_out.Text);

            DateTime dt = DateTime.Now;


            if (stokOut > stokBrg)
            {
                MessageBox.Show("stok keluar tidak boleh melebihi stok barang");
            }
            else
            {
                int newStok = stokBrg - stokOut;

                //UPDATE STOK

                string txtquery = "update product set stok = '" + newStok + "' where id = '" + idBrg + "'";
                ExecuteQuery(txtquery);


                //INSERT 
                string txtQuery2 = "insert into outcoming_table (id, product_id, number_of_item, created_date) values('" + id_msk + "','" + idBrg + "', '" + stokOut + "','" + dt + "')";
                ExecuteQuery(txtQuery2);

                MessageBox.Show("Berhasil mengeluarkan stok");

                loadData();
            }



        }
    }
}
