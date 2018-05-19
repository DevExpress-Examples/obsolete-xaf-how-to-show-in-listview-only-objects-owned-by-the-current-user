using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp.Updating;

namespace WinSolution.Module {
    public class Updater : ModuleUpdater {
        public Updater(DevExpress.ExpressApp.IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
        public override void UpdateDatabaseAfterUpdateSchema() {
            base.UpdateDatabaseAfterUpdateSchema();
            if (new XPCollection<Employee>(Session).Count == 0) {
                Employee admin = new Employee(Session);
                admin.UserName = "Administrator";
                admin.SetPassword("");
                admin.IsAdministrator = true;
                admin.Save();

                Store adminStore = new Store(Session);
                adminStore.Name = admin.UserName + " Store";
                adminStore.AssignedTo = admin;
                adminStore.Save();

                Employee user = new Employee(Session);
                user.UserName = "Sam";
                user.SetPassword("");
                user.Save();

                Store userStore = new Store(Session);
                userStore.Name = user.UserName + " Store";
                userStore.AssignedTo = user;
                userStore.Save();

                Employee user2 = new Employee(Session);
                user2.UserName = "John";
                user2.SetPassword("");
                user2.Save();

                Store user2Store = new Store(Session);
                user2Store.Name = user2.UserName + " Store";
                user2Store.AssignedTo = user2;
                user2Store.Save();
            }
        }
    }
}
