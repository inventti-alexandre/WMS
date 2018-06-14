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

Partial Public Class Products
    Public Property Id As Integer
    Public Property Code As String
    Public Property Name As String
    Public Property NameEng As String
    Public Property Description As String
    Public Property FKCompany As Integer
    Public Property FKOwner As Integer
    Public Property FKProductGroup As Integer
    Public Property FKProductBrand As Integer
    Public Property FKProductType As Integer
    Public Property FKZone As Integer
    Public Property ShelfLife As Integer
    Public Property ReceiveLimit As Integer
    Public Property IssueLimit As Integer
    Public Property BaseBarcode As String
    Public Property BaseUnitCode As String
    Public Property BaseUnitPackSize As Decimal
    Public Property IssueBarcode As String
    Public Property IssueUnitCode As String
    Public Property IssueUnitPackSize As Decimal
    Public Property CreateDate As Date
    Public Property CreateBy As String
    Public Property UpdateDate As Date
    Public Property UpdateBy As String
    Public Property Enable As Boolean

    Public Overridable Property Company As Company
    Public Overridable Property CheckStockLocation As ICollection(Of CheckStockLocation) = New HashSet(Of CheckStockLocation)
    Public Overridable Property CurrentStocks As ICollection(Of CurrentStocks) = New HashSet(Of CurrentStocks)
    Public Overridable Property CycleCountDTL As ICollection(Of CycleCountDTL) = New HashSet(Of CycleCountDTL)
    Public Overridable Property IssueSum As ICollection(Of IssueSum) = New HashSet(Of IssueSum)
    Public Overridable Property ManageZone As ICollection(Of ManageZone) = New HashSet(Of ManageZone)
    Public Overridable Property MaterialTrans As ICollection(Of MaterialTrans) = New HashSet(Of MaterialTrans)
    Public Overridable Property Owners As Owners
    Public Overridable Property ProductBrands As ProductBrands
    Public Overridable Property ProductDetails As ICollection(Of ProductDetails) = New HashSet(Of ProductDetails)
    Public Overridable Property ProductGroups As ProductGroups
    Public Overridable Property ProductType As ProductType
    Public Overridable Property Zone As Zone
    Public Overridable Property StockOnhand As ICollection(Of StockOnhand) = New HashSet(Of StockOnhand)
    Public Overridable Property TransferDTL As ICollection(Of TransferDTL) = New HashSet(Of TransferDTL)
    Public Overridable Property PhyCountDTL As ICollection(Of PhyCountDTL) = New HashSet(Of PhyCountDTL)

End Class