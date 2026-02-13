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
        private List<User> users = new List<User>();

        public UserPresenter (IUserModels model, IUsersView views)
        {
            model_ = model;
            views_ = views;
            users = model.Load();
            views_.ShowUsers(users);
        }

       
    }
}
