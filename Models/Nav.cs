using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SugarStock.Models
{
    internal class Nav
    {
        private static Stack<Form> forms = new Stack<Form>();

        public static void NavigateTo(Form form)
        {
            if (forms.Count > 0)
            {
                forms.Peek().Hide(); 
            }
            forms.Push(form);
            form.Show();
        }

        public static void GoBack()
        {
            if (forms.Count > 0)
            {
                Form currentForm = forms.Pop();
                currentForm.Hide();
                if (forms.Count > 0)
                {
                    forms.Peek().Show(); 
                }
            }
        }
    }
}
