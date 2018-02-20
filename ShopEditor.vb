Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports System.Resources
Imports System.Xml
Imports System.Collections
Imports System.Runtime.InteropServices

Public Class ShopEditor

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As Integer, ByVal wParam As Integer, <MarshalAs(UnmanagedType.LPWStr)> ByVal lParam As String) As Int32
    End Function

#Region "    Global Variables"
    Private DontWork As Boolean
    Private ItemName As String(,) = New String(15, 512) {}
    Private ItemSize As String(,) = New String(15, 512) {}
    Private CompleteItemList As List(Of Structures.ItemSearchStuct) = New List(Of Structures.ItemSearchStuct)
    Private L_Ancient As New List(Of Structures.c_AncientItems)()
    Private L_AncientLevelDatas As New List(Of Structures.c_AncientNames)()
    Private L_AncientNames As New List(Of Structures.c_AncientNames)()
    Private L_AncientNameDatas As New List(Of Structures.c_AncientNames)()
    Private L_Armors As New List(Of Structures.UniItem)()
    Private L_Axes As New List(Of Structures.UniItem)()
    Private L_Boots As New List(Of Structures.UniItem)()
    Private L_BowsCrossBows As New List(Of Structures.UniItem)()
    Private L_CharClassDatas As New List(Of Structures.c_CharClass)()
    Private L_ElementDatas As New List(Of Structures.c_ElementData)()
    Private L_Gloves As New List(Of Structures.UniItem)()
    Private L_Groups As New List(Of Structures.c_Groups)()
    Private L_Helms As New List(Of Structures.UniItem)()
    Private L_LevelDatas As New List(Of Structures.c_LevelData)()
    Private L_MacesScepters As New List(Of Structures.UniItem)()
    Private L_OptionDatas As New List(Of Structures.c_OptionData)()
    Private L_Others1 As New List(Of Structures.UniItem)()
    Private L_Others2 As New List(Of Structures.UniItem)()
    Private L_Pants As New List(Of Structures.UniItem)()
    Private L_Scrolls As New List(Of Structures.UniItem)()
    Private L_Shields As New List(Of Structures.UniItem)()
    Private L_SocketDatas As New List(Of Structures.c_SocketData)()
    Private L_Spears As New List(Of Structures.UniItem)()
    Private L_Staffs As New List(Of Structures.UniItem)()
    Private L_Swords As New List(Of Structures.UniItem)()
    Private L_WingsSkillsSeedsOthers As New List(Of Structures.UniItem)()
    Private LastSelectedItemIndex As Integer
    Private LastSelectetItem As New Structures.CustomPictureBox()
    Private OccupiedBoxes As Boolean(,) = New Boolean(15, 8) {}
    Private OldDurValue As Integer
    Private SelectedSI As Structures.ShopItem = Nothing
    Private ShopItems As Structures.ShopItem(,) = New Structures.ShopItem(15, 8) {}
    Private Check_Level_Option As Boolean = False
    Private strct As New Structures()
#End Region

