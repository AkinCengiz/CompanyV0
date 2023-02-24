using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.ModelConfiguration.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FenIsleri.Business.Abstract;
using FenIsleri.Business.Concrete;
using FenIsleri.DataAccess.Concrete.EntityFramework;
using FenIsleri.Entities.Concrete;

namespace FenIsleri.WindowsFormsUI
{
    public partial class FrmMainForm : Form
    {
        private IEmployeeService _employeeService;
        private IChiefdomService _chiefdomService;
        private IStaffStatuService _staffStatuService;
        private IDegreeService _degreeService;
        private IDistrictService _districtService;
        private IDutyService _dutyService;
        public FrmMainForm()
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployeeDal());
            _chiefdomService = new ChiefdomManager(new EfChiefdomDal());
            _staffStatuService = new StaffStatuManager(new EfStaffStatuDal());
            _degreeService = new DegreeManager(new EfDegreeDal());
            _districtService = new DistrictManager(new EfDistrictDal());
            _dutyService = new DutyManager(new EfDutyDal());
        }

        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadChiefdoms();
            LoadStaffStatus();
            LoadDegrees();

        }

        private void LoadDegrees()
        {
            cbxDegree.DataSource = _degreeService.GetAll();
            cbxDegree.DisplayMember = "DegreeName";
            cbxDegree.ValueMember = "DegreeId";
        }

        private void LoadStaffStatus()
        {
            cbxStaffStatus.DataSource = _staffStatuService.GetAll();
            cbxStaffStatus.DisplayMember = "StaffName";
            cbxStaffStatus.ValueMember = "StaffStatuId";
        }

        private void LoadChiefdoms()
        {
            cbxChiefdom.DataSource = _chiefdomService.GetAll();
            cbxChiefdom.DisplayMember = "ChiefdomName";
            cbxChiefdom.ValueMember = "ChiefdomId";

        }

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = _employeeService.GetAll();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //_employeeService.Add(new Employee
            //{
            //    FirstName = tbxFirstName.Text,
            //    LastName = tbxLastName.Text,
            //    BirthDate = Convert.ToDateTime(dtpBirthDate.Text),
            //    WorkDate = Convert.ToDateTime(dtpWorkOfDate.Text),
            //    Phone = mtbxPhone.Text,
            //    Address = tbxAddress.Text,
            //    City = Convert.ToInt32(cbxCity.SelectedValue),
            //    Town = Convert.ToInt32(cbxTown.SelectedValue),
            //    IdentityNumber = mtbxIdentityNumber.Text,
            //    Degree = Convert.ToInt32(cmbDegree.SelectedValue),
            //    Duty = Convert.ToByte(cmbDuty.SelectedValue),
            //    StaffStatus = Convert.ToByte(cmbStaffStatus.SelectedValue),
            //    Chiefdom = Convert.ToByte(cbxChiefdom.SelectedValue)
            //});
            //LoadEmployees();
        }

    }
}
