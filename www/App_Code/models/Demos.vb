﻿' Demo model class
'
' Part of ASP.NET osa framework  www.osalabs.com/osafw/asp.net
' (c) 2009-2015 Oleg Savchuk www.osalabs.com

Public Class Demos
    Inherits FwModel

    Public Sub New()
        MyBase.New()
        table_name = "demos"
    End Sub

    'check if item exists for a given email
    Public Overrides Function isExists(uniq_key As Object, not_id As Integer) As Boolean
        Return isExistsByField(uniq_key, not_id, "email")
    End Function

    Public Overridable Function getSelectOptionsParent(sel_id As String) As String
        Dim rows = db.array("select id, iname from " & Me.table_name & " where parent_id=0 and status<>127 order by iname")
        Return FormUtils.selectOptions(rows, sel_id)
    End Function

End Class
