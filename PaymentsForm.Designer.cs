namespace Project_VP
{
    partial class PaymentsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtxtDate = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancelSub = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnShowSubs = new System.Windows.Forms.Button();
            this.btnDisplayServices = new System.Windows.Forms.Button();
            this.btnDisplayAllCusts = new System.Windows.Forms.Button();
            this.btnDisplayAllPayments = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnBackPayment = new System.Windows.Forms.RadioButton();
            this.rbtnAddPayment = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.mtxtServiceNo = new System.Windows.Forms.TextBox();
            this.mtxtCustomerNo = new System.Windows.Forms.TextBox();
            this.mtxtAmount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPaymentType = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1098, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "رقم الزبون";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1098, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 7;
            this.label1.Text = "رقم الدفعة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // mtxtDate
            // 
            this.mtxtDate.Location = new System.Drawing.Point(905, 297);
            this.mtxtDate.Mask = "00 /00 /0000";
            this.mtxtDate.Name = "mtxtDate";
            this.mtxtDate.Size = new System.Drawing.Size(167, 24);
            this.mtxtDate.TabIndex = 2;
            this.mtxtDate.ValidatingType = typeof(System.DateTime);
            this.mtxtDate.Visible = false;
            this.mtxtDate.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtDate_TypeValidationCompleted);
            this.mtxtDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtDate_KeyPress);
            this.mtxtDate.Leave += new System.EventHandler(this.mtxtDate_Leave);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1098, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 11;
            this.label3.Text = "تاريخ الدفعة";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1098, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 30);
            this.label4.TabIndex = 13;
            this.label4.Text = "المبلغ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(516, 709);
            this.dataGridView1.TabIndex = 17;
            // 
            // btnCancelSub
            // 
            this.btnCancelSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSub.ForeColor = System.Drawing.Color.White;
            this.btnCancelSub.Location = new System.Drawing.Point(1056, 501);
            this.btnCancelSub.Name = "btnCancelSub";
            this.btnCancelSub.Size = new System.Drawing.Size(189, 44);
            this.btnCancelSub.TabIndex = 4;
            this.btnCancelSub.Text = "تسجيل الدفعة";
            this.btnCancelSub.UseVisualStyleBackColor = false;
            this.btnCancelSub.Visible = false;
            this.btnCancelSub.Click += new System.EventHandler(this.btnCancelSub_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(597, 120);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(601, 30);
            this.lblTitle.TabIndex = 19;
            this.lblTitle.Text = "الرجاء ادخال بيانات الدفعة";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // btnShowSubs
            // 
            this.btnShowSubs.BackColor = System.Drawing.Color.Black;
            this.btnShowSubs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSubs.ForeColor = System.Drawing.Color.White;
            this.btnShowSubs.Location = new System.Drawing.Point(1111, 635);
            this.btnShowSubs.Name = "btnShowSubs";
            this.btnShowSubs.Size = new System.Drawing.Size(154, 44);
            this.btnShowSubs.TabIndex = 5;
            this.btnShowSubs.Text = "عرض الاشتراكات";
            this.btnShowSubs.UseVisualStyleBackColor = false;
            this.btnShowSubs.Visible = false;
            this.btnShowSubs.Click += new System.EventHandler(this.btnShowSubs_Click_1);
            // 
            // btnDisplayServices
            // 
            this.btnDisplayServices.BackColor = System.Drawing.Color.Black;
            this.btnDisplayServices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayServices.ForeColor = System.Drawing.Color.White;
            this.btnDisplayServices.Location = new System.Drawing.Point(951, 635);
            this.btnDisplayServices.Name = "btnDisplayServices";
            this.btnDisplayServices.Size = new System.Drawing.Size(154, 44);
            this.btnDisplayServices.TabIndex = 6;
            this.btnDisplayServices.Text = "عرض الخدمات";
            this.btnDisplayServices.UseVisualStyleBackColor = false;
            this.btnDisplayServices.Visible = false;
            this.btnDisplayServices.Click += new System.EventHandler(this.btnDisplayServices_Click_1);
            // 
            // btnDisplayAllCusts
            // 
            this.btnDisplayAllCusts.BackColor = System.Drawing.Color.Black;
            this.btnDisplayAllCusts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllCusts.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAllCusts.Location = new System.Drawing.Point(791, 635);
            this.btnDisplayAllCusts.Name = "btnDisplayAllCusts";
            this.btnDisplayAllCusts.Size = new System.Drawing.Size(154, 44);
            this.btnDisplayAllCusts.TabIndex = 7;
            this.btnDisplayAllCusts.Text = "عرض الزبائن";
            this.btnDisplayAllCusts.UseVisualStyleBackColor = false;
            this.btnDisplayAllCusts.Visible = false;
            this.btnDisplayAllCusts.Click += new System.EventHandler(this.btnDisplayAllCusts_Click_1);
            // 
            // btnDisplayAllPayments
            // 
            this.btnDisplayAllPayments.BackColor = System.Drawing.Color.Black;
            this.btnDisplayAllPayments.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllPayments.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAllPayments.Location = new System.Drawing.Point(522, 635);
            this.btnDisplayAllPayments.Name = "btnDisplayAllPayments";
            this.btnDisplayAllPayments.Size = new System.Drawing.Size(253, 44);
            this.btnDisplayAllPayments.TabIndex = 8;
            this.btnDisplayAllPayments.Text = "عرض الدفعات";
            this.btnDisplayAllPayments.UseVisualStyleBackColor = false;
            this.btnDisplayAllPayments.Visible = false;
            this.btnDisplayAllPayments.Click += new System.EventHandler(this.btnDisplayAllPayments_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnBackPayment);
            this.groupBox1.Controls.Add(this.rbtnAddPayment);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(569, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 72);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ادارة الدفعات المالية";
            // 
            // rbtnBackPayment
            // 
            this.rbtnBackPayment.AutoSize = true;
            this.rbtnBackPayment.Location = new System.Drawing.Point(143, 29);
            this.rbtnBackPayment.Name = "rbtnBackPayment";
            this.rbtnBackPayment.Size = new System.Drawing.Size(192, 27);
            this.rbtnBackPayment.TabIndex = 1;
            this.rbtnBackPayment.TabStop = true;
            this.rbtnBackPayment.Text = "تسجيل ارجاع مبلغ لزبون";
            this.rbtnBackPayment.UseVisualStyleBackColor = true;
            this.rbtnBackPayment.CheckedChanged += new System.EventHandler(this.rbtnBackPayment_CheckedChanged);
            // 
            // rbtnAddPayment
            // 
            this.rbtnAddPayment.AutoSize = true;
            this.rbtnAddPayment.Location = new System.Drawing.Point(378, 29);
            this.rbtnAddPayment.Name = "rbtnAddPayment";
            this.rbtnAddPayment.Size = new System.Drawing.Size(194, 27);
            this.rbtnAddPayment.TabIndex = 0;
            this.rbtnAddPayment.TabStop = true;
            this.rbtnAddPayment.Text = "تسجيل دفعة اشتراك زبون";
            this.rbtnAddPayment.UseVisualStyleBackColor = true;
            this.rbtnAddPayment.CheckedChanged += new System.EventHandler(this.rbtnAddPayment_CheckedChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // mtxtServiceNo
            // 
            this.mtxtServiceNo.Location = new System.Drawing.Point(905, 193);
            this.mtxtServiceNo.Name = "mtxtServiceNo";
            this.mtxtServiceNo.Size = new System.Drawing.Size(167, 24);
            this.mtxtServiceNo.TabIndex = 0;
            this.mtxtServiceNo.Visible = false;
            this.mtxtServiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtServiceNo_KeyPress_1);
            this.mtxtServiceNo.Leave += new System.EventHandler(this.mtxtServiceNo_Leave);
            // 
            // mtxtCustomerNo
            // 
            this.mtxtCustomerNo.Location = new System.Drawing.Point(905, 248);
            this.mtxtCustomerNo.Name = "mtxtCustomerNo";
            this.mtxtCustomerNo.Size = new System.Drawing.Size(167, 24);
            this.mtxtCustomerNo.TabIndex = 1;
            this.mtxtCustomerNo.Visible = false;
            this.mtxtCustomerNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtCustomerNo_KeyPress);
            this.mtxtCustomerNo.Leave += new System.EventHandler(this.mtxtCustomerNo_Leave);
            // 
            // mtxtAmount
            // 
            this.mtxtAmount.Location = new System.Drawing.Point(905, 347);
            this.mtxtAmount.Name = "mtxtAmount";
            this.mtxtAmount.Size = new System.Drawing.Size(167, 24);
            this.mtxtAmount.TabIndex = 3;
            this.mtxtAmount.Visible = false;
            this.mtxtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtAmount_KeyPress);
            this.mtxtAmount.Leave += new System.EventHandler(this.mtxtAmount_Leave);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1098, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 30);
            this.label5.TabIndex = 27;
            this.label5.Text = "نوع الدفعة";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // txtPaymentType
            // 
            this.txtPaymentType.Enabled = false;
            this.txtPaymentType.Location = new System.Drawing.Point(905, 402);
            this.txtPaymentType.Name = "txtPaymentType";
            this.txtPaymentType.Size = new System.Drawing.Size(167, 24);
            this.txtPaymentType.TabIndex = 28;
            this.txtPaymentType.Visible = false;
            // 
            // PaymentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 709);
            this.Controls.Add(this.txtPaymentType);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.mtxtAmount);
            this.Controls.Add(this.mtxtCustomerNo);
            this.Controls.Add(this.mtxtServiceNo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDisplayAllPayments);
            this.Controls.Add(this.btnDisplayAllCusts);
            this.Controls.Add(this.btnDisplayServices);
            this.Controls.Add(this.btnShowSubs);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnCancelSub);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PaymentsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "PaymentsForm";
            this.Load += new System.EventHandler(this.PaymentsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtxtDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelSub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnShowSubs;
        private System.Windows.Forms.Button btnDisplayServices;
        private System.Windows.Forms.Button btnDisplayAllCusts;
        private System.Windows.Forms.Button btnDisplayAllPayments;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnBackPayment;
        private System.Windows.Forms.RadioButton rbtnAddPayment;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox mtxtServiceNo;
        private System.Windows.Forms.TextBox mtxtCustomerNo;
        private System.Windows.Forms.TextBox mtxtAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPaymentType;
    }
}