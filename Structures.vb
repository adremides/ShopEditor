Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.IO
Imports System.Windows.Forms
Imports System.Xml
Imports System.Runtime.InteropServices
Imports System.Reflection

Public Class Structures
    Public Class c_Groups
        Public _GroupID As Integer

        Public _GroupName As String

        Public Property Group() As Integer
            Get
                Return Me._GroupID
            End Get
            Set(value As Integer)
                Me._GroupID = value
            End Set
        End Property

        Public Property GroupName() As String
            Get
                Return Me._GroupName
            End Get
            Set(value As String)
                Me._GroupName = value
            End Set
        End Property

        Public Sub New(GroupID__1 As String, GroupName As String)
            Dim groupID__2 As Integer = -1
            Integer.TryParse(GroupID__1, groupID__2)
            Me._GroupID = groupID__2
            Me._GroupName = GroupName
        End Sub
    End Class

    Public Class c_ItemSlot
        Public _Index As Integer
        Public _Name As String

        Public Property Index() As Integer
            Get
                Return Me._Index
            End Get
            Set(value As Integer)
                Me._Index = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
            End Set
        End Property

        Public Sub New(ID As Integer, Name As String)
            Me._Index = ID
            Me._Name = Name
        End Sub
    End Class

    Public Class c_ItemType
        Public _Index As Integer
        Public _Name As String

        Public Property Index() As Integer
            Get
                Return Me._Index
            End Get
            Set(value As Integer)
                Me._Index = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
            End Set
        End Property

        Public Sub New(ID As Integer, Name As String)
            Me._Index = ID
            Me._Name = Name
        End Sub
    End Class

    Public Class c_CharClass
        Public _Index As String
        Public _Name As String

        Public Property Index() As String
            Get
                Return Me._Index
            End Get
            Set(value As String)
                Me._Index = value
            End Set
        End Property
        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
            End Set
        End Property

        Public Sub New(Index As String, Name As String)
            Me._Index = Index
            Me._Name = Name
        End Sub

        Public Overloads Function Equals(tmpTP As c_CharClass) As Boolean
            If tmpTP Is Nothing Then
                Return False
            End If
            Return (Me._Index.Equals(tmpTP._Index))
        End Function

        Public Overrides Function Equals(objTemp As Object) As Boolean
            If objTemp Is Nothing Then Return False
            Dim objTP As c_CharClass = TryCast(objTemp, c_CharClass)
            If objTP Is Nothing Then
                Return False
            Else
                Return Equals(objTP)
            End If
        End Function
    End Class

    Public Class c_SocketData
        Public _ID As Integer

        Public _Name As String

        Public Property ID() As Integer
            Get
                Return Me._ID
            End Get
            Set(value As Integer)
                Me._ID = value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
            End Set
        End Property

        Public Sub New(ID As Integer, Name As String)
            Me._ID = ID
            Me._Name = Name
        End Sub
    End Class
    Public Class c_ElementData
        Public _ID As Integer

        Public _Name As String

        Public Property ID() As Integer
            Get
                Return Me._ID
            End Get
            Set(value As Integer)
                Me._ID = value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
            End Set
        End Property

        Public Sub New(ID As Integer, Name As String)
            Me._ID = ID
            Me._Name = Name
        End Sub
    End Class

    Public Class c_LevelData
        Public _LevelID As Integer

        Public _LevelName As String

        Public Property ID() As Integer
            Get
                Return Me._LevelID
            End Get
            Set(value As Integer)
                Me._LevelID = value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return Me._LevelName
            End Get
            Set(value As String)
                Me._LevelName = value
            End Set
        End Property

        Public Sub New(ID As Integer, Name As String)
            Me._LevelID = ID
            Me._LevelName = Name
        End Sub
    End Class
    Public Structure c_OptionData
        Public Property ID() As Integer
            Get
                Return m_ID
            End Get
            Set(value As Integer)
                m_ID = value
            End Set
        End Property
        Private m_ID As Integer

        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = value
            End Set
        End Property
        Private m_Name As String
    End Structure

    Public Class c_AncientNames
        Public _Index As Integer
        Public _Name As String

        Public Property Index() As Integer
            Get
                Return Me._Index
            End Get
            Set(value As Integer)
                Me._Index = value
            End Set
        End Property

        Public Property Name() As String
            Get
                Return Me._Name
            End Get
            Set(value As String)
                Me._Name = value
            End Set
        End Property

        Public Sub New(Index As Integer, Name As String)
            Me._Index = Index
            Me._Name = Name
        End Sub

        Public Function ShallowCopy() As c_AncientNames
            Return DirectCast(Me.MemberwiseClone(), c_AncientNames)
        End Function
    End Class
    Public Class c_AncientItems
        Public _Cat As Integer
        Public _Item_index As Integer
        Public _IndexT1 As Integer
        Public _IndexT2 As Integer

        Public Property Cat() As Integer
            Get
                Return Me._Cat
            End Get
            Set(value As Integer)
                Me._Cat = value
            End Set
        End Property
        Public Property Item_index() As Integer
            Get
                Return Me._Item_index
            End Get
            Set(value As Integer)
                Me._Item_index = value
            End Set
        End Property

        Public Property IndexT1() As Integer
            Get
                Return Me._IndexT1
            End Get
            Set(value As Integer)
                Me._IndexT1 = value
            End Set
        End Property

        Public Property IndexT2() As Integer
            Get
                Return Me._IndexT2
            End Get
            Set(value As Integer)
                Me._IndexT2 = value
            End Set
        End Property

        Public Sub New(Cat As Integer, Item_index As Integer, IndexT1 As Integer, IndexT2 As Integer)
            Me._Cat = Cat
            Me._Item_index = Item_index
            Me._IndexT1 = IndexT1
            Me._IndexT2 = IndexT2
        End Sub
        Public Function ShallowCopy() As c_AncientItems
            Return DirectCast(Me.MemberwiseClone(), c_AncientItems)
        End Function
    End Class

    Public Class CustomPictureBox
        Inherits PictureBox
        Private _MSBType As Integer

        Private colorBorder As Color = Color.Transparent

        Public Property BorderColor() As Color
            Get
                Return Me.colorBorder
            End Get
            Set(value As Color)
                Me.colorBorder = value
            End Set
        End Property

        Public Property MSBType() As Integer
            Get
                Return Me._MSBType
            End Get
            Set(value As Integer)
                Me._MSBType = value
            End Set
        End Property

        Public Sub New()
            MyBase.SetStyle(ControlStyles.UserPaint, True)
        End Sub

        Protected Overrides Sub OnPaint(e As PaintEventArgs)
            MyBase.OnPaint(e)
            e.Graphics.DrawRectangle(New Pen(New SolidBrush(Me.colorBorder), 4.0F), e.ClipRectangle)
        End Sub
    End Class
    Public Class CustomToolTip
        Inherits ToolTip
        Private _sizeX As Integer = 230

        Private _sizeY As Integer = 140

