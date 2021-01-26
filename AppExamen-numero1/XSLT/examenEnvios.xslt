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
          <caption/>
          <tr>
            <th>Agencia</th>
            <th>Cliente</th>
          </tr>

          <tr>
            <td>
              <xsl:value-of select="//raiz/agenciaaduanal" />
            </td>

            <td>
              <xsl:value-of select="//raiz/cliente" />
            </td>
          </tr>

        </table>


        <table class="estilo_table"  width="100%">
          <caption>
            <h3>Factura</h3>
          </caption>
          <tr>
            <th>Descripcion</th>
			  <th>Tipo</th>
            <th>Costo</th>
          </tr>


          <xsl:for-each select="//items/item">
            <tr>
              <td>
                <xsl:value-of select="descripcion" />
              </td>

              <td>
                <xsl:value-of select="tipo" />
              </td>
              <td>
                <xsl:value-of select="costo" />
              </td>
            </tr>
          </xsl:for-each>
        </table>
        <br/>
        <table class="estilo_table"  width="100%">
          <tr>
            <td>
              Monto Total <xsl:value-of select="sum(//costo)" />
            </td>
          </tr>
        </table>

      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>