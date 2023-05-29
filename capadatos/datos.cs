using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using capaentidad;
using System.Data;

namespace capadatos
{
    public class datos
    {   
        string cadena = "Server=localhost;User=root;Password=;Port=3306;database=parqueadero";

        public void Conexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadena);

            try
            {
                conexion.Open();
            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }
        public void Crear(entidad entidad)
        {
            MySqlConnection conexion = new MySqlConnection(cadena);
            conexion.Open();

            string Query = "INSERT INTO `planilla` (`id`, `placaveh`, `nombreprop`, `tipoveh`, `horaini`, `horafin`) VALUES (NULL, '"+entidad.placa+"', '"+entidad.nombrepropietario+"', '"+entidad.tipoveh+"', '"+entidad.horainicio+"', '"+entidad.horafinal+"');";

            MySqlCommand codigo = new MySqlCommand(Query, conexion);
            codigo.ExecuteNonQuery();

            conexion.Close();
        }

        public void Actualizar(entidad entidad)
        {
            MySqlConnection conexionBD = new MySqlConnection(cadena);
            conexionBD.Open();

            string Query = "UPDATE `planilla` SET `placaveh` = '"+ entidad.newPlaca + "' WHERE `planilla`.`id` = "+entidad.idActualizar+";";

            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            conexionBD.Close();
        }
        public void Borrar(entidad entidad)
        {
            MySqlConnection conexionBD = new MySqlConnection(cadena);
            conexionBD.Open();

            string Query = "DELETE FROM `planilla` WHERE `id`='" + entidad.idActualizar + "';";

            MySqlCommand codigo = new MySqlCommand(Query, conexionBD);
            codigo.ExecuteNonQuery();

            conexionBD.Close();
        }
        public DataSet Ver()
        {
            MySqlConnection conexionBD = new MySqlConnection(cadena);
            conexionBD.Open();

            string Query = ("SELECT * FROM `planilla`;");

            MySqlDataAdapter adaptador;
            DataSet ds = new DataSet();
            adaptador = new MySqlDataAdapter(Query, conexionBD);
            adaptador.Fill(ds, "planilla");
            return ds;
        }
    }
}
