using Domain;
using System;

namespace Infraestructure
{
    public class ActivoModel
    {
        public ActivosFijos[] activosFijos;
        public void Add(ActivosFijos Act)
        {
            if (Act == null)
            {
                throw new ArgumentException("El producto no puede ser null.");
            }
            Add(Act, ref activosFijos);
        }
        private void Add(ActivosFijos ActivoF, ref ActivosFijos[] acts)
        {
            if (activosFijos == null)
            {
                activosFijos = new ActivosFijos[1];
                activosFijos[0] = ActivoF;
            }

            ActivosFijos[] temp = new ActivosFijos[activosFijos.Length + 1];
            Array.Copy(activosFijos, temp, activosFijos.Length);
            temp[temp.Length - 1] = ActivoF;
            activosFijos = temp;
        }

        public string Print()
        {
            string Print = "";

            if(activosFijos == null)
            {
                throw new ArgumentException("Error el activo fijo no puede ser null.");
            }
            foreach(ActivosFijos activosFijos in activosFijos)
            {
                Print = $"Id         Codigo       Nombre       Valor         Fecha Adquisicion       Tipo Activo \n"+
                  $"{activosFijos.Id}       {activosFijos.Codigo}        {activosFijos.Nombre}       {activosFijos.ValorActivo}        {activosFijos.FechaAdquisicion}        {activosFijos.TipoActivo}";
            }
            return Print;
        }

        public ActivosFijos[] GetActivosFijos()
        {
            return activosFijos;
        }

        public int GetLastActivoId()
        {
            return activosFijos == null ? 0 : activosFijos[activosFijos.Length - 1].Id;
        }
    }
}
