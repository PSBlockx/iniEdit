<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.startLauncher = New System.Windows.Forms.Button()
        Me.vsyncCheck = New System.Windows.Forms.CheckBox()
        Me.fogShadCheck = New System.Windows.Forms.CheckBox()
        Me.ambOccCheck = New System.Windows.Forms.CheckBox()
        Me.bloomCheck = New System.Windows.Forms.CheckBox()
        Me.blurCheck = New System.Windows.Forms.CheckBox()
        Me.smoothCheck = New System.Windows.Forms.CheckBox()
        Me.wideCheck = New System.Windows.Forms.CheckBox()
        Me.gpuPhysCheck = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.useGlobRenCheck = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.graphQualDrop = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.texQualDrop = New System.Windows.Forms.ComboBox()
        Me.shadQualDrop = New System.Windows.Forms.ComboBox()
        Me.lightQualDrop = New System.Windows.Forms.ComboBox()
        Me.effQualDrop = New System.Windows.Forms.ComboBox()
        Me.terrQualDrop = New System.Windows.Forms.ComboBox()
        Me.floraQualDrop = New System.Windows.Forms.ComboBox()
        Me.modQualDrop = New System.Windows.Forms.ComboBox()
        Me.partQualDrop = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.graphPanel4 = New System.Windows.Forms.FlowLayoutPanel()
        Me.graphPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.globRenDistBox = New System.Windows.Forms.NumericUpDown()
        Me.infRenDistBox = New System.Windows.Forms.NumericUpDown()
        Me.vehRenDistbox = New System.Windows.Forms.NumericUpDown()
        Me.airRenDistBox = New System.Windows.Forms.NumericUpDown()
        Me.graphPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.renQualBox = New System.Windows.Forms.NumericUpDown()
        Me.partDistScaleBox = New System.Windows.Forms.NumericUpDown()
        Me.fovBox = New System.Windows.Forms.NumericUpDown()
        Me.maxFPSBox = New System.Windows.Forms.NumericUpDown()
        Me.gammaBox = New System.Windows.Forms.NumericUpDown()
        Me.graphPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.DPIBox = New System.Windows.Forms.NumericUpDown()
        Me.sensRawCheck = New System.Windows.Forms.CheckBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.sensSensPanel = New System.Windows.Forms.Panel()
        Me.recalcSensButton = New System.Windows.Forms.Button()
        Me.sensPanel4 = New System.Windows.Forms.SplitContainer()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Label55 = New System.Windows.Forms.Label()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.sensPanel3 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.hip360Box = New System.Windows.Forms.NumericUpDown()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.ads360Box = New System.Windows.Forms.NumericUpDown()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.adsZoomBox = New System.Windows.Forms.ComboBox()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.scop360Box = New System.Windows.Forms.NumericUpDown()
        Me.Label49 = New System.Windows.Forms.Label()
        Me.scopZoomBox = New System.Windows.Forms.ComboBox()
        Me.sensPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.hipSensBox = New System.Windows.Forms.NumericUpDown()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.adsSensBox = New System.Windows.Forms.NumericUpDown()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.scopSensBox = New System.Windows.Forms.NumericUpDown()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.vehSensBox = New System.Windows.Forms.NumericUpDown()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.gunSensBox = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.airSensBox = New System.Windows.Forms.NumericUpDown()
        Me.sensPanel2 = New System.Windows.Forms.SplitContainer()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.sensTypeDrop = New System.Windows.Forms.ComboBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.fontAutoCheck = New System.Windows.Forms.CheckBox()
        Me.selectedFontPath = New System.Windows.Forms.Label()
        Me.fontSelectButton = New System.Windows.Forms.Button()
        Me.Label57 = New System.Windows.Forms.Label()
        Me.graphPanel4.SuspendLayout()
        Me.graphPanel3.SuspendLayout()
        CType(Me.globRenDistBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.infRenDistBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vehRenDistbox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.airRenDistBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.graphPanel2.SuspendLayout()
        CType(Me.renQualBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partDistScaleBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fovBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.maxFPSBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gammaBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.graphPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DPIBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sensSensPanel.SuspendLayout()
        CType(Me.sensPanel4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sensPanel4.Panel1.SuspendLayout()
        Me.sensPanel4.Panel2.SuspendLayout()
        Me.sensPanel4.SuspendLayout()
        Me.sensPanel3.SuspendLayout()
        CType(Me.hip360Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ads360Box, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scop360Box, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sensPanel1.SuspendLayout()
        CType(Me.hipSensBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.adsSensBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.scopSensBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.vehSensBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gunSensBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.airSensBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sensPanel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sensPanel2.Panel1.SuspendLayout()
        Me.sensPanel2.Panel2.SuspendLayout()
        Me.sensPanel2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.SuspendLayout()
        '
        'startLauncher
        '
        Me.startLauncher.BackColor = System.Drawing.SystemColors.Control
        Me.startLauncher.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startLauncher.Location = New System.Drawing.Point(12, 456)
        Me.startLauncher.Name = "startLauncher"
        Me.startLauncher.Size = New System.Drawing.Size(424, 38)
        Me.startLauncher.TabIndex = 30
        Me.startLauncher.Text = "START LAUNCHER"
        Me.startLauncher.UseVisualStyleBackColor = False
        '
        'vsyncCheck
        '
        Me.vsyncCheck.AutoSize = True
        Me.vsyncCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.vsyncCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.vsyncCheck.Location = New System.Drawing.Point(3, 3)
        Me.vsyncCheck.Name = "vsyncCheck"
        Me.vsyncCheck.Size = New System.Drawing.Size(57, 17)
        Me.vsyncCheck.TabIndex = 20
        Me.vsyncCheck.Text = "VSync"
        Me.vsyncCheck.UseVisualStyleBackColor = False
        '
        'fogShadCheck
        '
        Me.fogShadCheck.AutoSize = True
        Me.fogShadCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.fogShadCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.fogShadCheck.Location = New System.Drawing.Point(3, 72)
        Me.fogShadCheck.Name = "fogShadCheck"
        Me.fogShadCheck.Size = New System.Drawing.Size(91, 17)
        Me.fogShadCheck.TabIndex = 23
        Me.fogShadCheck.Text = "Fog Shadows"
        Me.fogShadCheck.UseVisualStyleBackColor = False
        '
        'ambOccCheck
        '
        Me.ambOccCheck.AutoSize = True
        Me.ambOccCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ambOccCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.ambOccCheck.Location = New System.Drawing.Point(3, 49)
        Me.ambOccCheck.Name = "ambOccCheck"
        Me.ambOccCheck.Size = New System.Drawing.Size(114, 17)
        Me.ambOccCheck.TabIndex = 22
        Me.ambOccCheck.Text = "Ambient Occlusion"
        Me.ambOccCheck.UseVisualStyleBackColor = False
        '
        'bloomCheck
        '
        Me.bloomCheck.AutoSize = True
        Me.bloomCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bloomCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.bloomCheck.Location = New System.Drawing.Point(123, 26)
        Me.bloomCheck.Name = "bloomCheck"
        Me.bloomCheck.Size = New System.Drawing.Size(55, 17)
        Me.bloomCheck.TabIndex = 25
        Me.bloomCheck.Text = "Bloom"
        Me.bloomCheck.UseVisualStyleBackColor = False
        '
        'blurCheck
        '
        Me.blurCheck.AutoSize = True
        Me.blurCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.blurCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.blurCheck.Location = New System.Drawing.Point(123, 3)
        Me.blurCheck.Name = "blurCheck"
        Me.blurCheck.Size = New System.Drawing.Size(79, 17)
        Me.blurCheck.TabIndex = 24
        Me.blurCheck.Text = "Motion Blur"
        Me.blurCheck.UseVisualStyleBackColor = False
        '
        'smoothCheck
        '
        Me.smoothCheck.AutoSize = True
        Me.smoothCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.smoothCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.smoothCheck.Location = New System.Drawing.Point(3, 26)
        Me.smoothCheck.Name = "smoothCheck"
        Me.smoothCheck.Size = New System.Drawing.Size(76, 17)
        Me.smoothCheck.TabIndex = 21
        Me.smoothCheck.Text = "Smoothing"
        Me.smoothCheck.UseVisualStyleBackColor = False
        '
        'wideCheck
        '
        Me.wideCheck.AutoSize = True
        Me.wideCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.wideCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.wideCheck.Location = New System.Drawing.Point(123, 49)
        Me.wideCheck.Name = "wideCheck"
        Me.wideCheck.Size = New System.Drawing.Size(107, 17)
        Me.wideCheck.TabIndex = 26
        Me.wideCheck.Text = "Wide View Mode"
        Me.wideCheck.UseVisualStyleBackColor = False
        '
        'gpuPhysCheck
        '
        Me.gpuPhysCheck.AutoSize = True
        Me.gpuPhysCheck.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.gpuPhysCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.gpuPhysCheck.Location = New System.Drawing.Point(123, 72)
        Me.gpuPhysCheck.Name = "gpuPhysCheck"
        Me.gpuPhysCheck.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gpuPhysCheck.Size = New System.Drawing.Size(110, 17)
        Me.gpuPhysCheck.TabIndex = 27
        Me.gpuPhysCheck.Text = "Use GPU Physics"
        Me.gpuPhysCheck.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Control
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 17)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Global Render Distance"
        '
        'useGlobRenCheck
        '
        Me.useGlobRenCheck.AutoSize = True
        Me.useGlobRenCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.useGlobRenCheck.Location = New System.Drawing.Point(3, 46)
        Me.useGlobRenCheck.Name = "useGlobRenCheck"
        Me.useGlobRenCheck.Size = New System.Drawing.Size(161, 17)
        Me.useGlobRenCheck.TabIndex = 16
        Me.useGlobRenCheck.Text = "Use Global Render Distance"
        Me.useGlobRenCheck.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Control
        Me.Label2.Location = New System.Drawing.Point(3, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Infantry Render Distance"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Control
        Me.Label3.Location = New System.Drawing.Point(3, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(164, 17)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Vehicle Render Distance"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Control
        Me.Label4.Location = New System.Drawing.Point(3, 152)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 17)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Aircraft Render Distance"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Control
        Me.Label5.Location = New System.Drawing.Point(3, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 17)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "Render Quality"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(3, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "FoV (Vertical)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(3, 146)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 17)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Maximum FPS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(3, 189)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 17)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Gamma"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(3, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 34)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "Particle Distance Scale"
        '
        'graphQualDrop
        '
        Me.graphQualDrop.FormattingEnabled = True
        Me.graphQualDrop.Items.AddRange(New Object() {"1. Low", "2. Medium", "3. High"})
        Me.graphQualDrop.Location = New System.Drawing.Point(3, 20)
        Me.graphQualDrop.MaxDropDownItems = 3
        Me.graphQualDrop.Name = "graphQualDrop"
        Me.graphQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.graphQualDrop.TabIndex = 1
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(3, 44)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(104, 17)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Texture Quality"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(3, 176)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(99, 17)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "Effects Quality"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(3, 220)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(102, 17)
        Me.Label12.TabIndex = 46
        Me.Label12.Text = "Terrain Quality"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.Control
        Me.Label13.Location = New System.Drawing.Point(3, 264)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(88, 17)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Flora Quality"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.Control
        Me.Label14.Location = New System.Drawing.Point(3, 132)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 17)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Lighting Quality"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.Control
        Me.Label15.Location = New System.Drawing.Point(3, 88)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 17)
        Me.Label15.TabIndex = 49
        Me.Label15.Text = "Shadow Quality"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.SystemColors.Control
        Me.Label16.Location = New System.Drawing.Point(3, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(113, 17)
        Me.Label16.TabIndex = 60
        Me.Label16.Text = "Graphics Quality"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.SystemColors.Control
        Me.Label17.Location = New System.Drawing.Point(3, 308)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(94, 17)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Model Quality"
        '
        'texQualDrop
        '
        Me.texQualDrop.FormattingEnabled = True
        Me.texQualDrop.Items.AddRange(New Object() {"0. Ultra", "1. High", "2. Medium", "3. Low"})
        Me.texQualDrop.Location = New System.Drawing.Point(3, 64)
        Me.texQualDrop.MaxDropDownItems = 4
        Me.texQualDrop.Name = "texQualDrop"
        Me.texQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.texQualDrop.TabIndex = 2
        '
        'shadQualDrop
        '
        Me.shadQualDrop.FormattingEnabled = True
        Me.shadQualDrop.Items.AddRange(New Object() {"0. Off", "1.Low", "2. Medium", "3. High", "4. Ultra", "5. Max"})
        Me.shadQualDrop.Location = New System.Drawing.Point(3, 108)
        Me.shadQualDrop.MaxDropDownItems = 6
        Me.shadQualDrop.Name = "shadQualDrop"
        Me.shadQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.shadQualDrop.TabIndex = 3
        '
        'lightQualDrop
        '
        Me.lightQualDrop.FormattingEnabled = True
        Me.lightQualDrop.Items.AddRange(New Object() {"1. Low", "2. Medium", "3. High"})
        Me.lightQualDrop.Location = New System.Drawing.Point(3, 152)
        Me.lightQualDrop.MaxDropDownItems = 3
        Me.lightQualDrop.Name = "lightQualDrop"
        Me.lightQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.lightQualDrop.TabIndex = 4
        '
        'effQualDrop
        '
        Me.effQualDrop.FormattingEnabled = True
        Me.effQualDrop.Items.AddRange(New Object() {"1. Low", "2. Medium", "3. High"})
        Me.effQualDrop.Location = New System.Drawing.Point(3, 196)
        Me.effQualDrop.MaxDropDownItems = 3
        Me.effQualDrop.Name = "effQualDrop"
        Me.effQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.effQualDrop.TabIndex = 5
        '
        'terrQualDrop
        '
        Me.terrQualDrop.FormattingEnabled = True
        Me.terrQualDrop.Items.AddRange(New Object() {"1. Low", "2. Medium", "3. High"})
        Me.terrQualDrop.Location = New System.Drawing.Point(3, 240)
        Me.terrQualDrop.MaxDropDownItems = 3
        Me.terrQualDrop.Name = "terrQualDrop"
        Me.terrQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.terrQualDrop.TabIndex = 6
        '
        'floraQualDrop
        '
        Me.floraQualDrop.FormattingEnabled = True
        Me.floraQualDrop.Items.AddRange(New Object() {"1. Low", "2. Medium", "3. High", "4. Off"})
        Me.floraQualDrop.Location = New System.Drawing.Point(3, 284)
        Me.floraQualDrop.MaxDropDownItems = 4
        Me.floraQualDrop.Name = "floraQualDrop"
        Me.floraQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.floraQualDrop.TabIndex = 7
        '
        'modQualDrop
        '
        Me.modQualDrop.FormattingEnabled = True
        Me.modQualDrop.Items.AddRange(New Object() {"1. Low", "2. Medium", "3. High"})
        Me.modQualDrop.Location = New System.Drawing.Point(3, 328)
        Me.modQualDrop.MaxDropDownItems = 3
        Me.modQualDrop.Name = "modQualDrop"
        Me.modQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.modQualDrop.TabIndex = 8
        '
        'partQualDrop
        '
        Me.partQualDrop.FormattingEnabled = True
        Me.partQualDrop.Items.AddRange(New Object() {"0. Low", "1. Medium", "2. High", "3. Ultra"})
        Me.partQualDrop.Location = New System.Drawing.Point(3, 372)
        Me.partQualDrop.MaxDropDownItems = 4
        Me.partQualDrop.Name = "partQualDrop"
        Me.partQualDrop.Size = New System.Drawing.Size(121, 21)
        Me.partQualDrop.TabIndex = 9
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.Control
        Me.Label18.Location = New System.Drawing.Point(3, 352)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(103, 17)
        Me.Label18.TabIndex = 59
        Me.Label18.Text = "Particle Quality"
        '
        'graphPanel4
        '
        Me.graphPanel4.AutoScroll = True
        Me.graphPanel4.Controls.Add(Me.vsyncCheck)
        Me.graphPanel4.Controls.Add(Me.smoothCheck)
        Me.graphPanel4.Controls.Add(Me.ambOccCheck)
        Me.graphPanel4.Controls.Add(Me.fogShadCheck)
        Me.graphPanel4.Controls.Add(Me.blurCheck)
        Me.graphPanel4.Controls.Add(Me.bloomCheck)
        Me.graphPanel4.Controls.Add(Me.wideCheck)
        Me.graphPanel4.Controls.Add(Me.gpuPhysCheck)
        Me.graphPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.graphPanel4.Location = New System.Drawing.Point(142, 262)
        Me.graphPanel4.Name = "graphPanel4"
        Me.graphPanel4.Size = New System.Drawing.Size(257, 96)
        Me.graphPanel4.TabIndex = 3
        '
        'graphPanel3
        '
        Me.graphPanel3.AutoScroll = True
        Me.graphPanel3.Controls.Add(Me.Label1)
        Me.graphPanel3.Controls.Add(Me.globRenDistBox)
        Me.graphPanel3.Controls.Add(Me.useGlobRenCheck)
        Me.graphPanel3.Controls.Add(Me.Label2)
        Me.graphPanel3.Controls.Add(Me.infRenDistBox)
        Me.graphPanel3.Controls.Add(Me.Label3)
        Me.graphPanel3.Controls.Add(Me.vehRenDistbox)
        Me.graphPanel3.Controls.Add(Me.Label4)
        Me.graphPanel3.Controls.Add(Me.airRenDistBox)
        Me.graphPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.graphPanel3.Location = New System.Drawing.Point(257, 6)
        Me.graphPanel3.Name = "graphPanel3"
        Me.graphPanel3.Size = New System.Drawing.Size(173, 206)
        Me.graphPanel3.TabIndex = 2
        '
        'globRenDistBox
        '
        Me.globRenDistBox.Location = New System.Drawing.Point(3, 20)
        Me.globRenDistBox.Maximum = New Decimal(New Integer() {6000, 0, 0, 0})
        Me.globRenDistBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.globRenDistBox.Name = "globRenDistBox"
        Me.globRenDistBox.Size = New System.Drawing.Size(120, 20)
        Me.globRenDistBox.TabIndex = 15
        Me.globRenDistBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'infRenDistBox
        '
        Me.infRenDistBox.Location = New System.Drawing.Point(3, 86)
        Me.infRenDistBox.Maximum = New Decimal(New Integer() {6000, 0, 0, 0})
        Me.infRenDistBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.infRenDistBox.Name = "infRenDistBox"
        Me.infRenDistBox.Size = New System.Drawing.Size(120, 20)
        Me.infRenDistBox.TabIndex = 21
        Me.infRenDistBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'vehRenDistbox
        '
        Me.vehRenDistbox.Location = New System.Drawing.Point(3, 129)
        Me.vehRenDistbox.Maximum = New Decimal(New Integer() {6000, 0, 0, 0})
        Me.vehRenDistbox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.vehRenDistbox.Name = "vehRenDistbox"
        Me.vehRenDistbox.Size = New System.Drawing.Size(120, 20)
        Me.vehRenDistbox.TabIndex = 22
        Me.vehRenDistbox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'airRenDistBox
        '
        Me.airRenDistBox.Location = New System.Drawing.Point(3, 172)
        Me.airRenDistBox.Maximum = New Decimal(New Integer() {6000, 0, 0, 0})
        Me.airRenDistBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.airRenDistBox.Name = "airRenDistBox"
        Me.airRenDistBox.Size = New System.Drawing.Size(120, 20)
        Me.airRenDistBox.TabIndex = 23
        Me.airRenDistBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'graphPanel2
        '
        Me.graphPanel2.AutoScroll = True
        Me.graphPanel2.Controls.Add(Me.Label5)
        Me.graphPanel2.Controls.Add(Me.renQualBox)
        Me.graphPanel2.Controls.Add(Me.Label9)
        Me.graphPanel2.Controls.Add(Me.partDistScaleBox)
        Me.graphPanel2.Controls.Add(Me.Label6)
        Me.graphPanel2.Controls.Add(Me.fovBox)
        Me.graphPanel2.Controls.Add(Me.Label7)
        Me.graphPanel2.Controls.Add(Me.maxFPSBox)
        Me.graphPanel2.Controls.Add(Me.Label8)
        Me.graphPanel2.Controls.Add(Me.gammaBox)
        Me.graphPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.graphPanel2.Location = New System.Drawing.Point(142, 6)
        Me.graphPanel2.Name = "graphPanel2"
        Me.graphPanel2.Size = New System.Drawing.Size(109, 250)
        Me.graphPanel2.TabIndex = 1
        '
        'renQualBox
        '
        Me.renQualBox.DecimalPlaces = 6
        Me.renQualBox.Increment = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.renQualBox.Location = New System.Drawing.Point(3, 20)
        Me.renQualBox.Maximum = New Decimal(New Integer() {2, 0, 0, 0})
        Me.renQualBox.Minimum = New Decimal(New Integer() {5, 0, 0, 65536})
        Me.renQualBox.Name = "renQualBox"
        Me.renQualBox.Size = New System.Drawing.Size(80, 20)
        Me.renQualBox.TabIndex = 42
        Me.renQualBox.Value = New Decimal(New Integer() {5, 0, 0, 65536})
        '
        'partDistScaleBox
        '
        Me.partDistScaleBox.DecimalPlaces = 6
        Me.partDistScaleBox.Increment = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.partDistScaleBox.Location = New System.Drawing.Point(3, 80)
        Me.partDistScaleBox.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.partDistScaleBox.Name = "partDistScaleBox"
        Me.partDistScaleBox.Size = New System.Drawing.Size(80, 20)
        Me.partDistScaleBox.TabIndex = 43
        '
        'fovBox
        '
        Me.fovBox.Location = New System.Drawing.Point(3, 123)
        Me.fovBox.Maximum = New Decimal(New Integer() {170, 0, 0, 0})
        Me.fovBox.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.fovBox.Name = "fovBox"
        Me.fovBox.Size = New System.Drawing.Size(80, 20)
        Me.fovBox.TabIndex = 44
        Me.fovBox.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'maxFPSBox
        '
        Me.maxFPSBox.Location = New System.Drawing.Point(3, 166)
        Me.maxFPSBox.Maximum = New Decimal(New Integer() {5000, 0, 0, 0})
        Me.maxFPSBox.Minimum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.maxFPSBox.Name = "maxFPSBox"
        Me.maxFPSBox.Size = New System.Drawing.Size(80, 20)
        Me.maxFPSBox.TabIndex = 45
        Me.maxFPSBox.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'gammaBox
        '
        Me.gammaBox.DecimalPlaces = 6
        Me.gammaBox.Increment = New Decimal(New Integer() {1, 0, 0, 393216})
        Me.gammaBox.Location = New System.Drawing.Point(3, 209)
        Me.gammaBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.gammaBox.Name = "gammaBox"
        Me.gammaBox.Size = New System.Drawing.Size(80, 20)
        Me.gammaBox.TabIndex = 46
        '
        'graphPanel1
        '
        Me.graphPanel1.AutoScroll = True
        Me.graphPanel1.Controls.Add(Me.Label16)
        Me.graphPanel1.Controls.Add(Me.graphQualDrop)
        Me.graphPanel1.Controls.Add(Me.Label10)
        Me.graphPanel1.Controls.Add(Me.texQualDrop)
        Me.graphPanel1.Controls.Add(Me.Label15)
        Me.graphPanel1.Controls.Add(Me.shadQualDrop)
        Me.graphPanel1.Controls.Add(Me.Label14)
        Me.graphPanel1.Controls.Add(Me.lightQualDrop)
        Me.graphPanel1.Controls.Add(Me.Label11)
        Me.graphPanel1.Controls.Add(Me.effQualDrop)
        Me.graphPanel1.Controls.Add(Me.Label12)
        Me.graphPanel1.Controls.Add(Me.terrQualDrop)
        Me.graphPanel1.Controls.Add(Me.Label13)
        Me.graphPanel1.Controls.Add(Me.floraQualDrop)
        Me.graphPanel1.Controls.Add(Me.Label17)
        Me.graphPanel1.Controls.Add(Me.modQualDrop)
        Me.graphPanel1.Controls.Add(Me.Label18)
        Me.graphPanel1.Controls.Add(Me.partQualDrop)
        Me.graphPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.graphPanel1.Location = New System.Drawing.Point(6, 6)
        Me.graphPanel1.Name = "graphPanel1"
        Me.graphPanel1.Size = New System.Drawing.Size(130, 410)
        Me.graphPanel1.TabIndex = 0
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(381, 440)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(55, 13)
        Me.Label19.TabIndex = 67
        Me.Label19.Text = "(B) Blockx"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(326, 440)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(49, 13)
        Me.Label20.TabIndex = 68
        Me.Label20.Text = "ver. 0.80"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(0, -1)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(447, 438)
        Me.TabControl1.TabIndex = 70
        Me.TabControl1.TabStop = False
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage1.Controls.Add(Me.graphPanel1)
        Me.TabPage1.Controls.Add(Me.graphPanel4)
        Me.TabPage1.Controls.Add(Me.graphPanel3)
        Me.TabPage1.Controls.Add(Me.graphPanel2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(439, 412)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Graphics"
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage2.Controls.Add(Me.DPIBox)
        Me.TabPage2.Controls.Add(Me.sensRawCheck)
        Me.TabPage2.Controls.Add(Me.Label21)
        Me.TabPage2.Controls.Add(Me.sensSensPanel)
        Me.TabPage2.Controls.Add(Me.sensTypeDrop)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(439, 412)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sensitivity"
        '
        'DPIBox
        '
        Me.DPIBox.Location = New System.Drawing.Point(193, 7)
        Me.DPIBox.Maximum = New Decimal(New Integer() {8000, 0, 0, 0})
        Me.DPIBox.Minimum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.DPIBox.Name = "DPIBox"
        Me.DPIBox.Size = New System.Drawing.Size(100, 20)
        Me.DPIBox.TabIndex = 2
        Me.DPIBox.Value = New Decimal(New Integer() {100, 0, 0, 0})
        '
        'sensRawCheck
        '
        Me.sensRawCheck.AutoSize = True
        Me.sensRawCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.sensRawCheck.Location = New System.Drawing.Point(312, 10)
        Me.sensRawCheck.Name = "sensRawCheck"
        Me.sensRawCheck.Size = New System.Drawing.Size(97, 17)
        Me.sensRawCheck.TabIndex = 3
        Me.sensRawCheck.Text = "Use Raw Input"
        Me.sensRawCheck.UseVisualStyleBackColor = True
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.SystemColors.Control
        Me.Label21.Location = New System.Drawing.Point(156, 7)
        Me.Label21.Margin = New System.Windows.Forms.Padding(3, 0, 0, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 17)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "DPI:"
        '
        'sensSensPanel
        '
        Me.sensSensPanel.Controls.Add(Me.recalcSensButton)
        Me.sensSensPanel.Controls.Add(Me.sensPanel4)
        Me.sensSensPanel.Controls.Add(Me.sensPanel3)
        Me.sensSensPanel.Controls.Add(Me.sensPanel1)
        Me.sensSensPanel.Controls.Add(Me.sensPanel2)
        Me.sensSensPanel.Location = New System.Drawing.Point(8, 33)
        Me.sensSensPanel.Name = "sensSensPanel"
        Me.sensSensPanel.Size = New System.Drawing.Size(424, 373)
        Me.sensSensPanel.TabIndex = 3
        '
        'recalcSensButton
        '
        Me.recalcSensButton.Location = New System.Drawing.Point(236, 228)
        Me.recalcSensButton.Name = "recalcSensButton"
        Me.recalcSensButton.Size = New System.Drawing.Size(75, 23)
        Me.recalcSensButton.TabIndex = 5
        Me.recalcSensButton.Text = "Recalculate"
        Me.recalcSensButton.UseVisualStyleBackColor = True
        '
        'sensPanel4
        '
        Me.sensPanel4.Location = New System.Drawing.Point(146, 33)
        Me.sensPanel4.Name = "sensPanel4"
        '
        'sensPanel4.Panel1
        '
        Me.sensPanel4.Panel1.Controls.Add(Me.Label53)
        Me.sensPanel4.Panel1.Controls.Add(Me.Label52)
        Me.sensPanel4.Panel1.Controls.Add(Me.Label51)
        '
        'sensPanel4.Panel2
        '
        Me.sensPanel4.Panel2.Controls.Add(Me.Label56)
        Me.sensPanel4.Panel2.Controls.Add(Me.Label55)
        Me.sensPanel4.Panel2.Controls.Add(Me.Label54)
        Me.sensPanel4.Size = New System.Drawing.Size(255, 177)
        Me.sensPanel4.SplitterDistance = 168
        Me.sensPanel4.TabIndex = 4
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label53.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.SystemColors.Control
        Me.Label53.Location = New System.Drawing.Point(9, 67)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(156, 17)
        Me.Label53.TabIndex = 65
        Me.Label53.Text = "Scope sensitivity set to:"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label52.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.SystemColors.Control
        Me.Label52.Location = New System.Drawing.Point(21, 39)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(144, 17)
        Me.Label52.TabIndex = 64
        Me.Label52.Text = "ADS sensitivity set to:"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label51.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.SystemColors.Control
        Me.Label51.Location = New System.Drawing.Point(8, 11)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(157, 17)
        Me.Label51.TabIndex = 63
        Me.Label51.Text = "Hipfire sensitivity set to:"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label56.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label56.ForeColor = System.Drawing.SystemColors.Control
        Me.Label56.Location = New System.Drawing.Point(3, 66)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(0, 17)
        Me.Label56.TabIndex = 88
        '
        'Label55
        '
        Me.Label55.AutoSize = True
        Me.Label55.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label55.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label55.ForeColor = System.Drawing.SystemColors.Control
        Me.Label55.Location = New System.Drawing.Point(3, 39)
        Me.Label55.Name = "Label55"
        Me.Label55.Size = New System.Drawing.Size(0, 17)
        Me.Label55.TabIndex = 87
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label54.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.SystemColors.Control
        Me.Label54.Location = New System.Drawing.Point(3, 11)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(0, 17)
        Me.Label54.TabIndex = 86
        '
        'sensPanel3
        '
        Me.sensPanel3.Controls.Add(Me.Label46)
        Me.sensPanel3.Controls.Add(Me.hip360Box)
        Me.sensPanel3.Controls.Add(Me.Label47)
        Me.sensPanel3.Controls.Add(Me.ads360Box)
        Me.sensPanel3.Controls.Add(Me.Label50)
        Me.sensPanel3.Controls.Add(Me.adsZoomBox)
        Me.sensPanel3.Controls.Add(Me.Label48)
        Me.sensPanel3.Controls.Add(Me.scop360Box)
        Me.sensPanel3.Controls.Add(Me.Label49)
        Me.sensPanel3.Controls.Add(Me.scopZoomBox)
        Me.sensPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.sensPanel3.Location = New System.Drawing.Point(12, 13)
        Me.sensPanel3.Name = "sensPanel3"
        Me.sensPanel3.Size = New System.Drawing.Size(118, 282)
        Me.sensPanel3.TabIndex = 3
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label46.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.SystemColors.Control
        Me.Label46.Location = New System.Drawing.Point(3, 0)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(99, 17)
        Me.Label46.TabIndex = 76
        Me.Label46.Text = "Hipfire cm/360"
        '
        'hip360Box
        '
        Me.hip360Box.DecimalPlaces = 3
        Me.hip360Box.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.hip360Box.Location = New System.Drawing.Point(3, 20)
        Me.hip360Box.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.hip360Box.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hip360Box.Name = "hip360Box"
        Me.hip360Box.Size = New System.Drawing.Size(100, 20)
        Me.hip360Box.TabIndex = 79
        Me.hip360Box.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label47.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.SystemColors.Control
        Me.Label47.Location = New System.Drawing.Point(3, 43)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(86, 17)
        Me.Label47.TabIndex = 77
        Me.Label47.Text = "ADS cm/360"
        '
        'ads360Box
        '
        Me.ads360Box.DecimalPlaces = 3
        Me.ads360Box.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.ads360Box.Location = New System.Drawing.Point(3, 63)
        Me.ads360Box.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.ads360Box.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ads360Box.Name = "ads360Box"
        Me.ads360Box.Size = New System.Drawing.Size(100, 20)
        Me.ads360Box.TabIndex = 80
        Me.ads360Box.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label50.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.SystemColors.Control
        Me.Label50.Location = New System.Drawing.Point(3, 86)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(76, 17)
        Me.Label50.TabIndex = 85
        Me.Label50.Text = "ADS Zoom"
        '
        'adsZoomBox
        '
        Me.adsZoomBox.FormattingEnabled = True
        Me.adsZoomBox.Items.AddRange(New Object() {"1x", "2x"})
        Me.adsZoomBox.Location = New System.Drawing.Point(3, 106)
        Me.adsZoomBox.MaxDropDownItems = 3
        Me.adsZoomBox.Name = "adsZoomBox"
        Me.adsZoomBox.Size = New System.Drawing.Size(50, 21)
        Me.adsZoomBox.TabIndex = 81
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label48.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.SystemColors.Control
        Me.Label48.Location = New System.Drawing.Point(3, 130)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(98, 17)
        Me.Label48.TabIndex = 78
        Me.Label48.Text = "Scope cm/360"
        '
        'scop360Box
        '
        Me.scop360Box.DecimalPlaces = 3
        Me.scop360Box.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.scop360Box.Location = New System.Drawing.Point(3, 150)
        Me.scop360Box.Maximum = New Decimal(New Integer() {200, 0, 0, 0})
        Me.scop360Box.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.scop360Box.Name = "scop360Box"
        Me.scop360Box.Size = New System.Drawing.Size(100, 20)
        Me.scop360Box.TabIndex = 82
        Me.scop360Box.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label49
        '
        Me.Label49.AutoSize = True
        Me.Label49.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label49.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label49.ForeColor = System.Drawing.SystemColors.Control
        Me.Label49.Location = New System.Drawing.Point(3, 173)
        Me.Label49.Name = "Label49"
        Me.Label49.Size = New System.Drawing.Size(88, 17)
        Me.Label49.TabIndex = 84
        Me.Label49.Text = "Scope Zoom"
        '
        'scopZoomBox
        '
        Me.scopZoomBox.FormattingEnabled = True
        Me.scopZoomBox.Items.AddRange(New Object() {"3.4x", "4x", "6x", "8x", "10x", "12x"})
        Me.scopZoomBox.Location = New System.Drawing.Point(3, 193)
        Me.scopZoomBox.MaxDropDownItems = 3
        Me.scopZoomBox.Name = "scopZoomBox"
        Me.scopZoomBox.Size = New System.Drawing.Size(50, 21)
        Me.scopZoomBox.TabIndex = 83
        '
        'sensPanel1
        '
        Me.sensPanel1.Controls.Add(Me.Label22)
        Me.sensPanel1.Controls.Add(Me.hipSensBox)
        Me.sensPanel1.Controls.Add(Me.Label23)
        Me.sensPanel1.Controls.Add(Me.adsSensBox)
        Me.sensPanel1.Controls.Add(Me.Label24)
        Me.sensPanel1.Controls.Add(Me.scopSensBox)
        Me.sensPanel1.Controls.Add(Me.Label27)
        Me.sensPanel1.Controls.Add(Me.vehSensBox)
        Me.sensPanel1.Controls.Add(Me.Label26)
        Me.sensPanel1.Controls.Add(Me.gunSensBox)
        Me.sensPanel1.Controls.Add(Me.Label25)
        Me.sensPanel1.Controls.Add(Me.airSensBox)
        Me.sensPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.sensPanel1.Location = New System.Drawing.Point(12, 13)
        Me.sensPanel1.Name = "sensPanel1"
        Me.sensPanel1.Size = New System.Drawing.Size(118, 282)
        Me.sensPanel1.TabIndex = 1
        Me.sensPanel1.Visible = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.SystemColors.Control
        Me.Label22.Location = New System.Drawing.Point(3, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(85, 17)
        Me.Label22.TabIndex = 53
        Me.Label22.Text = "Hipfire Sens"
        '
        'hipSensBox
        '
        Me.hipSensBox.DecimalPlaces = 3
        Me.hipSensBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.hipSensBox.Location = New System.Drawing.Point(3, 20)
        Me.hipSensBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.hipSensBox.Name = "hipSensBox"
        Me.hipSensBox.Size = New System.Drawing.Size(100, 20)
        Me.hipSensBox.TabIndex = 73
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.SystemColors.Control
        Me.Label23.Location = New System.Drawing.Point(3, 43)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(72, 17)
        Me.Label23.TabIndex = 54
        Me.Label23.Text = "ADS Sens"
        '
        'adsSensBox
        '
        Me.adsSensBox.DecimalPlaces = 3
        Me.adsSensBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.adsSensBox.Location = New System.Drawing.Point(3, 63)
        Me.adsSensBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.adsSensBox.Name = "adsSensBox"
        Me.adsSensBox.Size = New System.Drawing.Size(100, 20)
        Me.adsSensBox.TabIndex = 74
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.SystemColors.Control
        Me.Label24.Location = New System.Drawing.Point(3, 86)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(84, 17)
        Me.Label24.TabIndex = 55
        Me.Label24.Text = "Scope Sens"
        '
        'scopSensBox
        '
        Me.scopSensBox.DecimalPlaces = 3
        Me.scopSensBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.scopSensBox.Location = New System.Drawing.Point(3, 106)
        Me.scopSensBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.scopSensBox.Name = "scopSensBox"
        Me.scopSensBox.Size = New System.Drawing.Size(100, 20)
        Me.scopSensBox.TabIndex = 75
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.SystemColors.Control
        Me.Label27.Location = New System.Drawing.Point(3, 129)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(90, 17)
        Me.Label27.TabIndex = 59
        Me.Label27.Text = "Vehicle Sens"
        '
        'vehSensBox
        '
        Me.vehSensBox.DecimalPlaces = 3
        Me.vehSensBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.vehSensBox.Location = New System.Drawing.Point(3, 149)
        Me.vehSensBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.vehSensBox.Name = "vehSensBox"
        Me.vehSensBox.Size = New System.Drawing.Size(100, 20)
        Me.vehSensBox.TabIndex = 76
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label26.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.SystemColors.Control
        Me.Label26.Location = New System.Drawing.Point(3, 172)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(92, 17)
        Me.Label26.TabIndex = 60
        Me.Label26.Text = "Gunner Sens"
        '
        'gunSensBox
        '
        Me.gunSensBox.DecimalPlaces = 3
        Me.gunSensBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.gunSensBox.Location = New System.Drawing.Point(3, 192)
        Me.gunSensBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.gunSensBox.Name = "gunSensBox"
        Me.gunSensBox.Size = New System.Drawing.Size(100, 20)
        Me.gunSensBox.TabIndex = 77
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.ForeColor = System.Drawing.SystemColors.Control
        Me.Label25.Location = New System.Drawing.Point(3, 215)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(89, 17)
        Me.Label25.TabIndex = 61
        Me.Label25.Text = "Aircraft Sens"
        '
        'airSensBox
        '
        Me.airSensBox.DecimalPlaces = 3
        Me.airSensBox.Increment = New Decimal(New Integer() {1, 0, 0, 196608})
        Me.airSensBox.Location = New System.Drawing.Point(3, 235)
        Me.airSensBox.Maximum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.airSensBox.Name = "airSensBox"
        Me.airSensBox.Size = New System.Drawing.Size(100, 20)
        Me.airSensBox.TabIndex = 78
        '
        'sensPanel2
        '
        Me.sensPanel2.Location = New System.Drawing.Point(146, 33)
        Me.sensPanel2.Name = "sensPanel2"
        '
        'sensPanel2.Panel1
        '
        Me.sensPanel2.Panel1.Controls.Add(Me.Label31)
        Me.sensPanel2.Panel1.Controls.Add(Me.Label36)
        Me.sensPanel2.Panel1.Controls.Add(Me.Label28)
        Me.sensPanel2.Panel1.Controls.Add(Me.Label35)
        Me.sensPanel2.Panel1.Controls.Add(Me.Label30)
        Me.sensPanel2.Panel1.Controls.Add(Me.Label34)
        Me.sensPanel2.Panel1.Controls.Add(Me.Label29)
        Me.sensPanel2.Panel1.Controls.Add(Me.Label33)
        Me.sensPanel2.Panel1.Controls.Add(Me.Label32)
        '
        'sensPanel2.Panel2
        '
        Me.sensPanel2.Panel2.Controls.Add(Me.Label37)
        Me.sensPanel2.Panel2.Controls.Add(Me.Label45)
        Me.sensPanel2.Panel2.Controls.Add(Me.Label38)
        Me.sensPanel2.Panel2.Controls.Add(Me.Label44)
        Me.sensPanel2.Panel2.Controls.Add(Me.Label39)
        Me.sensPanel2.Panel2.Controls.Add(Me.Label43)
        Me.sensPanel2.Panel2.Controls.Add(Me.Label40)
        Me.sensPanel2.Panel2.Controls.Add(Me.Label42)
        Me.sensPanel2.Panel2.Controls.Add(Me.Label41)
        Me.sensPanel2.Size = New System.Drawing.Size(255, 177)
        Me.sensPanel2.SplitterDistance = 125
        Me.sensPanel2.TabIndex = 2
        Me.sensPanel2.Visible = False
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.SystemColors.Control
        Me.Label31.Location = New System.Drawing.Point(34, 70)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(88, 17)
        Me.Label31.TabIndex = 66
        Me.Label31.Text = "3.4x cm/360:"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.SystemColors.Control
        Me.Label36.Location = New System.Drawing.Point(38, 155)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(84, 17)
        Me.Label36.TabIndex = 71
        Me.Label36.Text = "12x cm/360:"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.SystemColors.Control
        Me.Label28.Location = New System.Drawing.Point(19, 3)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(103, 17)
        Me.Label28.TabIndex = 62
        Me.Label28.Text = "Hipfire cm/360:"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.ForeColor = System.Drawing.SystemColors.Control
        Me.Label35.Location = New System.Drawing.Point(38, 138)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 17)
        Me.Label35.TabIndex = 70
        Me.Label35.Text = "10x cm/360:"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label30.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.SystemColors.Control
        Me.Label30.Location = New System.Drawing.Point(46, 29)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(76, 17)
        Me.Label30.TabIndex = 64
        Me.Label30.Text = "1x cm/360:"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.ForeColor = System.Drawing.SystemColors.Control
        Me.Label34.Location = New System.Drawing.Point(46, 121)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(76, 17)
        Me.Label34.TabIndex = 69
        Me.Label34.Text = "8x cm/360:"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.SystemColors.Control
        Me.Label29.Location = New System.Drawing.Point(46, 46)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(76, 17)
        Me.Label29.TabIndex = 65
        Me.Label29.Text = "2x cm/360:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.SystemColors.Control
        Me.Label33.Location = New System.Drawing.Point(46, 104)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(76, 17)
        Me.Label33.TabIndex = 68
        Me.Label33.Text = "6x cm/360:"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.SystemColors.Control
        Me.Label32.Location = New System.Drawing.Point(46, 87)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(76, 17)
        Me.Label32.TabIndex = 67
        Me.Label32.Text = "4x cm/360:"
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.ForeColor = System.Drawing.SystemColors.Control
        Me.Label37.Location = New System.Drawing.Point(3, 70)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(0, 17)
        Me.Label37.TabIndex = 75
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label45.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.SystemColors.Control
        Me.Label45.Location = New System.Drawing.Point(3, 87)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(0, 17)
        Me.Label45.TabIndex = 76
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.SystemColors.Control
        Me.Label38.Location = New System.Drawing.Point(3, 155)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(0, 17)
        Me.Label38.TabIndex = 80
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.SystemColors.Control
        Me.Label44.Location = New System.Drawing.Point(3, 104)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(0, 17)
        Me.Label44.TabIndex = 77
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.SystemColors.Control
        Me.Label39.Location = New System.Drawing.Point(3, 3)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(0, 17)
        Me.Label39.TabIndex = 72
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.SystemColors.Control
        Me.Label43.Location = New System.Drawing.Point(3, 46)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(0, 17)
        Me.Label43.TabIndex = 74
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.SystemColors.Control
        Me.Label40.Location = New System.Drawing.Point(3, 138)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(0, 17)
        Me.Label40.TabIndex = 79
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.SystemColors.Control
        Me.Label42.Location = New System.Drawing.Point(3, 121)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(0, 17)
        Me.Label42.TabIndex = 78
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.SystemColors.Control
        Me.Label41.Location = New System.Drawing.Point(3, 29)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(0, 17)
        Me.Label41.TabIndex = 73
        '
        'sensTypeDrop
        '
        Me.sensTypeDrop.FormattingEnabled = True
        Me.sensTypeDrop.Items.AddRange(New Object() {"Sensitivity", "cm/360"})
        Me.sensTypeDrop.Location = New System.Drawing.Point(8, 6)
        Me.sensTypeDrop.MaxDropDownItems = 3
        Me.sensTypeDrop.Name = "sensTypeDrop"
        Me.sensTypeDrop.Size = New System.Drawing.Size(121, 21)
        Me.sensTypeDrop.TabIndex = 2
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.TabPage3.Controls.Add(Me.Label57)
        Me.TabPage3.Controls.Add(Me.fontAutoCheck)
        Me.TabPage3.Controls.Add(Me.selectedFontPath)
        Me.TabPage3.Controls.Add(Me.fontSelectButton)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Margin = New System.Windows.Forms.Padding(3, 3, 0, 3)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(439, 412)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Font"
        '
        'fontAutoCheck
        '
        Me.fontAutoCheck.AutoSize = True
        Me.fontAutoCheck.ForeColor = System.Drawing.SystemColors.Control
        Me.fontAutoCheck.Location = New System.Drawing.Point(8, 17)
        Me.fontAutoCheck.Name = "fontAutoCheck"
        Me.fontAutoCheck.Size = New System.Drawing.Size(155, 17)
        Me.fontAutoCheck.TabIndex = 2
        Me.fontAutoCheck.Text = "Automatically Replace Font"
        Me.fontAutoCheck.UseVisualStyleBackColor = True
        '
        'selectedFontPath
        '
        Me.selectedFontPath.AutoSize = True
        Me.selectedFontPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.selectedFontPath.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedFontPath.ForeColor = System.Drawing.SystemColors.Control
        Me.selectedFontPath.Location = New System.Drawing.Point(8, 66)
        Me.selectedFontPath.Name = "selectedFontPath"
        Me.selectedFontPath.Size = New System.Drawing.Size(0, 17)
        Me.selectedFontPath.TabIndex = 63
        '
        'fontSelectButton
        '
        Me.fontSelectButton.Location = New System.Drawing.Point(8, 40)
        Me.fontSelectButton.Name = "fontSelectButton"
        Me.fontSelectButton.Size = New System.Drawing.Size(75, 23)
        Me.fontSelectButton.TabIndex = 3
        Me.fontSelectButton.Text = "Select Font"
        Me.fontSelectButton.UseVisualStyleBackColor = True
        '
        'Label57
        '
        Me.Label57.AutoSize = True
        Me.Label57.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label57.ForeColor = System.Drawing.Color.White
        Me.Label57.Location = New System.Drawing.Point(5, 112)
        Me.Label57.Name = "Label57"
        Me.Label57.Size = New System.Drawing.Size(418, 160)
        Me.Label57.TabIndex = 64
        Me.Label57.Text = resources.GetString("Label57.Text")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange
        Me.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ClientSize = New System.Drawing.Size(448, 503)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.startLauncher)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "iniEdit"
        Me.graphPanel4.ResumeLayout(False)
        Me.graphPanel4.PerformLayout()
        Me.graphPanel3.ResumeLayout(False)
        Me.graphPanel3.PerformLayout()
        CType(Me.globRenDistBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.infRenDistBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vehRenDistbox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.airRenDistBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.graphPanel2.ResumeLayout(False)
        Me.graphPanel2.PerformLayout()
        CType(Me.renQualBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partDistScaleBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fovBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.maxFPSBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gammaBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.graphPanel1.ResumeLayout(False)
        Me.graphPanel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DPIBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sensSensPanel.ResumeLayout(False)
        Me.sensPanel4.Panel1.ResumeLayout(False)
        Me.sensPanel4.Panel1.PerformLayout()
        Me.sensPanel4.Panel2.ResumeLayout(False)
        Me.sensPanel4.Panel2.PerformLayout()
        CType(Me.sensPanel4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sensPanel4.ResumeLayout(False)
        Me.sensPanel3.ResumeLayout(False)
        Me.sensPanel3.PerformLayout()
        CType(Me.hip360Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ads360Box, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scop360Box, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sensPanel1.ResumeLayout(False)
        Me.sensPanel1.PerformLayout()
        CType(Me.hipSensBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.adsSensBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.scopSensBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.vehSensBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gunSensBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.airSensBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sensPanel2.Panel1.ResumeLayout(False)
        Me.sensPanel2.Panel1.PerformLayout()
        Me.sensPanel2.Panel2.ResumeLayout(False)
        Me.sensPanel2.Panel2.PerformLayout()
        CType(Me.sensPanel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sensPanel2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents startLauncher As Button
    Friend WithEvents vsyncCheck As CheckBox
    Friend WithEvents fogShadCheck As CheckBox
    Friend WithEvents ambOccCheck As CheckBox
    Friend WithEvents bloomCheck As CheckBox
    Friend WithEvents blurCheck As CheckBox
    Friend WithEvents smoothCheck As CheckBox
    Friend WithEvents wideCheck As CheckBox
    Friend WithEvents gpuPhysCheck As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents useGlobRenCheck As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents graphQualDrop As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents texQualDrop As ComboBox
    Friend WithEvents shadQualDrop As ComboBox
    Friend WithEvents lightQualDrop As ComboBox
    Friend WithEvents effQualDrop As ComboBox
    Friend WithEvents terrQualDrop As ComboBox
    Friend WithEvents floraQualDrop As ComboBox
    Friend WithEvents modQualDrop As ComboBox
    Friend WithEvents partQualDrop As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents graphPanel4 As FlowLayoutPanel
    Friend WithEvents graphPanel3 As FlowLayoutPanel
    Friend WithEvents graphPanel2 As FlowLayoutPanel
    Friend WithEvents graphPanel1 As FlowLayoutPanel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents sensRawCheck As CheckBox
    Friend WithEvents Label21 As Label
    Friend WithEvents sensSensPanel As Panel
    Friend WithEvents Label30 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents sensTypeDrop As ComboBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents selectedFontPath As Label
    Friend WithEvents fontSelectButton As Button
    Friend WithEvents Label36 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents sensPanel2 As SplitContainer
    Friend WithEvents Label37 As Label
    Friend WithEvents Label45 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label44 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents Label43 As Label
    Friend WithEvents Label40 As Label
    Friend WithEvents Label42 As Label
    Friend WithEvents Label41 As Label
    Friend WithEvents globRenDistBox As NumericUpDown
    Friend WithEvents infRenDistBox As NumericUpDown
    Friend WithEvents vehRenDistbox As NumericUpDown
    Friend WithEvents airRenDistBox As NumericUpDown
    Friend WithEvents renQualBox As NumericUpDown
    Friend WithEvents partDistScaleBox As NumericUpDown
    Friend WithEvents fovBox As NumericUpDown
    Friend WithEvents maxFPSBox As NumericUpDown
    Friend WithEvents gammaBox As NumericUpDown
    Friend WithEvents DPIBox As NumericUpDown
    Friend WithEvents sensPanel1 As FlowLayoutPanel
    Friend WithEvents hipSensBox As NumericUpDown
    Friend WithEvents adsSensBox As NumericUpDown
    Friend WithEvents scopSensBox As NumericUpDown
    Friend WithEvents vehSensBox As NumericUpDown
    Friend WithEvents gunSensBox As NumericUpDown
    Friend WithEvents airSensBox As NumericUpDown
    Friend WithEvents sensPanel3 As FlowLayoutPanel
    Friend WithEvents Label46 As Label
    Friend WithEvents hip360Box As NumericUpDown
    Friend WithEvents Label47 As Label
    Friend WithEvents ads360Box As NumericUpDown
    Friend WithEvents Label48 As Label
    Friend WithEvents scop360Box As NumericUpDown
    Friend WithEvents sensPanel4 As SplitContainer
    Friend WithEvents Label53 As Label
    Friend WithEvents Label52 As Label
    Friend WithEvents Label51 As Label
    Friend WithEvents Label50 As Label
    Friend WithEvents adsZoomBox As ComboBox
    Friend WithEvents Label49 As Label
    Friend WithEvents scopZoomBox As ComboBox
    Friend WithEvents Label56 As Label
    Friend WithEvents Label55 As Label
    Friend WithEvents Label54 As Label
    Friend WithEvents recalcSensButton As Button
    Friend WithEvents fontAutoCheck As CheckBox
    Friend WithEvents Label57 As Label
End Class
