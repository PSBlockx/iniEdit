Imports System.IO
Imports Microsoft.Win32.TaskScheduler
Imports System.Text.RegularExpressions
Imports System.Security.Cryptography.X509Certificates
Imports System.Runtime.Remoting.Messaging
Imports System.ComponentModel
Imports System.Windows.Forms.VisualStyles
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Window
Imports System.Data.SqlTypes

Public Class Form1
    Public Class Lists
        Public Shared Rendering As New List(Of String)({"[Rendering]", "GraphicsQuality=", "TextureQuality=", "ShadowQuality=", "LightingQuality=", "EffectsQuality=", "TerrainQuality=", "FloraQuality=", "ModelQuality=", "RenderDistance=", "Gamma=", "VerticalFOV=", "ParticleLOD=", "FogShadowsEnable", "MotionBlur=", "VSync=", "AO=", "MaximumFPS", "UseLod0a=", "BloomEnabed=", "InfantryRenderDistance=", "GroundVehicleRenderDistance=", "AirVehicleRenderDistance=", "UseGlobalRenderDistance=", "ParticleDistanceScale=", "Smoothing=", "UseAspectFOV=", "GpuPhysics=", "ShadowManagerQuality=", "ShadowMapCount=", "ShadowMapQuality=", "ShadowNearDistance=", "ShadowFarDistance=", "ShadowRSM=", "ColorBlindFilterType=", "ColorBlindFilterAmount=", "ColorBlindFilterStrength", "OverallQuality=", "FSRQuality=", "FSRSharpness=", "DLSSQuality=", "DLSSSharpness=", "UseFences=", "AAQuality=", "SmoothingMaxFramerate=", "SmoothingMinFramerate=", "UnderwaterGodRaysQuality=", "SSLRQuality=", "Tessellation=", "WaterQuality="})
        Public Shared Display As New List(Of String)({"[Display]", "Mode=", "FullscreenMode=", "FullscreenRefresh=", "FullscreenWidth=", "FullscreenHeight=", "WindowedWidth=", "WindowedHeight=", "Maximized=", "RenderQuality=", "AllowToggleUI="})
        Public Shared Sound As New List(Of String)({"[Sound]", "Master=", "Music=", "Game=", "Dialog=", "UI=", "HitIndicator=", "LowAmmoIndicator=", "VehicleChatter=", "IdleMusic=", "MaxVoices=", "UseFloat32Output=", "ExclusiveMode=", "UseHighQualityReverb="})
        Public Shared Terrain As New List(Of String)({"[Terrain]", "RenderFlora="})
        Public Shared General As New List(Of String)({"[General]", "AutoDetectPerformanceSettings=", "MouseSensitivity=", "ScopedMouseSensitivity=", "ADSMouseSensitivity=", "VehicleMouseSensitivity=", "FlightMouseSensitivity=", "JoystickSensitivity=", "JoystickDeadzone=", "InvertVerticalLook=", "InvertVerticalFly=", "InvertTankSteering=", "MouseRawInput=", "MouseSmoothing=", "ToggleCrouch=", "ZoomToggle=", "SprintToggle=", "SprintLegacyToggleMode=", "DrawHud=", "ReduceInputLag=", "FixedMinimap=", "Profanity=", "GamepadSmoothing=", "GamepadInvertLook=", "GamepadInvertFlight=", "GamepadEasyFlight=", "DecloakOnFire=", "AbilityQueueSeconds=", "VehicleGunnerMouseSensitivity="})
        Public Shared iniEdit As New List(Of String)({"[iniEdit]", "FontAutoReplace=", "FontFilePath="})
        Public Shared UI As New List(Of String)({"[UI]", "CentralizedHudMode=", "HudChatInactiveOpacity=", "HudShowIndicatorNames=", "HudShowAlertTimer=", "ShowReticleIFF=", "HudShowHealth=", "HudShowTopCompass=", "HudShow3PVehicleReticle=", "DrawMission=", "DrawKillSpam=", "DrawLootDrop=", "TintModeReticuleStyle=", "TintModeReticuleColor=", "PlatoonSquadColor0=", 1234, "PlatoonSquadColor1=", 1234, "PlatoonSquadColor2=", 1234, "PlatoonSquadColor3=", 1234, "TintModeFacility=", "TintModePlayer=", "TintModeMap=", "NoDeployZoneColor=", 13369344, "OrbitalStrikeColor=", 13421568, "OrbitalStrikeAlpha=", "ShowGroupNotifications=", "ShowOutfitNotifications=", "HideWarpZoneConfirmation=", "SelectedChatChannel=", "ChatFontSize=", "MapShowFactionColoredHotspots=", "MapActiveToggleView=", "MapFilterHeatMapMode=", "MapFilterShowInfluenceCloud=", "MapFilterShowGrid=", "MapFilterShowFacilities=", "MapFilterShowTerrain=", "MapFilterShowFacilityLinks=", "MapFilterShowTerritoryControl=", "MapFilterShowResource1=", "MapStatisticsView=", "MapFilterShowHotspots=", "MapCommandsSettingsShow2=", "MapCommandsSettingsShow3=", "MapCommandsSettingsAlpha3=", "TrackedDirectives=", "OutfitShowOfflineMembers=", "ShowVRTrainingTutorial=", "ShowDirectivesTutorial=", "ShowMapTutorial=", "ShowImplantTutorial=", "ShowTutorialIslandLandingPage=", "ShowOutfitsTutorial=", "LoadoutInfoInfiltrator=", "LoadoutInfoLightAssault=", "LoadoutInfoMedic=", "LoadoutInfoEngineer=", "LoadoutInfoHeavyAssault=", "LoadoutInfoMax=", "HiddenHUDIndicators=", "HideReticule=", "HudChatOpacity=", "ConstructionFavorites="})
        Public Shared AutoRefuse As New List(Of String)({"[AutoRefuse]", "FriendInvitation=", "DuelInvitation=", "GuildInvitation=", "HideUi=", "TradeRequest=", "HousingInvitation=", "GroupInvitation=", "SwapSeatRequest=", "Whispers="})
        Public Shared ChatChannels As New List(Of String)({"[DisableChatChannelOptions]", "Squad=", "Platoon=", "Fireteam=", "Leader=", "Proximity=", "Outfit=", "Yell=", "Region=", "Mentor=", "Social="})
        Public Shared Voice As New List(Of String)({"[Voice]", "Enable=", "ReceiveVolume=", "OutfitVolume=", "SquadVolume=", "RaidVolume=", "ProximityVolume=", "MicrophoneVolume=", "Ducking=", "EchoEnabled=", "ProximityEnabled=", "FactionEnabled=", "GroupEnabled=", "GroupLeaderEnabled=", "RaidEnabled=", "GuildEnabled=", "RadioEnabled=", "CBEnabled=", "CustomEnabled=", "SubGroupEnabled=", "MuteInactiveChannels=", "PushToTalk="})
        Public Shared Controls As New List(Of String)({"[Controls]", "CameraAutoAdjustment=", "ClickToMove=", "ClickToMoveRightButton=", "InfantryActionSetName=", "GroundVehicleSetName=", "AirVehicleActionSetName=", "Rumble=", "RailCamera="})
        Public Shared Group As New List(Of String)({"[Group]", "AutoGroupOnLoginNew=", "AutoGroupAsLeaderNew=", "AutoGroupWithFriendsNew=", "AutoGroupWithGuildNew=", "AutoGroupOnLogin=", "AutoGroupAsLeader=", "AutoGroupwithFriends=", "AutoGroupWithGuild="})
        Public Shared Guild As New List(Of String)({"[Guild]", "NotifyOnGuildPetitionRecieved="})
        Public Shared Chat As New List(Of String)({"[Chat]", "HudChatInactiveOpacity=", "CanShowHudChat="})
        Public Shared VoiceChat As New List(Of String)({"[VoiceChat]", "EchoEnabled=", "EchoVolume=", "ProximityEnabled=", "ProximityVolume=", "FactionEnabled=", "FactionVolume=", "GroupEnabled=", "GroupVolume=", "GroupLeaderEnabled=", "GroupLeaderVolume=", "RaidEnabled=", "RaidVolume=", "CBEnabled=", "CBVolume=", "CustomEnabled=", "CustomVolume=", "SubGroupEnabled=", "SubGroupVolume=", "InputDevice=", "OutputDevice="})
        'Options below this comment are not currently, or may have never been used, but are listed here anyway
        'Public Shared Social As New List(Of String)({"[Social]", "FriendNotifications="})
        'Public Shared MinimapOptions As New List(Of String)({"[MinimapOptions]", "PathEnabled="})
        'Public Shared Emote As New List(Of String)({"[Emote]", "Favorites="})
        'Public Shared Logging As New List(Of String)({"[Logging]", "Directory=", "EnableDebugOutputString=", "LocalLogLevel=", "FileLogLevel=", "ServerLogLevel=", "OutputWindowLevel=", "LocalDirectory=", "FailureDirectory="})
        'Public Shared UiDebug As New List(Of String)({"[UiDebug]", "WatchedColumns="})
        'Public Shared CrashReporter As New List(Of String)({"[CrashReporter]", "MaxParameters=", "MaxUploaderPerDay=", "MaxUploadSec=", "MaxCrashAge=", "NoUploadFromInit=", "LocalFullDump=", "IncludeIndirectMemory=", "WaitForAttach=", "PipeCrashUploaderConsole="})
        'Public Shared CrashUploader As New List(Of String)({"[CrashUploader]", "MaxPerDay=", "WaitForAttach=", "WriteResultsOnFailure="})
        'Public Shared Promotion As New List(Of String)({"[Promotion]", "HasntOptedIn="})
        'Public Shared Video As New List(Of String)({"[Video]", "VideoCapturePrefix="})
        'Public Shared ImageCapture As New List(Of String)({"[ImageCapture]", "OutputFolder=", "OutputFilePrefix="})
        'Public Shared VideoCapture As New List(Of String)({"[VideoCapture]", "Resolution=", "Quality=", "OutputFile=", "WorkingDir="})
        'Public Shared VideoStreamer As New List(Of String)({"[VideoStreamer]", "Resolution=", "Fps=", "Kbps=", "MicRecordVolume=", "SpeakerRecordVolume=", "Username="})
        'Public Shared Umbra As New List(Of String)({"[Umbra]", "Cull=", "TomeCollection="})
        'Public Shared Graphics As New List(Of String)({"[Graphics]", "WindowWidth=", "WindowHeight="})


        Public Shared bigOptions As Array = {Rendering, General, Terrain, UI, Sound, ChatChannels, Voice, VoiceChat, iniEdit, Display}
    End Class
    Public Shared curini As List(Of String) = Nothing
    Public Shared curiniPath As String = "Useroptions.ini"
    Public Shared doneLoading As Boolean = False

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Read ini into previously initialized empty list
        curini = File.ReadAllLines("Useroptions.ini").ToList
        'If ini doesn't already have header for options added by this program, add one at the top
        If Not curini.Contains("[iniEdit]") Then
            curini.Insert(0, "[iniEdit]")
        End If
        'Housekeeping
        readAllOptions()
        sensTypeDrop.SelectedIndex = 0
        curEditLabel.Text = String.Concat("Currently Editing: ", curiniPath)
        doneLoading = True
    End Sub
