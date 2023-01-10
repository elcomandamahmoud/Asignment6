using Asignment6.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asignment6
{
    public partial class FRMEmployees : Form
    {
        public FRMEmployees()
        {
            InitializeComponent();
        }
        
        private void BTNExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BTNAdd_Click(object sender, EventArgs e)
        {
            new MyFuntions().Add(TXTID.Text.Trim()+";",TXTName.Text.Trim()+";",TXTPhone.Text.Trim()+";",TXTAddress.Text.Trim()  );
            MessageBox.Show("تم حفظ البيانات بنجاح")    ;
            TXTID.Focus();
        }

        private void BTNClear_Click(object sender, EventArgs e)
        {
            TXTID.Clear();
            TXTName.Clear();
            TXTPhone.Clear();
            TXTAddress.Clear();
            BTNEdit.Enabled = false;
            BTNDelete.Enabled = false;
            TXTID.Focus();
        }
                    }
}
