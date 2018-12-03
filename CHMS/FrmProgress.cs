using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//下载源码到51aspx
namespace CHMS
{
    public partial class FrmProgress : Form
    {

        public FrmProgress()
        {
            InitializeComponent();
        }
        #region 委托
        /// <summary>
        /// 设置显示值的委托
        /// </summary>
        /// <param name="text"></param>
        public delegate void SetTextInvoker(String text);

        /// <summary>
        /// 进度显示的委托
        /// </summary>
        /// <param name="val"></param>
        public delegate void IncrementInvoker(int val);

        /// <summary>
        /// 跳转到
        /// </summary>
        /// <param name="val"></param>
        public delegate void StepToInvoker(int val);

        /// <summary>
        /// 设置ProgressBar的范围
        /// </summary>
        /// <param name="minimum"></param>
        /// <param name="maximum"></param>
        public delegate void RangeInvoker(int minimum, int maximum);
        #endregion

        #region 私有变量
        /// <summary>
        /// tilte
        /// </summary>
        private String title = "";

        /// <summary>
        /// 初始线程
        /// </summary>
        private System.Threading.ManualResetEvent initResetEvent = new System.Threading.ManualResetEvent(false);

        /// <summary>
        /// 停止线程
        /// </summary>
        private System.Threading.ManualResetEvent abortResetEvent = new System.Threading.ManualResetEvent(false);

        /// <summary>
        /// 是否关闭
        /// </summary>
        private bool requiresClose = true;
        #endregion

        #region 方法
        /// <summary>
        /// 开始进程
        /// </summary>
        /// <param name="minimum">progressbar的最大值</param>
        /// <param name="maximum">progressbar的最大值</param>
        public void BeginThread(int minimum, int maximum)
        {
            initResetEvent.WaitOne();
            Invoke(new RangeInvoker(DoBegin), new object[] { minimum, maximum });
        }

        /// <summary>
        /// 开始进程
        /// </summary>
        public void BeginThread()
        {
            initResetEvent.WaitOne();
            Invoke(new MethodInvoker(DoBegin));
        }

        /// <summary>
        /// 设置范围
        /// </summary>
        /// <param name="minimum">最小值</param>
        /// <param name="maximum">最大值</param>
        public void SetProgressRange(int minimum, int maximum)
        {
            initResetEvent.WaitOne();
            Invoke(new RangeInvoker(DoSetRange), new object[] { minimum, maximum });
        }

        /// <summary>
        /// 设置显示值
        /// </summary>
        /// <param name="text">显示值</param>
        public void SetDisplayText(String text)
        {
            Invoke(new SetTextInvoker(DoSetText), new object[] { text });
        }

        /// <summary>
        /// 增加显示值
        /// </summary>
        /// <param name="val">增加值</param>
        public void Increment(int val)
        {
            Invoke(new IncrementInvoker(DoIncrement), new object[] { val });
        }
        /// <summary>
        /// 跳到摸个进度
        /// </summary>
        /// <param name="val"></param>
        public void StepTo(int val)
        {
            Invoke(new StepToInvoker(DoStepTo), new object[] { val });
        }
        /// <summary>
        /// 是否停止
        /// </summary>
        public bool IsAborting
        {
            get
            {
                return abortResetEvent.WaitOne(0, false);
            }
        }
        /// <summary>
        /// 结束进程
        /// </summary>
        public void End()
        {
            if (requiresClose)
            {
                Invoke(new MethodInvoker(DoEnd));
            }
        }
        #endregion

        #region 私有方法
        private void DoSetText(String text)
        {
            lbTitle.Text = text;
        }

        private void DoIncrement(int val)
        {
            progressBar.Increment(val);
            UpdateStatusText();
        }

        private void DoStepTo(int val)
        {
            progressBar.Value = val;
            UpdateStatusText();
        }

        private void DoBegin(int minimum, int maximum)
        {
            DoBegin();
            DoSetRange(minimum, maximum);
        }

        private void DoBegin()
        {

        }
        private void DoSetRange(int minimum, int maximum)
        {
            progressBar.Minimum = minimum;
            progressBar.Maximum = maximum;
            progressBar.Value = minimum;
            title = Text;
        }

        private void DoEnd()
        {
            Close();
        }

        /// <summary>
        /// Utility function that formats and updates the title bar text
        /// </summary>
        private void UpdateStatusText()
        {
            Text = title + String.Format(" - {0}% 已完成", (progressBar.Value * 100) / (progressBar.Maximum - progressBar.Minimum));
        }

        /// <summary>
        /// 强制停止进程
        /// </summary>
        private void AbortWork()
        {
            abortResetEvent.Set();
        }
        #endregion

        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Load"/> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs"/> that contains the event data.</param>
        protected override void OnLoad(EventArgs e)
        {
            this.ControlBox = false;
            initResetEvent.Set();
            base.OnLoad(e);
        }
        /// <summary>
        /// Raises the <see cref="E:System.Windows.Forms.Form.Closing"/> event.
        /// </summary>
        /// <param name="e">A <see cref="T:System.ComponentModel.CancelEventArgs"/> that contains the event data.</param>
        protected override void OnClosing(CancelEventArgs e)
        {
            requiresClose = false;
            AbortWork();
            base.OnClosing(e);
        }
    }
}
