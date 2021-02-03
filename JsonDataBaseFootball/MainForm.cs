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
           /// NewDB.GenerateFiles();
            ///NewDB.GenerateNewDB();
            /////////////////////////////////////////////////////
            var DownloadForDeleteAndUppdate = new List<EntitesForDownload>
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
            var DownloadForAdd = new List<EntitesForDownload>
        {
                new EntitesForDownload{ Name = "Ничего не выбрано"},
                new EntitesForDownload { Name = eventsTypes },
                new EntitesForDownload { Name = footbollers},
                new EntitesForDownload { Name = teamsTypes},
                new EntitesForDownload { Name = trainers},
                new EntitesForDownload { Name = positions},
        };
            comboBoxDownload.DataSource = DownloadForDeleteAndUppdate;
            comboBoxDownload.DisplayMember = "Name";
            comboBoxDownload.ValueMember = "Name";
            comboBoxAddEntites.DataSource = DownloadForAdd;
            comboBoxAddEntites.DisplayMember = "Name";
            comboBoxAddEntites.ValueMember = "Name";
        }

        ///Поиск по определенным вводным параметрам
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

        ///Добавление, удаление, изменени
        private void comboBoxDownload_SelectedIndexChanged(object sender, EventArgs e)
        {
            DownloadDelete();
            DownloadChange();
            DownloadAdd();
            FillChange();
            FillAdd();
        }
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        private void buttonChange_Click(object sender, EventArgs e)
        {
            Change();
        }
        private void buttonChangeTeam_Click(object sender, EventArgs e)
        {
            ChangeTeam();
        }
        private void buttonChangeEvent_Click(object sender, EventArgs e)
        {
            ChangeEvent();
        }
        private void buttonChangeFootTeam_Click(object sender, EventArgs e)
        {
            ChangeFootTeam();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            AddTeam();
        }
        private void buttonAddEvent_Click(object sender, EventArgs e)
        {
            AddEvent();
        }
        private void buttonAddFootTeam_Click(object sender, EventArgs e)
        {
            AddFootTeam();
        }

        ///Сами функции
        private void DownloadDelete()
        {
            if (comboBoxDownload.SelectedValue.ToString() == events)
            {
                EventControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Event>(comboBoxDeleteByID);

            }
            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes)
            {
                EventTypeControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<EventType>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers)
            {
                FootballerControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Footballer>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollersTeams)
            {
                FootballerTeamControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<FootballerTeam>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == positions)
            {
                PositionControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Position>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == teams)
            {
                TeamControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Team>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == teamsTypes)
            {
                TeamTypeControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<TeamType>(comboBoxDeleteByID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == trainers)
            {
                TrainerControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Trainer>(comboBoxDeleteByID);
            }
        }
        private void DownloadChange()
        {
            if (comboBoxDownload.SelectedValue.ToString() == events)
            {
                EventControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Event>(comboBoxEventID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes)
            {
                EventTypeControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<EventType>(comboBoxChangeEntityID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers)
            {
                FootballerControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Footballer>(comboBoxChangeEntityID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollersTeams)
            {
                FootballerTeamControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<FootballerTeam>(comboBoxFootTeamId);
            }
            if (comboBoxDownload.SelectedValue.ToString() == positions)
            {
                PositionControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Position>(comboBoxChangeEntityID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == teams)
            {
                TeamControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Team>(comboBoxTeamID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == teamsTypes)
            {
                TeamTypeControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<TeamType>(comboBoxChangeEntityID);
            }
            if (comboBoxDownload.SelectedValue.ToString() == trainers)
            {
                TrainerControllers.Print(richTextBoxMain);
                Fill_inComboBox.ID<Trainer>(comboBoxChangeEntityID);
            }
        }
        private void DownloadAdd()
        {
            if (comboBoxDownload.SelectedValue.ToString() == events)
            {
                EventControllers.Print(richTextBoxMain);
            }
            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes)
            {
                EventTypeControllers.Print(richTextBoxMain);
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers)
            {
                FootballerControllers.Print(richTextBoxMain);
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollersTeams)
            {
                FootballerTeamControllers.Print(richTextBoxMain);
            }
            if (comboBoxDownload.SelectedValue.ToString() == positions)
            {
                PositionControllers.Print(richTextBoxMain);
            }
            if (comboBoxDownload.SelectedValue.ToString() == teams)
            {
                TeamControllers.Print(richTextBoxMain);
            }
            if (comboBoxDownload.SelectedValue.ToString() == teamsTypes)
            {
                TeamTypeControllers.Print(richTextBoxMain);
            }
            if (comboBoxDownload.SelectedValue.ToString() == trainers)
            {
                TrainerControllers.Print(richTextBoxMain);
            }
        }
        private void FillChange()
        {
            Fill_inComboBox.Name<EventType>(comboBoxChangeEventType);
            Fill_inComboBox.Name<Team>(comboBoxChangeTeamForEvent);
            Fill_inComboBox.Name<Footballer>(comboBoxFootbollerID);
            Fill_inComboBox.Name<Team>(comboBoxTeamIDForFT);
            Fill_inComboBox.Name<Position>(comboBoxChangePositionForFootTeam);
            Fill_inComboBox.Name<TeamType>(comboBoxChangeTeamTypeForTeam);
        }
        private void FillAdd()
        {
            Fill_inComboBox.Name<EventType>(comboBoxAddEventType);
            Fill_inComboBox.Name<Team>(comboBoxAddEntiti);
            Fill_inComboBox.Name<Footballer>(comboBoxAddFootballerForFT);
            Fill_inComboBox.Name<Team>(comboBoxAddTeamForFT);
            Fill_inComboBox.Name<Position>(comboBoxAddPositionForFT);
            Fill_inComboBox.Name<TeamType>(comboBoxAddTeamTypeForNewTeam);
        }
        private void Delete()
        {
            if (comboBoxDownload.SelectedValue.ToString() == events)
            {
                EventServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue));
                DownloadDelete();
            }
            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes)
            {
                EventTypeServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue));
                DownloadDelete();
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers)
            {
                FootballerServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue));
                DownloadDelete();
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollersTeams)
            {
                FootballerTeamServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue));
                DownloadDelete();
            }
            if (comboBoxDownload.SelectedValue.ToString() == positions)
            {
                PositionServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue));
                DownloadDelete();
            }
            if (comboBoxDownload.SelectedValue.ToString() == teams)
            {
                TeamServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue));
                DownloadDelete();
            }
            if (comboBoxDownload.SelectedValue.ToString() == teamsTypes)
            {
                TeamTypeServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue));
                DownloadDelete();
            }
            if (comboBoxDownload.SelectedValue.ToString() == trainers)
            {
                TrainerServices.Delete(Convert.ToInt32(comboBoxDeleteByID.SelectedValue));
                DownloadDelete();
            }


        }
        private void Change()
        {

            if (comboBoxDownload.SelectedValue.ToString() == eventsTypes)
            {
                EventTypeServices.Update(
                    Convert.ToInt32(comboBoxChangeEntityID.SelectedValue),
                    textBoxChangeEntityName.Text);
                DownloadChange();
            }
            if (comboBoxDownload.SelectedValue.ToString() == footbollers)
            {
                FootballerServices.Update(
                    Convert.ToInt32(comboBoxChangeEntityID.SelectedValue),
                    textBoxChangeEntityName.Text);
                DownloadChange();
            }

            if (comboBoxDownload.SelectedValue.ToString() == teams)
            {
                TeamServices.Update(
                    Convert.ToInt32(comboBoxTeamID.SelectedValue.ToString()),
                    textBoxChangeTeamName.Text,
                    Convert.ToInt32(comboBoxChangeTeamTypeForTeam.SelectedValue.ToString())
                    );
                DownloadChange();
            }
            if (comboBoxDownload.SelectedValue.ToString() == trainers)
            {
                TrainerServices.Update(
                    Convert.ToInt32(comboBoxChangeEntityID.SelectedValue),
                    textBoxChangeEntityName.Text);
                DownloadChange();
            }
            if (comboBoxDownload.SelectedValue.ToString() == positions)
            {
                PositionServices.Update(
                    Convert.ToInt32(comboBoxChangeEntityID.SelectedValue),
                    textBoxChangeEntityName.Text);
                DownloadChange();
            }
        }
        private void ChangeTeam()
        {
            TeamServices.Update(
                      Convert.ToInt32(comboBoxTeamID.SelectedValue.ToString()),
                      textBoxChangeTeamName.Text,
                      Convert.ToInt32(comboBoxChangeTeamTypeForTeam.SelectedValue.ToString())
                      );
            DownloadChange();

        }
        private void ChangeEvent()
        {
            EventServices.Update(
                    Convert.ToInt32(comboBoxEventID.SelectedValue.ToString()),
                    dateTimePickerChangeEvent.Value,
                    Convert.ToInt32(comboBoxChangeEventType.SelectedValue.ToString()),
                    Convert.ToInt32(comboBoxChangeTeamForEvent.SelectedValue.ToString())
                    );
            DownloadChange();

        }
        private void ChangeFootTeam()
        {
            FootballerTeamServices.Update(
                     Convert.ToInt32(comboBoxFootTeamId.SelectedValue.ToString()),
                     Convert.ToInt32(comboBoxFootbollerID.SelectedValue.ToString()),
                     Convert.ToInt32(comboBoxTeamIDForFT.SelectedValue.ToString()),
                     Convert.ToInt32(comboBoxChangePositionForFootTeam.SelectedValue.ToString())
                     );
            DownloadChange();

        }
        private void Add()
        {
            if (comboBoxAddEntites.SelectedValue.ToString() == eventsTypes)
            {
                EventTypeServices.Add(999999,
                    textBoxAddNameEntites.Text);
                DownloadAdd();
            }
            if (comboBoxAddEntites.SelectedValue.ToString() == footbollers)
            {
                FootballerServices.Add(999999,
                    textBoxAddNameEntites.Text);
                DownloadAdd();
            }
            if (comboBoxAddEntites.SelectedValue.ToString() == teamsTypes)
            {
                TeamTypeServices.Add(999999,
                    textBoxAddNameEntites.Text);
                DownloadAdd();
            }
            if (comboBoxAddEntites.SelectedValue.ToString() == trainers)
            {
                TrainerServices.Add(999999,
                    textBoxAddNameEntites.Text);
                DownloadAdd();
            }
            if (comboBoxAddEntites.SelectedValue.ToString() == positions)
            {
                PositionServices.Add(999999,
                    textBoxAddNameEntites.Text);
                DownloadAdd();
            }

        }
        private void AddTeam()
        {
            TeamServices.Add(999999,
                textBoxAddNameTeam.Text,
                Convert.ToInt32(comboBoxAddTeamTypeForNewTeam.SelectedValue.ToString())
                );
            DownloadAdd();
        }
        private void AddEvent()
        {
            EventServices.Add(999999,
                   dateTimePickerAdd.Value,
                   Convert.ToInt32(comboBoxAddEventType.SelectedValue.ToString()),
                   Convert.ToInt32(comboBoxAddEntiti.SelectedValue.ToString())
                   );
            DownloadAdd();
        }
        private void AddFootTeam()
        {
            FootballerTeamServices.Add(99999,
                Convert.ToInt32(comboBoxAddFootballerForFT.SelectedValue.ToString()),
                Convert.ToInt32(comboBoxAddTeamForFT.SelectedValue.ToString()),
                Convert.ToInt32(comboBoxAddPositionForFT.SelectedValue.ToString())
                );
            DownloadAdd();
        }
    }
    class EntitesForDownload
    {
        public string Name { get; set; }
    }
}
