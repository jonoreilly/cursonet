using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWPF
{
    enum DiasLaborables { Lunes, Martes, Miercoles, Jueves, Viernes }

    class claseAppWPF
    {
        //declarar una veriable del tioo DiasLaborables
        private DiasLaborables diaExamen;
        //private byte DiasLaborablesCantidad = (byte)Enum.GetNames(typeof(DiasLaborables)).Length;
        
        //crear un metodo que establece el dia del examen
        public void SetExamen(string diaRecibido)
        {
            Enum.TryParse(diaRecibido, true, out diaExamen);
        }

        public void SetExamenMalo(string diaRecibido)
        {
            for (int i = 0; i < Enum.GetNames(typeof(DiasLaborables)).Length; i++)
            {
                switch (i)
                {
                    case 0:
                        if (DiasLaborables.Lunes.ToString().ToLower() == diaRecibido.ToLower())
                        {
                            diaExamen = DiasLaborables.Lunes;
                        }
                        break;
                    case 1:
                        if (DiasLaborables.Martes.ToString().ToLower() == diaRecibido.ToLower())
                        {
                            diaExamen = DiasLaborables.Martes;
                        }
                        break;
                    case 2:
                        if (DiasLaborables.Miercoles.ToString().ToLower() == diaRecibido.ToLower())
                        {
                            diaExamen = DiasLaborables.Miercoles;
                        }
                        break;
                    case 3:
                        if (DiasLaborables.Jueves.ToString().ToLower() == diaRecibido.ToLower())
                        {
                            diaExamen = DiasLaborables.Jueves;
                        }
                        break;
                    case 4:
                        if (DiasLaborables.Viernes.ToString().ToLower() == diaRecibido.ToLower())
                        {
                            diaExamen = DiasLaborables.Viernes;
                        }
                        break;
                    default:
                        throw new ArgumentException("la cagaste");
                        break;
                }
            }
        }
    }
}
