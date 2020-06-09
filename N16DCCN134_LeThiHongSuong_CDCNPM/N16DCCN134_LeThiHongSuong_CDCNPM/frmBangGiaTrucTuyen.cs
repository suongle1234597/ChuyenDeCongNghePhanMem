using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N16DCCN134_LeThiHongSuong_CDCNPM
{
    public partial class frmBangGiaTrucTuyen : Form
    {
        private int changeCount = 0;
        private const String tableName = "BANGGIATRUCTUYEN";

        private SqlConnection connection = null;
        private SqlCommand command = null;
        private DataSet dataToWatch = null;
        public frmBangGiaTrucTuyen()
        {
            InitializeComponent();
        }

        private void frmBangGiaTrucTuyen_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'n16DCCN134_LeThiHongSuongDataSet.BANGGIATRUCTUYEN' table. You can move, or remove it, as needed.
            this.bANGGIATRUCTUYENTableAdapter.Fill(this.DS1.BANGGIATRUCTUYEN);

            if (CanRequestNotifications() == true) 
            {
                Program.KetNoi();
                BatDau();
            }
            else
            {
                MessageBox.Show("Bạn chưa kích hoạt dịch vụ Broker", "", MessageBoxButtons.OK);
            }
        }

        private Boolean CanRequestNotifications()
        {
            try
            {
                SqlClientPermission perm = new SqlClientPermission(PermissionState.Unrestricted);
                perm.Demand();
                return true; 
            }
            catch (Exception e)
            {
                return false; 
            }
        }

        private String GetSQL() 
        {
            return "EXEC SP_GETROW";
        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            ISynchronizeInvoke i = (ISynchronizeInvoke)this;

            if (i.InvokeRequired)
            {
                OnChangeEventHandler tempDelegate = new OnChangeEventHandler(dependency_OnChange);

                object[] args = { sender, e };

                i.BeginInvoke(tempDelegate, args);
                return;
            }

            SqlDependency dependency = (SqlDependency)sender;

            dependency.OnChange -= dependency_OnChange;

            changeCount += 1;

            this.ListBox1.Items.Clear();
            this.ListBox1.Items.Add("Info:   " + e.Info.ToString());
            this.ListBox1.Items.Add("Source: " + e.Source.ToString());
            this.ListBox1.Items.Add("Type:   " + e.Type.ToString());

            GetData();
        }

        private void GetData() 
        {
            dataToWatch.Clear();

            command.Notification = null;

            SqlDependency dependency = new SqlDependency(command); 
            dependency.OnChange += dependency_OnChange; 

            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                adapter.Fill(dataToWatch, tableName); 
                this.DataGridView1.AutoGenerateColumns = false;
                this.DataGridView1.DataSource = dataToWatch;
                this.DataGridView1.DataMember = tableName;
            }
        }

        private void BatDau()
        {
            changeCount = 0;
            SqlDependency.Stop(Program.connectionString); 
            try
            {
                SqlDependency.Start(Program.connectionString);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (connection == null) 
            {
                connection = new SqlConnection(Program.connectionString);
                connection.Open();
            }
            if (command == null)
            {
                command = new SqlCommand(GetSQL(), connection);
            }

            if (dataToWatch == null)
            {
                dataToWatch = new DataSet();
            }

            GetData();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmBangGiaTrucTuyen form = new frmBangGiaTrucTuyen();
            form.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát Form này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void frmBangGiaTrucTuyen_FormClosed(object sender, FormClosedEventArgs e)
        {
            SqlDependency.Stop(Program.connectionString);
            if (connection != null)
            {
                connection.Close();
            }
        }

        private void btnDatLenh_Click(object sender, EventArgs e)
        {
            if(Program.frmGD == null)
            {
                Program.frmGD = new frmGiaoDich();
                Program.frmGD.MdiParent = frmMain.ActiveForm;
                Program.frmGD.Show();
            }
            else
            {
                Program.frmGD.WindowState = System.Windows.Forms.FormWindowState.Maximized;
                Program.frmGD.Show();
            }
        }
    }
}