#Region "UpdatesAndGets"
    Public Sub UpdateVal(ByVal optionName As String, ByVal newVal As String)
        'Reads the ini line by line for the specified option
        'If option isn't found, run through option arrays for option and insert a line for the correct category
        If Not doneLoading Then
            Exit Sub
        End If
        Dim found As Boolean = False
        For index As Integer = 0 To curini.Count - 1
            If curini(index).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                curini(index) = optionName & newVal
                Console.WriteLine($"Updated {optionName} to {newVal}")
            End If
        Next
        If Not found Then
            For Each list As List(Of String) In Lists.bigOptions
                If list.Contains(optionName) Then
                    For Each line In curini
                        If line.StartsWith(list(0), StringComparison.OrdinalIgnoreCase) Then
                            curini.Insert(curini.IndexOf(line) + 1, optionName & newVal)
                            Console.WriteLine($"Added {optionName} with val {newVal}")
                            Exit Sub
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    Public Sub UpdateValSpecific(ByVal optionName As String, ByVal newVal As String, ByVal optionGroup As String)
        'Voice options are stupid
        If Not doneLoading Then
            Exit Sub
        End If
        Dim found As Boolean = False
        Dim optionIndexes = New ArrayList()
        For Each line In curini
            If line.StartsWith("[") Then
                optionIndexes.Add(line)
                optionIndexes.Add(curini.IndexOf(line))
            End If
        Next
        Dim optionGroupIndex As Integer = optionIndexes(optionIndexes.IndexOf(optionGroup) + 1)
        Dim optionGroupNextIndex As Integer = optionIndexes(optionIndexes.IndexOf(optionGroup) + 3)
        For ctr As Integer = optionGroupIndex To optionGroupNextIndex
            If curini(ctr).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                curini(ctr) = optionName & newVal
                Console.WriteLine($"Updated {optionName} to {newVal}")
            End If
        Next
        If Not found Then
            curini.Insert(curini(optionGroupIndex + 1), optionName & newVal)
            Console.WriteLine($"Added {optionName} with val {newVal}")
        End If
    End Sub
    Function GetState(ByVal optionName As String)
        'Find the line which has the desired option, and return the value after the = sign
        For Each line In curini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = line.Split("="c)
                Console.WriteLine($"Got {optionName} with {optionVal(1)}")
                Return optionVal(1)
            End If
        Next
    End Function
    Function GetStateSpecific(ByVal optionName As String, ByVal optionGroup As String)
        'Voice options are stupid
        Dim optionIndexes = New ArrayList()
        For Each line In curini
            If line.StartsWith("[") Then
                optionIndexes.Add(line)
                optionIndexes.Add(curini.IndexOf(line))
            End If
        Next
        Dim optionGroupIndex As Integer = optionIndexes(optionIndexes.IndexOf(optionGroup) + 1)
        Dim optionGroupNextIndex As Integer = optionIndexes(optionIndexes.IndexOf(optionGroup) + 3)
        For ctr As Integer = optionGroupIndex To optionGroupNextIndex
            If curini(ctr).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = curini(ctr).Split("="c)
                Console.WriteLine($"Got {optionName} with {optionVal(1)} under {optionGroup}")
                Return optionVal(1)
            End If
        Next
    End Function
    Public Sub ColorUpdate(ByVal optionName As String, ByVal newVal As String, ByVal faction As Integer)
        'Specialized update function for color options with multiple values separated by commas, could be used for other options with multiple values
        If Not doneLoading Then
            Exit Sub
        End If
        Dim found As Boolean = False
        For index As Integer = 0 To curini.Count - 1
            If curini(index).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                Dim lineList As List(Of String) = curini(index).Split("="c, ","c).ToList
                lineList(faction) = newVal
                curini(index) = optionName & lineList(1) & lineList(2) & lineList(3)
            End If
        Next
        Console.WriteLine($"Updated {optionName} to {newVal}")
        If Not found Then
            For Each list As List(Of String) In Lists.bigOptions
                If list.Contains(optionName) Then
                    For Each line In curini
                        If line.StartsWith(list(0), StringComparison.OrdinalIgnoreCase) Then
                            curini.Insert(curini.IndexOf(line) + 1, optionName & newVal)
                            Console.WriteLine($"Added {optionName} with val {newVal}")
                            Exit Sub
                        End If
                    Next
                End If
            Next
        End If
    End Sub
    Function ColorGetState(ByVal optionName As String, ByVal faction As Integer)
        'Specialized getState for options with multiple values separated by commas
        For Each line In curini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As Array = line.Split("="c, ","c)
                Console.WriteLine($"Got {optionName} with {optionVal(faction)}")
                Return optionVal(faction)
            End If
        Next
    End Function
    Function GetStateContains(ByVal optionName As String, ByVal findVal As String)
        For Each line In curini
            If line.StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                Dim optionVal As List(Of String) = line.Split("="c, ","c).ToList
                Return optionVal.Contains(findVal)
            End If
        Next
    End Function
    Public Sub UpdateValContains(ByVal optionName As String, ByVal newVal As String, ByVal addremove As Boolean)
        If Not doneLoading Then
            Exit Sub
        End If
        Dim found As Boolean = False
        For index As Integer = 0 To curini.Count - 1
            If curini(index).StartsWith(optionName, StringComparison.OrdinalIgnoreCase) Then
                found = True
                Console.WriteLine(curini(index))
                Dim lineList As List(Of String) = curini(index).Split("="c, ","c).ToList
                lineList.RemoveAll(Function(str) String.IsNullOrEmpty(str))
                If lineList.Contains(newVal) And addremove = True Then
                    Console.WriteLine("option already in list")
                    Exit Sub
                ElseIf Not lineList.Contains(newVal) And addremove = False Then
                    Console.WriteLine("option already not in list")
                    Exit Sub
                ElseIf lineList.Contains(newVal) And addremove = False Then
                    Console.WriteLine("option removed from list")
                    lineList.Remove(newVal)
                ElseIf Not lineList.Contains(newVal) And addremove = True Then
                    Console.WriteLine("option added to list")
                    lineList.Add(newVal)
                End If
                Dim newLine As String
                For index2 As Integer = 0 To lineList.Count - 1
                    If index2 = 0 Then
                        newLine = lineList(index2) + "="
                    ElseIf index2 = lineList.Count - 1 Then
                        newLine = newLine + lineList(index2)
                    Else
                        newLine = newLine + lineList(index2) + ","
                    End If
                Next
                curini(index) = newLine
                Console.WriteLine(curini(index))
            End If
        Next
        Console.WriteLine($"Updated {optionName} to {newVal}")
        If Not found Then
            For Each list As List(Of String) In Lists.bigOptions
                If list.Contains(optionName) Then
                    For Each line In curini
                        If line.StartsWith(list(0), StringComparison.OrdinalIgnoreCase) Then
                            curini.Insert(curini.IndexOf(line) + 1, optionName & newVal)
                            Console.WriteLine($"Added {optionName} with val {newVal}")
                            Exit Sub
                        End If
                    Next
                End If
            Next
        End If
    End Sub
