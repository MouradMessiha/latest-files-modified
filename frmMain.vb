Imports System.IO
Imports System.Collections

Public Class frmMain

   Private mobjFiles As New ArrayList

   Private Sub btnStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStart.Click

      Dim strRootFile As String
      Dim objFile As FileInfo
      Dim intFileCount As Int16

      Cursor.Current = Cursors.AppStarting
      btnStart.Enabled = False
      lstFiles.Items.Clear()

      For Each strRootFile In Directory.GetFiles("c:\", "*")
         objFile = New FileInfo
         objFile.FileName = strRootFile
         objFile.LastModified = My.Computer.FileSystem.GetFileInfo(strRootFile).LastWriteTime
         mobjFiles.Add(objFile)
      Next

      For Each strRootFile In Directory.GetDirectories("c:\", "*")
         ProcessAllFolders(strRootFile)
      Next

      mobjFiles.Sort()
      For intFileCount = 1 To 1000
         lstFiles.Items.Add(mobjFiles(mobjFiles.Count - intFileCount))
      Next

      btnStart.Enabled = True
      Cursor.Current = Cursors.Default

   End Sub

   Private Sub ProcessAllFolders(ByVal pstrFolder As String)

      Dim strFilePath As String
      Dim objFile As FileInfo

      Try
         lblCurrentFile.Text = pstrFolder
         Application.DoEvents()

         For Each strFilePath In Directory.GetFiles(pstrFolder, "*", SearchOption.AllDirectories)
            objFile = New FileInfo
            objFile.FileName = strFilePath
            objFile.LastModified = My.Computer.FileSystem.GetFileInfo(strFilePath).LastWriteTime
            mobjFiles.Add(objFile)
         Next

      Catch ex As Exception

      End Try

   End Sub

End Class

Public Class FileInfo
   Implements IComparable

   Private mstrFileName As String
   Private mdteLastModified As DateTime

   Public Property FileName() As String
      Get
         Return mstrFileName
      End Get
      Set(ByVal value As String)
         mstrFileName = value
      End Set
   End Property

   Public Property LastModified() As DateTime
      Get
         Return mdteLastModified
      End Get
      Set(ByVal value As DateTime)
         mdteLastModified = value
      End Set
   End Property

   Public Function CompareTo(ByVal obj As Object) As Integer Implements System.IComparable.CompareTo

      Return mdteLastModified.CompareTo(TryCast(obj, FileInfo).LastModified)

   End Function

   Public Overrides Function ToString() As String

      Return Strings.Left(mstrFileName & Strings.Space(125), 125) & " " & Strings.Format(mdteLastModified, "yyyy-MM-dd hh:mm:ss tt")

   End Function

End Class

