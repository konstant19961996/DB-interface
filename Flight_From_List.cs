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
    public partial class Flight_From_List : Form
    {
        public Flight_From_List()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker3.Format = DateTimePickerFormat.Time;
            dateTimePicker4.Format = DateTimePickerFormat.Time;
            dateTimePicker5.Format = DateTimePickerFormat.Time;
            //dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=key;Initial Catalog=Airline_DB;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Flight_From_List_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select distinct Flight_Number, Plane_Type_Name, Flight_List.Route_ID, Dest_Time, Arr_Time_Stop, Dest_Time_Stop, Arr_Time, Flight_Time,Regular from Airline, Hub_airport, Routes, Flight_List, Plane_Type where Airline.Airline_ID=Hub_airport.Airline_ID and Hub_airport.HubID=Routes.HubID and Routes.Route_ID=Flight_List.Route_ID and Flight_List.Plane_Type_ID=Plane_Type.Plane_Type_ID and Airline_Name='Аэрофлот'", cnn);
            da.Fill(ds, "Flight_List");
            dataGridView1.DataSource = ds.Tables[0];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_flight_from_list";
            cmd.Parameters.Add("@F_N", SqlDbType.Int, 32);
            cmd.Parameters["@F_N"].Value = textBox1.Text;
            cmd.Parameters.Add("@PT_Name", SqlDbType.VarChar, 50);
            cmd.Parameters["@PT_Name"].Value = textBox2.Text;
            cmd.Parameters.Add("@Route_ID", SqlDbType.Int, 32);
            cmd.Parameters["@Route_ID"].Value = textBox3.Text;
            cmd.Parameters.Add("@D_T", SqlDbType.DateTime, 8);
            cmd.Parameters["@D_T"].Value = dateTimePicker1.Value.ToLongTimeString();
            cmd.Parameters.Add("@A_T_S", SqlDbType.DateTime, 8);
            cmd.Parameters["@A_T_S"].Value = dateTimePicker2.Value.ToLongTimeString();
            cmd.Parameters.Add("@D_T_S", SqlDbType.DateTime, 8);
            cmd.Parameters["@D_T_S"].Value = dateTimePicker3.Value.ToLongTimeString();
            cmd.Parameters.Add("@A_T", SqlDbType.DateTime, 8);
            cmd.Parameters["@A_T"].Value = dateTimePicker4.Value.ToLongTimeString();
            cmd.Parameters.Add("@F_T", SqlDbType.DateTime, 8);
            cmd.Parameters["@F_T"].Value = dateTimePicker5.Value.ToLongTimeString();
            cmd.Parameters.Add("@Regular", SqlDbType.Bit, 8);
            cmd.Parameters["@Regular"].Value = textBox9.Text;
            cnn.Open();
            cmd.ExecuteScalar();
            label11.Text = "Добавление прошло успешно";
            cnn.Close();
        }


    }
}
