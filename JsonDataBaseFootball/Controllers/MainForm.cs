using JsonDataBaseFootball.DataBase;
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
using JsonDataBaseFootball.Controllers;

namespace JsonDataBaseFootball
{
    public partial class MainForm : Form
    {
        private const string events = "События";
        private const string eventsTypes = "Типы события";
        private const string footbollers = "Футболисты";
        private const string teams = "Составы";
        private const string teamsTypes = "Типы составов";
        private const string trainers = "Тренера";
        private const string positions = "Позиции";
        private const string footbollersTeams = "Футболисты и составы";
        public MainForm()
        {
            InitializeComponent();
            //NewDB.GenerateFiles();
            //NewDB.GenerateNewDB();
            /////////////////////////////////////////////////////
            var entitesForDownloads = new List<EntitesForDownload>
        {
                new EntitesForDownload{ Name = "Ничего не выбрано"},
                new EntitesForDownload { Name = events},
                new EntitesForDownload { Name = eventsTypes },
                new EntitesForDownload { Name = footbollers},
                new EntitesForDownload { Name = teams},
                new EntitesForDownload { Name = teamsTypes},
                new EntitesForDownload { Name = trainers},
                new EntitesForDownload { Name = positions},
                new EntitesForDownload { Name = footbollersTeams}
        };
            comboBoxDownload.DataSource = entitesForDownloads;
            comboBoxDownload.DisplayMember = "Name";
            comboBoxDownload.ValueMember = "Name";
            /////////////////////////////////////////////////////

            /////////////////////////////////////////////////////
        }

        private void buttonGetTeamByFootballer_Click(object sender, EventArgs e)
        {
            var teamList = TeamServices.GetByFootballer(Convert.ToInt32(textBox1.Text));
            foreach (var team in teamList) richTextBox1.Text += Convert.ToString(team) + "\n";
        }
        private void buttonGetTeamByTeamType_Click(object sender, EventArgs e)
        {
            var teamTypeList = TeamServices.GetByTeamType(textBox2.Text);
            foreach (var type in teamTypeList) richTextBox1.Text += type + "\n";
        }
        private void buttonGetTeamByDate_Click(object sender, EventArgs e)
        {
            var teamList = TeamServices.GetByDate(dateTimePicker1.Value.Date);
            foreach (var item in teamList) richTextBox1.Text += Convert.ToString(item) + "\n";
        }
        private void buttonGetEventsByFootballer_Click(object sender, EventArgs e)
        {
            var eventList = EventServices.GetByFootballer(Convert.ToInt32(textBox4.Text));
            foreach (var item in eventList) richTextBox1.Text += Convert.ToString(item.ID) + " " + Convert.ToString(item.DateTime) + " " + Convert.ToString(item.EventTypeID) + "\n";
        }
        private void buttonGetEventsByFootballerAndDate_Click(object sender, EventArgs e)
        {
            var eventList = EventServices.GetByFootballerAndDate(Convert.ToInt32(textBox5.Text), dateTimePicker2.Value.Date);
            foreach (var item in eventList) richTextBox1.Text += Convert.ToString(item.ID) + " " + Convert.ToString(item.DateTime) + " " + Convert.ToString(item.EventTypeID) + "\n";
        }

        private void comboBoxDownload_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxDownload.SelectedValue.ToString() == events)
            {
                richTextBoxDelete.Text = EventServices.Download();
                Fill_inComboBox.DeleteComboBox<Event>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes)
            {
                EventControllers.Method(richTextBoxDelete);
                DeleteComboBox<EventType>();
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers) { richTextBoxDelete.Text = FootballerServices.Download(); DeleteComboBox<Footballer>(); }
            if (comboBoxDownload.SelectedValue.ToString() == teams) { richTextBoxDelete.Text = TeamServices.Download(); DeleteComboBox<Team>(); }
            if (comboBoxDownload.SelectedValue.ToString() == teamsTypes) { richTextBoxDelete.Text = TeamTypeServices.Download(); DeleteComboBox<TeamType>(); }
            if (comboBoxDownload.SelectedValue.ToString() == trainers) { richTextBoxDelete.Text = TrainerServices.Download(); DeleteComboBox<Trainer>(); }
            if (comboBoxDownload.SelectedValue.ToString() == positions) { richTextBoxDelete.Text = PositionServices.Download(); DeleteComboBox<Position>(); }
            if (comboBoxDownload.SelectedValue.ToString() == footbollersTeams) { richTextBoxDelete.Text = FootballerTeamServices.Download(); DeleteComboBox<FootballerTeam>(); }
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (comboBoxDownload.SelectedValue.ToString() == events) { Repository.Delete<Event>(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); richTextBoxDelete.Text = EventServices.Download(); DeleteComboBox<Event>(); }
            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes) { Repository.Delete<EventType>(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); richTextBoxDelete.Text = EventTypeServices.Download(); DeleteComboBox<EventType>(); }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers) { Repository.Delete<Footballer>(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); richTextBoxDelete.Text = FootballerServices.Download(); DeleteComboBox<Footballer>(); }
            if (comboBoxDownload.SelectedValue.ToString() == teams) { Repository.Delete<Team>(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); richTextBoxDelete.Text = TeamServices.Download(); DeleteComboBox<Team>(); }
            if (comboBoxDownload.SelectedValue.ToString() == teamsTypes) { Repository.Delete<TeamType>(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); richTextBoxDelete.Text = TeamTypeServices.Download(); DeleteComboBox<TeamType>(); }
            if (comboBoxDownload.SelectedValue.ToString() == trainers) { Repository.Delete<Trainer>(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); richTextBoxDelete.Text = TrainerServices.Download(); DeleteComboBox<Trainer>(); }
            if (comboBoxDownload.SelectedValue.ToString() == positions) { Repository.Delete<Position>(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); richTextBoxDelete.Text = PositionServices.Download(); DeleteComboBox<Position>(); }
            if (comboBoxDownload.SelectedValue.ToString() == footbollersTeams) { Repository.Delete<FootballerTeam>(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); richTextBoxDelete.Text = FootballerTeamServices.Download(); DeleteComboBox<FootballerTeam>(); }

        }


    }

    static class Dowload
    {

    }

    class EntitesForDownload
    {
        public string Name { get; set; }
    }
}