#End Region
#Region "MiscFuncs"
    Function colorGetter()
        'Opens Windows color picker and returns user-chosen color
        'Value needs to be in BGR format, and is converted before use in update function
        Dim chosenColor = Nothing
        Dim colorDialog As New ColorDialog()
        If colorDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            chosenColor = colorDialog.Color
        End If
        Return chosenColor
    End Function
    Function colorDecimalSwap(ByVal color As Integer)
        'Math-y way of bit swapping RGB<>BGR and vice versa from decimal color values
        Dim Channel1 As Integer = color \ 65536
        Dim Channel2 As Integer = (color - Channel1 * 65536) \ 256
        Dim Channel3 As Integer = color - (Channel1 * 65536 + Channel2 * 256)
        Dim Result As Integer = Channel1 + Channel2 * 256 + Channel3 * 65536
        Return Result
    End Function
#Region "AimCalcs"
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
#End Region
#End Region
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
        shadQualDrop.SelectedIndex = Integer.Parse(GetState("ShadowQuality="))
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
#End Region
#Region "SensGets"
        hipSensBox.Value = GetState("MouseSensitivity=")
        adsSensBox.Value = GetState("ADSMouseSensitivity=")
        scopSensBox.Value = GetState("ScopedMouseSensitivity=")
        vehSensBox.Value = GetState("VehicleMouseSensitivity=")
        gunSensBox.Value = GetState("VehicleGunnerMouseSensitivity=")
        airSensBox.Value = GetState("FlightMouseSensitivity=")
        sensRawCheck.Checked = GetState("MouseRawInput=")
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
        alphaColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("PlatoonSquadColor0=")))
        bravoColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("PlatoonSquadColor1=")))
        charlieColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("PlatoonSquadColor2=")))
        deltaColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("PlatoonSquadColor3=")))
        NDZColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("NoDeployZoneColor=")))
        OSColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(GetState("OrbitalStrikeColor=")))
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
            facColorPanelButtons.Visible = True
        End If
        If GetState("TintModeMap=") = "0" Then
            terrColorDrop.SelectedIndex = 0
        ElseIf GetState("TintModeMap=") = "1" Then
            terrColorDrop.SelectedIndex = 1
        Else
            terrColorDrop.SelectedIndex = 2
            terrColorPanelButtons.Visible = True
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
#End Region
#Region "iniEditGets"
        fontAutoCheck.Checked = GetState("FontAutoReplace=")
        selectedFontPath.Text = GetState("FontFilePath=")
