using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamDeckBridge
{
    public partial class StreamDeckBridge : ServiceBase
    {
        public StreamDeckBridge()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            MessageBox.Show("hi!");
        }

        protected override void OnStop()
        {
            MessageBox.Show("bye!");
        }
    }
}
