' Pour en savoir plus sur le modèle d'élément Page vierge, consultez la page http://go.microsoft.com/fwlink/?LinkId=234238

''' <summary>
''' Une page vide peut être utilisée seule ou constituer une page de destination au sein d'un frame.
''' </summary>
Public NotInheritable Class MainPage
    Inherits Page
    Dim ListClient As List(Of List(Of Object)) = Nothing

    Private Async Sub Button_Click(sender As Object, e As RoutedEventArgs)
        Dim service As New ServiceReference1.Service1Client(ServiceReference1.Service1Client.EndpointConfiguration.BasicHttpBinding_IService1)
        Try
            ServReturnValue.Text = Await service.GetDataAsync(CInt(txtVAlueEnter.Text))
        Catch ex As Exception
            ServReturnValue.Text = ex.Message
            If Not ex.InnerException.Message Is Nothing Then
                ServReturnValue.Text = ServReturnValue.Text + ex.InnerException.Message
            End If
        End Try

        Dim TableClient As String = ""

        Try
            TableClient = Await service.GetListeGardeAsync()
            ListClient = DeserializeList(TableClient)
        Catch ex As Exception

        End Try

    End Sub

    Private Function DeserializeList(ByVal SerList As String) As List(Of List(Of Object))
        Dim x As New Xml.Serialization.XmlSerializer(GetType(List(Of List(Of Object))))
        Dim sr As New IO.StringReader(SerList)
        Dim Obj As List(Of List(Of Object)) = CType(x.Deserialize(sr), List(Of List(Of Object)))
        Return Obj
    End Function

End Class
