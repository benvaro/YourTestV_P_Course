﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfMvvmTest.ViewModel.Comands
{
    public class CreateTestCommand : ICommand
    {
        TeacherVM VM { get; set; }
        public event EventHandler CanExecuteChanged
        {

            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;

            }
        }

        public CreateTestCommand(TeacherVM vm)
        {
            VM = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            VM.CreateTest();
        }
    }
}
