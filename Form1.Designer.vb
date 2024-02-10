<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmBurgers
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
        lblHeading = New Label()
        picPrime = New PictureBox()
        picVeggie = New PictureBox()
        btnSelectMeal = New Button()
        btnPrime = New Button()
        btnVeggie = New Button()
        lblInstructions = New Label()
        lblConfirmation = New Label()
        btnExit = New Button()
        CType(picPrime, ComponentModel.ISupportInitialize).BeginInit()
        CType(picVeggie, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' lblHeading
        ' 
        lblHeading.AutoSize = True
        lblHeading.Font = New Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        lblHeading.Location = New Point(273, 23)
        lblHeading.Name = "lblHeading"
        lblHeading.Size = New Size(239, 25)
        lblHeading.TabIndex = 0
        lblHeading.Text = "Farm Burger Specials "
        ' 
        ' picPrime
        ' 
        picPrime.Location = New Point(93, 60)
        picPrime.Name = "picPrime"
        picPrime.Size = New Size(260, 250)
        picPrime.TabIndex = 1
        picPrime.TabStop = False
        ' 
        ' picVeggie
        ' 
        picVeggie.Location = New Point(431, 60)
        picVeggie.Name = "picVeggie"
        picVeggie.Size = New Size(260, 250)
        picVeggie.TabIndex = 2
        picVeggie.TabStop = False
        ' 
        ' btnSelectMeal
        ' 
        btnSelectMeal.Location = New Point(330, 349)
        btnSelectMeal.Name = "btnSelectMeal"
        btnSelectMeal.Size = New Size(128, 35)
        btnSelectMeal.TabIndex = 3
        btnSelectMeal.Text = "Select Meal"
        btnSelectMeal.UseVisualStyleBackColor = True
        ' 
        ' btnPrime
        ' 
        btnPrime.Location = New Point(140, 349)
        btnPrime.Name = "btnPrime"
        btnPrime.Size = New Size(128, 35)
        btnPrime.TabIndex = 4
        btnPrime.Text = "Prime Beef"
        btnPrime.UseVisualStyleBackColor = True
        ' 
        ' btnVeggie
        ' 
        btnVeggie.Location = New Point(521, 349)
        btnVeggie.Name = "btnVeggie"
        btnVeggie.Size = New Size(128, 35)
        btnVeggie.TabIndex = 5
        btnVeggie.Text = "Veggie "
        btnVeggie.UseVisualStyleBackColor = True
        ' 
        ' lblInstructions
        ' 
        lblInstructions.AutoSize = True
        lblInstructions.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblInstructions.Location = New Point(244, 411)
        lblInstructions.Name = "lblInstructions"
        lblInstructions.Size = New Size(308, 14)
        lblInstructions.TabIndex = 6
        lblInstructions.Text = "Choose a burger and then click the Select Meal button"
        ' 
        ' lblConfirmation
        ' 
        lblConfirmation.AutoSize = True
        lblConfirmation.Font = New Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblConfirmation.Location = New Point(320, 451)
        lblConfirmation.Name = "lblConfirmation"
        lblConfirmation.Size = New Size(148, 14)
        lblConfirmation.TabIndex = 7
        lblConfirmation.Text = "Enjoy your burger special " & vbCrLf
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(330, 492)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(128, 35)
        btnExit.TabIndex = 8
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmBurgers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(784, 551)
        Controls.Add(btnExit)
        Controls.Add(lblConfirmation)
        Controls.Add(lblInstructions)
        Controls.Add(btnVeggie)
        Controls.Add(btnPrime)
        Controls.Add(btnSelectMeal)
        Controls.Add(picVeggie)
        Controls.Add(picPrime)
        Controls.Add(lblHeading)
        Name = "frmBurgers"
        Text = "Burger Specials "
        CType(picPrime, ComponentModel.ISupportInitialize).EndInit()
        CType(picVeggie, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picPrime As PictureBox
    Friend WithEvents picVeggie As PictureBox
    Friend WithEvents btnSelectMeal As Button
    Friend WithEvents btnPrime As Button
    Friend WithEvents btnVeggie As Button
    Friend WithEvents lblInstructions As Label
    Friend WithEvents lblConfirmation As Label
    Friend WithEvents btnExit As Button

End Class
