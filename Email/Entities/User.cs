using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Email.Entities
{
    public abstract class User
    {
        private string _id;
        public string id
        {
            get { return _id; }
            set { _id = value; }

        }
    }
}