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
    public partial class PaymentsForm : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAMZA-PC;Initial Catalog=VP-Project;Integrated Security=True");

        public PaymentsForm()
        {
            InitializeComponent();
        }
        private void clearAll()
        {
            mtxtAmount.Clear();
            mtxtCustomerNo.Clear();
            mtxtDate.Clear();
            mtxtServiceNo.Clear();
        }

        private void btnCancelSub_Click(object sender, EventArgs e)
        {
            if (rbtnAddPayment.Checked == true)
            {

                try
                {
                    con.Open();
                SqlCommand cmd = new SqlCommand("insert into Payments values(@sno, @customerNo, @date, @amount, @PaymentType)", con);
                        cmd.Parameters.AddWithValue("@sno", Convert.ToInt16(mtxtServiceNo.Text));
                        cmd.Parameters.AddWithValue("@customerNo", Convert.ToInt16(mtxtCustomerNo.Text));
                        cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(mtxtDate.Text));
                        cmd.Parameters.AddWithValue("@amount", Convert.ToInt16(mtxtAmount.Text));
                        cmd.Parameters.AddWithValue("@PaymentType", txtPaymentType.Text);

                    DialogResult result = MessageBox.Show("هل انت متأكد من اضافة الدفعة؟", "اضافة دفعة", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                    if (result == DialogResult.Yes)
                    {
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("تم اضافة الدفعة بنجاح", " اضافة دفعة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            clearAll();
                        }
                        else
                            MessageBox.Show("خطأ: لم يتم اضافة الدفعة ", " اضافة دفعة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);


                        con.Close();
                    }


                }

                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال قيم الحقول المطلوبة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الدفعة مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtServiceNo.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("رقم الدفعة مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtServiceNo.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            if(rbtnBackPayment.Checked ==true)
            {
                try {
                    
                        con.Open();
                        SqlCommand cmd = new SqlCommand("insert into Payments values(@sno, @customerNo, @date, @amount,  @PaymentType)", con);
                        cmd.Parameters.AddWithValue("@sno", Convert.ToInt16(mtxtServiceNo.Text));
                        cmd.Parameters.AddWithValue("@customerNo", Convert.ToInt16(mtxtCustomerNo.Text));
                        cmd.Parameters.AddWithValue("@date", Convert.ToDateTime(mtxtDate.Text));
                        cmd.Parameters.AddWithValue("@amount", Convert.ToInt16(mtxtAmount.Text));
                        cmd.Parameters.AddWithValue("@PaymentType", txtPaymentType.Text);
                    DialogResult result = MessageBox.Show("هل انت متأكد من تسجيل ارجاع دفعة ؟", " ارجاع دفعة", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                        if (result == DialogResult.Yes)
                        {
                            int a = cmd.ExecuteNonQuery();
                            if (a > 0)
                            {
                                MessageBox.Show("تم تسجيل ارجاع الدفعة بنجاح", " ارجاع دفعة", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                clearAll();
                            }
                            else
                                MessageBox.Show("خطأ: لم يتم تسجيل ارجاع دفعة ", " ارجاع دفعة", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);


                            con.Close();
                        }
                    }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال قيم الحقول المطلوبة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الدفعة مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtServiceNo.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("رقم الدفعة مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    mtxtServiceNo.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
     
       
   
        private void btnShowSubs_Click_1(object sender, EventArgs e)
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

        private void btnDisplayServices_Click_1(object sender, EventArgs e)
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

        private void btnDisplayAllCusts_Click_1(object sender, EventArgs e)
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
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btnDisplayAllPayments_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Payments ", con);
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
       


        private void PaymentsForm_Load(object sender, EventArgs e)
        {
            mtxtDate.ValidatingType = typeof(System.DateTime); 

        }

        private void rbtnAddPayment_CheckedChanged(object sender, EventArgs e)
        {
            clearAll();
            lblTitle.Visible = true;
            lblTitle.Text = "الرجاء ادخال بيانات الدفعة";
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtPaymentType.Visible = true;
            mtxtServiceNo.Visible = true;
            mtxtCustomerNo.Visible = true;
            mtxtDate.Visible = true;
            mtxtAmount.Visible = true;
            txtPaymentType.Text = "دفعة اشتراك";
            label3.Text = "تاريخ الدفعة";
            btnCancelSub.Visible = true;
            btnCancelSub.Text = "تسجيل الدفعة";

            btnDisplayAllCusts.Visible = true;
            btnDisplayAllPayments.Visible = true;
            btnDisplayServices.Visible = true;
            btnShowSubs.Visible = true;
            
        }

        private void rbtnBackPayment_CheckedChanged(object sender, EventArgs e)
        {
            clearAll();
            lblTitle.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            txtPaymentType.Visible = true;
            mtxtServiceNo.Visible = true;
            mtxtCustomerNo.Visible = true;
            mtxtDate.Visible = true;
            mtxtAmount.Visible = true;
            txtPaymentType.Text = "ارجاع مبلغ";
            label3.Text = "تاريخ ارجاع الدفعة";
            btnCancelSub.Visible = true;
            btnCancelSub.Text = "تسجيل ارجاع دفعة";

            btnDisplayAllCusts.Visible = true;
            btnDisplayAllPayments.Visible = true;
            btnDisplayServices.Visible = true;
            btnShowSubs.Visible = true;



        }

        private void mtxtServiceNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                errorProvider1.SetError(mtxtServiceNo, "مطلوب ادخال رقم");
                mtxtServiceNo.Focus();

            }
            else
                errorProvider1.Clear();
        }

        private void mtxtServiceNo_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                errorProvider1.SetError(mtxtServiceNo, "مطلوب ادخال رقم");
                e.Handled = true;
            }
            else
                errorProvider1.Clear();
        }

        private void mtxtServiceNo_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(mtxtServiceNo.Text, out number) == false || number <= 0)
            {
                errorProvider1.SetError(mtxtServiceNo, "الرجاء ادخال قيمة");
                mtxtServiceNo.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void mtxtCustomerNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                errorProvider1.SetError(mtxtCustomerNo, "مطلوب ادخال رقم");
                e.Handled = true;
            }
            else
                errorProvider1.Clear();

        }

        private void mtxtCustomerNo_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(mtxtCustomerNo.Text, out number) == false || number <= 0)
            {
                errorProvider1.SetError(mtxtCustomerNo, "الرجاء ادخال قيمة");
                mtxtCustomerNo.Focus();
            }
            else
                errorProvider1.Clear();

        }

        private void mtxtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                errorProvider1.SetError(mtxtDate, "مطلوب ادخال تاريخ فقط");
                e.Handled = true;
            }
            else
                errorProvider1.Clear();
        }

        private void mtxtDate_Leave(object sender, EventArgs e)
        {
            if (mtxtDate.MaskCompleted == false)
            {
                errorProvider1.SetError(mtxtDate, "مطلوب ادخال تاريخ ");
                mtxtDate.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void mtxtDate_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (e.IsValidInput == false)
            {
                errorProvider1.SetError(mtxtDate, "الرجاء ادخال تاريخ صالح");
                e.Cancel = true;
            }
            else
                errorProvider1.Clear();
        }

        private void mtxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                errorProvider1.SetError(mtxtAmount, "مطلوب ادخال رقم");
                e.Handled = true;
            }
            else
                errorProvider1.Clear();

        }

        private void mtxtAmount_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(mtxtAmount.Text, out number) == false || number <= 0)
            {
                errorProvider1.SetError(mtxtAmount, "الرجاء ادخال قيمة");
                mtxtAmount.Focus();
            }
            else
                errorProvider1.Clear();

        }

       
    }
}
