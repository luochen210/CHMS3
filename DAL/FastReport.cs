using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.InteropServices;
using System.Data;


namespace DAL
{
    /// <summary>
    /// FastReport调用类
    /// </summary>
    public class FastReport
    {
        [DllImport("IFastReport.dll")]
        private extern static string InvokeFastReport(IntPtr handle, string dataXML, string ParametersXML);

        /// <summary>
        /// 调用FastReport
        /// </summary>
        /// <param name="handle">窗口句柄</param>
        /// <param name="dataSource">数据源</param>
        /// <param name="settings">报表设置</param>
        public static void Invoke(IntPtr handle, DataTable dataSource, FastReportSettings settings)
        {
            IXMLDataTableTransform xmlTransform = new DelphiClientDataSet();
            string dataXML = xmlTransform.Transform(dataSource);
            string result = InvokeFastReport(handle, dataXML, settings.GetXML());
            if (result.Trim() != "")
            {
                throw new Exception(result);
            }
        }

        /// <summary>
        /// 调用FastReport
        /// </summary>
        /// <param name="dataSource">数据源</param>
        /// <param name="settings">报表设置</param>
        public static void Invoke(DataTable dataSource, FastReportSettings settings)
        {
            Invoke(new IntPtr(0), dataSource, settings);
        }
    }

    /// <summary>
    /// FastReport的报表设置类
    /// </summary>
    public class FastReportSettings
    {
        #region 报表参数部分
        /// <summary>
        /// 报表参数部分
        /// </summary>
        public class ReportParameter
        {
            private string _Name;
            /// <summary>
            /// 报表参数名称
            /// </summary>
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            private string _Value;
            /// <summary>
            /// 报表参数的值
            /// </summary>
            public string Value
            {
                get { return _Value; }
                set { _Value = value; }
            }
            /// <summary>
            /// 参数对象
            /// </summary>
            /// <param name="name">参数名称</param>
            /// <param name="value">参数的值</param>
            public ReportParameter(string name, string value)
            {
                this._Name = name;
                this._Value = value;
            }
        }

        private IList<ReportParameter> _ReportParametersList;

        /// <summary>
        ///报表ReportParametersList的参数列表
        /// </summary>
        protected IList<ReportParameter> ReportParametersList
        {
            get
            {
                if (_ReportParametersList == null)
                {
                    _ReportParametersList = new List<ReportParameter>();
                }
                return _ReportParametersList;
            }
            set { _ReportParametersList = value; }
        }
        /// <summary>
        /// 添加参数对象
        /// </summary>
        /// <param name="Parameters">参数对象</param>
        public void AddReportParameter(ReportParameter Parameters)
        {
            ReportParametersList.Add(Parameters);
        }

        /// <summary>
        /// 添加参数
        /// </summary>
        /// <param name="name">参数名称</param>
        /// <param name="value">参数的值</param>
        public void AddReportParameters(string name, string value)
        {
            ReportParametersList.Add(new ReportParameter(name, value));
        }
        #endregion

        private Mode _OperateMode;
        /// <summary>
        /// 操作模式
        /// </summary>
        public Mode OperateMode
        {
            get { return _OperateMode; }
            set { _OperateMode = value; }
        }

        /// <summary>
        /// 报表操作模式 Print直接打印 Preview预览 Design设计
        /// </summary>
        public enum Mode
        {
            /// <summary>
            /// 打印状态
            /// </summary>
            Print = 0,
            /// <summary>
            /// 预览状态
            /// </summary>
            Preview = 1,
            /// <summary>
            /// 设计状态
            /// </summary>
            Design = 2
        }

        private string _ReportPath;
        /// <summary>
        /// 报表文件路径
        /// </summary>
        public string ReportPath
        {
            get { return _ReportPath; }
            set { _ReportPath = value; }
        }

        private string _PrinterName;
        /// <summary>
        /// 打印机名称
        /// </summary>
        public string PrinterName
        {
            get { return _PrinterName; }
            set { _PrinterName = value; }
        }

        /// <summary>
        /// 默认构造方法
        /// </summary>
        public FastReportSettings()
        {
        }

        /// <summary>
        /// 带路径的构造方法
        /// </summary>
        /// <param name="reportPath">报表文件路径</param>
        public FastReportSettings(string reportPath)
        {
            this._ReportPath = reportPath;
            this._OperateMode = Mode.Preview;
            this._PrinterName = "";
        }

        /// <summary>
        /// 带操作模式 报表路径 打印机名称的构造方法
        /// </summary>
        /// <param name="mode">操作模式</param>
        /// <param name="reportPath">报表路径</param>
        /// <param name="printerName">打印机名称</param>
        public FastReportSettings(Mode mode, string reportPath, string printerName)
        {
            this._OperateMode = mode;
            this._PrinterName = printerName;
            this._ReportPath = reportPath;
        }

        #region xml 获得报表设置的XML IFastReport接口可以解析的
        /// <summary>
        /// 获得报表设置的XML IFastReport接口可以解析的
        /// </summary>
        /// <returns></returns>
        public string GetXML()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;
            StringBuilder sbParameters = new StringBuilder();
            using (XmlWriter xw = XmlWriter.Create(sbParameters, settings))
            {
                xw.WriteStartDocument(true);

                xw.WriteStartElement("PARAMS");
                BuildBaseXML(xw);
                BuildParametersXML(xw);
                xw.WriteEndDocument();

                xw.Flush();
            }
            return sbParameters.ToString().Replace("?xml version=\"1.0\" encoding=\"utf-16\"", "?xml version=\"1.0\" encoding=\"GB2312\"");
        }

        private void BuildParametersXML(XmlWriter xw)
        {
            xw.WriteStartElement("FastReport");
            foreach (ReportParameter rp in ReportParametersList)
            {
                xw.WriteStartElement("PARAM");
                xw.WriteAttributeString("Name", rp.Name);
                xw.WriteAttributeString("Value", rp.Value);
                xw.WriteEndElement();//param
            }
            xw.WriteEndElement();//FastReport
        }

        private void BuildBaseXML(XmlWriter xw)
        {
            xw.WriteStartElement("BASE");

            xw.WriteStartElement("ReportPath");
            xw.WriteValue(@ReportPath);
            xw.WriteEndElement();

            xw.WriteStartElement("Mode");//0 直接打印 1预览 2设计
            xw.WriteValue((int)OperateMode);
            xw.WriteEndElement();

            xw.WriteStartElement("PrinterName");
            xw.WriteValue(PrinterName);
            xw.WriteEndElement();

            xw.WriteEndElement();//BASEPARAMS
        }
        #endregion
    }
}
