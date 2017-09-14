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
using Microsoft.Office.Interop.Excel;
using Excel=Microsoft.Office.Interop.Excel;

namespace DB_interface
{
    public partial class Plane_Service : Form
    {
        public Plane_Service()
        {
            InitializeComponent();
        }
        SqlConnection cnn = new SqlConnection(@"Data Source=key;Initial Catalog=Airline_DB;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();

        private void Plane_Service_Load(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select distinct Plane_Service.Plane_Service_ID, Plane_Type_Name, Aircraft_Raid, Plane_Reg, Plane_Service_Date, Detale_Name  from Airline, Hub_airport, Plane, Plane_Service, Plane_Service_Plan, Plane_Type, P_S_Details, Details where Airline.Airline_ID=Hub_airport.Airline_ID and Hub_airport.HubID=Plane.HubID and Plane.Plane_ID=Plane_Service.Plane_ID and Plane_Service.Plane_Service_Plan_ID=Plane_Service_Plan.Plane_Service_Plan_ID and Plane_Service_Plan.Plane_Type_ID=Plane_Type.Plane_Type_ID and Plane_Service.Plane_Service_ID=P_S_Details.Plane_Service_ID and P_S_Details.Detail_ID=Details.Detail_ID and Airline_Name='Аэрофлот'", cnn);
            da.Fill(ds, "Plane_Service");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_det";
            cmd.Parameters.Add("@D_Name", SqlDbType.VarChar, 50);
            cmd.Parameters["@D_Name"].Value = textBox1.Text;
            cmd.Parameters.Add("@cost", SqlDbType.Money, 32);
            cmd.Parameters["@cost"].Value = textBox2.Text;
            cnn.Open();
            cmd.ExecuteScalar();
            label4.Text = "Добавление прошло успешно";
            cnn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_P_S";
            cmd.Parameters.Add("@P_S_P", SqlDbType.Int, 32);
            cmd.Parameters["@P_S_P"].Value = textBox3.Text;
            cmd.Parameters.Add("@P_Reg", SqlDbType.VarChar, 10);
            cmd.Parameters["@P_Reg"].Value = textBox4.Text;
            cmd.Parameters.Add("@date", SqlDbType.DateTime, 8);
            cmd.Parameters["@date"].Value = dateTimePicker1.Value;
            cnn.Open();
            cmd.ExecuteScalar();
            label8.Text = "Добавление прошло успешно";
            cnn.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            cmd.CommandText = "new_S_det";
            cmd.Parameters.Add("@P_S", SqlDbType.Int, 32);
            cmd.Parameters["@P_S"].Value = textBox6.Text;
            cmd.Parameters.Add("@D_Name", SqlDbType.VarChar, 50);
            cmd.Parameters["@D_Name"].Value = textBox7.Text;
            cnn.Open();
            cmd.ExecuteScalar();
            label11.Text = "Добавление прошло успешно";
            cnn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Plane_Service.Plane_Service_ID, Plane_Type_Name, Aircraft_Raid, Plane_Reg, Plane_Service_Date, Detale_Name
            Excel.Application exApp = new Excel.Application();
            exApp.Visible = true;
            exApp.Workbooks.Add();
            Worksheet worksheet = (Worksheet)exApp.ActiveSheet;
            worksheet.Cells[1, 1] = "Plane_Service_ID";
            worksheet.Cells[1, 2] = "Plane_Type_Name";
            worksheet.Cells[1, 3] = "Aircraft_Raid";
            worksheet.Cells[1, 4] = "Plane_Reg";
            worksheet.Cells[1, 5] = "Plane_Service_Date";
            worksheet.Cells[1, 6] = "Detale_Name";
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                worksheet.Cells[i + 1, 1] = dataGridView1.Rows[i].Cells["Plane_Service_ID"].Value;
                worksheet.Cells[i + 1, 2] = dataGridView1.Rows[i].Cells["Plane_Type_Name"].Value;
                worksheet.Cells[i + 1, 3] = dataGridView1.Rows[i].Cells["Aircraft_Raid"].Value;
                worksheet.Cells[i + 1, 4] = dataGridView1.Rows[i].Cells["Plane_Reg"].Value;
                worksheet.Cells[i + 1, 5] = dataGridView1.Rows[i].Cells["Plane_Service_Date"].Value;
                worksheet.Cells[i + 1, 6] = dataGridView1.Rows[i].Cells["Detale_Name"].Value;
            }
            string PathtoxmlFile;
            PathtoxmlFile = Environment.CurrentDirectory + "\\" + "MyFile.xls";
            worksheet.SaveAs(PathtoxmlFile);
        }
    }
}