#End Region
#Region "HudIndGets"
#Region "Infantry"
        iconsInfantryAllyCheck = GetStateContains("HiddenHUDIndicators=", 84)
        iconsInfantryEnemyCheck = GetStateContains("HiddenHUDIndicators=", 85)
        If iconsInfantryAllyCheck.Checked And iconsInfantryEnemyCheck.Checked Then
            iconsInfantryGroupCheck.Checked = True
        Else
            iconsInfantryGroupCheck.Checked = False
        End If

#End Region
#Region "Vehicle"
        iconsVehAllyCheck = GetStateContains("HiddenHUDIndicators=", 86)
        iconsVehEnemyCheck = GetStateContains("HiddenHUDIndicators=", 87)
        iconsVehBastionCheck = GetStateContains("HiddenHUDIndicators=", 62)
        If iconsVehAllyCheck.Checked And
                iconsVehEnemyCheck.Checked And
                iconsVehBastionCheck.Checked Then
            iconsVehicleGroupCheck.Checked = True
        Else
            iconsVehicleGroupCheck.Checked = False
        End If
#End Region
#Region "Deployables"
        iconsDepDMGNadeCheck = GetStateContains("HiddenHUDIndicators=", 3)
        iconsDepStatusNadeCheck = GetStateContains("HiddenHUDIndicators=", 82)
        iconsDepMinesCheck = GetStateContains("HiddenHUDIndicators=", 34)
        iconsDepC4Check = GetStateContains("HiddenHUDIndicators=", 10)
        iconsDepShieldRegenCheck = GetStateContains("HiddenHUDIndicators=", 38)
        iconsDepDildarCheck = GetStateContains("HiddenHUDIndicators=", 39)
        iconsDepAmmoBoxCheck = GetStateContains("HiddenHUDIndicators=", 33)
        iconsDepDroneCheck = GetStateContains("HiddenHUDIndicators=", 65)
        iconsDepTurretsCheck = GetStateContains("HiddenHUDIndicators=", 88)
