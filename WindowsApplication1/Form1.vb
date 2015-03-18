Public Class Form1



    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        rompath.Text = "H:\snes9xgx\roms"
        originalcoverpath.Text = "D:\#temp\Wii\covers\SNES Vert Shrunken Spine (753)\SNES Vert Shrunken Spine (753)\all"
        renamedcoverpath.Text = "D:\#temp\Wii\covers\wiiflow renamed\vert"
    End Sub



    Private Sub btnSearchRom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRom.Click
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.SelectedPath = rompath.Text
        FolderBrowserDialog1.ShowDialog()
        rompath.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub btnSearchCovers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchCovers.Click
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.SelectedPath = originalcoverpath.Text
        FolderBrowserDialog1.ShowDialog()
        originalcoverpath.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub btnSearchRenamed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchRenamed.Click
        FolderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer
        FolderBrowserDialog1.SelectedPath = renamedcoverpath.Text
        FolderBrowserDialog1.ShowDialog()
        renamedcoverpath.Text = FolderBrowserDialog1.SelectedPath
    End Sub
    Private Sub btnAnalize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAnalize.Click
        analize()
    End Sub



    Private Sub analize()
        Dim dt As New DataTable

        dt.Columns.Add("rom", GetType(String))
        dt.Columns.Add("romParsed", GetType(String))
        dt.Columns.Add("cover", GetType(String))
        dt.Columns.Add("match", GetType(String))

        dt.Columns.Add("game", GetType(String))
        dt.Columns.Add("word0", GetType(String))
        dt.Columns.Add("word1", GetType(String))
        dt.Columns.Add("word2", GetType(String))
        dt.Columns.Add("word3", GetType(String))
        dt.Columns.Add("word4", GetType(String))
        dt.Columns.Add("word5", GetType(String))
        dt.Columns.Add("word6", GetType(String))
        dt.Columns.Add("word7", GetType(String))
        dt.Columns.Add("word8", GetType(String))
        dt.Columns.Add("word9", GetType(String))
        dt.Columns.Add("attribute0", GetType(String))
        dt.Columns.Add("attribute1", GetType(String))
        dt.Columns.Add("attribute2", GetType(String))
        dt.Columns.Add("attribute3", GetType(String))
        dt.Columns.Add("attribute4", GetType(String))
        dt.Columns.Add("attribute5", GetType(String))
        dt.Columns.Add("attribute6", GetType(String))
        dt.Columns.Add("attribute7", GetType(String))
        dt.Columns.Add("attribute8", GetType(String))
        dt.Columns.Add("attribute9", GetType(String))
        dt.Columns.Add("index", GetType(Integer))

        Dim dtCovers As New DataTable
        dtCovers.Columns.Add("cover", GetType(String))
        dtCovers.Columns.Add("coverParsed", GetType(String))
        dtCovers.Columns.Add("game", GetType(String))
        dtCovers.Columns.Add("word0", GetType(String))
        dtCovers.Columns.Add("word1", GetType(String))
        dtCovers.Columns.Add("word2", GetType(String))
        dtCovers.Columns.Add("word3", GetType(String))
        dtCovers.Columns.Add("word4", GetType(String))
        dtCovers.Columns.Add("word5", GetType(String))
        dtCovers.Columns.Add("word6", GetType(String))
        dtCovers.Columns.Add("word7", GetType(String))
        dtCovers.Columns.Add("word8", GetType(String))
        dtCovers.Columns.Add("word9", GetType(String))
        dtCovers.Columns.Add("attribute0", GetType(String))
        dtCovers.Columns.Add("attribute1", GetType(String))
        dtCovers.Columns.Add("attribute2", GetType(String))
        dtCovers.Columns.Add("attribute3", GetType(String))
        dtCovers.Columns.Add("attribute4", GetType(String))
        dtCovers.Columns.Add("attribute5", GetType(String))
        dtCovers.Columns.Add("attribute6", GetType(String))
        dtCovers.Columns.Add("attribute7", GetType(String))
        dtCovers.Columns.Add("attribute8", GetType(String))
        dtCovers.Columns.Add("attribute9", GetType(String))
        dtCovers.Columns.Add("index", GetType(Integer))

        'scan rom path to get all romnames
        For Each file As String In My.Computer.FileSystem.GetFiles(rompath.Text)
            Dim newLine As DataRow = dt.NewRow
            With newLine
                .Item("rom") = file.Replace(rompath.Text, "").Replace("\", "")
                .Item("game") = Trim(.Item("rom"))
                .Item("game") = Mid(.Item("game"), 1, .Item("game").ToString.LastIndexOf(".")) 'remove the extension

                Dim strToSplit As String = Trim(.Item("game"))
                Dim strSplit As String() = strToSplit.Split(" ")

                Dim indexx As Integer = 0
                For i As Integer = 0 To strSplit.Length - 1
                    If i > 9 Then Exit For
                    If Not (strSplit(i).Contains("(") Or strSplit(i).Contains(")") Or strSplit(i).Contains("[") Or strSplit(i).Contains("]")) Then
                        .Item("word" & indexx) = parse(strSplit(i))
                        indexx += 1
                    End If
                Next

                indexx = 0
                For i As Integer = 0 To strSplit.Length - 1
                    If indexx > 9 Then Exit For
                    If (strSplit(i).Contains("(") Or strSplit(i).Contains("[")) Then
                        .Item("attribute" & indexx) = strSplit(i)
                        indexx += 1
                    ElseIf (strSplit(i).Contains(")") Or strSplit(i).Contains("]")) Then
                        .Item("attribute" & indexx - 1) &= " " & strSplit(i)
                    End If
                Next
            End With
            dt.Rows.Add(newLine)
        Next


        'then, scan the cover path, and generate a list with all covers
        For Each file As String In My.Computer.FileSystem.GetFiles(originalcoverpath.Text)
            Dim newLine As DataRow = dtCovers.NewRow
            With newLine
                .Item("cover") = file.Replace(originalcoverpath.Text, "").Replace("\", "")
                .Item("game") = Trim(.Item("cover"))
                .Item("game") = Mid(.Item("game"), 1, .Item("game").ToString.LastIndexOf(".")) 'remove the extension

                Dim strToSplit As String = Trim(.Item("game"))
                Dim strSplit As String() = strToSplit.Split(" ")

                Dim indexx As Integer = 0
                For i As Integer = 0 To strSplit.Length - 1
                    If i > 9 Then Exit For
                    If Not (strSplit(i).Contains("(") Or strSplit(i).Contains(")") Or strSplit(i).Contains("[") Or strSplit(i).Contains("]")) Then
                        .Item("word" & indexx) = parse(strSplit(i))
                        indexx += 1
                    End If
                Next

                indexx = 0
                For i As Integer = 0 To strSplit.Length - 1
                    If indexx > 9 Then Exit For
                    If (strSplit(i).Contains("(") Or strSplit(i).Contains("[")) Then
                        .Item("attribute" & indexx) = strSplit(i)
                        indexx += 1
                    ElseIf (strSplit(i).Contains(")") Or strSplit(i).Contains("]")) Then
                        .Item("attribute" & indexx - 1) &= " " & strSplit(i)
                    End If
                Next
            End With
            dtCovers.Rows.Add(newLine)
        Next

        'now, we try to match the roms with its covers

        For i As Integer = 0 To dt.Rows.Count - 1
            'For Each rom As DataRow In dt.Rows
            Dim rom As DataRow = dt.Rows(i)
            Dim coverFile As String
            coverFile = locateCover(i, _
                                    dt, _
                                    dtCovers)
            rom.Item("cover") = coverFile
            If Not coverFile Is Nothing AndAlso coverFile.Length > 0 Then
                rom.Item("match") = "S"
            End If
        Next


        dg.AutoGenerateColumns = False
        dg.DataSource = dt

    End Sub
    Private Function locateCover(ByVal indexDT As Integer, _
                                 ByVal dtRoms As DataTable, _
                                 ByVal tableCovers As DataTable)
        Dim coverFile As String = ""
        Dim count As Integer = 0
        Dim result As Integer = 0

        Dim accuracy As Integer = 75

        'try to find an exact match
        count = tableCovers.Compute(" count(game)", " game ='" & parse(dtRoms.Rows(indexDT).Item("game")) & "'")

        Select Case count
            Case 0 'no exact match, so we need to start comparing the file names, word by word 

                Dim romWords As New ArrayList
                Dim dtCoverFiltered As DataTable = tableCovers

                'First, we need to get all the words of the rom gamename
                For i As Integer = 0 To 9
                    If Not IsDBNull(dtRoms.Rows(indexDT).Item("word" & i)) Then
                        romWords.Add(dtRoms.Rows(indexDT).Item("word" & i))
                    End If
                Next

                'Then, we are gonna look for the cover for this game, word by word
                For i As Integer = 0 To romWords.Count - 1
                    dtCoverFiltered.DefaultView.RowFilter = " word" & i & " = '" & parse(romWords(i)) & "'"
                    Select Case dtCoverFiltered.DefaultView.ToTable.Rows.Count
                        Case 0
                            'Ooops! no cover found with the last filter
                            Exit For
                        Case 1
                            'We found our cover! (hopefully)

                            'To make sure the cover selected is correct, lets look at the next word in the cover selected
                            ' if thats the correct cover, it should be empty

                            If Not romWords.Count = 10 Then
                                If Not IsDBNull(dtCoverFiltered.DefaultView.ToTable.Rows(0).Item("word" & romWords.Count)) Then
                                    Continue For
                                End If
                            End If

                            coverFile = dtCoverFiltered.DefaultView.ToTable.Rows(0).Item("cover")
                            Exit For
                        Case Else
                            'More than one result = we need to add more filters
                            dtCoverFiltered = dtCoverFiltered.DefaultView.ToTable
                    End Select
                Next


            Case 1 'we've found a exact match. Hooray!
                coverFile = tableCovers.Compute(" max(cover)", " game ='" & parse(dtRoms.Rows(indexDT).Item("game")) & "'")

            Case Else

        End Select


        'if we cannot find an exact match, lets try a less acurate search


        Return coverFile
    End Function
    Private Function parse(ByVal str As String) As String
        Return str.Replace("'", "")
    End Function


    Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click

        For Each dr As DataRow In CType(dg.DataSource, DataTable).Select(" match='S'", "")

            Dim sourceFile, destinationFile, coverExtension As String

            sourceFile = originalcoverpath.Text
            If Not Mid(sourceFile, sourceFile.Length, 1) = "/" Then
                sourceFile &= "\"
            End If
            sourceFile &= dr.Item("cover")

            coverExtension = Mid(sourceFile, sourceFile.ToString.LastIndexOf(".") + 1) 'remove the extension

            destinationFile = renamedcoverpath.Text
            If Not Mid(destinationFile, destinationFile.Length, 1) = "/" Then
                destinationFile &= "\"
            End If
            destinationFile &= dr.Item("rom") & coverExtension


            My.Computer.FileSystem.CopyFile(sourceFile, destinationFile)


        Next


    End Sub
End Class
