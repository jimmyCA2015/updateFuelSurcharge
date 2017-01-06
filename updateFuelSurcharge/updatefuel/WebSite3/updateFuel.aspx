<%@ Page Language="C#" AutoEventWireup="true" CodeFile="updateFuel.aspx.cs" Inherits="JIMMY" %>

<!DOCTYPE html>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Rogue Specialty Transportation</title>
    
</head>
<body>
       
    

<fieldset style="background-color:lightgreen"> 
   <asp:image ID="Image1" ImageUrl="logo.jpg"  runat="server" width="40%" Height="200px" />

<h1 style="text-align:center;position:relative;left:200px;top:-160px;font-size:60px">Fuel Surchage Update</h1><br /><fieldset style="border-color:red;position:relative;top:-150px;"><h2 style="color:red">This form will perfect our update of fuel surcharge rates in the courier complete DB. Please use with caution. If you have any questions,please contact the IT Department</h2></fieldset>
 <br /><br />


 <form id="Form1" runat="server">
   
     <fieldset id="Fieldset1" style="border-color:black;background-color:lightyellow;height:70px;position:relative;top:-160px;" runat="server">
     Date Today:<asp:TextBox ID="txtDateTime"  Text="" runat="server" style="position:absolute;left:200px;color:#0000FF" ReadOnly="true" enabled="false"/>  
        <br > <br/> 
        
            
       
        <label style="position:absolute;left:18px;">Last updated date: </label><asp:TextBox ID="txtDateTime2"  Text="" runat="server" style="position:absolute;left:200px;color:blue" ReadOnly="true"  disabled="true"/>  
     </fieldset>
     <fieldset id="Fieldset2" style="position:relative;top:-150px;border:hidden;font-size:20px">
     <br /><br />
    <asp:RadioButton ID="noupdate" GroupName="updateoption" runat="server" Text="Test Fuel Surcharge Update" checked="true" OnCheckedChanged="noupdate_CheckedChanged" autopostback="true" />
     <br /><br />
    <asp:RadioButton ID="yesupdate" GroupName="updateoption" runat="server" Text="Perform Update" OnCheckedChanged="yesupdate_CheckedChanged" autopostback="true" />
     <br />
     <br />

 

 Standard Rate:
 <asp:TextBox id="rate1"  Text="13.9" runat="server" style="position:absolute;left:200px;"/>
 <br /><br />

Preferred Rate:
 
 <asp:TextBox id="rate2" Text="11.4" runat="server" style="position:absolute;left:200px;" />
 <br /><br />

 Cardinal Rate:
 <asp:TextBox id="rate3"  Text="8.2" runat="server" style="position:absolute;left:200px;" />
 <br /><br />

Fisher Rate:
 <asp:TextBox id="rate4" Text="8.0" runat="server" style="position:absolute;left:200px;" />
 <br /><br />

 UPS Rate:
 <asp:TextBox id="rate5"  Text="12.8" runat="server" style="position:absolute;left:200px;"/>
 <br /><br />

 Stryker Rate:
 <asp:TextBox id="rate6" Text="5.9" runat="server" style="position:absolute;left:200px;" />
<br /><br />

 Geodis Rate:
 <asp:TextBox id="rate7"  Text="29.3" runat="server" style="position:absolute;left:200px;" />
 <br /><br />


 OLG Rate:
 <asp:TextBox id="rate8" Text="9.1" runat="server" style="position:absolute;left:200px;" />
 <br /><br />

 
<asp:Button ID="magic" runat="server" Text="Test" OnClick="magic_Click"  style="font-size:30px" autopostback="true"/>
     <ASP:DataGrid id="MyDataGrid" runat="server"
      Width="700"
      BackColor="#ccccff" 
      BorderColor="black"
      ShowFooter="false" 
      CellPadding="3"
      CellSpacing="0"
      Font-Name="Verdana"
      Font-Size="8pt"
      HeaderStyle-BackColor="#aaaadd"
      EnableViewState="true"
      style="position:relative;left:500px;top:-500px"
      
   />
 </fieldset>
    

 </form>
    </fieldset>
    <br /><br />
  

</body>
</html>
