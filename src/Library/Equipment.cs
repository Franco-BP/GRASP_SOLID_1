//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Equipment
    {
        public ArrayList equipmentCatalog = new ArrayList();
    
        public string Description { get; set; }
        public double HourlyCost { get; set; }

        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }
    }
}