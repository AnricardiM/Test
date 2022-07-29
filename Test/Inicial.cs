using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.Funciones;
using Test.Conexion;
using Test.Model;


namespace Test
{
    public partial class Inicial : Form
    {
        SolicitudFactory aux = new SolicitudFactory();
        Funcion funcion = new Funcion();
        public Inicial()
        {           
            InitializeComponent();
        }

        private void btn_MA_Click(object sender, EventArgs e)
        {
            pl_auto.Visible = true;          
            pl_centro.Visible = false;
            pl_dashboard.Visible = false;
            pl_venta.Visible = false;
            var respuesta=  aux.GetAll("auto");
            var listautos = funcion.ConvertirAuto(respuesta.responseBody);

            dgv_auto.DataSource = listautos;
            dgv_auto.Refresh();
        }

        private void btn_CD_Click(object sender, EventArgs e)
        {
            pl_auto.Visible = false;
            pl_centro.Visible = true;
            pl_dashboard.Visible = false;
            pl_venta.Visible = false;
            var respuesta = aux.GetAll("centro");
            var listcentro = funcion.ConvertirCentro(respuesta.responseBody);
            dgv_centro.DataSource = listcentro;
            dgv_centro.Refresh();
        }

        private void btn_HV_Click(object sender, EventArgs e)
        {
            pl_auto.Visible = false;
            pl_centro.Visible = false;
            pl_dashboard.Visible = false;
            pl_venta.Visible = true;
            var respuesta = aux.GetAll("centro");
            var listcentro = funcion.ConvertirCentro(respuesta.responseBody);

            respuesta = aux.GetAll("auto");
            var listautos = funcion.ConvertirAuto(respuesta.responseBody);

            cbx_centro.DataSource = listcentro;
            cbx_centro.Refresh();

            cbx_auto.DataSource = listautos;
            cbx_auto.Refresh();
        }

        private void Inicial_Load(object sender, EventArgs e)
        {
            pl_auto.Visible = false;
            pl_centro.Visible = false;
            pl_dashboard.Visible = false;
            pl_venta.Visible = false;
        }
            

        private void cbx_auto_Format(object sender, ListControlConvertEventArgs e)
        {
            string valor = ((Auto)e.ListItem).descripcionAuto;
            string index = ((Auto)e.ListItem).idAuto.ToString();
            e.Value = index + " - " + valor;
        }

        private void cbx_centro_Format(object sender, ListControlConvertEventArgs e)
        {
            string valor = ((Centro)e.ListItem).descripcionCentro;
            string index = ((Centro)e.ListItem).idCentro.ToString();
            e.Value = index + " - " + valor;
        }
              

        private void cbx_auto_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;  

            var respuesta = aux.GetAll("auto");
            var listautos = funcion.ConvertirAuto(respuesta.responseBody);

            Auto ComboA  = (Auto)cbx_auto.SelectedValue;
            Auto Automovil = listautos.FirstOrDefault(x => x.idAuto == ComboA.idAuto);
            lbl_IA.Text = "Descripcion: " + Automovil.descripcionAuto + " --  Costo: U$S" + Automovil.costoAuto  ;
        }

        private void cbx_centro_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;

            var respuesta = aux.GetAll("centro");
            var listcentro = funcion.ConvertirCentro(respuesta.responseBody);

            Centro ComboC = (Centro)cbx_centro.SelectedValue;
            Centro Cent = listcentro.FirstOrDefault(x => x.idCentro == ComboC.idCentro);
            lbl_IC.Text = "Descripcion: " + Cent.descripcionCentro; 
            
        }

        private void btn_comprar_Click(object sender, EventArgs e)
        {
            Venta venta = new Venta();

            venta.idAuto = cbx_auto.SelectedIndex;
            venta.idCentro = cbx_centro.SelectedIndex;
            venta.descripcionVenta = tbx_descripcion.Text;
          
            var data = funcion.SerializarVenta(venta);
            var respuesta = aux.Post("venta", data);

            if (respuesta.error == false)
            {
                Lbl_Mensaje.ForeColor = Color.Green;
                Lbl_Mensaje.Text = "Guardado con Exito";
            }
            else {
                Lbl_Mensaje.ForeColor = Color.Red;
                Lbl_Mensaje.Text = respuesta.responseBody;
            }
        }

        private void btn_DB_Click(object sender, EventArgs e)
        {
            try {

                pl_auto.Visible = false;
                pl_centro.Visible = false;
                pl_dashboard.Visible = true;
                pl_venta.Visible = false;
                var respuesta = aux.Count("dashboard");
                var listventa = funcion.ConvertirDashboard(respuesta.responseBody);
                int cantidad = listventa.Count();

                var listcentro = new List<MostrarDatos>();
                var listcentro2 = new List<MostrarDatos>();
                lbl_TV.Text = "Total Importe: U$S" + listventa.Sum(x => x.Monto).ToString();
                lbl_TNV.Text = "Cantidad : " + cantidad.ToString();

                foreach (var item in listventa.GroupBy(x => x.idCentro)) {
                    var md = new MostrarDatos();                   
                    md.Centro = item.FirstOrDefault().CentroDeVenta;
                    md.Importe = "U$S " + item.Sum(x=>x.Monto).ToString();
                    md.Cantidad = item.Count().ToString();
                    md.Porcentaje = (int.Parse(md.Cantidad) * 100 / cantidad).ToString() + "%";

                    listcentro.Add(md);
                }


                foreach (var item in listventa.GroupBy(x => x.idCentro & x.idVehiculo))
                {
                    var md = new MostrarDatos();
                    md.Centro = item.FirstOrDefault().CentroDeVenta;
                    md.Vehiculo = item.FirstOrDefault().Vehiculo;
                    md.Importe = "U$S " + item.Sum(x => x.Monto).ToString();
                    md.Cantidad = item.Count().ToString();
                    md.Porcentaje = (int.Parse(md.Cantidad) * 100 / cantidad).ToString() + "%";

                    listcentro2.Add(md);
                }


                dgv_lcdv.DataSource = listcentro;
                dgv_lcdv.Columns[4].Visible = false;
                dgv_lcdv.Refresh();

                dgv_lcm.DataSource = listcentro2;
                dgv_lcm.Refresh();

                dgv_venta.DataSource = listventa;
                dgv_venta.Columns[4].Visible = false;
                dgv_venta.Columns[5].Visible = false;
                dgv_venta.Refresh();

            }
            catch (Exception ex) {

                Lbl_Mensaje.ForeColor = Color.Red;
                Lbl_Mensaje.Text = ex.Message;
            }

           
        }

         }

    class MostrarDatos {
        public string Centro { get; set; }
        public string Importe { get; set; }
        public string Cantidad { get; set; }
        public string Porcentaje { get; set; }
        public string Vehiculo { get; set; }
    }
}
