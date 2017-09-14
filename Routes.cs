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
    public partial class Routes : Form
    {
        public Routes()
        {
            InitializeComponent();
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=key;Initial Catalog=Airline_DB;Integrated Security=True");
        SqlDataAdapter da, da2 = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataSet ds2 = new DataSet();

        private void Routes_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select distinct Route_ID, Routes.HubID, A1.Airport_Name, A2.Airport_Name, A3.Airport_Name,  Range, International from Airline, Hub_airport, Routes, Airport A1, Airport A2, Airport A3 where Airline.Airline_ID=Hub_airport.Airline_ID and Hub_airport.HubID=Routes.HubID and Routes.Airport_ID=A1.Airport_ID and Routes.Air_Airport_ID=A2.Airport_ID and Routes.Air_Airport_ID2=A3.Airport_ID and Airline_Name='Аэрофлот'", cnn);
            da.Fill(ds, "Routes");
            dataGridView1.DataSource = ds.Tables[0];
            da2 = new SqlDataAdapter("select distinct Route_ID, Routes.HubID, A1.Airport_Name, A2.Airport_Name, Range, International from Airline, Hub_airport, Routes, Airport A1, Airport A2 where Airline.Airline_ID=Hub_airport.Airline_ID and Hub_airport.HubID=Routes.HubID and Routes.Airport_ID=A1.Airport_ID and Routes.Air_Airport_ID=A2.Airport_ID and Airline_Name='Аэрофлот' and Air_Airport_ID2 is null", cnn);
            da2.Fill(ds2, "Routes");
            dataGridView2.DataSource = ds2.Tables[0];   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_route";
            cmd.Parameters.Add("@H_Name", SqlDbType.VarChar, 50);
            cmd.Parameters["@H_Name"].Value = textBox1.Text;
            cmd.Parameters.Add("@Air_Name1", SqlDbType.VarChar, 50);
            cmd.Parameters["@Air_Name1"].Value = textBox2.Text;
            cmd.Parameters.Add("@Air_Name2", SqlDbType.VarChar, 50);
            cmd.Parameters["@Air_Name2"].Value = textBox3.Text;
            cmd.Parameters.Add("@Air_Name3", SqlDbType.VarChar, 50);
            cmd.Parameters["@Air_Name3"].Value = textBox4.Text;
            cmd.Parameters.Add("@Range", SqlDbType.Int, 32);
            cmd.Parameters["@Range"].Value = textBox5.Text;
            cmd.Parameters.Add("@Inter", SqlDbType.Bit, 8);
            cmd.Parameters["@Inter"].Value = textBox6.Text;
            cnn.Open();
            cmd.ExecuteScalar();
            label8.Text = "Добавление прошло успешно";
            cnn.Close();

        }




    }
}
