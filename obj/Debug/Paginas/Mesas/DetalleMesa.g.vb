﻿#ExternalChecksum("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml","{8829d00f-11b8-4213-878b-770e8597ac16}","0D854E8426753DF3A119D57675EB0BBB97D868A37B14A1343493BC1CA4E0646D")
'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports RestPOS
Imports System
Imports System.Diagnostics
Imports System.Windows
Imports System.Windows.Automation
Imports System.Windows.Controls
Imports System.Windows.Controls.Primitives
Imports System.Windows.Data
Imports System.Windows.Documents
Imports System.Windows.Ink
Imports System.Windows.Input
Imports System.Windows.Markup
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Media.Effects
Imports System.Windows.Media.Imaging
Imports System.Windows.Media.Media3D
Imports System.Windows.Media.TextFormatting
Imports System.Windows.Navigation
Imports System.Windows.Shapes
Imports System.Windows.Shell


'''<summary>
'''DetalleMesa
'''</summary>
<Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>  _
Partial Public Class DetalleMesa
    Inherits System.Windows.Controls.Page
    Implements System.Windows.Markup.IComponentConnector
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",11)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Recursos As System.Windows.ResourceDictionary
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",14)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents OptionsBar As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",25)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents BackKey As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",85)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Mod_Cantidad As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",90)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Mod_Precio As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",96)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Mod_Detalle As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",102)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Mod_Modificar As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",108)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Mod_Tiempo As System.Windows.Controls.Grid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",117)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents LabelMesa As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",123)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents NombreTrabajador As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",128)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Categories As System.Windows.Controls.Primitives.UniformGrid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",130)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents LabelTotal As System.Windows.Controls.Label
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",133)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents ListaPedido As System.Windows.Controls.DataGrid
    
    #End ExternalSource
    
    
    #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",144)
    <System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")>  _
    Friend WithEvents Productos As System.Windows.Controls.Primitives.UniformGrid
    
    #End ExternalSource
    
    Private _contentLoaded As Boolean
    
    '''<summary>
    '''InitializeComponent
    '''</summary>
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")>  _
    Public Sub InitializeComponent() Implements System.Windows.Markup.IComponentConnector.InitializeComponent
        If _contentLoaded Then
            Return
        End If
        _contentLoaded = true
        Dim resourceLocater As System.Uri = New System.Uri("/RestPOS;component/paginas/mesas/detallemesa.xaml", System.UriKind.Relative)
        
        #ExternalSource("..\..\..\..\Paginas\Mesas\DetalleMesa.xaml",1)
        System.Windows.Application.LoadComponent(Me, resourceLocater)
        
        #End ExternalSource
    End Sub
    
    <System.Diagnostics.DebuggerNonUserCodeAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0"),  _
     System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity"),  _
     System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")>  _
    Sub System_Windows_Markup_IComponentConnector_Connect(ByVal connectionId As Integer, ByVal target As Object) Implements System.Windows.Markup.IComponentConnector.Connect
        If (connectionId = 1) Then
            Me.Recursos = CType(target,System.Windows.ResourceDictionary)
            Return
        End If
        If (connectionId = 2) Then
            Me.OptionsBar = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 3) Then
            Me.BackKey = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 4) Then
            Me.Mod_Cantidad = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 5) Then
            Me.Mod_Precio = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 6) Then
            Me.Mod_Detalle = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 7) Then
            Me.Mod_Modificar = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 8) Then
            Me.Mod_Tiempo = CType(target,System.Windows.Controls.Grid)
            Return
        End If
        If (connectionId = 9) Then
            Me.LabelMesa = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 10) Then
            Me.NombreTrabajador = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 11) Then
            Me.Categories = CType(target,System.Windows.Controls.Primitives.UniformGrid)
            Return
        End If
        If (connectionId = 12) Then
            Me.LabelTotal = CType(target,System.Windows.Controls.Label)
            Return
        End If
        If (connectionId = 13) Then
            Me.ListaPedido = CType(target,System.Windows.Controls.DataGrid)
            Return
        End If
        If (connectionId = 14) Then
            Me.Productos = CType(target,System.Windows.Controls.Primitives.UniformGrid)
            Return
        End If
        Me._contentLoaded = true
    End Sub
End Class
