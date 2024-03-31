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
        PictureBox1 = New PictureBox()
        Label1 = New Label()
        Panel1 = New Panel()
        NameTxtbox = New TextBox()
        PictureBox2 = New PictureBox()
        Panel2 = New Panel()
        PswdTxtbox = New TextBox()
        PictureBox3 = New PictureBox()
        LoginBtn = New Button()
        CloseBtn = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(144, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(156, 146)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Georgia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = Color.Black
        Label1.Location = New Point(144, 196)
        Label1.Name = "Label1"
        Label1.Size = New Size(57, 18)
        Label1.TabIndex = 1
        Label1.Text = "Sign In"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.WhiteSmoke
        Panel1.Controls.Add(NameTxtbox)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Location = New Point(100, 217)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(323, 58)
        Panel1.TabIndex = 2
        ' 
        ' NameTxtbox
        ' 
        NameTxtbox.BorderStyle = BorderStyle.None
        NameTxtbox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        NameTxtbox.ForeColor = Color.Black
        NameTxtbox.Location = New Point(54, 22)
        NameTxtbox.Name = "NameTxtbox"
        NameTxtbox.Size = New Size(257, 18)
        NameTxtbox.TabIndex = 7
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 13)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(45, 42)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 0
        PictureBox2.TabStop = False
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.WhiteSmoke
        Panel2.Controls.Add(PswdTxtbox)
        Panel2.Controls.Add(PictureBox3)
        Panel2.Location = New Point(100, 278)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(323, 58)
        Panel2.TabIndex = 4
        ' 
        ' PswdTxtbox
        ' 
        PswdTxtbox.BackColor = SystemColors.Window
        PswdTxtbox.BorderStyle = BorderStyle.None
        PswdTxtbox.Font = New Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PswdTxtbox.ForeColor = Color.Black
        PswdTxtbox.Location = New Point(63, 23)
        PswdTxtbox.Name = "PswdTxtbox"
        PswdTxtbox.Size = New Size(248, 18)
        PswdTxtbox.TabIndex = 2
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 13)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(45, 42)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 0
        PictureBox3.TabStop = False
        ' 
        ' LoginBtn
        ' 
        LoginBtn.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LoginBtn.ForeColor = Color.Black
        LoginBtn.Location = New Point(100, 353)
        LoginBtn.Name = "LoginBtn"
        LoginBtn.Size = New Size(125, 38)
        LoginBtn.TabIndex = 5
        LoginBtn.Text = "Login"
        LoginBtn.UseVisualStyleBackColor = True
        ' 
        ' CloseBtn
        ' 
        CloseBtn.Font = New Font("Georgia", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CloseBtn.ForeColor = Color.Black
        CloseBtn.Location = New Point(286, 353)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(125, 38)
        CloseBtn.TabIndex = 6
        CloseBtn.Text = "Close"
        CloseBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(491, 656)
        Controls.Add(CloseBtn)
        Controls.Add(LoginBtn)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        Controls.Add(Label1)
        Controls.Add(PictureBox1)
        FormBorderStyle = FormBorderStyle.FixedSingle
        MaximizeBox = False
        MinimizeBox = False
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents LoginBtn As Button
    Friend WithEvents CloseBtn As Button
    Friend WithEvents PswdTxtbox As TextBox
    Friend WithEvents NameTxtbox As TextBox

End Class
