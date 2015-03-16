using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace ProductInfoFromASIN
{
    internal class ProductInfoDataGridView : DataGridView
    {
        public ProductInfoDataGridView()
        {
            Initialize();
        }

        private void Initialize()
        {
            this.DoubleBuffered = true;

            this.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.DataGridView_CellFormatting);
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            if (dgv.Columns[e.ColumnIndex].Name == "ImageColumn" && e.RowIndex >= 0)
            {
                WebClient wc = new WebClient();
                var imageURL = (string)dgv[2, e.RowIndex].Value;
                Stream stream = wc.OpenRead(imageURL);
                Bitmap bitmap = new Bitmap(stream);
                stream.Close();
                dgv[1, e.RowIndex].Value = bitmap;
                e.Value = bitmap;
                e.FormattingApplied = true;
            }
        }

        internal void Configuration()
        {
            this.CurrentCell = null;
            this.ClearSelection();
        }
    }
}