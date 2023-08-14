﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DAprendizaje
    {
        /// <summary>
        /// Este metodo Insertará un nuevo registro por medio de un procedimiento almacenado, el cual recibe patametros
        /// </summary>
        /// <param name="parametros"></param> parametros es la manera de llamar los datos existentes en LAprendizaje
        /// <returns></returns>
        public bool InsertarEstrAprea(LAprendizaje parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarEstrategiaAprendizaje", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreEstApren", parametros.NombreEstApren);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        /// <summary>
        /// Muestra las estrategias de aprendizaje desde una base de datos en un ComboBox con autocompletado.
        /// </summary>
        /// <param name="combo">El ComboBox en el cual se mostrarán las estrategias de aprendizaje.</param>

        public void MostrarEstrategiaAprendizaje(ComboBox combo)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarEstrategiaAprendizaje", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdEstrategiaAprendizaje";
                combo.DisplayMember = "EstrategiaAprendizaje";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["EstrategiaAprendizaje"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Inserta un nuevo registro en la EstrategiaEvaluacion
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public bool InsertarEstrategiaEvaluacion(LAprendizaje parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarEstrategiaEvaluacion", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreEstEva", parametros.NombreEsEvaluacion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        /// <summary>
        /// Muestra las Estrategias de Evaluacion desde una base de datos en un ComboBox con autocompletado.
        /// </summary>
        /// <param name="combo">El ComboBox en el cual se mostrarán las estrategias de aprendizaje.</param>
        public void MostrarEstrategiaEvaluacion(ComboBox combo)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarEstrategiaEvaluacion", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdEstragiaEvaluacion";
                combo.DisplayMember = "EstrategiaEvaluacion";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["EstrategiaEvaluacion"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }

        /// <summary>
        /// Inserta un nuevo registro en la tabla FormaEvaluacion
        /// </summary>
        /// <param name="parametros"></param>
        /// <returns></returns>
        public bool InsertarFormaEvaluacion(LAprendizaje parametros)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("InsertarFormaEvaluacion", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@NombreFormaEva", parametros.NombreFrmEva);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        /// <summary>
        /// Muestra las Formas de Evaluacion desde una base de datos en un ComboBox con autocompletado.
        /// </summary>
        /// <param name="combo">El ComboBox en el cual se mostrarán las estrategias de aprendizaje.</param>
        public void MostrarFormaEvaluacion(ComboBox combo)
        {
            try
            {
                AutoCompleteStringCollection lista = new AutoCompleteStringCollection();
                Conexion.abrir();
                SqlCommand da = new SqlCommand("MostrarFormaEvaluacion", Conexion.conectar);
                da.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter cb = new SqlDataAdapter(da);
                DataTable dt = new DataTable();
                cb.Fill(dt);
                combo.ValueMember = "IdFormaEvaluacion";
                combo.DisplayMember = "FormaEvaluacion";
                combo.DataSource = dt;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Add(dt.Rows[i]["FormaEvaluacion"].ToString());
                }
                combo.AutoCompleteCustomSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexion.cerrar();
            }
        }
    }
}
