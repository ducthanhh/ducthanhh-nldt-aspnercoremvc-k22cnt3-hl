using Microsoft.AspNetCore.Mvc;

namespace nldtDay03View.Models.ViewCompoments
{
    public class NldtDemoCompoments:ViewCompoments
    {
        public IViewComponentResult Invoke()
        {
            List <Category> categories = new List <Category> ();
        }
    }
}
