<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblSensorValue = New System.Windows.Forms.Label()
        Me.lblAlert = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblSensorValue2 = New System.Windows.Forms.Label()
        Me.lblAlert2 = New System.Windows.Forms.Label()
        Me.chartSensors = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btnStop = New System.Windows.Forms.Button()
        CType(Me.chartSensors, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSensorValue
        '
        Me.lblSensorValue.AutoSize = True
        Me.lblSensorValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblSensorValue.Location = New System.Drawing.Point(133, 93)
        Me.lblSensorValue.Name = "lblSensorValue"
        Me.lblSensorValue.Size = New System.Drawing.Size(100, 36)
        Me.lblSensorValue.TabIndex = 0
        Me.lblSensorValue.Text = "Well1:"
        '
        'lblAlert
        '
        Me.lblAlert.AutoSize = True
        Me.lblAlert.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblAlert.ForeColor = System.Drawing.Color.Red
        Me.lblAlert.Location = New System.Drawing.Point(144, 150)
        Me.lblAlert.Name = "lblAlert"
        Me.lblAlert.Size = New System.Drawing.Size(68, 29)
        Me.lblAlert.TabIndex = 1
        Me.lblAlert.Text = "Alert:"
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(158, 247)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start Simulation"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'lblSensorValue2
        '
        Me.lblSensorValue2.AutoSize = True
        Me.lblSensorValue2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblSensorValue2.Location = New System.Drawing.Point(569, 93)
        Me.lblSensorValue2.Name = "lblSensorValue2"
        Me.lblSensorValue2.Size = New System.Drawing.Size(80, 29)
        Me.lblSensorValue2.TabIndex = 3
        Me.lblSensorValue2.Text = "Well2:"
        '
        'lblAlert2
        '
        Me.lblAlert2.AutoSize = True
        Me.lblAlert2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!)
        Me.lblAlert2.ForeColor = System.Drawing.Color.Red
        Me.lblAlert2.Location = New System.Drawing.Point(568, 150)
        Me.lblAlert2.Name = "lblAlert2"
        Me.lblAlert2.Size = New System.Drawing.Size(68, 29)
        Me.lblAlert2.TabIndex = 4
        Me.lblAlert2.Text = "Alert:"
        '
        'chartSensors
        '
        ChartArea3.Name = "ChartArea1"
        Me.chartSensors.ChartAreas.Add(ChartArea3)
        Legend3.Name = "Legend1"
        Me.chartSensors.Legends.Add(Legend3)
        Me.chartSensors.Location = New System.Drawing.Point(499, 247)
        Me.chartSensors.Name = "chartSensors"
        Series5.ChartArea = "ChartArea1"
        Series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series5.Legend = "Legend1"
        Series5.Name = "Well1"
        Series6.ChartArea = "ChartArea1"
        Series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series6.Legend = "Legend1"
        Series6.Name = "Well2"
        Me.chartSensors.Series.Add(Series5)
        Me.chartSensors.Series.Add(Series6)
        Me.chartSensors.Size = New System.Drawing.Size(387, 265)
        Me.chartSensors.TabIndex = 5
        Me.chartSensors.Text = "Chart1"
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(322, 247)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 6
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(937, 524)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.chartSensors)
        Me.Controls.Add(Me.lblAlert2)
        Me.Controls.Add(Me.lblSensorValue2)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblAlert)
        Me.Controls.Add(Me.lblSensorValue)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.chartSensors, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSensorValue As Label
    Friend WithEvents lblAlert As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lblSensorValue2 As Label
    Friend WithEvents lblAlert2 As Label
    Friend WithEvents chartSensors As DataVisualization.Charting.Chart
    Friend WithEvents btnStop As Button
End Class
