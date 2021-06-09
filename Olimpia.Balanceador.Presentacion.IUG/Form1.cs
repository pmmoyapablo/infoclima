//PRUEBA OLIMPIA
//La función de la aplicación actual es calcular el saldo final de las cuentas de un "banco", para esto se consume un servicio que devuelve 
//las transacciones realizas a la cuentas.

//Paso 1: Hacer funcionar la aplicación. Debido al aumento de transacciones y al  colocar al servicio con SSL la aplicación actual esta fallando.
//Paso 2: Estructurar mejor el codigo. Uso de patrones, buenas practicas, etc.
//Paso 3: Optimizar el codigo, como se menciono en el paso 1 el aumento de transacciones ha causado que el calculo de los saldos se demore demasiado.
//Paso 4: Adicionar una barra de progreso al formulario. Actualizar la barra con el progreso del proceso, evitando bloqueos del GUI.


using System;
using System.Windows.Forms;
using Olimpia.Balanceador.Transversal.Inyeccion;
using Olimpia.Balanceador.Dominio.Core;
using Olimpia.Balanceador.Dominio.Interface;
using Olimpia.Balanceador.Servicio.ClienteSoap;
using Olimpia.Balanceador.Servicio.Interface;
using Olimpia.Balanceador.Aplicacion.Interface;
using Olimpia.Balanceador.Aplicacion.Main;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace WindowsLiderEntrega
{
    public partial class Form1 : Form
    {
        private bool Result;
        private string Message;
        private long TimeTotal;
        private int Increment = 1;
        public Form1()
        {
            InitializeComponent();          
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
          progressBar1.Maximum = 100;
          progressBar1.Step = 1;
          progressBar1.Value = 20;

          ProcesarCalculo();
             
        }
        private void Form1_Load(object sender, EventArgs e)
        {
          Injector.Clear();
          Injector.Map<IConfiguration, AppConfiguration>();
          Injector.Map<IClienteBalance, ClienteBalance>();
          Injector.Map<IBalanceDomain, BalanceDomain>();
          Injector.Map<IBalanceAplicacion, BalanceAplicacion>();
     
          //Injector.Map<IAppLogger<BalanceAplicacion>, LoggerAdapter<BalanceAplicacion>>();
        }

        private async void ProcesarCalculo()
        {    
          var application = Injector.Get<IBalanceAplicacion>();
          var response = await application.CalcularBalance();

          Result = response.IsSuccess;
          Message = response.Messange;
  
          if (Result)
          {
            Increment = 100;
            progressBar1.Value = Increment;
            dataGridView1.DataSource = response.Data.CuentasBancarias;
            lblCantCtas.Text = dataGridView1.Rows.Count.ToString();
            TimeTotal = response.Data.TiempoTotal;
            lblTiempoTotal.Text = TimeTotal.ToString();
          }else
           {
             progressBar1.Value = 0;
           }
        
           if (Result)
              {
                MessageBox.Show(Message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              }
           else
              {
                MessageBox.Show(Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }
            
        }
  }
}