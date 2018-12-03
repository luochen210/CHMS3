using System;
using System.Collections.Generic;
using System.Text;

namespace Framework
{
    public class ReturnValue
    {
        /// <summary>
        /// �������ͽ��
        /// </summary>
        private int result;
        /// <summary>
        /// �����ַ��ͽ��
        /// </summary>
        private string reason;

        public int Result
        {
            get { return result; }
            set { result = value; }
        }

        public string Reason
        {
            get { return reason; }
            set { reason = value; }
        }

        public ReturnValue() { }
        public ReturnValue(int result, string reason)
        {
            this.result = result;
            this.reason = reason;
        }

    }
}
