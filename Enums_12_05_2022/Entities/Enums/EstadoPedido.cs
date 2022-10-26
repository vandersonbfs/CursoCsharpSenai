using System;
using System.Collections.Generic;
using System.Text;

namespace Enums_12_05_2022.Entities.Enums
{
    enum EstadoPedido : int // A Classe agora é enum
    {
        Realizado,
        EmPreparo,
        SaiParaEntrega,
        Entregue
    }
}