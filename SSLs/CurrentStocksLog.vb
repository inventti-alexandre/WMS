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

Partial Public Class CurrentStocksLog
    Public Property RowID As Integer
    Public Property Id As Nullable(Of Integer)
    Public Property FKCompany As Nullable(Of Integer)
    Public Property FKOwner As Nullable(Of Integer)
    Public Property FKWarehouse As Nullable(Of Integer)
    Public Property FKVendor As Nullable(Of Integer)
    Public Property FKLocation As Nullable(Of Integer)
    Public Property FKProduct As Nullable(Of Integer)
    Public Property Qty As Nullable(Of Decimal)
    Public Property BookQty As Nullable(Of Decimal)
    Public Property PriceUnit As Nullable(Of Decimal)
    Public Property NetPrice As Nullable(Of Decimal)
    Public Property FKProductUnit As Nullable(Of Integer)
    Public Property LotNo As String
    Public Property ProductDate As Nullable(Of Date)
    Public Property ExpDate As Nullable(Of Date)
    Public Property ReceiveDate As Nullable(Of Date)
    Public Property FKItemStatus As Nullable(Of Integer)
    Public Property PalletCode As String
    Public Property ACCTASSCAT As String
    Public Property SourceConfirm As String
    Public Property CreateDate As Nullable(Of Date)
    Public Property CreateBy As String
    Public Property UpdateDate As Nullable(Of Date)
    Public Property UpdateBy As String
    Public Property CheckBy As String
    Public Property CheckDate As Nullable(Of Date)
    Public Property Enable As Nullable(Of Boolean)

End Class
