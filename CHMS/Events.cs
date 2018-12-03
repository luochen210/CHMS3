using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CHMS
{
    class Events : CollectionBase
    {
        #region 增加事件
        public Event Add(Event tEvent)
        {
            this.InnerList.Add(tEvent);
            return tEvent;
        }
        public Event Add(string eventName, DateTime startTime, DateTime endTime)
        {
            Event tEvent = new Event(eventName, startTime, endTime);
            this.InnerList.Add(tEvent);
            return tEvent;
        }
        #endregion
        #region 返回事件
        public Event item(int index)
        {
            return (Event)this.InnerList[index];
        }
        public Event item(Event parEvent)
        {
            int tIndex = this.InnerList.IndexOf(parEvent);
            return (Event)this.InnerList[tIndex];
        }
        #endregion
        #region 删除事件
        public void Remove(Event tEvent)
        {
            this.InnerList.Remove(tEvent);
        }
        public void Remove(int index)
        {
            Event tEvent;
            tEvent = (Event)this.InnerList[index];
            if (!(tEvent == null))
            {
                this.InnerList.Remove(tEvent);
            }
        }
        #endregion
    }

}