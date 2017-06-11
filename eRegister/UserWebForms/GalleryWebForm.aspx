<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPages/ProfileMasterPage.Master" AutoEventWireup="true" CodeBehind="GalleryWebForm.aspx.cs" Inherits="eRegister.UserWebForms.GalleryWebForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
    <div class="col-md-9">
        <div id="title" class="col-md-8" style="text-align: left">
            <h3>Галерия</h3>
        </div>
        <div class="col-md-4" style="text-align: right">
            <h3 style="text-align: left" id="lblHeader" runat="server">Качване на снимки</h3>
        </div>
               <asp:FileUpload ID="FileUpload1" Visible="true" runat="server"/>
                        <asp:Button ID="btnUpload" Visible="true" runat="server" Text="Качи" OnClick="Upload" />
                        <hr />
                        <div class="row">
                           <div class="col-md-3">
                                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" ShowHeader="false" CssClass="Grid">
                                    <Columns>                               
                                        <asp:ImageField DataImageUrlField="Value" ControlStyle-Height="200" ControlStyle-Width="180"/>                                      
                                    </Columns>
                                </asp:GridView>
                               
                            </div>
                        </div>
		</div>
</asp:Content>

