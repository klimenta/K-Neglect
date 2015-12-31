using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K_Neglect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
                Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Nothing will be saved...", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

     

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            timer2.Enabled = checkBox2.Checked;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            timer3.Enabled = checkBox3.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strCurrentTime, strScheduledTime;
            strCurrentTime = DateTime.Now.ToString("h:mm tt");
            strScheduledTime = dateTimePicker1.Value.ToString("h:mm tt");
            if (strCurrentTime == strScheduledTime)
            {
                Show();
                WindowState = FormWindowState.Normal;
                SystemSounds.Beep.Play();               
                MessageBox.Show(textBox1.Text + " is due now!", "Reminder 1");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("K-Neglect v1.0" + "\n" + 
                "==========" + "\n" +
                "- You have 3 reminders. Type a description, schedule a time and check to enable." + "\n" +
                "- Don't schedule more than 24 hrs in advance." + "\n" + 
                "- You can choose a date, but the program doesn't check the dates." + "\n" +
                "- If you want to schedule something for tomorrow, schedule the time past." + "\n" +
                "- E.g. If it's 3PM and you want scheduled something for tomorrow 8AM," + "\n" +
                "  schedule the reminder for 8AM and leave the program running in the tray.", "Help");
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            string strCurrentTime, strScheduledTime;
            strCurrentTime = DateTime.Now.ToString("h:mm tt");
            strScheduledTime = dateTimePicker2.Value.ToString("h:mm tt");
            if (strCurrentTime == strScheduledTime)
            {
                Show();
                WindowState = FormWindowState.Normal;
                SystemSounds.Beep.Play();
                MessageBox.Show(textBox2.Text + " is due now!", "Reminder 2");
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            string strCurrentTime, strScheduledTime;
            strCurrentTime = DateTime.Now.ToString("h:mm tt");
            strScheduledTime = dateTimePicker3.Value.ToString("h:mm tt");
            if (strCurrentTime == strScheduledTime)
            {
                Show();
                WindowState = FormWindowState.Normal;
                SystemSounds.Beep.Play();
                MessageBox.Show(textBox3.Text + " is due now!", "Reminder 3");
            }
        }
    }
}
