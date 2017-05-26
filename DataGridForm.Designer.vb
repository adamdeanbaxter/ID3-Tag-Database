<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ID3DataGridForm
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ID3DataGridForm))
        Me.ID3InfoDataGridView = New System.Windows.Forms.DataGridView()
        Me.Btn_Add_New = New System.Windows.Forms.Button()
        Me.Btn_Save_Rec = New System.Windows.Forms.Button()
        Me.Btn_Prev_Rec = New System.Windows.Forms.Button()
        Me.Btn_Next_Rec = New System.Windows.Forms.Button()
        Me.Btn_Del_Rec = New System.Windows.Forms.Button()
        Me.Btn_Exit = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TxtBx_Search = New System.Windows.Forms.TextBox()
        Me.Btn_Search = New System.Windows.Forms.Button()
        Me.Btn_Rst_Search = New System.Windows.Forms.Button()
        Me.Group_Box_Controls = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Btn_Update_Tag = New System.Windows.Forms.Button()
        Me.Group_Box_DataGrid = New System.Windows.Forms.GroupBox()
        Me.Btn_Go_Back = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_Stop = New System.Windows.Forms.PictureBox()
        Me.Btn_Play = New System.Windows.Forms.PictureBox()
        Me.Grp_SearchRdo = New System.Windows.Forms.GroupBox()
        Me.Rdo_Title = New System.Windows.Forms.RadioButton()
        Me.Rdo_Genre = New System.Windows.Forms.RadioButton()
        Me.Rdo_Artist = New System.Windows.Forms.RadioButton()
        Me.Rdo_Comment = New System.Windows.Forms.RadioButton()
        Me.Rdo_Album = New System.Windows.Forms.RadioButton()
        Me.Rdo_Track = New System.Windows.Forms.RadioButton()
        Me.Rdo_Year = New System.Windows.Forms.RadioButton()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ID3InfoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ID3InfoDataSet1 = New ID3TagDatabase.ID3InfoDataSet()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtistDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AlbumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.YrDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TrackDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CommentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PathDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID3InfoTableAdapter = New ID3TagDatabase.ID3InfoDataSetTableAdapters.ID3InfoTableAdapter()
        Me.TableAdapterManager = New ID3TagDatabase.ID3InfoDataSetTableAdapters.TableAdapterManager()
        Me.ClrProgressBar = New System.Windows.Forms.ProgressBar()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.ID3InfoDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group_Box_Controls.SuspendLayout()
        Me.Group_Box_DataGrid.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Btn_Stop, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Btn_Play, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Grp_SearchRdo.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ID3InfoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ID3InfoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ID3InfoDataGridView
        '
        Me.ID3InfoDataGridView.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID3InfoDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.ID3InfoDataGridView.AutoGenerateColumns = False
        Me.ID3InfoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.ID3InfoDataGridView.BackgroundColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.ID3InfoDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.ID3InfoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ID3InfoDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.TitleDataGridViewTextBoxColumn, Me.ArtistDataGridViewTextBoxColumn, Me.AlbumDataGridViewTextBoxColumn, Me.YrDataGridViewTextBoxColumn, Me.TrackDataGridViewTextBoxColumn, Me.CommentDataGridViewTextBoxColumn, Me.GenreDataGridViewTextBoxColumn, Me.PathDataGridViewTextBoxColumn})
        Me.ID3InfoDataGridView.DataSource = Me.ID3InfoBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.ID3InfoDataGridView.DefaultCellStyle = DataGridViewCellStyle9
        Me.ID3InfoDataGridView.Location = New System.Drawing.Point(274, 45)
        Me.ID3InfoDataGridView.Name = "ID3InfoDataGridView"
        Me.ID3InfoDataGridView.Size = New System.Drawing.Size(720, 549)
        Me.ID3InfoDataGridView.TabIndex = 1
        '
        'Btn_Add_New
        '
        Me.Btn_Add_New.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Add_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Add_New.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Add_New.Location = New System.Drawing.Point(14, 19)
        Me.Btn_Add_New.Name = "Btn_Add_New"
        Me.Btn_Add_New.Size = New System.Drawing.Size(107, 32)
        Me.Btn_Add_New.TabIndex = 2
        Me.Btn_Add_New.Text = "AddNew"
        Me.Btn_Add_New.UseVisualStyleBackColor = False
        '
        'Btn_Save_Rec
        '
        Me.Btn_Save_Rec.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Save_Rec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Save_Rec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Save_Rec.Location = New System.Drawing.Point(14, 57)
        Me.Btn_Save_Rec.Name = "Btn_Save_Rec"
        Me.Btn_Save_Rec.Size = New System.Drawing.Size(107, 32)
        Me.Btn_Save_Rec.TabIndex = 3
        Me.Btn_Save_Rec.Text = "Save"
        Me.Btn_Save_Rec.UseVisualStyleBackColor = False
        '
        'Btn_Prev_Rec
        '
        Me.Btn_Prev_Rec.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Prev_Rec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Prev_Rec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Prev_Rec.Location = New System.Drawing.Point(74, 204)
        Me.Btn_Prev_Rec.Name = "Btn_Prev_Rec"
        Me.Btn_Prev_Rec.Size = New System.Drawing.Size(79, 32)
        Me.Btn_Prev_Rec.TabIndex = 4
        Me.Btn_Prev_Rec.Text = "< Previous "
        Me.Btn_Prev_Rec.UseVisualStyleBackColor = False
        '
        'Btn_Next_Rec
        '
        Me.Btn_Next_Rec.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Next_Rec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Next_Rec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Next_Rec.Location = New System.Drawing.Point(152, 204)
        Me.Btn_Next_Rec.Name = "Btn_Next_Rec"
        Me.Btn_Next_Rec.Size = New System.Drawing.Size(77, 32)
        Me.Btn_Next_Rec.TabIndex = 5
        Me.Btn_Next_Rec.Text = "Next >"
        Me.Btn_Next_Rec.UseVisualStyleBackColor = False
        '
        'Btn_Del_Rec
        '
        Me.Btn_Del_Rec.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Del_Rec.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Del_Rec.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Del_Rec.Location = New System.Drawing.Point(14, 95)
        Me.Btn_Del_Rec.Name = "Btn_Del_Rec"
        Me.Btn_Del_Rec.Size = New System.Drawing.Size(107, 32)
        Me.Btn_Del_Rec.TabIndex = 6
        Me.Btn_Del_Rec.Text = "Delete"
        Me.Btn_Del_Rec.UseVisualStyleBackColor = False
        '
        'Btn_Exit
        '
        Me.Btn_Exit.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Exit.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Exit.Location = New System.Drawing.Point(183, 563)
        Me.Btn_Exit.Name = "Btn_Exit"
        Me.Btn_Exit.Size = New System.Drawing.Size(85, 32)
        Me.Btn_Exit.TabIndex = 7
        Me.Btn_Exit.Text = "Exit"
        Me.Btn_Exit.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(36, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Title:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(31, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Artist:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(25, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Album:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(36, 99)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 16)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Year:"
        '
        'TextBox1
        '
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ID3InfoBindingSource, "Title", True))
        Me.TextBox1.Location = New System.Drawing.Point(74, 20)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(155, 22)
        Me.TextBox1.TabIndex = 12
        '
        'TextBox2
        '
        Me.TextBox2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ID3InfoBindingSource, "Artist", True))
        Me.TextBox2.Location = New System.Drawing.Point(74, 46)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(155, 22)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ID3InfoBindingSource, "Album", True))
        Me.TextBox3.Location = New System.Drawing.Point(74, 72)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(155, 22)
        Me.TextBox3.TabIndex = 14
        '
        'TextBox4
        '
        Me.TextBox4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ID3InfoBindingSource, "Yr", True))
        Me.TextBox4.Location = New System.Drawing.Point(74, 98)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(155, 22)
        Me.TextBox4.TabIndex = 15
        '
        'TxtBx_Search
        '
        Me.TxtBx_Search.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtBx_Search.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtBx_Search.Location = New System.Drawing.Point(22, 12)
        Me.TxtBx_Search.Name = "TxtBx_Search"
        Me.TxtBx_Search.Size = New System.Drawing.Size(243, 29)
        Me.TxtBx_Search.TabIndex = 16
        '
        'Btn_Search
        '
        Me.Btn_Search.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Search.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Search.Location = New System.Drawing.Point(274, 12)
        Me.Btn_Search.Name = "Btn_Search"
        Me.Btn_Search.Size = New System.Drawing.Size(74, 30)
        Me.Btn_Search.TabIndex = 17
        Me.Btn_Search.Text = "Search"
        Me.Btn_Search.UseVisualStyleBackColor = False
        '
        'Btn_Rst_Search
        '
        Me.Btn_Rst_Search.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Rst_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Rst_Search.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Rst_Search.Location = New System.Drawing.Point(354, 12)
        Me.Btn_Rst_Search.Name = "Btn_Rst_Search"
        Me.Btn_Rst_Search.Size = New System.Drawing.Size(74, 30)
        Me.Btn_Rst_Search.TabIndex = 18
        Me.Btn_Rst_Search.Text = "Reset"
        Me.Btn_Rst_Search.UseVisualStyleBackColor = False
        '
        'Group_Box_Controls
        '
        Me.Group_Box_Controls.Controls.Add(Me.Label7)
        Me.Group_Box_Controls.Controls.Add(Me.Label6)
        Me.Group_Box_Controls.Controls.Add(Me.TextBox8)
        Me.Group_Box_Controls.Controls.Add(Me.TextBox7)
        Me.Group_Box_Controls.Controls.Add(Me.Label5)
        Me.Group_Box_Controls.Controls.Add(Me.Btn_Prev_Rec)
        Me.Group_Box_Controls.Controls.Add(Me.Btn_Next_Rec)
        Me.Group_Box_Controls.Controls.Add(Me.TextBox6)
        Me.Group_Box_Controls.Controls.Add(Me.TextBox4)
        Me.Group_Box_Controls.Controls.Add(Me.TextBox3)
        Me.Group_Box_Controls.Controls.Add(Me.TextBox2)
        Me.Group_Box_Controls.Controls.Add(Me.TextBox1)
        Me.Group_Box_Controls.Controls.Add(Me.Label4)
        Me.Group_Box_Controls.Controls.Add(Me.Label3)
        Me.Group_Box_Controls.Controls.Add(Me.Label2)
        Me.Group_Box_Controls.Controls.Add(Me.Label1)
        Me.Group_Box_Controls.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group_Box_Controls.Location = New System.Drawing.Point(22, 223)
        Me.Group_Box_Controls.Name = "Group_Box_Controls"
        Me.Group_Box_Controls.Size = New System.Drawing.Size(243, 250)
        Me.Group_Box_Controls.TabIndex = 19
        Me.Group_Box_Controls.TabStop = False
        Me.Group_Box_Controls.Text = "Edit Tag Info Here"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(6, 150)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 16)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Comment:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(27, 176)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 16)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "Genre:"
        '
        'TextBox8
        '
        Me.TextBox8.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ID3InfoBindingSource, "Genre", True))
        Me.TextBox8.Location = New System.Drawing.Point(74, 176)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(155, 22)
        Me.TextBox8.TabIndex = 19
        '
        'TextBox7
        '
        Me.TextBox7.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ID3InfoBindingSource, "Comment", True))
        Me.TextBox7.Location = New System.Drawing.Point(74, 150)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(155, 22)
        Me.TextBox7.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(30, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 16)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Track:"
        '
        'TextBox6
        '
        Me.TextBox6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ID3InfoBindingSource, "Track", True))
        Me.TextBox6.Location = New System.Drawing.Point(74, 122)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(155, 22)
        Me.TextBox6.TabIndex = 16
        '
        'Btn_Update_Tag
        '
        Me.Btn_Update_Tag.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Update_Tag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Update_Tag.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Update_Tag.Location = New System.Drawing.Point(14, 133)
        Me.Btn_Update_Tag.Name = "Btn_Update_Tag"
        Me.Btn_Update_Tag.Size = New System.Drawing.Size(107, 32)
        Me.Btn_Update_Tag.TabIndex = 22
        Me.Btn_Update_Tag.Text = "Update ID3 Tag"
        Me.Btn_Update_Tag.UseVisualStyleBackColor = False
        '
        'Group_Box_DataGrid
        '
        Me.Group_Box_DataGrid.Controls.Add(Me.Button2)
        Me.Group_Box_DataGrid.Controls.Add(Me.ClrProgressBar)
        Me.Group_Box_DataGrid.Controls.Add(Me.Button1)
        Me.Group_Box_DataGrid.Controls.Add(Me.Btn_Go_Back)
        Me.Group_Box_DataGrid.Controls.Add(Me.GroupBox1)
        Me.Group_Box_DataGrid.Controls.Add(Me.Btn_Stop)
        Me.Group_Box_DataGrid.Controls.Add(Me.Group_Box_Controls)
        Me.Group_Box_DataGrid.Controls.Add(Me.Btn_Play)
        Me.Group_Box_DataGrid.Controls.Add(Me.Grp_SearchRdo)
        Me.Group_Box_DataGrid.Controls.Add(Me.Btn_Rst_Search)
        Me.Group_Box_DataGrid.Controls.Add(Me.Btn_Search)
        Me.Group_Box_DataGrid.Controls.Add(Me.TxtBx_Search)
        Me.Group_Box_DataGrid.Controls.Add(Me.ID3InfoDataGridView)
        Me.Group_Box_DataGrid.Controls.Add(Me.Btn_Exit)
        Me.Group_Box_DataGrid.Location = New System.Drawing.Point(12, 28)
        Me.Group_Box_DataGrid.Name = "Group_Box_DataGrid"
        Me.Group_Box_DataGrid.Size = New System.Drawing.Size(1000, 600)
        Me.Group_Box_DataGrid.TabIndex = 20
        Me.Group_Box_DataGrid.TabStop = False
        '
        'Btn_Go_Back
        '
        Me.Btn_Go_Back.BackColor = System.Drawing.SystemColors.Window
        Me.Btn_Go_Back.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Btn_Go_Back.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_Go_Back.Location = New System.Drawing.Point(22, 563)
        Me.Btn_Go_Back.Name = "Btn_Go_Back"
        Me.Btn_Go_Back.Size = New System.Drawing.Size(111, 32)
        Me.Btn_Go_Back.TabIndex = 35
        Me.Btn_Go_Back.Text = "< Go Back"
        Me.Btn_Go_Back.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_Add_New)
        Me.GroupBox1.Controls.Add(Me.Btn_Update_Tag)
        Me.GroupBox1.Controls.Add(Me.Btn_Del_Rec)
        Me.GroupBox1.Controls.Add(Me.Btn_Save_Rec)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(132, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(133, 177)
        Me.GroupBox1.TabIndex = 34
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Database Controls"
        '
        'Btn_Stop
        '
        Me.Btn_Stop.Image = Global.ID3TagDatabase.My.Resources.Resources.StopButton
        Me.Btn_Stop.Location = New System.Drawing.Point(475, 9)
        Me.Btn_Stop.Name = "Btn_Stop"
        Me.Btn_Stop.Size = New System.Drawing.Size(35, 34)
        Me.Btn_Stop.TabIndex = 33
        Me.Btn_Stop.TabStop = False
        '
        'Btn_Play
        '
        Me.Btn_Play.Image = Global.ID3TagDatabase.My.Resources.Resources.PlayButton
        Me.Btn_Play.Location = New System.Drawing.Point(434, 9)
        Me.Btn_Play.Name = "Btn_Play"
        Me.Btn_Play.Size = New System.Drawing.Size(35, 33)
        Me.Btn_Play.TabIndex = 32
        Me.Btn_Play.TabStop = False
        '
        'Grp_SearchRdo
        '
        Me.Grp_SearchRdo.Controls.Add(Me.Rdo_Title)
        Me.Grp_SearchRdo.Controls.Add(Me.Rdo_Genre)
        Me.Grp_SearchRdo.Controls.Add(Me.Rdo_Artist)
        Me.Grp_SearchRdo.Controls.Add(Me.Rdo_Comment)
        Me.Grp_SearchRdo.Controls.Add(Me.Rdo_Album)
        Me.Grp_SearchRdo.Controls.Add(Me.Rdo_Track)
        Me.Grp_SearchRdo.Controls.Add(Me.Rdo_Year)
        Me.Grp_SearchRdo.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Grp_SearchRdo.Location = New System.Drawing.Point(22, 45)
        Me.Grp_SearchRdo.Name = "Grp_SearchRdo"
        Me.Grp_SearchRdo.Size = New System.Drawing.Size(104, 177)
        Me.Grp_SearchRdo.TabIndex = 29
        Me.Grp_SearchRdo.TabStop = False
        Me.Grp_SearchRdo.Text = "Search By:"
        '
        'Rdo_Title
        '
        Me.Rdo_Title.AutoSize = True
        Me.Rdo_Title.Location = New System.Drawing.Point(7, 15)
        Me.Rdo_Title.Name = "Rdo_Title"
        Me.Rdo_Title.Size = New System.Drawing.Size(50, 20)
        Me.Rdo_Title.TabIndex = 22
        Me.Rdo_Title.TabStop = True
        Me.Rdo_Title.Text = "Title"
        Me.Rdo_Title.UseVisualStyleBackColor = True
        '
        'Rdo_Genre
        '
        Me.Rdo_Genre.AutoSize = True
        Me.Rdo_Genre.Location = New System.Drawing.Point(7, 153)
        Me.Rdo_Genre.Name = "Rdo_Genre"
        Me.Rdo_Genre.Size = New System.Drawing.Size(61, 20)
        Me.Rdo_Genre.TabIndex = 28
        Me.Rdo_Genre.TabStop = True
        Me.Rdo_Genre.Text = "Genre"
        Me.Rdo_Genre.UseVisualStyleBackColor = True
        '
        'Rdo_Artist
        '
        Me.Rdo_Artist.AutoSize = True
        Me.Rdo_Artist.Location = New System.Drawing.Point(7, 38)
        Me.Rdo_Artist.Name = "Rdo_Artist"
        Me.Rdo_Artist.Size = New System.Drawing.Size(57, 20)
        Me.Rdo_Artist.TabIndex = 23
        Me.Rdo_Artist.TabStop = True
        Me.Rdo_Artist.Text = "Artist"
        Me.Rdo_Artist.UseVisualStyleBackColor = True
        '
        'Rdo_Comment
        '
        Me.Rdo_Comment.AutoSize = True
        Me.Rdo_Comment.Location = New System.Drawing.Point(7, 130)
        Me.Rdo_Comment.Name = "Rdo_Comment"
        Me.Rdo_Comment.Size = New System.Drawing.Size(82, 20)
        Me.Rdo_Comment.TabIndex = 27
        Me.Rdo_Comment.TabStop = True
        Me.Rdo_Comment.Text = "Comment"
        Me.Rdo_Comment.UseVisualStyleBackColor = True
        '
        'Rdo_Album
        '
        Me.Rdo_Album.AutoSize = True
        Me.Rdo_Album.Location = New System.Drawing.Point(7, 62)
        Me.Rdo_Album.Name = "Rdo_Album"
        Me.Rdo_Album.Size = New System.Drawing.Size(63, 20)
        Me.Rdo_Album.TabIndex = 24
        Me.Rdo_Album.TabStop = True
        Me.Rdo_Album.Text = "Album"
        Me.Rdo_Album.UseVisualStyleBackColor = True
        '
        'Rdo_Track
        '
        Me.Rdo_Track.AutoSize = True
        Me.Rdo_Track.Location = New System.Drawing.Point(7, 107)
        Me.Rdo_Track.Name = "Rdo_Track"
        Me.Rdo_Track.Size = New System.Drawing.Size(58, 20)
        Me.Rdo_Track.TabIndex = 26
        Me.Rdo_Track.TabStop = True
        Me.Rdo_Track.Text = "Track"
        Me.Rdo_Track.UseVisualStyleBackColor = True
        '
        'Rdo_Year
        '
        Me.Rdo_Year.AutoSize = True
        Me.Rdo_Year.Location = New System.Drawing.Point(7, 84)
        Me.Rdo_Year.Name = "Rdo_Year"
        Me.Rdo_Year.Size = New System.Drawing.Size(52, 20)
        Me.Rdo_Year.TabIndex = 25
        Me.Rdo_Year.TabStop = True
        Me.Rdo_Year.Text = "Year"
        Me.Rdo_Year.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BackColor = System.Drawing.SystemColors.Window
        Me.BindingNavigator1.BindingSource = Me.ID3InfoBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2})
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 0)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(1024, 25)
        Me.BindingNavigator1.TabIndex = 21
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Window
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(780, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 23)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "Clear Database"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ID3InfoBindingSource
        '
        Me.ID3InfoBindingSource.DataMember = "ID3Info"
        Me.ID3InfoBindingSource.DataSource = Me.ID3InfoDataSet1
        '
        'ID3InfoDataSet1
        '
        Me.ID3InfoDataSet1.DataSetName = "ID3InfoDataSet"
        Me.ID3InfoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        Me.IDDataGridViewTextBoxColumn.Width = 45
        '
        'TitleDataGridViewTextBoxColumn
        '
        Me.TitleDataGridViewTextBoxColumn.DataPropertyName = "Title"
        Me.TitleDataGridViewTextBoxColumn.HeaderText = "Title"
        Me.TitleDataGridViewTextBoxColumn.Name = "TitleDataGridViewTextBoxColumn"
        Me.TitleDataGridViewTextBoxColumn.Width = 57
        '
        'ArtistDataGridViewTextBoxColumn
        '
        Me.ArtistDataGridViewTextBoxColumn.DataPropertyName = "Artist"
        Me.ArtistDataGridViewTextBoxColumn.HeaderText = "Artist"
        Me.ArtistDataGridViewTextBoxColumn.Name = "ArtistDataGridViewTextBoxColumn"
        Me.ArtistDataGridViewTextBoxColumn.Width = 64
        '
        'AlbumDataGridViewTextBoxColumn
        '
        Me.AlbumDataGridViewTextBoxColumn.DataPropertyName = "Album"
        Me.AlbumDataGridViewTextBoxColumn.HeaderText = "Album"
        Me.AlbumDataGridViewTextBoxColumn.Name = "AlbumDataGridViewTextBoxColumn"
        Me.AlbumDataGridViewTextBoxColumn.Width = 70
        '
        'YrDataGridViewTextBoxColumn
        '
        Me.YrDataGridViewTextBoxColumn.DataPropertyName = "Yr"
        Me.YrDataGridViewTextBoxColumn.HeaderText = "Yr"
        Me.YrDataGridViewTextBoxColumn.Name = "YrDataGridViewTextBoxColumn"
        Me.YrDataGridViewTextBoxColumn.Width = 46
        '
        'TrackDataGridViewTextBoxColumn
        '
        Me.TrackDataGridViewTextBoxColumn.DataPropertyName = "Track"
        Me.TrackDataGridViewTextBoxColumn.HeaderText = "Track"
        Me.TrackDataGridViewTextBoxColumn.Name = "TrackDataGridViewTextBoxColumn"
        Me.TrackDataGridViewTextBoxColumn.Width = 65
        '
        'CommentDataGridViewTextBoxColumn
        '
        Me.CommentDataGridViewTextBoxColumn.DataPropertyName = "Comment"
        Me.CommentDataGridViewTextBoxColumn.HeaderText = "Comment"
        Me.CommentDataGridViewTextBoxColumn.Name = "CommentDataGridViewTextBoxColumn"
        Me.CommentDataGridViewTextBoxColumn.Width = 89
        '
        'GenreDataGridViewTextBoxColumn
        '
        Me.GenreDataGridViewTextBoxColumn.DataPropertyName = "Genre"
        Me.GenreDataGridViewTextBoxColumn.HeaderText = "Genre"
        Me.GenreDataGridViewTextBoxColumn.Name = "GenreDataGridViewTextBoxColumn"
        Me.GenreDataGridViewTextBoxColumn.Width = 68
        '
        'PathDataGridViewTextBoxColumn
        '
        Me.PathDataGridViewTextBoxColumn.DataPropertyName = "Path"
        Me.PathDataGridViewTextBoxColumn.HeaderText = "Path"
        Me.PathDataGridViewTextBoxColumn.Name = "PathDataGridViewTextBoxColumn"
        Me.PathDataGridViewTextBoxColumn.Width = 60
        '
        'ID3InfoTableAdapter
        '
        Me.ID3InfoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ID3InfoTableAdapter = Me.ID3InfoTableAdapter
        Me.TableAdapterManager.UpdateOrder = ID3TagDatabase.ID3InfoDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClrProgressBar
        '
        Me.ClrProgressBar.Location = New System.Drawing.Point(894, 16)
        Me.ClrProgressBar.Name = "ClrProgressBar"
        Me.ClrProgressBar.Size = New System.Drawing.Size(100, 23)
        Me.ClrProgressBar.TabIndex = 37
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(573, 20)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ID3DataGridForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.BindingNavigator1)
        Me.Controls.Add(Me.Group_Box_DataGrid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1024, 640)
        Me.Name = "ID3DataGridForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ID3 Database Interface"
        CType(Me.ID3InfoDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group_Box_Controls.ResumeLayout(False)
        Me.Group_Box_Controls.PerformLayout()
        Me.Group_Box_DataGrid.ResumeLayout(False)
        Me.Group_Box_DataGrid.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Btn_Stop, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Btn_Play, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Grp_SearchRdo.ResumeLayout(False)
        Me.Grp_SearchRdo.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ID3InfoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ID3InfoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ID3InfoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ID3InfoDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents Btn_Add_New As System.Windows.Forms.Button
    Friend WithEvents Btn_Save_Rec As System.Windows.Forms.Button
    Friend WithEvents Btn_Prev_Rec As System.Windows.Forms.Button
    Friend WithEvents Btn_Next_Rec As System.Windows.Forms.Button
    Friend WithEvents Btn_Del_Rec As System.Windows.Forms.Button
    Friend WithEvents Btn_Exit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TxtBx_Search As System.Windows.Forms.TextBox
    Friend WithEvents Btn_Search As System.Windows.Forms.Button
    Friend WithEvents Btn_Rst_Search As System.Windows.Forms.Button
    Friend WithEvents Group_Box_Controls As System.Windows.Forms.GroupBox
    Friend WithEvents Group_Box_DataGrid As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents ID3InfoDataSet1 As ID3InfoDataSet
    Friend WithEvents ID3InfoTableAdapter As ID3InfoDataSetTableAdapters.ID3InfoTableAdapter
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents TableAdapterManager As ID3InfoDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Rdo_Genre As RadioButton
    Friend WithEvents Rdo_Comment As RadioButton
    Friend WithEvents Rdo_Track As RadioButton
    Friend WithEvents Rdo_Year As RadioButton
    Friend WithEvents Rdo_Album As RadioButton
    Friend WithEvents Rdo_Artist As RadioButton
    Friend WithEvents Rdo_Title As RadioButton
    Friend WithEvents Grp_SearchRdo As GroupBox
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TitleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArtistDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AlbumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents YrDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TrackDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CommentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PathDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Btn_Update_Tag As Button
    Friend WithEvents Btn_Play As PictureBox
    Friend WithEvents Btn_Stop As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_Go_Back As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ClrProgressBar As ProgressBar
    Friend WithEvents Button2 As Button
End Class
