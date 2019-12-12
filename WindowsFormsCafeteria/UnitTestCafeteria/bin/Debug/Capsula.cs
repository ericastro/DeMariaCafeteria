using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCafeteria
{
    public class Capsula
    {
        private int forca;

        public Capsula()
        {

        }

        public int Capsulas_id { get; set; }
        public string Descricao { get; set; }
        public int Forca
        {
            get
            {
                return forca;
            }
            set
            {
                if( (this.forca > 0) && (this.forca < 11) )
                {
                    forca = Forca;
                }
                else
                {
                    forca = 0;
                }
            }
        }

        public void IncluirCapsula(Capsula capsula)
        {

        }

        public void LitarCapsulas()
        {

        }

        public void EditarCapsulas(Capsula capsula)
        {

        }

        public void ExcluirCapsulas(int capusla_id)
        {

        }
    }



}
