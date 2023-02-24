Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class CategoriesPage

    Dim StockStructure As Dictionary(Of String, Object)

    Private Sub CategoriesPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'InitaliseConnection()
        'myconnection.Open()
        LoadTreeViewData()

    End Sub

    Private Sub AddBT_Click(sender As Object, e As EventArgs) Handles AddBT.Click
        Dim N As Item
        Dim fm As New AddItemPage With {
            .CurrentItem = New Item(-1)
        }

        If TreeView1.SelectedNode IsNot Nothing Then
            fm.CurrentItem.ParentCategory = New Item(TreeView1.SelectedNode.Name)
        Else
            fm.CurrentItem.ParentCategory = New Item(-1)
        End If

        fm.ShowDialog()

        N = fm.CurrentItem

        If N.ItemID = -1 Then Exit Sub

        If TreeView1.SelectedNode Is Nothing Then
            TreeView1.Nodes.Add(N.ItemID, N.Name)
        Else
            TreeView1.SelectedNode.Nodes.Add(N.ItemID, N.Name)
        End If

        SaveBT.PerformClick()

    End Sub

    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Label1.Text = TreeView1.SelectedNode.FullPath
    End Sub

    Private Function TreeViewToDictionary(_nodes As TreeNodeCollection)
        Dim dict As New Dictionary(Of String, Object)

        For Each i As TreeNode In _nodes
            If i.Nodes.Count = 0 Then
                dict(i.Name) = ""
            Else
                dict(i.Name) = TreeViewToDictionary(i.Nodes)
            End If
        Next

        Return dict
    End Function

    Private Sub AddToTree(_dict As Dictionary(Of String, Object), Optional _node As TreeNode = Nothing)

        For Each i In _dict
            Dim newlyAddedNode As TreeNode

            Dim itm As New Item(i.Key)

            If _node IsNot Nothing Then
                TreeView1.SelectedNode = _node
                newlyAddedNode = TreeView1.SelectedNode.Nodes.Add(itm.ItemID, itm.Name)
            Else
                newlyAddedNode = TreeView1.Nodes.Add(itm.ItemID, itm.Name)
            End If
            If i.Value IsNot "" Then
                Dim _str As JObject = i.Value
                Dim dict As Dictionary(Of String, Object) = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(_str.ToString)
                AddToTree(dict, newlyAddedNode)
            End If
        Next

    End Sub

    Private Sub LoadTreeViewData()
        Dim dict As Dictionary(Of String, Object) = Nothing

        Dim dr_count As OleDb.OleDbDataReader = DataReader("Select COUNT(Id) From Stock_Structure")

        While dr_count.Read
            If dr_count(0) = 0 Then Exit Sub
        End While

        Try
            Dim dr As OleDb.OleDbDataReader = DataReader("Select ItemOrder From Stock_Structure Where Id=1")

            While dr.Read
                dict = JsonConvert.DeserializeObject(Of Dictionary(Of String, Object))(dr(0))
                Exit While
            End While
        Catch ex As Exception
        End Try


        StockStructure = dict

        TreeView1.Nodes.Clear()
        AddToTree(dict)
    End Sub

    Private Sub SaveBT_Click(sender As Object, e As EventArgs) Handles SaveBT.Click
        Dim dict As Dictionary(Of String, Object) = TreeViewToDictionary(TreeView1.Nodes)

        Dim myJ = JsonConvert.SerializeObject(dict)

        Try
            Dim dr As OleDb.OleDbDataReader = DataReader("Select COUNT(Id) From Stock_Structure")

            While dr.Read
                Dim _temp As Integer = dr(0)
                If _temp = 0 Then
                    SqlCommand($"INSERT INTO Stock_Structure (Id,ItemOrder) VALUES (1,'{myJ}')")
                Else
                    SqlCommand($"UPDATE Stock_Structure SET ItemOrder='{myJ}' WHERE Id=1")
                End If
            End While
        Catch ex As Exception
        End Try

        LoadTreeViewData()

    End Sub

    Private Sub StockEntryBT_Click(sender As Object, e As EventArgs) Handles StockEntryBT.Click

        If TreeView1.SelectedNode Is Nothing Then Exit Sub

        Dim _id As Integer = TreeView1.SelectedNode.Name

        Dim fm As New StockEntry With {
            .CurrentItem = New Item(_id)
        }
        fm.ShowDialog()
    End Sub

    Private Sub EditBT_Click(sender As Object, e As EventArgs) Handles EditBT.Click
        Dim fm As New AddItemPage
        If TreeView1.SelectedNode IsNot Nothing Then
            Try
                Dim prevItem As New Item(TreeView1.SelectedNode.Name)
                fm.CurrentItem = prevItem
            Catch ex As Exception
            End Try
        End If

        fm.ShowDialog()
    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs) Handles FlowLayoutPanel1.Paint

    End Sub

    Private Sub IconButton1_Click(sender As Object, e As EventArgs) Handles IconButton1.Click
        Dim fm As New ShowItems
        fm.ShowDialog()
    End Sub
End Class
