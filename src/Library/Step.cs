//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }
        
        /*Step conoce la cantidad y el costos de los productos, por lo tanto es 
        experta en eso y por eso puede calcular el costo del step - Utilizamos 
        EXPERT*/

        public double StepCost
        {
            get
            {
                return (this.Quantity*this.Input.UnitCost) + (this.Time*this.Equipment.HourlyCost);
            }
        }
    }
}