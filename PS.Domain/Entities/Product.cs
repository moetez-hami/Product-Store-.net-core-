using System;
using System.Collections.Generic;
using System.Text;

namespace PS.Domain.Entities
{
    public  class Product:Concept
    {
        public int ProductId { get; set; }
        public DateTime DateProd { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public Double Price { get; set; }
        public int Quantity { get; set; }
        public IList<Category> Categories { get; set; }
        public IList<Provider> providers { get; set; }

        public override string GetDetails()
        {
            return "l'id"+ProductId+ "\nDateProduction" + DateProd+ "\ndescription" + Description+ "\nnom" + Name+ "\nprix" + Price+ "\nquantité" + Quantity;
        }
        public virtual string GetMyType()
        {
            return "unknown";
        }
    }
}
