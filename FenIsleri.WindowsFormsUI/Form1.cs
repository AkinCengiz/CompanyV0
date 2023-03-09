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
        //private IEmployeeService _employeeService;
        //private IChiefdomService _chiefdomService;
        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            //_employeeService = new EmployeeManager(new EfEmployeeDal());
            //_chiefdomService = new ChiefdomManager(new EfChiefdomDal());
        }

        public FrmPersonel frmPersonel;
        
        
        private void personelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (FrmPersonel.isClosed)
            {
                FrmPersonel.isClosed = false;
                frmPersonel = new FrmPersonel();
                frmPersonel.MdiParent = this;
            }
            frmPersonel.Show();
        }
    }
}
