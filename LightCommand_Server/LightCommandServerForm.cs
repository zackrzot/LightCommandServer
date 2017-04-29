using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LightCommand_Server
{
    public partial class LightCommandServerForm : Form
    {
        public Thread socketThread = null;


        public LightCommandServerForm()
        {
            InitializeComponent();

            this.FormClosing += LightCommandServerForm_Closing;

            Logger.Initialize(this);

            Logger.Log("Starting socket thread.");
            socketThread = new Thread(AsynchronousSocketListener.StartListening);
            socketThread.Start();
            Logger.Log("Socket thread started.");

            try
            {
                OpenDMX.start();                                            //find and connect to devive (first found if multiple)
                if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)       //update status
                    Logger.Log("No Enttec USB Device Found");
                else if (OpenDMX.status == FT_STATUS.FT_OK)
                    Logger.Log("Found DMX on USB");
                else
                    Logger.Log("Error Opening Device");
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                Logger.Log("Error Connecting to Enttec USB Device");
            }

            Array itemNames = System.Enum.GetNames(typeof(LightScript));

            foreach(var x in itemNames)
            {
                comboBox_scripts.Items.Add(x.ToString());
            }

            this.log_richTextBox.TextChanged += (sender, e) =>
            {
                if (this.log_richTextBox.Visible)
                {
                    this.log_richTextBox.SelectionStart = this.log_richTextBox.TextLength;
                    this.log_richTextBox.ScrollToCaret();
                }
            };
        }

        public void PrintToLog(String text)
        {
            if (this.log_richTextBox.InvokeRequired)
                this.log_richTextBox.BeginInvoke((MethodInvoker)delegate() { this.log_richTextBox.AppendText(text + "\n"); });
            else
            {
                try
                {
                    this.log_richTextBox.AppendText(text + "\n");
                }
                catch { }
            }
        }

        private void stop_all_button_Click(object sender, EventArgs e)
        {
            Logger.Log("Stopping lights.");

            if (OpenDMX.status == FT_STATUS.FT_DEVICE_NOT_FOUND)
                Logger.Log("No Enttec USB Device Found");
            else
                Logger.Log("Found DMX on USB");

            ScriptControl.StopLights();
        }

        public void SetSocketState(SocketState ss)
        {
            if (this.socket_status_label.InvokeRequired)
                this.socket_status_label.BeginInvoke((MethodInvoker)delegate() { this.socket_status_label.Text = ss.ToString(); });
            else
                this.socket_status_label.Text = ss.ToString();
        }

        public void SetIPText(String text)
        {
            if (this.server_ip_label.InvokeRequired)
                this.server_ip_label.BeginInvoke((MethodInvoker)delegate() { this.server_ip_label.Text = text; });
            else
                this.server_ip_label.Text = text;
        }

        public void SetLightStatus(LightStatus ls)
        {
            if (this.status_text_label.InvokeRequired)
                this.status_text_label.BeginInvoke((MethodInvoker)delegate() { this.status_text_label.Text = ls.ToString(); });
            else
                this.status_text_label.Text = ls.ToString();
        }

        public void SetClientStatus(ClientStatus cs)
        {
            if (this.client_status_label.InvokeRequired)
                this.client_status_label.BeginInvoke((MethodInvoker)delegate() { this.client_status_label.Text = cs.ToString(); });
            else
                this.client_status_label.Text = cs.ToString();
        }

        private void LightCommandServerForm_Closing(object sender, FormClosingEventArgs e)
        {
            Logger.Log("Stopping socket thread.");
            try
            {
                socketThread.Abort();
                Logger.Log("Socket thread stopped.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Unable to stop socket thread because: " + ex.ToString());
            }
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            SocketHelper.processMsg(comboBox_scripts.Text);
        }


    }
}
