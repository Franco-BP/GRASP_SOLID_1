//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public ArrayList getSteps()
        {
            return steps;
        }

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        // Para asignar la responsabilidad, use la diferenciación de Expert, siendo que la
        // clase Recipe es la que conoce cantidad de cada ítem y horas de uso de cada equipo.
        public double GetProductionCost()
        {
            double itemCost = 0;
            double equipmentCost = 0;
            foreach (Step step in this.steps)
            {
                itemCost += step.Input.UnitCost * step.Quantity;
                equipmentCost += step.Equipment.HourlyCost * step.Time;
            }
            double totalCost = itemCost + equipmentCost;
            return totalCost;
        }
    }
}