using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {

        // Para asignar esta responsabilidad, se usa el principio SRP, para evitar darle otra
        // responsabilidad a Recipe. En caso de tener que cambiar el formato de impresión, no se tiene
        // que cambiar Recipe o buscar dónde se encuentra la impresión, sino que tiene una clase asignada.
        public void PrintRecipe(Recipe recipe)
        {
            Console.WriteLine($"Receta de {recipe.FinalProduct.Description}:");
            foreach (Step step in recipe.getSteps())
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"\nEl costo total de la receta es: ${recipe.GetProductionCost()}");
        }
    }
}