#End Region
#Region "World"
        iconsWorldGroupCheck = GetStateContains("HiddenHUDIndicators=",)
        iconsWorldAnomalyCheck = GetStateContains("HiddenHUDIndicators=", 49)
        iconsWorldDrillCheck = GetStateContains("HiddenHUDIndicators=", 53)
        iconsWorldBuoyCheck = GetStateContains("HiddenHUDIndicators=", 58)
        iconsWorldMissionCheck = GetStateContains("HiddenHUDIndicators=", 68)
        iconsWorldImplantCheck = GetStateContains("HiddenHUDIndicators=", 67)
        iconsWorldPlantCheck = GetStateContains("HiddenHUDIndicators=", 71)
        iconsWorldNPCCheck = GetStateContains("HiddenHUDIndicators=", 79)
        iconsWorldStationCheck = GetStateContains("HiddenHUDIndicators=", 44)
        iconsWorldAssetCheck = GetStateContains("HiddenHUDIndicators=", 63)
        iconsWorldCrystalCheck = GetStateContains("HiddenHUDIndicators=", 43)
        iconsWorldConstructionCheck = GetStateContains("HiddenHUDIndicators=", 117)
        iconsWorldCortiumCheck = GetStateContains("HiddenHUDIndicators=", 116)
#End Region
#Region "Facility"
        iconsFacilityGroupCheck = GetStateContains("HiddenHUDIndicators=",)
        iconsFacVehAmmoCheck = GetStateContains("HiddenHUDIndicators=", 11)
        iconsFacAirAmmoCheck = GetStateContains("HiddenHUDIndicators=", 18)
        iconsFacEquipTermCheck = GetStateContains("HiddenHUDIndicators=", 7)
        iconsFacWGTermCheck = GetStateContains("HiddenHUDIndicators=", 26)
        iconsFacAirTermCheck = GetStateContains("HiddenHUDIndicators=", 4)
        iconsFacVehTermCheck = GetStateContains("HiddenHUDIndicators=", 5)
        iconsFacGalTermCheck = GetStateContains("HiddenHUDIndicators=", 6)
        iconsFacFlashTermCheck = GetStateContains("HiddenHUDIndicators=", 15)
        iconsFacLightTermCheck = GetStateContains("HiddenHUDIndicators=", 20)
        iconsFacBusTermCheck = GetStateContains("HiddenHUDIndicators=", 115)
        iconsFacTeleCheck = GetStateContains("HiddenHUDIndicators=", 13)
        iconsFacPointCheck = GetStateContains("HiddenHUDIndicators=", 2)
        iconsFacOWPointsCheck = GetStateContains("HiddenHUDIndicators=", 61)
        iconsFacNearbyCheck = GetStateContains("HiddenHUDIndicators=", 83)
        iconsFacSCUCheck = GetStateContains("HiddenHUDIndicators=", 17)
        iconsFacHorzCheck = GetStateContains("HiddenHUDIndicators=", 22)
        iconsFacVertCheck = GetStateContains("HiddenHUDIndicators=", 23)
        iconsFacVehShieldCheck = GetStateContains("HiddenHUDIndicators=", 24)
        iconsFacSCUShieldCheck = GetStateContains("HiddenHUDIndicators=", 25)
        iconsFacForwardCheck = GetStateContains("HiddenHUDIndicators=", 27)
        iconsFacBridgeTermCheck = GetStateContains("HiddenHUDIndicators=", 35)
        iconsFacSCUAttackCheck = GetStateContains("HiddenHUDIndicators=", 75)
        iconsFacGateAttackCheck = GetStateContains("HiddenHUDIndicators=", 76)
        iconsFacRelicDoorCheck = GetStateContains("HiddenHUDIndicators=", 77)
