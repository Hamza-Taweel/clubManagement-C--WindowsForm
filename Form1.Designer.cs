namespace Project_VP
{
    partial class frmCusts_Emps
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
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnCustomers = new System.Windows.Forms.RadioButton();
            this.rbtnEmployees = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.ManageGroup = new System.Windows.Forms.GroupBox();
            this.rbtnDisplay = new System.Windows.Forms.RadioButton();
            this.rbtnUpdate = new System.Windows.Forms.RadioButton();
            this.rbtnDelete = new System.Windows.Forms.RadioButton();
            this.rbtnAdd = new System.Windows.Forms.RadioButton();
            this.btnDisplayAllCusts = new System.Windows.Forms.Button();
            this.btnDisplayAllEmps = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBox5 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ManageGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv1
            // 
            this.dgv1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgv1.Location = new System.Drawing.Point(0, 0);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 26;
            this.dgv1.Size = new System.Drawing.Size(609, 733);
            this.dgv1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtnCustomers);
            this.groupBox1.Controls.Add(this.rbtnEmployees);
            this.groupBox1.Font = new System.Drawing.Font("Tempus Sans ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(615, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(718, 77);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ادارة بيانات المستخدمين";
            // 
            // rbtnCustomers
            // 
            this.rbtnCustomers.AutoSize = true;
            this.rbtnCustomers.Font = new System.Drawing.Font("Tempus Sans ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnCustomers.Location = new System.Drawing.Point(316, 43);
            this.rbtnCustomers.Name = "rbtnCustomers";
            this.rbtnCustomers.Size = new System.Drawing.Size(167, 28);
            this.rbtnCustomers.TabIndex = 2;
            this.rbtnCustomers.TabStop = true;
            this.rbtnCustomers.Text = "ادارة بيانات الزبائن";
            this.rbtnCustomers.UseVisualStyleBackColor = true;
            this.rbtnCustomers.CheckedChanged += new System.EventHandler(this.rbtnCustomers_CheckedChanged);
            // 
            // rbtnEmployees
            // 
            this.rbtnEmployees.AutoSize = true;
            this.rbtnEmployees.Font = new System.Drawing.Font("Tempus Sans ITC", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnEmployees.Location = new System.Drawing.Point(526, 43);
            this.rbtnEmployees.Name = "rbtnEmployees";
            this.rbtnEmployees.Size = new System.Drawing.Size(181, 28);
            this.rbtnEmployees.TabIndex = 0;
            this.rbtnEmployees.TabStop = true;
            this.rbtnEmployees.Text = "ادارة بيانات الموظفين";
            this.rbtnEmployees.UseVisualStyleBackColor = true;
            this.rbtnEmployees.CheckedChanged += new System.EventHandler(this.rbtnEmployees_CheckedChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(1134, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "lablel1";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(924, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(178, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Visible = false;
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(924, 270);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 24);
            this.textBox2.TabIndex = 1;
            this.textBox2.Visible = false;
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.textBox2.Leave += new System.EventHandler(this.isEmpty);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1134, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 37);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(924, 324);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(178, 24);
            this.textBox3.TabIndex = 2;
            this.textBox3.Visible = false;
            this.textBox3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.textBox3.Leave += new System.EventHandler(this.isEmpty);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1134, 318);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 37);
            this.label3.TabIndex = 6;
            this.label3.Text = "label3";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(924, 378);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(178, 24);
            this.textBox4.TabIndex = 3;
            this.textBox4.Visible = false;
            this.textBox4.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(1134, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(166, 37);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1134, 426);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 37);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Visible = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(1113, 506);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(206, 46);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "اضافة";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Visible = false;
            this.btnAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(1113, 506);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(206, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnUpdate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(1113, 506);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(206, 46);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "تعديل";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.ForeColor = System.Drawing.Color.White;
            this.btnDisplay.Location = new System.Drawing.Point(1113, 506);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(206, 46);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "استعراض";
            this.btnDisplay.UseVisualStyleBackColor = false;
            this.btnDisplay.Visible = false;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // ManageGroup
            // 
            this.ManageGroup.Controls.Add(this.rbtnDisplay);
            this.ManageGroup.Controls.Add(this.rbtnUpdate);
            this.ManageGroup.Controls.Add(this.rbtnDelete);
            this.ManageGroup.Controls.Add(this.rbtnAdd);
            this.ManageGroup.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ManageGroup.Location = new System.Drawing.Point(615, 136);
            this.ManageGroup.Name = "ManageGroup";
            this.ManageGroup.Size = new System.Drawing.Size(597, 55);
            this.ManageGroup.TabIndex = 16;
            this.ManageGroup.TabStop = false;
            this.ManageGroup.Text = "groupBox2";
            this.ManageGroup.Visible = false;
            // 
            // rbtnDisplay
            // 
            this.rbtnDisplay.AutoSize = true;
            this.rbtnDisplay.Location = new System.Drawing.Point(172, 21);
            this.rbtnDisplay.Name = "rbtnDisplay";
            this.rbtnDisplay.Size = new System.Drawing.Size(138, 21);
            this.rbtnDisplay.TabIndex = 3;
            this.rbtnDisplay.TabStop = true;
            this.rbtnDisplay.Text = "استعراض ملف موظف";
            this.rbtnDisplay.UseVisualStyleBackColor = true;
            this.rbtnDisplay.CheckedChanged += new System.EventHandler(this.rbtnDisplay_CheckedChanged);
            // 
            // rbtnUpdate
            // 
            this.rbtnUpdate.AutoSize = true;
            this.rbtnUpdate.Location = new System.Drawing.Point(346, 21);
            this.rbtnUpdate.Name = "rbtnUpdate";
            this.rbtnUpdate.Size = new System.Drawing.Size(54, 21);
            this.rbtnUpdate.TabIndex = 2;
            this.rbtnUpdate.TabStop = true;
            this.rbtnUpdate.Text = "تعديل";
            this.rbtnUpdate.UseVisualStyleBackColor = true;
            this.rbtnUpdate.CheckedChanged += new System.EventHandler(this.rbtnUpdate_CheckedChanged);
            // 
            // rbtnDelete
            // 
            this.rbtnDelete.AutoSize = true;
            this.rbtnDelete.Location = new System.Drawing.Point(436, 21);
            this.rbtnDelete.Name = "rbtnDelete";
            this.rbtnDelete.Size = new System.Drawing.Size(53, 21);
            this.rbtnDelete.TabIndex = 1;
            this.rbtnDelete.TabStop = true;
            this.rbtnDelete.Text = "حذف";
            this.rbtnDelete.UseVisualStyleBackColor = true;
            this.rbtnDelete.CheckedChanged += new System.EventHandler(this.rbtnDelete_CheckedChanged);
            // 
            // rbtnAdd
            // 
            this.rbtnAdd.AutoSize = true;
            this.rbtnAdd.Location = new System.Drawing.Point(525, 21);
            this.rbtnAdd.Name = "rbtnAdd";
            this.rbtnAdd.Size = new System.Drawing.Size(60, 21);
            this.rbtnAdd.TabIndex = 0;
            this.rbtnAdd.TabStop = true;
            this.rbtnAdd.Text = "اضافة";
            this.rbtnAdd.UseVisualStyleBackColor = true;
            this.rbtnAdd.CheckedChanged += new System.EventHandler(this.rbtnAdd_CheckedChanged);
            // 
            // btnDisplayAllCusts
            // 
            this.btnDisplayAllCusts.BackColor = System.Drawing.Color.Black;
            this.btnDisplayAllCusts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllCusts.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAllCusts.Location = new System.Drawing.Point(667, 662);
            this.btnDisplayAllCusts.Name = "btnDisplayAllCusts";
            this.btnDisplayAllCusts.Size = new System.Drawing.Size(189, 44);
            this.btnDisplayAllCusts.TabIndex = 17;
            this.btnDisplayAllCusts.Text = "عرض جميع الزبائن";
            this.btnDisplayAllCusts.UseVisualStyleBackColor = false;
            this.btnDisplayAllCusts.Visible = false;
            this.btnDisplayAllCusts.Click += new System.EventHandler(this.btnDisplayAllCusts_Click);
            // 
            // btnDisplayAllEmps
            // 
            this.btnDisplayAllEmps.BackColor = System.Drawing.Color.Black;
            this.btnDisplayAllEmps.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplayAllEmps.ForeColor = System.Drawing.Color.White;
            this.btnDisplayAllEmps.Location = new System.Drawing.Point(667, 662);
            this.btnDisplayAllEmps.Name = "btnDisplayAllEmps";
            this.btnDisplayAllEmps.Size = new System.Drawing.Size(189, 44);
            this.btnDisplayAllEmps.TabIndex = 6;
            this.btnDisplayAllEmps.Text = "عرض جميع الموظفين";
            this.btnDisplayAllEmps.UseVisualStyleBackColor = false;
            this.btnDisplayAllEmps.Visible = false;
            this.btnDisplayAllEmps.Click += new System.EventHandler(this.btnDisplayAllEmps_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(928, 439);
            this.textBox5.Mask = "\\05-000-000-0000";
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(172, 24);
            this.textBox5.TabIndex = 4;
            this.textBox5.Visible = false;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            this.textBox5.Leave += new System.EventHandler(this.textBox5_Leave);
            // 
            // frmCusts_Emps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1345, 733);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btnDisplayAllEmps);
            this.Controls.Add(this.btnDisplayAllCusts);
            this.Controls.Add(this.ManageGroup);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgv1);
            this.Name = "frmCusts_Emps";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "ادارة بيانات الطلاب والموظفين";
            this.Load += new System.EventHandler(this.frmCusts_Emps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ManageGroup.ResumeLayout(false);
            this.ManageGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbtnCustomers;
        private System.Windows.Forms.RadioButton rbtnEmployees;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.GroupBox ManageGroup;
        private System.Windows.Forms.RadioButton rbtnUpdate;
        private System.Windows.Forms.RadioButton rbtnDelete;
        private System.Windows.Forms.RadioButton rbtnAdd;
        private System.Windows.Forms.RadioButton rbtnDisplay;
        private System.Windows.Forms.Button btnDisplayAllCusts;
        private System.Windows.Forms.Button btnDisplayAllEmps;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.MaskedTextBox textBox5;
    }
}

