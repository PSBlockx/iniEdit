Imports System.IO
Imports Microsoft.Win32.TaskScheduler
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography.X509Certificates
Imports System.Runtime.Remoting.Messaging

Public Class Form1
    Public Class Arrays
        Public Shared Rendering As Array = {"[Rendering]", "GraphicsQuality=", "TextureQuality=", "ShadowQuality=", "LightingQuality=", "EffectsQuality=", "TerrainQuality=", "FloraQuality=", "ModelQuality=", "RenderDistance=", "Gamma=", "VerticalFOV=", "ParticleLOD=", "FogShadowsEnable", "MotionBlur=", "VSync=", "AO=", "MaximumFPS", "UseLod0a=", "BloomEnabed=", "InfantryRenderDistance=", "GroundVehicleRenderDistance=", "AirVehicleRenderDistance=", "UseGlobalRenderDistance=", "ParticleDistanceScale=", "Smoothing=", "UseAspectFOV=", "GpuPhysics=", "ShadowManagerQuality=", "ShadowMapCount=", "ShadowMapQuality=", "ShadowNearDistance=", "ShadowFarDistance=", "ShadowRSM=", "ColorBlindFilterType=", "ColorBlindFilterAmount=", "ColorBlindFilterStrength"}
        Public Shared Display As Array = {"[Display]", "Mode=", "FullscreenMode=", "FullscreenRefresh=", "FullscreenWidth=", "FullscreenHeight=", "WindowedWidth=", "WindowedHeight=", "Maximized=", "RenderQuality="}
        Public Shared Sound As Array = {"[Sound]", "Master=", "Music=", "Game=", "Dialog=", "UI=", "HitIndicator=", "LowAmmoIndicator=", "VehicleChatter=", "IdleMusic=", "MaxVoices=", "UseFloat32Output=", "ExclusiveMode=", "UseHighQualityReverb="}
        Public Shared Terrain As Array = {"[Terrain]", "RenderFlora="}
        Public Shared General As Array = {"[General]", "AutoDetectPerformanceSettings=", "MouseSensitivity=", "ScopedMouseSensitivity=", "ADSMouseSensitivity=", "VehicleMouseSensitivity=", "FlightMouseSensitivity=", "JoystickSensitivity=", "JoystickDeadzone=", "InvertVerticalLook=", "InvertVerticalFly=", "InvertTankSteering=", "MouseRawInput=", "MouseSmoothing=", "ToggleCrouch=", "ZoomToggle=", "SprintToggle=", "SprintLegacyToggleMode=", "DrawHud=", "ReduceInputLag=", "FixedMinimap=", "Profanity=", "GamepadSmoothing=", "GamepadInvertLook=", "GamepadInvertFlight=", "GamepadEasyFlight=", "DecloakOnFire=", "AbilityQueueSeconds=", "VehicleGunnerMouseSensitivity="}
        Public Shared iniEdit As Array = {"[iniEdit]", "FontAutoReplace=", "FontFilePath="}
        Public Shared UI As Array = {"[UI]", "CentralizedHudMode=", "HudChatInactiveOpacity=", "HudShowIndicatorNames=", "HudShowAlertTimer=", "ShowReticleIFF=", "HudShowHealth=", "HudShowTopCompass=", "HudShow3PVehicleReticle=", "DrawMission=", "DrawKillSpam=", "DrawLootDrop=", "TintModeReticuleStyle=", "TintModeReticuleColor=", "PlatoonSquadColor0=", 1234, "PlatoonSquadColor1=", 1234, "PlatoonSquadColor2=", 1234, "PlatoonSquadColor3=", 1234, "TintModeFacility=", "TintModePlayer=", "TintModeMap=", "NoDeployZoneColor=", 13369344, "OrbitalStrikeColor=", 13421568, "OrbitalStrikeAlpha=", "ShowGroupNotifications=", "ShowOutfitNotifications=", "HideWarpZoneConfirmation=", "SelectedChatChannel=", "ChatFontSize=", "MapShowFactionColoredHotspots=", "MapActiveToggleView=", "MapFilterHeatMapMode=", "MapFilterShowInfluenceCloud=", "MapFilterShowGrid=", "MapFilterShowFacilities=", "MapFilterShowTerrain=", "MapFilterShowFacilityLinks=", "MapFilterShowTerritoryControl=", "MapFilterShowResource1=", "MapStatisticsView=", "MapFilterShowHotspots=", "MapCommandsSettingsShow2=", "MapCommandsSettingsShow3=", "MapCommandsSettingsAlpha3=", "TrackedDirectives=", "OutfitShowOfflineMembers=", "ShowVRTrainingTutorial=", "ShowDirectivesTutorial=", "ShowMapTutorial=", "ShowImplantTutorial=", "ShowTutorialIslandLandingPage=", "ShowOutfitsTutorial=", "LoadoutInfoInfiltrator=", "LoadoutInfoLightAssault=", "LoadoutInfoMedic=", "LoadoutInfoEngineer=", "LoadoutInfoHeavyAssault=", "LoadoutInfoMax="}
        Public Shared AutoRefuse As Array = {"[AutoRefuse]", "FriendInvitation=", "DuelInvitation=", "GuildInvitation=", "HideUi=", "TradeRequest=", "HousingInvitation=", "GroupInvitation=", "SwapSeatRequest=", "Whispers="}
        Public Shared ChatChannels As Array = {"[DisableChatChannelOptions]", "Squad=", "Platoon=", "Fireteam=", "Leader=", "Proximity=", "Outfit=", "Yell=", "Region=", "Mentor=", "Social="}

        Public Shared bigOptions As Array = {Rendering, General, Terrain, UI, iniEdit, Display}
    End Class
    Public Shared curini As List(Of String) = Nothing

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If ini doesn't already have header for options added by this program, add one
        curini = File.ReadAllLines("Useroptions.ini").ToList
        If Not curini.Contains("[iniEdit]") Then
            curini.Insert(0, "[iniEdit]")
            File.WriteAllLines("Useroptions.ini", curini.ToArray)
        End If
        'Housekeeping
        readAllOptions()
        sensTypeDrop.SelectedIndex = 0
        Label62.Text = "Currently Editing: Useroptions.ini"
    End Sub
    Friend Sub UpdateVal(ByVal optionName As String, ByVal newVal As String)
        Dim found As Boolean = False
        For Each line In curini
            If line.StartsWith(optionName) Then
                found = True
                line = String.Concat(optionName, newVal)
                Console.WriteLine(String.Concat("Updated ", optionName, " to ", newVal))
            End If
        Next
        If Not found Then
            For Each array In Arrays.bigOptions
                For Each item In array
                    If item.Equals(optionName) Then
                        For Each line In curini
                            If line.ToLower.StartsWith(array(0).ToString.ToLower) Then
                                curini.Insert(curini.IndexOf(line) + 1, String.Concat(optionName, newVal))
                                Console.WriteLine(String.Concat("Added ", optionName, " with val ", newVal))
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            Next
        End If
    End Sub
    Function getState(ByVal optionName As String)
        'Find the line which has the desired option, and return the value after the = sign
        For Each line In curini
            If line.StartsWith(optionName) Then
                Dim optionVal As Array = line.Split("="c)
                Console.WriteLine(String.Concat("Got ", optionName, " with ", optionVal(1)))
                Return optionVal(1)
            End If
        Next
    End Function
    Friend Sub ColorUpdate(ByVal optionName As String, ByVal newVal As String, ByVal faction As Integer)
        Dim found As Boolean = False
        For Each line In curini
            If line.StartsWith(optionName) Then
                found = True
                Dim lineList As List(Of String) = line.Split("="c, ","c).ToList
                lineList(faction) = newVal
                line = String.Concat(optionName, lineList(1), ",", lineList(2), ",", lineList(3))
            End If
        Next
        Console.WriteLine(String.Concat("Updated ", optionName, " to ", newVal))
        If Not found Then
            For Each array In Arrays.bigOptions
                For Each item In array
                    If item.Equals(optionName) Then
                        For Each line In curini
                            If line.ToLower.StartsWith(array(0).ToString.ToLower) Then
                                curini.Insert(curini.IndexOf(line) + 1, String.Concat(optionName, newVal))
                                Console.WriteLine(String.Concat("Added ", optionName, " with val ", newVal))
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            Next
        End If
    End Sub
    Function ColorGetState(ByVal optionName As String, ByVal faction As Integer)
        For Each line In curini
            If line.StartsWith(optionName) Then
                Dim optionVal As Array = line.Split("="c, ","c)
                Console.WriteLine(String.Concat("Got ", optionName, "with ", optionVal(faction)))
                Return optionVal(faction)
            End If
        Next
    End Function
