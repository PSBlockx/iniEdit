Imports System.Diagnostics.Eventing.Reader
Imports System.IO
Imports System.ComponentModel
Public Class Form1
    Public Shared doneLoading As Boolean = False
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read ini into previously initialized empty list
        Try
            curini = File.ReadAllLines("Useroptions.ini").ToList
        Catch ex As Exception
            MessageBox.Show("Could not locate base useroptions.ini. Please ensure exe is placed in PS2 game folder.")
            End
        End Try
        If File.Exists(iniPath) Then
            iniini = File.ReadAllLines(iniPath).ToList
        Else
            Dim inistart As String = "[iniEdit]"
            File.WriteAllText(iniPath, inistart)
            iniini = File.ReadAllLines(iniPath).ToList
        End If
        readAllOptions()
        sensTypeDrop.SelectedIndex = 0
        curEditLabel.Text = String.Concat("Currently Editing: ", curiniPath)
        doneLoading = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    Function readAllOptions()
        'Big list of checking where the options are at cus i dont code good
#Region "GraphicsGets"
        vsyncCheck.Checked = GetState("VSync=")
        fogShadCheck.Checked = GetState("FogShadowsEnable=")
        ambOccCheck.Checked = GetState("AO=")
        bloomCheck.Checked = GetState("BloomEnabled=")
        blurCheck.Checked = GetState("MotionBlur=")
        smoothCheck.Checked = GetState("Smoothing=")
        wideCheck.Checked = GetState("UseAspectFOV=")
        useGlobRenCheck.Checked = GetState("UseGlobalRenderDistance=")
        globRenDistBox.Text = GetState("RenderDistance=")
        infRenDistBox.Text = GetState("InfantryRenderDistance=")
        vehRenDistbox.Text = GetState("GroundVehicleRenderDistance=")
        airRenDistBox.Text = GetState("AirVehicleRenderDistance=")
        fovBox.Text = GetState("VerticalFOV=")
        renQualBox.Text = GetState("RenderQuality=")
        maxFPSBox.Text = GetState("MaximumFPS=")
        gammaBox.Text = GetState("Gamma=")
        partDistScaleBox.Text = GetState("ParticleDistanceScale=")
        graphQualDrop.SelectedIndex = Integer.Parse(GetState("GraphicsQuality=")) - 1
        texQualDrop.SelectedIndex = Integer.Parse(GetState("TextureQuality="))
        If GetState("ShadowQuality=") > 5 Then
            shadQualDrop.SelectedIndex = 0
        Else
            shadQualDrop.SelectedIndex = Integer.Parse(GetState("ShadowQuality="))
        End If
        lightQualDrop.SelectedIndex = Integer.Parse(GetState("LightingQuality=")) - 1
        effQualDrop.SelectedIndex = Integer.Parse(GetState("EffectsQuality=")) - 1
        terrQualDrop.SelectedIndex = Integer.Parse(GetState("TerrainQuality=")) - 1
        floraQualDrop.SelectedIndex = Integer.Parse(GetState("FloraQuality=")) - 1
        modQualDrop.SelectedIndex = Integer.Parse(GetState("ModelQuality=")) - 1
        partQualDrop.SelectedIndex = Integer.Parse(GetState("ParticleLOD="))
        If GetState("DLSSQuality=") = "-1" And GetState("FSRQuality=") = "-1" Then
            upscaleDrop.SelectedIndex = 0
        ElseIf GetState("FSRQuality=") = "-1" Then
            upscaleDrop.SelectedIndex = 1
            DLSSQualDrop.SelectedIndex = GetState("DLSSQuality=")
            DLSSSharpBox.Value = GetState("DLSSSharpness=")
        ElseIf GetState("DLSSQuality=") = "-1" Then
            upscaleDrop.SelectedIndex = 2
            FSRQualDrop.SelectedIndex = GetState("FSRQuality=")
            FSRSharpBox.Value = GetState("FSRSharpness=")
        Else
            upscaleDrop.SelectedIndex = 0
        End If
        AADrop.SelectedIndex = Integer.Parse(GetState("AAQuality=")) + 1
        waterReflectDrop.SelectedIndex = Integer.Parse(GetState("WaterQuality="))
        objReflectDrop.SelectedIndex = Integer.Parse(GetState("SSLRQuality="))
#End Region
#Region "SensGets"
        hipSensBox.Value = GetState("MouseSensitivity=")
        adsSensBox.Value = GetState("ADSMouseSensitivity=")
        scopSensBox.Value = GetState("ScopedMouseSensitivity=")
        vehSensBox.Value = GetState("VehicleMouseSensitivity=")
        gunSensBox.Value = GetState("VehicleGunnerMouseSensitivity=")
        airSensBox.Value = GetState("FlightMouseSensitivity=")
        sensRawCheck.Checked = GetState("MouseRawInput=")
        If GetStateMyIni("DPI=") = 0 Then
            DPIBox.Value = 100
        Else
            DPIBox.Value = GetStateMyIni("DPI=")
        End If
#End Region
#Region "InterfaceGets"
        hudHPCheck.Checked = GetState("HudShowHealth=")
        hudIndCheck.Checked = GetState("HudShowIndicatorNames=")
        hudAlertCheck.Checked = GetState("HudShowAlertTimer")
        hudLootCheck.Checked = GetState("DrawLootDrop=")
        hudSpamCheck.Checked = GetState("DrawKillSpam=")
        hudCompCheck.Checked = GetState("HudShowTopCompass=")
        hudDotCheck.Checked = GetState("HudShow3PVehicleReticle=")
        custRetCheck.Checked = GetState("TintModeReticuleStyle=")
        retColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("TintModeReticuleColor=")))
        If Not GetState("PlatoonSquadColor0=") = Nothing Then
            alphaColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("PlatoonSquadColor0=")))
        End If
        If Not GetState("PlatoonSquadColor0=") = Nothing Then
            bravoColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("PlatoonSquadColor1=")))
        End If
        If Not GetState("PlatoonSquadColor0=") = Nothing Then
            charlieColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("PlatoonSquadColor2=")))
        End If
        If Not GetState("PlatoonSquadColor0=") = Nothing Then
            deltaColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("PlatoonSquadColor3=")))
        End If
        NDZColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("NoDeployZoneColor=")))
        OSColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("OrbitalStrikeColor=")))
        OSAlphaBox.Value = GetState("OrbitalStrikeAlpha=")
        If GetState("TintModePlayer=") = "0" Then
            playerColorDrop.SelectedIndex = 0
        ElseIf GetState("TintModePlayer=") = "1" Then
            playerColorDrop.SelectedIndex = 1
        Else
            playerColorDrop.SelectedIndex = 2
            playerColorPanelButtons.Visible = True
        End If
        If GetState("TintModeFacility=") = "0" Then
            facColorDrop.SelectedIndex = 0
        ElseIf GetState("TintModeFacility=") = "1" Then
            facColorDrop.SelectedIndex = 1
        Else
            facColorDrop.SelectedIndex = 2
            terrColorPanelButtons.Visible = True
        End If
        If GetState("TintModeMap=") = "0" Then
            terrColorDrop.SelectedIndex = 0
        ElseIf GetState("TintModeMap=") = "1" Then
            terrColorDrop.SelectedIndex = 1
        Else
            terrColorDrop.SelectedIndex = 2
            facColorPanelButtons.Visible = True
        End If
#End Region
#Region "SoundGets"
        masVolBox.Value = GetState("Master=")
        musVolBox.Value = GetState("Music=")
        gamVolBox.Value = GetState("Game=")
        diaVolBox.Value = GetState("Dialog=")
        maxVoiceBox.Value = GetState("MaxVoices=")
        hitIndCheck.Checked = GetState("HitIndicator=")
        lowAmmCheck.Checked = GetState("LowAmmoIndicator=")
        vehChatterCheck.Checked = GetState("VehicleChatter=")
        idleMusicCheck.Checked = GetState("IdleMusic=")
#End Region
#Region "ChatGets"
        yellTextCheck.Checked = GetState("Yell=")
        squadTextCheck.Checked = GetState("Squad=")
        raidTextCheck.Checked = GetState("Platoon=")
        fireteamTextCheck.Checked = GetState("Fireteam=")
        leaderTextCheck.Checked = GetState("Leader=")
        proxTextCheck.Checked = GetState("Proximity=")
        outfitTextCheck.Checked = GetState("Outfit=")
        regionTextCheck.Checked = GetState("Region=")
        mentorTextCheck.Checked = GetState("Mentor=")
        genVoiceVolBox.Value = GetState("ReceiveVolume=")
        proxVoiceVolBox.Value = GetStateSpecific("ProximityVolume=", "[VoiceChat]")
        squadVoiceVolBox.Value = GetStateSpecific("GroupVolume=", "[VoiceChat]")
        raidVoiceVolBox.Value = GetStateSpecific("RaidVolume=", "[VoiceChat]")
        outfitVoiceVolBox.Value = GetStateSpecific("GuildVolume=", "[VoiceChat]")
        leaderVoiceVolBox.Value = GetStateSpecific("GroupLeaderVolume=", "[VoiceChat]")
        transmitVoiceVolBox.Value = GetState("MicrophoneVolume=")
        duckVoiceVolBox.Value = GetState("Ducking=")
        proxVoiceCheck.Checked = GetStateSpecific("ProximityEnabled=", "[Voice]")
        squadVoiceCheck.Checked = GetStateSpecific("GroupEnabled=", "[Voice]")
        raidVoiceCheck.Checked = GetStateSpecific("RaidEnabled=", "[Voice]")
        outfitVoiceCheck.Checked = GetStateSpecific("GuildEnabled=", "[Voice]")
        leaderVoiceCheck.Checked = GetStateSpecific("GroupLeaderEnabled=", "[Voice]")
