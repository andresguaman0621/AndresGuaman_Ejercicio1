using System;
using System.ComponentModel.DataAnnotations;

namespace AndresGuaman_Ejercicio1.Models
{
	public class Burger
	{
	    public int Id { get; set; }
        public string? Name { get; set; }
        public bool WithCheese { get; set; }
        [Range(0.01, 9999.99)]
        public decimal Precio { get; set; }
	}
}

