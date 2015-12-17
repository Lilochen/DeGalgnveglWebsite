using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebSite_Galgnvegl.Models
{
    public class Result
    {
        public bool result { get; set; }
        public string message { get; set; }

        public Result(bool _result, string _message)
        {
            result = _result;
            message = _message;
        }
    }
}