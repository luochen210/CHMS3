using System;
using System.Collections.Generic;
using System.Xml;
using System.Data;
using System.Text;

namespace DAL
{
    /// <summary>
    /// 于DelphiClientDataSet的适配对象
    /// </summary>
    public class DelphiClientDataSet:IXMLDataTableTransform
    {
        #region IXMLDataTableTransform 成员 把DataTable转换成Delphi的ClientDataSet可以解析的XML字符串
        /// <summary>
        /// 把DataTable转换成Delphi的ClientDataSet可以解析的XML字符串
        /// </summary>
        /// <param name="datatable">要转换的DataTable</param>
        /// <returns>解析过的XML</returns>
        public string Transform(DataTable datatable)
        {
            StringBuilder result = new StringBuilder();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Encoding = Encoding.UTF8;
            settings.Indent = true;
            using (XmlWriter xw = XmlWriter.Create(result, settings))
            {
                xw.WriteStartDocument(true);
                xw.WriteStartElement("DATAPACKET");
                xw.WriteAttributeString("Version", "2.0");
                BuildMetaData(datatable, xw);
                xw.WriteEndDocument();
                xw.Flush();
            }
            return result.ToString().Replace("?xml version=\"1.0\" encoding=\"utf-16\"", "?xml version=\"1.0\" encoding=\"utf-8\"");
        }

        #endregion

        private void BuildMetaData(DataTable dt, XmlWriter xw)
        {
            xw.WriteStartElement("METADATA");
            BuildFields(dt, xw);
            BuildParams(xw);
            xw.WriteEndElement();//metadata
            BuildRowData(dt, xw);
            xw.WriteEndElement();//datapacket
        }

        private void BuildFields(DataTable dt, XmlWriter xw)
        {
            xw.WriteStartElement("FIELDS");
            foreach (DataColumn dc in dt.Columns)
            {
                xw.WriteStartElement("FIELD");
                xw.WriteAttributeString("attrname", dc.ColumnName);
                switch (dc.DataType.Name.ToLower())
                {
                    case "int16":
                        {
                            xw.WriteAttributeString("fieldtype", "i2");
                            break;
                        }
                    case "int32":
                        {
                            xw.WriteAttributeString("fieldtype", "i4");
                            break;
                        }
                    case "byte":
                        {
                            xw.WriteAttributeString("fieldtype", "i1");
                            break;
                        }
                    case "int64":
                        {
                            xw.WriteAttributeString("fieldtype", "i8");
                            break;
                        }
                    case "decimal":
                        {
                            xw.WriteAttributeString("fieldtype", "r8");
                            xw.WriteAttributeString("WIDTH", "19");
                            break;
                        }
                    case "double":
                        {
                            xw.WriteAttributeString("fieldtype", "r8");
                            xw.WriteAttributeString("WIDTH", "18");
                            break;
                        }
                    case "single":
                        {
                            xw.WriteAttributeString("fieldtype", "r8");
                            break;
                        }
                    case "byte[]":
                        {
                            xw.WriteAttributeString("fieldtype", "bin.hex");
                            xw.WriteAttributeString("SUBTYPE", "Binary");
                            break;
                        }
                    case "string":
                        {
                            xw.WriteAttributeString("fieldtype", "string");
                            xw.WriteAttributeString("WIDTH", "2000");
                            break;
                        }
                    default:
                        {
                            xw.WriteAttributeString("fieldtype", dc.DataType.Name.ToLower());
                            break;
                        }
                }
                xw.WriteEndElement();
            }
            xw.WriteEndElement();//fields
        }

        private static void BuildParams(XmlWriter xw)
        {
            xw.WriteStartElement("PARAMS");
            xw.WriteEndElement();//params
        }

        private static void BuildRowData(DataTable dt, XmlWriter xw)
        {
            xw.WriteStartElement("ROWDATA");
            foreach (DataRow dr in dt.Rows)
            {
                xw.WriteStartElement("ROW");
                foreach (DataColumn dc in dt.Columns)
                {
                    xw.WriteAttributeString(dc.ColumnName, dr[dc].ToString());
                }
                xw.WriteEndElement();
            }
            xw.WriteEndElement();//rowdata
        }          
    }
}
