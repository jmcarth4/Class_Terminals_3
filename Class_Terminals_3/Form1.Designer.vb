﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.components = New System.ComponentModel.Container()
        Me.DataInputLabel = New System.Windows.Forms.Label()
        Me.InTermListBox = New System.Windows.Forms.ListBox()
        Me.OutTermListBox = New System.Windows.Forms.ListBox()
        Me.DataInputClearButton = New System.Windows.Forms.Button()
        Me.OutClearButton = New System.Windows.Forms.Button()
        Me.InClearButton = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SendButton = New System.Windows.Forms.Button()
        Me.PortDataListBox = New System.Windows.Forms.ListBox()
        Me.PortOpenButton = New System.Windows.Forms.Button()
        Me.ComPortListBox = New System.Windows.Forms.ListBox()
        Me.BaudRateListBox = New System.Windows.Forms.ListBox()
        Me.QuitButton = New System.Windows.Forms.Button()
        Me.ComPortButton = New System.Windows.Forms.Button()
        Me.BaudRateButton = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.AnalogReadButton = New System.Windows.Forms.Button()
        Me.WriteAnalogButton = New System.Windows.Forms.Button()
        Me.QyRecLabel = New System.Windows.Forms.Label()
        Me.QyDisplayLabel = New System.Windows.Forms.Label()
        Me.QySendTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RDigitalButton = New System.Windows.Forms.Button()
        Me.WDigitalButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DataInputLabel
        '
        Me.DataInputLabel.AutoSize = True
        Me.DataInputLabel.Location = New System.Drawing.Point(672, 32)
        Me.DataInputLabel.Name = "DataInputLabel"
        Me.DataInputLabel.Size = New System.Drawing.Size(85, 20)
        Me.DataInputLabel.TabIndex = 63
        Me.DataInputLabel.Text = "Data Input"
        '
        'InTermListBox
        '
        Me.InTermListBox.FormattingEnabled = True
        Me.InTermListBox.ItemHeight = 20
        Me.InTermListBox.Location = New System.Drawing.Point(863, 191)
        Me.InTermListBox.Name = "InTermListBox"
        Me.InTermListBox.Size = New System.Drawing.Size(207, 184)
        Me.InTermListBox.TabIndex = 62
        '
        'OutTermListBox
        '
        Me.OutTermListBox.FormattingEnabled = True
        Me.OutTermListBox.ItemHeight = 20
        Me.OutTermListBox.Location = New System.Drawing.Point(620, 203)
        Me.OutTermListBox.Name = "OutTermListBox"
        Me.OutTermListBox.Size = New System.Drawing.Size(226, 244)
        Me.OutTermListBox.TabIndex = 61
        '
        'DataInputClearButton
        '
        Me.DataInputClearButton.Location = New System.Drawing.Point(801, 32)
        Me.DataInputClearButton.Name = "DataInputClearButton"
        Me.DataInputClearButton.Size = New System.Drawing.Size(110, 58)
        Me.DataInputClearButton.TabIndex = 60
        Me.DataInputClearButton.Text = "Clear data input "
        Me.DataInputClearButton.UseVisualStyleBackColor = True
        '
        'OutClearButton
        '
        Me.OutClearButton.Location = New System.Drawing.Point(676, 453)
        Me.OutClearButton.Name = "OutClearButton"
        Me.OutClearButton.Size = New System.Drawing.Size(154, 104)
        Me.OutClearButton.TabIndex = 59
        Me.OutClearButton.Text = "Clear data out display"
        Me.OutClearButton.UseVisualStyleBackColor = True
        '
        'InClearButton
        '
        Me.InClearButton.Location = New System.Drawing.Point(901, 401)
        Me.InClearButton.Name = "InClearButton"
        Me.InClearButton.Size = New System.Drawing.Size(154, 104)
        Me.InClearButton.TabIndex = 58
        Me.InClearButton.Text = "clear data in display"
        Me.InClearButton.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(657, 55)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 26)
        Me.TextBox1.TabIndex = 57
        '
        'SendButton
        '
        Me.SendButton.Location = New System.Drawing.Point(603, 87)
        Me.SendButton.Name = "SendButton"
        Me.SendButton.Size = New System.Drawing.Size(154, 104)
        Me.SendButton.TabIndex = 56
        Me.SendButton.Text = "Send Packet"
        Me.SendButton.UseVisualStyleBackColor = True
        '
        'PortDataListBox
        '
        Me.PortDataListBox.FormattingEnabled = True
        Me.PortDataListBox.ItemHeight = 20
        Me.PortDataListBox.Location = New System.Drawing.Point(304, 7)
        Me.PortDataListBox.Name = "PortDataListBox"
        Me.PortDataListBox.Size = New System.Drawing.Size(173, 204)
        Me.PortDataListBox.TabIndex = 55
        '
        'PortOpenButton
        '
        Me.PortOpenButton.Location = New System.Drawing.Point(339, 243)
        Me.PortOpenButton.Name = "PortOpenButton"
        Me.PortOpenButton.Size = New System.Drawing.Size(154, 104)
        Me.PortOpenButton.TabIndex = 54
        Me.PortOpenButton.Text = "Connect"
        Me.PortOpenButton.UseVisualStyleBackColor = True
        '
        'ComPortListBox
        '
        Me.ComPortListBox.FormattingEnabled = True
        Me.ComPortListBox.ItemHeight = 20
        Me.ComPortListBox.Location = New System.Drawing.Point(188, 27)
        Me.ComPortListBox.Name = "ComPortListBox"
        Me.ComPortListBox.Size = New System.Drawing.Size(110, 184)
        Me.ComPortListBox.TabIndex = 53
        '
        'BaudRateListBox
        '
        Me.BaudRateListBox.FormattingEnabled = True
        Me.BaudRateListBox.ItemHeight = 20
        Me.BaudRateListBox.Location = New System.Drawing.Point(17, 12)
        Me.BaudRateListBox.Name = "BaudRateListBox"
        Me.BaudRateListBox.Size = New System.Drawing.Size(165, 204)
        Me.BaudRateListBox.TabIndex = 52
        '
        'QuitButton
        '
        Me.QuitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.QuitButton.Location = New System.Drawing.Point(1150, 560)
        Me.QuitButton.Name = "QuitButton"
        Me.QuitButton.Size = New System.Drawing.Size(82, 76)
        Me.QuitButton.TabIndex = 51
        Me.QuitButton.Text = "Quit"
        Me.QuitButton.UseVisualStyleBackColor = True
        '
        'ComPortButton
        '
        Me.ComPortButton.Location = New System.Drawing.Point(179, 238)
        Me.ComPortButton.Name = "ComPortButton"
        Me.ComPortButton.Size = New System.Drawing.Size(154, 104)
        Me.ComPortButton.TabIndex = 50
        Me.ComPortButton.Text = "Com Port"
        Me.ComPortButton.UseVisualStyleBackColor = True
        '
        'BaudRateButton
        '
        Me.BaudRateButton.Location = New System.Drawing.Point(33, 243)
        Me.BaudRateButton.Name = "BaudRateButton"
        Me.BaudRateButton.Size = New System.Drawing.Size(127, 95)
        Me.BaudRateButton.TabIndex = 49
        Me.BaudRateButton.Text = "Baud Rate"
        Me.BaudRateButton.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'SerialPort1
        '
        '
        'AnalogReadButton
        '
        Me.AnalogReadButton.Location = New System.Drawing.Point(17, 394)
        Me.AnalogReadButton.Name = "AnalogReadButton"
        Me.AnalogReadButton.Size = New System.Drawing.Size(109, 96)
        Me.AnalogReadButton.TabIndex = 64
        Me.AnalogReadButton.Text = "ReadAnalog"
        Me.AnalogReadButton.UseVisualStyleBackColor = True
        '
        'WriteAnalogButton
        '
        Me.WriteAnalogButton.Location = New System.Drawing.Point(179, 394)
        Me.WriteAnalogButton.Name = "WriteAnalogButton"
        Me.WriteAnalogButton.Size = New System.Drawing.Size(104, 87)
        Me.WriteAnalogButton.TabIndex = 65
        Me.WriteAnalogButton.Text = "Write Analog"
        Me.WriteAnalogButton.UseVisualStyleBackColor = True
        '
        'QyRecLabel
        '
        Me.QyRecLabel.AutoSize = True
        Me.QyRecLabel.Location = New System.Drawing.Point(240, 515)
        Me.QyRecLabel.Name = "QyRecLabel"
        Me.QyRecLabel.Size = New System.Drawing.Size(18, 20)
        Me.QyRecLabel.TabIndex = 66
        Me.QyRecLabel.Text = "0"
        '
        'QyDisplayLabel
        '
        Me.QyDisplayLabel.AutoSize = True
        Me.QyDisplayLabel.Location = New System.Drawing.Point(175, 495)
        Me.QyDisplayLabel.Name = "QyDisplayLabel"
        Me.QyDisplayLabel.Size = New System.Drawing.Size(153, 20)
        Me.QyDisplayLabel.TabIndex = 67
        Me.QyDisplayLabel.Text = "Qy@ Received Data"
        '
        'QySendTextBox
        '
        Me.QySendTextBox.Location = New System.Drawing.Point(507, 546)
        Me.QySendTextBox.Name = "QySendTextBox"
        Me.QySendTextBox.Size = New System.Drawing.Size(100, 26)
        Me.QySendTextBox.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 549)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(18, 20)
        Me.Label1.TabIndex = 69
        Me.Label1.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(404, 549)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 20)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "0"
        '
        'RDigitalButton
        '
        Me.RDigitalButton.Location = New System.Drawing.Point(323, 394)
        Me.RDigitalButton.Name = "RDigitalButton"
        Me.RDigitalButton.Size = New System.Drawing.Size(111, 77)
        Me.RDigitalButton.TabIndex = 71
        Me.RDigitalButton.Text = "Read Digital"
        Me.RDigitalButton.UseVisualStyleBackColor = True
        '
        'WDigitalButton
        '
        Me.WDigitalButton.Location = New System.Drawing.Point(456, 401)
        Me.WDigitalButton.Name = "WDigitalButton"
        Me.WDigitalButton.Size = New System.Drawing.Size(116, 62)
        Me.WDigitalButton.TabIndex = 72
        Me.WDigitalButton.Text = "Wrtie Digital"
        Me.WDigitalButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1247, 646)
        Me.Controls.Add(Me.WDigitalButton)
        Me.Controls.Add(Me.RDigitalButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.QySendTextBox)
        Me.Controls.Add(Me.QyDisplayLabel)
        Me.Controls.Add(Me.QyRecLabel)
        Me.Controls.Add(Me.WriteAnalogButton)
        Me.Controls.Add(Me.AnalogReadButton)
        Me.Controls.Add(Me.DataInputLabel)
        Me.Controls.Add(Me.InTermListBox)
        Me.Controls.Add(Me.OutTermListBox)
        Me.Controls.Add(Me.DataInputClearButton)
        Me.Controls.Add(Me.OutClearButton)
        Me.Controls.Add(Me.InClearButton)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.SendButton)
        Me.Controls.Add(Me.PortDataListBox)
        Me.Controls.Add(Me.PortOpenButton)
        Me.Controls.Add(Me.ComPortListBox)
        Me.Controls.Add(Me.BaudRateListBox)
        Me.Controls.Add(Me.QuitButton)
        Me.Controls.Add(Me.ComPortButton)
        Me.Controls.Add(Me.BaudRateButton)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataInputLabel As Label
    Friend WithEvents InTermListBox As ListBox
    Friend WithEvents OutTermListBox As ListBox
    Friend WithEvents DataInputClearButton As Button
    Friend WithEvents OutClearButton As Button
    Friend WithEvents InClearButton As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SendButton As Button
    Friend WithEvents PortDataListBox As ListBox
    Friend WithEvents PortOpenButton As Button
    Friend WithEvents ComPortListBox As ListBox
    Friend WithEvents BaudRateListBox As ListBox
    Friend WithEvents QuitButton As Button
    Friend WithEvents ComPortButton As Button
    Friend WithEvents BaudRateButton As Button
    Friend WithEvents Timer1 As Timer
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents AnalogReadButton As Button
    Friend WithEvents WriteAnalogButton As Button
    Friend WithEvents QyRecLabel As Label
    Friend WithEvents QyDisplayLabel As Label
    Friend WithEvents QySendTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents RDigitalButton As Button
    Friend WithEvents WDigitalButton As Button
End Class
