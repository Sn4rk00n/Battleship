<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHelp
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tc_help = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tc_help.SuspendLayout()
        Me.SuspendLayout()
        '
        'tc_help
        '
        Me.tc_help.Controls.Add(Me.TabPage1)
        Me.tc_help.Controls.Add(Me.TabPage2)
        Me.tc_help.Location = New System.Drawing.Point(12, 12)
        Me.tc_help.Name = "tc_help"
        Me.tc_help.SelectedIndex = 0
        Me.tc_help.Size = New System.Drawing.Size(538, 258)
        Me.tc_help.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(530, 232)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Spielablauf"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(530, 232)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Steuerung"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmHelp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(562, 282)
        Me.Controls.Add(Me.tc_help)
        Me.Name = "frmHelp"
        Me.Text = "Hilfe"
        Me.tc_help.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Friend WithEvents tc_help As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class
