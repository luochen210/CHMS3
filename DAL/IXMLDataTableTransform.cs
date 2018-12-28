using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAL
{
    /// <summary>
    /// DataTable ����Դ����ת����XML�ļ�
    /// </summary>
    public interface IXMLDataTableTransform
    {
        /// <summary>
        /// ת��DataTable����
        /// </summary>
        /// <param name="datatable">DataTable</param>
        /// <returns> DataTable�������е�ֵ</returns>
        string Transform(DataTable datatable);
    }
}
