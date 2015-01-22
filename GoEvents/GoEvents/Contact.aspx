<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="GoEvents.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>If you have any questiosn, pls contact us</h3>
    <address>
        123 Marietta way<br />
        Marietta, GA 30080<br />
        <abbr title="Phone">P:</abbr>
        123.456.7890
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:admin@goevents.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@goevents.com">Marketing@example.com</a>
    </address>
</asp:Content>
