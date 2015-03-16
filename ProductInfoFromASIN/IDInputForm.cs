using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductInfoFromASIN
{
    public partial class IDInputForm : Form
    {
        private List<string> IDList = new List<string>();

        public IDInputForm()
        {
            InitializeComponent();
        }

        private void IDInputForm_Load(object sender, EventArgs e)
        {
        }

        public IEnumerable<string> GetAmazonIDs()
        {
            return IDList;
        }

        private void Button_OK(object sender, EventArgs e)
        {
            IDList.Add(textBox_AccessKey.Text);
            IDList.Add(textBox_SecretKey.Text);
            IDList.Add(textBox_SellerID.Text);
            IDList.Add(textBox_MarketplaceID.Text);
            this.Close();
        }

        private void Button_Cancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}