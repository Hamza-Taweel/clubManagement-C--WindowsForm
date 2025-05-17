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


namespace Project_VP
{
    public partial class Main : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAMZA-PC;Initial Catalog=VP-Project;Integrated Security=True");

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            DateTime date = DateTime.Now;
        }

        private void ادارةبياناتالموظفينالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCusts_Emps frmCusts_Emps1 =  new frmCusts_Emps();
            frmCusts_Emps1.MdiParent = this; 
            frmCusts_Emps1.Show();
            
        }

        private void الاشتراكاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubsForm frmSubsForm = new SubsForm();
            frmSubsForm.MdiParent = this;
            frmSubsForm.Show();
        }

        private void تسجيلدفعةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PaymentsForm frmPaymentsForm = new PaymentsForm();
            frmPaymentsForm.MdiParent = this; 

            frmPaymentsForm.Show();
        }

        private void btnCutomersReport_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.CustomersTableAdapter customers = new DataSet1TableAdapters.CustomersTableAdapter();
            //DataTable dt = new DataTable();

        }

        private void عرضتقريربالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataSet1TableAdapters.CustomersTableAdapter customers = new DataSet1TableAdapters.CustomersTableAdapter();
            //DataTable dt = new DataTable();
            //dt = customers.SelectCustomers1();
            //CustomersReport cr = new CustomersReport();
            //cr.SetDataSource(dt);
            //frmCustomerReport f = new frmCustomerReport();
            //f.crystalReportViewer1.ReportSource = cr;
            //f.crystalReportViewer1.Refresh();
            //f.Show();




        }

        private void تقريربالموظفينToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.CustomersTableAdapter customers = new DataSet1TableAdapters.CustomersTableAdapter();
            DataTable dt = new DataTable();
            dt = customers.SelectCustomers1();
            CustomersReport cr = new CustomersReport();
            cr.SetDataSource(dt);
            frmCustomerReport f = new frmCustomerReport();
            f.MdiParent = this; 
            f.crystalReportViewer1.ReportSource = cr;
            f.crystalReportViewer1.Refresh();
            f.Show();

        }

        private void تقريربالزبائنToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.EmployeesTableAdapter employees = new DataSet1TableAdapters.EmployeesTableAdapter();
            DataTable dt = new DataTable();
            dt = employees.EmployeeReport1();
            EmployeesReport cr = new EmployeesReport();
            cr.SetDataSource(dt);
            frmEmployeeReport f = new frmEmployeeReport();
            f.MdiParent = this;
            f.crystalReportViewer1.ReportSource = cr;
            f.crystalReportViewer1.Refresh();
            f.Show();

        }

        private void تقريربالاشتراكاتالفعالةToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SubsTableAdapter subs = new DataSet1TableAdapters.SubsTableAdapter();
            DataTable dt = new DataTable();
            dt = subs.SelectSubs1();
            ActiveSubsReport cr = new ActiveSubsReport();
            cr.SetDataSource(dt);
            frmActiveSubs f = new frmActiveSubs();
            f.MdiParent = this;
            f.crystalReportViewer1.ReportSource = cr;
            f.crystalReportViewer1.Refresh();
            f.Show();

        }

        private void تقريربالاشتراكاتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DataSet1TableAdapters.SubsTableAdapter subs= new DataSet1TableAdapters.SubsTableAdapter(); 
            DataTable dt = new DataTable();
            dt = subs.SelectSubsWithoutAmount1();
            SubsWithoutAmountReport cr = new SubsWithoutAmountReport();
            cr.SetDataSource(dt);
            frmSubsWithoutAmount f = new frmSubsWithoutAmount();
            f.MdiParent = this;
            f.crystalReportViewer1.ReportSource = cr;
            f.crystalReportViewer1.Refresh();
            f.Show();

        }

        private void تقاريرالاشتراكاتToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
