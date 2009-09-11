using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using mshtml;

namespace HtmlEventsSmple
{
    public partial class Form1 : Form
    {
        private bool m_RegisterEvents = true;

        public Form1()
        {
            InitializeComponent();
            webBrowser1.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(webBrowser1_DocumentCompleted);
        }

        void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {            
            if (m_RegisterEvents)
            {
                m_RegisterEvents = false;

                //regester the html event handlers
                object form = webBrowser1.Document.Forms[0].DomElement ;
                HtmlEventProxy.Create("onsubmit", form, FormSubmitHabdler);

                object button = webBrowser1.Document.GetElementById("button1").DomElement;
                HtmlEventProxy.Create("onclick", button, ButtonClickHabdler);                


            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.DocumentText = global::HtmlEventsSmple.Properties.Resources.HTML;
        }


        /// <summary>
        /// handler for onsubmit event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormSubmitHabdler(object sender, EventArgs e)
        {           
            
            MessageBox.Show("form submitted");

            // show the outer html of the form
            IHTMLElement form = ((HtmlEventProxy)sender).HTMLElement as IHTMLElement;
            MessageBox.Show("outer html:" + form.outerHTML);

            //detach the event from the element
            ((HtmlEventProxy)sender).Detach();
        }

        /// <summary>
        /// handler for button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ButtonClickHabdler(object sender, EventArgs e)
        {          

            MessageBox.Show("button clicked","This is .NET Message Box");
        }


    }
}