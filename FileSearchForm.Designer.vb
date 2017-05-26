<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FileSearchForm
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
        Me.Btn_Select_Folder = New System.Windows.Forms.Button()
        Me.File_List = New System.Windows.Forms.ListBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.StatusStrip = New System.Windows.Forms.StatusStrip()
        Me.Status_Progress_Bar = New System.Windows.Forms.ToolStripProgressBar()
        Me.Status_Bar_Txt = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Btn_Add_Files = New System.Windows.Forms.Button()
        Me.Btn_Find_Files = New System.Windows.Forms.Button()
        Me.Lbl_Folder_Path = New System.Windows.Forms.Label()
        Me.Btn_View_DB = New System.Windows.Forms.Button()
        Me.Btn_Clear = New System.Windows.Forms.Button()
        Me.StatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Btn_Select_Folder
        '
        Me.Btn_Select_Folder.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Select_Folder.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Select_Folder.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Select_Folder.Location = New System.Drawing.Point(12, 5)
        Me.Btn_Select_Folder.Name = "Btn_Select_Folder"
        Me.Btn_Select_Folder.Size = New System.Drawing.Size(103, 30)
        Me.Btn_Select_Folder.TabIndex = 0
        Me.Btn_Select_Folder.Text = "Select Folder"
        Me.Btn_Select_Folder.UseVisualStyleBackColor = False
        '
        'File_List
        '
        Me.File_List.FormattingEnabled = True
        Me.File_List.HorizontalScrollbar = True
        Me.File_List.Location = New System.Drawing.Point(12, 41)
        Me.File_List.Name = "File_List"
        Me.File_List.SelectionMode = System.Windows.Forms.SelectionMode.None
        Me.File_List.Size = New System.Drawing.Size(721, 121)
        Me.File_List.TabIndex = 1
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.SystemColors.Window
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Status_Progress_Bar, Me.Status_Bar_Txt})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 198)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(745, 22)
        Me.StatusStrip.TabIndex = 2
        Me.StatusStrip.Text = "StatusStrip1"
        '
        'Status_Progress_Bar
        '
        Me.Status_Progress_Bar.BackColor = System.Drawing.SystemColors.Window
        Me.Status_Progress_Bar.ForeColor = System.Drawing.Color.Lime
        Me.Status_Progress_Bar.Name = "Status_Progress_Bar"
        Me.Status_Progress_Bar.Size = New System.Drawing.Size(100, 16)
        '
        'Status_Bar_Txt
        '
        Me.Status_Bar_Txt.Name = "Status_Bar_Txt"
        Me.Status_Bar_Txt.Size = New System.Drawing.Size(0, 17)
        '
        'Btn_Add_Files
        '
        Me.Btn_Add_Files.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Add_Files.Enabled = False
        Me.Btn_Add_Files.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add_Files.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_Files.Location = New System.Drawing.Point(588, 168)
        Me.Btn_Add_Files.Name = "Btn_Add_Files"
        Me.Btn_Add_Files.Size = New System.Drawing.Size(145, 30)
        Me.Btn_Add_Files.TabIndex = 3
        Me.Btn_Add_Files.Text = "Add Files to Database"
        Me.Btn_Add_Files.UseVisualStyleBackColor = False
        '
        'Btn_Find_Files
        '
        Me.Btn_Find_Files.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Find_Files.Enabled = False
        Me.Btn_Find_Files.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Find_Files.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Find_Files.Location = New System.Drawing.Point(465, 168)
        Me.Btn_Find_Files.Name = "Btn_Find_Files"
        Me.Btn_Find_Files.Size = New System.Drawing.Size(117, 30)
        Me.Btn_Find_Files.TabIndex = 4
        Me.Btn_Find_Files.Text = "Search For Files"
        Me.Btn_Find_Files.UseVisualStyleBackColor = False
        '
        'Lbl_Folder_Path
        '
        Me.Lbl_Folder_Path.AutoSize = True
        Me.Lbl_Folder_Path.Location = New System.Drawing.Point(150, 17)
        Me.Lbl_Folder_Path.Name = "Lbl_Folder_Path"
        Me.Lbl_Folder_Path.Size = New System.Drawing.Size(0, 13)
        Me.Lbl_Folder_Path.TabIndex = 5
        '
        'Btn_View_DB
        '
        Me.Btn_View_DB.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_View_DB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_View_DB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_View_DB.Location = New System.Drawing.Point(12, 165)
        Me.Btn_View_DB.Name = "Btn_View_DB"
        Me.Btn_View_DB.Size = New System.Drawing.Size(135, 30)
        Me.Btn_View_DB.TabIndex = 6
        Me.Btn_View_DB.Text = "View Database"
        Me.Btn_View_DB.UseVisualStyleBackColor = False
        '
        'Btn_Clear
        '
        Me.Btn_Clear.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Clear.Location = New System.Drawing.Point(658, 12)
        Me.Btn_Clear.Name = "Btn_Clear"
        Me.Btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.Btn_Clear.TabIndex = 7
        Me.Btn_Clear.Text = "Clear List"
        Me.Btn_Clear.UseVisualStyleBackColor = False
        '
        'FileSearchForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(745, 220)
        Me.Controls.Add(Me.Btn_Clear)
        Me.Controls.Add(Me.Btn_View_DB)
        Me.Controls.Add(Me.Lbl_Folder_Path)
        Me.Controls.Add(Me.Btn_Find_Files)
        Me.Controls.Add(Me.Btn_Add_Files)
        Me.Controls.Add(Me.StatusStrip)
        Me.Controls.Add(Me.File_List)
        Me.Controls.Add(Me.Btn_Select_Folder)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(761, 259)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(761, 259)
        Me.Name = "FileSearchForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ID3 TAG V1 Database"
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Btn_Select_Folder As Button
    Friend WithEvents File_List As ListBox
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents StatusStrip As StatusStrip
    Friend WithEvents Status_Bar_Txt As ToolStripStatusLabel
    Friend WithEvents Btn_Add_Files As Button
    Friend WithEvents Btn_Find_Files As Button
    Friend WithEvents Lbl_Folder_Path As Label
    Friend WithEvents Status_Progress_Bar As ToolStripProgressBar
    Friend WithEvents Btn_View_DB As Button
    Friend WithEvents Btn_Clear As Button
End Class
