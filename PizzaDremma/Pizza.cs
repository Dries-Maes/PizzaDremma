using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaDremma
{
    class Pizza
    {

        public string Name { get; set; }//Pepperoni, Chicken Heaven, Veggie Galore,...
        public double Price { get; set; }//€12,00 ofzo
        public bool Vegetarisch { get; set; }//ja/nee
        public string Size { get; set; }//regular, medium, large
        public string Crust { get; set; }//pan, deep, cheese

        public string Cheesies1 { get; set; }//mozzarella
        public string Cheesies2 { get; set; }//emmentaler
        public string Cheesies3 { get; set; }//gorgonzola
        public string Cheesies4 { get; set; }//parmezaan

        public string Veggies1 { get; set; }//paprika
        public string Veggies2 { get; set; }//olijven
        public string Veggies3 { get; set; }//champignons
        public string Veggies4 { get; set; }//artichok

        public string Meaties1 { get; set; }//gehakt
        public string Meaties2 { get; set; }//salami
        public string Meaties3 { get; set; }//kip

        //ffkes een plasje gaan doen :D
    }
}
