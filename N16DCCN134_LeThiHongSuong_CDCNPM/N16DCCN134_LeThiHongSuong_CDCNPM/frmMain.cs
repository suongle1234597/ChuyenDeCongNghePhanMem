using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N16DCCN134_LeThiHongSuong_CDCNPM
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }

        private void btnGiaoDich_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmGiaoDich));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmGD = new frmGiaoDich();
                Program.frmGD.MdiParent = this;
                Program.frmGD.Show();
            }
        }

        private void btnBangGiaTrucTuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = this.CheckExists(typeof(frmBangGiaTrucTuyen));
            if (frm != null) frm.Activate();
            else
            {
                Program.frmBGTT = new frmBangGiaTrucTuyen();
                Program.frmBGTT.MdiParent = this;
                Program.frmBGTT.Show();
            }
        }
    }
}
