using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace SAI_MOBIL_ESHOP
{
    internal class VentaDB
    {
        internal static void InsertIntoVentaDB(double total, string idUsuario, string efectivo)
        {
            try
            {
                // Cadena de conexión al servidor de SQL Server
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";

                // Consulta SQL para insertar la venta
                string query = "INSERT INTO ventas(FechaVenta, Total, Vendedor, Efectivo) VALUES(GETDATE(), @Total, @Vendedor, @Efectivo)";

                // Creación y uso del objeto SqlConnection dentro de un bloque using para asegurar que se cierre y libere correctamente
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();

                    // Creación y uso del objeto SqlCommand también dentro de un bloque using
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        // Asignación de valores a los parámetros
                        cmd.Parameters.AddWithValue("@Total", total);
                        cmd.Parameters.AddWithValue("@Vendedor", idUsuario);
                        cmd.Parameters.AddWithValue("@Efectivo", efectivo);

                        // Ejecución del comando
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al insertar venta en la base de datos: " + ex.Message);
            }
        }

        internal static List<detVentaObject> obtenerDetallesVenta(int idVenta)
        {
            List<detVentaObject> detallesVenta = new List<detVentaObject>();

            try
            {
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                using (SqlConnection conexion = new SqlConnection(connectionString))
                {
                    conexion.Open();

                    string consulta = @"SELECT dv.ID_Venta, dv.ID_Prod, p.Descripcion, dv.Cantidad, dv.PrecioUnitario, dv.SubTotal, v.Vendedor
                        FROM detallesventa dv
                        INNER JOIN productos p ON dv.ID_Prod = p.ID_Prod
                        INNER JOIN ventas v ON dv.ID_Venta = v.ID_Venta
                        WHERE dv.ID_Venta = @idVenta";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(consulta, conexion))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@idVenta", idVenta);

                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "detallesVenta");

                        // Acceder a los datos del DataSet
                        DataTable detallesVentaTable = dataSet.Tables["detallesVenta"];
                        foreach (DataRow row in detallesVentaTable.Rows)
                        {
                            int idProducto = Convert.ToInt32(row["ID_Prod"]);
                            string descripcion = row["Descripcion"].ToString();
                            int cantidad = Convert.ToInt32(row["Cantidad"]);
                            double precioUnitario = Convert.ToDouble(row["PrecioUnitario"]);
                            double SubTotal = Convert.ToDouble(row["SubTotal"]);
                            string vendedor = row["Vendedor"].ToString();

                            detVentaObject detalleVenta = new detVentaObject(Convert.ToInt32(row["ID_Venta"]), idProducto, descripcion, cantidad, precioUnitario, SubTotal, vendedor);
                            detallesVenta.Add(detalleVenta);
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error al obtener los detalles de venta: " + e.Message);
            }

            return detallesVenta;
        }

        internal static int ObtenerNumeroVentaActual()
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                SqlConnection con = new SqlConnection(connectionString);
                {
                    con.Open();
                    string query = "SELECT COUNT(*) FROM ventas";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        int totalVentas = Convert.ToInt32(cmd.ExecuteScalar());
                        return totalVentas + 1; // Sumamos 1 para obtener el número de venta actual
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al obtener el número de venta actual: " + ex.Message);
            }

            return 0; // Si ocurre un error, devuelve 0
        }

        internal static DataTable ObtenerTodasLasVentas()
        {
            DataTable tabla = new DataTable();
            string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string consultaSQL = "SELECT * FROM ventas"; // Ajusta la consulta SQL para la tabla de ventas
                using (SqlCommand cmd = new SqlCommand(consultaSQL, con))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(tabla);
                    }
                }
            }
            return tabla;
        }

        internal static void RegistrarDetallesVenta(int idVenta, int idProducto, int cantidad, double precioUnitario, double SubTotal)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                SqlConnection con = new SqlConnection(connectionString);
                {
                    con.Open();
                    string query = "INSERT INTO detallesventa (ID_Venta, ID_Prod, Cantidad, PrecioUnitario, SubTotal) VALUES (@ID_Venta, @ID_Prod, @Cantidad, @PrecioUnitario, @SubTotal)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@ID_Venta", idVenta);
                        cmd.Parameters.AddWithValue("@ID_Prod", idProducto);
                        cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                        cmd.Parameters.AddWithValue("@PrecioUnitario", precioUnitario);
                        cmd.Parameters.AddWithValue("@SubTotal", SubTotal);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al registrar los detalles de venta: " + ex.Message);
            }
        }
    }
}