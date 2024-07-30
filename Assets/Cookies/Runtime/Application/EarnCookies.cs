using Cookies.Runtime.Domain;

namespace Cookies.Runtime.Application
{
    public class EarnCookies
    {
        CookieBox model;
        CookieCounter view;
        
        public EarnCookies(CookieBox model, CookieCounter view)
        {
            this.model = model;
            this.view = view;
        }

        public void Run()
        {
            model.AddOnce();
            view.ShowCookies(model.Cookies);
        }
    }
}