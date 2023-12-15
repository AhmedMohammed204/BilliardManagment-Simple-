using System;
using System.Windows.Forms;

namespace BilliardManagment_Simple_
{
    public partial class frmTables : Form
    {
        public frmTables()
        {
            InitializeComponent();
        }

        struct stTable
        {
            public Button PauseBtn;
            public Button StartBtn;
            public Button DoneBtn;
            public Label lblTimer;
            public float TotalBill;
            public TimeSpan Time;
            public bool EnabledToTimer;
        }
        stTable Table1 = new stTable();
        stTable Table2 = new stTable();
        stTable Table3 = new stTable();
        private void frmTables_Load(object sender, EventArgs e)
        {
            Table1.PauseBtn = btnPause1;
            Table1.StartBtn = btnStart1;
            Table1.DoneBtn = btnDone1;
            Table1.lblTimer = lblTimerTable1;
            Table1.TotalBill = 0;
            Table1.EnabledToTimer = false;
            Table1.Time = new TimeSpan(0, 0, 0);

            Table2.PauseBtn = btnPause2;
            Table2.StartBtn = btnStart2;
            Table2.DoneBtn = btnDone2;
            Table2.lblTimer = lblTimerTable2;
            Table2.TotalBill = 0;
            Table2.EnabledToTimer = false;
            Table2.Time = new TimeSpan(0, 0, 0);

            Table3.PauseBtn = btnPause3;
            Table3.StartBtn = btnStart3;
            Table3.DoneBtn = btnDone3;
            Table3.lblTimer = lblTimerTable3;
            Table3.TotalBill = 0;
            Table3.EnabledToTimer = false;
            Table3.Time = new TimeSpan(0, 0, 0);


        }


        private void _ResetTable(stTable Table)
        {
            Table.lblTimer.Text = "00:00:00";
            Table.TotalBill = 0;
            Table.PauseBtn.Text = "Pause";
            Table.StartBtn.Tag = "false";
            Table.StartBtn.Enabled = true;
            Table.DoneBtn.Enabled = false;
            Table.PauseBtn.Enabled = false;
            Table.lblTimer.Enabled = true;
            Table.lblTimer.Tag = 0;
        }
        private stTable _GetTableFromBtn(Button btn)
        {

            timer1.Enabled = true;
            //Last letter
            switch (btn.Name[btn.Name.Length - 1].ToString())
            {
                case "1":
                    return Table1;
                case "2":
                    return Table2;
                case "3":
                    return Table3;
                default:
                    return Table1;
            }

        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            stTable Table = _GetTableFromBtn((Button)sender);
            Table.StartBtn.Tag = "true";
            Table.PauseBtn.Enabled = true;
            Table.DoneBtn.Enabled = true;
            Table.StartBtn.Enabled = false;

        }
        private void btnPause_Click(object sender, EventArgs e)
        {
            stTable Table = _GetTableFromBtn((Button)sender);
            if (Table.PauseBtn.Text == "Pause")
            {
                Table.PauseBtn.Text = "Continue";
                Table.lblTimer.Enabled = false;
                Table.StartBtn.Tag = "false";
            }
            else
            {
                Table.PauseBtn.Text = "Pause";
                Table.lblTimer.Enabled = true;
                Table.StartBtn.Tag = "true";
            }
        }
        private void btnDone_Click(object sender, EventArgs e)
        {
            stTable Table = _GetTableFromBtn((Button)sender);
            _ResetTable(Table);
            MessageBox.Show($"Your Total Bill is {Table.TotalBill.ToString()}$", "Total Bill", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Table1.StartBtn.Tag.ToString() == "true")
            {
                int NumberOfSeconds = Convert.ToInt32(lblTimerTable1.Tag) + 1;
                lblTimerTable1.Tag = NumberOfSeconds;
                Table1.Time = new TimeSpan(0, 0, NumberOfSeconds);
                Table1.lblTimer.Text = Table1.Time.ToString();
                Table1.TotalBill += 0.01f;
            }
            if (Table2.StartBtn.Tag.ToString() == "true")
            {
                int NumberOfSeconds = Convert.ToInt32(lblTimerTable2.Tag) + 1;
                lblTimerTable2.Tag = NumberOfSeconds;
                Table2.Time = new TimeSpan(0, 0, NumberOfSeconds);
                Table2.lblTimer.Text = Table2.Time.ToString();
                Table2.TotalBill += 0.01f;
            }
            if (Table3.StartBtn.Tag.ToString() == "true")
            {
                int NumberOfSeconds = Convert.ToInt32(lblTimerTable3.Tag) + 1;
                lblTimerTable3.Tag = NumberOfSeconds;
                Table3.Time = new TimeSpan(0, 0, NumberOfSeconds);
                Table3.lblTimer.Text = Table3.Time.ToString();
                Table3.TotalBill += 0.01f;
            }


        }


    }
}
