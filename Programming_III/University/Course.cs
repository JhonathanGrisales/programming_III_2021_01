using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityConsole
{
    public class Course
    {

       public string Code;
       public string Name;
        private int Shift; //0: nigth 1:Day;

        public void SetShift(int newShift)
        {

            if(newShift == 0 || newShift == 1)
            {

                Shift = newShift;
            }
            else
            {

                Console.WriteLine("La jornada para la asignatura " + Name + "  no puede ser != de cero o uno");
            }

        }

        public int GetShift()
        {

            return Shift;
        }
    }
}
