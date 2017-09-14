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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=key;Initial Catalog=Airline_DB;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Planes_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select distinct Plane_Type_Name, Plane_Reg, Plane.HubID, Seat_Number, Max_Range from Hub_airport,Plane,Plane_Type,Airline where Plane.Plane_Type_ID=Plane_Type.Plane_Type_ID and Plane.HubID=Hub_airport.HubID and Hub_airport.Airline_ID=Airline.Airline_ID and Airline_Name='Аэрофлот'", cnn);
            da.Fill(ds, "Plane");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_plane";
            cmd.Parameters.Add("@PT_Name", SqlDbType.VarChar, 50);
            cmd.Parameters["@PT_Name"].Value = textBox1.Text;
            cmd.Parameters.Add("@Air_Name", SqlDbType.VarChar, 50);
            cmd.Parameters["@Air_Name"].Value = textBox2.Text;
            cmd.Parameters.Add("@P_Reg", SqlDbType.VarChar, 10);
            cmd.Parameters["@P_Reg"].Value = textBox3.Text;
            cmd.Parameters.Add("@Seat_Num", SqlDbType.Int, 32);
            cmd.Parameters["@Seat_Num"].Value = textBox4.Text;
            cmd.Parameters.Add("@Max_Range", SqlDbType.Int, 32);
            cmd.Parameters["@Max_Range"].Value = textBox4.Text;
            cnn.Open();
            cmd.ExecuteScalar();
            label7.Text = "Добавление прошло успешно";
            cnn.Close();
        }


    }
}
