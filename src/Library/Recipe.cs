//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        /* Recipe sabe todos los Steps que tiene cada receta, por lo tanto es EXPERTA en eso
        Trayendo el costo de cada uno de los Steps, Recipe puede sumarlos para calcular el total.
        */
        public double GetProductionCost
        {
            get
            {
                double result = 0;
                foreach (Step item in this.steps)
                {
                    result = result + item.StepCost;
                }
                return result;
            }
        }
        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            Console.WriteLine($"El costo total de la receta es {this.GetProductionCost}");
        }
    }
}