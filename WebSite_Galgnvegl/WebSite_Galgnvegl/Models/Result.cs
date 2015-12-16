using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_Galgnvegl.Models
{
    public class Result
    {
        public bool result { get; set; }

        public Result(bool _result)
        {
            result = _result;
        }
    }
}