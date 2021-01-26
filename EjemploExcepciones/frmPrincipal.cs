using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;

namespace EjemploExcepciones
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //DIVIDIR
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(textBox1.Text);
                int y = int.Parse(textBox2.Text);

                int z = x / y;
                textBox3.Text = z.ToString();
            }            
            catch (DivideByZeroException) // error al dividir entre cero
            {
                MessageBox.Show("No se puede dividir por cero (0)");
            }
            catch(FormatException) // error al convertir un caracter en integer
            {
                MessageBox.Show("Debe ingresar dos NUMEROS");
            }
            catch (Exception ex) // cualquier otro error
            {
                MessageBox.Show(ex.Message);                
            }
        }

        //LANZAR
        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationException ex = new ApplicationException("Error lanzado para pruebas");
            ex.Data.Add("Dato1", "Error en evento del Boton 2");
            ex.HelpLink = "www.help.com";
            ex.Source = "Evento Boton 2";
            

            throw ex;
        }

        //MULTIPLES
        private void button3_Click(object sender, EventArgs e)
        {
            this.Multiples();
        }

        private void Multiples()
        {
            try
            {
                // FORZANDO QUE LANCE UNA EXCEPCION
                if (radioNull.Checked)
                    throw new NullReferenceException("Referencia NULA");
                if (radioField.Checked)
                    // CONSTRUIMOS EXCEPCION PERSOANLIZADA
                    throw new FieldAccessException("Acceso a un ATRIBUTO");
                if (radioArgumento.Checked)
                    //EXCEPCION PERSONALIZADA
                    throw new ArgumentException("ARGUMENTO");
                //EXCEPCION POIR DEFECTO
                //throw new ArgumentException();
                if (radioEx.Checked)
                    throw new Exception("GENERICA");
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (FieldAccessException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }           
        }

        // RELOJ DE ARENA
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // cambiar el cursor por el reloj de arena
                this.Cursor = Cursors.WaitCursor;                

                // esperar 2 segundos para ver el cursor ocupado
                System.Threading.Thread.Sleep(2000);
                // simular el error
                if (lanzarEx.Checked)
                    throw new ApplicationException("ERROR");

                // si se cambia el cursor aqui cuando exista un error
                // no se actualiza el estado porque brinca al catch
                //this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                try
                {
                    try
                    {
                        throw new ApplicationException("Primer error");
                    }
                    catch (Exception)
                    {
                        if (checkPrimero.Checked)
                            throw;
                        else
                            throw new NullReferenceException("Segundo error");
                    }
                }
                catch (Exception)
                {
                    if (checkPrimero.Checked)
                        throw;
                    else
                        throw new ArgumentException("Tercer error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                this.ValidarNombre(txtNombre.Text);

                MessageBox.Show("OK");
            }
            catch(LongitudNombreException)
            {
                MessageBox.Show("La longitud del nombre debe ser menor a 10");
            }
            catch (Exception)
            {                
                //throw;
            }
        }

        void ValidarNombre(string nombre)
        {
            if (nombre.Length > 10)
                throw new LongitudNombreException();
        }
    }
}
