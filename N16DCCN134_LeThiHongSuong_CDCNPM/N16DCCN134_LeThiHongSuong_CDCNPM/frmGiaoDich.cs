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
    public partial class frmGiaoDich : Form
    {
        public frmGiaoDich()
        {
            InitializeComponent();
        }

        private void frmGiaoDich_Load(object sender, EventArgs e)
        {
            DateTime ngay = DateTime.Now;
            lbNgay.Text = ngay.ToString("dd/MM/yyyy");
            cbbLoaiLenh.SelectedIndex = 0;
            rbtMua.Checked = true;
        }

        private void btnGD_Click(object sender, EventArgs e)
        {
            String ma, loailenh, loaiGD = "";
            int sl;
            float gia;
            ma = txtMA.Text;
            loailenh = cbbLoaiLenh.SelectedIndex.ToString();
            sl = int.Parse(txtSoLuong.Text.ToString());
            gia = float.Parse(txtGia.Text.ToString());
            if (ma.Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập mã cố phiếu!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (loailenh.Length == 0)
            {
                MessageBox.Show("Bạn chưa chọn loại lệnh!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (sl <= 0 || txtSoLuong.Text.ToString().Length == 0)
            {
                MessageBox.Show("Số lượng cần lớn hơn 0!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (gia <= 0 || txtGia.Text.ToString().Length == 0)
            {
                MessageBox.Show("Bạn chưa nhập giá!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // xử lí radioButton
            if (rbtBan.Checked)
            {
                loaiGD = "B";
            }
            else if (rbtMua.Checked)
            {
                loaiGD = "M";
            }

            Program.KetNoi();

            string strLenh1 = "EXEC SP_KHOPLENH_LO  N'" + ma + "' ,N'" + loaiGD + "'," + sl + ", " + gia;
            Program.myReader = Program.ExecSqlDataReader(strLenh1);
            if (Program.myReader == null)
            {
                Reset();
                return;
            }
            Program.myReader.Read();

            //lấy trang thái lệnh cho người dùng biết
            string kq = (Program.myReader.GetString(0).ToString());
            Program.myReader.Close();

            Reset();
            //MessageBox.Show(kq, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            if (Program.frmBGTT == null)
            {
                Program.frmBGTT = new frmBangGiaTrucTuyen();
                Program.frmBGTT.MdiParent = frmMain.ActiveForm;
                Program.frmBGTT.Show();
            }
            else
            {
                Program.frmBGTT.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                Program.frmBGTT.Show();
            }
        }

        private void txtMA_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !((e.KeyChar >= 65 && e.KeyChar <= 122) || (e.KeyChar == 8));
        }

        private void Reset()
        {
            txtMA.Text = "";
            txtSoLuong.Text = "";
            txtGia.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
