using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace Models
{
    /// <summary>
    /// �ɶ�ȡ���ݵĽӿ�
    /// </summary>
    public interface ILoadable
    {
        /// <summary>
        /// ��ȡ����
        /// </summary>
        /// <param name="dr">���ݶ�ȡ��</param>
        void Loading(IDataReader dr);
    }
}
