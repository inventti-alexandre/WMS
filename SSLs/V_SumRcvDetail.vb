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

Partial Public Class V_SumRcvDetail
    Public Property Id As Integer
    Public Property FKRcvHeader As Integer
    Public Property FKWarehouse As Integer
    Public Property FKProductDetail As Integer
    Public Property FKItemStatus As Integer
    Public Property ProductDate As Date
    Public Property FKLocation As Nullable(Of Integer)
    Public Property PalletNo As Nullable(Of Integer)
    Public Property Remark As String
    Public Property qty As Nullable(Of Decimal)
    Public Property PriceUnit As Decimal
    Public Property Netprice As Nullable(Of Decimal)
    Public Property ExpDate As Date
    Public Property FKCompany As Integer
    Public Property FKZone As Integer
    Public Property FKOwner As Integer
    Public Property PalletTotal As Integer
    Public Property FKProduct As Integer
    Public Property PackSize As Decimal
    Public Property FKProductUnit As Integer
    Public Property LotNo As String

End Class