#End Region
#Region "iniEditGets"
        fontAutoCheck.Checked = GetStateMyIni("FontAutoReplace=")
        If fontAutoCheck.Checked Then
            selectedFontPath.Visible = True
            fontAutoCheck2.Visible = True
            fontSelectButton.Visible = True
        Else
            selectedFontPath.Visible = False
            fontAutoCheck2.Visible = False
            fontSelectButton.Visible = False
        End If
        selectedFontPath.Text = GetStateMyIni("FontFilePath=")
        fontAutoCheck2.Checked = GetStateMyIni("FontAutoReplace2=")
        localeReplaceCheck.Checked = GetStateMyIni("LocaleAutoReplace=")
        If localeReplaceCheck.Checked Then
            localeDatButton.Visible = True
            localeDirButton.Visible = True
            selectedDatPath.Visible = True
            selectedDirPath.Visible = True
            Label38.Visible = True
        Else
            localeDatButton.Visible = False
            localeDirButton.Visible = False
            selectedDatPath.Visible = False
            selectedDirPath.Visible = False
            Label38.Visible = False
        End If
        selectedDirPath.Text = GetStateMyIni("LocaleDirPath=")
        selectedDatPath.Text = GetStateMyIni("LocaleDatPath=")
        commandAutoCheck.Checked = GetStateMyIni("CommandAutoReplace=")
        If commandAutoCheck.Checked Then
            commandTextBox.Visible = True
        Else
            commandTextBox.Visible = False
        End If
        If File.Exists(commandPath) Then
            commandTextBox.Lines = File.ReadAllLines(commandPath)
        End If
#End Region
#Region "HudIndGets"
#Region "Infantry"
        iconsInfantryAllyCheck.Checked = GetStateContains("HiddenHUDIndicators=", 84)
        iconsInfantryEnemyCheck.Checked = GetStateContains("HiddenHUDIndicators=", 85)
        If iconsInfantryAllyCheck.Checked And iconsInfantryEnemyCheck.Checked Then
            iconsInfantryGroupCheck.Checked = True
        Else
            iconsInfantryGroupCheck.Checked = False
        End If

#End Region
#Region "Vehicle"
        iconsVehAllyCheck.Checked = GetStateContains("HiddenHUDIndicators=", 86)
        iconsVehEnemyCheck.Checked = GetStateContains("HiddenHUDIndicators=", 87)
        iconsVehBastionCheck.Checked = GetStateContains("HiddenHUDIndicators=", 62)
        If iconsVehAllyCheck.Checked And
                iconsVehEnemyCheck.Checked And
                iconsVehBastionCheck.Checked Then
            iconsVehicleGroupCheck.Checked = True
        Else
            iconsVehicleGroupCheck.Checked = False
        End If
#End Region
#Region "Deployables"
        iconsDepDMGNadeCheck.Checked = GetStateContains("HiddenHUDIndicators=", 3)
        iconsDepStatusNadeCheck.Checked = GetStateContains("HiddenHUDIndicators=", 82)
        iconsDepMinesCheck.Checked = GetStateContains("HiddenHUDIndicators=", 34)
        iconsDepC4Check.Checked = GetStateContains("HiddenHUDIndicators=", 10)
        iconsDepShieldRegenCheck.Checked = GetStateContains("HiddenHUDIndicators=", 38)
        iconsDepDildarCheck.Checked = GetStateContains("HiddenHUDIndicators=", 39)
        iconsDepAmmoBoxCheck.Checked = GetStateContains("HiddenHUDIndicators=", 33)
        iconsDepDroneCheck.Checked = GetStateContains("HiddenHUDIndicators=", 65)
        iconsDepTurretsCheck.Checked = GetStateContains("HiddenHUDIndicators=", 88)
        If iconsDepDMGNadeCheck.Checked And
                iconsDepStatusNadeCheck.Checked And
                iconsDepMinesCheck.Checked And
                iconsDepC4Check.Checked And
                iconsDepShieldRegenCheck.Checked And
                iconsDepDildarCheck.Checked And
                iconsDepAmmoBoxCheck.Checked And
                iconsDepDroneCheck.Checked And
                iconsDepTurretsCheck.Checked Then
            iconsDeployGroupCheck.Checked = True
        Else
            iconsDeployGroupCheck.Checked = False
        End If
#End Region
#Region "World"
        iconsWorldAnomalyCheck.Checked = GetStateContains("HiddenHUDIndicators=", 49)
        iconsWorldDrillCheck.Checked = GetStateContains("HiddenHUDIndicators=", 53)
        iconsWorldBuoyCheck.Checked = GetStateContains("HiddenHUDIndicators=", 58)
        iconsWorldMissionCheck.Checked = GetStateContains("HiddenHUDIndicators=", 68)
        iconsWorldImplantCheck.Checked = GetStateContains("HiddenHUDIndicators=", 67)
        iconsWorldPlantCheck.Checked = GetStateContains("HiddenHUDIndicators=", 71)
        iconsWorldNPCCheck.Checked = GetStateContains("HiddenHUDIndicators=", 79)
        iconsWorldStationCheck.Checked = GetStateContains("HiddenHUDIndicators=", 44)
        iconsWorldAssetCheck.Checked = GetStateContains("HiddenHUDIndicators=", 63)
        iconsWorldCrystalCheck.Checked = GetStateContains("HiddenHUDIndicators=", 43)
        iconsWorldConstructionCheck.Checked = GetStateContains("HiddenHUDIndicators=", 117)
        iconsWorldCortiumCheck.Checked = GetStateContains("HiddenHUDIndicators=", 116)
        If iconsWorldAnomalyCheck.Checked And
                iconsWorldDrillCheck.Checked And
                iconsWorldBuoyCheck.Checked And
                iconsWorldMissionCheck.Checked And
                iconsWorldImplantCheck.Checked And
                iconsWorldPlantCheck.Checked And
                iconsWorldNPCCheck.Checked And
                iconsWorldStationCheck.Checked And
                iconsWorldAssetCheck.Checked And
                iconsWorldCrystalCheck.Checked And
                iconsWorldConstructionCheck.Checked And
                iconsWorldCortiumCheck.Checked Then
            iconsWorldGroupCheck.Checked = True
        Else
            iconsWorldGroupCheck.Checked = False
        End If
#End Region
#Region "Facility"
        iconsFacVehAmmoCheck.Checked = GetStateContains("HiddenHUDIndicators=", 11)
        iconsFacAirAmmoCheck.Checked = GetStateContains("HiddenHUDIndicators=", 18)
        iconsFacEquipTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 7)
        iconsFacWGTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 26)
        iconsFacAirTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 4)
        iconsFacVehTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 5)
        iconsFacGalTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 6)
        iconsFacFlashTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 15)
        iconsFacLightTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 20)
        iconsFacBusTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 115)
        iconsFacTeleCheck.Checked = GetStateContains("HiddenHUDIndicators=", 13)
        iconsFacPointCheck.Checked = GetStateContains("HiddenHUDIndicators=", 2)
        iconsFacOWPointsCheck.Checked = GetStateContains("HiddenHUDIndicators=", 61)
        iconsFacNearbyCheck.Checked = GetStateContains("HiddenHUDIndicators=", 83)
        iconsFacSCUCheck.Checked = GetStateContains("HiddenHUDIndicators=", 17)
        iconsFacHorzCheck.Checked = GetStateContains("HiddenHUDIndicators=", 22)
        iconsFacVertCheck.Checked = GetStateContains("HiddenHUDIndicators=", 23)
        iconsFacVehShieldCheck.Checked = GetStateContains("HiddenHUDIndicators=", 24)
        iconsFacSCUShieldCheck.Checked = GetStateContains("HiddenHUDIndicators=", 25)
        iconsFacForwardCheck.Checked = GetStateContains("HiddenHUDIndicators=", 27)
        iconsFacBridgeTermCheck.Checked = GetStateContains("HiddenHUDIndicators=", 35)
        iconsFacSCUAttackCheck.Checked = GetStateContains("HiddenHUDIndicators=", 75)
        iconsFacGateAttackCheck.Checked = GetStateContains("HiddenHUDIndicators=", 76)
        iconsFacRelicDoorCheck.Checked = GetStateContains("HiddenHUDIndicators=", 77)
        If iconsFacilityGroupCheck.Checked And
                iconsFacVehAmmoCheck.Checked And
                iconsFacAirAmmoCheck.Checked And
                iconsFacEquipTermCheck.Checked And
                iconsFacWGTermCheck.Checked And
                iconsFacAirTermCheck.Checked And
                iconsFacVehTermCheck.Checked And
                iconsFacGalTermCheck.Checked And
                iconsFacFlashTermCheck.Checked And
                iconsFacLightTermCheck.Checked And
                iconsFacBusTermCheck.Checked And
                iconsFacTeleCheck.Checked And
                iconsFacPointCheck.Checked And
                iconsFacOWPointsCheck.Checked And
                iconsFacNearbyCheck.Checked And
                iconsFacSCUCheck.Checked And
                iconsFacHorzCheck.Checked And
                iconsFacVertCheck.Checked And
                iconsFacVehShieldCheck.Checked And
                iconsFacSCUShieldCheck.Checked And
                iconsFacForwardCheck.Checked And
                iconsFacBridgeTermCheck.Checked And
                iconsFacSCUAttackCheck.Checked And
                iconsFacGateAttackCheck.Checked And
                iconsFacRelicDoorCheck.Checked Then
            iconsFacilityGroupCheck.Checked = True
        Else
            iconsFacilityGroupCheck.Checked = False
        End If
#End Region
#Region "Title"
        iconsTitleAllyCheck.Checked = GetStateContains("HiddenNamePlateOptions", 1)
        iconsTitleEnemyCheck.Checked = GetStateContains("HiddenNamePlateOptions", 2)
        If iconsTitleAllyCheck.Checked And
                iconsTitleEnemyCheck.Checked Then
            iconsTitlesGroupCheck.Checked = True
        Else
            iconsTitlesGroupCheck.Checked = False
        End If
