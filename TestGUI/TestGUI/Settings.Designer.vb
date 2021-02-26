<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Me.file_name = New System.Windows.Forms.TextBox()
        Me.local_path = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ButtonAreaBL = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.remote_path = New System.Windows.Forms.TextBox()
        Me.network_name = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.upload_rate = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Home = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'file_name
        '
        Me.file_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.file_name.Location = New System.Drawing.Point(110, 158)
        Me.file_name.Name = "file_name"
        Me.file_name.Size = New System.Drawing.Size(333, 62)
        Me.file_name.TabIndex = 16
        '
        'local_path
        '
        Me.local_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.local_path.Location = New System.Drawing.Point(110, 259)
        Me.local_path.Name = "local_path"
        Me.local_path.Size = New System.Drawing.Size(333, 62)
        Me.local_path.TabIndex = 17
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(104, 116)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(158, 33)
        Me.Label9.TabIndex = 38
        Me.Label9.Text = "File Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(104, 223)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 33)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Local File Path"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox1.Location = New System.Drawing.Point(72, 58)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(408, 472)
        Me.PictureBox1.TabIndex = 40
        Me.PictureBox1.TabStop = False
        '
        'ButtonAreaBL
        '
        Me.ButtonAreaBL.AccessibleName = "Bboi"
        Me.ButtonAreaBL.AutoSize = True
        Me.ButtonAreaBL.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ButtonAreaBL.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonAreaBL.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ButtonAreaBL.Location = New System.Drawing.Point(111, 440)
        Me.ButtonAreaBL.Margin = New System.Windows.Forms.Padding(7, 6, 7, 6)
        Me.ButtonAreaBL.Name = "ButtonAreaBL"
        Me.ButtonAreaBL.Size = New System.Drawing.Size(217, 72)
        Me.ButtonAreaBL.TabIndex = 51
        Me.ButtonAreaBL.Text = "Edit Database"
        Me.ButtonAreaBL.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(104, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(317, 39)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Database Settings"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(827, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(296, 39)
        Me.Label3.TabIndex = 59
        Me.Label3.Text = "Network Settings"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(827, 223)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 33)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "Upload Rate"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(827, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(220, 33)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Network Name"
        '
        'remote_path
        '
        Me.remote_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.remote_path.Location = New System.Drawing.Point(111, 360)
        Me.remote_path.Name = "remote_path"
        Me.remote_path.Size = New System.Drawing.Size(333, 62)
        Me.remote_path.TabIndex = 54
        '
        'network_name
        '
        Me.network_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.network_name.Location = New System.Drawing.Point(833, 158)
        Me.network_name.Name = "network_name"
        Me.network_name.Size = New System.Drawing.Size(333, 62)
        Me.network_name.TabIndex = 53
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.PictureBox2.Location = New System.Drawing.Point(795, 58)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(408, 272)
        Me.PictureBox2.TabIndex = 57
        Me.PictureBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(105, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(256, 33)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Remote File Path"
        '
        'upload_rate
        '
        Me.upload_rate.AutoCompleteCustomSource.AddRange(New String() {"1", "2", "3", "4", "5"})
        Me.upload_rate.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.upload_rate.FormattingEnabled = True
        Me.upload_rate.Location = New System.Drawing.Point(833, 259)
        Me.upload_rate.Name = "upload_rate"
        Me.upload_rate.Size = New System.Drawing.Size(172, 41)
        Me.upload_rate.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(1021, 267)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(80, 33)
        Me.Label7.TabIndex = 62
        Me.Label7.Text = "secs"
        '
        'Home
        '
        Me.Home.BackgroundImage = Global.FallDemo.My.Resources.Resources.PixelKit_home_icon
        Me.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Home.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Home.Location = New System.Drawing.Point(583, 640)
        Me.Home.Name = "Home"
        Me.Home.Size = New System.Drawing.Size(107, 97)
        Me.Home.TabIndex = 63
        Me.Home.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.Home.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Home.UseVisualStyleBackColor = True
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1264, 749)
        Me.Controls.Add(Me.Home)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.upload_rate)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.remote_path)
        Me.Controls.Add(Me.network_name)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ButtonAreaBL)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.local_path)
        Me.Controls.Add(Me.file_name)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Settings"
        Me.Text = "I"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents file_name As TextBox
    Friend WithEvents local_path As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ButtonAreaBL As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents remote_path As TextBox
    Friend WithEvents network_name As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents upload_rate As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Home As Button
End Class
