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
using System.Configuration;

namespace MovingInTable
{
    public partial class Form1 : Form
    {
        SqlDataAdapter da;
        DataTable dt;
        BindingSource bs;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetEmployees();
        }

        private void backToFirstButon_Click(object sender, EventArgs e)
        {
            backToFirst();
           
        }

        private void goBackButon_Click(object sender, EventArgs e)
        {
            goBackward();
        }

        private void goForwardButon_Click(object sender, EventArgs e)
        {
            goForward();
        }

        private void forwardToLastButon_Click(object sender, EventArgs e)
        {
            forwardToLast();
        }
        public void GetEmployees()
        {
            try
            {
                da = new SqlDataAdapter("select FirstName,LastName,EmployeeID from employees", ConfigurationManager.ConnectionStrings["con"].ConnectionString);
                dt = new DataTable();
                da.Fill(dt);
                bs = new BindingSource();
                bs.DataSource = dt;// binding source uzerinden de dt ile yapmak yerine bs ile yapılabilir. Burada hazir metotlar bulunuyor bunları metot clickleri içine atarak sonuca ulasilabilir.
                tBox1.DataBindings.Add("Text", bs, "Firstname");
                //tBox1.DataBindings.Add("Text", dt, "FirstName");
                tBox2.DataBindings.Add("Text", dt, "LastName");
                tBox3.DataBindings.Add("Text", dt, "EmployeeID");

            }
            catch (ConfigurationErrorsException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {

                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void backToFirst()
        {
            tBox1.BindingContext[dt].Position = 0;
        }
        public void goForward()
        {
            if (tBox1.BindingContext[dt].Position == dt.Rows.Count-1)
            {
                backToFirst();
            }
            else
            tBox1.BindingContext[dt].Position += 1;
        }
        public void goBackward()
        {
            if (tBox1.BindingContext[dt].Position == 0)
            {
                forwardToLast();
            }
            else
            tBox1.BindingContext[dt].Position -= 1;

        }
        public void forwardToLast()
        {
            tBox1.BindingContext[dt].Position = dt.Rows.Count-1;
        }
    }
}
