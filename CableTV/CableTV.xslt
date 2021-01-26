<xsl:stylesheet version="1.0"
xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

  <xsl:template match="/">
    <html>
      <body>
        <h2>Cotización CableTV</h2>
        <table>

          <xsl:for-each select="CableTV/Proveedor">

            <tr bgcolor="#660000">
              <th colspan="2" style="color: #fff;">
                <xsl:value-of select="./@Nombre"/>
              </th>
            </tr>

            <tr bgcolor="#990000">
              <th colspan="2" style="color: #fff;">
                <xsl:value-of select="./Paquete/@Descripcion"/>
              </th>
            </tr>

            <tr>
              <td>
                <b>Cantidad TV:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Cliente/@CantidadTV"/>
              </td>
            </tr>

            <tr bgcolor="#FF6666">
              <th colspan="2">Cliente</th>
            </tr>            
            <tr>
              <td>
                <b>Identificacion:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Cliente/@Identificacion"/>
              </td>
            </tr>
            <tr>
              <td>
                <b>Nombre:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Cliente/@Nombre"/>
              </td>
            </tr>
            <tr>
              <td>
                <b>Nacimiento:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Cliente/@FechaNacimiento"/>
              </td>
            </tr>

            <tr bgcolor="#FF6666">
              <th colspan="2">Zona</th>
            </tr>
            <tr>
              <td>
                <b>Nombre:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Zona"/>
              </td>
            </tr>
            <tr>
              <td>
                <b>Precio TV:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Zona/@PrecioTV"/>
              </td>
            </tr>

            <tr bgcolor="#FF6666">
              <th colspan="2">Adicionales</th>
            </tr>
            <!--<xsl:for-each select="./Adicionales/Adicional">
              <tr>
                <td colspan="2" style="text-align: center;">
                  <xsl:value-of select="."/>
                </td>
              </tr>
            </xsl:for-each>-->
            <tr>
              <td colspan="2">
                <xsl:for-each select="./Adicionales/Adicional">
                  <xsl:value-of select="."/>
                  <xsl:if test="position() != last()">
                    <xsl:text>, </xsl:text>
                  </xsl:if>
                </xsl:for-each>
              </td>
            </tr>

            <tr bgcolor="#FF6666">
              <th colspan="2">Total</th>
            </tr>
            <tr>
              <td>
                <b>Descuentos:</b>
              </td>
              <td colspan="2">
                <xsl:value-of select="./Total/@Descuentos"/>
              </td>
            </tr>
            <tr>
              <td>
                <b>Total:</b>
              </td>
              <td colspan="2">
                <b><xsl:value-of select="./Total"/></b>
              </td>
            </tr>

          </xsl:for-each>

        </table>
      </body>
    </html>
  </xsl:template>

</xsl:stylesheet>
