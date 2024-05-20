using System;

namespace SAI_MOBIL_ESHOP
{
    public class ProductList
    {
        public int ID_producto;
        public string Lote;
        public string Descripcion;
        public double Precio_Venta; 
        public double Precio_Compra; 
        public int Stock;


        public ProductList(int iD_producto, string lote, string descripcion, double precio_Venta, double precio_Compra, int stock)
        {
            ID_producto = iD_producto;
            Lote = lote;
            Descripcion = descripcion;
            Precio_Venta = precio_Venta;
            Precio_Compra = precio_Compra;
            Stock = stock;
        }
    }

}