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

namespace DB_interface
{
    public partial class Plane_Types : Form
    {
        public Plane_Types()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=key;Initial Catalog=Airline_DB;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();


        private void Plane_Types_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select Plane_Type_Name from Plane_Type", cnn);
            da.Fill(ds, "Plane_Type");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_plane_type";
            cmd.Parameters.Add("@PT_Name", SqlDbType.VarChar, 50);
            cmd.Parameters["@PT_Name"].Value = textBox1.Text;
            cnn.Open();
            cmd.ExecuteScalar();
            label3.Text = "Добавление прошло успешно";
            cnn.Close();
        }
    }
}
