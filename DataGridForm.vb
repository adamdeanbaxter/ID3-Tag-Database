Option Explicit On

Imports NAudio
Imports NAudio.Wave

Public Class ID3DataGridForm

    Dim WaveOutDevice As IWavePlayer
    Dim audiofilereader As AudioFileReader
    Dim IsPlaying As Boolean

    Private Sub DataGridForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        IsPlaying = False
        WaveOutDevice = New WaveOut()

        Try

            Me.ID3InfoTableAdapter.Fill(Me.ID3InfoDataSet1.ID3Info)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Btn_Add_New_Click(sender As Object, e As EventArgs) Handles Btn_Add_New.Click

        ID3InfoBindingSource.AddNew()

    End Sub

    Private Sub Btn_Save_Rec_Click(sender As Object, e As EventArgs) Handles Btn_Save_Rec.Click

        Try

            ID3InfoBindingSource.EndEdit()
            ID3InfoTableAdapter.Update(ID3InfoDataSet1.ID3Info)
            MessageBox.Show("Record Saved")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub Btn_Del_Rec_Click(sender As Object, e As EventArgs) Handles Btn_Del_Rec.Click

        If MessageBox.Show("Are you Sure", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            Try

                ID3InfoBindingSource.RemoveCurrent()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

        End If

    End Sub

    Private Sub Btn_Exit_Click(sender As Object, e As EventArgs) Handles Btn_Exit.Click

        If MessageBox.Show("Do you want to Exit?", "Exit Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            ID3InfoBindingSource.EndEdit()
            ID3InfoTableAdapter.Update(ID3InfoDataSet1.ID3Info)
            Me.Close() 'End
            FileSearchForm.Close()

        End If

    End Sub

    Private Sub Btn_Prev_Rec_Click(sender As Object, e As EventArgs) Handles Btn_Prev_Rec.Click

        ID3InfoBindingSource.MovePrevious()

    End Sub

    Private Sub Btn_Next_Rec_Click(sender As Object, e As EventArgs) Handles Btn_Next_Rec.Click

        ID3InfoBindingSource.MoveNext()

    End Sub

    Private Sub Btn_Search_Click(sender As Object, e As EventArgs) Handles Btn_Search.Click

        If Rdo_Title.Checked = True Then

            ID3InfoDataGridView.DataSource = Me.ID3InfoDataSet1.ID3Info.Select("Title like '%" & TxtBx_Search.Text & "%'")

        ElseIf Rdo_Artist.Checked = True Then

            ID3InfoDataGridView.DataSource = Me.ID3InfoDataSet1.ID3Info.Select("Artist like '%" & TxtBx_Search.Text & "%'")

        ElseIf Rdo_Album.Checked = True Then

            ID3InfoDataGridView.DataSource = Me.ID3InfoDataSet1.ID3Info.Select("Album like '%" & TxtBx_Search.Text & "%'")

        ElseIf Rdo_Year.Checked = True Then

            ID3InfoDataGridView.DataSource = Me.ID3InfoDataSet1.ID3Info.Select("Yr like '%" & TxtBx_Search.Text & "%'")

        ElseIf Rdo_Track.Checked = True Then

            ID3InfoDataGridView.DataSource = Me.ID3InfoDataSet1.ID3Info.Select("Track like '%" & TxtBx_Search.Text & "%'")

        ElseIf Rdo_Comment.Checked = True Then

            ID3InfoDataGridView.DataSource = Me.ID3InfoDataSet1.ID3Info.Select("Comment like '%" & TxtBx_Search.Text & "%'")

        ElseIf Rdo_Genre.Checked = True Then

            ID3InfoDataGridView.DataSource = Me.ID3InfoDataSet1.ID3Info.Select("Genre like '%" & TxtBx_Search.Text & "%'")

        Else

            MessageBox.Show("Please select a search criteria before using the search function")

        End If

    End Sub

    Private Sub Btn_Rst_Search_Click(sender As Object, e As EventArgs) Handles Btn_Rst_Search.Click

        Try
            TxtBx_Search.Select()
            ID3InfoBindingSource.Filter = Nothing

            With ID3InfoDataGridView
                .ClearSelection()
                .ReadOnly = True
                .MultiSelect = False
                .DataSource = ID3InfoBindingSource
            End With

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub SetTagInfo(filename As String)

        Dim objMP3 As New MP3ID3(filename)
        Dim rowindex As Integer = ID3InfoDataGridView.CurrentRow.Index

        Try
            If Not ID3InfoDataGridView.Rows(rowindex).Cells(1).Value.ToString = "" Then

                objMP3.Frame(MP3ID3.FrameTypes.Title) = ID3InfoDataGridView.Rows(rowindex).Cells(1).Value.ToString

            End If

            If Not ID3InfoDataGridView.Rows(rowindex).Cells(2).Value.ToString = "" Then

                objMP3.Frame(MP3ID3.FrameTypes.Artist) = ID3InfoDataGridView.Rows(rowindex).Cells(2).Value.ToString

            End If

            If Not ID3InfoDataGridView.Rows(rowindex).Cells(3).Value.ToString = "" Then

                objMP3.Frame(MP3ID3.FrameTypes.Album) = ID3InfoDataGridView.Rows(rowindex).Cells(3).Value.ToString

            End If

            If Not ID3InfoDataGridView.Rows(rowindex).Cells(4).Value.ToString = "" Then

                objMP3.Frame(MP3ID3.FrameTypes.Year) = ID3InfoDataGridView.Rows(rowindex).Cells(4).Value.ToString

            End If

            If Not ID3InfoDataGridView.Rows(rowindex).Cells(5).Value.ToString = "" Then

                objMP3.Frame(MP3ID3.FrameTypes.Track) = ID3InfoDataGridView.Rows(rowindex).Cells(5).Value.ToString

            End If

            If Not ID3InfoDataGridView.Rows(rowindex).Cells(6).Value.ToString = "" Then

                objMP3.Frame(MP3ID3.FrameTypes.Comment) = ID3InfoDataGridView.Rows(rowindex).Cells(6).Value.ToString

            End If

            If Not ID3InfoDataGridView.Rows(rowindex).Cells(7).Value.ToString = "" Then

                objMP3.Frame(MP3ID3.FrameTypes.Genre) = ReturnEnumVal(ID3InfoDataGridView.Rows(rowindex).Cells(7).Value.ToString)

            End If

            objMP3.Update()
            MessageBox.Show("ID3 Tag Updated Successfully")

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try


    End Sub

    Private Sub Btn_Update_Tag_Click(sender As Object, e As EventArgs) Handles Btn_Update_Tag.Click
        If IsPlaying = False Then

            SetTagInfo(ID3InfoDataGridView.Rows(ID3InfoDataGridView.CurrentRow.Index).Cells(8).Value.ToString)

        ElseIf IsPlaying = True Then

            If MessageBox.Show("Cannot commit new ID3 Tag during music playback, would you like to stop playback?", "Playback Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                WaveOutDevice.Stop()

                If audiofilereader IsNot Nothing Then

                    audiofilereader.Dispose()

                End If

                IsPlaying = False

                SetTagInfo(ID3InfoDataGridView.Rows(ID3InfoDataGridView.CurrentRow.Index).Cells(8).Value.ToString)

                End If

            End If
    End Sub

    Private Sub Btn_Play_Click(sender As Object, e As EventArgs) Handles Btn_Play.Click
        Try

            If IsPlaying = False Then

                If Not ID3InfoDataGridView.Rows(ID3InfoDataGridView.CurrentRow.Index).Cells(8).Value.ToString = "" Then

                    audiofilereader = New AudioFileReader(ID3InfoDataGridView.Rows(ID3InfoDataGridView.CurrentRow.Index).Cells(8).Value.ToString)
                    WaveOutDevice.Init(audiofilereader)
                    WaveOutDevice.Play()
                    IsPlaying = True

                ElseIf ID3InfoDataGridView.Rows(ID3InfoDataGridView.CurrentRow.Index).Cells(8).Value.ToString = "" Then

                    MessageBox.Show("No Track selected! Please select a track before clicking play")

                End If

            ElseIf IsPlaying = True Then

                If MessageBox.Show("You cannot play multiple tracks at once, Would you like to stop the current track?", "Playback Error", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

                    WaveOutDevice.Stop()

                    If audiofilereader IsNot Nothing Then

                        audiofilereader.Dispose()

                    End If
                    IsPlaying = False

                End If

            End If

        Catch ex As Exception

            If ID3InfoDataGridView.SelectedRows.Count = 0 Then

                MessageBox.Show("No track selected, please select a track from the list")
                'Exit Sub
            Else

                MessageBox.Show(ex.Message)

            End if
        End Try
    End Sub

    Private Sub Btn_Stop_Click(sender As Object, e As EventArgs) Handles Btn_Stop.Click

        WaveOutDevice.Stop()

        If audiofilereader IsNot Nothing Then

            audiofilereader.Dispose()

        End If

        IsPlaying = False

    End Sub

    Private Sub Btn_Go_Back_Click(sender As Object, e As EventArgs) Handles Btn_Go_Back.Click

        WaveOutDevice.Stop()

        If audiofilereader IsNot Nothing Then

            audiofilereader.Dispose()

        End If

        IsPlaying = False
        Me.Close()
        FileSearchForm.Btn_Select_Folder.Enabled = True
        FileSearchForm.Btn_View_DB.Enabled = True
        FileSearchForm.Show()

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs)

        Try

            ID3InfoBindingSource.RemoveCurrent()

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

    End Sub

    Private Sub ID3DataGridForm_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        ID3InfoBindingSource.EndEdit()
        ID3InfoTableAdapter.Update(ID3InfoDataSet1.ID3Info)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        If MessageBox.Show("Are you sure you want to clear the database?", "Clear Database?", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then

            Try
                ID3InfoBindingSource.MoveFirst()
                ClrProgressBar.Maximum = ID3InfoBindingSource.Count

                For i = 1 To ID3InfoBindingSource.Count

                    ClrProgressBar.Value = i
                    ID3InfoBindingSource.RemoveCurrent()

                Next

                If ClrProgressBar.Value = ClrProgressBar.Maximum Then

                    MessageBox.Show("Database cleared!")

                End If

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            Finally

                ID3InfoBindingSource.EndEdit()
                ID3InfoTableAdapter.Update(ID3InfoDataSet1.ID3Info)
                ClrProgressBar.Value = 0

            End Try

        End If

    End Sub

    Private Function ReturnEnumVal(EnumName As String) As String

        Dim val As String = CType([Enum].Parse(GetType(MP3ID3.Genres), EnumName), Integer)
        Return val

    End Function

End Class