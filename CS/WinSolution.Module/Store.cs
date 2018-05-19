using System;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    [DefaultClassOptions]
    public class Store : BaseObject {
        public Store(Session session) : base(session) { }
        private Employee _AssignedTo;
        public Employee AssignedTo {
            get { return _AssignedTo; }
            set { SetPropertyValue("AssignedTo", ref _AssignedTo, value); }
        }
        public override void AfterConstruction() {
            base.AfterConstruction();
            _AssignedTo = Session.GetObjectByKey<Employee>(SecuritySystem.CurrentUserId);
        }
        private string _Name;
        public string Name {
            get { return _Name; }
            set { SetPropertyValue("Name", ref _Name, value); }
        }
    }
}
