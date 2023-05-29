using capaentidad;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaentidad;
using capanegocio;

namespace presentacion
{
    public partial class Inicio : Form
    {

        negocio cp = new negocio();
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            entidad ent = new entidad();
            ent.placa = txtPlaca.Text;
            ent.nombrepropietario = txtPropietario.Text;
            ent.tipoveh = cbtipo.Text;

            DateTime hrini = Convert.ToDateTime(ent.horainicio = HoraIni.Text);
            DateTime hrfin = Convert.ToDateTime(ent.horafinal = HoraFin.Text);
            cp.Crear(ent);
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            entidad ent = new entidad();
            ent.datos = datos.Text;
            datos.DataSource = cp.Datos(ent).Tables["planilla"];
        }

        private void actualizar_Click(object sender, EventArgs e)
        {
            entidad ent = new entidad();
            ent.idActualizar = idPlaca.Text;
            ent.newPlaca = placa.Text;
            cp.Actualizar(ent);
            Inicio_Load(sender, e);
        }

        private void borrar_Click(object sender, EventArgs e)
        {
            entidad ent = new entidad();
            ent.idActualizar = idbo.Text;
            cp.Borrar(ent);
            Inicio_Load(sender,e);
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            txtPlaca.Text = string.Empty;
            txtPropietario.Text = string.Empty;
            cbtipo.Items.Clear();
            cbtipo.Items.Insert(0, "CARRO");
            cbtipo.Items.Insert(1, "MOTO");
            cbtipo.Items.Insert(2, "BICICLETA");
            HoraIni.Text = string.Empty;
            HoraFin.Text = string.Empty;
            idPlaca.Text = string.Empty;
            placa.Text = string.Empty;
            idbo.Text = string.Empty;
        }
    }
}
