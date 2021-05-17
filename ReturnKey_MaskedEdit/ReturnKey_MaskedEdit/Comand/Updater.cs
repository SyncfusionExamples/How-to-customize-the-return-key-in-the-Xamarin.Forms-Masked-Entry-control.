using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Syncfusion.XForms.MaskedEdit;
using Xamarin.Forms;

namespace ReturnKey_MaskedEdit
{
    class Updater : ICommand
    {
        public event EventHandler CanExecuteChanged;
        #region ICommand Members
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public void Execute(object parameter)
        {
            if(parameter is StackLayout)
            {
                var stack = parameter as StackLayout;
               if ((stack.Children[0] as SfMaskedEdit).Value!=null)
                {
                   (stack.Children[1] as Entry).Focus();
                }
            }
        }
        #endregion
    }
}