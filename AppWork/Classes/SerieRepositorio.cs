using System;
using System.Collections.Generic;
using AppWork.Interfaces;

namespace AppWork
{
    public class SerieRepositorio : IRepositorio<Serie> // Endando de IRepositorio e imprementando a class Serie, imprementa uma classe de repositorios de series
    {
        private List<Serie> listaSerie = new List<Serie>(); // Lista que vai conter todas as series
        public void Atualiza(int id, Serie objeto)
        {
            listaSerie[id] = objeto;
        }

        public void Exclui(int id)
        {
            listaSerie[id].Excluir();
            // Imprementar envio de email
        }

        public void Insere(Serie objeto)
        {
            listaSerie.Add(objeto);
        }

        public List<Serie> Lista()
        {
            return listaSerie;
        }

        public int ProximoId()
        {
            return listaSerie.Count;
        }

        public Serie RetornaPorId(int id)
        {
            return listaSerie[id];
        }
    }
}