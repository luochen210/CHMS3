using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAL
{
    /// <summary>
    /// DataTable 数据源对象转化成XML文件
    /// </summary>
    public interface IXMLDataTableTransform
    {
        /// <summary>
        /// 转换DataTable对象
        /// </summary>
        /// <param name="datatable">DataTable</param>
        /// <returns> DataTable对象中行的值</returns>
        string Transform(DataTable datatable);
    }
}
