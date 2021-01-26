<?xml version="1.0" encoding="iso-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:template match="/">
    <html>
      <header>
        <style>
          .estilo_table {

          font-family: Consolas,monaco,monospace;
          border-radius: 15px;
          -moz-border-radius: 15px;
          -webkit-border-radius: 15px;
          border: 1px solid #C0C0C0;

          }
          .estilo_table th {
          border:0px solid #C0C0C0;
          padding:5px;
          background:#F0F0F0;
          border-radius : 20px 15px 10px 5px;
          }
          .estilo_table td {
          border:0px solid #C0C0C0;
          padding:5px;
          border-radius : 20px 15px 10px 5px;

          }
        </style>
      </header>
      <body>

        <table class="estilo_table"  width="100%">
          <tr>
            <th>
              <h3>
                 Snack Machine 2.0 
              </h3>
            </th>
          </tr>
        </table>
      
        <br></br>
        <th>
          <h3>
            Número de factura <xsl:value-of select="//factura/@numerofactura"/>
            <br></br>
            Fecha <xsl:value-of select="//factura/fechafactura"/>  
          </h3>
        </th>
         
        <table class="estilo_table"  width="100%">
          <tr>
            <th>Tipo</th>
            <th>Precio</th>           
          </tr>
          <xsl:for-each select="//factura/detalle/snack">
            <tr>
              <td align="left">
                <xsl:value-of select="tipo" />
              </td>
              <td align="left">
                <xsl:value-of select="format-number(precio, '#.00')" />
              </td>
            </tr>
          </xsl:for-each>

        </table>

        <br></br>
        <h3>
          Total  <xsl:value-of select="sum(//factura/detalle/snack/precio)" />
        </h3>

        <h2>
        <marquee>Gracias por su compra </marquee>
        
        </h2>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>
