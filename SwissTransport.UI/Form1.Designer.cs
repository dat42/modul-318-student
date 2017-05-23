namespace Test_Windows_Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.schliessenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPagest = new System.Windows.Forms.TabPage();
            this.panstShow = new System.Windows.Forms.Panel();
            this.webstMap = new System.Windows.Forms.WebBrowser();
            this.panstSetting = new System.Windows.Forms.Panel();
            this.lblstYCoordinate = new System.Windows.Forms.Label();
            this.lblstXCoordinate = new System.Windows.Forms.Label();
            this.txtstYCoordinate = new System.Windows.Forms.TextBox();
            this.txtstXCoordinate = new System.Windows.Forms.TextBox();
            this.cmbstStation = new System.Windows.Forms.ComboBox();
            this.btnstSearch = new System.Windows.Forms.Button();
            this.lblstHeading = new System.Windows.Forms.Label();
            this.tabPagedb = new System.Windows.Forms.TabPage();
            this.pandbShow = new System.Windows.Forms.Panel();
            this.ltvdbTrip = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pandbSetting = new System.Windows.Forms.Panel();
            this.cmbdbFrom = new System.Windows.Forms.ComboBox();
            this.dtpdbDate = new System.Windows.Forms.DateTimePicker();
            this.btndbSearch = new System.Windows.Forms.Button();
            this.dtpdbTime = new System.Windows.Forms.DateTimePicker();
            this.lbldbFrom = new System.Windows.Forms.Label();
            this.lbldbHeading = new System.Windows.Forms.Label();
            this.tabPagett = new System.Windows.Forms.TabPage();
            this.panttShow = new System.Windows.Forms.Panel();
            this.ltvttTrip = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panttSetting = new System.Windows.Forms.Panel();
            this.gpbttSetting = new System.Windows.Forms.GroupBox();
            this.lblttType = new System.Windows.Forms.Label();
            this.lblttTime = new System.Windows.Forms.Label();
            this.lblttDate = new System.Windows.Forms.Label();
            this.dtpttDate = new System.Windows.Forms.DateTimePicker();
            this.dtpttTime = new System.Windows.Forms.DateTimePicker();
            this.rabttDeparture = new System.Windows.Forms.RadioButton();
            this.rabttArrival = new System.Windows.Forms.RadioButton();
            this.cmbttTo = new System.Windows.Forms.ComboBox();
            this.cmbttFrom = new System.Windows.Forms.ComboBox();
            this.btnttSearch = new System.Windows.Forms.Button();
            this.lblttTo = new System.Windows.Forms.Label();
            this.lblttFrom = new System.Windows.Forms.Label();
            this.lblttHeading = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.gpbdbSetting = new System.Windows.Forms.GroupBox();
            this.lbldbDate = new System.Windows.Forms.Label();
            this.lbldbTime = new System.Windows.Forms.Label();
            this.menuStripMain.SuspendLayout();
            this.tabPagest.SuspendLayout();
            this.panstShow.SuspendLayout();
            this.panstSetting.SuspendLayout();
            this.tabPagedb.SuspendLayout();
            this.pandbShow.SuspendLayout();
            this.pandbSetting.SuspendLayout();
            this.tabPagett.SuspendLayout();
            this.panttShow.SuspendLayout();
            this.panttSetting.SuspendLayout();
            this.gpbttSetting.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.gpbdbSetting.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(1123, 28);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schliessenToolStripMenuItem});
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(57, 24);
            this.closeToolStripMenuItem.Text = "Datei";
            // 
            // schliessenToolStripMenuItem
            // 
            this.schliessenToolStripMenuItem.Name = "schliessenToolStripMenuItem";
            this.schliessenToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.schliessenToolStripMenuItem.Text = "Schliessen";
            this.schliessenToolStripMenuItem.Click += new System.EventHandler(this.CloseApplication);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Hilfe";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.Help);
            // 
            // tabPagest
            // 
            this.tabPagest.Controls.Add(this.panstShow);
            this.tabPagest.Controls.Add(this.panstSetting);
            this.tabPagest.Location = new System.Drawing.Point(4, 25);
            this.tabPagest.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagest.Name = "tabPagest";
            this.tabPagest.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagest.Size = new System.Drawing.Size(1115, 637);
            this.tabPagest.TabIndex = 3;
            this.tabPagest.Text = "Stationen";
            this.tabPagest.UseVisualStyleBackColor = true;
            // 
            // panstShow
            // 
            this.panstShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panstShow.Controls.Add(this.webstMap);
            this.panstShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panstShow.Location = new System.Drawing.Point(4, 178);
            this.panstShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panstShow.Name = "panstShow";
            this.panstShow.Size = new System.Drawing.Size(1107, 455);
            this.panstShow.TabIndex = 6;
            // 
            // webstMap
            // 
            this.webstMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webstMap.Location = new System.Drawing.Point(0, 0);
            this.webstMap.MinimumSize = new System.Drawing.Size(20, 20);
            this.webstMap.Name = "webstMap";
            this.webstMap.Size = new System.Drawing.Size(1103, 451);
            this.webstMap.TabIndex = 0;
            // 
            // panstSetting
            // 
            this.panstSetting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panstSetting.Controls.Add(this.lblstYCoordinate);
            this.panstSetting.Controls.Add(this.lblstXCoordinate);
            this.panstSetting.Controls.Add(this.txtstYCoordinate);
            this.panstSetting.Controls.Add(this.txtstXCoordinate);
            this.panstSetting.Controls.Add(this.cmbstStation);
            this.panstSetting.Controls.Add(this.btnstSearch);
            this.panstSetting.Controls.Add(this.lblstHeading);
            this.panstSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.panstSetting.Location = new System.Drawing.Point(4, 4);
            this.panstSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panstSetting.Name = "panstSetting";
            this.panstSetting.Size = new System.Drawing.Size(1107, 174);
            this.panstSetting.TabIndex = 5;
            // 
            // lblstYCoordinate
            // 
            this.lblstYCoordinate.AutoSize = true;
            this.lblstYCoordinate.Location = new System.Drawing.Point(865, 79);
            this.lblstYCoordinate.Name = "lblstYCoordinate";
            this.lblstYCoordinate.Size = new System.Drawing.Size(95, 17);
            this.lblstYCoordinate.TabIndex = 6;
            this.lblstYCoordinate.Text = "Y-Koordinate:";
            // 
            // lblstXCoordinate
            // 
            this.lblstXCoordinate.AutoSize = true;
            this.lblstXCoordinate.Location = new System.Drawing.Point(865, 40);
            this.lblstXCoordinate.Name = "lblstXCoordinate";
            this.lblstXCoordinate.Size = new System.Drawing.Size(95, 17);
            this.lblstXCoordinate.TabIndex = 5;
            this.lblstXCoordinate.Text = "X-Koordinate:";
            // 
            // txtstYCoordinate
            // 
            this.txtstYCoordinate.Location = new System.Drawing.Point(966, 79);
            this.txtstYCoordinate.Name = "txtstYCoordinate";
            this.txtstYCoordinate.ReadOnly = true;
            this.txtstYCoordinate.Size = new System.Drawing.Size(100, 22);
            this.txtstYCoordinate.TabIndex = 4;
            this.txtstYCoordinate.TabStop = false;
            // 
            // txtstXCoordinate
            // 
            this.txtstXCoordinate.Location = new System.Drawing.Point(966, 40);
            this.txtstXCoordinate.Name = "txtstXCoordinate";
            this.txtstXCoordinate.ReadOnly = true;
            this.txtstXCoordinate.Size = new System.Drawing.Size(100, 22);
            this.txtstXCoordinate.TabIndex = 3;
            this.txtstXCoordinate.TabStop = false;
            // 
            // cmbstStation
            // 
            this.cmbstStation.FormattingEnabled = true;
            this.cmbstStation.Location = new System.Drawing.Point(49, 92);
            this.cmbstStation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbstStation.Name = "cmbstStation";
            this.cmbstStation.Size = new System.Drawing.Size(321, 24);
            this.cmbstStation.TabIndex = 0;
            this.cmbstStation.DropDown += new System.EventHandler(this.LoadComboboxItems);
            // 
            // btnstSearch
            // 
            this.btnstSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnstSearch.Location = new System.Drawing.Point(404, 79);
            this.btnstSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnstSearch.Name = "btnstSearch";
            this.btnstSearch.Size = new System.Drawing.Size(321, 41);
            this.btnstSearch.TabIndex = 2;
            this.btnstSearch.Text = "Station Suchen";
            this.btnstSearch.UseVisualStyleBackColor = true;
            this.btnstSearch.Click += new System.EventHandler(this.SearchStation);
            // 
            // lblstHeading
            // 
            this.lblstHeading.AutoSize = true;
            this.lblstHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblstHeading.Location = new System.Drawing.Point(116, 26);
            this.lblstHeading.Name = "lblstHeading";
            this.lblstHeading.Size = new System.Drawing.Size(141, 36);
            this.lblstHeading.TabIndex = 0;
            this.lblstHeading.Text = "Stationen";
            // 
            // tabPagedb
            // 
            this.tabPagedb.Controls.Add(this.pandbShow);
            this.tabPagedb.Controls.Add(this.pandbSetting);
            this.tabPagedb.Location = new System.Drawing.Point(4, 25);
            this.tabPagedb.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagedb.Name = "tabPagedb";
            this.tabPagedb.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagedb.Size = new System.Drawing.Size(1115, 637);
            this.tabPagedb.TabIndex = 2;
            this.tabPagedb.Text = "Abfahtstafel";
            this.tabPagedb.UseVisualStyleBackColor = true;
            // 
            // pandbShow
            // 
            this.pandbShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pandbShow.Controls.Add(this.ltvdbTrip);
            this.pandbShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pandbShow.Location = new System.Drawing.Point(404, 4);
            this.pandbShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pandbShow.Name = "pandbShow";
            this.pandbShow.Size = new System.Drawing.Size(707, 629);
            this.pandbShow.TabIndex = 4;
            // 
            // ltvdbTrip
            // 
            this.ltvdbTrip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader7});
            this.ltvdbTrip.FullRowSelect = true;
            this.ltvdbTrip.GridLines = true;
            this.ltvdbTrip.Location = new System.Drawing.Point(33, 63);
            this.ltvdbTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltvdbTrip.Name = "ltvdbTrip";
            this.ltvdbTrip.Size = new System.Drawing.Size(651, 536);
            this.ltvdbTrip.TabIndex = 0;
            this.ltvdbTrip.UseCompatibleStateImageBehavior = false;
            this.ltvdbTrip.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Zielort";
            this.columnHeader10.Width = 267;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Abfahrtszeit";
            this.columnHeader7.Width = 158;
            // 
            // pandbSetting
            // 
            this.pandbSetting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pandbSetting.Controls.Add(this.gpbdbSetting);
            this.pandbSetting.Controls.Add(this.cmbdbFrom);
            this.pandbSetting.Controls.Add(this.btndbSearch);
            this.pandbSetting.Controls.Add(this.lbldbFrom);
            this.pandbSetting.Controls.Add(this.lbldbHeading);
            this.pandbSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.pandbSetting.Location = new System.Drawing.Point(4, 4);
            this.pandbSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pandbSetting.Name = "pandbSetting";
            this.pandbSetting.Size = new System.Drawing.Size(400, 629);
            this.pandbSetting.TabIndex = 3;
            // 
            // cmbdbFrom
            // 
            this.cmbdbFrom.FormattingEnabled = true;
            this.cmbdbFrom.Location = new System.Drawing.Point(133, 89);
            this.cmbdbFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbdbFrom.Name = "cmbdbFrom";
            this.cmbdbFrom.Size = new System.Drawing.Size(223, 24);
            this.cmbdbFrom.TabIndex = 0;
            this.cmbdbFrom.DropDown += new System.EventHandler(this.LoadComboboxItems);
            // 
            // dtpdbDate
            // 
            this.dtpdbDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdbDate.Location = new System.Drawing.Point(19, 54);
            this.dtpdbDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdbDate.Name = "dtpdbDate";
            this.dtpdbDate.Size = new System.Drawing.Size(285, 22);
            this.dtpdbDate.TabIndex = 2;
            // 
            // btndbSearch
            // 
            this.btndbSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndbSearch.Location = new System.Drawing.Point(35, 490);
            this.btndbSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btndbSearch.Name = "btndbSearch";
            this.btndbSearch.Size = new System.Drawing.Size(323, 62);
            this.btndbSearch.TabIndex = 4;
            this.btndbSearch.Text = "Verbindungen Suchen";
            this.btndbSearch.UseVisualStyleBackColor = true;
            this.btndbSearch.Click += new System.EventHandler(this.SearchTarget);
            // 
            // dtpdbTime
            // 
            this.dtpdbTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpdbTime.Location = new System.Drawing.Point(19, 128);
            this.dtpdbTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpdbTime.Name = "dtpdbTime";
            this.dtpdbTime.Size = new System.Drawing.Size(285, 22);
            this.dtpdbTime.TabIndex = 3;
            // 
            // lbldbFrom
            // 
            this.lbldbFrom.AutoSize = true;
            this.lbldbFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldbFrom.Location = new System.Drawing.Point(29, 89);
            this.lbldbFrom.Name = "lbldbFrom";
            this.lbldbFrom.Size = new System.Drawing.Size(55, 29);
            this.lbldbFrom.TabIndex = 1;
            this.lbldbFrom.Text = "Von";
            // 
            // lbldbHeading
            // 
            this.lbldbHeading.AutoSize = true;
            this.lbldbHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldbHeading.Location = new System.Drawing.Point(116, 26);
            this.lbldbHeading.Name = "lbldbHeading";
            this.lbldbHeading.Size = new System.Drawing.Size(184, 36);
            this.lbldbHeading.TabIndex = 0;
            this.lbldbHeading.Text = "Abfahrtsplan";
            // 
            // tabPagett
            // 
            this.tabPagett.Controls.Add(this.panttShow);
            this.tabPagett.Controls.Add(this.panttSetting);
            this.tabPagett.Location = new System.Drawing.Point(4, 25);
            this.tabPagett.Margin = new System.Windows.Forms.Padding(4);
            this.tabPagett.Name = "tabPagett";
            this.tabPagett.Padding = new System.Windows.Forms.Padding(4);
            this.tabPagett.Size = new System.Drawing.Size(1115, 637);
            this.tabPagett.TabIndex = 0;
            this.tabPagett.Text = "Fahrplan";
            this.tabPagett.UseVisualStyleBackColor = true;
            // 
            // panttShow
            // 
            this.panttShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panttShow.Controls.Add(this.ltvttTrip);
            this.panttShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panttShow.Location = new System.Drawing.Point(404, 4);
            this.panttShow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panttShow.Name = "panttShow";
            this.panttShow.Size = new System.Drawing.Size(707, 629);
            this.panttShow.TabIndex = 6;
            // 
            // ltvttTrip
            // 
            this.ltvttTrip.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ltvttTrip.FullRowSelect = true;
            this.ltvttTrip.GridLines = true;
            this.ltvttTrip.Location = new System.Drawing.Point(33, 63);
            this.ltvttTrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ltvttTrip.Name = "ltvttTrip";
            this.ltvttTrip.Size = new System.Drawing.Size(651, 536);
            this.ltvttTrip.TabIndex = 0;
            this.ltvttTrip.UseCompatibleStateImageBehavior = false;
            this.ltvttTrip.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Abfahrtszeit";
            this.columnHeader4.Width = 187;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Ankunftszeit";
            this.columnHeader5.Width = 176;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Reisezeit";
            this.columnHeader6.Width = 99;
            // 
            // panttSetting
            // 
            this.panttSetting.BackColor = System.Drawing.Color.Transparent;
            this.panttSetting.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panttSetting.Controls.Add(this.gpbttSetting);
            this.panttSetting.Controls.Add(this.cmbttTo);
            this.panttSetting.Controls.Add(this.cmbttFrom);
            this.panttSetting.Controls.Add(this.btnttSearch);
            this.panttSetting.Controls.Add(this.lblttTo);
            this.panttSetting.Controls.Add(this.lblttFrom);
            this.panttSetting.Controls.Add(this.lblttHeading);
            this.panttSetting.Dock = System.Windows.Forms.DockStyle.Left;
            this.panttSetting.Location = new System.Drawing.Point(4, 4);
            this.panttSetting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panttSetting.Name = "panttSetting";
            this.panttSetting.Size = new System.Drawing.Size(400, 629);
            this.panttSetting.TabIndex = 5;
            this.panttSetting.TabStop = true;
            // 
            // gpbttSetting
            // 
            this.gpbttSetting.Controls.Add(this.lblttType);
            this.gpbttSetting.Controls.Add(this.lblttTime);
            this.gpbttSetting.Controls.Add(this.lblttDate);
            this.gpbttSetting.Controls.Add(this.dtpttDate);
            this.gpbttSetting.Controls.Add(this.dtpttTime);
            this.gpbttSetting.Controls.Add(this.rabttDeparture);
            this.gpbttSetting.Controls.Add(this.rabttArrival);
            this.gpbttSetting.Location = new System.Drawing.Point(35, 188);
            this.gpbttSetting.Name = "gpbttSetting";
            this.gpbttSetting.Size = new System.Drawing.Size(323, 278);
            this.gpbttSetting.TabIndex = 2;
            this.gpbttSetting.TabStop = false;
            this.gpbttSetting.Text = "Weitere Optionen";
            // 
            // lblttType
            // 
            this.lblttType.AutoSize = true;
            this.lblttType.Location = new System.Drawing.Point(16, 187);
            this.lblttType.Name = "lblttType";
            this.lblttType.Size = new System.Drawing.Size(32, 17);
            this.lblttType.TabIndex = 8;
            this.lblttType.Text = "Typ";
            // 
            // lblttTime
            // 
            this.lblttTime.AutoSize = true;
            this.lblttTime.Location = new System.Drawing.Point(16, 109);
            this.lblttTime.Name = "lblttTime";
            this.lblttTime.Size = new System.Drawing.Size(32, 17);
            this.lblttTime.TabIndex = 7;
            this.lblttTime.Text = "Zeit";
            // 
            // lblttDate
            // 
            this.lblttDate.AutoSize = true;
            this.lblttDate.Location = new System.Drawing.Point(16, 35);
            this.lblttDate.Name = "lblttDate";
            this.lblttDate.Size = new System.Drawing.Size(49, 17);
            this.lblttDate.TabIndex = 6;
            this.lblttDate.Text = "Datum";
            // 
            // dtpttDate
            // 
            this.dtpttDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpttDate.Location = new System.Drawing.Point(19, 54);
            this.dtpttDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpttDate.Name = "dtpttDate";
            this.dtpttDate.Size = new System.Drawing.Size(285, 22);
            this.dtpttDate.TabIndex = 3;
            // 
            // dtpttTime
            // 
            this.dtpttTime.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpttTime.Location = new System.Drawing.Point(19, 128);
            this.dtpttTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpttTime.Name = "dtpttTime";
            this.dtpttTime.Size = new System.Drawing.Size(285, 22);
            this.dtpttTime.TabIndex = 4;
            // 
            // rabttDeparture
            // 
            this.rabttDeparture.AutoSize = true;
            this.rabttDeparture.Checked = true;
            this.rabttDeparture.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabttDeparture.Location = new System.Drawing.Point(19, 216);
            this.rabttDeparture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rabttDeparture.Name = "rabttDeparture";
            this.rabttDeparture.Size = new System.Drawing.Size(96, 29);
            this.rabttDeparture.TabIndex = 5;
            this.rabttDeparture.TabStop = true;
            this.rabttDeparture.Text = "Abfahrt";
            this.rabttDeparture.UseVisualStyleBackColor = true;
            // 
            // rabttArrival
            // 
            this.rabttArrival.AutoSize = true;
            this.rabttArrival.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rabttArrival.Location = new System.Drawing.Point(145, 216);
            this.rabttArrival.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rabttArrival.Name = "rabttArrival";
            this.rabttArrival.Size = new System.Drawing.Size(100, 29);
            this.rabttArrival.TabIndex = 6;
            this.rabttArrival.TabStop = true;
            this.rabttArrival.Text = "Ankunft";
            this.rabttArrival.UseVisualStyleBackColor = true;
            // 
            // cmbttTo
            // 
            this.cmbttTo.FormattingEnabled = true;
            this.cmbttTo.Location = new System.Drawing.Point(133, 135);
            this.cmbttTo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbttTo.Name = "cmbttTo";
            this.cmbttTo.Size = new System.Drawing.Size(223, 24);
            this.cmbttTo.TabIndex = 1;
            this.cmbttTo.DropDown += new System.EventHandler(this.LoadComboboxItems);
            // 
            // cmbttFrom
            // 
            this.cmbttFrom.FormattingEnabled = true;
            this.cmbttFrom.Location = new System.Drawing.Point(133, 89);
            this.cmbttFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbttFrom.Name = "cmbttFrom";
            this.cmbttFrom.Size = new System.Drawing.Size(223, 24);
            this.cmbttFrom.TabIndex = 0;
            this.cmbttFrom.DropDown += new System.EventHandler(this.LoadComboboxItems);
            // 
            // btnttSearch
            // 
            this.btnttSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnttSearch.Location = new System.Drawing.Point(35, 490);
            this.btnttSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnttSearch.Name = "btnttSearch";
            this.btnttSearch.Size = new System.Drawing.Size(323, 62);
            this.btnttSearch.TabIndex = 7;
            this.btnttSearch.Text = "Verbindungen Suchen";
            this.btnttSearch.UseVisualStyleBackColor = true;
            this.btnttSearch.Click += new System.EventHandler(this.SearchConnection);
            // 
            // lblttTo
            // 
            this.lblttTo.AutoSize = true;
            this.lblttTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttTo.Location = new System.Drawing.Point(29, 132);
            this.lblttTo.Name = "lblttTo";
            this.lblttTo.Size = new System.Drawing.Size(69, 29);
            this.lblttTo.TabIndex = 2;
            this.lblttTo.Text = "Nach";
            // 
            // lblttFrom
            // 
            this.lblttFrom.AutoSize = true;
            this.lblttFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttFrom.Location = new System.Drawing.Point(29, 89);
            this.lblttFrom.Name = "lblttFrom";
            this.lblttFrom.Size = new System.Drawing.Size(55, 29);
            this.lblttFrom.TabIndex = 1;
            this.lblttFrom.Text = "Von";
            // 
            // lblttHeading
            // 
            this.lblttHeading.AutoSize = true;
            this.lblttHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblttHeading.Location = new System.Drawing.Point(116, 26);
            this.lblttHeading.Name = "lblttHeading";
            this.lblttHeading.Size = new System.Drawing.Size(133, 36);
            this.lblttHeading.TabIndex = 0;
            this.lblttHeading.Text = "Fahrplan";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPagett);
            this.tabControl1.Controls.Add(this.tabPagedb);
            this.tabControl1.Controls.Add(this.tabPagest);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1123, 666);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // gpbdbSetting
            // 
            this.gpbdbSetting.Controls.Add(this.lbldbTime);
            this.gpbdbSetting.Controls.Add(this.lbldbDate);
            this.gpbdbSetting.Controls.Add(this.dtpdbDate);
            this.gpbdbSetting.Controls.Add(this.dtpdbTime);
            this.gpbdbSetting.Location = new System.Drawing.Point(35, 188);
            this.gpbdbSetting.Name = "gpbdbSetting";
            this.gpbdbSetting.Size = new System.Drawing.Size(323, 193);
            this.gpbdbSetting.TabIndex = 1;
            this.gpbdbSetting.TabStop = false;
            this.gpbdbSetting.Text = "Weiter Optionen";
            // 
            // lbldbDate
            // 
            this.lbldbDate.AutoSize = true;
            this.lbldbDate.Location = new System.Drawing.Point(16, 35);
            this.lbldbDate.Name = "lbldbDate";
            this.lbldbDate.Size = new System.Drawing.Size(49, 17);
            this.lbldbDate.TabIndex = 3;
            this.lbldbDate.Text = "Datum";
            // 
            // lbldbTime
            // 
            this.lbldbTime.AutoSize = true;
            this.lbldbTime.Location = new System.Drawing.Point(16, 109);
            this.lbldbTime.Name = "lbldbTime";
            this.lbldbTime.Size = new System.Drawing.Size(32, 17);
            this.lbldbTime.TabIndex = 4;
            this.lbldbTime.Text = "Zeit";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1123, 694);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStripMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "SwisTransport";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabPagest.ResumeLayout(false);
            this.panstShow.ResumeLayout(false);
            this.panstSetting.ResumeLayout(false);
            this.panstSetting.PerformLayout();
            this.tabPagedb.ResumeLayout(false);
            this.pandbShow.ResumeLayout(false);
            this.pandbSetting.ResumeLayout(false);
            this.pandbSetting.PerformLayout();
            this.tabPagett.ResumeLayout(false);
            this.panttShow.ResumeLayout(false);
            this.panttSetting.ResumeLayout(false);
            this.panttSetting.PerformLayout();
            this.gpbttSetting.ResumeLayout(false);
            this.gpbttSetting.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.gpbdbSetting.ResumeLayout(false);
            this.gpbdbSetting.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem schliessenToolStripMenuItem;
        private System.Windows.Forms.TabPage tabPagest;
        private System.Windows.Forms.Panel panstShow;
        private System.Windows.Forms.Panel panstSetting;
        private System.Windows.Forms.ComboBox cmbstStation;
        private System.Windows.Forms.Button btnstSearch;
        private System.Windows.Forms.Label lblstHeading;
        private System.Windows.Forms.TabPage tabPagedb;
        private System.Windows.Forms.Panel pandbShow;
        private System.Windows.Forms.ListView ltvdbTrip;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Panel pandbSetting;
        private System.Windows.Forms.ComboBox cmbdbFrom;
        private System.Windows.Forms.DateTimePicker dtpdbDate;
        private System.Windows.Forms.Button btndbSearch;
        private System.Windows.Forms.DateTimePicker dtpdbTime;
        private System.Windows.Forms.Label lbldbFrom;
        private System.Windows.Forms.Label lbldbHeading;
        private System.Windows.Forms.TabPage tabPagett;
        private System.Windows.Forms.Panel panttShow;
        private System.Windows.Forms.ListView ltvttTrip;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Panel panttSetting;
        private System.Windows.Forms.ComboBox cmbttTo;
        private System.Windows.Forms.ComboBox cmbttFrom;
        private System.Windows.Forms.DateTimePicker dtpttDate;
        private System.Windows.Forms.Button btnttSearch;
        private System.Windows.Forms.DateTimePicker dtpttTime;
        private System.Windows.Forms.RadioButton rabttArrival;
        private System.Windows.Forms.RadioButton rabttDeparture;
        private System.Windows.Forms.Label lblttTo;
        private System.Windows.Forms.Label lblttFrom;
        private System.Windows.Forms.Label lblttHeading;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.TextBox txtstYCoordinate;
        private System.Windows.Forms.TextBox txtstXCoordinate;
        private System.Windows.Forms.WebBrowser webstMap;
        private System.Windows.Forms.Label lblstYCoordinate;
        private System.Windows.Forms.Label lblstXCoordinate;
        private System.Windows.Forms.GroupBox gpbttSetting;
        private System.Windows.Forms.Label lblttType;
        private System.Windows.Forms.Label lblttTime;
        private System.Windows.Forms.Label lblttDate;
        private System.Windows.Forms.GroupBox gpbdbSetting;
        private System.Windows.Forms.Label lbldbTime;
        private System.Windows.Forms.Label lbldbDate;
    }
}

