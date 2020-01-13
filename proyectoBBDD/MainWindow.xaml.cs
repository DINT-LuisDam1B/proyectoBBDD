using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace proyectoBBDD
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            tema6bdluisEntities contexto = new tema6bdluisEntities();
            contexto.CLIENTES.Load();

            //enlazar origen de datos con datacontex de listbox
            listadoDeDatos_ListBox.DataContext = contexto.CLIENTES.Local;

            //enlazar origend de datos con itemsourse de combobox
            eliminar_Combobox.ItemsSource = contexto.CLIENTES.Local;
            //update
        }
    }
}
