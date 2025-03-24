using System.Windows.Forms;

namespace Project.Class
{
    public class SearchReports
    {
        private SearchTrans search = new SearchTrans();

        public void SearchTxbxReports(string txbx, string cmbx, DataGridView dgv)
        {
            search.SearchTxbx("SearchReportsTxbx", "SearchReportsTxbxInCmbx", cmbx, txbx, dgv);
        }

        public void SearchCmbxReports(string cmbx, DataGridView dgv)
        {
            search.searchCmbx("SearchReportsCmbx", cmbx, dgv);
        }
    }
}
