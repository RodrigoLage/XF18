﻿using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace App2_TRF.Modelos
{
  public  class GerenciadorTarefa
    {

        private List<Tarefa> Lista { get; set; }

        public void Salvar(Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.Add(tarefa);
            SalvarNoProperties(Lista); 
        }

        public void Deletar(Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.Remove(tarefa);
            SalvarNoProperties(Lista);
        }

        public void Finalizar(int index, Tarefa tarefa)
        {
            Lista = Listagem();
            Lista.RemoveAt(index);
            
            Lista.Add(tarefa);
            SalvarNoProperties(Lista);
        }

        public List<Tarefa> Listagem()
        {
            return ListagemNoProperties();
        }

        private void SalvarNoProperties(List<Tarefa> Lista)
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                App.Current.Properties.Remove("Tarefas");
            }

            string JsonVal =  JsonConvert.SerializeObject(Lista);

            App.Current.Properties.Add("Tarefas", JsonVal);
        }

        private List<Tarefa> ListagemNoProperties()
        {
            if (App.Current.Properties.ContainsKey("Tarefas"))
            {
                string JsonVal = (string)App.Current.Properties["Tarefas"];

                List<Tarefa> Lista = JsonConvert.DeserializeObject<List<Tarefa>>(JsonVal);

                return Lista;
            }

            return new List<Tarefa>();
        }

    }
}