#Region "        To disable dropshadow"
        Dim exstyle2 As Integer = GetClassLongPtr32(Handle, GCL_STYLE)

        <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="GetClassLong")>
        Public Shared Function GetClassLongPtr32(ByVal hWnd As IntPtr, ByVal nIndex As Integer) As Integer
        End Function

        <System.Runtime.InteropServices.DllImport("user32.dll", EntryPoint:="SetClassLong")>
        Public Shared Function SetClassLongPtr32(ByVal hWnd As IntPtr, ByVal nIndex As Integer, ByVal dwNewLong As Integer) As Integer
        End Function

        Private Const GCL_STYLE As Integer = -26
        Private Const CS_DROPSHADOW As Integer = &H20000

        Public ReadOnly Property Handle() As IntPtr
            Get
                Dim obj As Object
                Dim hwnd As IntPtr
                Try
                    hwnd = IntPtr.Zero
                    obj = GetType(ToolTip).InvokeMember("Handle", Reflection.BindingFlags.NonPublic Or Reflection.BindingFlags.Instance Or Reflection.BindingFlags.GetProperty, Nothing, Me, Nothing)
                    hwnd = CType(obj, IntPtr)
                Catch ex As Exception

                End Try
                Return hwnd
            End Get
        End Property
#End Region

