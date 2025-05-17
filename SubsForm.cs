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
    public partial class SubsForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAMZA-PC;Initial Catalog=VP-Project;Integrated Security=True");


        public SubsForm()
        {
            InitializeComponent();
        }
        private void clearAll()
        {
            
                txtServiceNo.Clear();
                txtCustomerNo.Clear();
                mtxtStartDate.Clear();
                mtxtEndDate.Clear();
           






        }
        private void rbtnAddSub_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAddSub.Checked == true)
            {
                txtCustomerNo.Visible = true;
                txtServiceNo.Visible = true;
                mtxtEndDate.Visible = true;
                mtxtStartDate.Visible = true;
                btnAddSub.Visible = true;
                lblTitle.Visible = true;
                lblTitle.Text = "الرجاء ادخال بيانات الاشتراك";
                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;

                btnCancelSub.Visible = false;

                btnDisplayAllCusts.Visible = true;
                btnDisplayServices.Visible = true;
                btnShowSubs.Visible = true;
                btnShowCustsInServic.Visible =false ;
                btnShowSubsForCust.Visible = false;


            }
        }

        private void rbtnCancelSub_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCancelSub.Checked == true)
            {
                clearAll();
                txtCustomerNo.Visible = true;
                txtServiceNo.Visible = true;
                lblTitle.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                btnCancelSub.Visible = true;

                lblTitle.Text = ("لالغاء الاشتراك,الرجاء ادخال رقم الخدمة ورقم الزبون المراد الغاء الاشتراك له");
                mtxtEndDate.Visible = false;
                mtxtStartDate.Visible = false;
                btnAddSub.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                btnDisplayAllCusts.Visible = true;
                btnDisplayServices.Visible = true;
                btnShowSubs.Visible = true;
                btnShowCustsInServic.Visible = false;
                btnShowSubsForCust.Visible = false;
            }

        }
        private void rbtnShowCustsInService_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnShowCustsInService.Checked ==true)
            {
                clearAll();
                txtCustomerNo.Visible = false;
                txtServiceNo.Visible = true;
                lblTitle.Visible = true;
                label1.Visible = true;
                label2.Visible = false;
                btnCancelSub.Visible = false;

                lblTitle.Text = ("الرجاء ادخال رقم الخدمة المراد عرض الاشتراكات فيها");
                mtxtEndDate.Visible = false;
                mtxtStartDate.Visible = false;
                btnAddSub.Visible = false;
                label3.Visible = false;
                label4.Visible = false;

                btnDisplayAllCusts.Visible = true;
                btnDisplayServices.Visible = true;
                btnShowSubs.Visible = true;
                btnShowCustsInServic.Visible = true;
                btnShowSubsForCust.Visible = false;

            }

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            clearAll();
            txtCustomerNo.Visible = true;
            txtServiceNo.Visible = false;
            lblTitle.Visible = true;
            label1.Visible = false;
            label2.Visible = true;
            btnCancelSub.Visible = false;

            lblTitle.Text = ("الرجاء ادخال رقم الزبون المراد عرض اشتراكاته");
            mtxtEndDate.Visible = false;
            mtxtStartDate.Visible = false;
            btnAddSub.Visible = false;
            label3.Visible = false;
            label4.Visible = false;

            btnDisplayAllCusts.Visible = true;
            btnDisplayServices.Visible = true;
            btnShowSubs.Visible = true;
            btnShowCustsInServic.Visible = false;
            btnShowSubsForCust.Visible = true;

        }



        private void btnAddSub_Click(object sender, EventArgs e) // Add Sub in DB
        {
            try
            {
               
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert into Subs values(@serviceNo, @customerNo, @startDate, @endDate)", con);
                    cmd.Parameters.AddWithValue("@serviceNo", Convert.ToInt16(txtServiceNo.Text));
                    cmd.Parameters.AddWithValue("@customerNo", Convert.ToInt16(txtCustomerNo.Text));
                    cmd.Parameters.AddWithValue("@startDate", Convert.ToDateTime( mtxtStartDate.Text));
                    cmd.Parameters.AddWithValue("@endDate",Convert.ToDateTime( mtxtEndDate.Text));
                    DialogResult result = MessageBox.Show("هل انت متأكد من الاضافة؟", "اضافة اشتراك", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
               {
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("تم اضافة الاشتراك بنجاح", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        clearAll();
                    }
                    else
                        MessageBox.Show(" خطأ: لم يتم اضافة الاشتراك", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);

                    con.Close();
                }


            }
            catch (FormatException)
            {
                MessageBox.Show("الرجاء ادخال قيم قبل الاضافة", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(" رقم الخدمة او رقم الزبون او كلاهما غير موجودان", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                //txtServiceNo.Clear();
                //txtCustomerNo.Clear();

            }
            catch (SqlException)
            {
                MessageBox.Show(" رقم الخدمة او رقم الزبون او كلاهما غير موجودان", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                //txtServiceNo.Clear();
                //txtCustomerNo.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير: حدث خطأ ما , الرجاء اعادة المحاولة", "تحذير ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }

        }

       

        private void btnCancelSub_Click(object sender, EventArgs e) //Remove sub from DB
        {
            try
            {
                DialogResult result = MessageBox.Show("هل انت متأكد من الغاء الاشتراك؟", "الغاء اشتراك", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Subs where ServiceNo = @sno and CustomerNo = @cno ", con);
                    cmd.Parameters.AddWithValue("@sno", Convert.ToInt16(txtServiceNo.Text));
                    cmd.Parameters.AddWithValue("@cno", Convert.ToInt16(txtCustomerNo.Text));
                    int a = cmd.ExecuteNonQuery();
                    if (a > 0)
                    {
                        MessageBox.Show("تم الغاء الاشتراك بنجاح", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        clearAll();
                    }
                    else
                        MessageBox.Show(" خطأ: لم يتم الغاء الاشتراك", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);


                    con.Close();

                }


            }
            catch (FormatException)
            {
                MessageBox.Show("الرجاء ادخال قيم قبل الاضافة", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show(" رقم الخدمة او رقم الزبون او كلاهما غير موجودان", "اضافة اشتراك", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1); txtServiceNo.Clear();
                txtCustomerNo.Clear();

            }
            catch (SqlException)
            {
                MessageBox.Show("هذا الاشتراك تمت اضافته سابقاً!, تأكد من رقم الخدمة او رقم الزبون", " الاشتراكات", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtServiceNo.Clear();
                txtCustomerNo.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير: حدث خطأ ما , الرجاء اعادة المحاولة", "تحذير ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }
        }

        private void btnDisplayAllCusts_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Customers ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnDisplayServices_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Services ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }
        private void btnShowSubs_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Subs ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void SubsForm_Load(object sender, EventArgs e)
        {
            mtxtStartDate.ValidatingType = typeof(System.DateTime);
            mtxtEndDate.ValidatingType = typeof(System.DateTime);

            
        }

        private void txtServiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtServiceNo, "!مطلوب ادخال رقم");
            }
            else
                errorProvider1.Clear();
        }

        private void txtServiceNo_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtServiceNo.Text, out number) == false || number <= 0)
            {
                errorProvider1.SetError(txtServiceNo, "الرجاء ادخال قيمة");
                txtServiceNo.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void txtCustomerNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(txtCustomerNo, "!مطلوب ادخال رقم");
            }
            else
                errorProvider1.Clear();

        }

        private void txtCustomerNo_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(txtCustomerNo.Text, out number) == false || number <= 0)
            {
                errorProvider1.SetError(txtCustomerNo, "الرجاء ادخال قيمة");
                txtCustomerNo.Focus();
            }
            else
                errorProvider1.Clear();

        }

        private void mtxtEndDate_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (e.IsValidInput == false)
            {
                errorProvider1.SetError(mtxtEndDate, "الرجاء ادخال تاريخ صحيح");
                e.Cancel = true; 
            }
            else
                errorProvider1.Clear();

        }

        private void mtxtStartDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(mtxtStartDate, "!مطلوب ادخال تاريخ");
            }
            else
                errorProvider1.Clear();

        }

        private void mtxtEndDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(mtxtEndDate, "!مطلوب ادخال تاريخ");
            }
            else
                errorProvider1.Clear();

        }

        private void mtxtStartDate_Leave(object sender, EventArgs e)
        {
            if (mtxtStartDate.MaskCompleted == false)
            {
                errorProvider1.SetError(mtxtStartDate, "مطلوب ادخال تاريخ");
                mtxtStartDate.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void mtxtEndDate_Leave(object sender, EventArgs e)
        {
            if (mtxtEndDate.MaskCompleted == false)
            {
                errorProvider1.SetError(mtxtEndDate, "مطلوب ادخال تاريخ");
                mtxtEndDate.Focus();
            }
            else
                errorProvider1.Clear();

        }

        private void mtxtStartDate_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (e.IsValidInput == false)
            {
                errorProvider1.SetError(mtxtStartDate, "الرجاء ادخال تاريخ صحيح");
                e.Cancel = true;
            }
            else
                errorProvider1.Clear();


        }

        private void btnShowCustsInServic_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select Customers.CustomerNo, CustomerName, Phone from Customers JOIN Subs ON Customers.CustomerNo = Subs.CustomerNo where ServiceNo = @sn ",con);


                cmd.Parameters.AddWithValue("@sn",Convert.ToInt16( txtServiceNo.Text));
                con.Open();
                cmd.ExecuteNonQuery();
             
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;
                

                con.Close();

            }
            catch (FormatException)
            {
                MessageBox.Show("الرجاء ادخال رقم الخدمة  ", " عرض اشتراكات", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            catch (SqlException)
            {
                MessageBox.Show("هذه الخدمة غير موجودة, الرجاء التحقق من الرقم المدخل", " عرض الاشتراكات", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtServiceNo.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير: حدث خطأ ما , الرجاء اعادة المحاولة", "تحذير ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }



        }

        private void btnShowSubsForCust_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("select Services.ServiceNo, ServiceName, Price from Services JOIN Subs ON Services.ServiceNo = Subs.ServiceNo where CustomerNo = @cn ", con);

                cmd.Parameters.AddWithValue("@cn", txtCustomerNo.Text);
                con.Open();
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dataGridView1.DataSource = dt;                

                con.Close();

            }
            catch (FormatException)
            {
                MessageBox.Show("الرجاء ادخال رقم الزبون  ", " اشتراكات زبون ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);

            }
            catch (SqlException)
            {
                MessageBox.Show("   هذا الزبون غير موجود  ", " اشتراكات زبون ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                txtCustomerNo.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("تحذير: حدث خطأ ما , الرجاء اعادة المحاولة", "تحذير ", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
            }


        }
    }
}
//Exit
