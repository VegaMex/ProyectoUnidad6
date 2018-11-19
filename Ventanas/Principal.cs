using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DATOS.daos;
using DATOS.modelo;

namespace Ventanas {
    public partial class Principal : Form {
        public Principal() {
            InitializeComponent();
        }

        private void agregarJuegoToolStripMenuItem_Click(object sender, EventArgs e) {
            AgregarJuego aj = new AgregarJuego();
            aj.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e) {
            tblTabla.DataSource = new JuegosDAOS().getAll();
            modificarSeleccionadoToolStripMenuItem.Enabled = true;
            eliminarSeleccionadoToolStripMenuItem.Enabled = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {

            if (txtFiltro.Text != "") {
                string filtro = txtFiltro.Text;
                List<JuegosModelo> res = new JuegosDAOS().getFiltro(filtro);
                if (res.Count != 0) {
                    tblTabla.DataSource = res;
                    modificarSeleccionadoToolStripMenuItem.Enabled = true;
                    eliminarSeleccionadoToolStripMenuItem.Enabled = true;
                } else {
                    MessageBox.Show("No hay coincidencias.");
                }
            } else {
                MessageBox.Show("Escriba criterios de filtro.");
            }

        }

        private void modificarSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e) {
            int idSelec = (int)tblTabla.Rows[tblTabla.CurrentRow.Index].Cells[0].Value;
            ModificarJuego mj = new ModificarJuego(idSelec);
            mj.Show();
        }

        private void eliminarSeleccionadoToolStripMenuItem_Click(object sender, EventArgs e) {
            int idSelec = (int)tblTabla.Rows[tblTabla.CurrentRow.Index].Cells[0].Value;
            string namSelec = (string)tblTabla.Rows[tblTabla.CurrentRow.Index].Cells[1].Value;

            if (MessageBox.Show("¿Seguro que desea borrar el registro " + namSelec + "?", "Eliminar registro",
      MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {

                JuegosDAOS jd = new JuegosDAOS();

                jd.delete(idSelec);
                MessageBox.Show("Se borró el registro " + namSelec);
                tblTabla.DataSource = new JuegosDAOS().getAll();

            } else {
                MessageBox.Show("No se borró nada.");
            }
        }

        private void Principal_Load(object sender, EventArgs e) {
            modificarSeleccionadoToolStripMenuItem.Enabled = false;
            eliminarSeleccionadoToolStripMenuItem.Enabled = false;
        }
    }
}
