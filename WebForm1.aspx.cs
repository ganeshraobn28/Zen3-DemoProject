using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("https://www.google.com/search?q=beach+images&rlz=1C1CHBF_enIN826IN826&tbm=isch&source=iu&ictx=1&fir=qcRC0tnFWsRpFM%253A%252ClRh4RnRHr183RM%252C_&vet=1&usg=AI4_-kTTgwVdag2kOteFZJ6jgqJ9_9l0sA&sa=X&ved=2ahUKEwj40bLH2ZXhAhWX7HMBHaiMBnIQ9QEwAHoECAcQBA#imgrc=qcRC0tnFWsRpFM:");
        }
    }
}