#Region "MiscFuncs"
    Function colorGetter()
        Dim chosenColor = Nothing
        Dim colorDialog As New ColorDialog()
        'Ask user for a color
        If colorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            chosenColor = colorDialog.Color
        End If
        Return chosenColor
    End Function
    Function colorDecimalSwap(ByVal color As Integer)
        Dim Channel1 As Integer = color \ 65536
        Dim Channel2 As Integer = (color - Channel1 * 65536) \ 256
        Dim Channel3 As Integer = color - (Channel1 * 65536 + Channel2 * 256)
        Dim Result As Integer = Channel1 + Channel2 * 256 + Channel3 * 65536
        Return Result
    End Function
    Function hipTurnCalc(DPI, Sens)
        Dim distance As Double = Math.Round((1 / DPI) * (11.7581 / (Sens + 0.3)) ^ 3, 2, MidpointRounding.AwayFromZero)
        Return distance.ToString()
    End Function
    Function aimTurncalc(DPI, Sens, Zoom)
        Dim distance As Double = Math.Round((1 / DPI) * (11.7581 / (Sens + 0.3)) ^ 3 * 1.6 * Zoom, 2, MidpointRounding.AwayFromZero)
        Return distance.ToString()
    End Function
    Function hipSensCalc(DPI, Distance)
        Dim sens As Double = Math.Round((DPI * Distance) ^ (-1 / 3) * 11.7581 - 0.3, 3, MidpointRounding.AwayFromZero)
        If sens > 1 Then
            sens = 1
        End If
        Return sens.ToString()
    End Function
    Function aimSensCalc(DPI, Distance, Zoom)
        Dim sens As Double = Math.Round(((DPI * Distance) / (Zoom * 1.6)) ^ (-1 / 3) * 11.7581 - 0.3, 3, MidpointRounding.AwayFromZero)
        If sens > 1 Then
            sens = 1
        End If
        Return sens.ToString()
    End Function
    Function showControl(control)
        With control
            .Show()
            .BringToFront()
            .Enabled = True
        End With
    End Function
    Function hideControl(control)
        With control
            .Hide()
            .SendToBack()
            .Enabled = False
        End With
    End Function
