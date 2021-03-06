'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class ProductDetails
    Public Property Id As Integer
    Public Property Code As String
    Public Property Description As String
    Public Property FKProduct As Integer
    Public Property FKProductUnit As Integer
    Public Property IsBaseUnit As Boolean
    Public Property IssueUnit As Boolean
    Public Property PackSize As Decimal
    Public Property PalletRow As Integer
    Public Property PalletLevel As Integer
    Public Property PalletTotal As Integer
    Public Property GrossWeight As Decimal
    Public Property Width As Decimal
    Public Property Length As Decimal
    Public Property Height As Decimal
    Public Property MinStock As Integer
    Public Property MaxStock As Integer
    Public Property UnitCost As Decimal
    Public Property CreateDate As Date
    Public Property CreateBy As String
    Public Property UpdateDate As Date
    Public Property UpdateBy As String
    Public Property Enable As Boolean

    Public Overridable Property LabelLog As ICollection(Of LabelLog) = New HashSet(Of LabelLog)
    Public Overridable Property Products As Products
    Public Overridable Property ProductUnit As ProductUnit
    Public Overridable Property RcvDetails As ICollection(Of RcvDetails) = New HashSet(Of RcvDetails)
    Public Overridable Property RcvLocation As ICollection(Of RcvLocation) = New HashSet(Of RcvLocation)
    Public Overridable Property PickOrderDTL As ICollection(Of PickOrderDTL) = New HashSet(Of PickOrderDTL)

End Class
