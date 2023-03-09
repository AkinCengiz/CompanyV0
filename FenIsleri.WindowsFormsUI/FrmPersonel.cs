using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FenIsleri.Business.Abstract;
using FenIsleri.Business.Concrete;
using FenIsleri.DataAccess.Concrete.EntityFramework;

namespace FenIsleri.WindowsFormsUI
{
    public partial class FrmPersonel : Form
    {
        private IEmployeeService _employeeService;
        private IDegreeService _degreeService;
        private IDutyService _dutyService;
        private IStaffStatuService _staffStatuService;
        private IChiefdomService _chiefdomService;
        private ITownService _townService;
        private ICityService _cityService;

        
        public FrmPersonel()
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployeeDal());
            _degreeService = new DegreeManager(new EfDegreeDal());
            _dutyService = new DutyManager(new EfDutyDal());
            _staffStatuService = new StaffStatuManager(new EfStaffStatuDal());
            _chiefdomService = new ChiefdomManager(new EfChiefdomDal());
            _townService = new TownManager(new EfTownDal());
            _cityService = new CityManager(new EfCityDal());
        }

        public static bool isClosed = true;
        private void FrmPersonel_FormClosed(object sender, FormClosedEventArgs e)
        {
            isClosed = true;
        }

        private void FrmPersonel_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            Loadcities();
            LoadChiefdoms();
            LoadTowns();
            LoadDuties();
            LoadDegrees();
            LoadStaffStatus();
        }

        private void LoadStaffStatus()
        {
            cbxStaffStatus.DataSource = _staffStatuService.GetAll();
            cbxStaffStatus.DisplayMember = "StaffName";
            cbxStaffStatus.ValueMember = "StaffStatuID";
        }

        private void LoadDegrees()
        {
            cbxDegree.DataSource = _degreeService.GetAll();
            cbxDegree.DisplayMember = "DegreeName";
            cbxDegree.ValueMember = "DegreeID";
        }

        private void LoadDuties()
        {
            cbxDuty.DataSource = _dutyService.GetAll();
            cbxDuty.DisplayMember = "DutyName";
            cbxDuty.ValueMember = "DutyId";
        }

        private void LoadChiefdoms()
        {
            cbxChiefdom.DataSource = _chiefdomService.GetAll();
            cbxChiefdom.DisplayMember = "ChiefdomName";
            cbxChiefdom.ValueMember = "ChiefdomId";
        }

        private void LoadTowns()
        {
            cbxTown.DataSource = _townService.GetAll().Where(c => c.CityId == Convert.ToInt32(cbxCity.SelectedIndex+1))
                .ToList();
            cbxTown.DisplayMember = "TownName";
            cbxTown.ValueMember = "ID";
        }

        private void Loadcities()
        {
            cbxCity.DataSource = _cityService.GetAll();
            cbxCity.DisplayMember = "CityName";
            cbxCity.ValueMember = "ID";
        }

        private void LoadEmployees()
        {
            dgvEmployees.DataSource = _employeeService.GetAll();
        }

        private void cbxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTowns();
        }
    }
}
