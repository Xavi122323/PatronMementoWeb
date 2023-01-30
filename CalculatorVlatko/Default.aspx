
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Text="CALCULATOR"></asp:Label>
    
        <br />
        <br />
       
        <asp:Table ID="Table1" runat="server" CellPadding="5" GridLines="horizontal" HorizontalAlign=Left>
        <asp:TableRow>     
        <asp:TableCell> <asp:TextBox ID="txtDisplej" runat="server" Width="400px"></asp:TextBox></asp:TableCell>
        <asp:TableCell> <asp:Label ID="lblMemory" runat="server" Text=""></asp:Label></asp:TableCell>
        <asp:TableCell> <asp:Label ID="lblsnimka" runat="server" Text=""></asp:Label></asp:TableCell>
         </asp:TableRow>
  </asp:Table>
  
        <br />
   <br />
        <br />
        <asp:Table runat="server" CellPadding="5" GridLines="horizontal" HorizontalAlign=Left>
       
   <asp:TableRow>
   <asp:TableCell>  <asp:Button ID="btnmemoryClear" runat="server" Text="MC" Width="60px" onclick="MemoryOpButtons"  /> </asp:TableCell>   
     <asp:TableCell><asp:Button ID="btnmemoryrecall" runat="server" Text="MR" Width="60px" onclick="MemoryOpButtons"  /> </asp:TableCell>
       <asp:TableCell><asp:Button ID="btnmemorystore" runat="server" Text="MS" Width="60px" onclick="MemoryOpButtons"  /> </asp:TableCell> 
     <asp:TableCell>  <asp:Button ID="btnmemoryadd" runat="server" Text="M+" Width="60px" onclick="MemoryOpButtons"  /> </asp:TableCell> 
         <asp:TableCell><asp:Button ID="btnmemorysubstract" runat="server" Text="M-" Width="60px" onclick="MemoryOpButtons"  /> </asp:TableCell>
     
     <asp:TableCell>  <asp:Button ID="btnclear" runat="server" Text="C" Width="60px" onclick="Clear_Displej" /> </asp:TableCell> 
     
    
   </asp:TableRow>
   <asp:TableRow>
     <asp:TableCell>  <asp:Button ID="btn7" runat="server" Text="7" Width="60px" onclick="Number_Btn_Click" /> </asp:TableCell>
     <asp:TableCell><asp:Button ID="btn8" runat="server" Text="8" Width="60px" onclick="Number_Btn_Click" /> </asp:TableCell>
     <asp:TableCell><asp:Button ID="btn9" runat="server" Text="9" Width="60px" onclick="Number_Btn_Click"/></asp:TableCell>
     <asp:TableCell><asp:Button ID="btndelenje" runat="server" Text="/" Width="60px" onclick="Znak_BtnClick" /></asp:TableCell>
     <asp:TableCell><asp:Button ID="btnUndo" runat="server" Text="Undo" Width="60px" onclick="Undo"/></asp:TableCell>
    
   </asp:TableRow>
    <asp:TableRow>
     <asp:TableCell><asp:Button ID="btn4" runat="server" Text="4" Width="60px" onclick="Number_Btn_Click" /></asp:TableCell>
     <asp:TableCell><asp:Button ID="btn5" runat="server" Text="5" Width="60px" onclick="Number_Btn_Click"/></asp:TableCell>
     <asp:TableCell><asp:Button ID="btn6" runat="server" Text="6" Width="60px" onclick="Number_Btn_Click"/></asp:TableCell>
     <asp:TableCell><asp:Button ID="btnmnozenje" runat="server" Text="*" Width="60px" onclick="Znak_BtnClick"/></asp:TableCell>
     <asp:TableCell><asp:Button ID="btnRedo" runat="server" Text="Redo" Width="60px" onclick="Redo"/></asp:TableCell>
    
   </asp:TableRow>
    <asp:TableRow>
     <asp:TableCell><asp:Button ID="btn1" runat="server" Text="1" Width="60px" onclick="Number_Btn_Click"/></asp:TableCell>
     <asp:TableCell><asp:Button ID="btn2" runat="server" Text="2" Width="60px" onclick="Number_Btn_Click"/></asp:TableCell>
     <asp:TableCell><asp:Button ID="btn3" runat="server" Text="3" Width="60px" onclick="Number_Btn_Click"/></asp:TableCell>
     <asp:TableCell><asp:Button ID="btnodzemanje" runat="server" Text="-" Width="60px" onclick="Znak_BtnClick"/></asp:TableCell>
     <asp:TableCell></asp:TableCell>
    
   </asp:TableRow>
    <asp:TableRow>
     <asp:TableCell><asp:Button ID="btn0" runat="server" Text="0" Width="60px" onclick="Number_Btn_Click"/></asp:TableCell>
     <asp:TableCell></asp:TableCell>
         <asp:TableCell> <asp:Button ID="btntocka" runat="server" Text="." Width="60px" onclick="Number_Btn_Click"/> </asp:TableCell>
     <asp:TableCell>  <asp:Button ID="btnsobiranje" runat="server" Text="+" Width="60px" onclick="Znak_BtnClick" /></asp:TableCell>
     
    
   </asp:TableRow>
    <asp:TableRow>
     
     <asp:TableCell><asp:Button ID="btnednakvo" runat="server" Height="60px" Text="="  Width="80px" onclick="Ednakvo_Btn_Click" /></asp:TableCell>
     <asp:TableCell></asp:TableCell>
     <asp:TableCell><asp:Button ID="btnRCL" runat="server" Height="60px" Text="RCL"  Width="80px" onclick="IzvrsiPrograma" /></asp:TableCell>
      <asp:TableCell><asp:Button ID="btnTapeonof" runat="server" Height="100px" Text="LentaON/OFF"  Width="80px" onclick="LentaONOFF" /></asp:TableCell>
    
   </asp:TableRow>
    <asp:TableRow>
     <asp:TableCell></asp:TableCell>
     <asp:TableCell> Vlatko</asp:TableCell>
     <asp:TableCell> Kochoski</asp:TableCell>
     <asp:TableCell></asp:TableCell>
     <asp:TableCell></asp:TableCell>
    
   </asp:TableRow>
</asp:Table>
<br>
        
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:ListBox 
            ID="listboxLenta" runat="server" 
            Height="306px" Width="365px">
        </asp:ListBox>
       
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
      

        
&nbsp;&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        <br />
        
&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        <br />
        
&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
        <br />
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>
