using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EKZBILETT
{
    public partial class FootbalLeague : Form
    {
        List<League> listLeague;
        
        public FootbalLeague()
        {
            
            InitializeComponent();
            List<string> RPLteams = new List<string>();
            RPLteams.Add("Зенит");
            RPLteams.Add("Спартак");
            RPLteams.Add("Краснодар");

            List<string> Premierteams = new List<string>();
            Premierteams.Add("Манчестер сити");
            Premierteams.Add("Манчестер юнайтед");
            Premierteams.Add("Арсенал");

            List<string> LaLigateams = new List<string>();
            LaLigateams.Add("РеалМадрид");
            LaLigateams.Add("Барселона");
            LaLigateams.Add("Атлетико Мадрид");

            List<string> Seriateams = new List<string>();
            Seriateams.Add("Ювентус");
            Seriateams.Add("Челси");
            Seriateams.Add("Порту");

            List<string> Bundesteams = new List<string>();
            Bundesteams.Add("Дортмунд");
            Bundesteams.Add("Бавария");
            Bundesteams.Add("Аугсбург");

            listLeague = new List<League>();
            listLeague.Add(new League("премьер лига", Premierteams));
            listLeague.Add(new League("РПЛ", RPLteams));
            listLeague.Add(new League("Ла Лига", LaLigateams));
            listLeague.Add(new League("Сериа А", Seriateams));
            listLeague.Add(new League("БундесЛига", Bundesteams));

            foreach (League league in listLeague)
            {
                LeagueComboBox.Items.Add(league.name_);
            }
        }

        private void LeagueComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            League selected = listLeague[LeagueComboBox.SelectedIndex];
            TeamListBox.Items.Clear();
            foreach (string team in selected.teams_)
            {
                TeamListBox.Items.Add(team);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (RenameTextBox.Text != "")
            {
                League selected = listLeague[LeagueComboBox.SelectedIndex];
                selected.teams_.Add(RenameTextBox.Text);
                TeamListBox.Items.Clear();
                foreach (string team in selected.teams_)
                {
                    TeamListBox.Items.Add(team);
                }
            }
            else 
            {
                MessageBox.Show("Введите название команды");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            
            if (LeagueComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите лигу");
            }
            else
            {
                if (TeamListBox.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите команду");
                }
                else
                {
                    League selected = listLeague[LeagueComboBox.SelectedIndex];
                    selected.teams_.RemoveAt(TeamListBox.SelectedIndex);
                    TeamListBox.Items.Clear();
                    foreach (string team in selected.teams_)
                    {
                        TeamListBox.Items.Add(team);
                    }
                }
            }    
        }

        private void RenameButton_Click(object sender, EventArgs e)
        {
            if (LeagueComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Выберите лигу");
            }
            else
            {
                if (RenameTextBox.Text != "")
                {
                    League selected = listLeague[LeagueComboBox.SelectedIndex];
                    selected.name_ = RenameTextBox.Text;
                    LeagueComboBox.Items.Clear();
                    foreach (League league in listLeague)
                    {
                        LeagueComboBox.Items.Add(league.name_);
                    }
                    LeagueComboBox.SelectedItem = RenameTextBox.Text;
                }
                else
                {
                    MessageBox.Show("Введите название лиги");
                }
            }
        }
    }
}
