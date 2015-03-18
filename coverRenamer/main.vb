Public Class main

    Dim logic As New logicWrapper

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

        dg.AutoGenerateColumns = False
        dg.DataSource = logic.analize(rompath.Text, originalcoverpath.Text)

    End Sub
    Private Sub btnExecute_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecute.Click

        logic.renameCovers(originalcoverpath.Text, _
                          renamedcoverpath.Text, _
                          CType(dg.DataSource, DataTable).Select(" match='S'", ""))


    End Sub



End Class
