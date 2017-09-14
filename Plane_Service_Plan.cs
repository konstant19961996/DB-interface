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
    public partial class Plane_Service_Plan : Form
    {
        public Plane_Service_Plan()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=key;Initial Catalog=Airline_DB;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Plane_Service_Plan_Load(object sender, EventArgs e)
        {   
            da = new SqlDataAdapter("select distinct Plane_Service_Plan_ID, Plane_Type_Name, Aircraft_Raid from Plane_Service_Plan, Plane_Type where Plane_Service_Plan.Plane_Type_ID=Plane_Type.Plane_Type_ID ", cnn);
            da.Fill(ds, "Plane_Service_Plan");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_P_S_Plan";
            cmd.Parameters.Add("@PT_Name", SqlDbType.VarChar, 50);
            cmd.Parameters["@PT_Name"].Value = textBox1.Text;
            cmd.Parameters.Add("@raid", SqlDbType.Int, 32);
            cmd.Parameters["@raid"].Value = textBox2.Text;
            cnn.Open();
            cmd.ExecuteScalar();
            label4.Text = "Добавление прошло успешно";
            cnn.Close();
        }
    }
}
