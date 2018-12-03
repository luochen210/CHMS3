using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CHMS
{
    class Event
    {
        private string _eventName;
        private DateTime _startTime;
        private DateTime _endTime;
        private string _stHour;
        private string _stMin;
        private string _stSec;
        private string _etHour;
        private string _etMin;
        private string _etSec;
        private TimeSpan _timeSpan;
        public bool _timeUp = true;
        public System.Windows.Forms.Timer tEventTimer = new System.Windows.Forms.Timer();
        public System.Timers.Timer showMessage = new System.Timers.Timer();
        public Event() { }
        public Event(string eventName, DateTime startTime, DateTime endTime)
        {
            _stHour = startTime.Hour.ToString();
            _stMin = startTime.Minute.ToString();
            _stSec = startTime.Second.ToString();
            this._eventName = eventName;
            _startTime = startTime;
            this._endTime = endTime;
            _etHour = endTime.Hour.ToString();
            _etMin = endTime.Minute.ToString();
            _etSec = endTime.Second.ToString();
            _timeSpan = endTime.Subtract(startTime);
            tEventTimer.Interval = 1000;
        }
        public string EventName
        {
            get { return _eventName; }
            set { _eventName = value; }
        }
        #region 开始和结束时间的时、分、秒
        public string StHour
        {
            get
            {
                return _stHour;
            }
        }
        public string StMin
        {
            get
            {
                return _stMin;
            }
        }
        public string StSec
        {
            get
            {
                return _stSec;
            }

        }
        public string EtHour
        {
            get
            {

                return _etHour;
            }

        }
        public string EtMin
        {
            get
            {
                return _etMin;
            }

        }
        public string EtSec
        {
            get
            {
                return _etSec;
            }

        }
        #endregion
        #region 开始和结束时间、时间差
        public DateTime StartTime
        {
            get
            {
                return _startTime;
            }
            set
            {
                _startTime = value;
            }
        }
        public DateTime EndTime
        {
            get
            {
                return _endTime;
            }
            set
            {
                _endTime = value;
            }
        }
        public TimeSpan TimeSpan
        {
            get
            {
                return _timeSpan;
            }
        }
        #endregion
        public string DisplayData
        {
            get
            {
                return _eventName + " ," + "开始时间:" + _stHour + ":" + _stMin + ",将在" + _timeSpan.Hours.ToString() + "小时" + _timeSpan.Minutes.ToString() + "分后提醒您！";
            }
        }
    }
}
