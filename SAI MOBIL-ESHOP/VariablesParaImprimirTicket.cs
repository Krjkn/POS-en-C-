namespace SAI_MOBIL_ESHOP
{
    internal class VariablesParaImprimirTicket
    {
        public static VariablesParaImprimirTicket instancia = null;
        string Linea1, NombreEmpresa, Calle, Telefono, FechaVenta, HoraVenta, Vendedor,
                Linea2, CantidadProductoTotal, Linea3, ProductosLista, Linea4, TotalVenta,
                Agradecimiento, TipoPago, codigoVenta, importe, cambio;
        int Total, idVenta;

        public VariablesParaImprimirTicket()
        {
            Linea1 = "";
            NombreEmpresa = "SAI MOBIL-ESHOP";
            Calle = "SAI MOBIL E-SHOP";
            Telefono = "tel. 7331913012";
            FechaVenta = "";
            HoraVenta = "";
            Vendedor = "";
            Linea2 = "";
            CantidadProductoTotal = "";
            Linea3 = "";
            ProductosLista = "";
            Linea4 = "";
            TotalVenta = "";
            Agradecimiento = "Gracias por su Preferencia";
            TipoPago = "";
            codigoVenta = "";
            importe = "";
            cambio = "";
        }

        public static VariablesParaImprimirTicket getInstancia()
        {
            if (instancia == null)
            {
                instancia = new VariablesParaImprimirTicket();
            }
            return instancia;
        }

        public void regresarANullo()
        {
            Linea1 = null;
            NombreEmpresa = null;
            Calle = null;
            Telefono = null;
            FechaVenta = null;
            HoraVenta = null;
            Vendedor = null;
            Linea2 = null;
            CantidadProductoTotal = null;
            Linea3 = null;
            ProductosLista = null;
            Linea4 = null;
            TotalVenta = null;
            Agradecimiento = null;
            TipoPago = null;
            codigoVenta = null;
            importe = null;
            cambio = null;
        }

        void setLinea1(string Linea1)
        {
            this.Linea1 = Linea1;
        }
        void setNombreEmpresa(string NombreEmpresa)
        {
            this.NombreEmpresa = NombreEmpresa;
        }
        void setCalle(string Calle)
        {
            this.Calle = Calle;
        }
        void setTelefono(string Telefono)
        {
            this.Telefono = Telefono;
        }
        public void setFechaVenta(string FechaVenta)
        {
            this.FechaVenta = FechaVenta;
        }
        void setHoraVenta(string HoraVenta)
        {
            this.HoraVenta = HoraVenta;
        }
        public void setVendedor(string Vendedor)
        {
            this.Vendedor = Vendedor;
        }
        void setLinea2(string Linea2)
        {
            this.Linea2 = Linea2;
        }
        public void setCantidadProductos(string CantidadProductos)
        {
            this.CantidadProductoTotal = CantidadProductos;
        }
        void setLinea3(string Linea3)
        {
            this.Linea3 = Linea3;
        }
        public void setProductosLista(string ProductosLista)
        {
            this.ProductosLista = ProductosLista;
        }
        void setLinea4(string Linea4)
        {
            this.Linea4 = Linea4;
        }
        public void setTotalVenta(string TotalVenta)
        {
            this.TotalVenta = TotalVenta;
        }
        void setAgradecimientos(string Agradecimientos)
        {
            this.Agradecimiento = Agradecimientos;
        }
        void setTipoPago(string TipoPago)
        {
            this.TipoPago = TipoPago;
        }
        public void setCodigoVenta(string CodigoVenta)
        {
            this.codigoVenta = CodigoVenta;
        }
        public void setImporte(string importe)
        {
            this.importe = importe;
        }
        void setCambio(string cambio)
        {
            this.cambio = cambio;
        }
        //--------------------------------------------------------------------------- 
        public string getLinea1()
        {
            return Linea1;
        }
        string getNombreEmpresa()
        {
            return NombreEmpresa;
        }
        public string getCalle()
        {
            return Calle;
        }
        public string getTelefono()
        {
            return Telefono;
        }
        public string getFechaVenta()
        {
            return FechaVenta;
        }
        string getHoraVenta()
        {
            return HoraVenta;
        }
        public string getVendedor()
        {
            return Vendedor;
        }
        string getLinea2()
        {
            return Linea2;
        }
        string getCantidadProductosTotal()
        {
            return CantidadProductoTotal;
        }
        public string getLinea3()
        {
            return Linea3;
        }
        public string getProductosLista()
        {
            return ProductosLista;
        }
        string getLinea4()
        {
            return Linea4;
        }
        public string getTotalVenta()
        {
            return TotalVenta;
        }
        string getAgradecimiento()
        {
            return Agradecimiento;
        }
        string getTipoPago()
        {
            return TipoPago;
        }
        public string getCodigoVenta()
        {
            return codigoVenta;
        }
        public string getImporte()
        {
            return importe;
        }
        string getCambio()
        {
            return cambio;
        }

        public int getTotal()
        {
            return Total;
        }

        public void setTotal(int Total)
        {
            this.Total = Total;
        }

        public int getIdVenta()
        {
            return idVenta;
        }

        public void setIdVenta(int idVenta)
        {
            this.idVenta = idVenta;
        }

    }
}