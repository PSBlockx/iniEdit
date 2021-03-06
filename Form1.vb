Imports System.IO
Imports Microsoft.Win32.TaskScheduler
Imports System.Text.RegularExpressions
Public Class Form1
    Public Class Arrays
        Public Shared Rendering As Array = {"[Rendering]", "GraphicsQuality=", 1, "TextureQuality=", 1, "ShadowQuality=", 1, "LightingQuality=", 1, "EffectsQuality=", 1, "TerrainQuality=", 1, "FloraQuality=", 1, "ModelQuality=", 1, "RenderDistance", 1000, "Gamma=", 0.5, "VerticalFOV=", 70, "ParticleLOD=", 1, "FogShadowsEnable", 0, "MotionBlur=", 0, "VSync=", 0, "AO=", 0, "MaximumFPS", 500, "UseLod0a=", 0, "BloomEnabed=", 0, "InfantryRenderDistance=", 1000, "GroundVehicleRenderDistance=", 1000, "AirVehicleRenderDistance=", 1000, "UseGlobalRenderDistance=", 1000, "ParticleDistanceScale=", 0.65, "Smoothing=", 0, "UseAspectFOV=", 0, "GpuPhysics=", 0, "ShadowManagerQuality=", "ShadowMapCount=", "ShadowMapQuality=", "ShadowNearDistance=", "ShadowFarDistance=", "ShadowRSM=", "ColorBlindFilterType=", "ColorBlindFilterAmount=", "ColorBlindFilterStrength"}
        Public Shared Display As Array = {"[Display]", "Mode=", "FullscreenMode=", "FullscreenRefresh=", "FullscreenWidth=", "FullscreenHeight=", "WindowedWidth=", "WindowedHeight=", "Maximized=", "RenderQuality=, 1"}
        Public Shared Sound As Array = {"[Sound]", "Master=", 1, "Music=", 1, "Game=", 1, "Dialog=", 1, "UI=", 1, "HitIndicator=", 1, "LowAmmoIndicator=", 1, "VehicleChatter=", 1, "IdleMusic=", 1, "MaxVoices=", 64}
        Public Shared Terrain As Array = {"[Terrain]", "RenderFlora=", "off"}
        Public Shared General As Array = {"[General]", "AutoDetectPerformanceSettings=", 2, "MouseSensitivity=", 0.18, "ScopedMouseSensitivity=", 0.18, "ADSMouseSensitivity=", 0.18, "VehicleMouseSensitivity=", 0.18, "FlightMouseSensitivity=", 0.18, "JoystickSensitivity=", 0.5, "JoystickDeadzone=", 0.1, "InvertVerticalLook=", 0, "InvertVerticalFly=", 0, "InvertTankSteering=", 1, "MouseRawInput=", 1, "MouseSmoothing=", 0, "ToggleCrouch=", 0, "ZoomToggle=", 0, "SprintToggle=", 0, "SprintLegacyToggleMode=", 0, "DrawHud=", 1, "ReduceInputLag=", 0, "FixedMinimap=", 0, "Profanity=", 1, "GamepadSmoothing=", 1, "GamepadInvertLook=", 0, "GamepadInvertFlight=", 0, "GamepadEasyFlight=", 0, "DecloakOnFire=", 0, "AbilityQueueSeconds=", 0, "VehicleGunnerMouseSensitivity=", 0.18}
        Public Shared iniEdit As Array = {"[iniEdit]", "FontAutoReplace=", 0, "FontFilePath="}
        Public Shared UI As Array = {"[UI]", "HudMode=", 1, "HudChatInactiveOpacity=", 0, "HudShowIndicatorNames=", 1, "HudShowAlertTimer=", 1, "ShowReticleIFF=", 1, "HudShowHealth=", 1, "HudShowTopCompass=", 1, "HudShow3PVehicleReticle=", 1, "DrawMission=", 1, "DrawKillSpam=", 1, "DrawLootDrop=", 1, "TintModeReticuleStyle=", 0, "TintModeReticuleColor=", 0, "PlatoonSquadColor0=", 1234, "PlatoonSquadColor1=", 1234, "PlatoonSquadColor2=", 1234, "PlatoonSquadColor3=", 1234, "TintModeFacility=", 1, "TintModePlayer=", 1, "TintModeMap=", 1, "NoDeployZoneColor=", 13369344, "TintModeNoDeploy=", 13369344, "TintModeOrbitalStrike=", 13421568, "OrbitalStrikeColor=", 13421568, "OrbitalStrikeAlpha=", 0.1, "ShowGroupNotifications=", 1, "ShowOutfitNotifications=", 1, "HideWarpZoneConfirmation=", 0, "SelectedChatChannel=", "General", "ChatFontSize=", "MapShowFactionColoredHotspots=", 0, "MapActiveToggleView=", 1, "MapFilterHeatMapMode=", 0, "MapFilterShowInfluenceCloud=", 0, "MapFilterShowGrid=", 0, "MapFilterShowFacilities=", 1, "MapFilterShowTerrain=", 1, "MapFilterShowFacilityLinks=", 1, "MapFilterShowTerritoryControl=", 1, "MapFilterShowResource1=", 1, "MapStatisticsView=", 0, "MapFilterShowHotspots=", 1, "MapCommandsSettingsShow2=", 1, "MapCommandsSettingsShow3=", 1, "MapCommandsSettingsAlpha3=", 1.0, "TrackedDirectives=", "OutfitShowOfflineMembers=", 0, "ShowVRTrainingTutorial=", 1, "ShowDirectivesTutorial=", 1, "ShowMapTutorial=", 1, "ShowImplantTutorial=", 1, "ShowTutorialIslandLandingPage=", 1, "ShowOutfitsTutorial=", 1, "LoadoutInfoInfiltrator=", 1, "LoadoutInfoLightAssault=", 1, "LoadoutInfoMedic=", 1, "LoadoutInfoEngineer=", 1, "LoadoutInfoHeavyAssault=", 1, "LoadoutInfoMax=", 1}
        Public Shared bigOptions As Array = {Rendering, General, Terrain, UI, iniEdit, Display}
    End Class
    Friend Sub Update(ByVal optionName As String, ByVal newVal As String)
        'Read ini into list
        Dim lines As List(Of String) = File.ReadAllLines("Useroptions.ini").ToList
        'Iterate over list looking for line with option
        'If option exists update it
        'If option doesn't exist, find where it goes and add it
        Dim found As Boolean = False
        For index As Integer = 0 To lines.Count - 1
            If lines(index).StartsWith(optionName) Then
                found = True
                lines(index) = String.Concat(optionName, newVal)
            End If
        Next

        If Not found Then
            For Each array In Arrays.bigOptions
                For Each item In array
                    If item.Equals(optionName) Then
                        For index As Integer = 0 To lines.Count - 1
                            If lines(index).ToLower.StartsWith(array(0).ToString.ToLower) Then
                                lines(index) = String.Concat(array(0), vbCrLf, item, newVal)
                                File.WriteAllLines("Useroptions.ini", lines.ToArray)
                                Console.WriteLine(String.Concat("Added ", optionName, " with val ", newVal))
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            Next
        End If
        'Save the updated option back to the file
        File.WriteAllLines("Useroptions.ini", lines.ToArray)
        Console.WriteLine(String.Concat("Updated ", optionName, " to ", newVal))
    End Sub
    Function getState(ByVal optionName As String)
        'Read ini into list
        Dim lines As List(Of String) = File.ReadAllLines("Useroptions.ini").ToList
        'Find specified option and return value of line after = sign
        For index As Integer = 0 To lines.Count - 1
            If lines(index).StartsWith(optionName) Then
                Dim optionVal As Array = lines(index).Split("="c)
                Console.WriteLine("split")
                'doesnt work? If the option doesn't have a value, attempt to set a default
                If IsNothing(optionVal(1)) Then
                    Console.WriteLine("failed")
                    For Each array In Arrays.bigOptions
                        For Each item In array
                            If item.Equals(optionName) Then
                                Dim defaultVal As String = array.IndexOf(array, item) + 1
                                Update(optionName, defaultVal)
                                Console.WriteLine(String.Concat("Defaulted ", optionName, "to ", defaultVal))
                            End If
                        Next
                    Next
                End If
                Console.WriteLine(String.Concat("Got ", optionName, "with ", optionVal(1)))
                Return optionVal(1)
            End If
        Next
    End Function
    Friend Sub ColorUpdate(ByVal optionName As String, ByVal newVal As String, ByVal faction As Integer)
        'Read ini into list
        Dim lines As List(Of String) = File.ReadAllLines("Useroptions.ini").ToList
        'Iterate over list looking for line with option
        'If option exists update it
        'If option doesn't exist, find where it goes and add it
        Dim found As Boolean = False
        For index As Integer = 0 To lines.Count - 1
            If lines(index).StartsWith(optionName) Then
                found = True
                Dim lineList As List(Of String) = lines(index).Split("="c, ","c).ToList
                lineList(faction) = newVal
                lines(index) = String.Concat(optionName, lineList(1), ",", lineList(2), ",", lineList(3))
            End If
        Next

        If Not found Then
            For Each array In Arrays.bigOptions
                For Each item In array
                    If item.Equals(optionName) Then
                        For index As Integer = 0 To lines.Count - 1
                            If lines(index).ToLower.StartsWith(array(0).ToString.ToLower) Then
                                lines(index) = String.Concat(array(0), vbCrLf, item, newVal)
                                File.WriteAllLines("Useroptions.ini", lines.ToArray)
                                Console.WriteLine(String.Concat("Added ", optionName, " with val ", "4460130,19328,10357519"))
                                Exit Sub
                            End If
                        Next
                    End If
                Next
            Next
        End If
        'Save the updated option back to the file
        File.WriteAllLines("Useroptions.ini", lines.ToArray)
        Console.WriteLine(String.Concat("Updated ", optionName, " to ", newVal))
    End Sub
    Function ColorGetState(ByVal optionName As String, ByVal faction As Integer)
        'Read ini into list
        Dim lines As List(Of String) = File.ReadAllLines("Useroptions.ini").ToList
        'Find specified option and return value of line after = sign
        For index As Integer = 0 To lines.Count - 1
            If lines(index).StartsWith(optionName) Then
                Dim optionVal As Array = lines(index).Split("="c, ","c)
                Console.WriteLine("split")
                'doesnt work? If the option doesn't have a value, attempt to set a default
                If IsNothing(optionVal(1)) Then
                    Console.WriteLine("failed")
                    For Each array In Arrays.bigOptions
                        For Each item In array
                            If item.Equals(optionName) Then
                                Dim defaultVal As String = array.IndexOf(array, item) + 1
                                Update(optionName, defaultVal)
                                Console.WriteLine(String.Concat("Defaulted ", optionName, "to ", defaultVal))
                            End If
                        Next
                    Next
                End If
                Console.WriteLine(String.Concat("Got ", optionName, "with ", optionVal(faction)))
                Return optionVal(faction)
            End If
        Next
    End Function
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
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'If ini doesn't already have header for options added by this program, add one
        Dim lines As List(Of String) = File.ReadAllLines("Useroptions.ini").ToList
        If Not lines.Contains("[iniEdit]") Then
            lines.Insert(0, "[iniEdit]")
            File.WriteAllLines("Useroptions.ini", lines.ToArray)
        End If
        'Housekeeping
        readAllOptions()
        sensTypeDrop.SelectedIndex = 0
    End Sub
    Private Sub startLauncher_Click(sender As Object, e As EventArgs) Handles startLauncher.Click
        Process.Start("LaunchPad.exe")
    End Sub
    Private Sub vsyncCheck_CheckedChanged(sender As Object, e As EventArgs) Handles vsyncCheck.Click
        If (vsyncCheck.Checked) Then
            Update("VSync=", 1)
        Else
            Update("VSync=", 0)
        End If
    End Sub
    Private Sub fogShadCheck_CheckedChanged(sender As Object, e As EventArgs) Handles fogShadCheck.Click
        If fogShadCheck.Checked Then
            Update("FogShadowsEnable=", 1)
        Else
            Update("FogShadowsEnable=", 0)
        End If
    End Sub
    Private Sub ambOccCheck_CheckedChanged(sender As Object, e As EventArgs) Handles ambOccCheck.Click
        If ambOccCheck.Checked Then
            Update("AO=", 1)
        Else
            Update("AO=", 0)
        End If
    End Sub
    Private Sub bloomCheck_CheckedChanged(sender As Object, e As EventArgs) Handles bloomCheck.Click
        If bloomCheck.Checked Then
            Update("BloomEnabled=", 1)
        Else
            Update("BloomEnabled=", 0)
        End If
    End Sub
    Private Sub blurCheck_CheckedChanged(sender As Object, e As EventArgs) Handles blurCheck.Click
        If blurCheck.Checked Then
            Update("MotionBlur=", 1)
        Else
            Update("MotionBlur=", 0)
        End If
    End Sub
    Private Sub smoothCheck_CheckedChanged(sender As Object, e As EventArgs) Handles smoothCheck.Click
        If smoothCheck.Checked Then
            Update("Smoothing=", 1)
        Else
            Update("Smoothing=", 0)
        End If
    End Sub
    Private Sub wideCheck_CheckedChanged(sender As Object, e As EventArgs) Handles wideCheck.Click
        If wideCheck.Checked Then
            Update("UseAspectFOV=", 1)
        Else
            Update("UseAspectFOV=", 0)
        End If
    End Sub
    Private Sub useGlobRenCheck_CheckedChanged(sender As Object, e As EventArgs) Handles useGlobRenCheck.Click
        If useGlobRenCheck.Checked Then
            Update("UseGlobalRenderDistance=", 1)
        Else
            Update("UseGlobalRenderDistance=", 0)
        End If
    End Sub
    Private Sub sensRawCheck_CheckedChanged(sender As Object, e As EventArgs) Handles sensRawCheck.Click
        If sensRawCheck.Checked Then
            Update("MouseRawInput=", 1)
        Else
            Update("MouseRawInput=", 0)
        End If
    End Sub
    Private Sub globRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles globRenDistBox.Validated
        Update("RenderDistance=", globRenDistBox.Value)
    End Sub
    Private Sub infRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles infRenDistBox.Validated
        Update("InfantryRenderDistance=", infRenDistBox.Value)
    End Sub
    Private Sub vehRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles vehRenDistbox.Validated
        Update("GroundVehicleRenderDistance=", vehRenDistbox.Value)
    End Sub
    Private Sub airRenDistBox_TextChanged(sender As Object, e As EventArgs) Handles airRenDistBox.Validated
        Update("AirVehicleRenderDistance=", airRenDistBox.Value)
    End Sub
    Private Sub fovBox_TextChanged(sender As Object, e As EventArgs) Handles fovBox.Validated
        Update("VerticalFOV=", fovBox.Value)
    End Sub
    Private Sub renQualBox_TextChanged(sender As Object, e As EventArgs) Handles renQualBox.Validated
        Update("RenderQuality=", renQualBox.Value)
    End Sub
    Private Sub maxFPSBox_TextChanged(sender As Object, e As EventArgs) Handles maxFPSBox.Validated
        Update("MaximumFPS=", maxFPSBox.Value)
    End Sub
    Private Sub gammaBox_TextChanged(sender As Object, e As EventArgs) Handles gammaBox.Validated
        Update("Gamma=", gammaBox.Value)
    End Sub
    Private Sub partDistScaleBox_TextChanged(sender As Object, e As EventArgs) Handles partDistScaleBox.Validated
        Update("ParticleDistanceScale=", partDistScaleBox.Value)
    End Sub
    Private Sub graphQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles graphQualDrop.Validated
        Update("GraphicsQuality=", graphQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub texQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles texQualDrop.Validated
        Update("TextureQuality=", texQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub shadQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles shadQualDrop.Validated
        Update("ShadowQuality=", shadQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub lightQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lightQualDrop.Validated
        Update("LightingQuality=", lightQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub effQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles effQualDrop.Validated
        Update("EffectsQuality=", effQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub terrQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles terrQualDrop.Validated
        Update("TerrainQuality=", terrQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub floraQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles floraQualDrop.Validated
        'Flora apparently has 2 lines in separate sections
        Update("FloraQuality=", floraQualDrop.SelectedItem.ToString.First)
        If floraQualDrop.SelectedIndex() = 3 Then
            Update("RenderFlora=", "off")
        Else
            Update("RenderFlora=", "on")
        End If
    End Sub
    Private Sub modQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles modQualDrop.Validated
        Update("ModelQuality=", modQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub partQualDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles partQualDrop.Validated
        Update("ParticleLOD=", partQualDrop.SelectedItem.ToString.First)
    End Sub
    Private Sub hipSensBox_TextChanged(sender As Object, e As EventArgs) Handles hipSensBox.Validated
        Update("MouseSensitivity=", hipSensBox.Value)
        Label39.Text() = String.Concat(hipTurnCalc(DPIBox.Value, hipSensBox.Value), "cm")
    End Sub
    Private Sub adsSensBox_TextChanged(sender As Object, e As EventArgs) Handles adsSensBox.Validated
        Update("ADSMouseSensitivity=", adsSensBox.Value)
        Label41.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 1.35), "cm")
        Label43.Text() = String.Concat(aimTurncalc(DPIBox.Value, adsSensBox.Value, 2), "cm")
    End Sub
    Private Sub scopSensBox_TextChanged(sender As Object, e As EventArgs) Handles scopSensBox.Validated
        Update("ScopedMouseSensitivity=", scopSensBox.Value)
        Label37.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 3.4), "cm")
        Label45.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 4), "cm")
        Label44.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 6), "cm")
        Label42.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 8), "cm")
        Label40.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 10), "cm")
        Label38.Text() = String.Concat(aimTurncalc(DPIBox.Value, scopSensBox.Value, 12), "cm")
    End Sub
    Private Sub vehSensBox_TextChanged(sender As Object, e As EventArgs) Handles vehSensBox.Validated
        Update("VehicleMouseSensitivity=", vehSensBox.Value)
    End Sub
    Private Sub gunSensBox_TextChanged(sender As Object, e As EventArgs) Handles gunSensBox.Validated
        Update("VehicleGunnerMouseSensitivity=", gunSensBox.Value)
    End Sub
    Private Sub airSensBox_TextChanged(sender As Object, e As EventArgs) Handles airSensBox.Validated
        Update("FlightMouseSensitivity=", airSensBox.Value)
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
            Update("ADSMouseSensitivity=", Sens)
            Label55.Text() = Sens
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, ads360Box.Value, adsZoomBox.SelectedItem.ToString.Trim("x"c))
            Update("ADSMouseSensitivity=", Sens)
            Label55.Text() = Sens
        End If
    End Sub
    Private Sub scop360Box_ValueChanged(sender As Object, e As EventArgs) Handles scop360Box.ValueChanged, scopZoomBox.SelectedValueChanged
        If IsNothing(scopZoomBox.SelectedItem) Then
            Exit Sub
        Else
            Dim Sens As String = aimSensCalc(DPIBox.Value, scop360Box.Value, scopZoomBox.SelectedItem.ToString.Trim("x"c))
            Console.WriteLine(Sens)
            Update("ScopedMouseSensitivity=", Sens)
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
    Private Sub fontSelectButton_Click(sender As Object, e As EventArgs) Handles fontSelectButton.Click
        Dim fontPath As String = Nothing
        Dim fontDialog As New OpenFileDialog()

        fontDialog.Filter = "TrueType Font files (*.ttf)|*.ttf"
        fontDialog.RestoreDirectory = True

        If fontDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            'Using a dialog, get the desired font file path
            fontPath = fontDialog.FileName.ToString
            'Show user selected font path
            selectedFontPath.Text() = fontPath
            Update("FontFilePath=", fontPath)
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
                Update("FontAutoReplace=", "1")
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
                Update("FontAutoReplace=", "0")
                ts.GetTask(String.Concat(ts.RootFolder, "iniEdit Font")).Enabled = False
            End If
        End Using

    End Sub
    Private Sub hudHPCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudHPCheck.Click
        If hudHPCheck.Checked Then
            Update("HudShowHealth=", 1)
        Else
            Update("HudShowHealth=", 0)
        End If
    End Sub
    Private Sub hudIndCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudIndCheck.Click
        If hudIndCheck.Checked Then
            Update("HudShowIndicatorNames=", 1)
        Else
            Update("HudShowIndicatorNames=", 0)
        End If
    End Sub
    Private Sub hudAlertCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudAlertCheck.Click
        If hudAlertCheck.Checked Then
            Update("HudShowAlertTimer=", 1)
        Else
            Update("HudShowAlertTimer=", 0)
        End If
    End Sub
    Private Sub hudSpamCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudSpamCheck.Click
        If hudSpamCheck.Checked Then
            Update("DrawKillSpam=", 1)
        Else
            Update("DrawKillSpam=", 0)
        End If
    End Sub
    Private Sub hudLootCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudLootCheck.Click
        If hudLootCheck.Checked Then
            Update("DrawLootDrop=", 1)
        Else
            Update("DrawLootDrop=", 0)
        End If
    End Sub
    Private Sub hudCompCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudCompCheck.Click
        If hudCompCheck.Checked Then
            Update("HudShowTopCompass=", 1)
        Else
            Update("HudShowTopCompass=", 0)
        End If
    End Sub
    Private Sub hudDotCheck_CheckedChanged(sender As Object, e As EventArgs) Handles hudDotCheck.Click
        If hudDotCheck.Checked Then
            Update("HudShow3PVehicleReticle=", 1)
        Else
            Update("HudShow3PVehicleReticle=", 0)
        End If
    End Sub
    Private Sub custRetCheck_CheckedChanged(sender As Object, e As EventArgs) Handles custRetCheck.Click
        If custRetCheck.Checked Then
            Update("TintModeReticuleStyle=", 1)
        Else
            Update("TintModeReticuleStyle=", 0)
        End If
    End Sub

    Private Sub retColorButton_Click(sender As Object, e As EventArgs) Handles retColorButton.Click
        Dim chosenColor As Color = colorGetter()
        retColorButton.BackColor = chosenColor
        Update("TintModeReticuleColor=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub alphaColorButton_Click(sender As Object, e As EventArgs) Handles alphaColorButton.Click
        Dim chosenColor As Color = colorGetter()
        alphaColorButton.BackColor = chosenColor
        Update("PlatoonSquadColor0=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub bravoColorButton_Click(sender As Object, e As EventArgs) Handles bravoColorButton.Click
        Dim chosenColor As Color = colorGetter()
        bravoColorButton.BackColor = chosenColor
        Update("PlatoonSquadColor1=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub charlieColorButton_Click(sender As Object, e As EventArgs) Handles charlieColorButton.Click
        Dim chosenColor As Color = colorGetter()
        charlieColorButton.BackColor = chosenColor
        Update("PlatoonSquadColor2=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub deltaColorButton_Click(sender As Object, e As EventArgs) Handles deltaColorButton.Click
        Dim chosenColor As Color = colorGetter()
        deltaColorButton.BackColor = chosenColor
        Update("PlatoonSquadColor3=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub NDZColorButton_Click(sender As Object, e As EventArgs) Handles NDZColorButton.Click
        Dim chosenColor As Color = colorGetter()
        NDZColorButton.BackColor = chosenColor
        Update("NoDeployZoneColor=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
        Update("TintModeNoDeploy=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub OSColorButton_Click(sender As Object, e As EventArgs) Handles OSColorButton.Click
        Dim chosenColor As Color = colorGetter()
        OSColorButton.BackColor = chosenColor
        Update("TintModeOrbitalStrike=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
        Update("OrbitalStrikeColor=", colorDecimalSwap(ColorTranslator.ToOle(chosenColor)))
    End Sub
    Private Sub playerColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles playerColorDrop.SelectedIndexChanged
        If playerColorDrop.SelectedIndex < 2 And IsNothing(playerColorDrop.SelectedItem) = False Then
            Update("TintModePlayer=", playerColorDrop.SelectedItem.ToString.First)
            hideControl(playerColorPanel)
        ElseIf playerColorDrop.SelectedIndex = 2 And IsNothing(playerColorDrop.SelectedItem) = False Then
            showControl(playerColorPanel)
            If getState("TintModePlayer=") = "0" Or getState("TintModePlayer=") = "1" Then
                Update("TintModePlayer=", "4460130,19328,10357519")
            End If
            VSplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 1)))
            NCplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 2)))
            TRplayerColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModePlayer=", 3)))
        End If
    End Sub
    Private Sub facColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles facColorDrop.SelectedIndexChanged
        If facColorDrop.SelectedIndex < 2 And IsNothing(facColorDrop.SelectedItem) = False Then
            Update("TintModeFacility=", facColorDrop.SelectedItem.ToString.First)
            hideControl(facColorPanel)
        ElseIf facColorDrop.SelectedIndex = 2 And IsNothing(facColorDrop.SelectedItem) = False Then
            showControl(facColorPanel)
            If getState("TintModeFacility=") = "0" Or getState("TintModeFacility=") = "1" Then
                Update("TintModeFacility=", "4460130,19328,10357519")
            End If
            VSfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 1)))
            NCfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 2)))
            TRfacColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeFacility=", 3)))
        End If
    End Sub
    Private Sub terrColorDrop_SelectedIndexChanged(sender As Object, e As EventArgs) Handles terrColorDrop.SelectedIndexChanged
        If terrColorDrop.SelectedIndex < 2 And IsNothing(terrColorDrop.SelectedItem) = False Then
            Update("TintModeMap=", terrColorDrop.SelectedItem.ToString.First)
            hideControl(terrColorPanel)
        ElseIf terrColorDrop.SelectedIndex = 2 And IsNothing(terrColorDrop.SelectedItem) = False Then
            showControl(terrColorPanel)
            If getState("TintModeMap=") = "0" Or getState("TintModeMap=") = "1" Then
                Update("TintModeMap=", "4460130,19328,10357519")
            End If
            VSterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 1)))
            NCterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 2)))
            TRterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 3)))
        End If
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
End Class