#End Region
#End Region
    End Function
#Region "MenuStripControls"
    Private Sub startLauncher_Click(sender As Object, e As EventArgs) Handles startLauncher.Click
        Process.Start("LaunchPad.exe")
        Console.WriteLine("Starting Launcher")
    End Sub
    Private Sub saveButton_Click(sender As Object, e As EventArgs) Handles saveButton.Click
        'Save current options to regular Useroptions.ini
        File.WriteAllLines(curiniPath, curini)
        Console.WriteLine("Saved INI to ", curiniPath)
    End Sub
    Private Sub saveToButton_Click(sender As Object, e As EventArgs) Handles saveToButton.Click
        'Save current options to user-specified file
        Dim saveDialog As New SaveFileDialog()
        saveDialog.DefaultExt = "ini"
        saveDialog.AddExtension = True
        saveDialog.InitialDirectory = String.Concat(CurDir, "\Presets")
        Console.WriteLine(String.Concat(CurDir, "\Presets"))
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
        UpdateVal("AAQuality=", AADrop.SelectedItem.ToString.First)
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
        LabelHipSens.Text() = hipSensCalc(DPIBox.Value, hip360Box.Value)
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
    'Private Sub fontAutoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles fontAutoCheck.Click
    '    'If user desires automatic font replacement, create or update task to run the replacement batch
    '    Using ts As New TaskService()
    '        If fontAutoCheck.Checked Then
    '            UpdateVal("FontAutoReplace=", "1")
    '            If ts.RootFolder.Tasks.Exists("iniEdit Font") Then
    '                ts.GetTask(String.Concat(ts.RootFolder, "iniEdit Font")).Enabled = True
    '            Else
    '                Dim td As TaskDefinition = ts.NewTask
    '                'Set description for the task
    '                td.RegistrationInfo.Description = "iniEdit Font Replacement"
    '                'Create eventlog trigger
    '                Dim eTrigger As New EventTrigger()
    '                eTrigger.Subscription = "<QueryList><Query Id=""0"" Path=""System""><Select Path=""System"">*[System[Provider[@Name='Service Control Manager'] and (Level=4 or Level=0) and (band(Keywords,36028797018963968)) and (EventID=7045)]] and *[EventData[Data[@Name='ServiceName'] and (Data='BEDaisy')]]</Select></Query></QueryList>"
    '                td.Triggers.Add(eTrigger)
    '                'Create task action
    '                Dim path As String = CurDir()
    '                td.Actions.Add(New ExecAction(String.Concat(path, "\iniEditFont.bat")))
    '                'Save task
    '                ts.RootFolder.RegisterTaskDefinition("iniEdit Font", td)
    '            End If
    '        Else
    '            UpdateVal("FontAutoReplace=", "0")
    '            ts.GetTask(String.Concat(ts.RootFolder, "iniEdit Font")).Enabled = False
    '        End If
    '    End Using
    'End Sub
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
            If getState("TintModeMap=").ToString.Length < 3 Then
                UpdateVal("TintModeMap=", "4460130,19328,10357519")
            End If
            VSterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 1)))
            NCterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 2)))
            TRterrColorButton.BackColor = ColorTranslator.FromOle(colorDecimalSwap(ColorGetState("TintModeMap=", 3)))
        End If
    End Sub
