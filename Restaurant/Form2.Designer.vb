<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

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


    Private components As System.ComponentModel.IContainer


    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        BtnPanel2 = New Panel()
        Button1 = New Button()
        BtnBilling = New Button()
        BtnDelivery = New Button()
        BtnDrinks = New Button()
        BtnFood = New Button()
        BtnPanel1 = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        ListBox1 = New ListBox()
        BtnPanel2.SuspendLayout()
        BtnPanel1.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' BtnPanel2
        ' 
        BtnPanel2.BackColor = Color.Maroon
        BtnPanel2.Controls.Add(Button1)
        BtnPanel2.Controls.Add(BtnBilling)
        BtnPanel2.Controls.Add(BtnDelivery)
        BtnPanel2.Controls.Add(BtnDrinks)
        BtnPanel2.Controls.Add(BtnFood)
        BtnPanel2.Location = New Point(1, 0)
        BtnPanel2.Name = "BtnPanel2"
        BtnPanel2.Size = New Size(199, 450)
        BtnPanel2.TabIndex = 0
        ' 
        ' Button1
        ' 
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 12F)
        Button1.ForeColor = Color.OrangeRed
        Button1.Location = New Point(3, 287)
        Button1.Name = "Button1"
        Button1.Size = New Size(196, 33)
        Button1.TabIndex = 4
        Button1.Text = "Log out"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' BtnBilling
        ' 
        BtnBilling.FlatStyle = FlatStyle.Flat
        BtnBilling.Font = New Font("Segoe UI", 12F)
        BtnBilling.ForeColor = Color.OrangeRed
        BtnBilling.Location = New Point(-1, 230)
        BtnBilling.Name = "BtnBilling"
        BtnBilling.Size = New Size(196, 33)
        BtnBilling.TabIndex = 3
        BtnBilling.Text = "Billing"
        BtnBilling.UseVisualStyleBackColor = True
        ' 
        ' BtnDelivery
        ' 
        BtnDelivery.FlatStyle = FlatStyle.Flat
        BtnDelivery.Font = New Font("Segoe UI", 12F)
        BtnDelivery.ForeColor = Color.OrangeRed
        BtnDelivery.Location = New Point(3, 172)
        BtnDelivery.Name = "BtnDelivery"
        BtnDelivery.Size = New Size(193, 33)
        BtnDelivery.TabIndex = 2
        BtnDelivery.Text = "Delivery"
        BtnDelivery.UseVisualStyleBackColor = True
        ' 
        ' BtnDrinks
        ' 
        BtnDrinks.BackColor = Color.Maroon
        BtnDrinks.FlatStyle = FlatStyle.Flat
        BtnDrinks.Font = New Font("Segoe UI", 12F)
        BtnDrinks.ForeColor = Color.OrangeRed
        BtnDrinks.Location = New Point(3, 117)
        BtnDrinks.Name = "BtnDrinks"
        BtnDrinks.Size = New Size(193, 34)
        BtnDrinks.TabIndex = 1
        BtnDrinks.Text = "Drinks"
        BtnDrinks.UseVisualStyleBackColor = False
        ' 
        ' BtnFood
        ' 
        BtnFood.FlatStyle = FlatStyle.Flat
        BtnFood.Font = New Font("Segoe UI", 12F)
        BtnFood.ForeColor = Color.OrangeRed
        BtnFood.Location = New Point(3, 64)
        BtnFood.Name = "BtnFood"
        BtnFood.Size = New Size(193, 34)
        BtnFood.TabIndex = 0
        BtnFood.Text = "Foods"
        BtnFood.UseVisualStyleBackColor = True
        ' 
        ' BtnPanel1
        ' 
        BtnPanel1.BackColor = Color.Orange
        BtnPanel1.Controls.Add(Label1)
        BtnPanel1.Dock = DockStyle.Top
        BtnPanel1.Location = New Point(0, 0)
        BtnPanel1.Name = "BtnPanel1"
        BtnPanel1.Size = New Size(912, 39)
        BtnPanel1.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(328, 7)
        Label1.Name = "Label1"
        Label1.Size = New Size(298, 32)
        Label1.TabIndex = 0
        Label1.Text = "LUNCHBOX RESTAURANT"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(206, 45)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(706, 405)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(212, 67)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(120, 94)
        ListBox1.TabIndex = 3
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(912, 450)
        Controls.Add(ListBox1)
        Controls.Add(PictureBox1)
        Controls.Add(BtnPanel1)
        Controls.Add(BtnPanel2)
        Name = "Form2"
        Text = "Restaurant system"
        BtnPanel2.ResumeLayout(False)
        BtnPanel1.ResumeLayout(False)
        BtnPanel1.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnPanel2 As Panel
    Friend WithEvents BtnFood As Button
    Friend WithEvents BtnPanel1 As Panel
    Friend WithEvents BtnDrinks As Button
    Friend WithEvents BtnDelivery As Button
    Friend WithEvents BtnBilling As Button
    Friend WithEvents Label1 As Label



    Private Sub BtnPanel1_Paint(sender As Object, e As PaintEventArgs) Handles BtnPanel1.Paint

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
End Class
