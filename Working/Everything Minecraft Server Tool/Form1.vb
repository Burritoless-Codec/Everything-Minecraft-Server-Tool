Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form2.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Text (*.txt)|*.txt"
        sfd.FileName = "eula"
        If RadioButton1.Checked = True Then
            If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                Dim sw As New System.IO.StreamWriter(sfd.FileName)
                sw.Write("eula=true")
                sw.Close()
            End If
        Else
            If RadioButton2.Checked = True Then
                If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
                    Dim sw As New System.IO.StreamWriter(sfd.FileName)
                    sw.Write("eula=flase")
                    sw.Close()
                End If
            End If
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Process.Start("https://account.mojang.com/documents/minecraft_eula")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' final to save as server.properties
        Dim sfd As New SaveFileDialog
        sfd.Filter = "Properties (*.properties)|*.properties"
        sfd.FileName = "server"


        ' variables for if statements
        Dim flight As String = ""
        Dim achievments As String = ""
        Dim worldname As String = ""
        Dim port As String = ""
        Dim motd As String = ""
        Dim worldsize As String = ""
        Dim op As String = ""
        Dim whitelist As String = ""
        Dim difficulty As String = ""
        Dim gamemode As String = ""
        Dim maxticks As String = ""
        Dim monsters As String = ""
        Dim harcore As String = ""
        Dim commandblock As String = ""
        Dim maxplayers As String = ""
        Dim structures As String = ""
        Dim animals As String = ""
        Dim npc As String = ""
        Dim pvp As String = ""
        Dim nether As String = ""

        ' All the if statements 
        If RadioButton28.Checked = True Then
            flight = "false"
        Else
            If RadioButton29.Checked = True Then
                flight = "true"
            End If
        End If

        If RadioButton30.Checked = True Then
            achievments = "false"
        Else
            If RadioButton31.Checked = True Then
                achievments = "true"
            End If
        End If

        worldname = TextBox1.Text
        port = TextBox2.Text
        motd = TextBox4.Text
        If RadioButton3.Checked = True Then
            worldsize = "2000"
        Else
            If RadioButton5.Checked = True Then
                worldsize = "10000"
            Else
                If RadioButton9.Checked = True Then
                    worldsize = "29999984"
                Else
                    If RadioButton8.Checked = True Then
                        worldsize = TextBox3.Text
                    End If
                End If
            End If
        End If

        op = NumericUpDown5.Value
        If RadioButton22.Checked = True Then
            whitelist = "false"
        Else
            If RadioButton23.Checked = True Then
                whitelist = "true"
            End If
        End If

        difficulty = NumericUpDown4.Value
        gamemode = NumericUpDown2.Value
        maxticks = TextBox5.Text

        If RadioButton12.Checked = True Then
            monsters = "false"
        Else
            If RadioButton13.Checked = True Then
                monsters = "true"
            End If
        End If
        If RadioButton18.Checked = True Then
            harcore = "false"
        Else
            If RadioButton19.Checked = True Then
                harcore = "true"
            End If
        End If
        If RadioButton14.Checked = True Then
            commandblock = "false"
        Else
            If RadioButton15.Checked = True Then
                commandblock = "true"
            End If
        End If
        maxplayers = NumericUpDown2.Value
        If RadioButton10.Checked = True Then
            structures = "false"
        Else
            If RadioButton11.Checked = True Then
                structures = "true"
            End If
        End If
        If RadioButton25.Checked = True Then
            npc = "true"
        Else
            If RadioButton24.Checked = True Then
                npc = "false"
            End If
        End If
        If RadioButton20.Checked = True Then
            animals = "false"
        Else
            If RadioButton21.Checked = True Then
                animals = "true"
            End If
        End If
        If RadioButton17.Checked = True Then
            pvp = "true"
        Else
            If RadioButton16.Checked = True Then
                pvp = "false"
            End If
        End If
        If RadioButton26.Checked = True Then
            nether = "false"
        Else
            If RadioButton27.Checked = True Then
                nether = "true"
            End If
        End If


        ' Save results
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            Dim sw As New System.IO.StreamWriter(sfd.FileName)
            sw.Write("# Minecraft server properties" + Environment.NewLine)
            sw.Write("# " + TimeOfDay + Environment.NewLine)
            sw.Write("# Configered with EMST https://github.com/MJGC-Jonathan/Everything-Minecraft-Server-Tool.git" + Environment.NewLine)
            sw.Write("generator-settings=" + Environment.NewLine)
            sw.Write("op-permission-level=" + op + Environment.NewLine)
            sw.Write("allow-nether=" + nether + Environment.NewLine)
            sw.Write("level-name=" + worldname + Environment.NewLine)
            sw.Write("enable-query=false" + Environment.NewLine)
            sw.Write("allow-flight=" + flight + Environment.NewLine)
            sw.Write("announce-player-achievements" + achievments + Environment.NewLine)
            sw.Write("server-port=" + port + Environment.NewLine)
            sw.Write("max-world-size=" + worldsize + Environment.NewLine)
            sw.Write("level-type=DEFAULT" + Environment.NewLine)
            sw.Write("enable-rcon=false" + Environment.NewLine)
            sw.Write("level-seed=" + Environment.NewLine)
            sw.Write("force-gamemode=false" + Environment.NewLine)
            sw.Write("server-ip=" + Environment.NewLine)
            sw.Write("network-compression-threshold=256" + Environment.NewLine)
            sw.Write("max-build-height=256" + Environment.NewLine)
            sw.Write("spawn-npcs=" + npc + Environment.NewLine)
            sw.Write("white-list=" + whitelist + Environment.NewLine)
            sw.Write("spawn-animals=" + animals + Environment.NewLine)
            sw.Write("hardcore=" + harcore + Environment.NewLine)
            sw.Write("snooper-enabled=true" + Environment.NewLine)
            sw.Write("resource-pack-sha1=" + Environment.NewLine)
            sw.Write("online-mode=true" + Environment.NewLine)
            sw.Write("resource-pack=" + Environment.NewLine)
            sw.Write("pvp=" + pvp + Environment.NewLine)
            sw.Write("difficulty=" + difficulty + Environment.NewLine)
            sw.Write("enable-command-block=" + commandblock + Environment.NewLine)
            sw.Write("gamemode=" + gamemode + Environment.NewLine)
            sw.Write("player-idle-timeout=0" + Environment.NewLine)
            sw.Write("max-players=" + maxplayers + Environment.NewLine)
            sw.Write("max-tick-time=" + maxticks + Environment.NewLine)
            sw.Write("spawn-monsters=" + monsters + Environment.NewLine)
            sw.Write("generate-structures=" + structures + Environment.NewLine)
            sw.Write("view-distance=10" + Environment.NewLine)
            sw.Write("motd=" + motd)

            sw.Close()
        End If

    End Sub
End Class
