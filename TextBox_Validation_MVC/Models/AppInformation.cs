using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TextBox_Validation_MVC.Models
{
    public class AppInformation
    {
        public string Today => "Today " + DateTime.Now.ToLongDateString();
        public string Author => "Author Karen Payne";
    }
}