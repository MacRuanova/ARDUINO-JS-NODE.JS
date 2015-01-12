using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnPrender_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start(@"C:\Users\Chema\Desktop\johnny-five-master\Blinkerjs\prender.bat");
    }
    protected void btnApagar_Click(object sender, EventArgs e)
    {
        System.Diagnostics.Process.Start(@"C:\Users\Chema\Desktop\johnny-five-master\Blinkerjs\apagar.bat");
    }
}