#End Region
#Region "Names"
        iconsNameSquadCheck.Checked = GetStateContains("HiddenNamePlateOptions", 3)
        iconsNamePlatoonCheck.Checked = GetStateContains("HiddenNamePlateOptions", 4)
        iconsNameFireCheck.Checked = GetStateContains("HiddenNamePlateOptions", 5)
        iconsNameOutfitCheck.Checked = GetStateContains("HiddenNamePlateOptions", 6)
        iconsNameEnemyCheck.Checked = GetStateContains("HiddenNamePlateOptions", 7)
        If iconsNameSquadCheck.Checked And
                iconsNamePlatoonCheck.Checked And
                iconsNameFireCheck.Checked And
                iconsNameOutfitCheck.Checked And
                iconsNameEnemyCheck.Checked Then
            iconsNamesGroupCheck.Checked = True
        Else
            iconsNamesGroupCheck.Checked = False
        End If
#End Region
#Region "Dorito"
        iconsDoritoAllyCheck.Checked = GetStateContains("HiddenNamePlateOptions", 8)
        iconsDoritoEnemyCheck.Checked = GetStateContains("HiddenNamePlateOptions", 9)
        If iconsDoritoAllyCheck.Checked And
                iconsDoritoEnemyCheck.Checked Then
            iconsDoritoGroupCheck.Checked = True
        Else
            iconsDoritoGroupCheck.Checked = False
        End If
#End Region
#Region "Misc"
        iconsSocialCheck.Checked = GetStateContains("HiddenNamePlateOptions", 10)
        If iconsSocialCheck.Checked Then
            iconsMiscGroupCheck.Checked = True
        Else
            iconsMiscGroupCheck.Checked = False
        End If
#End Region
#End Region
    End Function
#Region "Controls"
#Region "MenuStripControls"
    Private Sub startLauncher_Click(sender As Object, e As EventArgs) Handles startLauncher.Click
        Process.Start("LaunchPad.exe")
        Console.WriteLine("Starting Launcher")
        File.WriteAllLines(curiniPath, curini)
        Console.WriteLine("Saved PS2INI to ", curiniPath)
        File.WriteAllLines(iniPath, iniini)
        Console.WriteLine("Saved INIINI to ", iniPath)
    End Sub
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        'Save current options to regular Useroptions.ini
        File.WriteAllLines(curiniPath, curini)
        Console.WriteLine("Saved PS2INI to ", curiniPath)
        File.WriteAllLines(iniPath, iniini)
        Console.WriteLine("Saved INIINI to ", iniPath)
    End Sub
    Private Sub saveToButton_Click(sender As Object, e As EventArgs) Handles saveToButton.Click
        'Save current options to user-specified file
        Dim saveDialog As New SaveFileDialog()
        saveDialog.DefaultExt = "ini"
        saveDialog.AddExtension = True
        If Not Directory.Exists(String.Concat(CurDir, "\iniConfigs")) Then
            Directory.CreateDirectory(String.Concat(CurDir, "\iniConfigs"))
        End If
        saveDialog.InitialDirectory = String.Concat(CurDir, "\iniConfigs")
        Console.WriteLine(String.Concat(CurDir, "\iniConfigs"))
        saveDialog.Filter = "All files (*.*)|*.*"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            File.WriteAllLines(saveDialog.FileName, curini)
            Console.WriteLine("Saved INI to ", saveDialog.FileName)
        End If
    End Sub
    Private Sub openButton_Click(sender As Object, e As EventArgs) Handles openButton.Click
        'Open specified ini file
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "Config Files (*.ini)|*.ini"
        openDialog.RestoreDirectory = True
        If openDialog.ShowDialog() = DialogResult.OK Then
            'Re-run stuff that ran on load for new ini
            curini = File.ReadAllLines(openDialog.FileName).ToList
            If Not curini.Contains("[iniEdit]") Then
                curini.Insert(0, "[iniEdit]")
            End If
            readAllOptions()
            sensTypeDrop.SelectedIndex = 0
            'This gets the full file path and grabs the file name from the end to update the currently editing label
            curiniPath = openDialog.FileName
            curEditLabel.Text = String.Concat("Currently Editing: ", curiniPath.Split("\"c).ToList.Last)
        End If
    End Sub
#End Region
#Region "GraphicsControls"
#Region "ChecksChanged"
    Private Sub vsyncCheck_CheckedChanged(sender As Object, e As EventArgs) Handles vsyncCheck.Click
        If vsyncCheck.Checked Then
            UpdateVal("VSync=", 1)
        Else
            UpdateVal("VSync=", 0)
        End If
    End Sub
    Private Sub fogShadCheck_CheckedChanged(sender As Object, e As EventArgs) Handles fogShadCheck.Click
        If fogShadCheck.Checked Then
            UpdateVal("FogShadowsEnable=", 1)
        Else
            UpdateVal("FogShadowsEnable=", 0)
        End If
    End Sub
    Private Sub ambOccCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ambOccCheck.Click
        If ambOccCheck.Checked Then
            UpdateVal("AO=", 1)
        Else
            UpdateVal("AO=", 0)
        End If
    End Sub
    Private Sub bloomCheck_CheckedChanged(sender As Object, e As EventArgs) Handles bloomCheck.Click
        If bloomCheck.Checked Then
            UpdateVal("BloomEnabled=", 1)
        Else
            UpdateVal("BloomEnabled=", 0)
        End If
    End Sub
    Private Sub blurCheck_CheckedChanged(sender As Object, e As EventArgs) Handles blurCheck.Click
        If blurCheck.Checked Then
            UpdateVal("MotionBlur=", 1)
        Else
            UpdateVal("MotionBlur=", 0)
        End If
    End Sub
    Private Sub smoothCheck_CheckedChanged(sender As Object, e As EventArgs) Handles smoothCheck.Click
        If smoothCheck.Checked Then
            UpdateVal("Smoothing=", 1)
        Else
            UpdateVal("Smoothing=", 0)
        End If
    End Sub
    Private Sub wideCheck_CheckedChanged(sender As Object, e As EventArgs) Handles wideCheck.Click
        If wideCheck.Checked Then
            UpdateVal("UseAspectFOV=", 1)
        Else
            UpdateVal("UseAspectFOV=", 0)
        End If
    End Sub
    Private Sub useGlobRenCheck_CheckedChanged(sender As Object, e As EventArgs) Handles useGlobRenCheck.Click
        If useGlobRenCheck.Checked Then
            UpdateVal("UseGlobalRenderDistance=", 1)
        Else
            UpdateVal("UseGlobalRenderDistance=", 0)
        End If
    End Sub
    Private Sub sensRawCheck_CheckedChanged(sender As Object, e As EventArgs) Handles sensRawCheck.Click
        If sensRawCheck.Checked Then
            UpdateVal("MouseRawInput=", 1)
        Else
            UpdateVal("MouseRawInput=", 0)
        End If
    End Sub
#End Region
#Region "TextChanged"
    Private Sub globRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles globRenDistBox.TextChanged
        UpdateVal("RenderDistance=", globRenDistBox.Value)
    End Sub
    Private Sub infRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles infRenDistBox.TextChanged
        UpdateVal("InfantryRenderDistance=", infRenDistBox.Value)
    End Sub
    Private Sub vehRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles vehRenDistbox.TextChanged
        UpdateVal("GroundVehicleRenderDistance=", vehRenDistbox.Value)
    End Sub
    Private Sub airRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles airRenDistBox.TextChanged
        UpdateVal("AirVehicleRenderDistance=", airRenDistBox.Value)
    End Sub
    Private Sub fovBox_TextChanged(sender As Object, e As EventArgs) Handles fovBox.TextChanged
        UpdateVal("VerticalFOV=", fovBox.Value)
    End Sub
    Private Sub renQualBox_TextChanged(sender As Object, e As EventArgs) Handles renQualBox.TextChanged
        UpdateVal("RenderQuality=", renQualBox.Value)
    End Sub
    Private Sub maxFPSBox_TextChanged(sender As Object, e As EventArgs) Handles maxFPSBox.TextChanged
        UpdateVal("MaximumFPS=", maxFPSBox.Value)
    End Sub
    Private Sub gammaBox_TextChanged(sender As Object, e As EventArgs) Handles gammaBox.TextChanged
        UpdateVal("Gamma=", gammaBox.Value)
    End Sub
    Private Sub partDistScaleBox_TextChanged(sender As Object, e As EventArgs) Handles partDistScaleBox.TextChanged
        UpdateVal("ParticleDistanceScale=", partDistScaleBox.Value)
    End Sub
    Private Sub DLSSSharpBox_ValueChanged(sender As Object, e As EventArgs) Handles DLSSSharpBox.TextChanged
        UpdateVal("DLSSSharpness=", DLSSSharpBox.Value)
    End Sub
    Private Sub FSRSharpBox_ValueChanged(sender As Object, e As EventArgs) Handles FSRSharpBox.TextChanged
        UpdateVal("FSRSharpness=", FSRSharpBox.Value)
    End Sub
#End Region
#Region "IndexChanged"
    Private Sub graphQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles graphQualDrop.SelectedValueChanged
        UpdateVal("GraphicsQuality=", graphQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub texQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles texQualDrop.SelectedValueChanged
        UpdateVal("TextureQuality=", texQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub shadQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shadQualDrop.SelectedValueChanged
        UpdateVal("ShadowQuality=", shadQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub lightQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lightQualDrop.SelectedValueChanged
        UpdateVal("LightingQuality=", lightQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub effQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles effQualDrop.SelectedValueChanged
        UpdateVal("EffectsQuality=", effQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub terrQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles terrQualDrop.SelectedValueChanged
        UpdateVal("TerrainQuality=", terrQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub floraQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles floraQualDrop.SelectedValueChanged
        'Flora apparently has 2 lines in separate sections
        UpdateVal("FloraQuality=", floraQualDrop.SelectedItem.ToString.First)
        If floraQualDrop.SelectedIndex() = 3 Then
            UpdateVal("RenderFlora=", "off")
        Else
            UpdateVal("RenderFlora=", "on")
        End If
    End Sub
    Private Sub modQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modQualDrop.SelectedValueChanged
        UpdateVal("ModelQuality=", modQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub partQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles partQualDrop.SelectedValueChanged
        UpdateVal("ParticleLOD=", partQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub AADrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles AADrop.SelectedValueChanged
        If AADrop.SelectedIndex = 0 Then
            UpdateVal("AAQuality=", -1)
        Else
            UpdateVal("AAQuality=", AADrop.SelectedIndex - 1)
        End If
    End Sub
    Private Sub waterReflectDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles waterReflectDrop.SelectedValueChanged
        UpdateVal("WaterQuality=", waterReflectDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub objReflectDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles objReflectDrop.SelectedValueChanged
        UpdateVal("SSLRQuality=", objReflectDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub upscaleDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles upscaleDrop.SelectedValueChanged
        If upscaleDrop.SelectedIndex = 0 Then
            UpdateVal("DLSSQuality=", -1)
            UpdateVal("FSRQuality=", -1)
            Label66.Visible = False
            Label76.Visible = False
            DLSSQualDrop.Visible = False
            FSRQualDrop.Visible = False
            DLSSSharpBox.Visible = False
            FSRSharpBox.Visible = False
        ElseIf upscaleDrop.SelectedIndex = 1 Then
            UpdateVal("DLSSQuality=", 0)
            UpdateVal("FSRQuality=", -1)
            Label66.Visible = True
            Label76.Visible = True
            DLSSQualDrop.Visible = True
            FSRQualDrop.Visible = False
            DLSSSharpBox.Visible = True
            FSRSharpBox.Visible = False
        ElseIf upscaleDrop.SelectedIndex = 2 Then
            UpdateVal("DLSSQuality=", -1)
            UpdateVal("FSRQuality=", 0)
            Label66.Visible = True
            Label76.Visible = True
            DLSSQualDrop.Visible = False
            FSRQualDrop.Visible = True
            DLSSSharpBox.Visible = False
            FSRSharpBox.Visible = True
        End If
    End Sub
    Private Sub DLSSQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles DLSSQualDrop.SelectedValueChanged
        UpdateVal("DLSSQuality=", DLSSQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub FSRQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles FSRQualDrop.SelectedValueChanged
        UpdateVal("FSRQuality=", FSRQualDrop.SelectedItem.ToString.First)
    End Sub
#End Region
#End Region
#Region "SensStuff"
    Private Sub hipSensBox_TextChanged(sender As Object, e As EventArgs) Handles hipSensBox.TextChanged
        UpdateVal("MouseSensitivity=", hipSensBox.Value)
        LabelHipcm360.Text() = String.Concat(hipTurnCalc(DPIBox.Value, hipSensBox.Value), "cm")
    End Sub
    Private Sub adsSensBox_TextChanged(sender As Object, e As EventArgs) Handles adsSensBox.TextChanged
        UpdateVal("ADSMouseSensitivity=", adsSensBox.Value)
        Label1cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 1.35), "cm")
        Label2cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 2), "cm")
    End Sub
    Private Sub scopSensBox_TextChanged(sender As Object, e As EventArgs) Handles scopSensBox.TextChanged
        UpdateVal("ScopedMouseSensitivity=", scopSensBox.Value)
        Label3cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 3.4), "cm")
        Label4cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 4), "cm")
        Label6cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 6), "cm")
        Label8cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 8), "cm")
        Label10cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 10), "cm")
        Label12cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 12), "cm")
    End Sub
    Private Sub vehSensBox_TextChanged(sender As Object, e As EventArgs) Handles vehSensBox.TextChanged
        UpdateVal("VehicleMouseSensitivity=", vehSensBox.Value)
    End Sub
    Private Sub gunSensBox_TextChanged(sender As Object, e As EventArgs) Handles gunSensBox.TextChanged
        UpdateVal("VehicleGunnerMouseSensitivity=", gunSensBox.Value)
    End Sub
    Private Sub airSensBox_TextChanged(sender As Object, e As EventArgs) Handles airSensBox.TextChanged
        UpdateVal("FlightMouseSensitivity=", airSensBox.Value)
    End Sub
    Private Sub sensTypeDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sensTypeDrop.SelectedValueChanged
        'Switch what's visible on sens page
        If sensTypeDrop.SelectedIndex = 0 Then
            sensPanel1.Visible = True
            sensPanel2.Visible = True
            sensPanel3.Visible = False
            sensPanel4.Visible = False
        Else
            sensPanel3.Visible = True
            sensPanel4.Visible = True
            sensPanel1.Visible = False
            sensPanel2.Visible = False
        End If
    End Sub
    Private Sub hip360Box_ValueChanged(sender As Object, e As EventArgs) Handles hip360Box.ValueChanged
        Dim Sens As String = hipSensCalc(DPIBox.Value, hip360Box.Value)
        UpdateVal("MouseSensitivity=", Sens)
        LabelHipSens.Text() = Sens
    End Sub
    Private Sub ads360Box_ValueChanged(sender As Object, e As EventArgs) Handles ads360Box.ValueChanged, adsZoomBox.SelectedValueChanged
        If IsNothing(adsZoomBox.SelectedItem) Then
            Exit Sub
        ElseIf adsZoomBox.SelectedIndex = 0 Then
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, 1.35)
            UpdateVal("ADSMouseSensitivity=", Sens)
            LabelAdsSens.Text() = Sens
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, adsZoomBox.SelectedItem.ToString.Trim("x"c))
            UpdateVal("ADSMouseSensitivity=", Sens)
            LabelAdsSens.Text() = Sens
        End If
    End Sub
    Private Sub scop360Box_ValueChanged(sender As Object, e As EventArgs) Handles scop360Box.ValueChanged, scopZoomBox.SelectedValueChanged
        If IsNothing(scopZoomBox.SelectedItem) Then
            Exit Sub
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, scop360Box.Value, scopZoomBox.SelectedItem.ToString.Trim("x"c))
            UpdateVal("ScopedMouseSensitivity=", Sens)
            LabelScopSens.Text() = Sens
        End If
    End Sub
    Private Sub DPIBox_ValueChanged(sender As Object, e As EventArgs) Handles DPIBox.ValueChanged
        LabelHipcm360.Text() = String.Concat(hipTurnCalc(DPIBox.Value, hipSensBox.Value), "cm")
        Label1cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 1.35), "cm")
        Label2cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 2), "cm")
        Label3cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 3.4), "cm")
        Label4cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 4), "cm")
        Label6cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 6), "cm")
        Label8cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 8), "cm")
        Label10cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 10), "cm")
        Label12cm360.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 12), "cm")
        LabelHipSens.Text() = hipSensCalc(DPIBox.Value, hip360Box.Value)
        If IsNothing(adsZoomBox.SelectedItem) Then
        ElseIf adsZoomBox.SelectedIndex = 0 Then
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, 1.35)
            LabelAdsSens.Text() = Sens
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, adsZoomBox.SelectedItem.ToString.Trim("x"c))
            LabelAdsSens.Text() = Sens
        End If
        If Not IsNothing(scopZoomBox.SelectedItem) Then
            Dim Sens As String = aimSensCalc(DPIBox.Value, scop360Box.Value, scopZoomBox.SelectedItem.ToString.Trim("x"c))
            LabelScopSens.Text() = Sens
        End If
        UpdateValMyIni("DPI=", DPIBox.Value)
    End Sub
