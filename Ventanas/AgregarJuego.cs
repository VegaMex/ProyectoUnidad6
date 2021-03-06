﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DATOS.daos;
using DATOS.modelo;
using DATOS.util;

namespace Ventanas {
    public partial class AgregarJuego : Form {
        public AgregarJuego() {
            InitializeComponent();
        }

        Image img = null;

        DATOS.Varios val = new DATOS.Varios();

        private void btnGuardar_Click(object sender, EventArgs e) {

            if (val.validar(txtNombre.Text, txtGenero.Text, txtDesarrollador.Text,
                txtPublicador.Text, txtClasificacion.Text, (decimal)nudRating.Value,(decimal)nudPrecio.Value ))
            {
                JuegosModelo j = new JuegosModelo();
                JuegosDAOS dao = new JuegosDAOS();

                j.nombre = txtNombre.Text;
                j.genero = txtGenero.Text;
                j.fechalanzamiento = dtpFecha.Value;
                j.desarrollador = txtDesarrollador.Text;
                j.publicador = txtPublicador.Text;
                j.clasificacion = txtClasificacion.Text;
                j.rating = (decimal)nudRating.Value;
                j.precio = (decimal)nudPrecio.Value;

                if (img != null)
                {
                    j.imagen = ImageToByteArray(img);
                }
                else
                {
                    j.imagen = null;
                }

                dao.insert(j);
                MessageBox.Show("Agregado.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Algo está mal con los datos.");
            }

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
                string nombre = ruta.Substring(ruta.LastIndexOf("\\")+1);
                lblImagen.Text = nombre;
            }
        }

        private void AgregarJuego_Load(object sender, EventArgs e) {

        }
    }
}
