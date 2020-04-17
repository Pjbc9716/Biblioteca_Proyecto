using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

public class Database
{
    public Database()
    {

    }

    public static SqlConnection Conexion()
    {
        Console.WriteLine("Conectando...");
        SqlConnection conexion = new SqlConnection();
        conexion.ConnectionString = "Data Source=DESKTOP-7B4S146; Initial Catalog='BIBLIOTECA_NACIONAL';Trusted_Connection = True;";
        Console.WriteLine("Conectado a: " + conexion.ConnectionString.Split(';')[1]);
        return conexion;
    }

    public static Boolean hayRecurusos(String tipoRecurso)
    {
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(*) AS NUMERO_RECURSOS FROM " + tipoRecurso + " ;", Conexion());
        da.Fill(ds);
        Console.WriteLine("RESPUESTA "+ds.Tables[0].Rows[0]["NUMERO_RECURSOS"].ToString());
        ds.Dispose();
        return (!ds.Tables[0].Rows[0]["NUMERO_RECURSOS"].ToString().Equals("0"));
    } 
    public static DataSet busquedaGeneral(String recurso)
    {
        DataSet ds = new DataSet();
        String consulta = "";
        switch (recurso)
        {
            case "LIBRO":
                consulta = "SELECT ISBN, TITULO, AUTOR, EDITORIAL FROM  " + recurso + "  WHERE TOTAL_DISPONIBLES > 1 ORDER BY TITULO";
                break;
            case "PERIODICO":
                consulta = "SELECT ID_PERIODICO, TITULO_PERIODICO ,PRENSA, NUMERO_EDICION FROM " + recurso + " WHERE TOTAL_DISPONIBLES > 1 ORDER BY TITULO_PERIODICO";
                break;
            case "REVISTA":
                consulta = "SELECT ID_REVISTA, TITULO_REVISTA, NOMBRE_REVISTA,NUMERO_EDICION FROM " + recurso + " WHERE TOTAL_DISPONIBLES > 1 ORDER BY TITULO_REVISTA" ;
                break;
        }
        SqlDataAdapter da = new SqlDataAdapter(consulta, Conexion());
        da.Fill(ds);
        return ds;
    }
    public static Boolean verificarCredenciales(String ced, String con)
    {
        SqlConnection conx = Conexion();
        SqlDataAdapter da = new SqlDataAdapter("SELECT CEDULA AS USERNAME, CONTRASENA AS PASSWORD FROM ADMINISTRADOR WHERE CEDULA='"
            + ced + "' AND CONTRASENA='" + con + "'", conx);
        DataSet ds = new DataSet();
        da.Fill(ds);
        ds.Dispose();
        if (ds.Tables[0].Rows.Count == 0)
        {

            return false;
        }
        else
        {
            return true;
        }
    }

    public static SqlDataAdapter busquedaAvanzada(String recurso, List<System.Windows.Forms.TextBox> filtros)
    {
        SqlConnection conx = new SqlConnection();
        conx = Conexion();
        String consulta = "SELECT ";
        switch (recurso)
        {
            case "LIBRO":
                consulta += "TITULO, AUTOR, ISBN, EDITORIAL FROM " + recurso + " WHERE";
                foreach (System.Windows.Forms.TextBox i in filtros)
                {

                    switch (i.Name)
                    {
                        case "opcion1txt":
                            consulta += " ISBN = " + i.Text + " ";
                            break;
                        case "opcion2txt":
                            if (filtros.Count == 1)
                            {
                                consulta += " AUTOR = '" + i.Text + "' ";
                            }
                            else
                            {
                                consulta += "AND AUTOR = '" + i.Text + "' ";
                            }
                            break;
                        case "opcion3txt":
                            if (filtros.Count == 1)
                            {
                                consulta += " TITULO = " + i.Text + " ";
                            }
                            else
                            {
                                consulta += " AND TITULO = '" + i.Text + "' ";
                            }
                            break;
                        case "opcion4txt":
                            if (filtros.Count == 1)
                            {
                                consulta += " EDITORIAL = '" + i.Text + "' ";
                            }
                            else
                            {
                                consulta += " AND EDITORIAL= '" + i.Text + "' ";
                            }
                            break;
                    }
                }
                consulta += ";";
                break;

            case "PERIODICO":
                consulta += "TITULO_PERIODICO, PRENSA , NUMERO_EDICION , FECHA FROM " + recurso + " WHERE";
                foreach (System.Windows.Forms.TextBox i in filtros)
                {

                    switch (i.Name)
                    {
                        case "opcion1txt":
                            consulta += " TITULO_PERIODICO = " + i.Text + " ";
                            break;
                        case "opcion2txt":
                            if (filtros.Count == 1)
                            {
                                consulta += " PRENSA = '" + i.Text + "' ";
                            }
                            else
                            {
                                consulta += "AND PRENSA = '" + i.Text + "' ";
                            }
                            break;
                        case "opcion3txt":
                            if (filtros.Count == 1)
                            {
                                consulta += " NUMERO_EDICION = " + i.Text + " ";
                            }
                            else
                            {
                                consulta += " AND NUMERO_EDICION = '" + i.Text + "' ";
                            }
                            break;
                        case "opcion4txt":
                            if (filtros.Count == 1)
                            {
                                consulta += " FECHA = '" + i.Text + "' ";
                            }
                            else
                            {
                                consulta += " AND FECHA = '" + i.Text + "' ";
                            }
                            break;
                    }
                }
                consulta += ";";
                break;
        }
        Console.WriteLine(consulta);
        return new SqlDataAdapter(consulta, conx);
    }

}
