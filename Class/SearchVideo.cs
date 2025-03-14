using System.Windows.Forms;

namespace Project.Class
{
    public class SearchVideo
    {
        DataLoader dataLoader = new DataLoader();
        public void SearchTxbxDVD(string searchText, DataGridView dataGridView)
        {
            dataLoader.SearchTxbx("SearchTxbxDVD", searchText, dataGridView);
        }
        public void SearchTxbxVCD(string searchText, DataGridView dataGridView)
        {
            dataLoader.SearchTxbx("SearchTxbxVCD", searchText, dataGridView);
        }
    }
}
