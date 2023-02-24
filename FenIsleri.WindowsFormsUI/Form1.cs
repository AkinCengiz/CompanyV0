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
    public partial class Form1 : Form
    {
        private IEmployeeService _employeeService;
        private IChiefdomService _chiefdomService;
        public Form1()
        {
            InitializeComponent();
            _employeeService = new EmployeeManager(new EfEmployeeDal());
            _chiefdomService = new ChiefdomManager(new EfChiefdomDal());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadEmployees();
            LoadChiefdoms();
        }

        private void LoadChiefdoms()
        {
            dgvEntity.DataSource = _chiefdomService.GetAll();
        }

        private void LoadEmployees()
        {
            dgvEntity.DataSource = _employeeService.GetAll();
        }

    }
}
