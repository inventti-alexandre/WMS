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

Partial Public Class Transports
    Public Property Id As Integer
    Public Property Code As String
    Public Property Name As String
    Public Property Address As String
    Public Property Tel As String
    Public Property Fax As String
    Public Property Email As String
    Public Property Description As String
    Public Property CreateDate As Date
    Public Property CreateBy As String
    Public Property UpdateDate As Date
    Public Property UpdateBy As String
    Public Property Enable As Boolean
    Public Property FKCompany As Integer

    Public Overridable Property IssueSum As ICollection(Of IssueSum) = New HashSet(Of IssueSum)
    Public Overridable Property PickOrderHD As ICollection(Of PickOrderHD) = New HashSet(Of PickOrderHD)

End Class