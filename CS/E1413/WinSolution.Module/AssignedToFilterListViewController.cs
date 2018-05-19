using System;
using DevExpress.ExpressApp;
using DevExpress.Data.Filtering;

namespace WinSolution.Module {
    public partial class AssignedToFilterListViewController : ViewController {
        public AssignedToFilterListViewController() {
            TargetObjectType = typeof(Store);
            TargetViewType = ViewType.ListView;
        }
        protected override void OnActivated() {
            base.OnActivated();
            ListView lv = (ListView)View;
            if (!((Employee)SecuritySystem.CurrentUser).IsAdministrator) {
                lv.CollectionSource.Criteria["AssignedTo"] = CriteriaOperator.Parse("AssignedTo.Oid = ?", SecuritySystem.CurrentUserId);
            }
        }
    }
}