#End Region
#Region "InterfaceControls"
#Region "CheckedChanged"
    Private Sub hudHPCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudHPCheck.Click
        If hudHPCheck.Checked Then
            UpdateVal("HudShowHealth=", 1)
        Else
            UpdateVal("HudShowHealth=", 0)
        End If
    End Sub
    Private Sub hudIndCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudIndCheck.Click
        If hudIndCheck.Checked Then
            UpdateVal("HudShowIndicatorNames=", 1)
        Else
            UpdateVal("HudShowIndicatorNames=", 0)
        End If
    End Sub
    Private Sub hudAlertCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudAlertCheck.Click
        If hudAlertCheck.Checked Then
            UpdateVal("HudShowAlertTimer=", 1)
        Else
            UpdateVal("HudShowAlertTimer=", 0)
        End If
    End Sub
    Private Sub hudSpamCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudSpamCheck.Click
        If hudSpamCheck.Checked Then
            UpdateVal("DrawKillSpam=", 1)
        Else
            UpdateVal("DrawKillSpam=", 0)
        End If
    End Sub
    Private Sub hudLootCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudLootCheck.Click
        If hudLootCheck.Checked Then
            UpdateVal("DrawLootDrop=", 1)
        Else
            UpdateVal("DrawLootDrop=", 0)
        End If
    End Sub
    Private Sub hudCompCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudCompCheck.Click
        If hudCompCheck.Checked Then
            UpdateVal("HudShowTopCompass=", 1)
        Else
            UpdateVal("HudShowTopCompass=", 0)
        End If
    End Sub
    Private Sub hudDotCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudDotCheck.Click
        If hudDotCheck.Checked Then
            UpdateVal("HudShow3PVehicleReticle=", 1)
        Else
            UpdateVal("HudShow3PVehicleReticle=", 0)
        End If
    End Sub
    Private Sub custRetCheck_CheckedChanged(sender As Object, e As EventArgs) Handles custRetCheck.Click
        If custRetCheck.Checked Then
            UpdateVal("TintModeReticuleStyle=", 1)
        Else
            UpdateVal("TintModeReticuleStyle=", 0)
        End If
    End Sub
