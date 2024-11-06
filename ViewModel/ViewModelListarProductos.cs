using ExamenWPF.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamenWPF.Utilitarios;
using System.Windows.Input;

namespace ExamenWPF.ViewModel
{
    public class ViewModelListarProductos : ViewModelBase
    {
        #region Propiedades
        private string _nombre;
        public string Nombre
        {
            get { return _nombre; }
            set
            {
                _nombre = value;
                OnPropertyChanged(nameof(Nombre));
            }
        }

        private int _precio;
        public int Precio
        {
            get { return _precio; }
            set
            {
                _precio = value;
                OnPropertyChanged(nameof(Precio));
            }
        }

        private string _descripcion;
        public string Descripcion
        {
            get { return _descripcion; }
            set
            {
                _descripcion = value;
                OnPropertyChanged(nameof(Descripcion));
            }
        }
     
        public ObservableCollection<Producto> Productos { get; set; }
        public ICommand AgregarProductoCommand { get; }

        #endregion

        #region Constructor
        public ViewModelListarProductos()
        {
            AgregarProductoCommand = new RelayCommand(AgregarProducto);
            Productos = new ObservableCollection<Producto>();
        }
        #endregion

        #region Logica
        private void AgregarProducto()
        {
            Productos.Add(new Producto
            {
                Nombre = this.Nombre,
                Precio = this.Precio,
                Descripcion = this.Descripcion
            });
            Limpiar();
        }

        private void Limpiar()
        {
            this.Nombre = "";
            this.Descripcion = "";
            this.Precio = 0;
        }
        #endregion

    }
}
