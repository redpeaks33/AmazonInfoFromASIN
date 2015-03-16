using System.Windows.Forms;

namespace ProductInfoFromASIN
{
    internal class ASINDataGridView : DataGridView
    {
        public ASINDataGridView()
        {
        }

        internal void InitializeCofiguration()
        {
            this.RowCount = 100;
        }
    }
}