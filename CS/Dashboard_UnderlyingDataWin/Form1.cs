using DevExpress.DashboardCommon;
using DevExpress.DashboardWin;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace Dashboard_UnderlyingDataWin {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
        }

        private void dashboardViewer1_DashboardItemDoubleClick(object sender, DashboardItemMouseActionEventArgs e) {
            XtraForm form = new XtraForm {
                Text = "Underlying Data"
            };
            DashboardUnderlyingDataSet underlyingData = e.GetUnderlyingData();

            if (underlyingData != null && underlyingData.RowCount > 0) {
                DevExpress.XtraGrid.GridControl grid = new DevExpress.XtraGrid.GridControl {
                    Parent = form,
                    Dock = DockStyle.Fill,
                    DataSource = underlyingData,
                };
            }
            else {
                LabelControl lbl = new LabelControl {
                    Text = "No Data",
                    Parent = form,
                };
                lbl.AutoSizeMode = LabelAutoSizeMode.None;
                lbl.Appearance.TextOptions.HAlignment = HorzAlignment.Center;
                lbl.Appearance.TextOptions.VAlignment = VertAlignment.Center;
                lbl.Dock = DockStyle.Fill;
            }

            form.ShowDialog();
            form.Dispose();
        }
    }
}