#Region "        To correctly show transparent background"
        <DllImport("user32.dll")>
        Private Shared Function GetWindowRect(ByVal hWnd As IntPtr, ByRef lpRect As Rectangle) As Boolean
        End Function

        Private Function GetWindowRect() As Rectangle
            Dim rect As Rectangle = New Rectangle
            Dim window As NativeWindow = TryCast(GetType(ToolTip).GetField("window", BindingFlags.Instance Or BindingFlags.NonPublic).GetValue(Me), NativeWindow)
            GetWindowRect(window.Handle, rect)
            Return rect
        End Function
#End Region

        Public Property sizeX() As Integer
            Get
                Return Me._sizeX
            End Get
            Set(value As Integer)
                Me._sizeX = value
            End Set
        End Property

        Public Property sizeY() As Integer
            Get
                Return Me._sizeY
            End Get
            Set(value As Integer)
                Me._sizeY = value
            End Set
        End Property

        Public Sub New()
            MyBase.OwnerDraw = True

            ' Disable dropshadow
            If (exstyle2 And CS_DROPSHADOW) = CS_DROPSHADOW Then
                exstyle2 -= CS_DROPSHADOW
            End If
            SetClassLongPtr32(Handle, GCL_STYLE, exstyle2)

            AddHandler MyBase.Popup, New PopupEventHandler(AddressOf Me.OnPopup)
            AddHandler MyBase.Draw, New DrawToolTipEventHandler(AddressOf Me.OnDraw)
        End Sub

        Private Sub OnDraw(sender As Object, e As DrawToolTipEventArgs)
            Dim graphics As Graphics = e.Graphics

            ' Correctly show transparent background
            graphics.SmoothingMode = SmoothingMode.AntiAlias
            Dim windowRect As Rectangle = GetWindowRect()
            graphics.CopyFromScreen(windowRect.Left, windowRect.Top, 0, 0, New Size(e.Bounds.Width, e.Bounds.Height))

            Dim semiTransBrush As New SolidBrush(Color.FromArgb(92, 0, 0, 0))
            graphics.FillRectangle(semiTransBrush, e.Bounds)

            Dim stringFormat As New StringFormat()
            stringFormat.Alignment = StringAlignment.Center
            Dim rect As New Rectangle(0, 0, e.Bounds.Width, e.Bounds.Height)

            graphics.DrawString(e.ToolTipText, e.Font, Brushes.White, rect, stringFormat)

            semiTransBrush.Dispose()
        End Sub

        Private Sub OnPopup(sender As Object, e As PopupEventArgs)
            e.ToolTipSize = New Size(Me._sizeX, Me._sizeY)
        End Sub
    End Class

    Public Structure ItemSearchStuct
        Private m_ItemName As String
        Private m_ItemCategory As Integer
        Private m_ItemIndex As Integer

        Public Property ItemName() As String
            Get
                Return m_ItemName
            End Get
            Set(value As String)
                m_ItemName = value
            End Set
        End Property

        Public Property ItemCategory() As Integer
            Get
                Return m_ItemCategory
            End Get
            Set(value As Integer)
                m_ItemCategory = value
            End Set
        End Property

        Public Property ItemIndex() As Integer
            Get
                Return m_ItemIndex
            End Get
            Set(value As Integer)
                m_ItemIndex = value
            End Set
        End Property
    End Structure

    Public Structure ShopItem
        Public ShopLocX As Integer

        Public ShopLocY As Integer

        Public UniqName As String

        Public Group As Integer

        Public Index As Integer

        Public Property Level() As Byte
            Get
                Return m_Level
            End Get
            Set(value As Byte)
                m_Level = value
            End Set
        End Property
        Private m_Level As Byte

        Public Property Durablity() As Byte
            Get
                Return m_Durablity
            End Get
            Set(value As Byte)
                m_Durablity = value
            End Set
        End Property
        Private m_Durablity As Byte

        Public Property Skill() As Boolean
            Get
                Return m_Skill
            End Get
            Set(value As Boolean)
                m_Skill = value
            End Set
        End Property
        Private m_Skill As Boolean

        Public Property Luck() As Boolean
            Get
                Return m_Luck
            End Get
            Set(value As Boolean)
                m_Luck = value
            End Set
        End Property
        Private m_Luck As Boolean

        Public Property [Option]() As Byte
            Get
                Return m_Option
            End Get
            Set(value As Byte)
                m_Option = value
            End Set
        End Property
        Private m_Option As Byte

        Public Property Excellent() As Byte
            Get
                Return m_Excellent
            End Get
            Set(value As Byte)
                m_Excellent = value
            End Set
        End Property
        Private m_Excellent As Byte

        Public Property Ancient() As Byte
            Get
                Return m_Ancient
            End Get
            Set(value As Byte)
                m_Ancient = value
            End Set
        End Property
        Private m_Ancient As Byte

        Public Property Socket() As Byte
            Get
                Return m_socket
            End Get
            Set(value As Byte)
                m_socket = value
            End Set
        End Property
        Private m_socket As Byte

        Public Property Element() As Byte
            Get
                Return m_element
            End Get
            Set(value As Byte)
                m_element = value
            End Set
        End Property
        Private m_element As Byte

        Public Property Serial() As Boolean
            Get
                Return m_serial
            End Get
            Set(value As Boolean)
                m_serial = value
            End Set
        End Property
        Private m_serial As Boolean
    End Structure
    Public Structure UniItem
        Public Property Group() As Integer
            Get
                Return m_Group
            End Get
            Set(value As Integer)
                m_Group = value
            End Set
        End Property
        Private m_Group As Integer

        Public Property Index() As Integer
            Get
                Return m_Index
            End Get
            Set(value As Integer)
                m_Index = value
            End Set
        End Property
        Private m_Index As Integer

        Public Property Slot() As Integer
            Get
                Return m_Slot
            End Get
            Set(value As Integer)
                m_Slot = value
            End Set
        End Property
        Private m_Slot As Integer

        Public Property Skill() As Integer
            Get
                Return m_Skill
            End Get
            Set(value As Integer)
                m_Skill = value
            End Set
        End Property
        Private m_Skill As Integer

        Public Property X() As Integer
            Get
                Return m_X
            End Get
            Set(value As Integer)
                m_X = value
            End Set
        End Property
        Private m_X As Integer

        Public Property Y() As Integer
            Get
                Return m_Y
            End Get
            Set(value As Integer)
                m_Y = value
            End Set
        End Property
        Private m_Y As Integer

        Public Property [Option]() As Integer
            Get
                Return m_Option
            End Get
            Set(value As Integer)
                m_Option = value
            End Set
        End Property
        Private m_Option As Integer

        Public Property Name() As String
            Get
                Return m_Name
            End Get
            Set(value As String)
                m_Name = value
            End Set
        End Property
        Private m_Name As String

        Public Property Durability() As Integer
            Get
                Return m_Durability
            End Get
            Set(value As Integer)
                m_Durability = value
            End Set
        End Property
        Private m_Durability As Integer

        Public Property Ancient() As c_AncientItems
            Get
                Return m_Ancient
            End Get
            Set(value As c_AncientItems)
                m_Ancient = value
            End Set
        End Property
        Private m_Ancient As c_AncientItems

        Public Property Type() As Integer
            Get
                Return m_Type
            End Get
            Set(value As Integer)
                m_Type = value
            End Set
        End Property
        Private m_Type As Integer

        Public Property CharClass() As List(Of Structures.c_CharClass)
            Get
                Return m_CharClass
            End Get
            Set(value As List(Of Structures.c_CharClass))
                m_CharClass = value
            End Set
        End Property
        Private m_CharClass As List(Of Structures.c_CharClass)

    End Structure

    Private Function CheckNodeAttribute(ByVal node As XmlNode, attribute As String) As String
        If node.Attributes(attribute) IsNot Nothing Then
            Return node.Attributes(attribute).InnerText
        End If
        Return "0"
    End Function
    Public Sub ReadItemSetOption(fLocation As String, ByRef L_AncientNames As List(Of Structures.c_AncientNames))

        Dim index As String
        Dim name As String

        Dim settings As New XmlReaderSettings
        settings.IgnoreComments = True
        Dim reader As XmlReader = XmlReader.Create(fLocation, settings)
        Dim xmlDoc As New XmlDocument
        Dim SetItem As XmlNodeList

        xmlDoc.Load(reader)
        SetItem = xmlDoc.GetElementsByTagName("SetItem")

        For xml_setitem As Integer = 0 To SetItem.Count - 1
            index = SetItem(xml_setitem).Attributes("Index").InnerText
            name = SetItem(xml_setitem).Attributes("Name").InnerText
            L_AncientNames.Add(New Structures.c_AncientNames(Convert.ToInt32(index), name))
        Next

        reader.Close()

    End Sub
    Public Sub ReadItemSetType(fLocation As String, ByRef L_Ancient As List(Of Structures.c_AncientItems))

        Dim cat As String
        Dim item_index As String
        Dim indext1 As String
        Dim indext2 As String

        Dim settings As New XmlReaderSettings
        settings.IgnoreComments = True
        Dim reader As XmlReader = XmlReader.Create(fLocation, settings)
        Dim xmlDoc As New XmlDocument
        Dim Sections As XmlNodeList
        Dim Items As XmlNodeList

        xmlDoc.Load(reader)
        Sections = xmlDoc.GetElementsByTagName("Section")

        For xml_section As Integer = 0 To Sections.Count - 1
            If Sections(xml_section).Attributes("DropRate") IsNot Nothing Then
                Continue For
            End If
            cat = Sections(xml_section).Attributes("Index").InnerText

            Items = Sections(xml_section).ChildNodes

            For xml_item As Integer = 0 To Items.Count - 1
                item_index = CheckNodeAttribute(Items(xml_item), "Index")
                indext1 = CheckNodeAttribute(Items(xml_item), "TierI")
                indext2 = CheckNodeAttribute(Items(xml_item), "TierII")

                L_Ancient.Add(New Structures.c_AncientItems(Convert.ToInt32(cat),
                                                       Convert.ToInt32(item_index),
                                                       Convert.ToInt32(indext1),
                                                       Convert.ToInt32(indext2)))
            Next
        Next

        reader.Close()

    End Sub
    Public Sub ReadItemList(fLocation As String, ByRef L_Groups As List(Of Structures.c_Groups),
                                                    ByRef L_Swords As List(Of Structures.UniItem),
                                                    ByRef L_Axes As List(Of Structures.UniItem),
                                                    ByRef L_MacesScepters As List(Of Structures.UniItem),
                                                    ByRef L_Spears As List(Of Structures.UniItem),
                                                    ByRef L_BowsCrossBows As List(Of Structures.UniItem),
                                                    ByRef L_Staffs As List(Of Structures.UniItem),
                                                    ByRef L_Shields As List(Of Structures.UniItem),
                                                    ByRef L_Helms As List(Of Structures.UniItem),
                                                    ByRef L_Armors As List(Of Structures.UniItem),
                                                    ByRef L_Pants As List(Of Structures.UniItem),
                                                    ByRef L_Gloves As List(Of Structures.UniItem),
                                                    ByRef L_Boots As List(Of Structures.UniItem),
                                                    ByRef L_WingsSkillsSeedsOther As List(Of Structures.UniItem),
                                                    ByRef L_Others1 As List(Of Structures.UniItem),
                                                    ByRef L_Others2 As List(Of Structures.UniItem),
                                                    ByRef L_Scrolls As List(Of Structures.UniItem),
                                                    ByRef ItemName As String(,),
                                                    ByRef ItemSize As String(,),
                                                    ByRef L_Ancient As List(Of Structures.c_AncientItems),
                                                    ByRef L_AncientNames As List(Of Structures.c_AncientNames),
                                                    ByRef L_SearchItems As List(Of Structures.ItemSearchStuct),
                                                    ByVal L_CharClassDatas As List(Of Structures.c_CharClass))

        Dim group_index As String = ""
        Dim group_name As String = ""

        Dim item_index As String = ""
        Dim item_slot As String = ""
        Dim item_skill As String = ""
        Dim item_x As String = ""
        Dim item_y As String = ""
        Dim item_option As String = ""
        Dim item_durability As String = ""
        Dim item_ancient As c_AncientItems
        Dim item_name As String = ""
        Dim item_type As String = ""

        Try
            Dim settings As New XmlReaderSettings
            settings.IgnoreComments = True
            Dim reader As XmlReader = XmlReader.Create(fLocation, settings)
            Dim xmlDoc As New XmlDocument
            Dim Sections As XmlNodeList
            Dim Items As XmlNodeList
            xmlDoc.Load(reader)
            Sections = xmlDoc.GetElementsByTagName("Section")

            For xml_section As Integer = 0 To Sections.Count - 1
                group_index = Sections(xml_section).Attributes("Index").InnerText
                group_name = Sections(xml_section).Attributes("Name").InnerText

                L_Groups.Add(New Structures.c_Groups(group_index, group_name))

                Items = Sections(xml_section).ChildNodes

                For xml_item As Integer = 0 To Items.Count - 1
                    item_index = CheckNodeAttribute(Items(xml_item), "Index")
                    item_slot = CheckNodeAttribute(Items(xml_item), "Slot")
                    item_skill = CheckNodeAttribute(Items(xml_item), "SkillIndex")
                    item_x = CheckNodeAttribute(Items(xml_item), "Width")
                    item_y = CheckNodeAttribute(Items(xml_item), "Height")
                    item_option = CheckNodeAttribute(Items(xml_item), "Option")
                    item_durability = CheckNodeAttribute(Items(xml_item), "Durability")
                    item_type = CheckNodeAttribute(Items(xml_item), "Type")

                    Dim gi As Integer = Convert.ToInt32(group_index)
                    Dim ii As Integer = Convert.ToInt32(item_index)
                    item_ancient = L_Ancient.Find(Function(ancient) ancient.Cat = gi And ancient.Item_index = ii)

                    Dim cc As New List(Of String)
                    Dim item_charclass As New List(Of c_CharClass)
                    cc.Add(CheckNodeAttribute(Items(xml_item), "DarkKnight"))
                    cc.Add(CheckNodeAttribute(Items(xml_item), "FairyElf"))
                    cc.Add(CheckNodeAttribute(Items(xml_item), "DarkWizard"))
                    cc.Add(CheckNodeAttribute(Items(xml_item), "MagicGladiator"))
                    cc.Add(CheckNodeAttribute(Items(xml_item), "DarkLord"))
                    cc.Add(CheckNodeAttribute(Items(xml_item), "Summoner"))
                    cc.Add(CheckNodeAttribute(Items(xml_item), "RageFighter"))
                    For i As Integer = 0 To cc.Count - 1
                        If cc.Item(i) <> "0" Then
                            Dim c As String = i.ToString
                            Dim e As String = cc.Item(i)
                            Dim found As c_CharClass = L_CharClassDatas.Find(Function(charclass) charclass.Index = c & e)
                            If found IsNot Nothing Then
                                item_charclass.Add(found)
                            End If
                        End If
                    Next

                    item_name = CheckNodeAttribute(Items(xml_item), "Name")

                    Dim item As New Structures.UniItem() With {
                                .Group = Convert.ToInt32(group_index),
                                .Index = Convert.ToInt32(item_index),
                                .Slot = Convert.ToInt32(item_slot),
                                .Skill = Convert.ToInt32(item_skill),
                                .X = Convert.ToInt32(item_x),
                                .Y = Convert.ToInt32(item_y),
                                .[Option] = Convert.ToInt32(item_option),
                                .Durability = Convert.ToInt16(item_durability),
                                .Ancient = If(item_ancient IsNot Nothing, item_ancient.ShallowCopy, Nothing),
                                .Name = item_name,
                                .Type = Convert.ToInt16(item_type),
                                .CharClass = item_charclass
                            }

                    Dim searchItem As New Structures.ItemSearchStuct() With {
                            .ItemName = item_name,
                            .ItemCategory = Convert.ToInt32(group_index),
                            .ItemIndex = Convert.ToInt32(item_index)
                        }
                    L_SearchItems.Add(searchItem)

                    Select Case item.Group
                        Case 0
                            L_Swords.Add(item)
                            Exit Select
                        Case 1
                            L_Axes.Add(item)
                            Exit Select
                        Case 2
                            L_MacesScepters.Add(item)
                            Exit Select
                        Case 3
                            L_Spears.Add(item)
                            Exit Select
                        Case 4
                            L_BowsCrossBows.Add(item)
                            Exit Select
                        Case 5
                            L_Staffs.Add(item)
                            Exit Select
                        Case 6
                            L_Shields.Add(item)
                            Exit Select
                        Case 7
                            L_Helms.Add(item)
                            Exit Select
                        Case 8
                            L_Armors.Add(item)
                            Exit Select
                        Case 9
                            L_Pants.Add(item)
                            Exit Select
                        Case 10
                            L_Gloves.Add(item)
                            Exit Select
                        Case 11
                            L_Boots.Add(item)
                            Exit Select
                        Case 12
                            L_WingsSkillsSeedsOther.Add(item)
                            Exit Select
                        Case 13
                            L_Others1.Add(item)
                            Exit Select
                        Case 14
                            L_Others2.Add(item)
                            Exit Select
                        Case 15
                            L_Scrolls.Add(item)
                            Exit Select
                    End Select
                    If ItemName IsNot Nothing Then
                        ItemName(item.Group, item.Index) = item.Name
                    End If
                    If ItemSize IsNot Nothing Then
                        ItemSize(item.Group, item.Index) = item.X & "x" & item.Y
                    End If
                Next xml_item
            Next xml_section
        Catch ex As Exception
            MessageBox.Show(ex.Message, "[ReadItemList] ERROR")
            Application.[Exit]()
        End Try
    End Sub

    Public Sub Setc_LevelData(ByRef c_LevelDatas As List(Of Structures.c_LevelData), Optional ByVal MaxLevel As Integer = 15)
        c_LevelDatas.Clear()
        For i As Integer = 0 To MaxLevel
            c_LevelDatas.Add(New Structures.c_LevelData(i, "+" & i.ToString))
        Next
    End Sub
    Public Sub Setc_OptionData(ByRef c_OptionDatas As List(Of Structures.c_OptionData), Optional ByVal MaxOption As Integer = 7)
        c_OptionDatas.Clear()
        Dim item As New Structures.c_OptionData()
        For i As Integer = 0 To MaxOption
            item.ID = i
            item.Name = "+" & i * 4
            c_OptionDatas.Add(item)
        Next
    End Sub

    Public Sub Setc_AncientNames(ByVal L_AncientNames As List(Of Structures.c_AncientNames),
                                 ByVal Ancient_Indexes As Structures.c_AncientItems,
                                 ByRef combo_AncientNames As List(Of Structures.c_AncientNames))

        Dim IndexT1 As Integer = 0
        Dim IndexT2 As Integer = 0

        combo_AncientNames.Clear()
        combo_AncientNames.Insert(0, New Structures.c_AncientNames(Nothing, "None"))

        If Ancient_Indexes IsNot Nothing Then
            IndexT1 = Ancient_Indexes.IndexT1
            IndexT2 = Ancient_Indexes.IndexT2
        End If

        If IndexT1 > 0 Then
            Dim t1 As Structures.c_AncientNames = L_AncientNames.Find(Function(ti) ti.Index = IndexT1)
            If t1 IsNot Nothing Then
                combo_AncientNames.Add(New Structures.c_AncientNames(t1.Index, t1.Name))
            End If
        End If
        If IndexT2 > 0 Then
            Dim t2 As Structures.c_AncientNames = L_AncientNames.Find(Function(ti) ti.Index = IndexT2)
            If t2 IsNot Nothing Then
                combo_AncientNames.Add(New Structures.c_AncientNames(t2.Index, t2.Name))
            End If
        End If
    End Sub
    Public Sub Setc_AncientLevels(ByRef L_AncientLevels As List(Of Structures.c_AncientNames))
        L_AncientLevels.Clear()
        L_AncientLevels.Add(New Structures.c_AncientNames(5, "+5"))
        L_AncientLevels.Add(New Structures.c_AncientNames(9, "+10"))
    End Sub

    Public Sub Setc_SocketAmount(ByRef L_SocketDatas As List(Of Structures.c_SocketData))
        L_SocketDatas.Clear()
        For i As Integer = 0 To 5
            L_SocketDatas.Add(New Structures.c_SocketData(i, i.ToString))
        Next
    End Sub

    Public Sub Setc_Elements(ByRef L_ElementDatas As List(Of Structures.c_ElementData))
        L_ElementDatas.Clear()
        L_ElementDatas.Add(New Structures.c_ElementData(0, "No element"))
        L_ElementDatas.Add(New Structures.c_ElementData(1, "Fire"))
        L_ElementDatas.Add(New Structures.c_ElementData(2, "Water"))
        L_ElementDatas.Add(New Structures.c_ElementData(3, "Earth"))
        L_ElementDatas.Add(New Structures.c_ElementData(4, "Wind"))
        L_ElementDatas.Add(New Structures.c_ElementData(5, "Darkness"))
    End Sub

    Public Sub Setc_CharClass(ByRef L_CharClassDatas As List(Of Structures.c_CharClass))
        L_CharClassDatas.Clear()
        L_CharClassDatas.Add(New Structures.c_CharClass("01", "Dark Knight"))
        L_CharClassDatas.Add(New Structures.c_CharClass("02", "Blade Knight"))
        L_CharClassDatas.Add(New Structures.c_CharClass("03", "Blade Master"))
        L_CharClassDatas.Add(New Structures.c_CharClass("11", "Fairy Elf"))
        L_CharClassDatas.Add(New Structures.c_CharClass("12", "Muse Elf"))
        L_CharClassDatas.Add(New Structures.c_CharClass("13", "High Elf"))
        L_CharClassDatas.Add(New Structures.c_CharClass("21", "Dark Wizard"))
        L_CharClassDatas.Add(New Structures.c_CharClass("22", "Soul Master"))
        L_CharClassDatas.Add(New Structures.c_CharClass("23", "Grand Master"))
        L_CharClassDatas.Add(New Structures.c_CharClass("31", "Magic Gladiator"))
        L_CharClassDatas.Add(New Structures.c_CharClass("32", "Duel Master"))
        L_CharClassDatas.Add(New Structures.c_CharClass("41", "Dark Lord"))
        L_CharClassDatas.Add(New Structures.c_CharClass("42", "Lord Emperor"))
        L_CharClassDatas.Add(New Structures.c_CharClass("51", "Summoner"))
        L_CharClassDatas.Add(New Structures.c_CharClass("52", "Bloody Summoner"))
        L_CharClassDatas.Add(New Structures.c_CharClass("53", "Dimension Master"))
        L_CharClassDatas.Add(New Structures.c_CharClass("61", "Rage Fighter"))
        L_CharClassDatas.Add(New Structures.c_CharClass("62", "Fist Master"))
    End Sub

    Public Sub Setc_ItemType(ByRef L_ItemTypeDatas As List(Of Structures.c_ItemType))
        L_ItemTypeDatas.Clear()
        L_ItemTypeDatas.Add(New Structures.c_ItemType(-1, "All"))
        L_ItemTypeDatas.Add(New Structures.c_ItemType(0, "Common"))
        L_ItemTypeDatas.Add(New Structures.c_ItemType(1, "Regular Item"))
        L_ItemTypeDatas.Add(New Structures.c_ItemType(2, "Socket Item"))
        L_ItemTypeDatas.Add(New Structures.c_ItemType(3, "380 Option Item"))
        L_ItemTypeDatas.Add(New Structures.c_ItemType(4, "Lucky Item / Socket + Refinery"))
        L_ItemTypeDatas.Add(New Structures.c_ItemType(5, "Event Item"))
        L_ItemTypeDatas.Add(New Structures.c_ItemType(6, "Archangel Item"))
        L_ItemTypeDatas.Add(New Structures.c_ItemType(7, "Chaos Item"))
    End Sub

    Public Sub Setc_ItemSlot(ByRef L_ItemSlotDatas As List(Of Structures.c_ItemSlot))
        L_ItemSlotDatas.Clear()
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(-2, "All"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(-1, "Not Applies"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(0, "Left Hand"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(1, "Right Hand"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(2, "Helmet"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(3, "Armor"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(4, "Pants"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(5, "Gloves"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(6, "Boots"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(7, "Wings"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(8, "Helper (pet)"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(9, "Pendant"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(10, "Left Ring"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(11, "Right Ring"))
        L_ItemSlotDatas.Add(New Structures.c_ItemSlot(236, "Pentagram"))
    End Sub

End Class
