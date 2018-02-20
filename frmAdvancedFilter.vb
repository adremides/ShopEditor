Imports System.Collections.Generic
Public Class frmAdvancedFilter

    Private L_CharClassDatas As New List(Of Structures.c_CharClass)
    Private L_ItemTypeDatas As New List(Of Structures.c_ItemType)
    Private L_ItemSlotDatas As New List(Of Structures.c_ItemSlot)
    Private strc As New Structures

    Private Sub frmAdvancedFilter_Load(sender As Object, e As EventArgs) Handles Me.Load
        grpCharacterClass.Enabled = chkCharClass.Checked

        strc.Setc_CharClass(L_CharClassDatas)
        cmbClass.DataSource = L_CharClassDatas
        cmbClass.ValueMember = "Index"
        cmbClass.DisplayMember = "Name"

        strc.Setc_ItemType(L_ItemTypeDatas)
        cmbType.DataSource = L_ItemTypeDatas
        cmbType.ValueMember = "Index"
        cmbType.DisplayMember = "Name"

        strc.Setc_ItemSlot(L_ItemSlotDatas)
        cmbSlot.DataSource = L_ItemSlotDatas
        cmbSlot.ValueMember = "Index"
        cmbSlot.DisplayMember = "Name"

    End Sub

    Private Sub chkCharClass_CheckedChanged(sender As Object, e As EventArgs) Handles chkCharClass.CheckedChanged
        grpCharacterClass.Enabled = chkCharClass.Checked
    End Sub

End Class