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
        Me.ckbUnicode = New System.Windows.Forms.CheckBox()
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
        Me.cmbFieldsToBackup = New System.Windows.Forms.ComboBox()
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
        Me.txtUsername.Location = New System.Drawing.Point(13, 34)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(258, 20)
        Me.txtUsername.TabIndex = 0
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Location = New System.Drawing.Point(16, 15)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(110, 13)
        Me.lblUsername.TabIndex = 1
        Me.lblUsername.Text = "QuickBase Username"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(13, 96)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(258, 20)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Visible = False
        '
        'lblServer
        '
        Me.lblServer.AutoSize = True
        Me.lblServer.Location = New System.Drawing.Point(12, 186)
        Me.lblServer.Name = "lblServer"
        Me.lblServer.Size = New System.Drawing.Size(93, 13)
        Me.lblServer.TabIndex = 5
        Me.lblServer.Text = "QuickBase Server"
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(13, 204)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(258, 20)
        Me.txtServer.TabIndex = 4
        '
        'lblAppToken
        '
        Me.lblAppToken.AutoSize = True
        Me.lblAppToken.Location = New System.Drawing.Point(16, 131)
        Me.lblAppToken.Name = "lblAppToken"
        Me.lblAppToken.Size = New System.Drawing.Size(148, 13)
        Me.lblAppToken.TabIndex = 7
        Me.lblAppToken.Text = "QuickBase Application Token"
        '
        'txtAppToken
        '
        Me.txtAppToken.Location = New System.Drawing.Point(13, 150)
        Me.txtAppToken.Name = "txtAppToken"
        Me.txtAppToken.Size = New System.Drawing.Size(258, 20)
        Me.txtAppToken.TabIndex = 6
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RetrieveTheTableReportsToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(355, 26)
        '
        'RetrieveTheTableReportsToolStripMenuItem
        '
        Me.RetrieveTheTableReportsToolStripMenuItem.Name = "RetrieveTheTableReportsToolStripMenuItem"
        Me.RetrieveTheTableReportsToolStripMenuItem.Size = New System.Drawing.Size(354, 22)
        Me.RetrieveTheTableReportsToolStripMenuItem.Text = "Retrieve the table reports for the selected application."
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(380, 265)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(31, 24)
        Me.btnRemove.TabIndex = 25
        Me.btnRemove.Text = "<-"
        Me.ToolTip1.SetToolTip(Me.btnRemove, "Hold down the shift key and click me to remove all the tables, without the shift " &
        "key I remove one table per click.")
        Me.btnRemove.UseVisualStyleBackColor = True
        Me.btnRemove.Visible = False
        '
        'btnAddToBackupList
        '
        Me.btnAddToBackupList.Location = New System.Drawing.Point(380, 235)
        Me.btnAddToBackupList.Name = "btnAddToBackupList"
        Me.btnAddToBackupList.Size = New System.Drawing.Size(31, 24)
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
        Me.ckbDetectProxy.Location = New System.Drawing.Point(13, 235)
        Me.ckbDetectProxy.Name = "ckbDetectProxy"
        Me.ckbDetectProxy.Size = New System.Drawing.Size(188, 17)
        Me.ckbDetectProxy.TabIndex = 23
        Me.ckbDetectProxy.Text = "Automatically detect proxy settings"
        Me.ckbDetectProxy.UseVisualStyleBackColor = True
        '
        'cmbPassword
        '
        Me.cmbPassword.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPassword.FormattingEnabled = True
        Me.cmbPassword.Items.AddRange(New Object() {"Please choose...", "QuickBase Password", "QuickBase User Token"})
        Me.cmbPassword.Location = New System.Drawing.Point(13, 69)
        Me.cmbPassword.Name = "cmbPassword"
        Me.cmbPassword.Size = New System.Drawing.Size(233, 21)
        Me.cmbPassword.TabIndex = 47
        '
        'btnAppToken
        '
        Me.btnAppToken.Location = New System.Drawing.Point(165, 127)
        Me.btnAppToken.Name = "btnAppToken"
        Me.btnAppToken.Size = New System.Drawing.Size(19, 20)
        Me.btnAppToken.TabIndex = 80
        Me.btnAppToken.Text = "?"
        Me.btnAppToken.UseVisualStyleBackColor = True
        '
        'btnUserToken
        '
        Me.btnUserToken.Location = New System.Drawing.Point(252, 70)
        Me.btnUserToken.Name = "btnUserToken"
        Me.btnUserToken.Size = New System.Drawing.Size(19, 20)
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
        Me.tabs.Name = "tabs"
        Me.tabs.SelectedIndex = 0
        Me.tabs.Size = New System.Drawing.Size(825, 643)
        Me.tabs.TabIndex = 82
        '
        'tabAuth
        '
        Me.tabAuth.Controls.Add(Me.ckbUnicode)
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
        Me.tabAuth.Location = New System.Drawing.Point(4, 22)
        Me.tabAuth.Name = "tabAuth"
        Me.tabAuth.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabAuth.Size = New System.Drawing.Size(817, 617)
        Me.tabAuth.TabIndex = 0
        Me.tabAuth.Text = "Authentication"
        Me.tabAuth.UseVisualStyleBackColor = True
        '
        'ckbUnicode
        '
        Me.ckbUnicode.AutoSize = True
        Me.ckbUnicode.Location = New System.Drawing.Point(13, 259)
        Me.ckbUnicode.Name = "ckbUnicode"
        Me.ckbUnicode.Size = New System.Drawing.Size(234, 17)
        Me.ckbUnicode.TabIndex = 83
        Me.ckbUnicode.Text = "Use QuNect Unicode ODBC for QuickBase "
        Me.ckbUnicode.UseVisualStyleBackColor = True
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(63, 280)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(111, 23)
        Me.btnTest.TabIndex = 82
        Me.btnTest.Text = "Test Connection"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'tabOptions
        '
        Me.tabOptions.Controls.Add(Me.cmbFieldsToBackup)
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
        Me.tabOptions.Controls.Add(Me.cmbAttachments)
        Me.tabOptions.Controls.Add(Me.ckbAppFolders)
        Me.tabOptions.Location = New System.Drawing.Point(4, 22)
        Me.tabOptions.Name = "tabOptions"
        Me.tabOptions.Size = New System.Drawing.Size(817, 617)
        Me.tabOptions.TabIndex = 2
        Me.tabOptions.Text = "Options"
        Me.tabOptions.UseVisualStyleBackColor = True
        '
        'ckbLogSQL
        '
        Me.ckbLogSQL.AutoSize = True
        Me.ckbLogSQL.Location = New System.Drawing.Point(8, 137)
        Me.ckbLogSQL.Name = "ckbLogSQL"
        Me.ckbLogSQL.Size = New System.Drawing.Size(388, 17)
        Me.ckbLogSQL.TabIndex = 48
        Me.ckbLogSQL.Text = "Log SQL statements to C:\Windows\Temp (not available from command line)"
        Me.ckbLogSQL.UseVisualStyleBackColor = True
        '
        'ckbLogAPI
        '
        Me.ckbLogAPI.AutoSize = True
        Me.ckbLogAPI.Location = New System.Drawing.Point(8, 116)
        Me.ckbLogAPI.Name = "ckbLogAPI"
        Me.ckbLogAPI.Size = New System.Drawing.Size(408, 17)
        Me.ckbLogAPI.TabIndex = 47
        Me.ckbLogAPI.Text = "Log Quickbase API calls to C:\Windows\Temp (not available from command line)"
        Me.ckbLogAPI.UseVisualStyleBackColor = True
        '
        'lblHours
        '
        Me.lblHours.AutoSize = True
        Me.lblHours.Location = New System.Drawing.Point(330, 56)
        Me.lblHours.Name = "lblHours"
        Me.lblHours.Size = New System.Drawing.Size(427, 13)
        Me.lblHours.TabIndex = 46
        Me.lblHours.Text = "hours. Set to zero to backup all records. Table reports must contain ""Date Modifi" &
    "ed"" field."
        '
        'upDownHours
        '
        Me.upDownHours.Location = New System.Drawing.Point(270, 54)
        Me.upDownHours.Maximum = New Decimal(New Integer() {9999, 0, 0, 0})
        Me.upDownHours.Name = "upDownHours"
        Me.upDownHours.Size = New System.Drawing.Size(56, 20)
        Me.upDownHours.TabIndex = 45
        '
        'txtBackupFolder
        '
        Me.txtBackupFolder.Enabled = False
        Me.txtBackupFolder.Location = New System.Drawing.Point(290, 25)
        Me.txtBackupFolder.Name = "txtBackupFolder"
        Me.txtBackupFolder.Size = New System.Drawing.Size(496, 20)
        Me.txtBackupFolder.TabIndex = 39
        '
        'btnFolder
        '
        Me.btnFolder.Location = New System.Drawing.Point(256, 20)
        Me.btnFolder.Name = "btnFolder"
        Me.btnFolder.Size = New System.Drawing.Size(28, 23)
        Me.btnFolder.TabIndex = 35
        Me.btnFolder.Text = "..."
        Me.btnFolder.UseVisualStyleBackColor = True
        '
        'lblBackupFolder
        '
        Me.lblBackupFolder.AutoSize = True
        Me.lblBackupFolder.Location = New System.Drawing.Point(254, 6)
        Me.lblBackupFolder.Name = "lblBackupFolder"
        Me.lblBackupFolder.Size = New System.Drawing.Size(104, 13)
        Me.lblBackupFolder.TabIndex = 36
        Me.lblBackupFolder.Text = "Folder to Backup To"
        '
        'ckbDateFolders
        '
        Me.ckbDateFolders.AutoSize = True
        Me.ckbDateFolders.Location = New System.Drawing.Point(8, 77)
        Me.ckbDateFolders.Name = "ckbDateFolders"
        Me.ckbDateFolders.Size = New System.Drawing.Size(197, 17)
        Me.ckbDateFolders.TabIndex = 40
        Me.ckbDateFolders.Text = "Create a new subfolder for each day"
        Me.ckbDateFolders.UseVisualStyleBackColor = True
        '
        'lblAttachments
        '
        Me.lblAttachments.AutoSize = True
        Me.lblAttachments.Location = New System.Drawing.Point(10, 7)
        Me.lblAttachments.Name = "lblAttachments"
        Me.lblAttachments.Size = New System.Drawing.Size(85, 13)
        Me.lblAttachments.TabIndex = 37
        Me.lblAttachments.Text = "File Attachments"
        '
        'lblOnlyModified
        '
        Me.lblOnlyModified.AutoSize = True
        Me.lblOnlyModified.Location = New System.Drawing.Point(11, 56)
        Me.lblOnlyModified.Name = "lblOnlyModified"
        Me.lblOnlyModified.Size = New System.Drawing.Size(255, 13)
        Me.lblOnlyModified.TabIndex = 44
        Me.lblOnlyModified.Text = "Only backup records created and modified in the last"
        '
        'cmbAttachments
        '
        Me.cmbAttachments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbAttachments.FormattingEnabled = True
        Me.cmbAttachments.Items.AddRange(New Object() {"Do not download", "Download current revision and list file URL", "Download all revisions and current rev file URL", "Download all revisions and all file URLs"})
        Me.cmbAttachments.Location = New System.Drawing.Point(6, 25)
        Me.cmbAttachments.Name = "cmbAttachments"
        Me.cmbAttachments.Size = New System.Drawing.Size(238, 21)
        Me.cmbAttachments.TabIndex = 38
        '
        'ckbAppFolders
        '
        Me.ckbAppFolders.AutoSize = True
        Me.ckbAppFolders.Location = New System.Drawing.Point(8, 96)
        Me.ckbAppFolders.Name = "ckbAppFolders"
        Me.ckbAppFolders.Size = New System.Drawing.Size(199, 17)
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
        Me.tabTables.Location = New System.Drawing.Point(4, 22)
        Me.tabTables.Name = "tabTables"
        Me.tabTables.Size = New System.Drawing.Size(817, 617)
        Me.tabTables.TabIndex = 3
        Me.tabTables.Text = "Tables"
        Me.tabTables.UseVisualStyleBackColor = True
        '
        'tvAppsTables
        '
        Me.tvAppsTables.AllowDrop = True
        Me.tvAppsTables.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvAppsTables.Location = New System.Drawing.Point(5, 38)
        Me.tvAppsTables.Name = "tvAppsTables"
        Me.tvAppsTables.Size = New System.Drawing.Size(369, 577)
        Me.tvAppsTables.TabIndex = 21
        Me.tvAppsTables.Visible = False
        '
        'btnListTables
        '
        Me.btnListTables.Location = New System.Drawing.Point(194, 9)
        Me.btnListTables.Name = "btnListTables"
        Me.btnListTables.Size = New System.Drawing.Size(76, 23)
        Me.btnListTables.TabIndex = 22
        Me.btnListTables.Text = "List Tables"
        Me.btnListTables.UseVisualStyleBackColor = True
        '
        'lstBackup
        '
        Me.lstBackup.AllowDrop = True
        Me.lstBackup.FormattingEnabled = True
        Me.lstBackup.Location = New System.Drawing.Point(417, 39)
        Me.lstBackup.Name = "lstBackup"
        Me.lstBackup.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended
        Me.lstBackup.Size = New System.Drawing.Size(397, 576)
        Me.lstBackup.TabIndex = 23
        Me.lstBackup.Visible = False
        '
        'lblTables
        '
        Me.lblTables.AutoSize = True
        Me.lblTables.Location = New System.Drawing.Point(9, 14)
        Me.lblTables.Name = "lblTables"
        Me.lblTables.Size = New System.Drawing.Size(135, 13)
        Me.lblTables.TabIndex = 27
        Me.lblTables.Text = "Tables you have access to"
        '
        'lblBackup
        '
        Me.lblBackup.AutoSize = True
        Me.lblBackup.Location = New System.Drawing.Point(423, 14)
        Me.lblBackup.Name = "lblBackup"
        Me.lblBackup.Size = New System.Drawing.Size(91, 13)
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
        Me.tabBackup.Location = New System.Drawing.Point(4, 22)
        Me.tabBackup.Name = "tabBackup"
        Me.tabBackup.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabBackup.Size = New System.Drawing.Size(817, 617)
        Me.tabBackup.TabIndex = 1
        Me.tabBackup.Text = "Backup"
        Me.tabBackup.UseVisualStyleBackColor = True
        '
        'lblOverAllProgress
        '
        Me.lblOverAllProgress.AutoSize = True
        Me.lblOverAllProgress.Location = New System.Drawing.Point(8, 69)
        Me.lblOverAllProgress.Name = "lblOverAllProgress"
        Me.lblOverAllProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblOverAllProgress.TabIndex = 44
        '
        'pbOverAll
        '
        Me.pbOverAll.Location = New System.Drawing.Point(3, 35)
        Me.pbOverAll.Maximum = 1000
        Me.pbOverAll.Name = "pbOverAll"
        Me.pbOverAll.Size = New System.Drawing.Size(371, 23)
        Me.pbOverAll.TabIndex = 43
        Me.pbOverAll.Visible = False
        '
        'lblProgress
        '
        Me.lblProgress.AutoSize = True
        Me.lblProgress.Location = New System.Drawing.Point(8, 126)
        Me.lblProgress.Name = "lblProgress"
        Me.lblProgress.Size = New System.Drawing.Size(0, 13)
        Me.lblProgress.TabIndex = 42
        '
        'btnCommandLine
        '
        Me.btnCommandLine.Location = New System.Drawing.Point(116, 6)
        Me.btnCommandLine.Name = "btnCommandLine"
        Me.btnCommandLine.Size = New System.Drawing.Size(161, 23)
        Me.btnCommandLine.TabIndex = 29
        Me.btnCommandLine.Text = "Show command line"
        Me.btnCommandLine.UseVisualStyleBackColor = True
        Me.btnCommandLine.Visible = False
        '
        'pb
        '
        Me.pb.Location = New System.Drawing.Point(3, 92)
        Me.pb.Maximum = 1000
        Me.pb.Name = "pb"
        Me.pb.Size = New System.Drawing.Size(371, 23)
        Me.pb.TabIndex = 22
        Me.pb.Visible = False
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(7, 7)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(83, 23)
        Me.btnBackup.TabIndex = 14
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        Me.btnBackup.Visible = False
        '
        'cmbFieldsToBackup
        '
        Me.cmbFieldsToBackup.FormattingEnabled = True
        Me.cmbFieldsToBackup.Items.AddRange(New Object() {"Backup all fields except Report Link and Formula URL fields", "Backup only the five built-in and user entry fields. Exclude all lookup, summary," &
                " formula and query fields.", "Backup all fields"})
        Me.cmbFieldsToBackup.Location = New System.Drawing.Point(8, 161)
        Me.cmbFieldsToBackup.Name = "cmbFieldsToBackup"
        Me.cmbFieldsToBackup.Size = New System.Drawing.Size(623, 21)
        Me.cmbFieldsToBackup.TabIndex = 49
        '
        'backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 643)
        Me.Controls.Add(Me.tabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents ckbUnicode As CheckBox
    Friend WithEvents cmbFieldsToBackup As ComboBox
End Class
