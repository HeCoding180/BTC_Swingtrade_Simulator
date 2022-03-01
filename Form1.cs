using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTC_Swingtrade_Simulator
{
    public partial class Form1 : Form
    {
        public readonly Color DEFAULT_BACKCOLOR = Color.FromArgb(58, 64, 79);
        public readonly Color LIGHT_BACKCOLOR = Color.FromArgb(81, 87, 105);

        public readonly Color DEFAULT_FORECOLOR = Color.FromArgb(40, 121, 235);

        public readonly Color NEGATIVE_COURSE_COLOR = Color.FromArgb(255, 0, 0);
        public readonly Color POSITIVE_COURSE_COLOR = Color.FromArgb(43, 255, 0);

        MoneyTracker moneyTracker;

        public Form1()
        {
            using (Font checkFont = new Font("Open Sans Light", 9.75f, FontStyle.Regular, GraphicsUnit.Point))
            {
                if(checkFont.Name != "Open Sans Light")
                {
                    MessageBox.Show("\"Open Sans Light\" doesn't exist");
                    Process.Start(Directory.GetCurrentDirectory().Replace(@"\bin\Debug", @"\Resources\Fonts\OpenSans-Light.ttf"));
                }
                else
                {
                }
            }

            InitializeComponent();

            ReadBTC_Value BTCReader = new ReadBTC_Value(60); //60s delay between each Bitcoin value read
            moneyTracker = new MoneyTracker(0);
            BTCReader.NewBTCValueAvailable += moneyTracker.BTC_Tracker_NewBTCValueAvailable;
            BTCReader.Start();

            this.BackColor = DEFAULT_BACKCOLOR;
            MainPannel.BackColor = LIGHT_BACKCOLOR;

            lTitle.ForeColor = LIGHT_BACKCOLOR;

            BTCWorthLabel.ForeColor = DEFAULT_FORECOLOR;
        }

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }
            base.WndProc(ref m);
        }
        private void bClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
