using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Postgres_Viewer
{
    public class UIManager
    {
        
        public string GetLowestSelectedItemText(ListBox listBox)
        {
            if (listBox.SelectedIndices.Count > 0)
            {
                int lowestIndex = listBox.SelectedIndices[0];
                foreach (int index in listBox.SelectedIndices)
                {
                    if (index < lowestIndex)
                    {
                        lowestIndex = index;
                    }
                }
                return listBox.Items[lowestIndex].ToString();
            }
            else {
                return "";
            }
        }

        

    }
}
