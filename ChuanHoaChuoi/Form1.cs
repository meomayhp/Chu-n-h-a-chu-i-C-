using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChuanHoaChuoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnthuchien_Click(object sender, EventArgs e)
        {
            txtchuanhoa.Text = ChuanHoaChuoi.ChuanHoa(txtnhap.Text);
            txtsl.Text = ChuanHoaChuoi.DemSoTu(txtchuanhoa.Text).ToString();
            string []a = ChuanHoaChuoi.TachChuoi(txtchuanhoa.Text);
            for(int i=0;i<a.Count();i++)
            {
                txtds.Text += a[i] + Environment.NewLine;
            }
        }
    }
}
