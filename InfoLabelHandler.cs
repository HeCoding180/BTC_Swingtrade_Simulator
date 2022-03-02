using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTC_Swingtrade_Simulator
{
    public class InfoLabelEventArgs : EventArgs
    {
        public string InfoLabelText { set; get; }
    }

    class InfoLabelHandler
    {
        //Public Attributes
        public event EventHandler<InfoLabelEventArgs> InfoLabelUpdate;

        //Private Attributes
        private int displayTime;
        private int updateDisplayTime;
        private Timer InfoLabelClearTimer = new Timer();

        public InfoLabelHandler(int displayTime_ms)
        {
            displayTime = displayTime_ms;

            InfoLabelClearTimer.Tick += InfoLabelClearTimer_Tick;
        }

        private void InfoLabelClearTimer_Tick(object sender, EventArgs e)
        {
            InfoLabelEventArgs EmptyInfoLabelEvArgs = new InfoLabelEventArgs();
            EmptyInfoLabelEvArgs.InfoLabelText = string.Empty;
            EventHandler<InfoLabelEventArgs> handler = InfoLabelUpdate;
            handler(this, EmptyInfoLabelEvArgs);

            InfoLabelClearTimer.Stop();
        }

        public void setDisplayTime(int displaytime_ms)
        {
            displayTime = displaytime_ms;
        }

        public void setInfo(string infoText)
        {
            InfoLabelClearTimer.Stop();

            InfoLabelEventArgs InfoLabelEvArgs = new InfoLabelEventArgs();
            InfoLabelEvArgs.InfoLabelText = infoText;
            EventHandler<InfoLabelEventArgs> handler = InfoLabelUpdate;
            handler(this, InfoLabelEvArgs);

            InfoLabelClearTimer.Interval = displayTime;
            InfoLabelClearTimer.Start();
        }
    }
}
