using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EjemploInterfaces
{
    public partial class frmInterfaces : Form
    {
        
        public frmInterfaces()
        {
            InitializeComponent();
            TransferirACuentaCorriente = true;
        }

        bool TransferirACuentaCorriente;

        private void frmInterfaces_Load(object sender, EventArgs e)
        {
            ITransferenciaBancaria[] cuentas = new ITransferenciaBancaria[2];

            cuentas[0] = new CuentaAhorros();
            cuentas[1] = new CuentaCorriente();                      

            cmbCuentas.DataSource = cuentas;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ICuentaBancaria cuenta = cmbCuentas.SelectedItem as ICuentaBancaria;
            if (cuenta != null)
            {
                if (cuenta.GetType() == typeof(CuentaAhorros))
                    lbCuentasAhorros.Items.Add(cuenta);
                else
                    lbCuentasCorrientes.Items.Add(cuenta);
            }
        }

        private void lbCuentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarBalance();
        }

        private void lbCuentasCorrientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefrescarBalance();
        }

        private void RefrescarBalance()
        {
            txtSaldoAhorro.Clear();
            txtSaldoCorriente.Clear();

            ICuentaBancaria cuenta = lbCuentasAhorros.SelectedItem as ICuentaBancaria;
            if (cuenta != null)
            {
                txtSaldoAhorro.Text = cuenta.Saldo.ToString("C");
            }

            ICuentaBancaria corriente = lbCuentasCorrientes.SelectedItem as ICuentaBancaria;
            if (corriente != null)
            {
                txtSaldoCorriente.Text = corriente.Saldo.ToString("C");
            }
        }

        private void btnAplicar_Click(object sender, EventArgs e)
        {
            try
            {
                decimal monto = 0;

                if (Decimal.TryParse(txtMonto.Text, out monto))
                {
                    ICuentaBancaria cuenta = lbCuentasAhorros.SelectedItem as ICuentaBancaria;

                    if (cuenta != null)
                    {
                        if (radioIngreso.Checked)
                        {
                            cuenta.Deposito(monto);
                        }
                        if (radioEgreso.Checked)
                        {
                            cuenta.Retiro(monto);
                        }                        
                    }

                    cuenta = lbCuentasCorrientes.SelectedItem as ICuentaBancaria;

                    if (cuenta != null)
                    {
                        if (radioIngreso.Checked)
                        {
                            cuenta.Deposito(monto);
                        }
                        if (radioEgreso.Checked)
                        {
                            cuenta.Retiro(monto);
                        }                       
                    }

                    if (radioTransferencia.Checked)
                    {
                        Transferir(monto);
                    }
                }
                else
                {
                    MessageBox.Show("El valor ingresado es incorrecto");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                txtMonto.Clear();
                RefrescarBalance();
            }
        }

        private void Transferir(decimal monto)
        {
            ITransferenciaBancaria destino = null;
            ITransferenciaBancaria origen = null;

            if (TransferirACuentaCorriente)
            {
                destino = lbCuentasCorrientes.SelectedItem as ITransferenciaBancaria;
                origen = lbCuentasAhorros.SelectedItem as ITransferenciaBancaria;
            }
            else
            {
                destino = lbCuentasAhorros.SelectedItem as ITransferenciaBancaria;
                origen = lbCuentasCorrientes.SelectedItem as ITransferenciaBancaria;
            }
           
            AplicarTransferencia(origen, destino, monto);
        }

        private void AplicarTransferencia(ITransferenciaBancaria origen, ICuentaBancaria destino, decimal monto)
        {
            try
            {                                
                origen.TransferirA(destino, monto);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      

        private void btnDesSelecAhorros_Click(object sender, EventArgs e)
        {
            lbCuentasAhorros.SelectedIndex = -1;
        }

        private void btnDesSelecCorriente_Click(object sender, EventArgs e)
        {
            lbCuentasCorrientes.SelectedIndex = -1;
        }

        private void btnSentidoTrans_Click(object sender, EventArgs e)
        {
            TransferirACuentaCorriente = !TransferirACuentaCorriente;

            if (TransferirACuentaCorriente)
            {
                btnSentidoTrans.Text = "Transferir a Cuenta Corriente >>";
            }
            else
            {
                btnSentidoTrans.Text = "<< Transferir a Cuenta de Ahorros";                
            }
        }

        
    }
}
