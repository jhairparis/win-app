using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Test1
{
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            pnlNav.Height = btn_dashboard.Height;
            pnlNav.Top = btn_dashboard.Top;
            pnlNav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_dashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn_dashboard.Height;
            pnlNav.Top = btn_dashboard.Top;
            pnlNav.Left = btn_dashboard.Left;
            btn_dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_analytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn_analytics.Height;
            pnlNav.Top = btn_analytics.Top;
            pnlNav.Left = btn_analytics.Left;
            btn_analytics.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn_calendar.Height;
            pnlNav.Top = btn_calendar.Top;
            pnlNav.Left = btn_calendar.Left;
            btn_calendar.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void btn_contact_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn_contact.Height;
            pnlNav.Top = btn_contact.Top;
            pnlNav.Left = btn_contact.Left;
            btn_contact.BackColor = Color.FromArgb(46, 51, 73);
        }
        private void btn_settings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btn_settings.Height;
            pnlNav.Top = btn_settings.Top;
            pnlNav.Left = btn_settings.Left;
            btn_settings.BackColor = Color.FromArgb(46, 51, 73);

        }

        private void btn_dashboard_Leave(object sender, EventArgs e)
        {
            btn_dashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_analytics_Leave(object sender, EventArgs e)
        {
            btn_analytics.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_calendar_Leave(object sender, EventArgs e)
        {
            btn_calendar.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_contact_Leave(object sender, EventArgs e)
        {
            btn_contact.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btn_settings_Leave(object sender, EventArgs e)
        {
            btn_settings.BackColor = Color.FromArgb(24, 30, 54);
        }

           }
}
