using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Models
{
    public class StatusModel<TDataObject>
    {
        public StatusModel()
        {
            Messages = new List<string>();
            StatusCode = HttpStatusCode.InternalServerError;
        }

        public List<string> Messages { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public TDataObject Object { get; set; }

        public ApiResult<TDataObject> ResultObject
        {
            get
            {
                return new Models.ApiResult<TDataObject>()
                {
                    Messages = Messages,
                    Object = Object
                };
            }
        }

        public void SetStatus(HttpStatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public void SetStatus(HttpStatusCode statusCode, string msg, params string[] msgs)
        {
            StatusCode = statusCode;
            SetMessages(msg, msgs);
        }

        public void SetStatus(HttpStatusCode statusCode, TDataObject myObject, string msg, params string[] msgs)
        {
            SetStatus(statusCode, msg, msgs);
            Object = myObject;
        }

        public void SetStatus(HttpStatusCode statusCode, TDataObject myObject)
        {
            StatusCode = statusCode;
            Object = myObject;
        }

        private void SetMessages(string msg, params string[] msgs)
        {
            Messages.Add(msg);
            if (msgs.Length > 0)
            {
                Messages.AddRange(msgs);
            }
        }
    }

    public class ApiResult<TDataObject>
    {
        public List<string> Messages { get; set; }
        public TDataObject Object { get; set; }
    }
}
