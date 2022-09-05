using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{    
    public class ConsolePrinter
    {
        public Product FinalProduct { get; set; }

        // Aplicamos el principio SRP y Expert para la encapsulacion.

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in Recipe.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}