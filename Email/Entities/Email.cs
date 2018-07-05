using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Email.Entities
{
    public abstract class Email
    {
        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }

        }

        private long _date;
        public long date
        {
            get { return _date; }
            set { _date = value; }
        }
    }
}