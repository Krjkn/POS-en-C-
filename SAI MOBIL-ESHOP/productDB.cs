using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Windows.Forms;

namespace SAI_MOBIL_ESHOP
{
    internal class productDB

    {
        private static bool flag;
        public static SqlConnection GetSqlConnection()
        {
            string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
        public static void InsertIntoProductDB(string lote, string descripcion, double precio_venta, double precio_compra, int stock)
        {
            try
            {
                using (SqlConnection con = GetSqlConnection())
                {
                    string query = "INSERT INTO productos(Lote, Descripcion, Precio_Venta, Precio_Compra, Stock) " +
                        "VALUES (@lote, @descripcion, @precio_venta, @precio_compra, @stock)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@lote", lote);
                        cmd.Parameters.AddWithValue("@descripcion", descripcion);
                        cmd.Parameters.AddWithValue("@precio_venta", precio_venta);
                        cmd.Parameters.AddWithValue("@precio_compra", precio_compra);
                        cmd.Parameters.AddWithValue("@stock", stock);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            MessageBox.Show("Añadido exitosamente!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        public static List<ProductList> CheckStock()
        {
            List<ProductList> list = new List<ProductList>();

            try
            {
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    string query = "SELECT ID_Prod, Lote, Descripcion, Stock, Precio_Venta, Precio_Compra FROM productos";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {

                                ProductList pl = new ProductList(
                                    reader.GetInt32(reader.GetOrdinal("ID_Prod")),
                                    reader.GetString(reader.GetOrdinal("Lote")),
                                    reader.GetString(reader.GetOrdinal("Descripcion")),
                                    reader.GetDouble(reader.GetOrdinal("Precio_Compra")),
                                    reader.GetDouble(reader.GetOrdinal("Precio_Venta")),
                                    reader.GetInt32(reader.GetOrdinal("Stock"))
                                );

                                list.Add(pl);
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }

            return list;
        }

        public static DataTable ObtenerTodosLosProductos()
        {
            DataTable tabla = new DataTable();
            string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
            SqlConnection con = new SqlConnection(connectionString);
            {
                con.Open();
                string consultaSQL = "SELECT * FROM productos"; 
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
        public static DataTable ObtenerProductosPorConsulta(string consulta)
        {
            DataTable tabla = new DataTable();
            string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                string consultaSQL = "SELECT * FROM productos WHERE ID_Prod LIKE '%" + consulta +
            "%' OR Descripcion LIKE '%" + consulta + "%' OR Lote LIKE '%" + consulta + "%';";
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


        internal static void actualizarProducto(string lote, string Descripcion, double precio_venta,
            double precio_compra, int Stock, int ID_Prod)
        {
            string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
            SqlConnection con = new SqlConnection(connectionString);
            {
                try
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand("UPDATE productos SET Lote = @Lote, Descripcion = @Descripcion, Precio_Venta = @Precio_Venta, Precio_Compra = @Precio_Compra, Stock = @Stock  WHERE ID_Prod = @ID_Prod", con);
                    cmd.Parameters.AddWithValue("@Lote", lote);
                    cmd.Parameters.AddWithValue("@Descripcion", Descripcion);
                    cmd.Parameters.AddWithValue("@Precio_Venta", precio_venta);
                    cmd.Parameters.AddWithValue("@Precio_Compra", precio_compra);
                    cmd.Parameters.AddWithValue("@Stock", Stock);
                    cmd.Parameters.AddWithValue("@ID_Prod", ID_Prod);

                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Producto Actualizado");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de MySQL: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        internal static void Delete(int ID_Prod)
        {
            DialogResult confirm = MessageBox.Show("¿Estás seguro de que quieres borrar el artículo?", "Confirmar eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                    SqlConnection con = new SqlConnection(connectionString);
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("DELETE FROM productos WHERE ID_Prod=@ID_Prod", con);
                        cmd.Parameters.AddWithValue("@ID_Prod", ID_Prod);

                        if (cmd.ExecuteNonQuery() == 0)
                        {
                            MessageBox.Show("Artículo no encontrado!");
                        }
                        else
                        {
                            MessageBox.Show("Artículo eliminado!");
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error de SQL Server: " + ex.Message);
                }
            }
        }

        internal static void SellProductDB(int ID_Prod, int Stock)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                SqlConnection con = new SqlConnection(connectionString);
                {
                    con.Open();
                    string query = "UPDATE productos SET Stock = @Stock WHERE ID_Prod = @ID_Prod";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Stock", Stock);
                        cmd.Parameters.AddWithValue("@ID_Prod", ID_Prod);

                        int rowsUpdated = cmd.ExecuteNonQuery();
                        if (rowsUpdated == 0)
                        {
                            MessageBox.Show("Articulo no encontrado!");
                        }
                        else if (rowsUpdated == 1 && flag)
                        {
                            MessageBox.Show("Reducido del stock");
                            flag = false;
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Error al actualizar el stock del producto: " + ex.Message);
            }
        }

        internal static void InsertIntoVendedoresDB(string nombre, string email, string password)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                SqlConnection con = new SqlConnection(connectionString);
                {
                    // Ajusta este query según la estructura de tu tabla de vendedores
                    con.Open();
                    string query = "INSERT INTO vendedores (Nombre, CorreoElectronico, Password) VALUES (@nombre, @correoElectronico, @password)";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@nombre", nombre);
                        cmd.Parameters.AddWithValue("@correoElectronico", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Vendedor añadido exitosamente!");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al insertar vendedor: " + ex.Message);
            }
        }

        internal static bool UserExists(string username)
        {
            try
            {
                string connectionString = "Data Source=LAPTOP-97C2SFPH\\MSSQLSERVER02,50991;Initial Catalog=sai-pos;User ID=sa;Password=123;";
                SqlConnection con = new SqlConnection(connectionString);
                {
                    string query = "SELECT COUNT(*) FROM vendedores WHERE Nombre = @username";
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        con.Open();
                        int result = (int)cmd.ExecuteScalar();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el usuario: " + ex.Message);
                return false;
            }
        }
    }
}