using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoLinq
{
    public static class IEnumerableExtensions
    {
        public static IEnumerable<T> Paginar<T>(this IEnumerable<T> coleccion, int pagina, int tamanoLote)
        {
            return coleccion.Skip((pagina - 1) * tamanoLote).Take(tamanoLote);
        }
    }
}
