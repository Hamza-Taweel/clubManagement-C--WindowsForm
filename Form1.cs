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
    public partial class frmCusts_Emps : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAMZA-PC;Initial Catalog=VP-Project;Integrated Security=True");

        public frmCusts_Emps()
        {
            InitializeComponent();
        }

     
        private void rbtnEmployees_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnEmployees.Checked ==true)
            {
                rbtnAdd.Checked = false;
                rbtnDelete.Checked = false;
                rbtnUpdate.Checked = false;
                rbtnDisplay.Checked = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnDisplay.Visible = false;
                btnUpdate.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                btnDisplayAllCusts.Visible = false;
                btnDisplayAllEmps.Visible = true;
               

                ManageGroup.Text = "ادارة بيانات الموظفين";
                ManageGroup.Visible = true; 
            }
        }

        private void rbtnCustomers_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCustomers.Checked == true)
            {
                rbtnAdd.Checked = false;
                rbtnDelete.Checked = false;
                rbtnUpdate.Checked = false;
                rbtnDisplay.Checked = false;
                textBox1.Visible = false;
                textBox2.Visible = false;
                textBox3.Visible = false;
                textBox4.Visible = false;
                textBox5.Visible = false;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                btnDisplay.Visible = false;
                btnUpdate.Visible = false;
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                btnDisplayAllCusts.Visible = true;
                btnDisplayAllEmps.Visible = false;
                rbtnDisplay.Text = "استعراض ملف زبون";


                ManageGroup.Text = "ادارة بيانات الزبائن";
                ManageGroup.Visible = true;

            }

        }
        private void rbtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEmployees.Checked == true) //Add Employee
            {


                if (btnDelete.Visible)
                    btnDelete.Visible = false;
                if (btnUpdate.Visible)
                    btnUpdate.Visible = false;
                if (btnDisplay.Visible)
                    btnDisplay.Visible = false;


                label1.Text = "رقم الموظف";
                label2.Text = "اسم الموظف";
                label3.Text = "المهنة";
                label4.Text = "الراتب";
                label5.Text = "رقم الهاتف ";

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                btnAdd.Text = "اضافة موظف";
                btnAdd.Visible = true;
            }
            if(rbtnCustomers.Checked ==true) //Add Customer
            {
                if (btnDelete.Visible)
                    btnDelete.Visible = false;
                if (btnUpdate.Visible)
                    btnUpdate.Visible = false;
                if (btnDisplay.Visible)
                    btnDisplay.Visible = false;

                label1.Text = "رقم الزبون ";
                label2.Text = "اسم الزبون";
                label5.Text = "رقم الهاتف";
                label1.Visible = true;
                label2.Visible = true;
                label5.Visible = true;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox5.Visible = true;

                btnAdd.Text = "اضافة زبون";
                btnAdd.Visible = true;
            }


        }

        private void rbtnDelete_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEmployees.Checked == true) //Delete Employee
            {
                if (textBox2.Visible)
                    textBox2.Visible = false;
                if (textBox3.Visible)
                    textBox3.Visible = false;
                if (textBox4.Visible)
                    textBox4.Visible = false;
                if (textBox5.Visible)
                    textBox5.Visible = false;
                if (btnAdd.Visible)
                    btnAdd.Visible = false;
                if (btnUpdate.Visible)
                    btnUpdate.Visible = false;
                if (btnDisplay.Visible)
                    btnDisplay.Visible = false;
                if (label2.Visible)
                    label2.Visible = false;
                if (label3.Visible)
                    label3.Visible = false;
                if (label4.Visible)
                    label4.Visible = false;
                if (label5.Visible)
                    label5.Visible = false;
               

                label1.Text = "رقم الموظف";
                textBox1.Visible = true;
                label1.Visible = true;
                btnDelete.Text = "حذف موظف بناءً على رقمه";
                btnDelete.Visible = true;
            }
            if(rbtnCustomers.Checked==true) //Delete Customer
            {
                if (textBox2.Visible)
                    textBox2.Visible = false;
                if (textBox3.Visible)
                    textBox3.Visible = false;
                if (btnAdd.Visible)
                    btnAdd.Visible = false;
                if (btnUpdate.Visible)
                    btnUpdate.Visible = false;
                if (btnDisplay.Visible)
                    btnDisplay.Visible = false;
                if (label2.Visible)
                    label2.Visible = false;
                if (label3.Visible)
                    label3.Visible = false;
                textBox5.Visible = false;
                label5.Visible = false;


                label1.Text = "رقم الزبون ";
                label1.Visible = true;
                textBox1.Visible = true; 
                btnDelete.Text = "حذف زبون";
                btnDelete.Visible = true;

            }

        }

        private void rbtnUpdate_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnEmployees.Checked == true) //Update Employee
            {
                if (btnDelete.Visible)
                    btnDelete.Visible = false;
                if (btnAdd.Visible)
                    btnAdd.Visible = false;
                if (btnDisplay.Visible)
                    btnDisplay.Visible = false;

                label1.Text = "رقم الموظف";
                label2.Text = "اسم الموظف";
                label3.Text = "المهنة";
                label4.Text = "الراتب";
                label5.Text = "رقم الهاتف ";

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox3.Visible = true;
                textBox4.Visible = true;
                textBox5.Visible = true;

                label1.Visible = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;

                btnUpdate.Text = "تعديل موظف";
                btnUpdate.Visible = true;
            }

            if(rbtnCustomers.Checked ==true)//Update Customer
            {
                if (btnDelete.Visible)
                    btnDelete.Visible = false;
                if (btnAdd.Visible)
                    btnAdd.Visible = false;
                if (btnDisplay.Visible)
                    btnDisplay.Visible = false;

                label1.Text = "رقم الزبون ";
                label2.Text = "اسم الزبون";
                label5.Text = "رقم الهاتف";
                label1.Visible = true;
                label2.Visible = true;
                label5.Visible = true;

                textBox1.Visible = true;
                textBox2.Visible = true;
                textBox5.Visible = true;

                btnUpdate.Text = "تعديل زبون";
                btnUpdate.Visible = true;


            }


        }
        private void rbtnDisplay_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            if (rbtnEmployees.Checked == true) //Display file for Employee
            {
                if (textBox2.Visible)
                    textBox2.Visible = false;
                if (textBox3.Visible)
                    textBox3.Visible = false;
                if (textBox4.Visible)
                    textBox4.Visible = false;
                if (textBox5.Visible)
                    textBox5.Visible = false;
                if (btnAdd.Visible)
                    btnAdd.Visible = false;
                if (btnUpdate.Visible)
                    btnUpdate.Visible = false;
                if (btnDelete.Visible)
                    btnDelete.Visible = false;
                if (label2.Visible)
                    label2.Visible = false;
                if (label3.Visible)
                    label3.Visible = false;
                if (label4.Visible)
                    label4.Visible = false;
                if (label5.Visible)
                    label5.Visible = false;


                label1.Text = "رقم الموظف";
                textBox1.Visible = true;
                label1.Visible = true;
                btnDisplay.Text = " استعراض ملف موظف";
                btnDisplay.Visible = true;
            }
            if(rbtnCustomers.Checked ==true) //Display file for Customer
            {
                if (textBox2.Visible)
                    textBox2.Visible = false;
                if (textBox3.Visible)
                    textBox3.Visible = false;
               
                if (btnAdd.Visible)
                    btnAdd.Visible = false;
                if (btnUpdate.Visible)
                    btnUpdate.Visible = false;
                if (btnDelete.Visible)
                    btnDelete.Visible = false;
                if (label2.Visible)
                    label2.Visible = false;
                if (label3.Visible)
                    label3.Visible = false;
             
                label1.Text = "رقم الزبون ";
                label1.Visible = true;
                textBox1.Visible = true;
                btnDisplay.Text = "استعراض ملف زبون";
                btnDisplay.Visible = true; 
            }
        }















        private void  clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (rbtnEmployees.Checked == true) //Add Employee in DB
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert  into Employees values (@Num, @Name, @Job, @Salary, @Phone)", con);
                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt16(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Job", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToInt16(textBox4.Text));
                    cmd.Parameters.AddWithValue("@Phone", textBox5.Text);
                    DialogResult result = MessageBox.Show("هل انت متأكد من عملية الاضافة؟", "حذف موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();
                        }

                        else
                            MessageBox.Show("!خطأ: لم تتم الاضافة بشكل ناجح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    con.Close();


                }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال قيم الحقول المطلوبة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch(SqlException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما ربما رقم الموظف الذي ادخلته موجود من قبل, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }




            }
            if (rbtnCustomers.Checked == true) //Add Customer in DB
            {
                try
            {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("insert  into Customers values (@Num, @Name, @Phone)", con);
                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt16(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBox5.Text);
                    DialogResult result = MessageBox.Show("هل انت متأكد من عملية الاضافة؟", "اضافة موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("تمت الاضافة بنجاح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();

                        }
                        else
                            MessageBox.Show("!خطأ: لم تتم الاضافة بشكل ناجح", "اضافة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    con.Close();
                }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال قيم الحقول المطلوبة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch(SqlException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما ربما رقم الزبون الذي ادخلته موجود من قبل, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            //clear();
            //////////textBox1.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (rbtnEmployees.Checked == true) //Delete Employee from DB
            {
                try
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from Employees where EmpNo = @Num", con);
                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt16(textBox1.Text));
                    DialogResult result = MessageBox.Show("هل انت متأكد من عملية الحذف؟", "حذف موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {

                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            ////textBox1.Focus();
                        }
                        else
                        {
                            MessageBox.Show("رقم الموظف خاطئ, الرجاء ادخال رقم موجود", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            ////textBox1.Focus();
                        }
                    }
                    con.Close();


                }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال قيم الحقول المطلوبة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch(SqlException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما ربما رقم الموظف الذي ادخلته موجود من قبل, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            if (rbtnCustomers.Checked == true) //Delete Customer from DB
            {

                try
            {
                
                    con.Open();
                    //SqlCommand cmd = new SqlCommand("delete from Customers where CustomerNo = @Num", con);
                    SqlCommand cmd = new SqlCommand("delete from Customers where CustomerNo = @Num", con);

                    cmd.Parameters.AddWithValue("@Num",Convert.ToInt16( textBox1.Text));
                    DialogResult result = MessageBox.Show("هل انت متأكد من عملية الحذف؟", "حذف زبون", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    int a = cmd.ExecuteNonQuery();

                    if (result == DialogResult.Yes)
                    {

                        if (a > 0)
                        {
                            MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            ////textBox1.Focus();

                        }
                        else
                        {
                            MessageBox.Show("رقم الزبون خاطئ, الرجاء ادخال رقم موجود", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                            ////textBox1.Focus();

                        }
                    }
                    con.Close();
           }
            catch (FormatException)
            {
                MessageBox.Show("الرجاء ادخال قيم الحقول المطلوبة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الزبون مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }

                catch (SqlException)
                {
                    MessageBox.Show("رقم الزبون مكرر09889, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما ربما رقم الزبون الذي ادخلته موجود من قبل, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }


            clear();
            ////////textBox1.Focus();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (rbtnEmployees.Checked == true) //Update Employee DB
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Employees set EmpName = @Name, Job=@Job, Salary = @Salary,Phone=@Phone where  EmpNo = @Num  ", con);
                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt16(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Job", textBox3.Text);
                    cmd.Parameters.AddWithValue("@Salary", Convert.ToInt16(textBox4.Text));
                    cmd.Parameters.AddWithValue("@Phone", textBox5.Text);
                    DialogResult result = MessageBox.Show("هل انت متأكد من عملية التحديث؟", "تحديث موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {

                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("تم التحديث بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();

                        }
                        else
                        {
                            MessageBox.Show("!خطأ:رقم الموظف الذي ادخلته غير موجود", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();
                        }
                    }
                    con.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال قيم الحقول المطلوبة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch(SqlException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();

                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما ربما رقم الموظف الذي ادخلته موجود من قبل, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (rbtnCustomers.Checked == true) //Update Customer DB
            {
                try
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("update Customers set CustomerName = @Name, Phone=@Phone where CustomerNo= @Num  ", con);
                    cmd.Parameters.AddWithValue("@Num", Convert.ToInt16(textBox1.Text));
                    cmd.Parameters.AddWithValue("@Name", textBox2.Text);
                    cmd.Parameters.AddWithValue("@Phone", textBox5.Text);
                    DialogResult result = MessageBox.Show("هل انت متأكد من عملية التحديث؟", "تحديث موظف", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {

                        int a = cmd.ExecuteNonQuery();
                        if (a > 0)
                        {
                            MessageBox.Show("تم التحديث بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            clear();

                        }
                        else
                        {
                            MessageBox.Show("!خطأ:رقم الزبون الذي ادخلته غير موجود", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Clear();

                        }
                    }
                    con.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال قيم الحقول المطلوبة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("رقم الموظف مكرر, الرجاء ادخال رقم غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما ربما رقم الزبون الذي ادخلته موجود من قبل, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
          
            //////textBox1.Focus();

        }

        private void ادارةبياناتالموظفينالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnDisplayAllCusts_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Close();
                btnDisplayAllCusts.Focus();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Customers ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dgv1.DataSource = dt;
                con.Close();

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDisplayAllCusts.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnDisplayAllEmps_Click(object sender, EventArgs e)
        {
            try
            {
                con.Close();
                btnDisplayAllEmps.Focus();
                con.Open();
                SqlCommand cmd = new SqlCommand("select * from Employees ", con);
                cmd.ExecuteNonQuery();
                SqlDataAdapter dp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);
                dgv1.DataSource = dt;
                con.Close();

            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnDisplayAllCusts.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void frmCusts_Emps_Load(object sender, EventArgs e)
        {
             
        }
        private void isEmpty(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            if (tb.Text == "")
            {
                errorProvider1.SetError(tb, "!الرجاء ادخال قيمة");
                tb.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            int number;
            if (int.TryParse(textBox1.Text, out number) == false || number <= 0)
            {
                errorProvider1.SetError(textBox1, "!الرجاء ادخال رقم");
                textBox1.Focus();
            }
            else
                errorProvider1.Clear(); 

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox2, "!الرجاء ادخال احرف فقط");
            }
            else
                errorProvider1.Clear();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox3, "!الرجاء ادخال احرف فقط");
            }
            else
                errorProvider1.Clear();

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            int salary;
            if (int.TryParse(textBox4.Text, out salary) == false || salary <= 0)
            {
                errorProvider1.SetError(textBox4, "!الرجاء ادخال رقم");
                textBox4.Focus();
            }
            else
                errorProvider1.Clear();

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
                errorProvider1.SetError(textBox5, "!الرجاء ادخال ارقام فقط");
            }
            else
                errorProvider1.Clear();

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            if (textBox5.MaskCompleted == false)
            {
                errorProvider1.SetError(textBox5, "!الرجاء ادخال رقم هاتف صالح");
                textBox5.Focus();
            }
            else
                errorProvider1.Clear();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (rbtnEmployees.Checked == true)
            {


                try
                {
                    //con.Close();
                    btnDisplayAllCusts.Focus();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Employees where EmpNo = @en ", con);
                    cmd.Parameters.AddWithValue("@en", Convert.ToInt16(textBox1.Text));
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dp.Fill(dt);
                    dgv1.DataSource = dt;
                    con.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال رقم الموظف ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الموظف غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }

                catch (SqlException)
                {
                    MessageBox.Show("رقم الموظف غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            if (rbtnCustomers.Checked==true)
            {
                try
                {
                    //con.Close();
                    btnDisplayAllCusts.Focus();
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select * from Customers where CustomerNo = @cn ", con);
                    cmd.Parameters.AddWithValue("@cn", Convert.ToInt16(textBox1.Text));
                    cmd.ExecuteNonQuery();
                    SqlDataAdapter dp = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dp.Fill(dt);
                    dgv1.DataSource = dt;
                    con.Close();

                }
                catch (FormatException)
                {
                    MessageBox.Show("الرجاء ادخال رقم الزبون ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("رقم الزبون غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch (SqlException)
                {
                    MessageBox.Show("رقم الزبون غير موجود", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Clear();
                }
                catch (Exception)
                {
                    MessageBox.Show("حدث خطأ ما, الرجاء اعادة المحاولة ", "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

        }
    }
}
