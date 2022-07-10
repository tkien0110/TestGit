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
    public partial class formAccount : Form
    {
        SqlConnection conn;
        SqlCommand comm;
        SqlDataAdapter da = new SqlDataAdapter();
        string connstr = "Data Source=LAPTOP-CIMCTMTJ\\SQLEXPRESS;Initial Catalog=test2;Integrated Security=True";
        DataTable dt = new DataTable();
        public formAccount()
        {
            InitializeComponent();
        }
        void loadData()
        {
            comm = conn.CreateCommand();
            comm.CommandText = "SELECT * FROM dbo.tbAccount";
            da.SelectCommand = comm;
            dt.Clear();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void formAccount_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(connstr);
            conn.Open();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtStt.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtAccount.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtCompany.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtBookie.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtBot.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtChannel.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            txtRule.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            txtState.Text = dataGridView1.Rows[i].Cells[7].Value.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "INSERT INTO dbo.tbAccount VALUES('" + txtStt.Text + "',N'" + txtAccount.Text + "',N'" + txtCompany.Text + "',N'" + txtBookie.Text + "',N'" + txtBot.Text + "',N'" + txtChannel.Text + "',N'" + txtRule.Text + "',N'" + txtState.Text + "')";
            comm.ExecuteNonQuery();
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "DELETE FROM dbo.tbAccount where STT = '" + txtStt.Text + "' ";
            comm.ExecuteNonQuery();
            loadData();
            txtStt.Clear();
            txtAccount.Clear();
            txtBookie.Clear();
            txtBot.Clear();
            txtChannel.Clear();
            txtCompany.Clear();
            txtRule.Clear();
            txtState.ResetText();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            comm = conn.CreateCommand();
            comm.CommandText = "update dbo.tbAccount set  Account =N'" + txtAccount.Text + "', Company = N'" + txtCompany.Text + "',Bookie =N'" + txtBookie.Text + "',Bot =N'" + txtBot.Text + "',Chanel = N'" + txtChannel.Text + "',[Rule] = N'" + txtRule.Text + "',State = N'"+txtState+"' where STT ='" + txtStt.Text + "'";
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
