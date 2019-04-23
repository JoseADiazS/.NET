using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Author Jose Armando Diaz Segura
namespace Taller2_3Corte
{
    public class RecordVO
    {
        private string productName;
        private string companyName;
        private string categoryName;
        private double unitPrice;
        private string quantityPerUnit;
        private int unitsOnOrder;
        private int reorderLevel;
        private bool discontinued;

        public string ProductName { get => productName; set => productName = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public string CategoryName { get => categoryName; set => categoryName = value; }
        public double UnitPrice { get => unitPrice; set => unitPrice = value; }
        public string QuantityPerUnit { get => quantityPerUnit; set => quantityPerUnit = value; }
        public int UnitsOnOrder { get => unitsOnOrder; set => unitsOnOrder = value; }
        public int ReorderLevel { get => reorderLevel; set => reorderLevel = value; }
        public bool Discontinued { get => discontinued; set => discontinued = value; }
    }
}