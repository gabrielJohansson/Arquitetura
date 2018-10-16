using System;

namespace JogosDeGuerra
{
    internal class FactoryExercitoEgipcio : AbstractFactoryExercito
    {
        public override Arqueiro CriarArqueiro()
        {
            return new ArqueiroEgipicio();
        }

        public override Cavalaria CriarCavalaria()
        {
            return new CavalariaEgipicia();
        }

        public override Guerreiro CriarGuerreiro()
        {
            return new GuerreiroEgipicio();
        }
    }
}