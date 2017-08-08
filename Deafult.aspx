<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deafult.aspx.cs" Inherits="Jsreporter.Deafult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div>
                <section>
                    Choose which sections must be included in the Report
                </section>
                <section>
                    <table style="border:thin">
                        <tr style="border:thin">
                            <td style="border:thin">Asset Meta Data</td>
                            <td style="border:thin">
                                Rule Base
                            </td>
                            <td style="border: thin">Rule Review
                            </td>
                            <td style="border: thin">Shadow, Redundant and Groupable Rules
                            </td>
                            <td style="border: thin">
                                Unused Objects
                            </td>
                            <td style="border: thin">Insecure Rules
                            </td>
                            <td style="border: thin">Critical Ports
                            </td>
                            <td style="border: thin">Compliance
                            </td>
                            <td style="border: thin">Calculated Overall Risk Score
                            </td>
                        </tr>
                        <tr>
                            <td style="border: thin">
                                <asp:CheckBox runat="server" ID="chbk1" /></td>
                            <td style="border: thin">
                                <asp:CheckBox runat="server" ID="CheckBox1" /></td>
                            <td style="border: thin">
                                <asp:CheckBox runat="server" ID="CheckBox2" /></td>
                            <td style="border: thin">
                                <asp:CheckBox runat="server" ID="CheckBox3" /></td>
                            <td style="border:thin">
                                <asp:CheckBox runat="server" ID="CheckBox4" /></td>
                            <td style="border: thin">
                                <asp:CheckBox runat="server" ID="CheckBox5" /></td>
                            <td style="border: thin">
                                <asp:CheckBox runat="server" ID="CheckBox6" /></td>
                            <td style="border: thin">
                                <asp:CheckBox runat="server" ID="CheckBox7" /></td>
                            <td style="border: thin">
                                <asp:CheckBox runat="server" ID="CheckBox8" /></td>
                        </tr>
                    </table>
                </section>
            </div>
        </div>
        <br/>
        <div>
            <asp:Button ID="Button1" runat="server" Text="Generate Audit Report" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
