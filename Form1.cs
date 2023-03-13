using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Data.SqlClient;
using System.Configuration;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.IO;

namespace ClinicConsultationForm
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            ConnectionStringSettings settings = ConfigurationManager.ConnectionStrings["constr"];
            cnn = new SqlConnection(settings.ConnectionString);
            gridDiagnosis.DataSource= getDiagnosis();
            dgTreatment.DataSource= getTreatment();
        }

        private DataTable getTreatment()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT [ID] AS [TREATMENT_NO],[TREATMENT] FROM [IBusinessTest].[dbo].[CLINIC_TREATMENT]";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                cnn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();

            }


            return dt;
        }

        private DataTable getDiagnosis()
        {
            DataTable dt = new DataTable();
            string sql = "SELECT [ID] AS [DIAGNOSIS_NUMBER],[DIAGNOSIS] FROM [IBusinessTest].[dbo].[CLINIC_DIAGNOSIS]";
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql,cnn);
                cnn.Open();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cnn.Close();

            }


            return dt;
        }

        private void clearAll()
        {
            txtDate.Text = DateTime.Now.ToString("dd-MM-yyyy");
            txtName.Clear();
            txtEmpNum.Clear();
            txtTemp.Clear();
            txtDiag.Clear();
            txtTreat1.Clear();
            txtRmk.Clear();
            txtNurse.Clear();
            if (ckSickBay.Checked) { ckSickBay.Checked = false; }

        }

        private void txtEmpNum_Paint(object sender, PaintEventArgs e)
        {
            newgp(txtEmpNum, e); newgp(txtRmk, e);
            newgp(txtName, e);  newgp(txtNurse, e);
            newgp(txtDate, e);
            newgp(txtTemp,e); 
            newgp(txtDiag, e);
            newgp(txtTreat1, e);
        }

        private void newgp(System.Windows.Forms.TextBox tb,PaintEventArgs es)
        {
            Graphics g = es.Graphics;
            Rectangle rect = new Rectangle(0, 0, tb.Width, tb.Height);
            int radius = 15;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();
                es.Graphics.TranslateTransform(tb.Location.X, tb.Location.Y);
                es.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                Pen borderPen = new Pen(Color.Black, 4);
                es.Graphics.DrawPath(borderPen, path);
                g.FillPath(Brushes.White, path);
                tb.Region = new Region(path);
                es.Graphics.ResetTransform();
            }
        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void rbFit_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbUnfit_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void rbFit_Click(object sender, EventArgs e)
        {
            if (rbUnfit.Checked)
            {
                rbUnfit.Checked = false;
            }
        }

        private void rbUnfit_Click(object sender, EventArgs e)
        {
            if (rbFit.Checked)
            {
                rbFit.Checked = false;
            }
        }

        private void lblSave_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, lblSave.Width, lblSave.Height);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                lblSave.Region = new Region(path);
            }
        }

        private void lblCancel_Paint(object sender, PaintEventArgs e)
        {
            int radius = 20;
            Rectangle rect = new Rectangle(0, 0, lblCancel.Width, lblCancel.Height);
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.X + rect.Width - radius, rect.Y + rect.Height - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Y + rect.Height - radius, radius, radius, 90, 90);
                path.CloseAllFigures();

                lblCancel.Region = new Region(path);
            }
        }

        private void lblSave_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private string getDescription(string treatNo)
        {
            string result = "";
            string treatmentNo = "";
            foreach (DataGridViewRow row in dgTreatment.Rows)
            {
                treatmentNo = row.Cells["TREATMENT_NO"].Value.ToString();
                if (row.Cells["TREATMENT_NO"].Value.ToString() == treatNo)
                {
                    result = row.Cells["TREATMENT"].Value.ToString();
                }
                else
                {
                    
                }
            }
            return result;
        }

        private void lblSave_Click(object sender, EventArgs e)
        {
            string treatement_res = "";
            if (txtTreat1.Text.Contains(','))
            {
                string[] treatmentS = txtTreat1.Text.Split(',');
                int i = 0;

                foreach(var k in treatmentS)
                {

                    i++;
                    if (i != treatmentS.Length)
                    {
                        treatement_res = treatement_res + getDescription(k) + " & ";

                    }
                    else
                    {
                        treatement_res = treatement_res + getDescription(k);

                    }

                }

            }
            else
            {
                treatement_res = txtTreat1.Text;
            }


            if (treatement_res != "")
            {
                string sqlInsert = "INSERT INTO [dbo].[CLINIC_CONSULTATION_DATA] ([EMPLOYEE_ID],[DATE],[TIME],[TEMPERATURE],[DIAGNOSIS_NO],[TREATMENT]," +
               "[REMARKS],[FIT_TO_WORK],[SICKBAY],[NURSE_ON_DUTY],[CLINIC]) VALUES (@empID,@curDate,@curTime,@temp,@diagnosisNo,@treatment,@rmks,@fitToWork,@sickBay,@nurseOnDuty,@clinic)";

                SqlCommand cmd = new SqlCommand(sqlInsert, cnn);
                cmd.Parameters.Add("@empID", SqlDbType.NVarChar).Value = txtEmpNum.Text;
                cmd.Parameters.Add("@curDate", SqlDbType.NVarChar).Value = DateTime.Now.ToString("yyyy-MM-dd");
                cmd.Parameters.Add("@curTime", SqlDbType.NVarChar).Value = DateTime.Now.ToString("HH:mm:ss");
                cmd.Parameters.Add("@temp", SqlDbType.NVarChar).Value = txtTemp.Text;
                cmd.Parameters.Add("@diagnosisNo", SqlDbType.NVarChar).Value = txtDiag.Text;
                cmd.Parameters.Add("@treatment", SqlDbType.NVarChar).Value = treatement_res;


                cmd.Parameters.Add("@rmks", SqlDbType.NVarChar).Value = txtRmk.Text;
                if (rbFit.Checked)
                {
                    cmd.Parameters.Add("@fitToWork", SqlDbType.NVarChar).Value = "1";
                }
                else
                {
                    cmd.Parameters.Add("@fitToWork", SqlDbType.NVarChar).Value = "0";
                }

                if (ckSickBay.Checked)
                {
                    cmd.Parameters.Add("@sickBay", SqlDbType.NVarChar).Value = "1";
                }
                else
                {
                    cmd.Parameters.Add("@sickBay", SqlDbType.NVarChar).Value = "0";
                }

                if (CK_CLINIC.Checked)
                {
                    cmd.Parameters.Add("@clinic", SqlDbType.NVarChar).Value = "1";
                }
                else
                {
                    cmd.Parameters.Add("@clinic", SqlDbType.NVarChar).Value = "0";
                }

                cmd.Parameters.Add("@nurseOnDuty", SqlDbType.NVarChar).Value = txtNurse.Text;

                try
                {
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cnn.Close();
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Check Treatment No.");
            }
           

        }

        private void lblCancel_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        private DataTable retrieveEmployeeData()
        {
            DataTable employeeData = new DataTable();
            employeeData.Columns.Add("EmployeeID", typeof(string));
            employeeData.Columns.Add("Fullname", typeof(string));
            employeeData.Columns.Add("jobTitle", typeof(string));

            var path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            path = path.Substring(6);
            string pathTofile = path + @"\EMPLOYEEINFO.txt";

            string[] lines = File.ReadAllLines(pathTofile);
            foreach (string line in lines)
            {
                string[] data = line.Split(new char[] { '\t' });
                if (data.Length > 0)
                {
                    DataRow empdr = employeeData.NewRow();
                    empdr["EmployeeID"] = data[0];
                    empdr["Fullname"] = data[1];
                    empdr["jobTitle"] = data[2];
                    employeeData.Rows.Add(empdr);
                }
            }
            return employeeData;
        }

        private void txtEmpNum_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DataTable data = retrieveEmployeeData();
                DataRow[] dr = data.Select("EmployeeID = '"+txtEmpNum.Text+"'");
                if (dr.Length > 0)
                {
                    txtName.Text = dr[0].ItemArray[1].ToString();
                    txtTemp.Focus();
                }
                else
                {
                    MessageBox.Show("Employee " + txtEmpNum.Text + " Does not exist. Update the data in EMPLOYEEINFO.txt");
                }

            }
        }
    }
}
