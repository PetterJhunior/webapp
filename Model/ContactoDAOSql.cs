using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo.Entidad;

namespace Model
{
    public class ContactoDAOSql
    {
        #region Conexion
        string conexionString = "Data Source=JHUNIOR;Initial Catalog=appweb;User ID=petter;Password=123456";
        SqlConnection conexionBase;
        SqlCommand comandos;
        SqlDataReader reader;
        #endregion

        #region Metodos
        #region Metodo BuscarMensajes
        public List<Contacto> buscarMensajes()
        {
            
                List<Contacto> listaContacto = new List<Contacto>();
                using (conexionBase = new SqlConnection(conexionString))
                {
                    try
                    {
                        comandos = new SqlCommand("select codigocontacto, nombrecontacto, correocontacto, comentariocontacto from contacto",conexionBase);
                        conexionBase.Open();
                        reader = comandos.ExecuteReader();
                        while (reader.Read())
                        {
                            Contacto contacto = new Contacto();
                            contacto.codigoContacto = (int)reader[0];
                            contacto.nombreContacto = (string)reader[1];
                            contacto.correoContacto = (string)reader[2];
                            contacto.comentarioContacto = (string)reader[3];
                            listaContacto.Add(contacto);
                        }
                    }
                    catch (Exception)
                    {
                        throw;
                    }            
                }            
            return listaContacto;
        }
        #endregion
        #region Metodo Crear
        public Contacto BuscarMensaje(int codigoContacto)
        {
            Contacto contacto = new Contacto();
            using (conexionBase=new SqlConnection(conexionString))
            {
                try
                {
                    comandos = new SqlCommand("SELECT codigocontacto, nombrecontacto, correocontacto, comentariocontacto FROM contacto where codigocontacto="+codigoContacto, conexionBase);
                    conexionBase.Open();
                    reader = comandos.ExecuteReader();
                    if (reader.Read())
                    {                        
                        contacto.codigoContacto = (int)reader[0];
                        contacto.nombreContacto = (string)reader[1];
                        contacto.correoContacto = (string)reader[2];
                        contacto.comentarioContacto = (string)reader[3];
                    }
                }
                catch (Exception)
                {

                    throw;
                }
            }
            return contacto;
        }
        #endregion
        #region Metodo Modificar

        #endregion
        #region Metodo Eliminar

        #endregion    
        #endregion
    }
}
