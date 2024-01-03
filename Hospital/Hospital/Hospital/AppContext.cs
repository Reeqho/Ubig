using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Application = System.Windows.Forms.Application;

namespace Hospital
{
    class AppContext : ApplicationContext
    {
        public AppContext(Form form)
        {
            form.FormClosed += Form_FormClosed;
            form.Show();
        }

        private void Form_FormClosed(object sender, FormClosedEventArgs e)
        {
            int count = Application.OpenForms.Cast<Form>().Where(f => f.TopLevel).Count();
            if (count == 0)
            {
                Application.Exit();
                ExitThread();
            }
        }
    }
}