#End Region
    Function readAllOptions()
        'Big list of checking where the options are at cus i dont code good
        vsyncCheck.Checked = getState("VSync=")
        fogShadCheck.Checked = getState("FogShadowsEnable=")
        ambOccCheck.Checked = getState("AO=")
        bloomCheck.Checked = getState("BloomEnabled=")
        blurCheck.Checked = getState("MotionBlur=")
        smoothCheck.Checked = getState("Smoothing=")
        wideCheck.Checked = getState("UseAspectFOV=")
        useGlobRenCheck.Checked = getState("UseGlobalRenderDistance=")
        globRenDistBox.Text = getState("RenderDistance=")
        infRenDistBox.Text = getState("InfantryRenderDistance=")
        vehRenDistbox.Text = getState("GroundVehicleRenderDistance=")
        airRenDistBox.Text = getState("AirVehicleRenderDistance=")
        fovBox.Text = getState("VerticalFOV=")
        renQualBox.Text = getState("RenderQuality=")
        maxFPSBox.Text = getState("MaximumFPS=")
        gammaBox.Text = getState("Gamma=")
        partDistScaleBox.Text = getState("ParticleDistanceScale=")
        graphQualDrop.SelectedIndex = Integer.Parse(getState("GraphicsQuality=")) - 1
        texQualDrop.SelectedIndex = Integer.Parse(getState("TextureQuality="))
        shadQualDrop.SelectedIndex = Integer.Parse(getState("ShadowQuality="))
        lightQualDrop.SelectedIndex = Integer.Parse(getState("LightingQuality=")) - 1
        effQualDrop.SelectedIndex = Integer.Parse(getState("EffectsQuality=")) - 1
        terrQualDrop.SelectedIndex = Integer.Parse(getState("TerrainQuality=")) - 1
        floraQualDrop.SelectedIndex = Integer.Parse(getState("FloraQuality=")) - 1
        modQualDrop.SelectedIndex = Integer.Parse(getState("ModelQuality=")) - 1
        partQualDrop.SelectedIndex = Integer.Parse(getState("ParticleLOD="))
        hipSensBox.Value = getState("MouseSensitivity=")
        adsSensBox.Value = getState("ADSMouseSensitivity=")
        scopSensBox.Value = getState("ScopedMouseSensitivity=")
        vehSensBox.Value = getState("VehicleMouseSensitivity=")
        gunSensBox.Value = getState("VehicleGunnerMouseSensitivity=")
        airSensBox.Value = getState("FlightMouseSensitivity=")
        sensRawCheck.Checked = getState("MouseRawInput=")
        fontAutoCheck.Checked = getState("FontAutoReplace=")
        selectedFontPath.Text = getState("FontFilePath=")
        hudHPCheck.Checked = getState("HudShowHealth=")
        hudIndCheck.Checked = getState("HudShowIndicatorNames=")
        hudAlertCheck.Checked = getState("HudShowAlertTimer")
        hudLootCheck.Checked = getState("DrawLootDrop=")
        hudSpamCheck.Checked = getState("DrawKillSpam=")
        hudCompCheck.Checked = getState("HudShowTopCompass=")
        hudDotCheck.Checked = getState("HudShow3PVehicleReticle=")
        custRetCheck.Checked = getState("TintModeReticuleStyle=")
        retColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(getState("TintModeReticuleColor=")))
        alphaColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(getState("PlatoonSquadColor0=")))
        bravoColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(getState("PlatoonSquadColor1=")))
        charlieColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(getState("PlatoonSquadColor2=")))
        deltaColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(getState("PlatoonSquadColor3=")))
        NDZColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(getState("NoDeployZoneColor=")))
        OSColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(getState("OrbitalStrikeColor=")))
        If getState("TintModePlayer=") = "0" Then
            playerColorDrop.SelectedIndex = 0
        ElseIf getState("TintModePlayer=") = "1" Then
            playerColorDrop.SelectedIndex = 1
        Else
            playerColorDrop.SelectedIndex = 2
        End If
        If getState("TintModeFacility=") = "0" Then
            facColorDrop.SelectedIndex = 0
        ElseIf getState("TintModeFacility=") = "1" Then
            facColorDrop.SelectedIndex = 1
        Else
            facColorDrop.SelectedIndex = 2
        End If
        If getState("TintModeMap=") = "0" Then
            terrColorDrop.SelectedIndex = 0
        ElseIf getState("TintModeMap=") = "1" Then
            terrColorDrop.SelectedIndex = 1
        Else
            terrColorDrop.SelectedIndex = 2
        End If
    End Function
    Private Sub startLauncher_Click(sender As Object, e As EventArgs) Handles startLauncher.Click
        Process.Start("LaunchPad.exe")
        Console.WriteLine("Starting Launcher")
    End Sub
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        File.WriteAllLines("Useroptions.ini", curini)
        Console.WriteLine("Saved INI")
    End Sub
    Private Sub saveToButton_Click(sender As Object, e As EventArgs) Handles saveToButton.Click
        Dim saveDialog As New SaveFileDialog()
        saveDialog.DefaultExt = "ini"
        saveDialog.AddExtension = True
        saveDialog.InitialDirectory = String.Concat(CurDir, "\Presets")
        Console.WriteLine(String.Concat(CurDir, "\Presets"))
        saveDialog.Filter = "All files (*.*)|*.*"
        If saveDialog.ShowDialog() = DialogResult.OK Then
            File.WriteAllLines(saveDialog.FileName, curini)
        End If
    End Sub
    Private Sub openButton_Click(sender As Object, e As EventArgs) Handles openButton.Click
        Dim openDialog As New OpenFileDialog()
        openDialog.Filter = "Config Files (*.ini)|*.ini"
        openDialog.RestoreDirectory = True
        If openDialog.ShowDialog() = DialogResult.OK Then
            curini = File.ReadAllLines(openDialog.FileName).ToList
            If Not curini.Contains("[iniEdit]") Then
                curini.Insert(0, "[iniEdit]")
            End If
            readAllOptions()
            sensTypeDrop.SelectedIndex = 0
            Dim chosenPreset As List(Of String) = openDialog.FileName.Split("\"c).ToList
            Label62.Text = String.Concat("Currently Editing: ", chosenPreset.Last)
        End If
    End Sub
#Region "GraphicsControls"
#Region "ChecksChanged"
    Private Sub vsyncCheck_CheckedChanged(sender As Object, e As EventArgs) Handles vsyncCheck.Click
        If (vsyncCheck.Checked) Then
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
    Private Sub globRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles globRenDistBox.Validated
        UpdateVal("RenderDistance=", globRenDistBox.Value)
    End Sub
    Private Sub infRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles infRenDistBox.Validated
        UpdateVal("InfantryRenderDistance=", infRenDistBox.Value)
    End Sub
    Private Sub vehRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles vehRenDistbox.Validated
        UpdateVal("GroundVehicleRenderDistance=", vehRenDistbox.Value)
    End Sub
    Private Sub airRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles airRenDistBox.Validated
        UpdateVal("AirVehicleRenderDistance=", airRenDistBox.Value)
    End Sub
    Private Sub fovBox_TextChanged(sender As Object, e As EventArgs) Handles fovBox.Validated
        UpdateVal("VerticalFOV=", fovBox.Value)
    End Sub
    Private Sub renQualBox_TextChanged(sender As Object, e As EventArgs) Handles renQualBox.Validated
        UpdateVal("RenderQuality=", renQualBox.Value)
    End Sub
    Private Sub maxFPSBox_TextChanged(sender As Object, e As EventArgs) Handles maxFPSBox.Validated
        UpdateVal("MaximumFPS=", maxFPSBox.Value)
    End Sub
    Private Sub gammaBox_TextChanged(sender As Object, e As EventArgs) Handles gammaBox.Validated
        UpdateVal("Gamma=", gammaBox.Value)
    End Sub
    Private Sub partDistScaleBox_TextChanged(sender As Object, e As EventArgs) Handles partDistScaleBox.Validated
        UpdateVal("ParticleDistanceScale=", partDistScaleBox.Value)
    End Sub
#End Region
#Region "IndexChanged"
    Private Sub graphQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles graphQualDrop.Validated
        UpdateVal("GraphicsQuality=", graphQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub texQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles texQualDrop.Validated
        UpdateVal("TextureQuality=", texQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub shadQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shadQualDrop.Validated
        UpdateVal("ShadowQuality=", shadQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub lightQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lightQualDrop.Validated
        UpdateVal("LightingQuality=", lightQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub effQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles effQualDrop.Validated
        UpdateVal("EffectsQuality=", effQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub terrQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles terrQualDrop.Validated
        UpdateVal("TerrainQuality=", terrQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub floraQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles floraQualDrop.Validated
        'Flora apparently has 2 lines in separate sections
        UpdateVal("FloraQuality=", floraQualDrop.SelectedItem.ToString.First)
        If floraQualDrop.SelectedIndex() = 3 Then
            UpdateVal("RenderFlora=", "off")
        Else
            UpdateVal("RenderFlora=", "on")
        End If
    End Sub
    Private Sub modQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modQualDrop.Validated
        UpdateVal("ModelQuality=", modQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub partQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles partQualDrop.Validated
        UpdateVal("ParticleLOD=", partQualDrop.SelectedItem.ToString.First)
    End Sub
#End Region
#End Region
#Region "SensStuff"
    Private Sub hipSensBox_TextChanged(sender As Object, e As EventArgs) Handles hipSensBox.Validated
        UpdateVal("MouseSensitivity=", hipSensBox.Value)
        Label39.Text() = String.Concat(hipTurnCalc(DPIBox.Value, hipSensBox.Value), "cm")
    End Sub
    Private Sub adsSensBox_TextChanged(sender As Object, e As EventArgs) Handles adsSensBox.Validated
        UpdateVal("ADSMouseSensitivity=", adsSensBox.Value)
        Label41.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 1.35), "cm")
        Label43.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 2), "cm")
    End Sub
    Private Sub scopSensBox_TextChanged(sender As Object, e As EventArgs) Handles scopSensBox.Validated
        UpdateVal("ScopedMouseSensitivity=", scopSensBox.Value)
        Label37.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 3.4), "cm")
        Label45.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 4), "cm")
        Label44.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 6), "cm")
        Label42.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 8), "cm")
        Label40.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 10), "cm")
        Label38.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 12), "cm")
    End Sub
    Private Sub vehSensBox_TextChanged(sender As Object, e As EventArgs) Handles vehSensBox.Validated
        UpdateVal("VehicleMouseSensitivity=", vehSensBox.Value)
    End Sub
    Private Sub gunSensBox_TextChanged(sender As Object, e As EventArgs) Handles gunSensBox.Validated
        UpdateVal("VehicleGunnerMouseSensitivity=", gunSensBox.Value)
    End Sub
    Private Sub airSensBox_TextChanged(sender As Object, e As EventArgs) Handles airSensBox.Validated
        UpdateVal("FlightMouseSensitivity=", airSensBox.Value)
    End Sub
    Private Sub sensTypeDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sensTypeDrop.SelectedIndexChanged
        'Switch what's visible on sens page
        If sensTypeDrop.SelectedIndex = 0 Then
            showControl(sensPanel1)
            showControl(sensPanel2)
            hideControl(sensPanel3)
            hideControl(sensPanel4)
        Else
            showControl(sensPanel3)
            showControl(sensPanel4)
            hideControl(sensPanel1)
            hideControl(sensPanel2)
        End If
    End Sub
    Private Sub hip360Box_ValueChanged(sender As Object, e As EventArgs) Handles hip360Box.ValueChanged
        Label54.Text() = hipSensCalc(DPIBox.Value, hip360Box.Value)
    End Sub
    Private Sub ads360Box_ValueChanged(sender As Object, e As EventArgs) Handles ads360Box.ValueChanged, adsZoomBox.SelectedValueChanged
        If IsNothing(adsZoomBox.SelectedItem) Then
            Exit Sub
        ElseIf adsZoomBox.SelectedIndex = 0 Then
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, 1.35)
            UpdateVal("ADSMouseSensitivity=", Sens)
            Label55.Text() = Sens
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, adsZoomBox.SelectedItem.ToString.Trim("x"c))
            UpdateVal("ADSMouseSensitivity=", Sens)
            Label55.Text() = Sens
        End If
    End Sub
    Private Sub scop360Box_ValueChanged(sender As Object, e As EventArgs) Handles scop360Box.ValueChanged, scopZoomBox.SelectedValueChanged
        If IsNothing(scopZoomBox.SelectedItem) Then
            Exit Sub
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, scop360Box.Value, scopZoomBox.SelectedItem.ToString.Trim("x"c))
            Console.WriteLine(Sens)
            UpdateVal("ScopedMouseSensitivity=", Sens)
            Label56.Text() = Sens
        End If
    End Sub
    Private Sub recalcSensButton_Click(sender As Object, e As EventArgs) Handles recalcSensButton.Click
        Label39.Text() = String.Concat(hipTurnCalc(DPIBox.Value, hipSensBox.Value), "cm")
        Label41.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 1.35), "cm")
        Label43.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 2), "cm")
        Label37.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 3.4), "cm")
        Label45.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 4), "cm")
        Label44.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 6), "cm")
        Label42.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 8), "cm")
        Label40.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 10), "cm")
        Label38.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 12), "cm")
        Label54.Text() = hipSensCalc(DPIBox.Value, hip360Box.Value)
        If IsNothing(adsZoomBox.SelectedItem) Then
            Console.WriteLine("tweedledee")
        ElseIf adsZoomBox.SelectedIndex = 0 Then
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, 1.35)
            Label55.Text() = Sens
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, adsZoomBox.SelectedItem.ToString.Trim("x"c))
            Label55.Text() = Sens
        End If
        If IsNothing(scopZoomBox.SelectedItem) Then
            Console.WriteLine("tweedledum")
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, scop360Box.Value, scopZoomBox.SelectedItem.ToString.Trim("x"c))
            Console.WriteLine(Sens)
            Label56.Text() = Sens
        End If
    End Sub
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
            UpdateVal("FontFilePath=", fontPath)
            'Create or update batch used to actually replace font
            File.WriteAllText(String.Concat(CurDir(), "\iniEditFont.bat"), String.Concat("@echo off", vbCrLf,
                                                                                            "copy """, fontPath, """ """, CurDir(), "\UI\Resource\Fonts\Geo-Md.ttf""", vbCrLf,
                                                                                            "copy """, fontPath, """ """, CurDir(), "\UI\Resource\Fonts\ARIALUNI.ttf""", vbCrLf,
                                                                                            "exit"))
        End If
    End Sub
    Private Sub fontAutoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles fontAutoCheck.Click
        'If user desires automatic font replacement, create or update task to run the replacement batch
        Using ts As New TaskService()
            If fontAutoCheck.Checked Then
                UpdateVal("FontAutoReplace=", "1")
                If ts.RootFolder.Tasks.Exists("iniEdit Font") Then
                    ts.GetTask(String.Concat(ts.RootFolder, "iniEdit Font")).Enabled = True
                Else
                    Dim td As TaskDefinition = ts.NewTask
                    'Set description for the task
                    td.RegistrationInfo.Description = "iniEdit Font Replacement"
                    'Create eventlog trigger
                    Dim eTrigger As New EventTrigger()
                    eTrigger.Subscription = "<QueryList><Query Id=""0"" Path=""System""><Select Path=""System"">*[System[Provider[@Name='Service Control Manager'] and (Level=4 or Level=0) and (band(Keywords,36028797018963968)) and (EventID=7045)]] and *[EventData[Data[@Name='ServiceName'] and (Data='BEDaisy')]]</Select></Query></QueryList>"
                    td.Triggers.Add(eTrigger)
                    'Create task action
                    Dim path As String = CurDir()
                    td.Actions.Add(New ExecAction(String.Concat(path, "\iniEditFont.bat")))
                    'Save task
                    ts.RootFolder.RegisterTaskDefinition("iniEdit Font", td)
                End If
            Else
                UpdateVal("FontAutoReplace=", "0")
                ts.GetTask(String.Concat(ts.RootFolder, "iniEdit Font")).Enabled = False
            End If
        End Using
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
        If playerColorDrop.SelectedIndex < 2 And IsNothing(playerColorDrop.SelectedItem) = False Then
            UpdateVal("TintModePlayer=", playerColorDrop.SelectedItem.ToString.First)
            hideControl(playerColorPanel)
        ElseIf playerColorDrop.SelectedIndex = 2 And IsNothing(playerColorDrop.SelectedItem) = False Then
            showControl(playerColorPanel)
            If getState("TintModePlayer=") = "0" Or getState("TintModePlayer=") = "1" Then
                UpdateVal("TintModePlayer=", "4460130,19328,10357519")
            End If
            VSplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 1)))
            NCplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 2)))
            TRplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 3)))
        End If
    End Sub
    Private Sub facColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles facColorDrop.SelectedIndexChanged
        If facColorDrop.SelectedIndex < 2 And IsNothing(facColorDrop.SelectedItem) = False Then
            UpdateVal("TintModeFacility=", facColorDrop.SelectedItem.ToString.First)
            hideControl(facColorPanel)
        ElseIf facColorDrop.SelectedIndex = 2 And IsNothing(facColorDrop.SelectedItem) = False Then
            showControl(facColorPanel)
            If getState("TintModeFacility=") = "0" Or getState("TintModeFacility=") = "1" Then
                UpdateVal("TintModeFacility=", "4460130,19328,10357519")
            End If
            VSfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 1)))
            NCfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 2)))
            TRfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 3)))
        End If
    End Sub
    Private Sub terrColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles terrColorDrop.SelectedIndexChanged
        If terrColorDrop.SelectedIndex < 2 And IsNothing(terrColorDrop.SelectedItem) = False Then
            UpdateVal("TintModeMap=", terrColorDrop.SelectedItem.ToString.First)
            hideControl(terrColorPanel)
        ElseIf terrColorDrop.SelectedIndex = 2 And IsNothing(terrColorDrop.SelectedItem) = False Then
            showControl(terrColorPanel)
            If getState("TintModeMap=") = "0" Or getState("TintModeMap=") = "1" Then
                UpdateVal("TintModeMap=", "4460130,19328,10357519")
            End If
            VSterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 1)))
            NCterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 2)))
            TRterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 3)))
        End If
    End Sub
#End Region
#End Region
End Class