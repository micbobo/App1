﻿'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'     Runtime Version:4.0.30319.34209
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System.Runtime.Serialization

'
'This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 12.0.21005.1
'
Namespace ServiceReference1
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0"),  _
     System.Runtime.Serialization.DataContractAttribute(Name:="CompositeType", [Namespace]:="http://schemas.datacontract.org/2004/07/StageGardeService")>  _
    Partial Public Class CompositeType
        Inherits Object
        Implements System.ComponentModel.INotifyPropertyChanged
        
        Private BoolValueField As Boolean
        
        Private StringValueField As String
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property BoolValue() As Boolean
            Get
                Return Me.BoolValueField
            End Get
            Set
                If (Me.BoolValueField.Equals(value) <> true) Then
                    Me.BoolValueField = value
                    Me.RaisePropertyChanged("BoolValue")
                End If
            End Set
        End Property
        
        <System.Runtime.Serialization.DataMemberAttribute()>  _
        Public Property StringValue() As String
            Get
                Return Me.StringValueField
            End Get
            Set
                If (Object.ReferenceEquals(Me.StringValueField, value) <> true) Then
                    Me.StringValueField = value
                    Me.RaisePropertyChanged("StringValue")
                End If
            End Set
        End Property
        
        Public Event PropertyChanged As System.ComponentModel.PropertyChangedEventHandler Implements System.ComponentModel.INotifyPropertyChanged.PropertyChanged
        
        Protected Sub RaisePropertyChanged(ByVal propertyName As String)
            Dim propertyChanged As System.ComponentModel.PropertyChangedEventHandler = Me.PropertyChangedEvent
            If (Not (propertyChanged) Is Nothing) Then
                propertyChanged(Me, New System.ComponentModel.PropertyChangedEventArgs(propertyName))
            End If
        End Sub
    End Class
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0"),  _
     System.ServiceModel.ServiceContractAttribute(ConfigurationName:="ServiceReference1.IService1")>  _
    Public Interface IService1
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/GetData", ReplyAction:="http://tempuri.org/IService1/GetDataResponse")>  _
        Function GetDataAsync(ByVal value As Integer) As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/GetListeGarde", ReplyAction:="http://tempuri.org/IService1/GetListeGardeResponse")>  _
        Function GetListeGardeAsync() As System.Threading.Tasks.Task(Of String)
        
        <System.ServiceModel.OperationContractAttribute(Action:="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction:="http://tempuri.org/IService1/GetDataUsingDataContractResponse")>  _
        Function GetDataUsingDataContractAsync(ByVal composite As ServiceReference1.CompositeType) As System.Threading.Tasks.Task(Of ServiceReference1.CompositeType)
    End Interface
    
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Public Interface IService1Channel
        Inherits ServiceReference1.IService1, System.ServiceModel.IClientChannel
    End Interface
    
    <System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")>  _
    Partial Public Class Service1Client
        Inherits System.ServiceModel.ClientBase(Of ServiceReference1.IService1)
        Implements ServiceReference1.IService1
        
        ''' <summary>
        ''' Implement this partial method to configure the service endpoint.
        ''' </summary>
        ''' <param name="serviceEndpoint">The endpoint to configure</param>
        ''' <param name="clientCredentials">The client credentials</param>
        Partial Private Shared Sub ConfigureEndpoint(ByVal serviceEndpoint As System.ServiceModel.Description.ServiceEndpoint, ByVal clientCredentials As System.ServiceModel.Description.ClientCredentials)
        End Sub
        
        Public Sub New(ByVal endpointConfiguration As EndpointConfiguration)
            MyBase.New(Service1Client.GetBindingForEndpoint(endpointConfiguration), Service1Client.GetEndpointAddress(endpointConfiguration))
            Me.Endpoint.Name = endpointConfiguration.ToString
            ConfigureEndpoint(Me.Endpoint, Me.ClientCredentials)
        End Sub
        
        Public Sub New(ByVal endpointConfiguration As EndpointConfiguration, ByVal remoteAddress As String)
            MyBase.New(Service1Client.GetBindingForEndpoint(endpointConfiguration), New System.ServiceModel.EndpointAddress(remoteAddress))
            Me.Endpoint.Name = endpointConfiguration.ToString
            ConfigureEndpoint(Me.Endpoint, Me.ClientCredentials)
        End Sub
        
        Public Sub New(ByVal endpointConfiguration As EndpointConfiguration, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(Service1Client.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
            Me.Endpoint.Name = endpointConfiguration.ToString
            ConfigureEndpoint(Me.Endpoint, Me.ClientCredentials)
        End Sub
        
        Public Sub New(ByVal binding As System.ServiceModel.Channels.Binding, ByVal remoteAddress As System.ServiceModel.EndpointAddress)
            MyBase.New(binding, remoteAddress)
        End Sub
        
        Public Function GetDataAsync(ByVal value As Integer) As System.Threading.Tasks.Task(Of String) Implements ServiceReference1.IService1.GetDataAsync
            Return MyBase.Channel.GetDataAsync(value)
        End Function
        
        Public Function GetListeGardeAsync() As System.Threading.Tasks.Task(Of String) Implements ServiceReference1.IService1.GetListeGardeAsync
            Return MyBase.Channel.GetListeGardeAsync
        End Function
        
        Public Function GetDataUsingDataContractAsync(ByVal composite As ServiceReference1.CompositeType) As System.Threading.Tasks.Task(Of ServiceReference1.CompositeType) Implements ServiceReference1.IService1.GetDataUsingDataContractAsync
            Return MyBase.Channel.GetDataUsingDataContractAsync(composite)
        End Function
        
        Public Overridable Function OpenAsync() As System.Threading.Tasks.Task
            Return System.Threading.Tasks.Task.Factory.FromAsync(CType(Me,System.ServiceModel.ICommunicationObject).BeginOpen(Nothing, Nothing), AddressOf CType(Me,System.ServiceModel.ICommunicationObject).EndOpen)
        End Function
        
        Public Overridable Function CloseAsync() As System.Threading.Tasks.Task
            Return System.Threading.Tasks.Task.Factory.FromAsync(CType(Me,System.ServiceModel.ICommunicationObject).BeginClose(Nothing, Nothing), AddressOf CType(Me,System.ServiceModel.ICommunicationObject).EndClose)
        End Function
        
        Private Shared Function GetBindingForEndpoint(ByVal endpointConfiguration As EndpointConfiguration) As System.ServiceModel.Channels.Binding
            If (endpointConfiguration = EndpointConfiguration.BasicHttpBinding_IService1) Then
                Dim result As System.ServiceModel.BasicHttpBinding = New System.ServiceModel.BasicHttpBinding()
                result.MaxBufferSize = Integer.MaxValue
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max
                result.MaxReceivedMessageSize = Integer.MaxValue
                result.AllowCookies = true
                Return result
            End If
            If (endpointConfiguration = EndpointConfiguration.BasicHttpsBinding_IService1) Then
                Dim result As System.ServiceModel.BasicHttpBinding = New System.ServiceModel.BasicHttpBinding()
                result.MaxBufferSize = Integer.MaxValue
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max
                result.MaxReceivedMessageSize = Integer.MaxValue
                result.AllowCookies = true
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport
                Return result
            End If
            Throw New System.InvalidOperationException(String.Format("Could not find endpoint with name '{0}'.", endpointConfiguration))
        End Function
        
        Private Shared Function GetEndpointAddress(ByVal endpointConfiguration As EndpointConfiguration) As System.ServiceModel.EndpointAddress
            If (endpointConfiguration = EndpointConfiguration.BasicHttpBinding_IService1) Then
                Return New System.ServiceModel.EndpointAddress("http://bell-sebas.bellgaz.qc.ca/StageGarde/Service1.svc")
            End If
            If (endpointConfiguration = EndpointConfiguration.BasicHttpsBinding_IService1) Then
                Return New System.ServiceModel.EndpointAddress("https://bell-sebas.bellgaz.qc.ca/StageGarde/Service1.svc")
            End If
            Throw New System.InvalidOperationException(String.Format("Could not find endpoint with name '{0}'.", endpointConfiguration))
        End Function
        
        Public Enum EndpointConfiguration
            
            BasicHttpBinding_IService1
            
            BasicHttpsBinding_IService1
        End Enum
    End Class
End Namespace
