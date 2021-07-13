using DevExpress.Utils;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheLast.Common;
using TheLast.Model;

namespace TheLast.GUI
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        private WaitFunc _frmWaitForm = new WaitFunc();
        public frmMain()
        {
            InitializeComponent();
            lblTime.Text = $"{DateTime.Now.ToString("HH:MM:SS")}";
        }

        private void mnuBasicSetting_Click(object sender, EventArgs e)
        {
            new frmBasicSetting().Show();
        }

        private void mnuAdvanceSetting_Click(object sender, EventArgs e)
        {
            new frmAdvanceSetting().Show();
        }

        private void mnuStart_Click(object sender, EventArgs e)
        {
            ExecJob();
        }

        private void ExecJob()
        {
            Console.WriteLine($"Date Start: {DateTime.Now}");
            StaticValues.basicModel = 0.LoadBasicJson();
            StaticValues.advanceModel = 0.LoadAdvanceJson();

            _frmWaitForm.Show();
            var lstOutput = new List<OutputModel>();
            var lstTask = new List<Task>();
            foreach (var item in StaticValues.lstCoin)
            {
                var task = Task.Run(() =>
                {
                    lstOutput.Add(new Calculate(item.S).GetOutput());
                });
                lstTask.Add(task);
            }
            Task.WaitAll(lstTask.ToArray());
            var lstOutputResult = lstOutput.OrderByDescending(x => x.Point).ThenBy(x => x.Code);
            var count = 0;
            grid.BeginUpdate();
            grid.DataSource = (from entity in lstOutputResult 
                               from entity1 in StaticValues.lstCoin
                               where entity.Code == entity1.S
                               select new { No = ++count, entity.Code, Title = entity1.AN, entity.Point });
            grid.EndUpdate();
            Console.WriteLine($"Date End: {DateTime.Now}");
            lblTime.Text = $"{DateTime.Now.ToString("HH:MM:SS")}";
            _frmWaitForm.Close();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            DXMouseEventArgs ea = e as DXMouseEventArgs;
            GridHitInfo info = gridView1.CalcHitInfo(ea.Location);
            if (info.InRow || info.InRowCell)
            {
                var cellValue = gridView1.GetRowCellValue(info.RowHandle, "Code").ToString();
                ProcessStartInfo sInfo = new ProcessStartInfo($"{ConstValues.COIN_SINGLE}{cellValue.Replace("USDT","_USDT")}");
                Process.Start(sInfo);
            }
        }
    }
}