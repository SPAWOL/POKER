<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">



      
    
    

    <title>POKER</title>
    <meta charset="utf-8"/>
    <link href="css/bootstrap.min.css" rel="stylesheet" type="text/css" />
   <link href="css/menu.css" rel="stylesheet" type="text/css" />
       <style type="text/css">
        .auto-style1 {
            width: 77px;
        }
    </style>
</head>
<body> 

    <header>
        <hgroup>
            <h2>POKER</h2>
            <h3>Bem vindo</h3>
            </hgroup>

   <nav id="menu">
    <ul>
        <li><a href="#">HOME</a></li>
        <li><a href="#">POKER</a></li>
       
       
    </ul>
</nav>


       </header>

    <main >
        <table border ="2" align="center">
        <tr><th>
     <b> JOGADOR:  CASH:</b><br><p>

            

        <asp:Label ID="Label1" runat="server" Text="Resultado: "></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="Resultado: "></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="Resultado: "></asp:Label>
           
               
        <form id="CpuId" runat="server">
            <div>

                <table><tr>
                    <th>1</th>
                    <th>2</th>
                    <th>3</th>
                    <th>4</th>
                    <th>5</th>
                    </tr>
                    <tr>
                        
              <td> <asp:Image ID="Image1" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" />  </td>
                       
                        
              <td>  <asp:Image ID="Image2" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
              <td> <asp:Image ID="Image3" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
              <td>  <asp:Image ID="Image4" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
              <td> <asp:Image ID="Image5" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
              </tr>      </table>
                </div>
            

            

            
    <div>    


        <asp:Button ID="BComparar" runat="server" Text="Comparar" Height="40px" OnClick="BComparar_Click" BackColor="#3366FF" BorderColor="#000066" CssClass="align-content-lg-center"/><br>

       

       


            </div>
   

        
            <div>
               <b> CPU: CASH</b><br><p>
                   
     <asp:Label ID="ResultadoID" runat="server" Text="Resultado: "></asp:Label>
        <asp:Label ID="ResultadoID2" runat="server" Text="Resultado: "></asp:Label>
        <asp:Label ID="ResultadoID3" runat="server" Text="Resultado: "></asp:Label>
                <table><tr>
                    <th class="auto-style1">1</th>
                    <th>2</th>
                    <th>3</th>
                    <th>4</th>
                    <th>5</th>
                    </tr>
                    <tr>
                

                         
                <td><asp:Image ID="Image6" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
                <td> <asp:Image ID="Image7" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
                <td><asp:Image ID="Image8" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
                <td><asp:Image ID="Image9" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
                <td><asp:Image ID="Image10" runat="server" Height="111px" Width="77px" ImageUrl="~/img/global-poker-ic.png" /></td>
           </tr>
                    </table>





                </div>
            </form>
         </tr>
            </table>
        </main>

    <footer>
        
        <p><p>
                <p>André Costa da Silva</p>
        </footer>
</body>
</html>
