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

namespace test2
{
    public partial class formDB : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter da = new SqlDataAdapter();
        string connstr = "Data Source=LAPTOP-CIMCTMTJ\\SQLEXPRESS;Initial Catalog=test2;Integrated Security=True";
        DataTable dt = new DataTable();
        void loadData()
        {
            comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM dbo.tbDashboard";
            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }
        public formDB()
        {
            InitializeComponent();
        }

        private void formDB_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtSTT.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtAccount.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtBookie.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtCha.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtR.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtSu.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtSta.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO dbo.tbDashboard VALUES('"+txtSTT.Text+"',N'"+txtAccount.Text+"',N'"+txtBookie.Text+"',N'"+txtCha.Text+"','"+txtR.Text+"',N'"+txtSu.Text+"',N'"+txtSta.Text+"')";
            comm.ExecuteNonQuery();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM dbo.tbDashboard where STT = '"+txtSTT.Text+"' ";
            comm.ExecuteNonQuery();
            loadData();
            txtCha.Clear();
            txtAccount.Clear();
            txtBookie.Clear();
            txtR.Clear();
            txtSta.ResetText();
            txtSTT.Clear();
            txtSu.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "update dbo.tbDashboard set  Account =N'"+txtAccount.Text+"', Bookie = N'"+txtBookie.Text+"',Channel =N'"+txtCha.Text+"',[Rule] ='"+txtR.Text+ "',S = N'"+txtSu.Text+"',Status = N'" +txtSta.Text+"' where STT ='"+txtSTT.Text+"'";
            comm.ExecuteNonQuery();
            loadData();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Main f1 = new Main();
            f1.Show();
            Visible = false;
        }
    }
}
