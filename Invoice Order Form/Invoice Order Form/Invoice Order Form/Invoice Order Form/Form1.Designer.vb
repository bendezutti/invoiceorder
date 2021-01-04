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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtChairs = New System.Windows.Forms.TextBox()
        Me.txtSofas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.listBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(107, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 45)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Customer Name (Last, First):"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(249, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(134, 26)
        Me.txtName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(111, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(249, 165)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(134, 26)
        Me.txtAddress.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(107, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 20)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "City, State, ZIP:"
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(249, 243)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(134, 26)
        Me.txtCity.TabIndex = 5
        '
        'txtChairs
        '
        Me.txtChairs.Location = New System.Drawing.Point(249, 336)
        Me.txtChairs.Name = "txtChairs"
        Me.txtChairs.Size = New System.Drawing.Size(134, 26)
        Me.txtChairs.TabIndex = 6
        '
        'txtSofas
        '
        Me.txtSofas.Location = New System.Drawing.Point(249, 418)
        Me.txtSofas.Name = "txtSofas"
        Me.txtSofas.Size = New System.Drawing.Size(134, 26)
        Me.txtSofas.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(111, 318)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 44)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Number of Chairs ordered:"
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(107, 400)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 44)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Number of Sofas ordered:"
        '
        'btnProcess
        '
        Me.btnProcess.Location = New System.Drawing.Point(41, 560)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(342, 45)
        Me.btnProcess.TabIndex = 10
        Me.btnProcess.Text = "Process Order"
        Me.btnProcess.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(424, 560)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(342, 45)
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = "Clear Order Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(803, 560)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(342, 45)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'listBox
        '
        Me.listBox.FormattingEnabled = True
        Me.listBox.ItemHeight = 20
        Me.listBox.Location = New System.Drawing.Point(572, 62)
        Me.listBox.Name = "listBox"
        Me.listBox.Size = New System.Drawing.Size(518, 444)
        Me.listBox.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 617)
        Me.Controls.Add(Me.listBox)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnProcess)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtSofas)
        Me.Controls.Add(Me.txtChairs)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Furniture Order Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtChairs As TextBox
    Friend WithEvents txtSofas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnProcess As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents listBox As ListBox
End Class
