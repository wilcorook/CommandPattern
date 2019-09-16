using System;
using System.Collections;
using System.Collections.Generic;

namespace CommandPattern
{
    public class Remote
    {
        private readonly Stack<List<ICommand>> _commands;
        private List<ICommand> _btn1;
        private List<ICommand> _btn2;
        private List<ICommand> _btn3;
        private List<ICommand> _btn4;
        private List<ICommand> _btn5;
        private List<ICommand> _btn6;
        private List<ICommand> _btn7;
        private List<ICommand> _btn8;
        private List<ICommand> _btn9;

        public Remote()
        {
            _commands = new Stack<List<ICommand>>();
            _btn1 = new List<ICommand>();
            _btn2 = new List<ICommand>();
            _btn3 = new List<ICommand>();
            _btn4 = new List<ICommand>();
            _btn5 = new List<ICommand>();
            _btn6 = new List<ICommand>();
            _btn7 = new List<ICommand>();
            _btn8 = new List<ICommand>();
            _btn9 = new List<ICommand>();
        }

        public void SetButton(int button, ICommand command)
        {
            switch (button)
            {
                case 1:
                    _btn1.Add(command);
                    break;
                
                case 2:
                    _btn2.Add(command);
                    break;
                
                case 3:
                    _btn3.Add(command);
                    break;
                
                case 4:
                    _btn4.Add(command);
                    break;
                
                case 5:
                    _btn5.Add(command);
                    break;
                
                case 6:
                    _btn6.Add(command);
                    break;
                
                case 7:
                    _btn7.Add(command);
                    break;
                
                case 8:
                    _btn8.Add(command);
                    break;
                
                case 9:
                    _btn9.Add(command);
                    break;
                
                default:
                    Console.WriteLine("Choose a valid button");
                    break;
            }
        }
        
        public void PressButton(int button)
        {
            switch (button)
            {
                case 1:
                    _commands.Push(_btn1);
                    foreach (var c in _btn1)
                    {
                        c.Execute();
                    }
                    break;
                
                case 2:
                    _commands.Push(_btn2);
                    foreach (var c in _btn2)
                    {
                        c.Execute();
                    }
                    break;
                
                case 3:
                    _commands.Push(_btn3);
                    foreach (var c in _btn3)
                    {
                        c.Execute();
                    }
                    break;
                
                case 4:
                    _commands.Push(_btn4);
                    foreach (var c in _btn4)
                    {
                        c.Execute();
                    }
                    break;
                
                case 5:
                    _commands.Push(_btn5);
                    foreach (var c in _btn5)
                    {
                        c.Execute();
                    }
                    break;
                
                case 6:
                    _commands.Push(_btn6);
                    foreach (var c in _btn6)
                    {
                        c.Execute();
                    }
                    break;
                
                case 7:
                    _commands.Push(_btn7);
                    foreach (var c in _btn7)
                    {
                        c.Execute();
                    }
                    break;
                
                case 8:
                    _commands.Push(_btn8);
                    foreach (var c in _btn8)
                    {
                        c.Execute();
                    }
                    break;
                
                case 9:
                    _commands.Push(_btn9);
                    foreach (var c in _btn9)
                    {
                        c.Execute();
                    }
                    break;
                
                default:
                    Console.WriteLine("Choose a valid button");
                    break;
            }

            Console.WriteLine($"Button {button} pressed");
        }

        public void ClearButton(int button)
        {
            switch (button)
            {
                case 1:
                    _btn1.Clear();
                    break;

                case 2:
                    _btn2.Clear();
                    break;

                case 3:
                    _btn3.Clear();
                    break;

                case 4:
                    _btn4.Clear();
                    break;

                case 5:
                    _btn5.Clear();
                    break;

                case 6:
                    _btn6.Clear();
                    break;

                case 7:
                    _btn7.Clear();
                    break;

                case 8:
                    _btn8.Clear();
                    break;

                case 9:
                    _btn9.Clear();
                    break;

                default:
                    Console.WriteLine("Choose a valid button");
                    break;
            }
        }

        public void Undo()
        {
            var lastCommand = _commands.Pop();
            foreach (var c in lastCommand)
            {
                c.Undo();
            }
            Console.WriteLine("Undoing last button press");
        }
    }
}