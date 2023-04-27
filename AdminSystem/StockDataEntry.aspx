<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 2px;
        }
    </style>
</head>
<body style="height: 518px">
    <form id="form1" runat="server">
        <p>
            <asp:TextBox ID="txtGameNo" runat="server" style="z-index: 1; left: 195px; top: 29px; position: absolute"></asp:TextBox>
        </p>
        <asp:Label ID="lblGameNo" runat="server" style="z-index: 1; left: 23px; top: 27px; position: absolute" Text="Game Number" width="144px"></asp:Label>
        <asp:Label ID="lblGameName" runat="server" style="z-index: 1; left: 28px; top: 75px; position: absolute" Text="Game Name" width="144px"></asp:Label>
        <asp:Label ID="lblGameDescription" runat="server" style="z-index: 1; left: 24px; top: 123px; position: absolute" Text="Game Description"></asp:Label>
        <asp:TextBox ID="txtGameDescription" runat="server" style="z-index: 1; left: 193px; top: 123px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblGamePicture" runat="server" style="z-index: 1; left: 31px; top: 178px; position: absolute" Text="GamePicture" width="144px"></asp:Label>
        <asp:TextBox ID="txtGamePicture" runat="server" style="z-index: 1; left: 192px; top: 179px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
        <p>
            <asp:Label ID="lblDateReleased" runat="server" style="z-index: 1; left: 31px; top: 230px; position: absolute; height: 22px; bottom: 315px" Text="Date Released" width="144px"></asp:Label>
        </p>
        <asp:TextBox ID="txtDateReleased" runat="server" style="z-index: 1; left: 192px; top: 231px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 33px; top: 288px; position: absolute" Text="Price" width="144px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 192px; top: 291px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblAvailable" runat="server" style="z-index: 1; left: 30px; top: 348px; position: absolute" Text="Available" width="144px"></asp:Label>
        <asp:TextBox ID="txtAvailable" runat="server" style="z-index: 1; left: 192px; top: 349px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 28px; top: 402px; position: absolute" width="144px"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 32px; top: 457px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 87px; top: 457px; position: absolute" Text="Cancel" />
        <asp:TextBox ID="txtGameName" runat="server" style="z-index: 1; left: 195px; top: 78px; position: absolute"></asp:TextBox>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
