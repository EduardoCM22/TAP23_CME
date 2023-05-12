﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using MySql.Data.MySqlClient;

namespace Datos
{
    public class CategoryDAO
    {
        public List<Category> obtenerCategorias() {
            List<Category> lista = new List<Category>();
            //Conectarme
            if (Conexion.Conectar())
            {
                try
                { 
                //Crear la sentencia a ejecutar (SELECT)
                String select = "Select CategoryId, CategoryName from Categories;";
                //Definir un datatable para que sea llenado
                DataTable dt = new DataTable();
                //Crear el dataadapter
                MySqlCommand sentencia=new MySqlCommand();
                sentencia.CommandText=select;
                sentencia.Connection = Conexion.conexion;
                MySqlDataAdapter da = new MySqlDataAdapter();
                da.SelectCommand = sentencia;
                //Llenar el datatable
                da.Fill(dt);
                //Crear un objeto categoría por cada fila de la tabla y añadirlo a la lista
                foreach (DataRow fila in dt.Rows)
                {
                    Category categoria = new Category(
                        //int.Parse(fila["Clave"].ToString())
                        Convert.ToInt32(fila["CategoryId"]),
                        fila["CategoryName"].ToString()
                        );
                    lista.Add(categoria);
                }

                return lista;
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
            else {
                return null;
            }
        }
    }
}
