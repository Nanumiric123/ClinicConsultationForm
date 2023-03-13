namespace ClinicConsultationForm
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpDailyconsForm = new System.Windows.Forms.GroupBox();
            this.lblCancel = new System.Windows.Forms.Button();
            this.lblSave = new System.Windows.Forms.Button();
            this.txtNurse = new System.Windows.Forms.TextBox();
            this.lblNurseonDuty = new System.Windows.Forms.Label();
            this.ckSickBay = new System.Windows.Forms.CheckBox();
            this.rbUnfit = new System.Windows.Forms.RadioButton();
            this.rbFit = new System.Windows.Forms.RadioButton();
            this.txtRmk = new System.Windows.Forms.TextBox();
            this.lblRmks = new System.Windows.Forms.Label();
            this.txtTreat1 = new System.Windows.Forms.TextBox();
            this.lblTreatment = new System.Windows.Forms.Label();
            this.txtDiag = new System.Windows.Forms.TextBox();
            this.lblDiag = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.lblTemp = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.lblDate = new System.Windows.Forms.Label();
            this.txtEmpNum = new System.Windows.Forms.TextBox();
            this.lblBadgeNum = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gridDiagnosis = new System.Windows.Forms.DataGridView();
            this.DIAGNOSIS_NUMBER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIAGNOSIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgTreatment = new System.Windows.Forms.DataGridView();
            this.TREATMENT_NO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TREATMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CK_CLINIC = new System.Windows.Forms.CheckBox();
            this.grpDailyconsForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnosis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTreatment)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(430, 22);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(298, 37);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Consultation Form";
            // 
            // grpDailyconsForm
            // 
            this.grpDailyconsForm.Controls.Add(this.CK_CLINIC);
            this.grpDailyconsForm.Controls.Add(this.lblCancel);
            this.grpDailyconsForm.Controls.Add(this.lblSave);
            this.grpDailyconsForm.Controls.Add(this.txtNurse);
            this.grpDailyconsForm.Controls.Add(this.lblNurseonDuty);
            this.grpDailyconsForm.Controls.Add(this.ckSickBay);
            this.grpDailyconsForm.Controls.Add(this.rbUnfit);
            this.grpDailyconsForm.Controls.Add(this.rbFit);
            this.grpDailyconsForm.Controls.Add(this.txtRmk);
            this.grpDailyconsForm.Controls.Add(this.lblRmks);
            this.grpDailyconsForm.Controls.Add(this.txtTreat1);
            this.grpDailyconsForm.Controls.Add(this.lblTreatment);
            this.grpDailyconsForm.Controls.Add(this.txtDiag);
            this.grpDailyconsForm.Controls.Add(this.lblDiag);
            this.grpDailyconsForm.Controls.Add(this.txtTemp);
            this.grpDailyconsForm.Controls.Add(this.lblTemp);
            this.grpDailyconsForm.Controls.Add(this.txtDate);
            this.grpDailyconsForm.Controls.Add(this.lblDate);
            this.grpDailyconsForm.Controls.Add(this.txtEmpNum);
            this.grpDailyconsForm.Controls.Add(this.lblBadgeNum);
            this.grpDailyconsForm.Controls.Add(this.txtName);
            this.grpDailyconsForm.Controls.Add(this.lblName);
            this.grpDailyconsForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDailyconsForm.Location = new System.Drawing.Point(12, 83);
            this.grpDailyconsForm.Name = "grpDailyconsForm";
            this.grpDailyconsForm.Size = new System.Drawing.Size(547, 642);
            this.grpDailyconsForm.TabIndex = 0;
            this.grpDailyconsForm.TabStop = false;
            this.grpDailyconsForm.Text = "Daily Consultation Form";
            this.grpDailyconsForm.Paint += new System.Windows.Forms.PaintEventHandler(this.txtEmpNum_Paint);
            // 
            // lblCancel
            // 
            this.lblCancel.BackColor = System.Drawing.Color.LightGray;
            this.lblCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.ForeColor = System.Drawing.Color.White;
            this.lblCancel.Location = new System.Drawing.Point(412, 508);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(84, 38);
            this.lblCancel.TabIndex = 13;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.UseVisualStyleBackColor = false;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            this.lblCancel.Paint += new System.Windows.Forms.PaintEventHandler(this.lblCancel_Paint);
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lblSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.ForeColor = System.Drawing.Color.White;
            this.lblSave.Location = new System.Drawing.Point(267, 508);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(82, 38);
            this.lblSave.TabIndex = 12;
            this.lblSave.Text = "Save";
            this.lblSave.UseVisualStyleBackColor = false;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            this.lblSave.Paint += new System.Windows.Forms.PaintEventHandler(this.lblSave_Paint);
            this.lblSave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblSave_MouseDown);
            // 
            // txtNurse
            // 
            this.txtNurse.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNurse.Location = new System.Drawing.Point(136, 420);
            this.txtNurse.Name = "txtNurse";
            this.txtNurse.Size = new System.Drawing.Size(405, 19);
            this.txtNurse.TabIndex = 11;
            // 
            // lblNurseonDuty
            // 
            this.lblNurseonDuty.AutoSize = true;
            this.lblNurseonDuty.Location = new System.Drawing.Point(12, 419);
            this.lblNurseonDuty.Name = "lblNurseonDuty";
            this.lblNurseonDuty.Size = new System.Drawing.Size(122, 20);
            this.lblNurseonDuty.TabIndex = 0;
            this.lblNurseonDuty.Text = "Nurse on Duty : ";
            // 
            // ckSickBay
            // 
            this.ckSickBay.AutoSize = true;
            this.ckSickBay.Location = new System.Drawing.Point(39, 361);
            this.ckSickBay.Name = "ckSickBay";
            this.ckSickBay.Size = new System.Drawing.Size(89, 24);
            this.ckSickBay.TabIndex = 0;
            this.ckSickBay.TabStop = false;
            this.ckSickBay.Text = "Sick Bay";
            this.ckSickBay.UseVisualStyleBackColor = true;
            // 
            // rbUnfit
            // 
            this.rbUnfit.AutoSize = true;
            this.rbUnfit.Location = new System.Drawing.Point(182, 318);
            this.rbUnfit.Name = "rbUnfit";
            this.rbUnfit.Size = new System.Drawing.Size(124, 24);
            this.rbUnfit.TabIndex = 0;
            this.rbUnfit.Text = "Unfit To Work";
            this.rbUnfit.UseVisualStyleBackColor = true;
            this.rbUnfit.CheckedChanged += new System.EventHandler(this.rbUnfit_CheckedChanged);
            this.rbUnfit.Click += new System.EventHandler(this.rbUnfit_Click);
            // 
            // rbFit
            // 
            this.rbFit.AutoSize = true;
            this.rbFit.Location = new System.Drawing.Point(48, 318);
            this.rbFit.Name = "rbFit";
            this.rbFit.Size = new System.Drawing.Size(108, 24);
            this.rbFit.TabIndex = 0;
            this.rbFit.Text = "Fit To Work";
            this.rbFit.UseVisualStyleBackColor = true;
            this.rbFit.CheckedChanged += new System.EventHandler(this.rbFit_CheckedChanged);
            this.rbFit.Click += new System.EventHandler(this.rbFit_Click);
            // 
            // txtRmk
            // 
            this.txtRmk.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRmk.Location = new System.Drawing.Point(132, 272);
            this.txtRmk.Name = "txtRmk";
            this.txtRmk.Size = new System.Drawing.Size(410, 19);
            this.txtRmk.TabIndex = 10;
            // 
            // lblRmks
            // 
            this.lblRmks.AutoSize = true;
            this.lblRmks.Location = new System.Drawing.Point(44, 273);
            this.lblRmks.Name = "lblRmks";
            this.lblRmks.Size = new System.Drawing.Size(81, 20);
            this.lblRmks.TabIndex = 0;
            this.lblRmks.Text = "Remarks :";
            // 
            // txtTreat1
            // 
            this.txtTreat1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTreat1.Location = new System.Drawing.Point(131, 239);
            this.txtTreat1.Name = "txtTreat1";
            this.txtTreat1.Size = new System.Drawing.Size(410, 19);
            this.txtTreat1.TabIndex = 4;
            // 
            // lblTreatment
            // 
            this.lblTreatment.AutoSize = true;
            this.lblTreatment.Location = new System.Drawing.Point(35, 242);
            this.lblTreatment.Name = "lblTreatment";
            this.lblTreatment.Size = new System.Drawing.Size(90, 20);
            this.lblTreatment.TabIndex = 0;
            this.lblTreatment.Text = "Treatment :";
            // 
            // txtDiag
            // 
            this.txtDiag.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDiag.Location = new System.Drawing.Point(130, 200);
            this.txtDiag.Name = "txtDiag";
            this.txtDiag.Size = new System.Drawing.Size(130, 19);
            this.txtDiag.TabIndex = 3;
            // 
            // lblDiag
            // 
            this.lblDiag.AutoSize = true;
            this.lblDiag.Location = new System.Drawing.Point(34, 203);
            this.lblDiag.Name = "lblDiag";
            this.lblDiag.Size = new System.Drawing.Size(91, 20);
            this.lblDiag.TabIndex = 0;
            this.lblDiag.Text = "Diagnosis : ";
            // 
            // txtTemp
            // 
            this.txtTemp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTemp.Location = new System.Drawing.Point(130, 159);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(130, 19);
            this.txtTemp.TabIndex = 2;
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Location = new System.Drawing.Point(12, 165);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(112, 20);
            this.lblTemp.TabIndex = 0;
            this.lblTemp.Text = "Temperature : ";
            // 
            // txtDate
            // 
            this.txtDate.Enabled = false;
            this.txtDate.Location = new System.Drawing.Point(130, 121);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(130, 26);
            this.txtDate.TabIndex = 0;
            this.txtDate.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(68, 127);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(56, 20);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date : ";
            // 
            // txtEmpNum
            // 
            this.txtEmpNum.BackColor = System.Drawing.Color.White;
            this.txtEmpNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmpNum.Location = new System.Drawing.Point(130, 81);
            this.txtEmpNum.Name = "txtEmpNum";
            this.txtEmpNum.Size = new System.Drawing.Size(130, 19);
            this.txtEmpNum.TabIndex = 1;
            this.txtEmpNum.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpNum_KeyDown);
            // 
            // lblBadgeNum
            // 
            this.lblBadgeNum.AutoSize = true;
            this.lblBadgeNum.Location = new System.Drawing.Point(33, 84);
            this.lblBadgeNum.Name = "lblBadgeNum";
            this.lblBadgeNum.Size = new System.Drawing.Size(91, 20);
            this.lblBadgeNum.TabIndex = 0;
            this.lblBadgeNum.Text = "EMP NUM :";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(130, 43);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(411, 26);
            this.txtName.TabIndex = 0;
            this.txtName.TabStop = false;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(61, 46);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(63, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name : ";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // gridDiagnosis
            // 
            this.gridDiagnosis.AllowUserToAddRows = false;
            this.gridDiagnosis.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridDiagnosis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.gridDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDiagnosis.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DIAGNOSIS_NUMBER,
            this.DIAGNOSIS});
            this.gridDiagnosis.Location = new System.Drawing.Point(599, 95);
            this.gridDiagnosis.Name = "gridDiagnosis";
            this.gridDiagnosis.ReadOnly = true;
            this.gridDiagnosis.Size = new System.Drawing.Size(328, 605);
            this.gridDiagnosis.TabIndex = 1;
            // 
            // DIAGNOSIS_NUMBER
            // 
            this.DIAGNOSIS_NUMBER.DataPropertyName = "DIAGNOSIS_NUMBER";
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DIAGNOSIS_NUMBER.DefaultCellStyle = dataGridViewCellStyle8;
            this.DIAGNOSIS_NUMBER.HeaderText = "No. ";
            this.DIAGNOSIS_NUMBER.Name = "DIAGNOSIS_NUMBER";
            this.DIAGNOSIS_NUMBER.ReadOnly = true;
            this.DIAGNOSIS_NUMBER.Width = 35;
            // 
            // DIAGNOSIS
            // 
            this.DIAGNOSIS.DataPropertyName = "DIAGNOSIS";
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.DIAGNOSIS.DefaultCellStyle = dataGridViewCellStyle9;
            this.DIAGNOSIS.HeaderText = "DIAGNOSIS";
            this.DIAGNOSIS.Name = "DIAGNOSIS";
            this.DIAGNOSIS.ReadOnly = true;
            this.DIAGNOSIS.Width = 250;
            // 
            // dgTreatment
            // 
            this.dgTreatment.AllowUserToAddRows = false;
            this.dgTreatment.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgTreatment.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTreatment.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgTreatment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTreatment.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TREATMENT_NO,
            this.TREATMENT});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgTreatment.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgTreatment.Location = new System.Drawing.Point(959, 95);
            this.dgTreatment.Name = "dgTreatment";
            this.dgTreatment.ReadOnly = true;
            this.dgTreatment.Size = new System.Drawing.Size(328, 605);
            this.dgTreatment.TabIndex = 2;
            // 
            // TREATMENT_NO
            // 
            this.TREATMENT_NO.DataPropertyName = "TREATMENT_NO";
            this.TREATMENT_NO.HeaderText = "No. ";
            this.TREATMENT_NO.Name = "TREATMENT_NO";
            this.TREATMENT_NO.ReadOnly = true;
            this.TREATMENT_NO.Width = 35;
            // 
            // TREATMENT
            // 
            this.TREATMENT.DataPropertyName = "TREATMENT";
            this.TREATMENT.HeaderText = "TREATMENT";
            this.TREATMENT.Name = "TREATMENT";
            this.TREATMENT.ReadOnly = true;
            this.TREATMENT.Width = 250;
            // 
            // CK_CLINIC
            // 
            this.CK_CLINIC.AutoSize = true;
            this.CK_CLINIC.Location = new System.Drawing.Point(168, 361);
            this.CK_CLINIC.Name = "CK_CLINIC";
            this.CK_CLINIC.Size = new System.Drawing.Size(122, 24);
            this.CK_CLINIC.TabIndex = 14;
            this.CK_CLINIC.Text = "Send to clinic";
            this.CK_CLINIC.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1341, 737);
            this.Controls.Add(this.dgTreatment);
            this.Controls.Add(this.gridDiagnosis);
            this.Controls.Add(this.grpDailyconsForm);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpDailyconsForm.ResumeLayout(false);
            this.grpDailyconsForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDiagnosis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTreatment)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDailyconsForm;
        private System.Windows.Forms.Label lblBadgeNum;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.TextBox txtEmpNum;
        private System.Windows.Forms.RadioButton rbUnfit;
        private System.Windows.Forms.RadioButton rbFit;
        private System.Windows.Forms.TextBox txtRmk;
        private System.Windows.Forms.Label lblRmks;
        private System.Windows.Forms.TextBox txtTreat1;
        private System.Windows.Forms.Label lblTreatment;
        private System.Windows.Forms.TextBox txtDiag;
        private System.Windows.Forms.Label lblDiag;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.TextBox txtNurse;
        private System.Windows.Forms.Label lblNurseonDuty;
        private System.Windows.Forms.CheckBox ckSickBay;
        private System.Windows.Forms.DataGridView gridDiagnosis;
        private System.Windows.Forms.Button lblCancel;
        private System.Windows.Forms.Button lblSave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAGNOSIS_NUMBER;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIAGNOSIS;
        private System.Windows.Forms.DataGridView dgTreatment;
        private System.Windows.Forms.DataGridViewTextBoxColumn TREATMENT_NO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TREATMENT;
        private System.Windows.Forms.CheckBox CK_CLINIC;
    }
}

