using System;
using System.Drawing;
using System.Windows.Forms;

namespace BilliardManagment_Simple_
{
    public partial class frmMain : Form
    {
        private Button _ActiveBtn = null;
        private Form frmPrev = null;
        private void _OpenForm(Form frm)
        {

            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frmPrev = frm;
            panelScreens.Controls.Add(frm);
            frm.Show();
            frm.BringToFront();
        }
        private void _OpenScreen(Form frm, Button btn, Color LightColor, Color DarkColor)
        {
            if (_ActiveBtn != null)
            {
                _ActiveBtn.ForeColor = Color.Black;
                _ActiveBtn.BackColor = Color.WhiteSmoke;
            }

            lblLineOnTheLeftBtn.Visible = true;
            lblLineOnTheLeftBtn.Location = btn.Location;
            lblLineOnTheLeftBtn.BackColor = DarkColor;

            btn.BackColor = Color.Gainsboro;
            btn.ForeColor = DarkColor;
            lblScreenTitle.Text = frm.Text;
            lblScreenTitle.BackColor = DarkColor;
            _OpenForm(frm);
        }
        public frmMain()
        {
            InitializeComponent();
        }


        //To open it once
       
        frmTables frmTable = new frmTables();
        private void btnfrmTables_Click(object sender, EventArgs e)
        {
            _OpenScreen(frmTable, (Button)sender, Color.Aquamarine, Color.MediumAquamarine);
            _ActiveBtn = (Button)sender;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
