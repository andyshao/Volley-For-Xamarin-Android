using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using VolleyCSharp.MainCom;

/*
 * 15.4.15 ��д
 */

namespace VolleyCSharp.Delivery
{
    public interface IResponseDelivery
    {
        void PostResponse(Request request, Response response);
        void PostResponse(Request request, Response response, Action runnable);
        void PostError(Request request, VolleyError error);
    }
}