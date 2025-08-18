Imports Npgsql
Imports System.Timers

Public Class Form1
    Dim rnd As New Random()
    Dim WithEvents sensorTimer As New System.Windows.Forms.Timer()
    Dim dbPassword As String = Environment.GetEnvironmentVariable("PGPASSWORD")
    Dim connStr As String = "Host=localhost;Port=5432;Username=postgres;Password={dbPassword};Database=wellsite_db"

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        sensorTimer.Interval = 2000 ' 2 seconds
        sensorTimer.Start()
        btnStart.Enabled = False
    End Sub

    Private Sub sensorTimer_Tick(sender As Object, e As EventArgs) Handles sensorTimer.Tick
        ' Generate random sensor value
        Dim sensorValue As Double = rnd.NextDouble() * 100
        lblSensorValue.Text = "Well1: " & Math.Round(sensorValue, 2).ToString()

        ' Show alert if value > 80
        If sensorValue > 80 Then
            lblAlert.ForeColor = Color.Red
            lblAlert.Text = "Critical Value!"
        ElseIf sensorValue > 60 Then
            lblAlert.ForeColor = Color.Orange
            lblAlert.Text = "Warning Value"
        Else
            lblAlert.ForeColor = Color.Black
            lblAlert.Text = ""
        End If

        ' --- Well2 (New) ---
        Dim sensorValue2 As Double = rnd.NextDouble() * 100
        lblSensorValue2.Text = "Well2: " & Math.Round(sensorValue2, 2).ToString()
        If sensorValue2 > 80 Then
            lblAlert2.ForeColor = Color.Red
            lblAlert2.Text = "Critical Value!"
        ElseIf sensorValue2 > 60 Then
            lblAlert2.ForeColor = Color.Orange
            lblAlert2.Text = "Warning Value"
        Else
            lblAlert2.ForeColor = Color.Black
            lblAlert2.Text = ""
        End If

        ' Add points to chart
        chartSensors.Series("Well1").Points.AddY(sensorValue)
        chartSensors.Series("Well2").Points.AddY(sensorValue2)

        ' Optional: keep only last 20 points to avoid overcrowding
        If chartSensors.Series("Well1").Points.Count > 20 Then
            chartSensors.Series("Well1").Points.RemoveAt(0)
            chartSensors.Series("Well2").Points.RemoveAt(0)
        End If

        ' Insert into PostgreSQL
        Using conn As New NpgsqlConnection(connStr)
            Try
                conn.Open()
                Dim sql As String = "INSERT INTO sensor_readings (sensor_name, value) VALUES (@sensorName, @value)"
                Using cmd As New NpgsqlCommand(sql, conn)
                    cmd.Parameters.AddWithValue("@sensorName", "Well1")
                    cmd.Parameters.AddWithValue("@value", sensorValue)
                    cmd.ExecuteNonQuery()
                End Using

                Using cmd2 As New NpgsqlCommand(sql, conn)
                    cmd2.Parameters.AddWithValue("@sensorName", "Well2")
                    cmd2.Parameters.AddWithValue("@value", sensorValue2)
                    cmd2.ExecuteNonQuery()
                End Using
            Catch ex As Exception
                MessageBox.Show("DB Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub chartSensors_Click(sender As Object, e As EventArgs) Handles chartSensors.Click

    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        sensorTimer.Stop()                ' Stop the timer
        btnStart.Enabled = True           ' Re-enable the Start button
        lblAlert.Text = "Simulation Stopped"
        lblAlert2.Text = "Simulation Stopped"
    End Sub
End Class
