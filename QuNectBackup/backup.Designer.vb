<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class backup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(backup))
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.lblServer = New System.Windows.Forms.Label()
        Me.txtServer = New System.Windows.Forms.TextBox()
        Me.lblAppToken = New System.Windows.Forms.Label()
        Me.txtAppToken = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.RetrieveTheTableReportsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnAddToBackupList = New System.Windows.Forms.Button()
        Me.ckbDetectProxy = New System.Windows.Forms.CheckBox()
        Me.cmbPassword = New System.Windows.Forms.ComboBox()
        Me.btnAppToken = New System.Windows.Forms.Button()
        Me.btnUserToken = New System.Windows.Forms.Button()
        Me.tabs = New System.Windows.Forms.TabControl()
        Me.tabAuth = New System.Windows.Forms.TabPage()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.tabOptions = New System.Windows.Forms.TabPage()
        Me.ckbLogSQL = New System.Windows.Forms.CheckBox()
        Me.ckbLogAPI = New System.Windows.Forms.CheckBox()
        Me.lblHours = New System.Windows.Forms.Label()
        Me.upDownHours = New System.Windows.Forms.NumericUpDown()
        Me.txtBackupFolder = New System.Windows.Forms.TextBox()
        Me.btnFolder = New System.Windows.Forms.Button()
        Me.lblBackupFolder = New System.Windows.Forms.Label()
        Me.ckbDateFolders = New System.Windows.Forms.CheckBox()
        Me.lblAttachments = New System.Windows.Forms.Label()
        Me.lblOnlyModified = New System.Windows.Forms.Label()
        Me.ckbOnlyUserEntry = New System.Windows.Forms.CheckBox()
        Me.cmbAttachments = New System.Windows.Forms.ComboBox()
        Me.ckbAppFolders = New System.Windows.Forms.CheckBox()
        Me.tabTables = New System.Windows.Forms.TabPage()
        Me.tvAppsTables = New System.Windows.Forms.TreeView()
        Me.btnListTables = New System.Windows.Forms.Button()
        Me.lstBackup = New System.Windows.Forms.ListBox()
        Me.lblTables = New System.Windows.Forms.Label()
        Me.lblBackup = New System.Windows.Forms.Label()
        Me.tabBackup = New System.Windows.Forms.TabPage()
        Me.lblOverAllProgress = New System.Windows.Forms.Label()
        Me.pbOverAll = New System.Windows.Forms.ProgressBar()
        Me.lblProgress = New System.Windows.Forms.Label()
        Me.btnCommandLine = New System.Windows.Forms.Button()
        Me.pb = New System.Windows.Forms.ProgressBar()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.tabs.SuspendLayout()
        Me.tabAuth.SuspendLayout()
        Me.tabOptions.SuspendLayout()
        CType(Me.upDownHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTables.SuspendLayout()
        Me.tabBackup.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsername
        '
        Me.txtUsername.Location = New System.Drawing.Point(26, 65)
        Me.txtUsername.Margin = New System.Windows.Forms.Padding(6)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(512, 31)
        Me.txtUsername.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(32, 29)
        Me.lblUsername.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(220, 25)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "QuickBase Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(26, 185)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(6)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(512, 31)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Visible = False
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(24, 358)
        Me.lblServer.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(185, 25)
        Me.lblServer.TabIndex = 5
        Me.lblServer.Text = "QuickBase Server"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(26, 392)
        Me.txtServer.Margin = New System.Windows.Forms.Padding(6)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(512, 31)
        Me.txtServer.TabIndex = 4
        '
        'lblAppToken
        '
        Me.lblAppToken.AutoSize = True
        Me.lblAppToken.Location = New System.Drawing.Point(32, 252)
        Me.lblAppToken.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAppToken.Name = "lblAppToken"
        Me.lblAppToken.Size = New System.Drawing.Size(294, 25)
        Me.lblAppToken.TabIndex = 7
        Me.lblAppToken.Text = "QuickBase Application Token"
        '
        'txtAppToken
        '
        Me.txtAppToken.Location = New System.Drawing.Point(26, 288)
        Me.txtAppToken.Margin = New System.Windows.Forms.Padding(6)
        Me.txtAppToken.Name = "txtAppToken"
        Me.txtAppToken.Size = New System.Drawing.Size(512, 31)
        Me.txtAppToken.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetrieveTheTableReportsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(662, 42)
        '
        'RetrieveTheTableReportsToolStripMenuItem
        '
        Me.RetrieveTheTableReportsToolStripMenuItem.Name = "RetrieveTheTableReportsToolStripMenuItem"
        Me.RetrieveTheTableReportsToolStripMenuItem.Size = New System.Drawing.Size(661, 38)
        Me.RetrieveTheTableReportsToolStripMenuItem.Text = "Retrieve the table reports for the selected application."
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(760, 510)
        Me.btnRemove.Margin = New System.Windows.Forms.Padding(6)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(62, 46)
        Me.btnRemove.TabIndex = 25
        Me.btnRemove.Text = "<-"
        Me.ToolTip1.SetToolTip(Me.btnRemove, "Hold down the shift key and click me to remove all the tables, without the shift " &
        "key I remove one table per click.")
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.Visible = False
        '
        'btnAddToBackupList
        '
        Me.btnAddToBackupList.Location = New System.Drawing.Point(760, 452)
        Me.btnAddToBackupList.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAddToBackupList.Name = "btnAddToBackupList"
        Me.btnAddToBackupList.Size = New System.Drawing.Size(62, 46)
        Me.btnAddToBackupList.TabIndex = 24
        Me.btnAddToBackupList.Text = "->"
        Me.ToolTip1.SetToolTip(Me.btnAddToBackupList, "Hold down the shift key and click me to move over all tables, without the shift k" &
        "ey I add one table per click.")
        Me.btnAddToBackupList.UseVisualStyleBackColor = True
        Me.btnAddToBackupList.Visible = False
        '
        'ckbDetectProxy
        '
        Me.ckbDetectProxy.AutoSize = True
        Me.ckbDetectProxy.Location = New System.Drawing.Point(30, 452)
        Me.ckbDetectProxy.Margin = New System.Windows.Forms.Padding(6)
        Me.ckbDetectProxy.Name = "ckbDetectProxy"
        Me.ckbDetectProxy.Size = New System.Drawing.Size(377, 29)
        Me.ckbDetectProxy.TabIndex = 23
        Me.ckbDetectProxy.Text = "Automatically detect proxy settings"
        Me.ckbDetectProxy.UseVisualStyleBackColor = True
        '
        'cmbPassword
        '
        Me.cmbPassword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPassword.FormattingEnabled = True
        Me.cmbPassword.Items.AddRange(New Object() {"Please choose...", "QuickBase Password", "QuickBase User Token"})
        Me.cmbPassword.Location = New System.Drawing.Point(26, 133)
        Me.cmbPassword.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbPassword.Name = "cmbPassword"
        Me.cmbPassword.Size = New System.Drawing.Size(462, 33)
        Me.cmbPassword.TabIndex = 47
        '
        'btnAppToken
        '
        Me.btnAppToken.Location = New System.Drawing.Point(330, 244)
        Me.btnAppToken.Margin = New System.Windows.Forms.Padding(6)
        Me.btnAppToken.Name = "btnAppToken"
        Me.btnAppToken.Size = New System.Drawing.Size(38, 38)
        Me.btnAppToken.TabIndex = 80
        Me.btnAppToken.Text = "?"
        Me.btnAppToken.UseVisualStyleBackColor = True
        '
        'btnUserToken
        '
        Me.btnUserToken.Location = New System.Drawing.Point(504, 135)
        Me.btnUserToken.Margin = New System.Windows.Forms.Padding(6)
        Me.btnUserToken.Name = "btnUserToken"
        Me.btnUserToken.Size = New System.Drawing.Size(38, 38)
        Me.btnUserToken.TabIndex = 81
        Me.btnUserToken.Text = "?"
        Me.btnUserToken.UseVisualStyleBackColor = True
        '
        'tabs
        '
        Me.tabs.Controls.Add(Me.tabAuth)
        Me.tabs.Controls.Add(Me.tabOptions)
        Me.tabs.Controls.Add(Me.tabTables)
        Me.tabs.Controls.Add(Me.tabBackup)
        Me.tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabs.Location = New System.Drawing.Point(0, 0)
        Me.tabs.Margin = New System.Windows.Forms.Padding(6)
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(1650, 1236)
        Me.tabs.TabIndex = 82
        '
        'tabAuth
        '
        Me.tabAuth.Controls.Add(Me.btnTest)
        Me.tabAuth.Controls.Add(Me.txtPassword)
        Me.tabAuth.Controls.Add(Me.txtUsername)
        Me.tabAuth.Controls.Add(Me.btnUserToken)
        Me.tabAuth.Controls.Add(Me.lblUsername)
        Me.tabAuth.Controls.Add(Me.btnAppToken)
        Me.tabAuth.Controls.Add(Me.txtServer)
        Me.tabAuth.Controls.Add(Me.cmbPassword)
        Me.tabAuth.Controls.Add(Me.lblServer)
        Me.tabAuth.Controls.Add(Me.txtAppToken)
        Me.tabAuth.Controls.Add(Me.lblAppToken)
        Me.tabAuth.Controls.Add(Me.ckbDetectProxy)
        Me.tabAuth.Location = New System.Drawing.Point(8, 39)
        Me.tabAuth.Margin = New System.Windows.Forms.Padding(6)
        Me.tabAuth.Name = "tabAuth"
        Me.tabAuth.Padding = New System.Windows.Forms.Padding(6)
        Me.tabAuth.Size = New System.Drawing.Size(1634, 1189)
        Me.tabAuth.TabIndex = 0
        Me.tabAuth.Text = "Authentication"
        Me.tabAuth.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(26, 496)
        Me.btnTest.Margin = New System.Windows.Forms.Padding(6)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(222, 44)
        Me.btnTest.TabIndex = 82
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'tabOptions
        '
        Me.tabOptions.Controls.Add(Me.ckbLogSQL)
        Me.tabOptions.Controls.Add(Me.ckbLogAPI)
        Me.tabOptions.Controls.Add(Me.lblHours)
        Me.tabOptions.Controls.Add(Me.upDownHours)
        Me.tabOptions.Controls.Add(Me.txtBackupFolder)
        Me.tabOptions.Controls.Add(Me.btnFolder)
        Me.tabOptions.Controls.Add(Me.lblBackupFolder)
        Me.tabOptions.Controls.Add(Me.ckbDateFolders)
        Me.tabOptions.Controls.Add(Me.lblAttachments)
        Me.tabOptions.Controls.Add(Me.lblOnlyModified)
        Me.tabOptions.Controls.Add(Me.ckbOnlyUserEntry)
        Me.tabOptions.Controls.Add(Me.cmbAttachments)
        Me.tabOptions.Controls.Add(Me.ckbAppFolders)
        Me.tabOptions.Location = New System.Drawing.Point(8, 39)
        Me.tabOptions.Margin = New System.Windows.Forms.Padding(6)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.Size = New System.Drawing.Size(1634, 1189)
        Me.tabOptions.TabIndex = 2
        Me.tabOptions.Text = "Options"
        Me.tabOptions.UseVisualStyleBackColor = True
        '
        'ckbLogSQL
        '
        Me.ckbLogSQL.AutoSize = True
        Me.ckbLogSQL.Location = New System.Drawing.Point(16, 308)
        Me.ckbLogSQL.Margin = New System.Windows.Forms.Padding(6)
        Me.ckbLogSQL.Name = "ckbLogSQL"
        Me.ckbLogSQL.Size = New System.Drawing.Size(772, 29)
        Me.ckbLogSQL.TabIndex = 48
        Me.ckbLogSQL.Text = "Log SQL statements to C:\Windows\Temp (not available from command line)"
        Me.ckbLogSQL.UseVisualStyleBackColor = True
        '
        'ckbLogAPI
        '
        Me.ckbLogAPI.AutoSize = True
        Me.ckbLogAPI.Location = New System.Drawing.Point(16, 267)
        Me.ckbLogAPI.Margin = New System.Windows.Forms.Padding(6)
        Me.ckbLogAPI.Name = "ckbLogAPI"
        Me.ckbLogAPI.Size = New System.Drawing.Size(810, 29)
        Me.ckbLogAPI.TabIndex = 47
        Me.ckbLogAPI.Text = "Log Quickbase API calls to C:\Windows\Temp (not available from command line)"
        Me.ckbLogAPI.UseVisualStyleBackColor = True
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(660, 108)
        Me.lblHours.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(860, 25)
        Me.lblHours.TabIndex = 46
        Me.lblHours.Text = "hours. Set to zero to backup all records. Table reports must contain ""Date Modifi" &
    "ed"" field."
        '
        'upDownHours
        '
        Me.upDownHours.Location = New System.Drawing.Point(541, 104)
        Me.upDownHours.Margin = New System.Windows.Forms.Padding(6)
        Me.upDownHours.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.upDownHours.Name = "upDownHours"
        Me.upDownHours.Size = New System.Drawing.Size(112, 31)
        Me.upDownHours.TabIndex = 45
        '
        'txtBackupFolder
        '
        Me.txtBackupFolder.Enabled = False
        Me.txtBackupFolder.Location = New System.Drawing.Point(580, 48)
        Me.txtBackupFolder.Margin = New System.Windows.Forms.Padding(6)
        Me.txtBackupFolder.Name = "txtBackupFolder"
        Me.txtBackupFolder.Size = New System.Drawing.Size(987, 31)
        Me.txtBackupFolder.TabIndex = 39
        '
        'btnFolder
        '
        Me.btnFolder.Location = New System.Drawing.Point(513, 39)
        Me.btnFolder.Margin = New System.Windows.Forms.Padding(6)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.Size = New System.Drawing.Size(56, 44)
        Me.btnFolder.TabIndex = 35
        Me.btnFolder.Text = "..."
        Me.btnFolder.UseVisualStyleBackColor = True
        '
        'lblBackupFolder
        '
        Me.lblBackupFolder.AutoSize = True
        Me.lblBackupFolder.Location = New System.Drawing.Point(508, 12)
        Me.lblBackupFolder.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBackupFolder.Name = "lblBackupFolder"
        Me.lblBackupFolder.Size = New System.Drawing.Size(206, 25)
        Me.lblBackupFolder.TabIndex = 36
        Me.lblBackupFolder.Text = "Folder to Backup To"
        '
        'ckbDateFolders
        '
        Me.ckbDateFolders.AutoSize = True
        Me.ckbDateFolders.Location = New System.Drawing.Point(16, 148)
        Me.ckbDateFolders.Margin = New System.Windows.Forms.Padding(6)
        Me.ckbDateFolders.Name = "ckbDateFolders"
        Me.ckbDateFolders.Size = New System.Drawing.Size(391, 29)
        Me.ckbDateFolders.TabIndex = 40
        Me.ckbDateFolders.Text = "Create a new subfolder for each day"
        Me.ckbDateFolders.UseVisualStyleBackColor = True
        '
        'lblAttachments
        '
        Me.lblAttachments.AutoSize = True
        Me.lblAttachments.Location = New System.Drawing.Point(20, 13)
        Me.lblAttachments.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblAttachments.Name = "lblAttachments"
        Me.lblAttachments.Size = New System.Drawing.Size(172, 25)
        Me.lblAttachments.TabIndex = 37
        Me.lblAttachments.Text = "File Attachments"
        '
        'lblOnlyModified
        '
        Me.lblOnlyModified.AutoSize = True
        Me.lblOnlyModified.Location = New System.Drawing.Point(22, 108)
        Me.lblOnlyModified.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblOnlyModified.Name = "lblOnlyModified"
        Me.lblOnlyModified.Size = New System.Drawing.Size(516, 25)
        Me.lblOnlyModified.TabIndex = 44
        Me.lblOnlyModified.Text = "Only backup records created and modified in the last"
        '
        'ckbOnlyUserEntry
        '
        Me.ckbOnlyUserEntry.AutoSize = True
        Me.ckbOnlyUserEntry.Location = New System.Drawing.Point(16, 219)
        Me.ckbOnlyUserEntry.Margin = New System.Windows.Forms.Padding(6)
        Me.ckbOnlyUserEntry.Name = "ckbOnlyUserEntry"
        Me.ckbOnlyUserEntry.Size = New System.Drawing.Size(1043, 29)
        Me.ckbOnlyUserEntry.TabIndex = 43
        Me.ckbOnlyUserEntry.Text = "Backup only the five built-in and user entry fields. Exclude all lookup, summary," &
    " formula and query fields."
        Me.ckbOnlyUserEntry.UseVisualStyleBackColor = True
        '
        'cmbAttachments
        '
        Me.cmbAttachments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAttachments.FormattingEnabled = True
        Me.cmbAttachments.Items.AddRange(New Object() {"Do not download", "Download current revision and list file URL", "Download all revisions and current rev file URL", "Download all revisions and all file URLs"})
        Me.cmbAttachments.Location = New System.Drawing.Point(12, 48)
        Me.cmbAttachments.Margin = New System.Windows.Forms.Padding(6)
        Me.cmbAttachments.Name = "cmbAttachments"
        Me.cmbAttachments.Size = New System.Drawing.Size(472, 33)
        Me.cmbAttachments.TabIndex = 38
        '
        'ckbAppFolders
        '
        Me.ckbAppFolders.AutoSize = True
        Me.ckbAppFolders.Location = New System.Drawing.Point(16, 185)
        Me.ckbAppFolders.Margin = New System.Windows.Forms.Padding(6)
        Me.ckbAppFolders.Name = "ckbAppFolders"
        Me.ckbAppFolders.Size = New System.Drawing.Size(395, 29)
        Me.ckbAppFolders.TabIndex = 42
        Me.ckbAppFolders.Text = "Put each application in its own folder"
        Me.ckbAppFolders.UseVisualStyleBackColor = True
        '
        'tabTables
        '
        Me.tabTables.Controls.Add(Me.btnRemove)
        Me.tabTables.Controls.Add(Me.btnAddToBackupList)
        Me.tabTables.Controls.Add(Me.tvAppsTables)
        Me.tabTables.Controls.Add(Me.btnListTables)
        Me.tabTables.Controls.Add(Me.lstBackup)
        Me.tabTables.Controls.Add(Me.lblTables)
        Me.tabTables.Controls.Add(Me.lblBackup)
        Me.tabTables.Location = New System.Drawing.Point(8, 39)
        Me.tabTables.Margin = New System.Windows.Forms.Padding(6)
        Me.tabTables.Name = "tabTables"
        Me.tabTables.Size = New System.Drawing.Size(1634, 1189)
        Me.tabTables.TabIndex = 3
        Me.tabTables.Text = "Tables"
        Me.tabTables.UseVisualStyleBackColor = True
        '
        'tvAppsTables
        '
        Me.tvAppsTables.AllowDrop = True
        Me.tvAppsTables.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvAppsTables.Location = New System.Drawing.Point(10, 73)
        Me.tvAppsTables.Margin = New System.Windows.Forms.Padding(6)
        Me.tvAppsTables.Name = "tvAppsTables"
        Me.tvAppsTables.Size = New System.Drawing.Size(734, 1106)
        Me.tvAppsTables.TabIndex = 21
        Me.tvAppsTables.Visible = False
        '
        'btnListTables
        '
        Me.btnListTables.Location = New System.Drawing.Point(388, 17)
        Me.btnListTables.Margin = New System.Windows.Forms.Padding(6)
        Me.btnListTables.Name = "btnListTables"
        Me.btnListTables.Size = New System.Drawing.Size(152, 44)
        Me.btnListTables.TabIndex = 22
        Me.btnListTables.Text = "List Tables"
        Me.btnListTables.UseVisualStyleBackColor = True
        '
        'lstBackup
        '
        Me.lstBackup.AllowDrop = True
        Me.lstBackup.FormattingEnabled = True
        Me.lstBackup.ItemHeight = 25
        Me.lstBackup.Location = New System.Drawing.Point(834, 75)
        Me.lstBackup.Margin = New System.Windows.Forms.Padding(6)
        Me.lstBackup.Name = "lstBackup"
        Me.lstBackup.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstBackup.Size = New System.Drawing.Size(790, 1104)
        Me.lstBackup.TabIndex = 23
        Me.lstBackup.Visible = False
        '
        'lblTables
        '
        Me.lblTables.AutoSize = True
        Me.lblTables.Location = New System.Drawing.Point(18, 27)
        Me.lblTables.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTables.Name = "lblTables"
        Me.lblTables.Size = New System.Drawing.Size(269, 25)
        Me.lblTables.TabIndex = 27
        Me.lblTables.Text = "Tables you have access to"
        '
        'lblBackup
        '
        Me.lblBackup.AutoSize = True
        Me.lblBackup.Location = New System.Drawing.Point(846, 27)
        Me.lblBackup.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblBackup.Name = "lblBackup"
        Me.lblBackup.Size = New System.Drawing.Size(179, 25)
        Me.lblBackup.TabIndex = 26
        Me.lblBackup.Text = "Tables to Backup"
        Me.lblBackup.Visible = False
        '
        'tabBackup
        '
        Me.tabBackup.Controls.Add(Me.lblOverAllProgress)
        Me.tabBackup.Controls.Add(Me.pbOverAll)
        Me.tabBackup.Controls.Add(Me.lblProgress)
        Me.tabBackup.Controls.Add(Me.btnCommandLine)
        Me.tabBackup.Controls.Add(Me.pb)
        Me.tabBackup.Controls.Add(Me.btnBackup)
        Me.tabBackup.Location = New System.Drawing.Point(8, 39)
        Me.tabBackup.Margin = New System.Windows.Forms.Padding(6)
        Me.tabBackup.Name = "tabBackup"
        Me.tabBackup.Padding = New System.Windows.Forms.Padding(6)
        Me.tabBackup.Size = New System.Drawing.Size(1634, 1189)
        Me.tabBackup.TabIndex = 1
        Me.tabBackup.Text = "Backup"
        Me.tabBackup.UseVisualStyleBackColor = True
        '
        'lblOverAllProgress
        '
        Me.lblOverAllProgress.AutoSize = True
        Me.lblOverAllProgress.Location = New System.Drawing.Point(16, 133)
        Me.lblOverAllProgress.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblOverAllProgress.Name = "lblOverAllProgress"
        Me.lblOverAllProgress.Size = New System.Drawing.Size(0, 25)
        Me.lblOverAllProgress.TabIndex = 44
        '
        'pbOverAll
        '
        Me.pbOverAll.Location = New System.Drawing.Point(6, 67)
        Me.pbOverAll.Margin = New System.Windows.Forms.Padding(6)
        Me.pbOverAll.Maximum = 1000
        Me.pbOverAll.Name = "pbOverAll"
        Me.pbOverAll.Size = New System.Drawing.Size(742, 44)
        Me.pbOverAll.TabIndex = 43
        Me.pbOverAll.Visible = False
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(16, 242)
        Me.lblProgress.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 25)
        Me.lblProgress.TabIndex = 42
        '
        'btnCommandLine
        '
        Me.btnCommandLine.Location = New System.Drawing.Point(232, 12)
        Me.btnCommandLine.Margin = New System.Windows.Forms.Padding(6)
        Me.btnCommandLine.Name = "btnCommandLine"
        Me.btnCommandLine.Size = New System.Drawing.Size(322, 44)
        Me.btnCommandLine.TabIndex = 29
        Me.btnCommandLine.Text = "Show command line"
        Me.btnCommandLine.UseVisualStyleBackColor = True
        Me.btnCommandLine.Visible = False
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(6, 177)
        Me.pb.Margin = New System.Windows.Forms.Padding(6)
        Me.pb.Maximum = 1000
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(742, 44)
        Me.pb.TabIndex = 22
        Me.pb.Visible = False
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(14, 13)
        Me.btnBackup.Margin = New System.Windows.Forms.Padding(6)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(166, 44)
        Me.btnBackup.TabIndex = 14
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        Me.btnBackup.Visible = False
        '
        'backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1650, 1236)
        Me.Controls.Add(Me.tabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "backup"
        Me.Text = "QuNect Backup"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.tabs.ResumeLayout(False)
        Me.tabAuth.ResumeLayout(False)
        Me.tabAuth.PerformLayout()
        Me.tabOptions.ResumeLayout(False)
        Me.tabOptions.PerformLayout()
        CType(Me.upDownHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTables.ResumeLayout(False)
        Me.tabTables.PerformLayout()
        Me.tabBackup.ResumeLayout(False)
        Me.tabBackup.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtUsername As System.Windows.Forms.TextBox
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblServer As System.Windows.Forms.Label
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents lblAppToken As System.Windows.Forms.Label
    Friend WithEvents txtAppToken As System.Windows.Forms.TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents ckbDetectProxy As System.Windows.Forms.CheckBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents RetrieveTheTableReportsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmbPassword As ComboBox
    Friend WithEvents btnAppToken As Button
    Friend WithEvents btnUserToken As Button
    Friend WithEvents tabs As TabControl
    Friend WithEvents tabAuth As TabPage
    Friend WithEvents btnTest As Button
    Friend WithEvents tabOptions As TabPage
    Friend WithEvents lblHours As Label
    Friend WithEvents upDownHours As NumericUpDown
    Friend WithEvents txtBackupFolder As TextBox
    Friend WithEvents btnFolder As Button
    Friend WithEvents lblBackupFolder As Label
    Friend WithEvents ckbDateFolders As CheckBox
    Friend WithEvents lblAttachments As Label
    Friend WithEvents lblOnlyModified As Label
    Friend WithEvents ckbOnlyUserEntry As CheckBox
    Friend WithEvents cmbAttachments As ComboBox
    Friend WithEvents ckbAppFolders As CheckBox
    Friend WithEvents tabTables As TabPage
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnAddToBackupList As Button
    Friend WithEvents tvAppsTables As TreeView
    Friend WithEvents btnListTables As Button
    Friend WithEvents lstBackup As ListBox
    Friend WithEvents lblTables As Label
    Friend WithEvents lblBackup As Label
    Friend WithEvents tabBackup As TabPage
    Friend WithEvents btnCommandLine As Button
    Friend WithEvents pb As ProgressBar
    Friend WithEvents btnBackup As Button
    Friend WithEvents lblProgress As Label
    Friend WithEvents lblOverAllProgress As Label
    Friend WithEvents pbOverAll As ProgressBar
    Friend WithEvents ckbLogSQL As CheckBox
    Friend WithEvents ckbLogAPI As CheckBox
End Class
