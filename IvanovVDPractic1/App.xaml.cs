using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace IvanovVDPractic1
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
            public static IvanovPractic1BDEntities db = new IvanovPractic1BDEntities();
            public static UsersData LoggedUser;
    }
}
