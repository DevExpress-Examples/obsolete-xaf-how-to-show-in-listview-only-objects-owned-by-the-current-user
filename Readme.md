<!-- default file list -->
*Files to look at*:

* [AssignedToFilterListViewController.cs](./CS/WinSolution.Module/AssignedToFilterListViewController.cs) (VB: [AssignedToFilterListViewController.vb](./VB/WinSolution.Module/AssignedToFilterListViewController.vb))
* [Employee.cs](./CS/WinSolution.Module/Employee.cs) (VB: [Employee.vb](./VB/WinSolution.Module/Employee.vb))
* [Store.cs](./CS/WinSolution.Module/Store.cs) (VB: [Store.vb](./VB/WinSolution.Module/Store.vb))
* [Updater.cs](./CS/WinSolution.Module/Updater.cs) (VB: [Updater.vb](./VB/WinSolution.Module/Updater.vb))
<!-- default file list end -->
# OBSOLETE - How to show in ListView only objects owned by the current user


<p><strong>==================================<br />This example is now obsolete. </strong><strong>Instead u</strong><strong>se the </strong><strong>new </strong><a href="http://documentation.devexpress.com/#Xaf/CustomDocument3361"><strong><u>Security System</u></strong></a><strong> feature</strong><strong>s</strong><strong> (</strong><strong>see </strong><a href="https://www.devexpress.com/Support/Center/p/E4045">E4045</a><strong> example</strong><strong>)</strong> <strong>or the </strong><a href="http://documentation.devexpress.com/#Xaf/CustomDocument3307"><strong><u>IsCurrentUserInRole</u></strong></a><strong> criteria function</strong><strong>.</strong><strong><br />==================================</strong><br /><br />In this example the list view of the Store class will be filtered by the current employee, so that every employee sees only his own records.<br /> Run the sample project and log as Sam or John - you will see records assigned to these users only. However, if you log in as an Administrator you will see all records. This logic is coded in the controller that filters the list view.</p>
<p><strong>See Also:</strong><br /> <a href="https://www.devexpress.com/Support/Center/p/E2039">OBSOLETE - How to filter ListView to show only objects owned by the currently logged User</a><br /> <a href="http://documentation.devexpress.com/#XPO/CustomDocument4928">Criteria Language Syntax</a><br /> <a href="http://documentation.devexpress.com/#Xaf/CustomDocument2722">Filter List Views</a></p>

<br/>


