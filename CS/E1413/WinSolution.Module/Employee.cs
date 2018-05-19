using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace WinSolution.Module {
    public class Employee : SimpleUser {
        public Employee(Session session)
            : base(session) {
        }
    }
}
