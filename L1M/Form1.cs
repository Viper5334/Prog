using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace L1M
{
    public partial class Form1 : Form
    {// fefefef
        //r43t43t4
        private const string helpfile = "help.chm";
        private const string Topic = "tablitsa_clients.htm";
        private const string Topic1 = "tablitsa_master.htm";
        private const string Topic2 = "tablitsa_holdings.htm";

        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\L1.mdf;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "l1DataSet2.Master". При необходимости она может быть перемещена или удалена.
            this.masterTableAdapter.Fill(this.l1DataSet2.Master);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "l1DataSet1.Holdings". При необходимости она может быть перемещена или удалена.
            this.holdingsTableAdapter.Fill(this.l1DataSet1.Holdings);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "l1DataSet.Clients". При необходимости она может быть перемещена или удалена.
            this.clientsTableAdapter.Fill(this.l1DataSet.Clients);

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            

            string a = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT id, ACCT_NBR, SYMBOL, SHARES, PUR_PRISE, PUR_DATE FROM Holdings WHERE ACCT_NBR LIKE '"+a+"%'",conn);
            DataTable data = new DataTable() ;
            sda.Fill(data);
            dataGridView2.DataSource = data;

            string p = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pictureBox1.ImageLocation = p;
        }

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {


            string a =  dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            SqlDataAdapter sda1 = new SqlDataAdapter("SELECT id, SYMBOL, CO_NAME, EXCHANOE, RATING, RANG, RISK, BETA FROM Master WHERE SYMBOL LIKE '" + a + "%'", conn);
            DataTable data1 = new DataTable();
            sda1.Fill(data1);
            dataGridView3.DataSource = data1;

        }

        private void dataGridView1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, helpfile, navigator, Topic);
        }

        private void dataGridView2_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, helpfile, navigator, Topic2);
        }

        private void dataGridView3_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            HelpNavigator navigator = HelpNavigator.Topic;
            Help.ShowHelp(this, helpfile, navigator, Topic1);
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {
            string s = toolTip1.GetToolTip(this.pictureBox1);
            toolStripStatusLabel2.Text = s;
        }

        private void toolTip2_Popup(object sender, PopupEventArgs e)
        {
            string s = toolTip2.GetToolTip(this.dataGridView1);
            toolStripStatusLabel2.Text = s;
        }

        private void toolTip3_Popup(object sender, PopupEventArgs e)
        {
            string s = toolTip3.GetToolTip(this.dataGridView2);
            toolStripStatusLabel2.Text = s;
        }

        private void toolTip4_Popup(object sender, PopupEventArgs e)
        {
            string s = toolTip4.GetToolTip(this.dataGridView3);
            toolStripStatusLabel2.Text = s;
        }
    }
}
