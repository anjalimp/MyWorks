<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConvertNumberApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">  
    <div class="row">
        <div class ="form-horizontal">
            <div class="form-group row">
                <label class="control-label col-md-1">UserName:</label>
                <div class="col-md-4">
                    <input type="text" class="form-control" id="txtUserName" placeholder="Enter your name" />
                </div>
            </div>
            <div class="form-group row">
                <label class="control-label col-md-1">Number:</label>
                <div class="col-md-4">
                    <input type="text" class="form-control" id="txtNumber" placeholder="Enter number" />
                </div>
            </div>
            <div class="form-group row">               
                <div class="col-md-2">
                    <button type="submit" class="btn btn-default pull-right" id="btnSubmit" onclick ="btnSubmit_Click"">Submit</button>
                </div>
            </div>                 
        </div>
        </div>

</asp:Content>
