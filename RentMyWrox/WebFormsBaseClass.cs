﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.HtmlControls;

namespace RentMyWrox
{
    public class WebFormsBaseClass : System.Web.UI.Page
    {

        public string MetaTagKeywords { get; set; }

        public string MetaTagDescription { get; set; }

        protected override void OnPreLoad(EventArgs e)
        {
            if (!String.IsNullOrEmpty(MetaTagKeywords))
            {
                HtmlMeta tag = new HtmlMeta();
                tag.Name = "Keywords";
                tag.Content = MetaTagKeywords;
                Header.Controls.Add(tag);
            }
            else
            {
                throw new Exception("Your Keywords are empty");
            }
            if (!String.IsNullOrEmpty(MetaTagDescription))
            {
                HtmlMeta tag = new HtmlMeta();
                tag.Name = "description";
                tag.Content = MetaTagDescription;
                Header.Controls.Add(tag);
            }
            else
            {
                throw new Exception("Your description is empty");
            }
            base.OnPreLoad(e);
        }
    }
}