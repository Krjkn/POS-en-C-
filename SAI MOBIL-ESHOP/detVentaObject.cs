namespace SAI_MOBIL_ESHOP
{
    internal class detVentaObject
    {
        public int idVenta;
        public int idProducto;
        public string descripcion;
        public int cantidad;
        public double precioUnitario;
        public double subtotal;
        public string vendedor;

        public detVentaObject(int idVenta, int idProducto, string descripcion, int cantidad, double precioUnitario, double subtotal, string vendedor)
        {
            this.idVenta = idVenta;
            this.idProducto = idProducto;
            this.descripcion = descripcion;
            this.cantidad = cantidad;
            this.precioUnitario = precioUnitario;
            this.subtotal = subtotal;
            this.vendedor = vendedor;
        }
        public int getIdVenta()
        {
            return idVenta;
        }

        public void setIdVenta(int idVenta)
        {
            this.idVenta = idVenta;
        }

        public int getIdProducto()
        {
            return idProducto;
        }

        public void setIdProducto(int idProducto)
        {
            this.idProducto = idProducto;
        }


        public string getDescripcion()
        {
            return descripcion;
        }

        public void setDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public int getCantidad()
        {
            return cantidad;
        }

        public void setCantidad(int cantidad)
        {
            this.cantidad = cantidad;
        }

        public double getPrecioUnitario()
        {
            return precioUnitario;
        }

        public void setPrecioUnitario(double precioUnitario)
        {
            this.precioUnitario = precioUnitario;
        }


        public double getSubtotal()
        {
            return subtotal;
        }

        public void setSubtotal(double subtotal)
        {
            this.subtotal = subtotal;
        }



        public string getVendedor()
        {
            return vendedor;
        }

        public void setVendedor(string vendedor)
        {
            this.vendedor = vendedor;
        }
    }
}