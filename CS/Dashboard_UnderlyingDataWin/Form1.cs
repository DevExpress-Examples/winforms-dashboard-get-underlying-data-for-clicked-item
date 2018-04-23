using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.DashboardWin;
using DevExpress.DashboardCommon;

namespace Dashboard_UnderlyingDataWin {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void dashboardViewer1_DashboardItemDoubleClick(object sender, 
            DashboardItemMouseActionEventArgs e) {
            XtraForm form = new XtraForm();
            form.Text = "Underlying Data";
            DashboardUnderlyingDataSet underlyingData = e.GetUnderlyingData();

            DataGrid grid = new DataGrid();
            grid.Parent = form; grid.Dock = DockStyle.Fill;
            if (underlyingData != null) {
                grid.DataSource = underlyingData;
            }
            else
                grid.CaptionText = "The grid has no data";
            form.ShowDialog();
            form.Dispose();
        }
    }
}
