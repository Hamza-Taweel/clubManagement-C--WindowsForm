namespace Project_VP
{
    partial class SubsForm
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
            this.btnAddSub = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtServiceNo = new System.Windows.Forms.TextBox();
            this.txtCustomerNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.mtxtStartDate = new System.Windows.Forms.MaskedTextBox();
            this.mtxtEndDate = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rbtnShowCustsInService = new System.Windows.Forms.RadioButton();
            this.rbtnCancelSub = new System.Windows.Forms.RadioButton();
            this.rbtnAddSub = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnCancelSub = new System.Windows.Forms.Button();
            this.btnShowSubs = new System.Windows.Forms.Button();
            this.btnDisplayAllCusts = new System.Windows.Forms.Button();
            this.btnDisplayServices = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnShowSubsForCust = new System.Windows.Forms.Button();
            this.btnShowCustsInServic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddSub
            // 
            this.btnAddSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAddSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSub.ForeColor = System.Drawing.Color.White;
            this.btnAddSub.Location = new System.Drawing.Point(829, 453);
            this.btnAddSub.Name = "btnAddSub";
            this.btnAddSub.Size = new System.Drawing.Size(189, 44);
            this.btnAddSub.TabIndex = 1;
            this.btnAddSub.Text = "اضافة الاشتراك";
            this.btnAddSub.UseVisualStyleBackColor = false;
            this.btnAddSub.Visible = false;
            this.btnAddSub.Click += new System.EventHandler(this.btnAddSub_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 26;
            this.dataGridView1.Size = new System.Drawing.Size(401, 695);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(880, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "رقم الخدمة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // txtServiceNo
            // 
            this.txtServiceNo.Location = new System.Drawing.Point(687, 201);
            this.txtServiceNo.Name = "txtServiceNo";
            this.txtServiceNo.Size = new System.Drawing.Size(167, 24);
            this.txtServiceNo.TabIndex = 4;
            this.txtServiceNo.Visible = false;
            this.txtServiceNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtServiceNo_KeyPress);
            this.txtServiceNo.Leave += new System.EventHandler(this.txtServiceNo_Leave);
            // 
            // txtCustomerNo
            // 
            this.txtCustomerNo.Location = new System.Drawing.Point(687, 256);
            this.txtCustomerNo.Name = "txtCustomerNo";
            this.txtCustomerNo.Size = new System.Drawing.Size(167, 24);
            this.txtCustomerNo.TabIndex = 6;
            this.txtCustomerNo.Visible = false;
            this.txtCustomerNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerNo_KeyPress);
            this.txtCustomerNo.Leave += new System.EventHandler(this.txtCustomerNo_Leave);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(880, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 30);
            this.label2.TabIndex = 5;
            this.label2.Text = "رقم الزبون";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(880, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "تاريخ بداية الاشتراك";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            // 
            // mtxtStartDate
            // 
            this.mtxtStartDate.Location = new System.Drawing.Point(687, 311);
            this.mtxtStartDate.Mask = "00 /00 /0000";
            this.mtxtStartDate.Name = "mtxtStartDate";
            this.mtxtStartDate.Size = new System.Drawing.Size(167, 24);
            this.mtxtStartDate.TabIndex = 8;
            this.mtxtStartDate.ValidatingType = typeof(System.DateTime);
            this.mtxtStartDate.Visible = false;
            this.mtxtStartDate.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtStartDate_TypeValidationCompleted);
            this.mtxtStartDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtStartDate_KeyPress);
            this.mtxtStartDate.Leave += new System.EventHandler(this.mtxtStartDate_Leave);
            // 
            // mtxtEndDate
            // 
            this.mtxtEndDate.Location = new System.Drawing.Point(687, 366);
            this.mtxtEndDate.Mask = "00 /00 /0000";
            this.mtxtEndDate.Name = "mtxtEndDate";
            this.mtxtEndDate.Size = new System.Drawing.Size(167, 24);
            this.mtxtEndDate.TabIndex = 10;
            this.mtxtEndDate.ValidatingType = typeof(System.DateTime);
            this.mtxtEndDate.Visible = false;
            this.mtxtEndDate.TypeValidationCompleted += new System.Windows.Forms.TypeValidationEventHandler(this.mtxtEndDate_TypeValidationCompleted);
            this.mtxtEndDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mtxtEndDate_KeyPress);
            this.mtxtEndDate.Leave += new System.EventHandler(this.mtxtEndDate_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(880, 363);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 30);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاريخ نهاية الاشتراك";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.rbtnShowCustsInService);
            this.groupBox1.Controls.Add(this.rbtnCancelSub);
            this.groupBox1.Controls.Add(this.rbtnAddSub);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(420, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(639, 72);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "الاشتراكات";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 29);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(180, 27);
            this.radioButton2.TabIndex = 20;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "عرض اشتراكات لزبون";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // rbtnShowCustsInService
            // 
            this.rbtnShowCustsInService.AutoSize = true;
            this.rbtnShowCustsInService.Location = new System.Drawing.Point(194, 29);
            this.rbtnShowCustsInService.Name = "rbtnShowCustsInService";
            this.rbtnShowCustsInService.Size = new System.Drawing.Size(185, 27);
            this.rbtnShowCustsInService.TabIndex = 19;
            this.rbtnShowCustsInService.TabStop = true;
            this.rbtnShowCustsInService.Text = "عرض زبائن في اشتراك";
            this.rbtnShowCustsInService.UseVisualStyleBackColor = true;
            this.rbtnShowCustsInService.CheckedChanged += new System.EventHandler(this.rbtnShowCustsInService_CheckedChanged);
            // 
            // rbtnCancelSub
            // 
            this.rbtnCancelSub.AutoSize = true;
            this.rbtnCancelSub.Location = new System.Drawing.Point(387, 29);
            this.rbtnCancelSub.Name = "rbtnCancelSub";
            this.rbtnCancelSub.Size = new System.Drawing.Size(111, 27);
            this.rbtnCancelSub.TabIndex = 1;
            this.rbtnCancelSub.TabStop = true;
            this.rbtnCancelSub.Text = "الغاء اشتراك";
            this.rbtnCancelSub.UseVisualStyleBackColor = true;
            this.rbtnCancelSub.CheckedChanged += new System.EventHandler(this.rbtnCancelSub_CheckedChanged);
            // 
            // rbtnAddSub
            // 
            this.rbtnAddSub.AutoSize = true;
            this.rbtnAddSub.Location = new System.Drawing.Point(506, 29);
            this.rbtnAddSub.Name = "rbtnAddSub";
            this.rbtnAddSub.Size = new System.Drawing.Size(116, 27);
            this.rbtnAddSub.TabIndex = 0;
            this.rbtnAddSub.TabStop = true;
            this.rbtnAddSub.Text = "انشاء اشتراك";
            this.rbtnAddSub.UseVisualStyleBackColor = true;
            this.rbtnAddSub.CheckedChanged += new System.EventHandler(this.rbtnAddSub_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(434, 117);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(601, 30);
            this.lblTitle.TabIndex = 12;
            this.lblTitle.Text = "الرجاء ادخال بيانات الاشتراك";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.Visible = false;
            // 
            // btnCancelSub
            // 
            this.btnCancelSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelSub.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelSub.ForeColor = System.Drawing.Color.White;
            this.btnCancelSub.Location = new System.Drawing.Point(829, 453);
            this.btnCancelSub.Name = "btnCancelSub";
            this.btnCancelSub.Size = new System.Drawing.Size(189, 44);
            this.btnCancelSub.TabIndex = 13;
            this.btnCancelSub.Text = "الغاء الاشتراك";
            this.btnCancelSub.UseVisualStyleBackColor = false;
            this.btnCancelSub.Visible = false;
            this.btnCancelSub.Click += new System.EventHandler(this.btnCancelSub_Click);
            // 
            // btnShowSubs
            // 
            this.btnShowSubs.BackColor = System.Drawing.Color.Black;
            this.btnShowSubs.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSubs.ForeColor = System.Drawing.Color.White;
            this.btnShowSubs.Location = new System.Drawing.Point(855, 626);
            this.btnShowSubs.Name = "btnShowSubs";
            this.btnShowSubs.Size = new System.Drawing.Size(189, 44);
            this.btnShowSubs.TabIndex = 0;
            this.btnShowSubs.Text = "عرض جميع الاشتراكات";
            this.btnShowSubs.UseVisualStyleBackColor = false;
            this.btnShowSubs.Visible = false;
            this.btnShowSubs.Click += new System.EventHandler(this.btnShowSubs_Click);
            // 
            // btnDisplayAllCusts
            // 
            this.btnDisplayAllCusts.BackColor = System.Drawing.Color.Black;
            this.btnDisplayAllCusts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllCusts.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAllCusts.Location = new System.Drawing.Point(461, 626);
            this.btnDisplayAllCusts.Name = "btnDisplayAllCusts";
            this.btnDisplayAllCusts.Size = new System.Drawing.Size(189, 44);
            this.btnDisplayAllCusts.TabIndex = 15;
            this.btnDisplayAllCusts.Text = "عرض جميع الزبائن";
            this.btnDisplayAllCusts.UseVisualStyleBackColor = false;
            this.btnDisplayAllCusts.Visible = false;
            this.btnDisplayAllCusts.Click += new System.EventHandler(this.btnDisplayAllCusts_Click);
            // 
            // btnDisplayServices
            // 
            this.btnDisplayServices.BackColor = System.Drawing.Color.Black;
            this.btnDisplayServices.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayServices.ForeColor = System.Drawing.Color.White;
            this.btnDisplayServices.Location = new System.Drawing.Point(660, 626);
            this.btnDisplayServices.Name = "btnDisplayServices";
            this.btnDisplayServices.Size = new System.Drawing.Size(189, 44);
            this.btnDisplayServices.TabIndex = 16;
            this.btnDisplayServices.Text = "عرض جميع الخدمات";
            this.btnDisplayServices.UseVisualStyleBackColor = false;
            this.btnDisplayServices.Visible = false;
            this.btnDisplayServices.Click += new System.EventHandler(this.btnDisplayServices_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnShowSubsForCust
            // 
            this.btnShowSubsForCust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShowSubsForCust.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowSubsForCust.ForeColor = System.Drawing.Color.White;
            this.btnShowSubsForCust.Location = new System.Drawing.Point(807, 503);
            this.btnShowSubsForCust.Name = "btnShowSubsForCust";
            this.btnShowSubsForCust.Size = new System.Drawing.Size(218, 44);
            this.btnShowSubsForCust.TabIndex = 18;
            this.btnShowSubsForCust.Text = "عرض الاشتراكات لزبون";
            this.btnShowSubsForCust.UseVisualStyleBackColor = false;
            this.btnShowSubsForCust.Visible = false;
            this.btnShowSubsForCust.Click += new System.EventHandler(this.btnShowSubsForCust_Click);
            // 
            // btnShowCustsInServic
            // 
            this.btnShowCustsInServic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnShowCustsInServic.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowCustsInServic.ForeColor = System.Drawing.Color.White;
            this.btnShowCustsInServic.Location = new System.Drawing.Point(810, 503);
            this.btnShowCustsInServic.Name = "btnShowCustsInServic";
            this.btnShowCustsInServic.Size = new System.Drawing.Size(218, 44);
            this.btnShowCustsInServic.TabIndex = 17;
            this.btnShowCustsInServic.Text = "عرض زبائن اشتراك معين";
            this.btnShowCustsInServic.UseVisualStyleBackColor = false;
            this.btnShowCustsInServic.Visible = false;
            this.btnShowCustsInServic.Click += new System.EventHandler(this.btnShowCustsInServic_Click);
            // 
            // SubsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 695);
            this.Controls.Add(this.btnShowSubsForCust);
            this.Controls.Add(this.btnShowCustsInServic);
            this.Controls.Add(this.btnDisplayServices);
            this.Controls.Add(this.btnDisplayAllCusts);
            this.Controls.Add(this.btnCancelSub);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.mtxtEndDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtxtStartDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCustomerNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtServiceNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddSub);
            this.Controls.Add(this.btnShowSubs);
            this.Name = "SubsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "SubsForm";
            this.Load += new System.EventHandler(this.SubsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddSub;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtServiceNo;
        private System.Windows.Forms.TextBox txtCustomerNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox mtxtStartDate;
        private System.Windows.Forms.MaskedTextBox mtxtEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCancelSub;
        private System.Windows.Forms.RadioButton rbtnAddSub;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnCancelSub;
        private System.Windows.Forms.Button btnShowSubs;
        private System.Windows.Forms.Button btnDisplayAllCusts;
        private System.Windows.Forms.Button btnDisplayServices;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rbtnShowCustsInService;
        private System.Windows.Forms.Button btnShowSubsForCust;
        private System.Windows.Forms.Button btnShowCustsInServic;
    }
}