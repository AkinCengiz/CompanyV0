namespace FenIsleri.WindowsFormsUI
{
    partial class FrmMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMainForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.lblID = new System.Windows.Forms.Label();
            this.lblIdentityNo = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.cbxDuty = new System.Windows.Forms.ComboBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.mtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.mtbxGSM = new System.Windows.Forms.MaskedTextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpWorkOfDate = new System.Windows.Forms.DateTimePicker();
            this.cbxDegree = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mtbxIdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxStaffStatus = new System.Windows.Forms.ComboBox();
            this.cbxChiefdom = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cbxTown = new System.Windows.Forms.ComboBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.bynUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.HotTrack = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnDelete);
            this.splitContainer1.Panel1.Controls.Add(this.bynUpdate);
            this.splitContainer1.Panel1.Controls.Add(this.btnAdd);
            this.splitContainer1.Panel1.Controls.Add(this.tbxAddress);
            this.splitContainer1.Panel1.Controls.Add(this.cbxCity);
            this.splitContainer1.Panel1.Controls.Add(this.cbxTown);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.label11);
            this.splitContainer1.Panel1.Controls.Add(this.cbxChiefdom);
            this.splitContainer1.Panel1.Controls.Add(this.cbxStaffStatus);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.lblDegree);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.mtbxIdentityNumber);
            this.splitContainer1.Panel1.Controls.Add(this.cbxDegree);
            this.splitContainer1.Panel1.Controls.Add(this.dtpWorkOfDate);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.lblLastName);
            this.splitContainer1.Panel1.Controls.Add(this.mtbxGSM);
            this.splitContainer1.Panel1.Controls.Add(this.mtbxPhone);
            this.splitContainer1.Panel1.Controls.Add(this.dtpBirthDate);
            this.splitContainer1.Panel1.Controls.Add(this.cbxDuty);
            this.splitContainer1.Panel1.Controls.Add(this.tbxLastName);
            this.splitContainer1.Panel1.Controls.Add(this.tbxFirstName);
            this.splitContainer1.Panel1.Controls.Add(this.tbxId);
            this.splitContainer1.Panel1.Controls.Add(this.lblFirstName);
            this.splitContainer1.Panel1.Controls.Add(this.lblIdentityNo);
            this.splitContainer1.Panel1.Controls.Add(this.lblID);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvEmployees);
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvEmployees, "dgvEmployees");
            this.dgvEmployees.Name = "dgvEmployees";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // lblIdentityNo
            // 
            resources.ApplyResources(this.lblIdentityNo, "lblIdentityNo");
            this.lblIdentityNo.Name = "lblIdentityNo";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            // 
            // tbxId
            // 
            resources.ApplyResources(this.tbxId, "tbxId");
            this.tbxId.Name = "tbxId";
            // 
            // tbxFirstName
            // 
            resources.ApplyResources(this.tbxFirstName, "tbxFirstName");
            this.tbxFirstName.Name = "tbxFirstName";
            // 
            // tbxLastName
            // 
            resources.ApplyResources(this.tbxLastName, "tbxLastName");
            this.tbxLastName.Name = "tbxLastName";
            // 
            // cbxDuty
            // 
            this.cbxDuty.FormattingEnabled = true;
            resources.ApplyResources(this.cbxDuty, "cbxDuty");
            this.cbxDuty.Name = "cbxDuty";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpBirthDate, "dtpBirthDate");
            this.dtpBirthDate.Name = "dtpBirthDate";
            // 
            // mtbxPhone
            // 
            resources.ApplyResources(this.mtbxPhone, "mtbxPhone");
            this.mtbxPhone.Name = "mtbxPhone";
            // 
            // mtbxGSM
            // 
            resources.ApplyResources(this.mtbxGSM, "mtbxGSM");
            this.mtbxGSM.Name = "mtbxGSM";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Name = "lblLastName";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // dtpWorkOfDate
            // 
            this.dtpWorkOfDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpWorkOfDate, "dtpWorkOfDate");
            this.dtpWorkOfDate.Name = "dtpWorkOfDate";
            // 
            // cbxDegree
            // 
            this.cbxDegree.FormattingEnabled = true;
            resources.ApplyResources(this.cbxDegree, "cbxDegree");
            this.cbxDegree.Name = "cbxDegree";
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.splitContainer1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            // 
            // mtbxIdentityNumber
            // 
            resources.ApplyResources(this.mtbxIdentityNumber, "mtbxIdentityNumber");
            this.mtbxIdentityNumber.Name = "mtbxIdentityNumber";
            this.mtbxIdentityNumber.ValidatingType = typeof(int);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblDegree
            // 
            resources.ApplyResources(this.lblDegree, "lblDegree");
            this.lblDegree.Name = "lblDegree";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // cbxStaffStatus
            // 
            this.cbxStaffStatus.FormattingEnabled = true;
            resources.ApplyResources(this.cbxStaffStatus, "cbxStaffStatus");
            this.cbxStaffStatus.Name = "cbxStaffStatus";
            // 
            // cbxChiefdom
            // 
            this.cbxChiefdom.FormattingEnabled = true;
            resources.ApplyResources(this.cbxChiefdom, "cbxChiefdom");
            this.cbxChiefdom.Name = "cbxChiefdom";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // cbxTown
            // 
            this.cbxTown.FormattingEnabled = true;
            resources.ApplyResources(this.cbxTown, "cbxTown");
            this.cbxTown.Name = "cbxTown";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            resources.ApplyResources(this.cbxCity, "cbxCity");
            this.cbxCity.Name = "cbxCity";
            // 
            // tbxAddress
            // 
            resources.ApplyResources(this.tbxAddress, "tbxAddress");
            this.tbxAddress.Name = "tbxAddress";
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // bynUpdate
            // 
            resources.ApplyResources(this.bynUpdate, "bynUpdate");
            this.bynUpdate.Name = "bynUpdate";
            this.bynUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmMainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button bynUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.ComboBox cbxTown;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cbxChiefdom;
        private System.Windows.Forms.ComboBox cbxStaffStatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblDegree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mtbxIdentityNumber;
        private System.Windows.Forms.ComboBox cbxDegree;
        private System.Windows.Forms.DateTimePicker dtpWorkOfDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.MaskedTextBox mtbxGSM;
        private System.Windows.Forms.MaskedTextBox mtbxPhone;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.ComboBox cbxDuty;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxId;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblIdentityNo;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView dgvEmployees;
        private System.Windows.Forms.TabPage tabPage2;
    }
}