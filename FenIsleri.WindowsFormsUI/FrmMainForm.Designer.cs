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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnDelete = new System.Windows.Forms.Button();
            this.bynUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.cbxTown = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cbxChiefdom = new System.Windows.Forms.ComboBox();
            this.cbxStaffStatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDegree = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mtbxIdentityNumber = new System.Windows.Forms.MaskedTextBox();
            this.cbxDegree = new System.Windows.Forms.ComboBox();
            this.dtpWorkOfDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.mtbxGSM = new System.Windows.Forms.MaskedTextBox();
            this.mtbxPhone = new System.Windows.Forms.MaskedTextBox();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.cbxDuty = new System.Windows.Forms.ComboBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxId = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblIdentityNo = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
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
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.splitContainer1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
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
            // btnDelete
            // 
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // bynUpdate
            // 
            resources.ApplyResources(this.bynUpdate, "bynUpdate");
            this.bynUpdate.Name = "bynUpdate";
            this.bynUpdate.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            resources.ApplyResources(this.btnAdd, "btnAdd");
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddress
            // 
            resources.ApplyResources(this.tbxAddress, "tbxAddress");
            this.tbxAddress.Name = "tbxAddress";
            // 
            // cbxCity
            // 
            this.cbxCity.FormattingEnabled = true;
            resources.ApplyResources(this.cbxCity, "cbxCity");
            this.cbxCity.Name = "cbxCity";
            // 
            // cbxTown
            // 
            this.cbxTown.FormattingEnabled = true;
            resources.ApplyResources(this.cbxTown, "cbxTown");
            this.cbxTown.Name = "cbxTown";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // cbxChiefdom
            // 
            this.cbxChiefdom.FormattingEnabled = true;
            resources.ApplyResources(this.cbxChiefdom, "cbxChiefdom");
            this.cbxChiefdom.Name = "cbxChiefdom";
            // 
            // cbxStaffStatus
            // 
            this.cbxStaffStatus.FormattingEnabled = true;
            resources.ApplyResources(this.cbxStaffStatus, "cbxStaffStatus");
            this.cbxStaffStatus.Name = "cbxStaffStatus";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // lblDegree
            // 
            resources.ApplyResources(this.lblDegree, "lblDegree");
            this.lblDegree.Name = "lblDegree";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // mtbxIdentityNumber
            // 
            resources.ApplyResources(this.mtbxIdentityNumber, "mtbxIdentityNumber");
            this.mtbxIdentityNumber.Name = "mtbxIdentityNumber";
            this.mtbxIdentityNumber.ValidatingType = typeof(int);
            // 
            // cbxDegree
            // 
            this.cbxDegree.FormattingEnabled = true;
            resources.ApplyResources(this.cbxDegree, "cbxDegree");
            this.cbxDegree.Name = "cbxDegree";
            // 
            // dtpWorkOfDate
            // 
            this.dtpWorkOfDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpWorkOfDate, "dtpWorkOfDate");
            this.dtpWorkOfDate.Name = "dtpWorkOfDate";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // lblLastName
            // 
            resources.ApplyResources(this.lblLastName, "lblLastName");
            this.lblLastName.Name = "lblLastName";
            // 
            // mtbxGSM
            // 
            resources.ApplyResources(this.mtbxGSM, "mtbxGSM");
            this.mtbxGSM.Name = "mtbxGSM";
            // 
            // mtbxPhone
            // 
            resources.ApplyResources(this.mtbxPhone, "mtbxPhone");
            this.mtbxPhone.Name = "mtbxPhone";
            // 
            // dtpBirthDate
            // 
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpBirthDate, "dtpBirthDate");
            this.dtpBirthDate.Name = "dtpBirthDate";
            // 
            // cbxDuty
            // 
            this.cbxDuty.FormattingEnabled = true;
            resources.ApplyResources(this.cbxDuty, "cbxDuty");
            this.cbxDuty.Name = "cbxDuty";
            // 
            // tbxLastName
            // 
            resources.ApplyResources(this.tbxLastName, "tbxLastName");
            this.tbxLastName.Name = "tbxLastName";
            // 
            // tbxFirstName
            // 
            resources.ApplyResources(this.tbxFirstName, "tbxFirstName");
            this.tbxFirstName.Name = "tbxFirstName";
            // 
            // tbxId
            // 
            resources.ApplyResources(this.tbxId, "tbxId");
            this.tbxId.Name = "tbxId";
            // 
            // lblFirstName
            // 
            resources.ApplyResources(this.lblFirstName, "lblFirstName");
            this.lblFirstName.Name = "lblFirstName";
            // 
            // lblIdentityNo
            // 
            resources.ApplyResources(this.lblIdentityNo, "lblIdentityNo");
            this.lblIdentityNo.Name = "lblIdentityNo";
            // 
            // lblID
            // 
            resources.ApplyResources(this.lblID, "lblID");
            this.lblID.Name = "lblID";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvEmployees.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dgvEmployees, "dgvEmployees");
            this.dgvEmployees.Name = "dgvEmployees";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
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
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
    }
}