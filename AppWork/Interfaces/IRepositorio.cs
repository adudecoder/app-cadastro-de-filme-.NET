using System.Collections.Generic;

namespace AppWork.Interfaces
{
    public interface IRepositorio<T>
    {
         
        List<T> Lista(); // Uma lista que terona uma lista de T
        T RetornaPorId(int id); // id como paramentro e retorna um T como parametro, retorna uma serie
        void Insere(T entidade); // Insire vai receber uma serie
        void Exclui(int id);
        void Atualiza(int id, T entidade); // Atualiza recebe um id e uma entidade
        int ProximoId(); // Retorna o proximo id

    }
}