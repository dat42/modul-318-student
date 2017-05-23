using SwissTransport;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Windows_Forms
{
    public partial class FormMain : Form
    {
        private readonly ITransport transport = new Transport();

        public FormMain()
        {
            InitializeComponent();
        }

        //Bereitet die Form während des ladens vor
        private void FormMain_Load(object sender, EventArgs e)
        {
            SwissTransport.Transport transport = new SwissTransport.Transport();
            
            //Macht aus dem DateTimePicker eine TimePicker
            dtpttTime.Format = DateTimePickerFormat.Custom;
            dtpttTime.CustomFormat = "HH:mm";
            dtpttTime.ShowUpDown = true;

            dtpdbTime.Format = DateTimePickerFormat.Custom;
            dtpdbTime.CustomFormat = "HH:mm";
            dtpdbTime.ShowUpDown = true;

            //Setzt den Cursor in das erste Steuerelement
            cmbttFrom.Select();
        }


        //Tab-Controller, welcher bei einem Tab-Wechsel zum Einstatz kommt
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Setzt in den jeweiligen Tabs den Cursor in das erste Steuerelement
            if (tabControl1.SelectedTab == tabPagett)
            {
                cmbttFrom.Focus();
            }
            else if (tabControl1.SelectedTab == tabPagedb)
            {
                cmbdbFrom.Focus();
            }
            else if (tabControl1.SelectedTab == tabPagest)
            {
                cmbstStation.Focus();
            }

        }


        //Lädt die Station anhand der bereits eingegebenen Anfnagsbuchstaben
        private async void LoadComboboxItems(object sender, EventArgs e)
        {
            if (sender is ComboBox)
            {
                var cb = sender as ComboBox;

                var locationTo = cb.Text;

                //Holt die Angaben von der API und gibt Sie in der ComboBox aus
                var foundStation = await Task.Run(() => transport.GetStations(locationTo));
                cb.Items.Clear();
                foreach (var station in foundStation.StationList)
                {
                    cb.Items.Add(station);

                }
            }
        }


        //Sucht und Zeigt Verbindungen zwischen der Startstation und der Endstation
        private async void SearchConnection(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Enabled = false;
            this.ltvttTrip.Items.Clear();

            //Prüft ob eine Startstaion & Endstation gewählt ist
            if (this.cmbttTo.SelectedItem is Station &&
                this.cmbttFrom.SelectedItem is Station)
            {
                //Variabeln
                var fromStationId = ((Station)this.cmbttFrom.SelectedItem).Id;
                var toStationId = ((Station)this.cmbttTo.SelectedItem).Id;
                var time = this.dtpttTime.Value;
                var dateTime = this.dtpttDate.Value.Date
                    .AddHours(time.Hour)
                    .AddMinutes(time.Minute)
                    .AddSeconds(time.Second)
                    .AddMilliseconds(time.Millisecond);
                bool isArrivalTime = rabttArrival.Checked;
                
                //Holt die Angeben von der API und gibt Sie in der ListView aus
                var result = await Task.Run(() => transport.GetConnections(fromStationId, toStationId, dateTime, isArrivalTime));
                foreach (var connection in result.ConnectionList)
                {
                    var listViewItem = new ListViewItem(GetFormattedTimeString(connection.From.Departure));
                    listViewItem.SubItems.Add(GetFormattedTimeString(connection.To.Arrival));
                    listViewItem.SubItems.Add(GetFormattedDurationString(connection.Duration));
                    this.ltvttTrip.Items.Add(listViewItem);

                    button.Enabled = true;
                    this.cmbttFrom.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine Gültige Start- und Endstation ein.");
                button.Enabled = true;
                this.cmbttFrom.Focus();
            }
        }

        //Formatiert Date zu String für die Abfahrtszeit, bzw. für die Ankunftszeit
        private string GetFormattedTimeString(string date)
        {
            DateTime formattedDate = Convert.ToDateTime(date);

            //String, welcher zurück gebeben wird
            return formattedDate.ToString("HH:mm");
        }

        //Formatiert Date zu String für die Reisezeit
        private string GetFormattedDurationString(string time)
        {
            // 0d00:00:00 in 0.00:00:00
            time = time.Replace('d', '.');
            
            //Formateinstellung
            var timeSpan = TimeSpan.ParseExact(time, "c", CultureInfo.CurrentCulture);

            //String, welcher zurück gebeben wird
            return $"{timeSpan.Hours} h {timeSpan.Minutes} min";
        }


        //Sucht Verbindungen ab eiener Startstation
        private async void SearchTarget(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Enabled = false;
            this.ltvdbTrip.Items.Clear();

            //Prüft ob eine Starstation gewählt ist
            if (this.cmbdbFrom.SelectedItem is Station)
            {
                //Variabeln
                var fromStationId = ((Station)this.cmbdbFrom.SelectedItem).Id;
                var fromStation = ((Station)this.cmbdbFrom.SelectedItem).Name;
                var time = this.dtpdbTime.Value;
                var dateTime = this.dtpdbDate.Value.Date
                    .AddHours(time.Hour)
                    .AddMinutes(time.Minute)
                    .AddSeconds(time.Second)
                    .AddMilliseconds(time.Millisecond);

                //Holt die Angeben von der API und gibt Sie in der ListView aus
                var result = await Task.Run(() => transport.GetStationBoard(fromStation,fromStationId, dateTime));
                foreach (var connection in result.Entries)
                {
                    var listViewItem = new ListViewItem(connection.To);
                    listViewItem.SubItems.Add(connection.Stop.Departure.ToString());
                    this.ltvdbTrip.Items.Add(listViewItem);

                    button.Enabled = true;
                    this.cmbdbFrom.Focus();
                }
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine Gültige Startstation ein.");
                button.Enabled = true;
                this.cmbdbFrom.Focus();
            }
        }


        //Sucht eine Station und zeigt sie in der Map an
        private async void SearchStation(object sender, EventArgs e)
        {
            var button = sender as Button;
            button.Enabled = false;

            //Prüft ob eine Starstation gewählt ist
            if (this.cmbstStation.SelectedItem is Station)
            {
                //Holt die Koordinaten von der API und zeigt diese in der Map an
                var query = ((Station)this.cmbstStation.SelectedItem).Name;

                var result = await Task.Run(() => transport.GetStations(query));
                var station = (Station)this.cmbstStation.SelectedItem;
                String X = (station.Coordinate.XCoordinate.ToString().Replace(",","."));
                String Y = (station.Coordinate.YCoordinate.ToString().Replace(",", "."));

                this.txtstXCoordinate.Text=(X);
                this.txtstYCoordinate.Text=(Y);

                //URL für die Map (wego.here.com)
                var mapUrl = $"https://wego.here.com/?x=ep&map={this.txtstXCoordinate.Text},{this.txtstYCoordinate.Text},35,normal";
                this.webstMap.Navigate(mapUrl);

                button.Enabled = true;
                this.cmbstStation.Focus();
            }
            else
            {
                MessageBox.Show("Bitte geben Sie eine Station ein.");
                button.Enabled = true;
                this.cmbstStation.Focus();
            }
        }


        //Schliesst die Applikation
        private void CloseApplication(object sender, EventArgs e)
        {
            this.Close();
        }


        //Help-Funktion mit allen wichtigen Informationen
        private void Help(object sender, EventArgs e)
        {
            MessageBox.Show("Die Grundfunktiobnen sind in den drei Tabs:" +
                            "\n\n1: Verbindungen:" +
                            "\nStart- und Haltestelle eingeben. Weitere Optionen könnenn auswählen werden." +
                            "\n\n2: Abfahrtstafel:" +
                            "\nGeben Sie die Starthaltestelle. Weitere Optionen können ausgewählt werden." +
                            "\n\n3: Station:" +
                            "\nGeben Sie eine Statione ein." +
                            " Anschliessend immer auf den \"Suchen\"-Button klicken.");
        }
    }
}