#End Region
#Region "Buttons"
    Private Sub retColorButton_Click(sender As Object, e As EventArgs) Handles retColorButton.Click
        Dim chosenColor As Color = colorGetter()
        retColorButton.BackColor = chosenColor
        UpdateVal("TintModeReticuleColor=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub alphaColorButton_Click(sender As Object, e As EventArgs) Handles alphaColorButton.Click
        Dim chosenColor As Color = colorGetter()
        alphaColorButton.BackColor = chosenColor
        UpdateVal("PlatoonSquadColor0=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub bravoColorButton_Click(sender As Object, e As EventArgs) Handles bravoColorButton.Click
        Dim chosenColor As Color = colorGetter()
        bravoColorButton.BackColor = chosenColor
        UpdateVal("PlatoonSquadColor1=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub charlieColorButton_Click(sender As Object, e As EventArgs) Handles charlieColorButton.Click
        Dim chosenColor As Color = colorGetter()
        charlieColorButton.BackColor = chosenColor
        UpdateVal("PlatoonSquadColor2=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub deltaColorButton_Click(sender As Object, e As EventArgs) Handles deltaColorButton.Click
        Dim chosenColor As Color = colorGetter()
        deltaColorButton.BackColor = chosenColor
        UpdateVal("PlatoonSquadColor3=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub NDZColorButton_Click(sender As Object, e As EventArgs) Handles NDZColorButton.Click
        Dim chosenColor As Color = colorGetter()
        NDZColorButton.BackColor = chosenColor
        UpdateVal("NoDeployZoneColor=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
        UpdateVal("TintModeNoDeploy=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub OSColorButton_Click(sender As Object, e As EventArgs) Handles OSColorButton.Click
        Dim chosenColor As Color = colorGetter()
        OSColorButton.BackColor = chosenColor
        UpdateVal("OrbitalStrikeColor=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub VSplayerColorButton_Click(sender As Object, e As EventArgs) Handles VSplayerColorButton.Click
        Dim chosenColor As Color = colorGetter()
        VSplayerColorButton.BackColor = chosenColor
        ColorUpdate("TintModePlayer=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 1)
    End Sub
    Private Sub NCplayerColorButton_Click(sender As Object, e As EventArgs) Handles NCplayerColorButton.Click
        Dim chosenColor As Color = colorGetter()
        NCplayerColorButton.BackColor = chosenColor
        ColorUpdate("TintModePlayer=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 2)
    End Sub
    Private Sub TRplayerColorButton_Click(sender As Object, e As EventArgs) Handles TRplayerColorButton.Click
        Dim chosenColor As Color = colorGetter()
        TRplayerColorButton.BackColor = chosenColor
        ColorUpdate("TintModePlayer=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 3)
    End Sub
    Private Sub VSfacColorButton_Click(sender As Object, e As EventArgs) Handles VSfacColorButton.Click
        Dim chosenColor As Color = colorGetter()
        VSfacColorButton.BackColor = chosenColor
        ColorUpdate("TintModeFacility=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 1)
    End Sub
    Private Sub NCfacColorButton_Click(sender As Object, e As EventArgs) Handles NCfacColorButton.Click
        Dim chosenColor As Color = colorGetter()
        NCfacColorButton.BackColor = chosenColor
        ColorUpdate("TintModeFacility=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 2)
    End Sub
    Private Sub TRfacColorButton_Click(sender As Object, e As EventArgs) Handles TRfacColorButton.Click
        Dim chosenColor As Color = colorGetter()
        TRfacColorButton.BackColor = chosenColor
        ColorUpdate("TintModeFacility=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 3)
    End Sub
    Private Sub VSterrColorButton_Click(sender As Object, e As EventArgs) Handles VSterrColorButton.Click
        Dim chosenColor As Color = colorGetter()
        VSterrColorButton.BackColor = chosenColor
        ColorUpdate("TintModeMap=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 1)
    End Sub
    Private Sub NCterrColorButton_Click(sender As Object, e As EventArgs) Handles NCterrColorButton.Click
        Dim chosenColor As Color = colorGetter()
        NCterrColorButton.BackColor = chosenColor
        ColorUpdate("TintModeMap=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 2)
    End Sub
    Private Sub TRterrColorButton_Click(sender As Object, e As EventArgs) Handles TRterrColorButton.Click
        Dim chosenColor As Color = colorGetter()
        TRterrColorButton.BackColor = chosenColor
        ColorUpdate("TintModeMap=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)), 3)
    End Sub
#End Region
#Region "IndexChanged"
    Private Sub playerColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerColorDrop.SelectedIndexChanged
        If playerColorDrop.SelectedIndex = 0 Then
            UpdateVal("TintModePlayer=", 0)
            playerColorPanelButtons.Visible = False
        ElseIf playerColorDrop.SelectedIndex = 1 Then
            UpdateVal("TintModePlayer=", 1)
            playerColorPanelButtons.Visible = False
        ElseIf playerColorDrop.SelectedIndex = 2 Then
            playerColorPanelButtons.Visible = True
            If GetState("TintModePlayer=").ToString.Length < 3 Then
                UpdateVal("TintModePlayer=", "4460130,19328,10357519")
            End If
            VSplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 1)))
            NCplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 2)))
            TRplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 3)))
        End If
    End Sub
    Private Sub facColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles facColorDrop.SelectedIndexChanged
        If facColorDrop.SelectedIndex = 0 Then
            UpdateVal("TintModeFacility=", 0)
            facColorPanelButtons.Visible = False
        ElseIf facColorDrop.SelectedIndex = 1 Then
            UpdateVal("TintModeFacility=", 1)
            facColorPanelButtons.Visible = False
        ElseIf facColorDrop.SelectedIndex = 2 Then
            facColorPanelButtons.Visible = True
            If GetState("TintModeFacility=").ToString.Length < 3 Then
                UpdateVal("TintModeFacility=", "4460130,19328,10357519")
            End If
            VSfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 1)))
            NCfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 2)))
            TRfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 3)))
        End If
    End Sub
    Private Sub terrColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles terrColorDrop.SelectedIndexChanged
        If terrColorDrop.SelectedIndex = 0 Then
            UpdateVal("TintModeMap=", 0)
            terrColorPanelButtons.Visible = False
        ElseIf terrColorDrop.SelectedIndex = 1 Then
            UpdateVal("TintModeMap=", 1)
            terrColorPanelButtons.Visible = False
        ElseIf terrColorDrop.SelectedIndex = 2 Then
            terrColorPanelButtons.Visible = True
            If GetState("TintModeMap=").ToString.Length < 3 Then
                UpdateVal("TintModeMap=", "4460130,19328,10357519")
            End If
            VSterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 1)))
            NCterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 2)))
            TRterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 3)))
        End If
    End Sub
#End Region
    Private Sub OSAlphaBox_ValueChanged(sender As Object, e As EventArgs) Handles OSAlphaBox.TextChanged
        UpdateVal("OrbitalStrikeAlpha=", OSAlphaBox.Value)
    End Sub
#End Region
#Region "SoundControls"
#Region "TextChanged"
    Private Sub masVolBox_TextChanged(sender As Object, e As EventArgs) Handles masVolBox.TextChanged
        UpdateVal("Master=", masVolBox.Value)
    End Sub
    Private Sub gamVolBox_TextChanged(sender As Object, e As EventArgs) Handles gamVolBox.TextChanged
        UpdateVal("Game=", gamVolBox.Value)
    End Sub
    Private Sub musVolBox_TextChanged(sender As Object, e As EventArgs) Handles musVolBox.TextChanged
        UpdateVal("Music=", musVolBox.Value)
    End Sub
    Private Sub diaVolBox_TextChanged(sender As Object, e As EventArgs) Handles diaVolBox.TextChanged
        UpdateVal("Dialog=", diaVolBox.Value)
    End Sub
    Private Sub maxVoiceBox_TextChanged(sender As Object, e As EventArgs) Handles maxVoiceBox.TextChanged
        UpdateVal("MaxVoices=", maxVoiceBox.Value)
    End Sub
#End Region
#Region "ChecksChanged"
    Private Sub hitIndCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hitIndCheck.Click
        If hitIndCheck.Checked Then
            UpdateVal("HitIndicator=", 1)
        Else
            UpdateVal("HitIndicator=", 0)
        End If
    End Sub
    Private Sub lowAmmCheck_CheckedChanged(sender As Object, e As EventArgs) Handles lowAmmCheck.Click
        If lowAmmCheck.Checked Then
            UpdateVal("LowAmmoIndicator=", 1)
        Else
            UpdateVal("LowAmmoIndicator=", 0)
        End If
    End Sub
    Private Sub vehChatterCheck_CheckedChanged(sender As Object, e As EventArgs) Handles vehChatterCheck.Click
        If vehChatterCheck.Checked Then
            UpdateVal("VehicleChatter=", 1)
        Else
            UpdateVal("VehicleChatter=", 0)
        End If
    End Sub
    Private Sub idleMusicCheck_CheckedChanged(sender As Object, e As EventArgs) Handles idleMusicCheck.Click
        If idleMusicCheck.Checked Then
            UpdateVal("IdleMusic=", 1)
        Else
            UpdateVal("IdleMusic=", 0)
        End If
    End Sub

