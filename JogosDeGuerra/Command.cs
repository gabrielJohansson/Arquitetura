﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosDeGuerra
{
    public interface Command
    {
        void Execute();
        void Undo();
    }

    public class CommandCriarGuerreiro
        : Command
    {
        AbstractFactoryExercito Factory { get; set; }

        List<ElementosDoExercito> Elementos { get; set; }
        
        public ElementosDoExercito Elemento { get; set;}
        public CommandCriarGuerreiro(AbstractFactoryExercito factory,List<ElementosDoExercito>elementos)
        {
            this.Elementos = elementos;
            this.Factory = Factory;
        }
        public void Execute()
        {
            this.Elemento = Factory.CriarGuerreiro();
            Elementos.Add(this.Elemento);
        }

        public void Undo()
        {
            Elementos.Remove(this.Elemento);
        }
    }
    public class CommandCriarCavalaria
       : Command
    {
        AbstractFactoryExercito Factory { get; set; }

        List<ElementosDoExercito> Elementos { get; set; }

        public ElementosDoExercito Elemento { get; set; }
        public CommandCriarCavalaria(AbstractFactoryExercito factory, List<ElementosDoExercito> elementos)
        {
            this.Elementos = elementos;
            this.Factory = Factory;
        }
        public void Execute()
        {
            this.Elemento = Factory.CriarCavalaria();
            Elementos.Add(this.Elemento);
        }

        public void Undo()
        {
            Elementos.Remove(this.Elemento);
        }
    }
    public class CommandCriarArqueiro
       : Command
    {
        AbstractFactoryExercito Factory { get; set; }

        List<ElementosDoExercito> Elementos { get; set; }

        public ElementosDoExercito Elemento { get; set; }
        public CommandCriarArqueiro(AbstractFactoryExercito factory, List<ElementosDoExercito> elementos)
        {
            this.Elementos = elementos;
            this.Factory = Factory;
        }
        public void Execute()
        {
            this.Elemento = Factory.CriarArqueiro();
            Elementos.Add(this.Elemento);
        }

        public void Undo()
        {
            Elementos.Remove(this.Elemento);
        }
    }
}
