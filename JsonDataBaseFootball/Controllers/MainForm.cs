using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDataBaseFootball
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ///NewDB.GenerateFiles();
            ///NewDB.GenerateNewDB();
        }

        private void buttonGetTeamByFootballer_Click(object sender, EventArgs e)
        {
            var teamList = TeamServices.GetTeamByFootballer(Convert.ToInt32(textBox1.Text));
            foreach (var team in teamList) richTextBox1.Text += Convert.ToString(team) + "\n";
        }

        private void buttonGetTeamByTeamType_Click(object sender, EventArgs e)
        {
            var teamTypeList = TeamServices.GetTeamByTeamType(textBox2.Text);
            foreach (var type in teamTypeList) richTextBox1.Text += type + "\n";
        }

        private void buttonGetTeamByDate_Click(object sender, EventArgs e)
        {
            var teamList = TeamServices.GetTeamByDate(dateTimePicker1.Value.Date);
            foreach (var item in teamList) richTextBox1.Text += Convert.ToString(item) + "\n";
        }

        private void buttonGetEventsByFootballer_Click(object sender, EventArgs e)
        {
            var eventList = EventServices.GetEventsByFootballer(Convert.ToInt32(textBox4.Text));
            foreach (var item in eventList) richTextBox1.Text += Convert.ToString(item.ID) + " " + Convert.ToString(item.DateTime) + " " + Convert.ToString(item.EventTypeID) + "\n";
        }

        private void buttonGetEventsByFootballerAndDate_Click(object sender, EventArgs e)
        {
            var eventList = EventServices.GetEventsByFootballerAndDate(Convert.ToInt32(textBox5.Text), dateTimePicker2.Value.Date);
            foreach (var item in eventList)richTextBox1.Text += Convert.ToString(item.ID) + " " + Convert.ToString(item.DateTime) + " " + Convert.ToString(item.EventTypeID) + "\n";
        }
    }
}
