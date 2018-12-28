using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace DAL
{
    /// <summary>
    /// 可读取数据的接口
    /// </summary>
    public interface ILoadable
    {
        /// <summary>
        /// 读取数据
        /// </summary>
        /// <param name="dr">数据读取器</param>
        void Loading(IDataReader dr);
    }
}
