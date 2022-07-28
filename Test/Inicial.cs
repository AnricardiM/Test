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
            pl_auto.Visible = false;
            pl_centro.Visible = false;
            pl_dashboard.Visible = true;
            pl_venta.Visible = false;
            var respuesta = aux.GetAll("venta");
            var listventa = funcion.ConvertirVenta(respuesta.responseBody);

             respuesta = aux.GetAll("centro");
            var listcentro = funcion.ConvertirCentro(respuesta.responseBody);

            respuesta = aux.GetAll("auto");
            var listautos = funcion.ConvertirAuto(respuesta.responseBody);

            var nuevalist = listventa.Select(x => new {
              Vehiculo = listautos.First(y => y.idAuto == x.idAuto).descripcionAuto,
              CentroDeVenta = listcentro.First(y => y.idCentro == x.idCentro).descripcionCentro,
              Descripcion = x.descripcionVenta,
              Monto = listautos.First(y => y.idAuto == x.idAuto).costoAuto,
              x.idCentro
            }).ToList();

                        
            dgv_venta.DataSource = nuevalist;
            dgv_venta.Refresh();

            int cantidad = nuevalist.Count();
            int c1 = nuevalist.Count(x => x.idCentro == 1);
            int c2 = nuevalist.Count(x => x.idCentro == 2);
            int c3 = nuevalist.Count(x => x.idCentro == 3);
            int c4 = nuevalist.Count(x => x.idCentro == 4);

            lbl_TV.Text = "Total Importe: U$S" + nuevalist.Sum(x => x.Monto).ToString(); 
            lbl_TNV.Text = "Cantidad : " + cantidad.ToString(); 

            lbl_TC1.Text = "Total C1: U$S" + nuevalist.Where(x => x.idCentro == 1).Sum(x=>x.Monto).ToString(); 
            lbl_TC2.Text = "Total C2: U$S" + nuevalist.Where(x => x.idCentro == 2).Sum(x => x.Monto).ToString();
            lbl_TC3.Text = "Total C3: U$S" + nuevalist.Where(x => x.idCentro == 3).Sum(x => x.Monto).ToString(); 
            lbl_TC4.Text = "Total C4: U$S" + nuevalist.Where(x => x.idCentro == 4).Sum(x => x.Monto).ToString();

            label3.Text = "Cantidad C1: " + c1.ToString();
            label4.Text = "Cantidad C2: " + c2.ToString();
            label5.Text = "Cantidad C3: " + c3.ToString();
            label6.Text = "Cantidad C4: " + c4.ToString();

            lbl_PC1.Text = "C1: " + (c1*100/cantidad).ToString() +"%";
            lbl_PC2.Text = "C2: " + (c2 * 100 / cantidad).ToString() + "%";
            lbl_PC3.Text = "C3: " + (c3 * 100 / cantidad).ToString() + "%";
            lbl_PC4.Text = "C4: " + (c4 * 100 / cantidad).ToString() + "%";
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void pl_venta_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
