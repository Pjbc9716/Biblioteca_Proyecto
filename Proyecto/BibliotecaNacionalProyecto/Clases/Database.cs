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

    public static DataSet busquedaGeneral(String recurso)
    {
        SqlConnection conexion = Conexion();
        DataSet ds = new DataSet();
        String consulta = "";
        switch (recurso)
        {
            case "LIBRO":
                consulta = "SELECT ISBN, TITULO, AUTOR, EDITORIAL FROM LIBRO " + recurso + " ORDER BY TITULO";
                break;
            case "PERIODICO":
                consulta = "SELECT ID_PERIODICO, TITULO_PERIODICO, PRENSA, NUMERO_EDICION, FECHA FROM " + recurso + " ORDER BY ID_PERIODICO";
                break;
        }
        SqlDataAdapter da = new SqlDataAdapter(consulta, conexion);
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
        return ((ced == ds.Tables[0].Rows[0]["USERNAME"].ToString()) && (con == ds.Tables[0].Rows[0]["PASSWORD"].ToString()));
    }

    public static SqlConnection RetornaAcceso()
    {

        SqlConnection conecta = new SqlConnection();
        conecta.ConnectionString = "Data Source=DESKTOP-7B4S146; Initial Catalog='BIBLIOTECA_NACIONAL';Trusted_Connection = True;";

        return conecta;
    }

    public static Boolean validaNombreLibro(String nombreLibro)
    {
        int Resultado = 0;
        SqlConnection conx = new SqlConnection();
        conx = RetornaAcceso();

        SqlDataAdapter da = new SqlDataAdapter("SELECT COUNT(AUTOR) as DATA FROM LIBRO WHERE AUTOR='"
            + nombreLibro + "'", conx);

        DataSet ds = new DataSet();

        da.Fill(ds);
        Resultado = Int32.Parse(ds.Tables[0].Rows[0]["DATA"].ToString());
        ds.Dispose();

        if (Resultado >= 1) return true;
        else return false;
    }

    public static DataSet busquedaAvanzada(String recurso, List<System.Windows.Forms.TextBox> lista)
    {
        SqlConnection conx = new SqlConnection();
        conx = RetornaAcceso();
        String consulta = "SELECT ";
        switch (recurso)
        {
            case "LIBRO":
                consulta += "ISBN, AUTOR, TITULO, EDITORIAL FROM " + recurso + " WHERE";
                foreach (System.Windows.Forms.TextBox i in lista)
                {

                    switch (i.Name)
                    {
                        case "opcion1txt":
                            consulta += " ISBN = " + i.Text + " ";
                            break;
                        case "opcion2txt":
                            if (lista.Count == 1)
                            {
                                consulta += " AUTOR = '" + i.Text + "' ";
                            }
                            else
                            {
                                consulta += "AND AUTOR = '" + i.Text + "' ";
                            }
                            break;
                        case "opcion3txt":
                            if (lista.Count == 1)
                            {
                                consulta += " TITULO = " + i.Text + " ";
                            }
                            else
                            {
                                consulta += " AND TITULO = '" + i.Text + "' ";
                            }
                            break;
                        case "opcion4txt":
                            if (lista.Count == 1)
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
                foreach (System.Windows.Forms.TextBox i in lista)
                {
                    switch (i.Name)
                    {
                        case "opcion1txt":
                            consulta += " TITULO_PERIODICO = " + i.Text + " ";
                            break;
                        case "opcion2txt":
                            if (lista.Count == 1)
                            {
                                consulta += " PRENSA = '" + i.Text + "' ";
                            }
                            else
                            {
                                consulta += "AND PRENSA = '" + i.Text + "' ";
                            }
                            break;
                        case "opcion3txt":
                            if (lista.Count == 1)
                            {
                                consulta += " NUMERO_EDICION = " + i.Text + " ";
                            }
                            else
                            {
                                consulta += " AND NUMERO_EDICION = '" + i.Text + "' ";
                            }
                            break;
                        case "opcion4txt":
                            if (lista.Count == 1)
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

        SqlDataAdapter da = new SqlDataAdapter(consulta, conx);

        DataSet ds = new DataSet();
        da.Fill(ds);
        return ds;
    }

}
