using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Circulo:Forma
    {
        public String Desenhar()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("----------------------------");
            builder.Append("\n--------------------------------------------------------");
        
            builder.Append("\n--------------------------------------------------------------------------------------------------------------------------------------------");
            return builder.ToString();
        }
    }
}
