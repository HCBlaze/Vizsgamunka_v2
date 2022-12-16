using Asztali_alkalmazas.Classes;
using Asztali_alkalmazas.UI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asztali_alkalmazas.UI
{
    public partial class Invoice : Form
    {
        private string createInvoiceDate;
        public string customerName, customerPhone, customerOrderDate, customerOrderNumber, customerTotalAmount;
        public DataTable dtInvoiceProduct;
        public Invoice()
        {
            InitializeComponent();

            createInvoiceDate = DateTime.Now.ToString("yyyy/MM/dd");
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        private void Print(Panel invoicePrint)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = invoicePrint;
            getPrintArea(invoicePrint);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryImage;

        private void getPrintArea(Panel invoicePrint)
        {
            memoryImage = new Bitmap(invoicePrint.Width+50, invoicePrint.Height);
            invoicePrint.DrawToBitmap(memoryImage, new Rectangle(0, 0, invoicePrint.Width, invoicePrint.Height));
        }
        private void Invoice_Load(object sender, EventArgs e)
        {
            invoiceCreateDate.Text = createInvoiceDate+".";
            invoiceCustomerName.Text = customerName;
            invoiceCustomerPhone.Text = customerPhone;
            invoiceOrderDate.Text = customerOrderDate;
            invoiceOrderNumber.Text = customerOrderNumber;
            invoiceTotalAmount.Text = customerTotalAmount;
            invoiceDGV.DataSource= dtInvoiceProduct;
            invoiceDGV.Columns[0].HeaderText = "Termék megnevezése";
            invoiceDGV.Columns[1].HeaderText = "Mennyiség";
            invoiceDGV.Columns[2].HeaderText = "Kiszerelés";
            invoiceDGV.Columns[3].HeaderText = "Termék ára(HUF)";

        }
    }
}
