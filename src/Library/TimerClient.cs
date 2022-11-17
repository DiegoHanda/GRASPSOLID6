//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------
using System;
using System.Threading;

namespace Full_GRASP_And_SOLID
{
    public class TimerClient //Se eliminó la interfaz TimerClient, ya que se creó una clase con ese mismo nombre y funcion.
    {
        private Recipe recipe;
        public TimerClient(Recipe recipe)
        {
            this.recipe = recipe;
        }

        public void TimeOut()
        {
            recipe.Cook();
            recipe.Cooked = true;
        }
    }
}