#End Region
#End Region
#Region "ChatControls"
#Region "TextChanged"
    Private Sub genVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles genVoiceVolBox.TextChanged
        UpdateVal("ReceiveVolume=", genVoiceVolBox.Value)
    End Sub
    Private Sub proxVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles proxVoiceVolBox.TextChanged
        UpdateVal("ProximityVolume=", proxVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub squadVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles squadVoiceVolBox.TextChanged
        UpdateVal("GroupVolume=", squadVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub raidVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles raidVoiceVolBox.TextChanged
        UpdateVal("RaidVolume=", raidVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub outfitVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles outfitVoiceVolBox.TextChanged
        UpdateVal("GuildVolume=", outfitVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub leaderVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles leaderVoiceVolBox.TextChanged
        UpdateVal("GroupLeaderVolume=", leaderVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub transmitVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles transmitVoiceVolBox.TextChanged
        UpdateVal("MicrophoneVolume=", transmitVoiceVolBox.Value)
    End Sub
    Private Sub duckVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles duckVoiceVolBox.TextChanged
        UpdateVal("Ducking=", duckVoiceVolBox.Value)
    End Sub
#End Region
#Region "ChecksChanged"
    Private Sub yellTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles yellTextCheck.Click
        If yellTextCheck.Checked Then
            UpdateVal("Yell=", 1)
        Else
            UpdateVal("Yell=", 0)
        End If
    End Sub

    Private Sub fireteamTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles fireteamTextCheck.Click
        If fireteamTextCheck.Checked Then
            UpdateVal("Fireteam=", 1)
        Else
            UpdateVal("Fireteam=", 0)
        End If
    End Sub
    Private Sub squadTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles squadTextCheck.Click
        If squadTextCheck.Checked Then
            UpdateVal("Squad=", 1)
        Else
            UpdateVal("Squad=", 0)
        End If
    End Sub
    Private Sub raidTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles raidTextCheck.Click
        If raidTextCheck.Checked Then
            UpdateVal("Platoon=", 1)
        Else
            UpdateVal("Platoon=", 0)
        End If
    End Sub
    Private Sub outfitTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles outfitTextCheck.Click
        If outfitTextCheck.Checked Then
            UpdateVal("Outfit=", 1)
        Else
            UpdateVal("Outfit=", 0)
        End If
    End Sub
    Private Sub leaderTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles leaderTextCheck.Click
        If leaderTextCheck.Checked Then
            UpdateVal("Leader=", 1)
        Else
            UpdateVal("Leader=", 0)
        End If
    End Sub
    Private Sub proxTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles proxTextCheck.Click
        If proxTextCheck.Checked Then
            UpdateVal("Proximity=", 1)
        Else
            UpdateVal("Proximity=", 0)
        End If
    End Sub
    Private Sub regionTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles regionTextCheck.Click
        If regionTextCheck.Checked Then
            UpdateVal("Region=", 1)
        Else
            UpdateVal("Region=", 0)
        End If
    End Sub
    Private Sub mentorTextCheck_CheckedChanged(sender As Object, e As EventArgs) Handles mentorTextCheck.Click
        If mentorTextCheck.Checked Then
            UpdateVal("Mentor=", 1)
        Else
            UpdateVal("Mentor=", 0)
        End If
    End Sub
    Private Sub genVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles genVoiceCheck.Click
        If genVoiceCheck.Checked Then
            UpdateVal("Enable=", 1, "[Voice]")
        Else
            UpdateVal("Enable=", 0, "[Voice]")
        End If
    End Sub
    Private Sub proxVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles proxVoiceCheck.Click
        If proxVoiceCheck.Checked Then
            UpdateVal("ProximityEnabled=", 1, "[Voice]")
        Else
            UpdateVal("ProximityEnabled=", 0, "[Voice]")
        End If
    End Sub
    Private Sub squadVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles squadVoiceCheck.Click
        If squadVoiceCheck.Checked Then
            UpdateVal("GroupEnabled=", 1, "[Voice]")
        Else
            UpdateVal("GroupEnabled=", 0, "[Voice]")
        End If
    End Sub
    Private Sub raidVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles raidVoiceCheck.Click
        If raidVoiceCheck.Checked Then
            UpdateVal("RaidEnabled=", 1, "[Voice]")
        Else
            UpdateVal("RaidEnabled=", 0, "[Voice]")
        End If
    End Sub
    Private Sub outfitVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles outfitVoiceCheck.Click
        If outfitVoiceCheck.Checked Then
            UpdateVal("GuildEnabled=", 1, "[Voice]")
        Else
            UpdateVal("GuildEnabled=", 0, "[Voice]")
        End If
    End Sub
    Private Sub leaderVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles leaderVoiceCheck.Click
        If leaderVoiceCheck.Checked Then
            UpdateVal("GroupLeaderEnabled=", 1, "[Voice]")
        Else
            UpdateVal("GroupLeaderEnabled=", 0, "[Voice]")
        End If
    End Sub
#End Region
#End Region
#Region "HudIconControls"
#Region "GroupChecks"
    Private Sub iconsInfantryGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsInfantryGroupCheck.CheckedChanged
        If iconsInfantryGroupCheck.Checked = True Then
            iconsInfantryAllyCheck.Checked = True
            iconsInfantryEnemyCheck.Checked = True
        Else
            iconsInfantryAllyCheck.Checked = False
            iconsInfantryEnemyCheck.Checked = False
        End If
    End Sub
    Private Sub iconsVehicleGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsVehicleGroupCheck.CheckedChanged
        If iconsVehicleGroupCheck.Checked = True Then
            iconsVehAllyCheck.Checked = True
            iconsVehEnemyCheck.Checked = True
            iconsVehBastionCheck.Checked = True
        Else
            iconsVehAllyCheck.Checked = False
            iconsVehEnemyCheck.Checked = False
            iconsVehBastionCheck.Checked = False
        End If
    End Sub
    Private Sub iconsDeployGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDeployGroupCheck.CheckedChanged
        If iconsDeployGroupCheck.Checked = True Then
            iconsDepDildarCheck.Checked = True
            iconsDepC4Check.Checked = True
            iconsDepAmmoBoxCheck.Checked = True
            iconsDepDMGNadeCheck.Checked = True
            iconsDepDroneCheck.Checked = True
            iconsDepMinesCheck.Checked = True
            iconsDepShieldRegenCheck.Checked = True
            iconsDepStatusNadeCheck.Checked = True
            iconsDepTurretsCheck.Checked = True
        Else
            iconsDepDildarCheck.Checked = False
            iconsDepC4Check.Checked = False
            iconsDepAmmoBoxCheck.Checked = False
            iconsDepDMGNadeCheck.Checked = False
            iconsDepDroneCheck.Checked = False
            iconsDepMinesCheck.Checked = False
            iconsDepShieldRegenCheck.Checked = False
            iconsDepStatusNadeCheck.Checked = False
            iconsDepTurretsCheck.Checked = False
        End If
    End Sub
    Private Sub iconsWorldGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldGroupCheck.CheckedChanged
        If iconsWorldGroupCheck.Checked = True Then
            iconsWorldAnomalyCheck.Checked = True
            iconsWorldAssetCheck.Checked = True
            iconsWorldBuoyCheck.Checked = True
            iconsWorldConstructionCheck.Checked = True
            iconsWorldCortiumCheck.Checked = True
            iconsWorldCrystalCheck.Checked = True
            iconsWorldDrillCheck.Checked = True
            iconsWorldImplantCheck.Checked = True
            iconsWorldMissionCheck.Checked = True
            iconsWorldNPCCheck.Checked = True
            iconsWorldPlantCheck.Checked = True
            iconsWorldStationCheck.Checked = True
        Else
            iconsWorldAnomalyCheck.Checked = False
            iconsWorldAssetCheck.Checked = False
            iconsWorldBuoyCheck.Checked = False
            iconsWorldConstructionCheck.Checked = False
            iconsWorldCortiumCheck.Checked = False
            iconsWorldCrystalCheck.Checked = False
            iconsWorldDrillCheck.Checked = False
            iconsWorldImplantCheck.Checked = False
            iconsWorldMissionCheck.Checked = False
            iconsWorldNPCCheck.Checked = False
            iconsWorldPlantCheck.Checked = False
            iconsWorldStationCheck.Checked = False
        End If
    End Sub
    Private Sub iconsFacilityGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacilityGroupCheck.CheckedChanged
        If iconsFacilityGroupCheck.Checked = True Then
            iconsFacAirAmmoCheck.Checked = True
            iconsFacAirTermCheck.Checked = True
            iconsFacBridgeTermCheck.Checked = True
            iconsFacBusTermCheck.Checked = True
            iconsFacEquipTermCheck.Checked = True
            iconsFacFlashTermCheck.Checked = True
            iconsFacForwardCheck.Checked = True
            iconsFacGalTermCheck.Checked = True
            iconsFacGateAttackCheck.Checked = True
            iconsFacHorzCheck.Checked = True
            iconsFacLightTermCheck.Checked = True
            iconsFacNearbyCheck.Checked = True
            iconsFacOWPointsCheck.Checked = True
            iconsFacPointCheck.Checked = True
            iconsFacRelicDoorCheck.Checked = True
            iconsFacSCUAttackCheck.Checked = True
            iconsFacSCUCheck.Checked = True
            iconsFacSCUShieldCheck.Checked = True
            iconsFacTeleCheck.Checked = True
            iconsFacVehAmmoCheck.Checked = True
            iconsFacVehShieldCheck.Checked = True
            iconsFacVehTermCheck.Checked = True
            iconsFacVertCheck.Checked = True
            iconsFacWGTermCheck.Checked = True
        Else
            iconsFacAirAmmoCheck.Checked = False
            iconsFacAirTermCheck.Checked = False
            iconsFacBridgeTermCheck.Checked = False
            iconsFacBusTermCheck.Checked = False
            iconsFacEquipTermCheck.Checked = False
            iconsFacFlashTermCheck.Checked = False
            iconsFacForwardCheck.Checked = False
            iconsFacGalTermCheck.Checked = False
            iconsFacGateAttackCheck.Checked = False
            iconsFacHorzCheck.Checked = False
            iconsFacLightTermCheck.Checked = False
            iconsFacNearbyCheck.Checked = False
            iconsFacOWPointsCheck.Checked = False
            iconsFacPointCheck.Checked = False
            iconsFacRelicDoorCheck.Checked = False
            iconsFacSCUAttackCheck.Checked = False
            iconsFacSCUCheck.Checked = False
            iconsFacSCUShieldCheck.Checked = False
            iconsFacTeleCheck.Checked = False
            iconsFacVehAmmoCheck.Checked = False
            iconsFacVehShieldCheck.Checked = False
            iconsFacVehTermCheck.Checked = False
            iconsFacVertCheck.Checked = False
            iconsFacWGTermCheck.Checked = False
        End If
    End Sub
    Private Sub iconsTitlesGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsTitlesGroupCheck.CheckedChanged
        If iconsTitlesGroupCheck.Checked = True Then
            iconsTitleAllyCheck.Checked = True
            iconsTitleEnemyCheck.Checked = True
        Else
            iconsTitleAllyCheck.Checked = False
            iconsTitleEnemyCheck.Checked = False
        End If
    End Sub
    Private Sub iconsNamesGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsNamesGroupCheck.CheckedChanged
        If iconsNamesGroupCheck.Checked = True Then
            iconsNameSquadCheck.Checked = True
            iconsNamePlatoonCheck.Checked = True
            iconsNameFireCheck.Checked = True
            iconsNameOutfitCheck.Checked = True
            iconsNameEnemyCheck.Checked = True
        Else
            iconsNameSquadCheck.Checked = False
            iconsNamePlatoonCheck.Checked = False
            iconsNameFireCheck.Checked = False
            iconsNameOutfitCheck.Checked = False
            iconsNameEnemyCheck.Checked = False
        End If
    End Sub
    Private Sub iconsDoritoGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDoritoGroupCheck.CheckedChanged
        If iconsDoritoGroupCheck.Checked = True Then
            iconsDoritoAllyCheck.Checked = True
            iconsDoritoEnemyCheck.Checked = True
        Else
            iconsDoritoAllyCheck.Checked = False
            iconsDoritoEnemyCheck.Checked = False
        End If
    End Sub
    Private Sub iconsMiscGroupCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsMiscGroupCheck.CheckedChanged
        If iconsMiscGroupCheck.Checked = True Then
            iconsSocialCheck.Checked = True
        Else
            iconsSocialCheck.Checked = False
        End If
    End Sub
#End Region
#Region "IndividualChecks"
#Region "Infantry"
    Private Sub iconsInfantryAllyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsInfantryAllyCheck.CheckedChanged
        If iconsInfantryAllyCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 84, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 84, False)
        End If
    End Sub
    Private Sub iconsInfantryEnemyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsInfantryEnemyCheck.CheckedChanged
        If iconsInfantryEnemyCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 85, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 85, False)
        End If
    End Sub
#End Region
#Region "Vehicles"
    Private Sub iconsVehAllyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsVehAllyCheck.CheckedChanged
        If iconsVehAllyCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 86, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 86, False)
        End If
    End Sub
    Private Sub iconsVehEnemyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsVehEnemyCheck.CheckedChanged
        If iconsVehEnemyCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 87, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 87, False)
        End If
    End Sub
    Private Sub iconsVehBastionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsVehBastionCheck.CheckedChanged
        If iconsVehBastionCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 62, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 62, False)
        End If
    End Sub
