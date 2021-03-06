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

Partial Public Class ItemStatus
    Public Property Id As Integer
    Public Property Code As String
    Public Property Name As String
    Public Property Description As String
    Public Property CreateDate As Date
    Public Property CreateBy As String
    Public Property UpdateDate As Date
    Public Property UpdateBy As String
    Public Property Enable As Boolean
    Public Property FKCompany As Integer

    Public Overridable Property CheckStockLocation As ICollection(Of CheckStockLocation) = New HashSet(Of CheckStockLocation)
    Public Overridable Property CurrentStocks As ICollection(Of CurrentStocks) = New HashSet(Of CurrentStocks)
    Public Overridable Property CycleCountDTL As ICollection(Of CycleCountDTL) = New HashSet(Of CycleCountDTL)
    Public Overridable Property IssueSum As ICollection(Of IssueSum) = New HashSet(Of IssueSum)
    Public Overridable Property RcvDetails As ICollection(Of RcvDetails) = New HashSet(Of RcvDetails)
    Public Overridable Property RcvLocation As ICollection(Of RcvLocation) = New HashSet(Of RcvLocation)
    Public Overridable Property StockOnhand As ICollection(Of StockOnhand) = New HashSet(Of StockOnhand)
    Public Overridable Property TransferDTL As ICollection(Of TransferDTL) = New HashSet(Of TransferDTL)
    Public Overridable Property PhyCountDTL As ICollection(Of PhyCountDTL) = New HashSet(Of PhyCountDTL)
    Public Overridable Property PickOrderDTL As ICollection(Of PickOrderDTL) = New HashSet(Of PickOrderDTL)

End Class
