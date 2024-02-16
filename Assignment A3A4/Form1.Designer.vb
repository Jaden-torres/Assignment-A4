<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox1 = New PictureBox()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        Button4 = New Button()
        Label4 = New Label()
        Label5 = New Label()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Tahoma", 16F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(458, 59)
        Label1.Name = "Label1"
        Label1.Size = New Size(342, 39)
        Label1.TabIndex = 0
        Label1.Text = "Farm Burger Special"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(749, 127)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(522, 341)
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 127)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(502, 341)
        PictureBox1.TabIndex = 9
        PictureBox1.TabStop = False
        ' 
        ' Button1
        ' 
        Button1.AccessibleName = "PrimeBeef Bttn"
        Button1.Location = New Point(139, 500)
        Button1.Name = "Button1"
        Button1.Size = New Size(189, 52)
        Button1.TabIndex = 1
        Button1.Text = "Prime Beef"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(545, 486)
        Button2.Name = "Button2"
        Button2.Size = New Size(172, 52)
        Button2.TabIndex = 2
        Button2.Text = "Select Meal"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(924, 500)
        Button3.Name = "Button3"
        Button3.Size = New Size(186, 52)
        Button3.TabIndex = 3
        Button3.Text = "Veggie"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(409, 553)
        Label2.Name = "Label2"
        Label2.Size = New Size(438, 22)
        Label2.TabIndex = 4
        Label2.Text = "Choose a burger and then click the Select Meal button"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(527, 593)
        Label3.Name = "Label3"
        Label3.Size = New Size(210, 22)
        Label3.TabIndex = 5
        Label3.Text = "Enjoy your burger special"
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(545, 639)
        Button4.Name = "Button4"
        Button4.Size = New Size(172, 52)
        Button4.TabIndex = 6
        Button4.Text = "Exit Window"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Tahoma", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(221, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(844, 53)
        Label4.TabIndex = 10
        Label4.Text = "Success! Your order has been placed!"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Tahoma", 22F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(362, 282)
        Label5.Name = "Label5"
        Label5.Size = New Size(603, 53)
        Label5.TabIndex = 11
        Label5.Text = "Press Exit Window to exit."
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1283, 789)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(PictureBox1)
        Controls.Add(PictureBox2)
        Controls.Add(Button4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label

End Class
