using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS.daos;
using DATOS.modelo;

namespace Ventanas {
    public partial class ModificarJuego : Form {
        public ModificarJuego(int idb) {
            idbueno = idb;
            InitializeComponent();
            llenado();
        }

        int idbueno;

        DATOS.Varios val = new DATOS.Varios();

        private void nudID_ValueChanged(object sender, EventArgs e) {
            //checar();
        }

        Image img = null;

        //public Boolean checar() {
        //    JuegosDAOS dao = new JuegosDAOS();
        //    JuegosModelo jm = new JuegosModelo();
        //    jm = dao.search((int)nudID.Value);
        //    if (jm != null) {

        //        txtNombre.Text = jm.nombre;
        //        txtGenero.Text = jm.genero;
        //        dtpFecha.Value = jm.fechalanzamiento;
        //        txtDesarrollador.Text = jm.desarrollador;
        //        txtPublicador.Text = jm.publicador;
        //        cboClasificacion.SelectedItem = jm.clasificacion;
        //        nudRating.Value = jm.rating;
        //        nudPrecio.Value = jm.precio;

        //        //Acá va la imagen
        //        if (jm.imagen != null) {
        //            picImagen.Image = ByteArrayToImage(jm.imagen);
        //        } else {
        //            picImagen.Image = null;
        //        }

        //        lblEstado.Text = "-";
        //        btnModificar.Enabled = true;
        //        return true;
        //    } else {

        //        txtNombre.Text = "";
        //        txtGenero.Text = "";
        //        dtpFecha.Value = dtpFecha.MinDate;
        //        txtDesarrollador.Text = "";
        //        txtPublicador.Text = "";
        //        cboClasificacion.SelectedItem = null;
        //        nudRating.Value = nudRating.Minimum;
        //        nudPrecio.Value = nudPrecio.Minimum;
        //        //Acá va la imagen
        //        picImagen.Image = null;
        //        btnModificar.Enabled = false;
        //        lblEstado.Text = "No existe.";
        //        return false;
        //    }
        //}

        public void llenado() {
            JuegosDAOS dao = new JuegosDAOS();
            JuegosModelo jm = new JuegosModelo();
            jm = dao.search(idbueno);
            txtNombre.Text = jm.nombre;
            txtGenero.Text = jm.genero;
            dtpFecha.Value = jm.fechalanzamiento;
            txtDesarrollador.Text = jm.desarrollador;
            txtPublicador.Text = jm.publicador;
            txtClasificacion.Text = jm.clasificacion;
            nudRating.Value = jm.rating;
            nudPrecio.Value = jm.precio;

            //Acá va la imagen
            if (jm.imagen != null) {
                picImagen.Image = ByteArrayToImage(jm.imagen);
            } else {
                picImagen.Image = null;
            }

            btnModificar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e) {

            if (val.validar(txtNombre.Text, txtGenero.Text, txtDesarrollador.Text,
                txtPublicador.Text, txtClasificacion.Text, (decimal)nudRating.Value, (decimal)nudPrecio.Value))
            {
                JuegosModelo i = new JuegosModelo();
                JuegosDAOS dao = new JuegosDAOS();

                img = picImagen.Image;

                i.idjuego = idbueno;
                i.nombre = txtNombre.Text;
                i.genero = txtGenero.Text;
                i.fechalanzamiento = dtpFecha.Value;
                i.desarrollador = txtDesarrollador.Text;
                i.publicador = txtPublicador.Text;
                i.clasificacion = txtClasificacion.Text;
                i.rating = nudRating.Value;
                i.precio = nudPrecio.Value;

                if (img != null)
                {
                    i.imagen = ImageToByteArray(img);
                }
                else
                {
                    i.imagen = null;
                }


                dao.update(i);
                MessageBox.Show("Modificado.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Algo está mal con los datos.");
            }

        }

        public static Image ByteArrayToImage(byte[] byteArrayIn) {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            return Image.FromStream(ms);
        }

        public static byte[] ImageToByteArray(Image imageIn) {
            MemoryStream ms = new MemoryStream();
            imageIn.Save(ms, ImageFormat.Jpeg);
            return ms.ToArray();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e) {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Archivo JPG|*.jpg";

            if (fileDialog.ShowDialog() == DialogResult.OK) {
                img = Image.FromFile(fileDialog.FileName);
                picImagen.Image = img;
                string ruta = fileDialog.FileName;
                string nombre = ruta.Substring(ruta.LastIndexOf("\\") + 1);
                lblImagen.Text = nombre;
            }
        }

        private void ModificarJuego_Load(object sender, EventArgs e) {

        }
    }
}
