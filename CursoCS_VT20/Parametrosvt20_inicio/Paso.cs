using System;

namespace Parametros
{
    class Paso
    {
        public static void Valor(int param)
        {
            param = 57;
        }

        public static void Referencia(RodeaInt param)
        {
            param.Numero = 57;
        }
    }
}