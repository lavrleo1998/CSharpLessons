using JsonDataBaseFootball.DataBase;
using JsonDataBaseFootball.Controllers;
using JsonDataBaseFootball.Entities;
using JsonDataBaseFootball.Services;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



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
            Download();
        }
        

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        /// <summary>
        /// ////////////////////////////////////////////
        /// Функции для кнопок
        /// Загрузка
        /// Удаление
        /// </summary>
        private void Download()
        {
            if (comboBoxDownload.SelectedValue.ToString() == events)
            {
                EventControllers.Print(richTextBoxDelete);
                Fill_inComboBox.DeleteComboBox<Event>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes)
            {
                EventTypeControllers.Print(richTextBoxDelete);
                Fill_inComboBox.DeleteComboBox<EventType>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers)
            {
                FootballerControllers.Print(richTextBoxDelete);
                Fill_inComboBox.DeleteComboBox<Footballer>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollersTeams)
            {
                FootballerTeamControllers.Print(richTextBoxDelete);
                Fill_inComboBox.DeleteComboBox<FootballerTeam>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == positions)
            {
                PositionControllers.Print(richTextBoxDelete);
                Fill_inComboBox.DeleteComboBox<Position>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == teams)
            {
                TeamControllers.Print(richTextBoxDelete);
                Fill_inComboBox.DeleteComboBox<Team>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == teamsTypes)
            {
                TeamTypeControllers.Print(richTextBoxDelete);
                Fill_inComboBox.DeleteComboBox<TeamType>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == trainers)
            {
                TrainerControllers.Print(richTextBoxDelete);
                Fill_inComboBox.DeleteComboBox<Trainer>(comboBoxDeleteByID);
            }
        }
        private void Delete()
        {
            if (comboBoxDownload.SelectedValue.ToString() == events) { EventServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); Download(); }
            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes) { EventTypeServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); Download(); }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers) { FootballerServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); Download(); }
            if (comboBoxDownload.SelectedValue.ToString() == teams) { TeamServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); Download(); }
            if (comboBoxDownload.SelectedValue.ToString() == teamsTypes) { TeamTypeServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); Download(); }
            if (comboBoxDownload.SelectedValue.ToString() == trainers) { TrainerServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); Download(); }
            if (comboBoxDownload.SelectedValue.ToString() == positions) { PositionServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); Download(); }
            if (comboBoxDownload.SelectedValue.ToString() == footbollersTeams) { FootballerTeamServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue)); Download(); }
        }

    }


    class EntitesForDownload
    {
        public string Name { get; set; }
    }
}
