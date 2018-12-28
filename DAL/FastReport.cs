using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Runtime.InteropServices;
using System.Data;


namespace DAL
{
    /// <summary>
    /// FastReport������
    /// </summary>
    public class FastReport
    {
        [DllImport("IFastReport.dll")]
        private extern static string InvokeFastReport(IntPtr handle, string dataXML, string ParametersXML);

        /// <summary>
        /// ����FastReport
        /// </summary>
        /// <param name="handle">���ھ��</param>
        /// <param name="dataSource">����Դ</param>
        /// <param name="settings">��������</param>
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
        /// ����FastReport
        /// </summary>
        /// <param name="dataSource">����Դ</param>
        /// <param name="settings">��������</param>
        public static void Invoke(DataTable dataSource, FastReportSettings settings)
        {
            Invoke(new IntPtr(0), dataSource, settings);
        }
    }

    /// <summary>
    /// FastReport�ı���������
    /// </summary>
    public class FastReportSettings
    {
        #region �����������
        /// <summary>
        /// �����������
        /// </summary>
        public class ReportParameter
        {
            private string _Name;
            /// <summary>
            /// �����������
            /// </summary>
            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            private string _Value;
            /// <summary>
            /// ���������ֵ
            /// </summary>
            public string Value
            {
                get { return _Value; }
                set { _Value = value; }
            }
            /// <summary>
            /// ��������
            /// </summary>
            /// <param name="name">��������</param>
            /// <param name="value">������ֵ</param>
            public ReportParameter(string name, string value)
            {
                this._Name = name;
                this._Value = value;
            }
        }

        private IList<ReportParameter> _ReportParametersList;

        /// <summary>
        ///����ReportParametersList�Ĳ����б�
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
        /// ��Ӳ�������
        /// </summary>
        /// <param name="Parameters">��������</param>
        public void AddReportParameter(ReportParameter Parameters)
        {
            ReportParametersList.Add(Parameters);
        }

        /// <summary>
        /// ��Ӳ���
        /// </summary>
        /// <param name="name">��������</param>
        /// <param name="value">������ֵ</param>
        public void AddReportParameters(string name, string value)
        {
            ReportParametersList.Add(new ReportParameter(name, value));
        }
        #endregion

        private Mode _OperateMode;
        /// <summary>
        /// ����ģʽ
        /// </summary>
        public Mode OperateMode
        {
            get { return _OperateMode; }
            set { _OperateMode = value; }
        }

        /// <summary>
        /// �������ģʽ Printֱ�Ӵ�ӡ PreviewԤ�� Design���
        /// </summary>
        public enum Mode
        {
            /// <summary>
            /// ��ӡ״̬
            /// </summary>
            Print = 0,
            /// <summary>
            /// Ԥ��״̬
            /// </summary>
            Preview = 1,
            /// <summary>
            /// ���״̬
            /// </summary>
            Design = 2
        }

        private string _ReportPath;
        /// <summary>
        /// �����ļ�·��
        /// </summary>
        public string ReportPath
        {
            get { return _ReportPath; }
            set { _ReportPath = value; }
        }

        private string _PrinterName;
        /// <summary>
        /// ��ӡ������
        /// </summary>
        public string PrinterName
        {
            get { return _PrinterName; }
            set { _PrinterName = value; }
        }

        /// <summary>
        /// Ĭ�Ϲ��췽��
        /// </summary>
        public FastReportSettings()
        {
        }

        /// <summary>
        /// ��·���Ĺ��췽��
        /// </summary>
        /// <param name="reportPath">�����ļ�·��</param>
        public FastReportSettings(string reportPath)
        {
            this._ReportPath = reportPath;
            this._OperateMode = Mode.Preview;
            this._PrinterName = "";
        }

        /// <summary>
        /// ������ģʽ ����·�� ��ӡ�����ƵĹ��췽��
        /// </summary>
        /// <param name="mode">����ģʽ</param>
        /// <param name="reportPath">����·��</param>
        /// <param name="printerName">��ӡ������</param>
        public FastReportSettings(Mode mode, string reportPath, string printerName)
        {
            this._OperateMode = mode;
            this._PrinterName = printerName;
            this._ReportPath = reportPath;
        }

        #region xml ��ñ������õ�XML IFastReport�ӿڿ��Խ�����
        /// <summary>
        /// ��ñ������õ�XML IFastReport�ӿڿ��Խ�����
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

            xw.WriteStartElement("Mode");//0 ֱ�Ӵ�ӡ 1Ԥ�� 2���
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
