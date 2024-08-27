using CoD.Runtime.Model;
using CoD.Runtime.ViewAbstractions;

namespace CoD.Runtime.Controller
{
    public class Reload
    {
        readonly Equipment model;
        readonly WeaponHUD view;
        
        public Reload(Equipment model, WeaponHUD view)
        {
            this.model = model;
            this.view = view;
        }

        public void Run()
        {
            model.Current.Reload();
            view.Refresh(model.Current);
        }
    }
}