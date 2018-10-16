using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogosDeGuerra
{
    public class CommandManager
    {
        Stack<Command> Comandos { get; set; }

        Stack<Command> RedoComandos { get; set; }

        public void Execute(Command command)
        {
            command.Execute();
            this.Comandos.Push(command);
            this.RedoComandos.Clear();
        }

        public void Undo()
        {
            Command cmd = this.Comandos.Pop();
            cmd.Undo();
            this.RedoComandos.Push(cmd);
        }

        public void Redo()
        {
            Command cmd=this.RedoComandos.Pop();
            cmd.Execute();
            this.Comandos.Push(cmd);
        }
    }
}