#End Region
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
        UpdateValSpecific("ProximityVolume=", proxVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub squadVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles squadVoiceVolBox.TextChanged
        UpdateValSpecific("GroupVolume=", squadVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub raidVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles raidVoiceVolBox.TextChanged
        UpdateValSpecific("RaidVolume=", raidVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub outfitVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles outfitVoiceVolBox.TextChanged
        UpdateValSpecific("GuildVolume=", outfitVoiceVolBox.Value, "[VoiceChat]")
    End Sub
    Private Sub leaderVoiceVolBox_ValueChanged(sender As Object, e As EventArgs) Handles leaderVoiceVolBox.TextChanged
        UpdateValSpecific("GroupLeaderVolume=", leaderVoiceVolBox.Value, "[VoiceChat]")
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
            UpdateValSpecific("Enable=", 1, "[Voice]")
        Else
            UpdateValSpecific("Enable=", 0, "[Voice]")
        End If
    End Sub
    Private Sub proxVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles proxVoiceCheck.Click
        If proxVoiceCheck.Checked Then
            UpdateValSpecific("ProximityEnabled=", 1, "[Voice]")
        Else
            UpdateValSpecific("ProximityEnabled=", 0, "[Voice]")
        End If
    End Sub
    Private Sub squadVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles squadVoiceCheck.Click
        If squadVoiceCheck.Checked Then
            UpdateValSpecific("GroupEnabled=", 1, "[Voice]")
        Else
            UpdateValSpecific("GroupEnabled=", 0, "[Voice]")
        End If
    End Sub
    Private Sub raidVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles raidVoiceCheck.Click
        If raidVoiceCheck.Checked Then
            UpdateValSpecific("RaidEnabled=", 1, "[Voice]")
        Else
            UpdateValSpecific("RaidEnabled=", 0, "[Voice]")
        End If
    End Sub
    Private Sub outfitVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles outfitVoiceCheck.Click
        If squadVoiceCheck.Checked Then
            UpdateValSpecific("GuildEnabled=", 1, "[Voice]")
        Else
            UpdateValSpecific("GuildEnabled=", 0, "[Voice]")
        End If
    End Sub
    Private Sub leaderVoiceCheck_CheckedChanged(sender As Object, e As EventArgs) Handles leaderVoiceCheck.Click
        If squadVoiceCheck.Checked Then
            UpdateValSpecific("GroupEnabled=", 1, "[Voice]")
        Else
            UpdateValSpecific("GroupEnabled=", 0, "[Voice]")
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
#End Region
#Region "IndividualChecks"
    Private Sub iconsInfantryAllyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsInfantryAllyCheck.CheckedChanged
        If iconsInfantryAllyCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 84, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 84, False)
        End If
    End Sub
    Private Sub iconsInfantryEnemyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsInfantryEnemyCheck.CheckedChanged
        If iconsInfantryEnemyCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 85, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 85, False)
        End If
    End Sub
    Private Sub iconsVehAllyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsVehAllyCheck.CheckedChanged
        If iconsVehAllyCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 86, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 86, False)
        End If
    End Sub
    Private Sub iconsVehEnemyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsVehEnemyCheck.CheckedChanged
        If iconsVehEnemyCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 87, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 87, False)
        End If
    End Sub
    Private Sub iconsVehBastionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsVehBastionCheck.CheckedChanged
        If iconsVehBastionCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 62, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 62, False)
        End If
    End Sub
    Private Sub iconsDepDMGNadeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepDMGNadeCheck.CheckedChanged
        If iconsDepDMGNadeCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 3, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 3, False)
        End If
    End Sub
    Private Sub iconsDepStatusNadeCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepStatusNadeCheck.CheckedChanged
        If iconsDepStatusNadeCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 82, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 82, False)
        End If
    End Sub
    Private Sub iconsDepMinesCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepMinesCheck.CheckedChanged
        If iconsDepMinesCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 34, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 34, False)
        End If
    End Sub
    Private Sub iconsDepC4Check_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepC4Check.CheckedChanged
        If iconsDepC4Check.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 10, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 10, False)
        End If
    End Sub
    Private Sub iconsDepShieldRegenCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepShieldRegenCheck.CheckedChanged
        If iconsDepShieldRegenCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 38, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 38, False)
        End If
    End Sub
    Private Sub iconsDepDildarCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepDildarCheck.CheckedChanged
        If iconsDepDildarCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 39, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 39, False)
        End If
    End Sub
    Private Sub iconsDepAmmoBoxCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepAmmoBoxCheck.CheckedChanged
        If iconsDepAmmoBoxCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 33, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 33, False)
        End If
    End Sub
    Private Sub iconsDepDroneCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepDroneCheck.CheckedChanged
        If iconsDepDroneCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 65, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 65, False)
        End If
    End Sub
    Private Sub iconsDepTurretsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsDepTurretsCheck.CheckedChanged
        If iconsDepTurretsCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 88, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 88, False)
        End If
    End Sub
    Private Sub iconsWorldAnomalyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldAnomalyCheck.CheckedChanged
        If iconsWorldAnomalyCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 49, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 49, False)
        End If
    End Sub
    Private Sub iconsWorldDrillCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldDrillCheck.CheckedChanged
        If iconsWorldDrillCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 53, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 53, False)
        End If
    End Sub
    Private Sub iconsWorldBuoyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldBuoyCheck.CheckedChanged
        If iconsWorldBuoyCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 58, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 58, False)
        End If
    End Sub
    Private Sub iconsWorldMissionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldMissionCheck.CheckedChanged
        If iconsWorldMissionCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 68, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 68, False)
        End If
    End Sub
    Private Sub iconsWorldImplantCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldImplantCheck.CheckedChanged
        If iconsWorldImplantCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 67, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 67, False)
        End If
    End Sub
    Private Sub iconsWorldPlantCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldPlantCheck.CheckedChanged
        If iconsWorldPlantCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 71, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 71, False)
        End If
    End Sub
    Private Sub iconsWorldNPCCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldNPCCheck.CheckedChanged
        If iconsWorldNPCCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 79, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 79, False)
        End If
    End Sub
    Private Sub iconsWorldStationCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldStationCheck.CheckedChanged
        If iconsWorldStationCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 44, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 44, False)
        End If
    End Sub
    Private Sub iconsWorldAssetCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldAssetCheck.CheckedChanged
        If iconsWorldAssetCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 63, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 63, False)
        End If
    End Sub
    Private Sub iconsWorldCrystalCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldCrystalCheck.CheckedChanged
        If iconsWorldCrystalCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 43, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 43, False)
        End If
    End Sub
    Private Sub iconsWorldConstructionCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldConstructionCheck.CheckedChanged
        If iconsWorldConstructionCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 117, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 117, False)
        End If
    End Sub
    Private Sub iconsWorldCortiumCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsWorldCortiumCheck.CheckedChanged
        If iconsWorldCortiumCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 116, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 116, False)
        End If
    End Sub
    Private Sub iconsFacVehAmmoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacVehAmmoCheck.CheckedChanged
        If iconsFacVehAmmoCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 11, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 11, False)
        End If
    End Sub
    Private Sub iconsFacAirAmmoCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacAirAmmoCheck.CheckedChanged
        If iconsFacAirAmmoCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 18, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 18, False)
        End If
    End Sub
    Private Sub iconsFacEquipTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacEquipTermCheck.CheckedChanged
        If iconsFacEquipTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 7, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 7, False)
        End If
    End Sub
    Private Sub iconsFacWGTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacWGTermCheck.CheckedChanged
        If iconsFacWGTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 26, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 26, False)
        End If
    End Sub
    Private Sub iconsFacAirTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacAirTermCheck.CheckedChanged
        If iconsFacAirTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 4, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 4, False)
        End If
    End Sub
    Private Sub iconsFacVehTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacVehTermCheck.CheckedChanged
        If iconsFacVehTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 5, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 5, False)
        End If
    End Sub
    Private Sub iconsFacGalTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacGalTermCheck.CheckedChanged
        If iconsFacGalTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 6, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 6, False)
        End If
    End Sub
    Private Sub iconsFacFlashTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacFlashTermCheck.CheckedChanged
        If iconsFacFlashTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 15, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 15, False)
        End If
    End Sub
    Private Sub iconsFacLightTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacLightTermCheck.CheckedChanged
        If iconsFacLightTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 20, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 20, False)
        End If
    End Sub
    Private Sub iconsFacBusTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacBusTermCheck.CheckedChanged
        If iconsFacBusTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 115, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 115, False)
        End If
    End Sub
    Private Sub iconsFacTeleCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacTeleCheck.CheckedChanged
        If iconsFacTeleCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 13, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 13, False)
        End If
    End Sub
    Private Sub iconsFacPointCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacPointCheck.CheckedChanged
        If iconsFacPointCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 2, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 2, False)
        End If
    End Sub
    Private Sub iconsFacOWPointsCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacOWPointsCheck.CheckedChanged
        If iconsFacOWPointsCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 61, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 61, False)
        End If
    End Sub
    Private Sub iconsFacNearbyCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacNearbyCheck.CheckedChanged
        If iconsFacNearbyCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 83, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 83, False)
        End If
    End Sub
    Private Sub iconsFacSCUCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacSCUCheck.CheckedChanged
        If iconsFacSCUCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 17, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 17, False)
        End If
    End Sub
    Private Sub iconsFacHorzCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacHorzCheck.CheckedChanged
        If iconsFacHorzCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 22, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 22, False)
        End If
    End Sub
    Private Sub iconsFacVertCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacVertCheck.CheckedChanged
        If iconsFacVertCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 23, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 23, False)
        End If
    End Sub
    Private Sub iconsFacVehShieldCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacVehShieldCheck.CheckedChanged
        If iconsFacVehShieldCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 24, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 24, False)
        End If
    End Sub
    Private Sub iconsFacSCUShieldCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacSCUShieldCheck.CheckedChanged
        If iconsFacSCUShieldCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 25, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 25, False)
        End If
    End Sub
    Private Sub iconsFacForwardCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacForwardCheck.CheckedChanged
        If iconsFacForwardCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 27, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 27, False)
        End If
    End Sub
    Private Sub iconsFacBridgeTermCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacBridgeTermCheck.CheckedChanged
        If iconsFacBridgeTermCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 35, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 35, False)
        End If
    End Sub
    Private Sub iconsFacSCUAttackCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacSCUAttackCheck.CheckedChanged
        If iconsFacSCUAttackCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 75, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 75, False)
        End If
    End Sub
    Private Sub iconsFacGateAttackCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacGateAttackCheck.CheckedChanged
        If iconsFacGateAttackCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 76, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 76, False)
        End If
    End Sub
    Private Sub iconsFacRelicDoorCheck_CheckedChanged(sender As Object, e As EventArgs) Handles iconsFacRelicDoorCheck.CheckedChanged
        If iconsFacRelicDoorCheck.Checked = True Then
            UpdateValContains("HiddenHUDIndicators=", 77, True)
        Else
            UpdateValContains("HiddenHUDIndicators=", 77, False)
        End If
    End Sub
#End Region
#End Region
End Class