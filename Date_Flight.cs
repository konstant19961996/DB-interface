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
    public partial class Date_Flight : Form
    {
        public Date_Flight()
        {
            InitializeComponent();
            //dateTimePicker1.Format = DateTimePickerFormat.Short;
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=key;Initial Catalog=Airline_DB;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Date_Flight_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select distinct Flight.Flight_Number, Routes.Route_ID, Plane.Plane_Reg, Routes.HubID, Date from Airline, Hub_airport, Routes, Flight_List, Flight, Plane where Airline.Airline_ID=Hub_airport.Airline_ID and Hub_airport.HubID=Routes.HubID and Routes.Route_ID=Flight_List.Route_ID and Flight_List.Flight_Number=Flight.Flight_Number and Flight.Plane_ID=Plane.Plane_ID and Airline_Name='Аэрофлот'", cnn);
            da.Fill(ds, "Flight");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_date_flight";
            cmd.Parameters.Add("@F_N", SqlDbType.Int, 32);
            cmd.Parameters["@F_N"].Value = textBox1.Text;
            cmd.Parameters.Add("@Plane_Reg", SqlDbType.VarChar, 10);
            cmd.Parameters["@Plane_Reg"].Value = textBox2.Text;
            cmd.Parameters.Add("@Date", SqlDbType.DateTime, 8);
            cmd.Parameters["@Date"].Value = dateTimePicker1.Value;
            cnn.Open();
            cmd.ExecuteScalar();
            label5.Text = "Добавление прошло успешно";
            cnn.Close();
        }
    }
}
