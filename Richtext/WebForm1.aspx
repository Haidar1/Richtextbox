<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="WebForm1.aspx.vb" Inherits="Richtext.WebForm1" %>

<%@ Register Assembly="FreeTextBox" Namespace="FreeTextBoxControls" TagPrefix="FTB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <script src="ckeditor/ckeditor.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:TextBox runat ="server" ID="text" TextMode="MultiLine" Height="290px" Width="621px"></asp:TextBox>
        <!-- Import textArea Modification-->
        <script>
            CKEDITOR.replace("text");
        </script>
    </div>
        <div>


            <asp:Button ID="Button1" runat="server" Text="Save" />
&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Read" />
            <asp:Button ID="Button3" runat="server" Text="Button" />
        <asp:Button ID="Button4" runat="server" Text="Button" />
            <br />
            <br />


        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
