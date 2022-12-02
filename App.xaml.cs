using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Tp_Synthèse_B
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        public static Dictionary<int, Clothes> Products = new Dictionary<int, Clothes>()
        {
            {0,new Clothes(0,"chandail","C'est le meilleur chandail sur terre!",24.99,new List<string>(){"noir","rouge"}, new List<string>(){"xs","s","m","xl"},5) }
        };
    }
}
