using ModelViewLib.Models;
using ModelViewLib.ModelViews;
using ModelViewLib.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ModelViewLib.Presenter
{
    public class UserPresenter
    {
        private IUserModels model_;
        private IUsersView views_;
       

        public UserPresenter (IUserModels model, IUsersView views)
        {
            model_ = model;
            views_ = views;
            
            views_.ShowUsers(model_.Load());
        }

        public void RemoveUsers(List<User> users)
        {
            model_.RemoveUsers(users);
            views_.ShowUsers(model_.Load());
        
        }

        public void Adduser(User user)
        {
            model_.Adduser(user);
            views_.ShowUsers(model_.Load());
        }

        public IUserModels GetModel()
        {
            return model_;  
        }
    }
}
