using DevExpress.XtraReports.UI;
using identification_app.Classes;
using identification_app.Rapports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace identification_app.Formulaires
{
    public partial class frmRapport : Form
    {
        public frmRapport()
        {
            InitializeComponent();
        }

        private void frmRapport_Load(object sender, EventArgs e)
        {
            clsGlossaires.Getinstance().loadCombo("tprojet", "nom_projet", txtProjet);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                rptListeEqueteur rpt = new rptListeEqueteur();
                rpt.DataSource = clsGlossaires.Getinstance().get_Report_All("tpersonne");
                using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                rptAffectaionProjet rpt = new rptAffectaionProjet();
                rpt.DataSource = clsGlossaires.Getinstance().get_Report_All("vAffectation");
                using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                rptAffectaionProjet rpt = new rptAffectaionProjet();
                rpt.DataSource = clsGlossaires.Getinstance().get_Report_One("vAffectation", "refProjet", clsGlossaires.Getinstance().getcode_Combo("tprojet", "id", "nom_projet", txtProjet.Text));
                using (ReportPrintTool printTool = new ReportPrintTool(rpt))
                {
                    printTool.ShowPreviewDialog();
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message); }
        }
    }
}
