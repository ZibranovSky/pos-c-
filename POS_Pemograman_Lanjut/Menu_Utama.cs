namespace POS_Pemograman_Lanjut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            form_barang formBrg = new form_barang();
            formBrg.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            form_brg_msk formBrgMsk = new form_brg_msk();
            formBrgMsk.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form_brg_out formBrgOut = new form_brg_out();
            formBrgOut.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}