#End Region
#Region "Deployables"
    Private Sub iconsDepDMGNadeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepDMGNadeCheck.CheckedChanged
        If iconsDepDMGNadeCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 3, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 3, False)
        End If
    End Sub
    Private Sub iconsDepStatusNadeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepStatusNadeCheck.CheckedChanged
        If iconsDepStatusNadeCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 82, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 82, False)
        End If
    End Sub
    Private Sub iconsDepMinesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepMinesCheck.CheckedChanged
        If iconsDepMinesCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 34, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 34, False)
        End If
    End Sub
    Private Sub iconsDepC4Check_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepC4Check.CheckedChanged
        If iconsDepC4Check.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 10, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 10, False)
        End If
    End Sub
    Private Sub iconsDepShieldRegenCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepShieldRegenCheck.CheckedChanged
        If iconsDepShieldRegenCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 38, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 38, False)
        End If
    End Sub
    Private Sub iconsDepDildarCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepDildarCheck.CheckedChanged
        If iconsDepDildarCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 39, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 39, False)
        End If
    End Sub
    Private Sub iconsDepAmmoBoxCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepAmmoBoxCheck.CheckedChanged
        If iconsDepAmmoBoxCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 33, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 33, False)
        End If
    End Sub
    Private Sub iconsDepDroneCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepDroneCheck.CheckedChanged
        If iconsDepDroneCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 65, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 65, False)
        End If
    End Sub
    Private Sub iconsDepTurretsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepTurretsCheck.CheckedChanged
        If iconsDepTurretsCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 88, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 88, False)
        End If
    End Sub
#End Region
#Region "World"
    Private Sub iconsWorldAnomalyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldAnomalyCheck.CheckedChanged
        If iconsWorldAnomalyCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 49, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 49, False)
        End If
    End Sub
    Private Sub iconsWorldDrillCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldDrillCheck.CheckedChanged
        If iconsWorldDrillCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 53, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 53, False)
        End If
    End Sub
    Private Sub iconsWorldBuoyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldBuoyCheck.CheckedChanged
        If iconsWorldBuoyCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 58, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 58, False)
        End If
    End Sub
    Private Sub iconsWorldMissionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldMissionCheck.CheckedChanged
        If iconsWorldMissionCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 68, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 68, False)
        End If
    End Sub
    Private Sub iconsWorldImplantCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldImplantCheck.CheckedChanged
        If iconsWorldImplantCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 67, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 67, False)
        End If
    End Sub
    Private Sub iconsWorldPlantCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldPlantCheck.CheckedChanged
        If iconsWorldPlantCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 71, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 71, False)
        End If
    End Sub
    Private Sub iconsWorldNPCCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldNPCCheck.CheckedChanged
        If iconsWorldNPCCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 79, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 79, False)
        End If
    End Sub
    Private Sub iconsWorldStationCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldStationCheck.CheckedChanged
        If iconsWorldStationCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 44, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 44, False)
        End If
    End Sub
    Private Sub iconsWorldAssetCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldAssetCheck.CheckedChanged
        If iconsWorldAssetCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 63, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 63, False)
        End If
    End Sub
    Private Sub iconsWorldCrystalCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldCrystalCheck.CheckedChanged
        If iconsWorldCrystalCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 43, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 43, False)
        End If
    End Sub
    Private Sub iconsWorldConstructionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldConstructionCheck.CheckedChanged
        If iconsWorldConstructionCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 117, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 117, False)
        End If
    End Sub
    Private Sub iconsWorldCortiumCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldCortiumCheck.CheckedChanged
        If iconsWorldCortiumCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 116, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 116, False)
        End If
    End Sub
#End Region
#Region "Facility"
    Private Sub iconsFacVehAmmoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacVehAmmoCheck.CheckedChanged
        If iconsFacVehAmmoCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 11, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 11, False)
        End If
    End Sub
    Private Sub iconsFacAirAmmoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacAirAmmoCheck.CheckedChanged
        If iconsFacAirAmmoCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 18, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 18, False)
        End If
    End Sub
    Private Sub iconsFacEquipTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacEquipTermCheck.CheckedChanged
        If iconsFacEquipTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 7, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 7, False)
        End If
    End Sub
    Private Sub iconsFacWGTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacWGTermCheck.CheckedChanged
        If iconsFacWGTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 26, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 26, False)
        End If
    End Sub
    Private Sub iconsFacAirTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacAirTermCheck.CheckedChanged
        If iconsFacAirTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 4, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 4, False)
        End If
    End Sub
    Private Sub iconsFacVehTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacVehTermCheck.CheckedChanged
        If iconsFacVehTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 5, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 5, False)
        End If
    End Sub
    Private Sub iconsFacGalTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacGalTermCheck.CheckedChanged
        If iconsFacGalTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 6, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 6, False)
        End If
    End Sub
    Private Sub iconsFacFlashTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacFlashTermCheck.CheckedChanged
        If iconsFacFlashTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 15, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 15, False)
        End If
    End Sub
    Private Sub iconsFacLightTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacLightTermCheck.CheckedChanged
        If iconsFacLightTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 20, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 20, False)
        End If
    End Sub
    Private Sub iconsFacBusTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacBusTermCheck.CheckedChanged
        If iconsFacBusTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 115, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 115, False)
        End If
    End Sub
    Private Sub iconsFacTeleCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacTeleCheck.CheckedChanged
        If iconsFacTeleCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 13, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 13, False)
        End If
    End Sub
    Private Sub iconsFacPointCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacPointCheck.CheckedChanged
        If iconsFacPointCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 2, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 2, False)
        End If
    End Sub
    Private Sub iconsFacOWPointsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacOWPointsCheck.CheckedChanged
        If iconsFacOWPointsCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 61, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 61, False)
        End If
    End Sub
    Private Sub iconsFacNearbyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacNearbyCheck.CheckedChanged
        If iconsFacNearbyCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 83, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 83, False)
        End If
    End Sub
    Private Sub iconsFacSCUCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacSCUCheck.CheckedChanged
        If iconsFacSCUCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 17, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 17, False)
        End If
    End Sub
    Private Sub iconsFacHorzCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacHorzCheck.CheckedChanged
        If iconsFacHorzCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 22, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 22, False)
        End If
    End Sub
    Private Sub iconsFacVertCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacVertCheck.CheckedChanged
        If iconsFacVertCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 23, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 23, False)
        End If
    End Sub
    Private Sub iconsFacVehShieldCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacVehShieldCheck.CheckedChanged
        If iconsFacVehShieldCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 24, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 24, False)
        End If
    End Sub
    Private Sub iconsFacSCUShieldCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacSCUShieldCheck.CheckedChanged
        If iconsFacSCUShieldCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 25, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 25, False)
        End If
    End Sub
    Private Sub iconsFacForwardCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacForwardCheck.CheckedChanged
        If iconsFacForwardCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 27, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 27, False)
        End If
    End Sub
    Private Sub iconsFacBridgeTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacBridgeTermCheck.CheckedChanged
        If iconsFacBridgeTermCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 35, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 35, False)
        End If
    End Sub
    Private Sub iconsFacSCUAttackCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacSCUAttackCheck.CheckedChanged
        If iconsFacSCUAttackCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 75, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 75, False)
        End If
    End Sub
    Private Sub iconsFacGateAttackCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacGateAttackCheck.CheckedChanged
        If iconsFacGateAttackCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 76, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 76, False)
        End If
    End Sub
    Private Sub iconsFacRelicDoorCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacRelicDoorCheck.CheckedChanged
        If iconsFacRelicDoorCheck.Checked = True Then
            UpdateVal("HiddenHUDIndicators=", 77, True)
        Else
            UpdateVal("HiddenHUDIndicators=", 77, False)
        End If
    End Sub
