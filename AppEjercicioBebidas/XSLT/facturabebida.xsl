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
      <body bgcolor="white">
        <h1>
			<center> Facturación </center>
			FECHA <xsl:value-of select="//encabezado/@fecha" /> <br/>
        </h1>
		  <table class="estilo_table"  width="100%">
          <tr bgcolor="Purple">
			  <h3>
            <th align="center">Producto</th>
			 </h3>
          </tr>
          <xsl:for-each select="//factura/ingredientes">
            <tr>
              <td>
                <xsl:value-of select="ingrediente"/>
              </td>
            </tr>
          </xsl:for-each>
        </table>
        <br/>
        <h2>
          Calorias <xsl:value-of select="//encabezado/calorias" /> <br/>
          Impuesto <xsl:value-of select="//encabezado/costo/@impuesto"/><br/>
          Costo <xsl:value-of select="//encabezado/costo" /> <br/>
        </h2>

      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>