#Region "    Events"
    Private Sub ShopEditor_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim form As ShopEditor = DirectCast(Application.OpenForms(0), ShopEditor)
        Me.AddPreviewBoxes(8, 15)



        Try
            Me.strct.Setc_CharClass(Me.L_CharClassDatas)
            Me.strct.ReadItemSetOption("Data\IGC_ItemSetOption.xml", Me.L_AncientNames)
            Me.strct.ReadItemSetType("Data\IGC_ItemSetType.xml", Me.L_Ancient)
            Me.strct.ReadItemList("Data\IGC_ItemList.xml", Me.L_Groups, Me.L_Swords, Me.L_Axes, Me.L_MacesScepters,
                Me.L_Spears, Me.L_BowsCrossBows, Me.L_Staffs, Me.L_Shields, Me.L_Helms, Me.L_Armors,
                Me.L_Pants, Me.L_Gloves, Me.L_Boots, Me.L_WingsSkillsSeedsOthers, Me.L_Others1, Me.L_Others2,
                Me.L_Scrolls, Me.ItemName, Me.ItemSize, Me.L_Ancient, Me.L_AncientNames, Me.CompleteItemList, Me.L_CharClassDatas)

            DontWork = True
            Me.searchBox.DataSource = CompleteItemList
            Me.searchBox.ValueMember = "ItemIndex"
            Me.searchBox.DisplayMember = "ItemName"
            Me.searchBox.SelectedIndex = -1
            DontWork = False
            SendMessage(Me.searchBox.Handle, &H1703, 0, "Type search term")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.[Exit]()
        End Try

        Me.listBox_Group.ValueMember = "Group"
        Me.listBox_Group.DisplayMember = "GroupName"
        Me.listBox_Group.DataSource = Me.L_Groups

        Me.strct.Setc_LevelData(Me.L_LevelDatas)
        Me.listBox_Level.DataSource = Me.L_LevelDatas
        Me.listBox_Level.ValueMember = "ID"
        Me.listBox_Level.DisplayMember = "Name"

        Me.strct.Setc_OptionData(Me.L_OptionDatas)
        Me.listBox_Option.DataSource = Me.L_OptionDatas
        Me.listBox_Option.ValueMember = "ID"
        Me.listBox_Option.DisplayMember = "Name"

        Me.strct.Setc_AncientNames(Me.L_AncientNames, Nothing, Me.L_AncientNameDatas)
        Me.cmbAncientName.DataSource = Me.L_AncientNameDatas
        Me.cmbAncientName.ValueMember = "Index"
        Me.cmbAncientName.DisplayMember = "Name"

        Me.strct.Setc_AncientLevels(Me.L_AncientLevelDatas)
        Me.cmbAncientLevel.DataSource = Me.L_AncientLevelDatas
        Me.cmbAncientLevel.ValueMember = "Index"
        Me.cmbAncientLevel.DisplayMember = "Name"

        Me.strct.Setc_SocketAmount(Me.L_SocketDatas)
        Me.ListBox_Socket.DataSource = Me.L_SocketDatas
        Me.ListBox_Socket.ValueMember = "ID"
        Me.ListBox_Socket.DisplayMember = "Name"

        Me.strct.Setc_Elements(Me.L_ElementDatas)
        Me.ListBox_Element.DataSource = Me.L_ElementDatas
        Me.ListBox_Element.ValueMember = "ID"
        Me.ListBox_Element.DisplayMember = "Name"

        Me.Check_Level_Option = True
        Me.radioButton_ExcWeapon.Checked = True
        MyBase.WindowState = FormWindowState.Normal
        Me.FormBorderStyle = FormBorderStyle.FixedSingle
        MyBase.TopMost = True
        MyBase.TopMost = False
        MyBase.BringToFront()
        MyBase.Focus()

    End Sub
    Private Sub pb_MouseClick(sender As Object, e As MouseEventArgs)
        Dim customPictureBox As Structures.CustomPictureBox = DirectCast(sender, Structures.CustomPictureBox)
        Dim array As String() = customPictureBox.Name.Split(New Char() {"_"c})
        Dim array2 As String() = array(array.Length - 2).Split(New Char() {"x"c})
        Dim array3 As String() = array(array.Length - 1).Split(New Char() {"x"c})
        Dim num As Integer = CInt(Convert.ToInt16(array2(1)))
        Dim num2 As Integer = CInt(Convert.ToInt16(array2(0)))
        Dim num3 As Integer = CInt(Convert.ToInt16(array3(1)))
        Dim num4 As Integer = CInt(Convert.ToInt16(array3(0)))
        Dim a As String = String.Concat(New Object() {"Item_", num2, "x", num, "_", num4, "x", num3})
        If e.Button = MouseButtons.Right Then
            If MessageBox.Show("    Are you sure you want to delete this item?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) = DialogResult.Yes Then
                Dim shopItems As Structures.ShopItem(,) = Me.ShopItems
                Dim upperBound As Integer = shopItems.GetUpperBound(0)
                Dim upperBound2 As Integer = shopItems.GetUpperBound(1)
                Dim found As Boolean = False
                For i As Integer = shopItems.GetLowerBound(0) To upperBound
                    For j As Integer = shopItems.GetLowerBound(1) To upperBound2
                        Dim shopItem As Structures.ShopItem = shopItems(i, j)
                        If a = shopItem.UniqName Then
                            Me.ShopItems(shopItem.ShopLocY, shopItem.ShopLocX) = Nothing
                            found = True
                            Exit For
                        End If
                    Next
                    If found Then Exit For
                Next
                Me.pictureBox_ShopPreview.Controls.RemoveByKey(String.Concat(New Object() {"pictureBox_Item_", num2, "x", num, "_", num4, "x", num3}))
                Me.ChangeOccupid(num, num2, num3, num4, False)
                Me.button_Update.Enabled = False
            End If
            Return
        End If
        If e.Button <> MouseButtons.Left OrElse Me.LastSelectetItem Is customPictureBox Then
            Return
        End If
        customPictureBox.BorderColor = Color.Gold
        Me.LastSelectetItem.BorderColor = Color.Transparent
        Me.LastSelectetItem = customPictureBox
        Me.pictureBox_ShopPreview.Invalidate()
        Dim shopItems2 As Structures.ShopItem(,) = Me.ShopItems
        Dim upperBound3 As Integer = shopItems2.GetUpperBound(0)
        Dim upperBound4 As Integer = shopItems2.GetUpperBound(1)
        For k As Integer = shopItems2.GetLowerBound(0) To upperBound3
            For l As Integer = shopItems2.GetLowerBound(1) To upperBound4
                Dim selectedSI As Structures.ShopItem = shopItems2(k, l)
                If a = selectedSI.UniqName Then
                    Me.SelectedSI = selectedSI
                    Exit For
                End If
            Next
        Next
        Me.listBox_Group.SelectedValue = Me.SelectedSI.Group
        Me.listBox_Index.SelectedValue = Me.SelectedSI.Index
        Me.listBox_Level.SelectedIndex = CInt(Me.SelectedSI.Level)
        Me.listBox_Option.SelectedIndex = CInt(Me.SelectedSI.[Option])
        Me.checkBox_Luck.Checked = Me.SelectedSI.Luck
        Me.checkBox_Skill.Checked = Me.SelectedSI.Skill
        Me.numericUpDown_Durability.Value = Me.SelectedSI.Durablity
        Select Case Me.SelectedSI.Ancient
            Case 0
                cmbAncientName.SelectedIndex = 0
                cmbAncientLevel.SelectedIndex = 0
            Case 5
                cmbAncientName.SelectedIndex = 1
                cmbAncientLevel.SelectedIndex = 0
            Case 6
                cmbAncientName.SelectedIndex = 2
                cmbAncientLevel.SelectedIndex = 0
            Case 9
                cmbAncientName.SelectedIndex = 1
                cmbAncientLevel.SelectedIndex = 1
            Case 10
                cmbAncientName.SelectedIndex = 2
                cmbAncientLevel.SelectedIndex = 1
        End Select
        Me.ListBox_Socket.SelectedIndex = Me.SelectedSI.Socket
        Me.ListBox_Element.SelectedIndex = Me.SelectedSI.Element
        Me.CheckBox_Serial.Checked = Me.SelectedSI.Serial

        Me.checkBox_ExcOpt1.Checked = ((Me.SelectedSI.Excellent And 1) = 1)
        Me.checkBox_ExcOpt2.Checked = ((Me.SelectedSI.Excellent >> 1 And 1) = 1)
        Me.checkBox_ExcOpt3.Checked = ((Me.SelectedSI.Excellent >> 2 And 1) = 1)
        Me.checkBox_ExcOpt4.Checked = ((Me.SelectedSI.Excellent >> 3 And 1) = 1)
        Me.checkBox_ExcOpt5.Checked = ((Me.SelectedSI.Excellent >> 4 And 1) = 1)
        Me.checkBox_ExcOpt6.Checked = ((Me.SelectedSI.Excellent >> 5 And 1) = 1)
        Me.button_Update.Enabled = True
    End Sub
    Private Sub button_Add_Click(sender As Object, e As EventArgs) Handles button_Add.Click
        Dim empty As String = String.Empty
        Dim ancient As Byte
        If grpAncientOptions.Enabled Then
            If Me.cmbAncientName.SelectedIndex = 0 Then
                ancient = Convert.ToByte(0)
            Else
                ancient = Convert.ToByte(cmbAncientName.SelectedIndex - 1 + Convert.ToInt32(cmbAncientLevel.SelectedValue))
            End If
        Else
            ancient = Convert.ToByte(0)
        End If
        Dim shopItem As New Structures.ShopItem() With {
                        .Group = Convert.ToInt32(Me.listBox_Group.SelectedValue),
                        .Index = Convert.ToInt32(Me.listBox_Index.SelectedValue),
                        .Level = Convert.ToByte(Me.listBox_Level.SelectedValue),
                        .[Option] = Convert.ToByte(Me.listBox_Option.SelectedValue),
                        .Skill = Me.checkBox_Skill.Checked,
                        .Luck = Me.checkBox_Luck.Checked,
                        .Durablity = Convert.ToByte(Me.numericUpDown_Durability.Value),
                        .Ancient = ancient,
                        .Excellent = Me.GetExcVal(),
                        .Socket = Convert.ToByte(Me.ListBox_Socket.SelectedIndex),
                        .Element = Convert.ToByte(Me.ListBox_Element.SelectedIndex),
                        .Serial = Convert.ToBoolean(Me.CheckBox_Serial.Checked)
                    }
        Dim str As String = String.Empty & (If((shopItem.Excellent > 0), "Excellent ", ""))
        Dim obj As Object = str & (If((shopItem.Ancient > 0), "Ancient ", "")) & Me.listBox_Index.Text
        Dim str2 As String = String.Concat(New Object() {obj, "+", shopItem.Level, Me.listBox_Option.Text})
        Dim text As String = str2 & (If(shopItem.Skill, "+Skill", ""))
        Dim str3 As String = String.Concat(New Object() {text, If(shopItem.Luck, "+Luck", ""), vbLf & vbLf & "Durability: ", shopItem.Durablity})
        Dim text2 As String = str3 & (If((shopItem.Ancient > 0), (If((shopItem.Ancient = 5), vbLf & vbLf & "Ancinet: Level 1", (If((shopItem.Ancient = 10), vbLf & vbLf & "Ancinet: Level 2", "")))), ""))
        If shopItem.Excellent > 0 Then
            text2 = String.Concat(New String() {text2, vbLf & vbLf & "Excellent Options:" & vbLf, If(Me.checkBox_ExcOpt1.Checked, (Me.checkBox_ExcOpt1.Text & vbLf), ""), If(Me.checkBox_ExcOpt2.Checked, (Me.checkBox_ExcOpt2.Text & vbLf), ""), If(Me.checkBox_ExcOpt3.Checked, (Me.checkBox_ExcOpt3.Text & vbLf), ""), If(Me.checkBox_ExcOpt4.Checked, (Me.checkBox_ExcOpt4.Text & vbLf), ""),
                If(Me.checkBox_ExcOpt5.Checked, (Me.checkBox_ExcOpt5.Text & vbLf), ""), If(Me.checkBox_ExcOpt6.Checked, Me.checkBox_ExcOpt6.Text, "")})
        End If
        If Me.AddItemPicture(text2, empty, shopItem) Then
            shopItem.UniqName = empty
            Me.SelectedSI = shopItem
            Me.ShopItems(shopItem.ShopLocY, shopItem.ShopLocX) = shopItem
        End If
    End Sub
    Private Sub button_Update_Click(sender As Object, e As EventArgs) Handles button_Update.Click
        Dim shopItem As Structures.ShopItem = Nothing
        Dim ancient As Byte
        If grpAncientOptions.Enabled Then
            If Me.cmbAncientName.SelectedIndex = 0 Then
                ancient = Convert.ToByte(0)
            Else
                ancient = Convert.ToByte(cmbAncientName.SelectedIndex - 1 + Convert.ToInt32(cmbAncientLevel.SelectedValue))
            End If
        Else
            ancient = Convert.ToByte(0)
        End If
        shopItem = Me.SelectedSI
        shopItem.Level = Convert.ToByte(Me.listBox_Level.SelectedValue)
        shopItem.[Option] = Convert.ToByte(Me.listBox_Option.SelectedValue)
        shopItem.Skill = Me.checkBox_Skill.Checked
        shopItem.Luck = Me.checkBox_Luck.Checked
        shopItem.Durablity = Convert.ToByte(Me.numericUpDown_Durability.Value)
        shopItem.Ancient = ancient
        shopItem.Excellent = Me.GetExcVal()
        shopItem.Socket = Convert.ToByte(Me.ListBox_Socket.SelectedIndex)
        shopItem.Element = Convert.ToByte(Me.ListBox_Element.SelectedIndex)
        shopItem.Serial = Convert.ToBoolean(Me.CheckBox_Serial.Checked)
        Dim str As String = String.Empty & (If((shopItem.Excellent > 0), "Excellent ", ""))
        Dim obj As Object = str & (If((shopItem.Ancient > 0), "Ancient ", "")) & Me.listBox_Index.Text
        Dim str2 As String = String.Concat(New Object() {obj, "+", shopItem.Level, Me.listBox_Option.Text})
        Dim text As String = str2 & (If(shopItem.Skill, "+Skill", ""))
        Dim str3 As String = String.Concat(New Object() {text, If(shopItem.Luck, "+Luck", ""), vbLf & vbLf & "Durability: ", shopItem.Durablity})
        Dim text2 As String = str3 & (If((shopItem.Ancient > 0), (If((shopItem.Ancient = 5), vbLf & vbLf & "Ancinet: Level 1", (If((shopItem.Ancient = 10), vbLf & vbLf & "Ancinet: Level 2", "")))), ""))
        If shopItem.Excellent > 0 Then
            text2 = String.Concat(New String() {text2, vbLf & vbLf & "Excellent Options:" & vbLf, If(Me.checkBox_ExcOpt1.Checked, (Me.checkBox_ExcOpt1.Text & vbLf), ""), If(Me.checkBox_ExcOpt2.Checked, (Me.checkBox_ExcOpt2.Text & vbLf), ""), If(Me.checkBox_ExcOpt3.Checked, (Me.checkBox_ExcOpt3.Text & vbLf), ""), If(Me.checkBox_ExcOpt4.Checked, (Me.checkBox_ExcOpt4.Text & vbLf), ""),
                If(Me.checkBox_ExcOpt5.Checked, (Me.checkBox_ExcOpt5.Text & vbLf), ""), If(Me.checkBox_ExcOpt6.Checked, Me.checkBox_ExcOpt6.Text, "")})
        End If
        Me.LastSelectetItem.Controls.Clear()

        Dim ctt As New Structures.CustomToolTip With {.sizeX = 350,
                                                      .sizeY = 210}
        ctt.SetToolTip(Me.LastSelectetItem, text2)

        Me.ShopItems(Me.SelectedSI.ShopLocY, Me.SelectedSI.ShopLocX) = shopItem
    End Sub
    Private Sub btnSearchFilter_Click(sender As Object, e As EventArgs) Handles btnSearchFilter.Click
        frmAdvancedFilter.ShowDialog()
        DontWork = True
        Me.searchBox.DataSource = Nothing

        Dim L_Filter As New List(Of Structures.ItemSearchStuct)
        Dim cc_filter As Structures.c_CharClass = DirectCast(frmAdvancedFilter.cmbClass.SelectedItem, Structures.c_CharClass)
        Dim cco_filter As Boolean = frmAdvancedFilter.chkCharClassOnly.Checked
        Dim type_filter As Structures.c_ItemType = DirectCast(frmAdvancedFilter.cmbType.SelectedItem, Structures.c_ItemType)
        Dim slot_filter As Structures.c_ItemSlot = DirectCast(frmAdvancedFilter.cmbSlot.SelectedItem, Structures.c_ItemSlot)
        For Each group As Structures.c_Groups In L_Groups
            Dim Items As List(Of Structures.UniItem) = RetrieveListItems(group._GroupID)
            For Each item As Structures.UniItem In Items
                Dim AddItem As Boolean = True
                If frmAdvancedFilter.chkCharClass.Checked Then
                    Dim item_charclass As List(Of Structures.c_CharClass) = item.CharClass
                    Dim found As Structures.c_CharClass
                    If cco_filter Then
                        found = item_charclass.Find(Function(cc) cc.Index = cc_filter.Index)
                    Else
                        Dim cClass As String = cc_filter.Index.Substring(0, cc_filter.Index.Length - 1)
                        Dim cEvo As Integer = Convert.ToInt16(cc_filter.Index.Substring(cc_filter.Index.Length - 1, 1))
                        found = item_charclass.Find(
                        Function(cc) cc.Index.Substring(0, cc.Index.Length - 1) = cClass And
                                     Convert.ToInt16(cc.Index.Substring(cc.Index.Length - 1, 1)) <= cEvo)
                    End If
                    AddItem = AddItem And found IsNot Nothing
                End If
                If type_filter.Index <> -1 Then
                    AddItem = AddItem And item.Type = type_filter.Index
                End If
                If slot_filter.Index <> -2 Then
                    AddItem = AddItem And item.Slot = slot_filter.Index
                End If

                If AddItem Then
                    Dim item_name As String = item.Name
                    Dim item_category As Integer = item.Group
                    Dim item_index As Integer = item.Index
                    L_Filter.Add(New Structures.ItemSearchStuct With {.ItemCategory = item_category,
                                                                      .ItemIndex = item_index,
                                                                      .ItemName = item_name})
                End If
            Next
        Next

        Me.searchBox.DataSource = L_Filter
        Me.searchBox.ValueMember = "ItemIndex"
        Me.searchBox.DisplayMember = "ItemName"
        Me.searchBox.SelectedIndex = -1
        DontWork = False
        SendMessage(Me.searchBox.Handle, &H1703, 0, "Type search term")
    End Sub
    Private Sub listBox_Group_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox_Group.SelectedIndexChanged
        If Me.listBox_Group.SelectedIndex <> -1 Then
            Me.DontWork = True
            Me.listBox_Index.DisplayMember = "Name"
            Me.listBox_Index.ValueMember = "Index"
            Me.listBox_Index.DataSource = RetrieveListItems(CInt(Me.listBox_Group.SelectedValue))
            Me.listBox_Index.SelectedIndex = -1
            Me.DontWork = False
            If Me.LastSelectedItemIndex <= Me.listBox_Index.Items.Count - 1 Then
                Me.listBox_Index.SelectedIndex = Me.LastSelectedItemIndex
            End If
        End If
    End Sub
    Private Sub listBox_Index_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox_Index.SelectedIndexChanged
        FilterLevelOption()
        If Me.listBox_Index.SelectedIndex <> -1 And Not Me.DontWork Then
            Me.LastSelectedItemIndex = Me.listBox_Index.SelectedIndex
            Try
                Me.pictureBox_ItemPreview.BackgroundImage = DirectCast(
                    My.Resources.ResourceManager.GetObject(
                        "_" & Convert.ToString(Me.listBox_Group.SelectedValue) &
                                               Convert.ToString(Me.listBox_Index.SelectedValue)),
                        Bitmap)
                If Me.pictureBox_ItemPreview.BackgroundImage.Size.Width > Me.pictureBox_ItemPreview.Size.Width OrElse
                    Me.pictureBox_ItemPreview.BackgroundImage.Size.Height > Me.pictureBox_ItemPreview.Size.Height Then
                    Me.pictureBox_ItemPreview.BackgroundImageLayout = ImageLayout.Zoom
                Else
                    Me.pictureBox_ItemPreview.BackgroundImageLayout = ImageLayout.Center
                End If
            Catch
                Me.pictureBox_ItemPreview.BackgroundImage = DirectCast(My.Resources.ResourceManager.GetObject("no_img"), Bitmap)
            End Try
            Dim uniItem As Structures.UniItem = CType(Me.listBox_Index.SelectedItem, Structures.UniItem)
            Me.label_Size.Text = uniItem.X & "x" & uniItem.Y
            Me.checkBox_Skill.Checked = (uniItem.Skill <> 0 AndAlso Me.checkBox_Skill.Checked)
            ' Me.listBox_Option.SelectedIndex = (If((uniItem.[Option] = 0), 0, Me.listBox_Option.SelectedIndex))
            grpExcOpt.Enabled = Convert.ToBoolean(uniItem.[Option])
            If Not grpExcOpt.Enabled Then
                For Each cb As Object In grpExcOpt.Controls
                    If TypeOf cb Is CheckBox Then
                        cb.Checked = False
                    End If
                Next
            End If

            If uniItem.Ancient Is Nothing Then
                Me.grpAncientOptions.Enabled = False
            Else
                Me.grpAncientOptions.Enabled = True
                Me.strct.Setc_AncientNames(Me.L_AncientNames, uniItem.Ancient, Me.L_AncientNameDatas)
                Me.cmbAncientName.DataSource = Nothing
                Me.cmbAncientName.DataSource = Me.L_AncientNameDatas
                Me.cmbAncientName.DisplayMember = "Name"
                Me.cmbAncientName.ValueMember = "Index"
            End If
            Me.numericUpDown_Durability.Value = uniItem.Durability
            If uniItem.Type = 2 Or uniItem.Type = 4 Then
                Me.grpSocket.Enabled = True
            Else
                If Me.ListBox_Socket.Items.Count > 0 Then
                    Me.ListBox_Socket.SelectedIndex = 0
                End If
                Me.grpSocket.Enabled = False
            End If
            If uniItem.Skill > 0 Then
                checkBox_Skill.Checked = False
                checkBox_Skill.Enabled = True
            Else
                checkBox_Skill.Enabled = False
            End If
            Dim slot As Integer = uniItem.Slot
            Select Case slot
                Case -1, 8
                    Exit Select
                Case 0, 9
                    Me.radioButton_ExcWeapon.Enabled = True
                    Me.radioButton_ExcArmor.Enabled = False
                    Me.radioButton_ExcWings.Enabled = False
                    Me.radioButton_ExcWeapon.Checked = True
                    Return
                Case 1, 2, 3, 4, 5, 6, 10
                    If uniItem.Group > 5 Then
                        Me.radioButton_ExcWeapon.Enabled = False
                        Me.radioButton_ExcArmor.Enabled = True
                        Me.radioButton_ExcWings.Enabled = False
                        Me.radioButton_ExcArmor.Checked = True
                        Return
                    End If
                    Me.radioButton_ExcWeapon.Enabled = True
                    Me.radioButton_ExcArmor.Enabled = False
                    Me.radioButton_ExcWings.Enabled = False
                    Me.radioButton_ExcWeapon.Checked = True
                    Return
                Case 7
                    Me.radioButton_ExcWeapon.Enabled = False
                    Me.radioButton_ExcArmor.Enabled = False
                    Me.radioButton_ExcWings.Enabled = True
                    Me.radioButton_ExcWings.Checked = True
                    Return
                Case Else
                    If slot <> 236 Then
                        Return
                    End If
                    Exit Select
            End Select
            Me.checkBox_ExcOpt1.Checked = False
            Me.checkBox_ExcOpt2.Checked = False
            Me.checkBox_ExcOpt3.Checked = False
            Me.checkBox_ExcOpt4.Checked = False
            Me.checkBox_ExcOpt5.Checked = False
            Me.checkBox_ExcOpt6.Checked = False
            Return
        End If
    End Sub

    Private Sub listBox_LevelOption_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listBox_Level.SelectedIndexChanged,
                                                                                               listBox_Option.SelectedIndexChanged
        If Check_Level_Option Then
            Dim lbox As ListBox = DirectCast(sender, ListBox)

            If (checkBox_FO.Checked And lbox.Items.Count - 1 <> lbox.SelectedIndex) Or (Not checkBox_FO.Checked And 0 <> lbox.SelectedIndex) Then
                checkBox_FO.CheckState = CheckState.Indeterminate
            End If
        End If

    End Sub
    Private Sub numericUpDown_Durability_ValueChanged(sender As Object, e As EventArgs) Handles numericUpDown_Durability.ValueChanged
        If Me.numericUpDown_Durability.Focused Then
            Me.OldDurValue = CInt(Math.Truncate(Me.numericUpDown_Durability.Value))
            Return
        End If
        If Me.checkBox_DurLock.Checked Then
            Me.numericUpDown_Durability.Value = Me.OldDurValue
            Return
        End If
        Me.OldDurValue = CInt(Math.Truncate(Me.numericUpDown_Durability.Value))
    End Sub

    Private Sub checkBox_FO_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox_FO.CheckedChanged
        If Not Me.checkBox_FO.CheckState = CheckState.Indeterminate Then
            If Me.checkBox_FO.Checked Then
                Me.checkBox_ExcOpt1.Checked = True
                Me.checkBox_ExcOpt2.Checked = True
                Me.checkBox_ExcOpt3.Checked = True
                Me.checkBox_ExcOpt4.Checked = True
                Me.checkBox_ExcOpt5.Checked = True
                Me.checkBox_ExcOpt6.Checked = True
                Me.listBox_Level.SelectedIndex = listBox_Level.Items.Count - 1
                Me.listBox_Option.SelectedValue = listBox_Option.Items.Count - 1
                Me.checkBox_Luck.Checked = True
                If radioButton_ExcWeapon.Checked Then
                    Me.checkBox_Skill.Checked = True
                End If
            Else
                Me.checkBox_ExcOpt1.Checked = False
                Me.checkBox_ExcOpt2.Checked = False
                Me.checkBox_ExcOpt3.Checked = False
                Me.checkBox_ExcOpt4.Checked = False
                Me.checkBox_ExcOpt5.Checked = False
                Me.checkBox_ExcOpt6.Checked = False
                Me.listBox_Level.SelectedIndex = 0
                Me.listBox_Option.SelectedValue = 0
                Me.checkBox_Luck.Checked = False
                If radioButton_ExcWeapon.Checked Then
                    Me.checkBox_Skill.Checked = False
                End If
            End If
        End If
    End Sub
    Private Sub checkBoxes_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox_ExcOpt1.CheckedChanged,
                                                                                      checkBox_ExcOpt2.CheckedChanged,
                                                                                      checkBox_ExcOpt3.CheckedChanged,
                                                                                      checkBox_ExcOpt4.CheckedChanged,
                                                                                      checkBox_ExcOpt5.CheckedChanged,
                                                                                      checkBox_ExcOpt6.CheckedChanged,
                                                                                      checkBox_Luck.CheckedChanged,
                                                                                      checkBox_Skill.CheckedChanged
        Dim chkbox As CheckBox = DirectCast(sender, CheckBox)
        If (chkbox.Checked And Not checkBox_FO.Checked) Or (Not chkbox.Checked And checkBox_FO.Checked) Then
            checkBox_FO.CheckState = CheckState.Indeterminate
        End If
    End Sub
    Private Sub radioButton_Exc_CheckedChanged(sender As Object, e As EventArgs) Handles radioButton_ExcArmor.CheckedChanged,
                                                                                         radioButton_ExcWeapon.CheckedChanged,
                                                                                         radioButton_ExcWings.CheckedChanged
        If Me.radioButton_ExcArmor.Checked Then
            Me.checkBox_ExcOpt1.Text = "Zen Drop +30%"
            Me.checkBox_ExcOpt2.Text = "Def Success Rate +10%"
            Me.checkBox_ExcOpt3.Text = "Reflect +5%"
            Me.checkBox_ExcOpt4.Text = "Damage Decrease +4%"
            Me.checkBox_ExcOpt5.Text = "Mana +4%"
            Me.checkBox_ExcOpt6.Text = "HP +4%"
            Me.checkBox_Skill.Checked = False
            Return
        End If
        If Me.radioButton_ExcWeapon.Checked Then
            Me.checkBox_ExcOpt1.Text = "Mob Kill +mana/8"
            Me.checkBox_ExcOpt2.Text = "Mob Kill +life/8"
            Me.checkBox_ExcOpt3.Text = "Attack(Wizardy) Speed +7"
            Me.checkBox_ExcOpt4.Text = "Damage +2%"
            Me.checkBox_ExcOpt5.Text = "Damage +level/20"
            Me.checkBox_ExcOpt6.Text = "Exc Damage Rate +10%"
            Return
        End If
        If Me.radioButton_ExcWings.Checked Then
            Me.checkBox_ExcOpt1.Text = "Ignor Def +5% / HP +125"
            Me.checkBox_ExcOpt2.Text = "Return Attack +5% / Mana +125"
            Me.checkBox_ExcOpt3.Text = "Life Recovery +5% /Ignor Def +3%"
            Me.checkBox_ExcOpt4.Text = "Mana Recovery +5% / AG +50"
            Me.checkBox_ExcOpt5.Text = "--- / Attack(Wiz) Speed+5"
            Me.checkBox_ExcOpt6.Text = "---"
            Me.checkBox_Skill.Checked = False
        End If
    End Sub

    Private Sub searchBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles searchBox.SelectedIndexChanged
        If Not DontWork Then
            Dim selectedItem As Structures.ItemSearchStuct = CompleteItemList(searchBox.SelectedIndex)
            Dim si As Structures.ItemSearchStuct = DirectCast(searchBox.SelectedItem, Structures.ItemSearchStuct)
            listBox_Group.SelectedIndex = si.ItemCategory
            listBox_Index.SelectedValue = si.ItemIndex
        End If
    End Sub

#Region "    Menu New/Open/SaveAs"
    Private Sub newToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles newToolStripMenuItem.Click
        Me.ShopItems = New Structures.ShopItem(15, 8) {}
        Me.SelectedSI = Nothing
        Me.LastSelectetItem = New Structures.CustomPictureBox()
        Me.ChangeOccupid(1, 1, 8, 15, False)
        Me.ClearShopItemsPreview()
        Me.button_Update.Enabled = False
    End Sub
    Private Sub openToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles openToolStripMenuItem.Click
        Dim openFileDialog As New OpenFileDialog() With {
                .Filter = "Text files (*.xml)|*.xml",
                .Title = "Select a XML Shop file to Load"
            }
        If openFileDialog.ShowDialog() = DialogResult.OK Then
            Dim array As String() = openFileDialog.FileName.Split(New Char() {"."c})
            If array(array.Length - 1) = "xml" Then
                array = openFileDialog.FileName.Split(New Char() {"\"c})
                Me.label_FileName.Text = array(array.Length - 1)
                Me.ShopItems = New Structures.ShopItem(15, 8) {}
                Me.SelectedSI = Nothing
                Me.LastSelectetItem = New Structures.CustomPictureBox()
                Me.ChangeOccupid(1, 1, 8, 15, False)
                Me.ClearShopItemsPreview()
                Me.ReadShopFileXML(openFileDialog.FileName)
                Return
            End If
            MessageBox.Show("Invalid file selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    Private Sub saveAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles saveAsToolStripMenuItem.Click
        Dim saveFileDialog As New SaveFileDialog() With {
                .Title = "Select a Location to save the Shop file",
                .Filter = "Text files (*.xml)|*.xml",
                .FileName = Me.label_FileName.Text
            }
        If saveFileDialog.ShowDialog() = DialogResult.OK Then
            Dim array As String() = saveFileDialog.FileName.Split(New Char() {"\"c})
            Dim shop_name As String = array(array.Length - 1).Split(New Char() {"."c})(0)
            Try
                Dim settings As New XmlWriterSettings
                settings.Encoding = System.Text.Encoding.UTF8
                settings.Indent = True
                settings.IndentChars = "    "
                Dim writer As XmlWriter = XmlTextWriter.Create(saveFileDialog.FileName, settings)
                writer.WriteStartDocument()
                WriteHeaderComment(shop_name, writer)

                writer.WriteStartElement("Shop")
                For i As Integer = 1 To 15
                    For j As Integer = 1 To 8
                        If Me.ShopItems(i, j).UniqName IsNot Nothing Then
                            Dim shopItem As Structures.ShopItem = Me.ShopItems(i, j)
                            Dim str As String = String.Empty & (If((shopItem.Excellent > 0), "Excellent ", ""))
                            Dim str2 As String = str & (If((shopItem.Ancient > 0), "Ancient ", ""))
                            createNode(shopItem.Group.ToString,
                                       shopItem.Index.ToString,
                                       shopItem.Level.ToString,
                                       shopItem.Durablity.ToString,
                                       Convert.ToInt16(shopItem.Skill).ToString,
                                       Convert.ToInt16(shopItem.Luck).ToString,
                                       shopItem.[Option].ToString,
                                       shopItem.Excellent.ToString,
                                       shopItem.Ancient.ToString,
                                       Convert.ToInt16(shopItem.Socket).ToString,
                                       Convert.ToInt16(shopItem.Element).ToString,
                                       Convert.ToInt16(shopItem.Serial).ToString,
                                       writer)

                        End If
                    Next
                Next
                writer.WriteEndElement() ' Shop
                writer.WriteEndDocument()
                writer.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error saving file", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                Return
            End Try
            Me.label_FileName.Text = array(array.Length - 1)
        End If
    End Sub

    Private Sub createNode(ByVal Cat As String,
                       ByVal Index As String,
                       ByVal Level As String,
                       ByVal Durability As String,
                       ByVal Skill As String,
                       ByVal Luck As String,
                       ByVal Option_ As String,
                       ByVal Exc As String,
                       ByVal SetItem As String,
                       ByVal SocketCount As String,
                       ByVal Elemental As String,
                       ByVal Serial As String,
                       ByVal writer As XmlWriter)

        writer.WriteStartElement("Item")
        writer.WriteAttributeString("Cat", Cat)
        writer.WriteAttributeString("Index", Index)
        writer.WriteAttributeString("Level", Level)
        writer.WriteAttributeString("Durability", Durability)
        writer.WriteAttributeString("Skill", Skill)
        writer.WriteAttributeString("Luck", Luck)
        writer.WriteAttributeString("Option", Option_)
        writer.WriteAttributeString("Exc", Exc)
        writer.WriteAttributeString("SetItem", SetItem)
        writer.WriteAttributeString("SocketCount", SocketCount)
        writer.WriteAttributeString("Elemental", Elemental)
        writer.WriteAttributeString("Serial", Serial)
        writer.WriteEndElement()
    End Sub
    Private Sub WriteHeaderComment(ByVal shop_name As String, ByRef writer As XmlWriter)
        writer.WriteRaw(vbCrLf)
        writer.WriteRaw("<!--" & vbCrLf)
        writer.WriteRaw("// ============================================================" & vbCrLf)
        writer.WriteRaw("// == Shop file created by MU.ToolKit [Shop Editor]" & vbCrLf)
        writer.WriteRaw("// == code original by Bigman" & vbCrLf)
        writer.WriteRaw("// == coded by TopReal.IT" & vbCrLf)
        writer.WriteRaw("// == Decompiled by Virtual" & vbCrLf)
        writer.WriteRaw("// == Modified by LogoS" & vbCrLf)
        writer.WriteRaw("// == Shop: " & shop_name & vbCrLf)
        writer.WriteRaw("// ============================================================" & vbCrLf)
        writer.WriteRaw("//" & vbCrLf)
        writer.WriteRaw("// ### Shop::Item ###" & vbCrLf)
        writer.WriteRaw("//	Cat: Category of an item - refer to '\IGCData\Items\ItemList.xml'" & vbCrLf)
        writer.WriteRaw("//	Index: Index of an Item - refer to '\IGCData\Items\ItemList.xml'" & vbCrLf)
        writer.WriteRaw("//	Level: Level of an item, 0-15" & vbCrLf)
        writer.WriteRaw("//	Durability: Durability of an item, 0-255 - NOTE: some Items max durability is lower than maximum possible of 255" & vbCrLf)
        writer.WriteRaw("//	Skill: Apply skill to item, 0/1" & vbCrLf)
        writer.WriteRaw("//	Luck: Apply Luck on item, 0/1" & vbCrLf)
        writer.WriteRaw("//	Option: 0-7 (Opt * 4, example, Opt -> 7 * 4 = Item Option +28" & vbCrLf)
        writer.WriteRaw("//	Exc:  0:  No Exc options, or sum of below values (63 - Full of Excellent):" & vbCrLf)
        writer.WriteRaw("//		~ 1:  Mana recovery after Monster hunt +Mana/8" & vbCrLf)
        writer.WriteRaw("//		~ 2:  Health recovery after Monster hunt +HP/8" & vbCrLf)
        writer.WriteRaw("//		~ 4:  +7 Speed" & vbCrLf)
        writer.WriteRaw("//		~ 8:  More Damage +2%" & vbCrLf)
        writer.WriteRaw("//		~ 16: More Damage +Level/20" & vbCrLf)
        writer.WriteRaw("//		~ 32: Excellent Damage Rate +10%" & vbCrLf)
        writer.WriteRaw("//	SetItem (item must be added to set items (ancients), otherwise option will be ignored:" & vbCrLf)
        writer.WriteRaw("//		~ 0:  No Ancient" & vbCrLf)
        writer.WriteRaw("//		~ 5:  First Set type (+5 Stamina)" & vbCrLf)
        writer.WriteRaw("//		~ 6:  Second Set type (+5 Stamina)" & vbCrLf)
        writer.WriteRaw("//		~ 9:  First Set type (+10 Stamina)" & vbCrLf)
        writer.WriteRaw("//		~ 10: Second Set type (+10 Stamina)" & vbCrLf)
        writer.WriteRaw("//	SocketCount: Count of Sockets for socket item, values: 0-5" & vbCrLf)
        writer.WriteRaw("//	Elemental: Element type for elemental items: 0 ~ no Elemental Attribute, 1 ~ Fire, 2 ~ Water, 3 ~ Earth, 4 ~ Wind, 5 ~ Darkness - option ignored for S6E3" & vbCrLf)
        writer.WriteRaw("//	Serial: Generate serial for the shop item, 0/1" & vbCrLf)
        writer.WriteRaw("-->" & vbCrLf & vbCrLf)
    End Sub
#End Region ' Menu New/Open/SaveAs

#End Region

#Region "    Functions"
    Private Function AddItemPicture(toolTip As String, ByRef uniqName As String, ByRef sI As Structures.ShopItem) As Boolean
        Dim uniItem As Structures.UniItem = CType(Me.listBox_Index.SelectedItem, Structures.UniItem)
        Dim num As Integer = 0
        Dim num2 As Integer = 0
        If Not Me.GetFirstFreeBox(uniItem.X, uniItem.Y, num, num2) Then
            Return False
        End If
        Dim customPictureBox As New Structures.CustomPictureBox()

        Dim ctt As New Structures.CustomToolTip With {.sizeX = 350,
                                                      .sizeY = 210}
        ctt.SetToolTip(customPictureBox, toolTip)

        customPictureBox.Size = New Size(uniItem.X * 27, uniItem.Y * 27)
        Dim pictureBox As PictureBox = DirectCast(Me.pictureBox_ShopPreview.Controls(String.Concat(New Object() {"pictureBox_", num2, "x", num})), PictureBox)
        customPictureBox.Location = New Point(pictureBox.Location.X, pictureBox.Location.Y)
        customPictureBox.BackColor = Color.Transparent
        customPictureBox.Parent = Me.pictureBox_ShopPreview
        customPictureBox.Name = String.Concat(New Object() {"pictureBox_Item_", num2, "x", num, "_", uniItem.Y, "x", uniItem.X})
        uniqName = String.Concat(New Object() {"Item_", num2, "x", num, "_", uniItem.Y, "x", uniItem.X})
        sI.ShopLocX = num
        sI.ShopLocY = num2
        Try
            customPictureBox.BackgroundImage = DirectCast(My.Resources.ResourceManager.GetObject("_" & uniItem.Group & uniItem.Index), Bitmap)
            If customPictureBox.BackgroundImage.Size.Width > customPictureBox.Size.Width OrElse customPictureBox.BackgroundImage.Size.Height > customPictureBox.Size.Height Then
                customPictureBox.BackgroundImageLayout = ImageLayout.Zoom
            Else
                customPictureBox.BackgroundImageLayout = ImageLayout.Center
            End If
        Catch
            customPictureBox.BackgroundImage = DirectCast(My.Resources.ResourceManager.GetObject("no_img"), Bitmap)
        End Try
        AddHandler customPictureBox.MouseClick, New MouseEventHandler(AddressOf Me.pb_MouseClick)
        customPictureBox.BorderColor = Color.Gold
        Me.LastSelectetItem.BorderColor = Color.Transparent
        Me.LastSelectetItem = customPictureBox
        Me.pictureBox_ShopPreview.Controls.Add(customPictureBox)
        customPictureBox.BringToFront()
        Me.pictureBox_ShopPreview.Invalidate()
        Me.ChangeOccupid(num, num2, uniItem.X, uniItem.Y, True)
        Me.button_Update.Enabled = True
        Return True
    End Function
    Private Function AddItemPicture(toolTip As String, ByRef uniqName As String, uniqItm As Structures.UniItem, ByRef sI As Structures.ShopItem) As Boolean
        Dim uniItem As Structures.UniItem = uniqItm
        Dim num As Integer = 0
        Dim num2 As Integer = 0
        If Not Me.GetFirstFreeBox(uniItem.X, uniItem.Y, num, num2) Then
            Return False
        End If
        Dim customPictureBox As New Structures.CustomPictureBox()

        Dim ctt As New Structures.CustomToolTip With {.sizeX = 350,
                                                      .sizeY = 210}
        ctt.SetToolTip(customPictureBox, toolTip)

        customPictureBox.Size = New Size(uniItem.X * 27, uniItem.Y * 27)
        Dim pictureBox As PictureBox = DirectCast(Me.pictureBox_ShopPreview.Controls(String.Concat(New Object() {"pictureBox_", num2, "x", num})), PictureBox)
        customPictureBox.Location = New Point(pictureBox.Location.X, pictureBox.Location.Y)
        customPictureBox.BackColor = Color.Transparent
        customPictureBox.Parent = Me.pictureBox_ShopPreview
        customPictureBox.Name = String.Concat(New Object() {"pictureBox_Item_", num2, "x", num, "_", uniItem.Y, "x", uniItem.X})
        uniqName = String.Concat(New Object() {"Item_", num2, "x", num, "_", uniItem.Y, "x", uniItem.X})
        sI.ShopLocX = num
        sI.ShopLocY = num2
        Try
            customPictureBox.BackgroundImage = DirectCast(My.Resources.ResourceManager.GetObject("_" & uniItem.Group & uniItem.Index), Bitmap)
            If customPictureBox.BackgroundImage.Size.Width > customPictureBox.Size.Width OrElse customPictureBox.BackgroundImage.Size.Height > customPictureBox.Size.Height Then
                customPictureBox.BackgroundImageLayout = ImageLayout.Zoom
            Else
                customPictureBox.BackgroundImageLayout = ImageLayout.Center
            End If
        Catch
            customPictureBox.BackgroundImage = DirectCast(My.Resources.ResourceManager.GetObject("no_img"), Bitmap)
        End Try
        AddHandler customPictureBox.MouseClick, New MouseEventHandler(AddressOf Me.pb_MouseClick)
        customPictureBox.BorderColor = Color.Gold
        Me.LastSelectetItem.BorderColor = Color.Transparent
        Me.LastSelectetItem = customPictureBox
        Me.pictureBox_ShopPreview.Controls.Add(customPictureBox)
        customPictureBox.BringToFront()
        Me.pictureBox_ShopPreview.Invalidate()
        Me.ChangeOccupid(num, num2, uniItem.X, uniItem.Y, True)
        Me.button_Update.Enabled = True
        Return True
    End Function
    Private Function RetrieveListItems(ByVal Index As Integer) As List(Of Structures.UniItem)
        Select Case Index
            Case 0
                Return Me.L_Swords
            Case 1
                Return Me.L_Axes
            Case 2
                Return Me.L_MacesScepters
            Case 3
                Return Me.L_Spears
            Case 4
                Return Me.L_BowsCrossBows
            Case 5
                Return Me.L_Staffs
            Case 6
                Return Me.L_Shields
            Case 7
                Return Me.L_Helms
            Case 8
                Return Me.L_Armors
            Case 9
                Return Me.L_Pants
            Case 10
                Return Me.L_Gloves
            Case 11
                Return Me.L_Boots
            Case 12
                Return Me.L_WingsSkillsSeedsOthers
            Case 13
                Return Me.L_Others1
            Case 14
                Return Me.L_Others2
            Case 15
                Return Me.L_Scrolls
        End Select
        Return Nothing
    End Function
    Private Sub FilterLevelOption()
        Me.Check_Level_Option = False
        Me.listBox_Level.DataSource = Nothing
        Me.listBox_Option.DataSource = Nothing
        Select Case True
            Case listBox_Group.SelectedIndex = 4 And listBox_Index.SelectedIndex = 7 ' Bolt
                Me.strct.Setc_LevelData(Me.L_LevelDatas, 2)
                Me.strct.Setc_OptionData(Me.L_OptionDatas, 0)
            Case listBox_Group.SelectedIndex = 4 And listBox_Index.SelectedIndex = 15 ' Arrow
                Me.strct.Setc_LevelData(Me.L_LevelDatas, 2)
                Me.strct.Setc_OptionData(Me.L_OptionDatas, 0)
            Case Else
                Me.strct.Setc_LevelData(Me.L_LevelDatas)
                Me.strct.Setc_OptionData(Me.L_OptionDatas)
        End Select
        Me.listBox_Level.DataSource = Me.L_LevelDatas
        Me.listBox_Option.DataSource = Me.L_OptionDatas
        Me.listBox_Level.ValueMember = "ID"
        Me.listBox_Level.DisplayMember = "Name"
        Me.listBox_Option.ValueMember = "ID"
        Me.listBox_Option.DisplayMember = "Name"
        Me.Check_Level_Option = True
    End Sub
    Private Sub AddPreviewBoxes(x As Integer, y As Integer)
        Dim num As Integer = 19
        For i As Integer = 1 To y
            Dim num2 As Integer = 17
            For j As Integer = 1 To x
                Dim pictureBox As New PictureBox() With {
                    .Name = String.Concat(New Object() {"pictureBox_", i, "x", j}),
                    .Location = New Point(num2, num),
                    .Size = New Size(27, 27),
                    .BackgroundImage = My.Resources.Untitled_3
                }
                Me.pictureBox_ShopPreview.Controls.Add(pictureBox)
                pictureBox.Invalidate()
                num2 += 26
            Next
            num += 26
        Next
        Me.pictureBox_ShopPreview.Visible = True
        Me.pictureBox_ShopPreview.Invalidate()
    End Sub
    Private Sub ClearShopItemsPreview()
        Dim list As New List(Of String)()
        For Each control As Control In Me.pictureBox_ShopPreview.Controls
            If control.Name.StartsWith("pictureBox_Item_") Then
                list.Add(control.Name)
            End If
        Next
        For Each current As String In list
            Me.pictureBox_ShopPreview.Controls.RemoveByKey(current)
        Next
    End Sub
    Private Sub ChangeOccupid(startX As Integer, startY As Integer, LengthX As Integer, LengthY As Integer, state As Boolean)
        For i As Integer = 0 To LengthY - 1
            For j As Integer = 0 To LengthX - 1
                Me.OccupiedBoxes(i + startY, j + startX) = state
            Next
        Next
    End Sub
    Private Function CheckNodeAttribute(ByVal node As XmlNode, attribute As String) As String
        If node.Attributes(attribute) IsNot Nothing Then
            Return node.Attributes(attribute).InnerText
        End If
        Return "0"
    End Function
    Private Function GetExcVal() As Byte
        Dim num As Integer = 0
        num = (If(Me.checkBox_ExcOpt1.Checked, (num + 1), num))
        num = (If(Me.checkBox_ExcOpt2.Checked, (num + 2), num))
        num = (If(Me.checkBox_ExcOpt3.Checked, (num + 4), num))
        num = (If(Me.checkBox_ExcOpt4.Checked, (num + 8), num))
        num = (If(Me.checkBox_ExcOpt5.Checked, (num + 16), num))
        num = (If(Me.checkBox_ExcOpt6.Checked, (num + 32), num))
        Return Convert.ToByte(num)
    End Function
    Private Function GetFirstFreeBox(neededX As Integer, neededY As Integer, ByRef acceptedX As Integer, ByRef acceptedY As Integer) As Boolean
        For i As Integer = 1 To 15
            For j As Integer = 1 To 8
                If Not Me.OccupiedBoxes(i, j) Then
                    Dim flag As Boolean = False
                    For k As Integer = 0 To neededY - 1
                        For l As Integer = 0 To neededX - 1
                            If Not flag Then
                                If i + k <= 15 And j + l <= 8 Then
                                    If Me.OccupiedBoxes(i + k, j + l) Then
                                        flag = True
                                    End If
                                Else
                                    flag = True
                                End If
                            End If
                        Next
                    Next
                    If Not flag Then
                        acceptedX = j
                        acceptedY = i
                        Return True
                    End If
                End If
            Next
        Next
        Return False
    End Function
    Private Sub ReadShopFileXML(fName As String)
        Dim settings As New XmlReaderSettings
        settings.IgnoreComments = True
        Dim reader As XmlReader = XmlReader.Create(fName, settings)
        Dim xmlDoc As New XmlDocument
        Dim Shop As XmlNodeList
        Dim Items As XmlNodeList

        Try
            xmlDoc.Load(reader)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error loading XML")
            Me.label_FileName.Text = Nothing
            Return
        End Try

        Shop = xmlDoc.GetElementsByTagName("Shop")

        If Shop.Count > 0 Then
            Items = Shop(0).ChildNodes

            Dim group_index As String = ""
            Dim item_index As String = ""
            Dim item_level As String = ""
            Dim item_skill As String = ""
            Dim item_luck As String = ""
            Dim item_option As String = ""
            Dim item_excellent As String = ""
            Dim item_durability As String = ""
            Dim item_ancient As String = ""
            Dim item_name As String = ""
            Dim item_socket As String = ""
            Dim item_element As String = ""
            Dim item_serial As String = ""

            For xml_item As Integer = 0 To Items.Count - 1
                group_index = CheckNodeAttribute(Items(xml_item), "Cat")
                item_index = CheckNodeAttribute(Items(xml_item), "Index")
                item_level = CheckNodeAttribute(Items(xml_item), "Level")
                item_durability = CheckNodeAttribute(Items(xml_item), "Durability")
                item_skill = CheckNodeAttribute(Items(xml_item), "Skill")
                item_luck = CheckNodeAttribute(Items(xml_item), "Luck")
                item_option = CheckNodeAttribute(Items(xml_item), "Option")
                item_excellent = CheckNodeAttribute(Items(xml_item), "Exc")
                item_ancient = CheckNodeAttribute(Items(xml_item), "SetItem")
                item_name = CheckNodeAttribute(Items(xml_item), "Name")
                item_socket = CheckNodeAttribute(Items(xml_item), "SocketCount")
                item_element = CheckNodeAttribute(Items(xml_item), "Elemental")
                item_serial = CheckNodeAttribute(Items(xml_item), "Serial")

                Try
                    Dim shopItem As New Structures.ShopItem() With {
                            .Group = Convert.ToInt32(group_index),
                            .Index = Convert.ToInt32(item_index),
                            .Level = Convert.ToByte(item_level),
                            .Durablity = Convert.ToByte(item_durability),
                            .Skill = Convert.ToBoolean(Convert.ToByte(item_skill)),
                            .Luck = Convert.ToBoolean(Convert.ToByte(item_luck)),
                            .[Option] = Convert.ToByte(item_option),
                            .Excellent = Convert.ToByte(item_excellent),
                            .Ancient = Convert.ToByte(item_ancient),
                            .Socket = Convert.ToByte(item_socket),
                            .Element = Convert.ToByte(item_element),
                            .Serial = Convert.ToBoolean(Convert.ToInt16(item_serial))
                        }

                    Dim empty As String = String.Empty
                    Dim str As String = String.Empty & (If((shopItem.Excellent > 0), "Excellent ", ""))
                    Dim obj As Object = str & (If((shopItem.Ancient > 0), "Ancient ", "")) & Me.ItemName(shopItem.Group, shopItem.Index)
                    Dim str2 As String = String.Concat(New Object() {obj, "+",
                                                                     shopItem.Level, "+",
                                                                     If((shopItem.[Option] = 1),
                                                                        "4",
                                                                        (If((shopItem.[Option] = 2),
                                                                            "8", (If((shopItem.[Option] = 3),
                                                                                     "12", (If((shopItem.[Option] = 4),
                                                                                               "16", (If((shopItem.[Option] = 5),
                                                                                                         "20", (If((shopItem.[Option] = 6),
                                                                                                                   "24", (If((shopItem.[Option] = 7),
                                                                                                                             "28", "0")))))))))))))})
                    Dim text2 As String = str2 & (If(shopItem.Skill, "+Skill", ""))
                    Dim str3 As String = String.Concat(New Object() {text2,
                                                                     If(shopItem.Luck, "+Luck", ""), vbLf & vbLf & "Durability: ", shopItem.Durablity})
                    Dim text3 As String = str3 & (If((shopItem.Ancient > 0),
                                                     (If((shopItem.Ancient = 5), vbLf & vbLf & "Ancinet: Level 1",
                                                         (If((shopItem.Ancient = 10), vbLf & vbLf & "Ancinet: Level 2", "")))), ""))
                    If shopItem.Excellent > 0 Then
                        text3 = text3 & vbLf & vbLf & "Excellent Option: " & shopItem.Excellent
                    End If
                    Dim uniqItm As New Structures.UniItem() With {
                        .Group = shopItem.Group,
                        .Index = shopItem.Index
                    }
                    uniqItm.X = CInt(Convert.ToInt16(Me.ItemSize(uniqItm.Group, uniqItm.Index).Split(New Char() {"x"c})(0)))
                    uniqItm.Y = CInt(Convert.ToInt16(Me.ItemSize(uniqItm.Group, uniqItm.Index).Split(New Char() {"x"c})(1)))
                    If Me.AddItemPicture(text3, empty, uniqItm, shopItem) Then
                        shopItem.UniqName = empty
                        Me.SelectedSI = shopItem
                        Me.ShopItems(shopItem.ShopLocY, shopItem.ShopLocX) = shopItem
                    End If

                Catch ex As Exception
                    MessageBox.Show(vbTab & "Invalid line", "Error", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                    Exit Try
                End Try
            Next
        Else
            MessageBox.Show("""Shop"" tag not found", "Error loading XML")
            Me.label_FileName.Text = Nothing
            Return
        End If


    End Sub

#End Region

End Class