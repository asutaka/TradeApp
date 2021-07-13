using System.Threading;

namespace TheLast.GUI
{
    class WaitFunc
    {
        frmWaitForm loadingForm;
        Thread loadthread;
        public void Show()
        {
            loadthread = new Thread(new ThreadStart(LoadingProcessEx));
            loadthread.Start();
        }
        public void Close()
        {
            if (loadingForm != null)
            {
                loadingForm.BeginInvoke(new ThreadStart(loadingForm.Close));
                loadingForm = null;
                loadthread = null;
            }
        }
        private void LoadingProcessEx()
        {
            loadingForm = new frmWaitForm();
            loadingForm.ShowDialog();
        }
    }
}
