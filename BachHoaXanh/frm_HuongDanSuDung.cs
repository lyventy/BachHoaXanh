using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BachHoaXanh
{
    public partial class frm_HuongDanSuDung : Form
    {
        public frm_HuongDanSuDung()
        {
            InitializeComponent();
        }

        private void frm_HuongDanSuDung_Load(object sender, EventArgs e)
        {
            treeView1.ExpandAll();
        }
    }
}