#End Region
#Region "Title"
    Private Sub iconsTitleAllyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsTitleAllyCheck.CheckedChanged
        If iconsTitleAllyCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 1, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 1, False)
        End If
    End Sub
    Private Sub iconsTitleEnemyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsTitleEnemyCheck.CheckedChanged
        If iconsTitleEnemyCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 2, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 2, False)
        End If
    End Sub
#End Region
#Region "Names"
    Private Sub iconsNameSquadCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsNameSquadCheck.CheckedChanged
        If iconsNameSquadCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 3, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 3, False)
        End If
    End Sub
    Private Sub iconsNamePlatoonCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsNamePlatoonCheck.CheckedChanged
        If iconsNamePlatoonCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 4, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 4, False)
        End If
    End Sub
    Private Sub iconsNameFireCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsNameFireCheck.CheckedChanged
        If iconsNameFireCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 5, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 5, False)
        End If
    End Sub
    Private Sub iconsNameOutfitCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsNameOutfitCheck.CheckedChanged
        If iconsNameOutfitCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 6, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 6, False)
        End If
    End Sub
    Private Sub iconsNameEnemyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsNameEnemyCheck.CheckedChanged
        If iconsNameEnemyCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 7, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 7, False)
        End If
    End Sub
#End Region
#Region "Dorito"
    Private Sub iconsDoritoAllyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDoritoAllyCheck.CheckedChanged
        If iconsDoritoAllyCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 8, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 8, False)
        End If
    End Sub
    Private Sub iconsDoritoEnemyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDoritoEnemyCheck.CheckedChanged
        If iconsDoritoEnemyCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 9, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 9, False)
        End If
    End Sub
#End Region
#Region "Misc"
    Private Sub iconsSocialCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsSocialCheck.CheckedChanged
        If iconsSocialCheck.Checked = True Then
            UpdateVal("HiddenNamePlateOptions=", 10, True)
        Else
            UpdateVal("HiddenNamePlateOptions=", 10, False)
        End If
    End Sub

#End Region
#End Region
#End Region
#End Region
#Region "FontStuff"
    Private Sub fontSelectButton_Click(sender As Object, e As EventArgs) Handles fontSelectButton.Click
        Dim fontPath As String = Nothing
        Dim fontDialog As New OpenFileDialog()

        fontDialog.Filter = "TrueType Font files (*.ttf)|*.ttf"
        fontDialog.RestoreDirectory = True

        If fontDialog.ShowDialog() = DialogResult.OK Then
            'Using a dialog, get the desired font file path
            fontPath = fontDialog.FileName.ToString
            'Show user selected font path
            selectedFontPath.Text() = fontPath
            UpdateValMyIni("FontFilePath=", fontPath)
        End If
    End Sub
    Private Sub fontAutoCheck_CheckChanged(sender As Object, e As EventArgs) Handles fontAutoCheck.Click
        If fontAutoCheck.Checked Then
            UpdateValMyIni("FontAutoReplace=", True)
            fontAutoCheck2.Visible = True
            selectedFontPath.Visible = True
            fontSelectButton.Visible = True
        Else
            UpdateValMyIni("FontAutoReplace=", False)
            fontAutoCheck2.Visible = False
            selectedFontPath.Visible = False
            fontSelectButton.Visible = False
        End If
    End Sub
    Private Sub fontAutoCheck2_CheckChanged(sender As Object, e As EventArgs) Handles fontAutoCheck2.Click
        If fontAutoCheck2.Checked Then
            UpdateValMyIni("FontAutoReplace2=", True)
        Else
            UpdateValMyIni("FontAutoReplace2=", False)
        End If
    End Sub
    Public Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Dim watcher As EventLogWatcher
        watcher = Nothing
        Try
            Dim subQuery As New EventLogQuery("System", PathType.LogName, "*[System[Provider[@Name='Service Control Manager'] and (Level=4 or Level=0) and (band(Keywords,36028797018963968)) and (EventID=7045)]] and *[EventData[Data[@Name='ServiceName'] and (Data='BEDaisy')]]")
            watcher = New EventLogWatcher(subQuery)
            AddHandler watcher.EventRecordWritten, AddressOf BackgroundHandleEvent
            watcher.Enabled = True
            Console.WriteLine("waiting for event detect")
            While Not BackgroundWorker1.CancellationPending
                System.Threading.Thread.Sleep(500)
                If BackgroundWorker1.CancellationPending Then
                    Exit While
                End If
            End While
        Catch ex As EventLogReadingException
            Console.WriteLine("error: {0}", ex.Message)
        Finally
            watcher.Enabled = False
            If Not watcher Is Nothing Then
                watcher.Dispose()
            End If
        End Try
    End Sub
    Public Sub BackgroundHandleEvent(ByVal obj As Object, ByVal arg As EventRecordWrittenEventArgs)
        If Not arg.EventRecord Is Nothing Then
            Console.WriteLine("received event {0} from sub", arg.EventRecord.Id)
            Console.WriteLine("desc: {0}", arg.EventRecord.FormatDescription())
            If fontAutoCheck.Checked Then
                Dim fontSource As String = GetStateMyIni("FontFilePath=")
                Dim fontDest As String = CurDir() + "\UI\Resource\Fonts\Geo-Md.ttf"
                File.Copy(fontSource, fontDest, True)
                If fontAutoCheck2.Checked Then
                    Dim fontDest2 As String = CurDir() + "\UI\Resource\Fonts\ARIALUNI.ttf"
                    FileCopy(fontSource, fontDest2)
                End If
                Console.WriteLine("Copied fonts")
            End If
            If localeReplaceCheck.Checked Then
                Dim dirSource As String = GetStateMyIni("LocaleDirPath=")
                Dim datSource As String = GetStateMyIni("LocaleDatPath=")
                Dim dirDest As String = CurDir() + "\Locale\en_us_data.dir"
                Dim datDest As String = CurDir() + "\Locale\en_us_data.dat"
                File.Copy(dirSource, dirDest, True)
                File.Copy(datSource, datDest, True)
                Console.WriteLine("Copied locale")
            End If
            If commandAutoCheck.Checked Then
                Dim commandList As List(Of String) = Nothing
                commandList = File.ReadAllLines(commandPath).ToList
                commandList(0) = vbCrLf + commandList(0)
                File.AppendAllLines("ClientConfig.ini", commandList)
            End If
            End
        Else
            Console.WriteLine("event instance null")
        End If
    End Sub
    Private Sub localeReplaceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles localeReplaceCheck.Click
        If localeReplaceCheck.Checked Then
            UpdateValMyIni("LocaleAutoReplace=", True)
            localeDatButton.Visible = True
            localeDirButton.Visible = True
            selectedDatPath.Visible = True
            selectedDirPath.Visible = True
            Label38.Visible = True
        Else
            UpdateValMyIni("LocaleAutoReplace=", False)
            localeDatButton.Visible = False
            localeDirButton.Visible = False
            selectedDatPath.Visible = False
            selectedDirPath.Visible = False
            Label38.Visible = False
        End If
    End Sub
    Private Sub localeDirButton_Click(sender As Object, e As EventArgs) Handles localeDirButton.Click
        Dim filePath As String = Nothing
        Dim newDialog As New OpenFileDialog()

        newDialog.Filter = "Dir files (*.dir)|*.dir"
        newDialog.RestoreDirectory = True

        If newDialog.ShowDialog() = DialogResult.OK Then
            filePath = newDialog.FileName.ToString
            selectedDirPath.Text() = filePath
            UpdateValMyIni("LocaleDirPath=", filePath)
        End If
    End Sub
    Private Sub localeDatButton_Click(sender As Object, e As EventArgs) Handles localeDatButton.Click
        Dim filePath As String = Nothing
        Dim newDialog As New OpenFileDialog()

        newDialog.Filter = "Dat files (*.dat)|*.dat"
        newDialog.RestoreDirectory = True

        If newDialog.ShowDialog() = DialogResult.OK Then
            filePath = newDialog.FileName.ToString
            selectedDatPath.Text() = filePath
            UpdateValMyIni("LocaleDatPath=", filePath)
        End If
    End Sub
    Private Sub commandAutoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles commandAutoCheck.Click
        If commandAutoCheck.Checked Then
            UpdateValMyIni("CommandAutoReplace=", True)
            commandTextBox.Visible = True
        Else
            UpdateValMyIni("CommandAutoReplace=", False)
            commandTextBox.Visible = False
        End If
    End Sub
    Private Sub commandTextBox_TextChanged(sender As Object, e As EventArgs) Handles commandTextBox.LostFocus
        File.WriteAllLines(commandPath, commandTextBox.Lines)
    End Sub
#End Region
End Class