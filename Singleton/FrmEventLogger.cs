using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton
{
    public partial class FrmEventLogger : Form
    {
        EventLogger logger;
        public FrmEventLogger()
        {
            InitializeComponent();
            logger = EventLogger.GetInstance();//Pide una instancia del Logger
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            logger.AddEvent(TxtMessage.Text);
            ShowEvents();
            TxtMessage.Text = string.Empty;
        }

        private void ShowEvents()
        {
            ListEvents.Items.Clear();
            var events = logger.GetEvents();
            foreach (var eventMessage in events)
            {
                ListEvents.Items.Add(eventMessage);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var logTareas = EventLogger.GetInstance(); //Pide nueva instancia
            logTareas.AddEvent(TxtMessage.Text);
            ShowEvents();
            TxtMessage.Text = string.Empty;
        }
    }
}
