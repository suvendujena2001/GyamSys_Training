using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeviewProgram1
{
    public class Reflectobjects
    {
		public void LoadForm(string form, Form F)
		{
            try
            {
                Type objectType = (from asm in AppDomain.
           CurrentDomain.GetAssemblies()
           from type in asm.GetTypes()
           where type.IsClass && type.Name == form select
           type).Single();
                object obj = Activator.CreateInstance(objectType);
                Form f = obj as Form;
                f.ShowDialog();
            }
            catch (global::System.Exception)
            {

               
            }
        }
      

    }
}
