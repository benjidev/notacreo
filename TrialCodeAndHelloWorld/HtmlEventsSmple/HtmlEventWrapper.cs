using System;
using System.Collections.Generic;
using System.Text;
using mshtml;

namespace HtmlEventsSmple
{
    public class HtmlEventWrapper
    {
        private HtmlEventProxy m_Proxy = null;
        private object m_HtmlElement = null;


        //private CTOR to enable instantiation only through factory method
        private HtmlEventWrapper() 
        { 
        }




        /// <summary>
        /// factory nethod
        /// </summary>
        /// <returns></returns>
        public static HtmlEventWrapper Create(object htmlElement,string eventName,EventHandler handler)
        {
            
            HtmlEventWrapper wrapper = new HtmlEventWrapper();
            HtmlEventProxy proxy = new HtmlEventProxy(wrapper, handler);
        }

    }
}
