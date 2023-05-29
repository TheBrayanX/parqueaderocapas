using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using capaentidad;
using capadatos;
using MySql.Data.MySqlClient;
using System.Numerics;
using System.Data;

namespace capanegocio
{
    public class negocio
    {
        datos dt = new datos();
        public void Crear(entidad entidad)
        {
            string tveh = entidad.tipoveh;

            if (tveh == "CARRO")
            {
                dt.Crear(entidad);
                MessageBox.Show("Tú carro fue registrado dentro del sistema. ");
            }
            if (tveh == "MOTO")
            {
                dt.Crear(entidad);
                MessageBox.Show("Tú moto fue registrado dentro del sistema. ");
            }
            if (tveh == "BICICLETA")
            {
                dt.Crear(entidad);
                MessageBox.Show("Tú bicicleta fue registrado dentro del sistema. ");
            }
        }

        public void Actualizar(entidad entidad)
        {
            dt.Actualizar(entidad);
        }
        public void Borrar(entidad entidad)
        {
            dt.Borrar(entidad);
        }

        public DataSet Datos(entidad entidad)
        {
            return dt.Ver();
        }
    }
}
