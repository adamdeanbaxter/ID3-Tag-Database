﻿Imports System.IO

Public Class FileSearchForm

    Private Sub Btn_Select_Folder_Click(sender As Object, e As EventArgs) Handles Btn_Select_Folder.Click

        Dim Result As DialogResult

        Result = Me.FolderBrowserDialog1.ShowDialog()

        If Result = DialogResult.OK Then

            Lbl_Folder_Path.Text = AddSlash(Me.FolderBrowserDialog1.SelectedPath)
            Btn_Find_Files.Enabled = True

        ElseIf Result = DialogResult.Cancel Then

            Me.FolderBrowserDialog1.Dispose()

        End If

    End Sub


    Private Function AddSlash(path As String) As String

        If Strings.Right(path, 1) <> "\" Then

            AddSlash = path & "\"

        Else

            AddSlash = path

        End If

    End Function

    Private Sub Btn_Find_Files_Click(sender As Object, e As EventArgs) Handles Btn_Find_Files.Click

        Try
            Dim mp3FilesArray As String() = Directory.GetFiles(Lbl_Folder_Path.Text, "*.Mp3", SearchOption.AllDirectories)
            Dim wmaFilesArray As String() = Directory.GetFiles(Lbl_Folder_Path.Text, "*.Wma", SearchOption.AllDirectories)
            Dim progresscount As Integer = 0

            Me.Status_Progress_Bar.Maximum = mp3FilesArray.Count + wmaFilesArray.Count

            For Each mp3Files As String In mp3FilesArray

                File_List.Items.Add(mp3Files)
                progresscount = progresscount + 1
                Me.Status_Progress_Bar.Value = progresscount

            Next

            For Each wmaFiles As String In wmaFilesArray

                Me.Status_Bar_Txt.Text = wmaFiles
                File_List.Items.Add(wmaFiles)
                progresscount = progresscount + 1
                Me.Status_Progress_Bar.Value = progresscount

            Next

            Me.Status_Bar_Txt.Text = "Done " & File_List.Items.Count & " files found!"

            If File_List.Items.Count > 0 Then

                Btn_Add_Files.Enabled = True
                Btn_Find_Files.Enabled = False

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try



    End Sub

    Private Function GetTagInfo(filename As String)

        Dim objMP3 As New MP3ID3(filename)
        Dim TagInfo(8) As String

        Try

            If objMP3.TagExists Then

                TagInfo(0) = Trim(objMP3.Frame(MP3ID3.FrameTypes.Title))
                TagInfo(1) = Trim(objMP3.Frame(MP3ID3.FrameTypes.Artist))
                TagInfo(2) = Trim(objMP3.Frame(MP3ID3.FrameTypes.Album))
                TagInfo(3) = Trim(objMP3.Frame(MP3ID3.FrameTypes.Year))
                TagInfo(4) = Trim(objMP3.Frame(MP3ID3.FrameTypes.Track))
                TagInfo(5) = Trim(objMP3.Frame(MP3ID3.FrameTypes.Comment))
                TagInfo(6) = Trim(ReturnEnumText(objMP3.Frame(MP3ID3.FrameTypes.Genre)))
                TagInfo(7) = filename

            ElseIf Not objMP3.TagExists Then
                TagInfo(0) = ""
                TagInfo(1) = ""
                TagInfo(2) = ""
                TagInfo(3) = ""
                TagInfo(4) = ""
                TagInfo(5) = ""
                TagInfo(6) = ""
                TagInfo(7) = filename

            End If

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Return TagInfo

    End Function



    Private Sub Btn_Add_Files_Click(sender As Object, e As EventArgs) Handles Btn_Add_Files.Click

        Dim TagInfo() As String
        Dim i As Integer = 0
        Me.Status_Bar_Txt.Text = "Populating Database..."
        Me.Update()
        Me.Status_Progress_Bar.Value = 0
        Me.Status_Progress_Bar.Maximum = File_List.Items.Count

        Btn_Select_Folder.Enabled = False
        Btn_View_DB.Enabled = False
        Btn_Add_Files.Enabled = False

        For Each ListBoxItem As String In File_List.Items

            TagInfo = GetTagInfo(ListBoxItem)
            i = i + 1

            Try

                ID3DataGridForm.ID3InfoTableAdapter.Insert(TagInfo(0), TagInfo(1), TagInfo(2), TagInfo(3), TagInfo(4), TagInfo(5), TagInfo(6), TagInfo(7))
                ID3DataGridForm.ID3InfoBindingSource.EndEdit()

            Catch ex As Exception

                MessageBox.Show(ex.Message)

            End Try

            Me.Status_Progress_Bar.Value = i

        Next

        Try

            ID3DataGridForm.ID3InfoTableAdapter.Update(ID3DataGridForm.ID3InfoDataSet1.ID3Info)

        Catch ex As Exception

            MessageBox.Show(ex.Message)

        End Try

        Me.Status_Bar_Txt.Text = "Data Population Complete!"
        Me.Update()
        Me.Hide()
        ID3DataGridForm.Show()

    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_View_DB.Click

        Me.Hide()
        ID3DataGridForm.Show()

    End Sub

    Private Sub Btn_Clear_Click(sender As Object, e As EventArgs) Handles Btn_Clear.Click

        File_List.Items.Clear()
        Status_Progress_Bar.Value = 0
        Status_Bar_Txt.Text = ""
        Me.Update()

    End Sub

    Private Sub FileSearchForm_Load(sender As Object, e As EventArgs) Handles Me.Load

        Status_Bar_Txt.Text = ""
        Status_Progress_Bar.Value = 0

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        'Dim i As Integer
        'MessageBox.Show(MP3ID3.Genres.)

    End Sub

    Private Function ReturnEnumText(EnumNo As String) As String

        Dim myGenres As MP3ID3.Genres = CInt(EnumNo)
        Return myGenres.ToString()

    End Function
End Class