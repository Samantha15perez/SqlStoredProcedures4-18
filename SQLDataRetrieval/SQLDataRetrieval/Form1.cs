using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLDataRetrieval
{
    public partial class Form1 : Form
    {
        SqlStoredProcedures dataWorks = new SqlStoredProcedures();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonLoad_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime FromDate = DateTime.Parse(textBoxFromDate.Text.ToString());
                DateTime UntilDate = DateTime.Parse(textBoxUntilDate.Text.ToString());


                dataGridSearchLog.DataSource = dataWorks.DtSearchLog(FromDate, UntilDate);
                dataGridJobLeadsPerDay.DataSource = dataWorks.DtJobLeadsPerDay(FromDate, UntilDate);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                textBoxFromDate.Text = "1/1/2012";
                textBoxUntilDate.Text = "4/18/2018";


                dataGridInactiveLeads.DataSource = dataWorks.DtInactive_Leads();
                dataGridLeadsBySource.DataSource = dataWorks.DtLeadsBySource();
                dataGridActiveContactList.DataSource = dataWorks.DtActiveContactList();
                dataGridActiveLeads.DataSource = dataWorks.DtActiveLeads();
                dataGridLeadReport.DataSource = dataWorks.DtLeadReport();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error ...");
            }
        }
    }
}
