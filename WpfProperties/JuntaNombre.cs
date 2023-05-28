using System;
using System.ComponentModel;

public class JuntaNombre : INotifyPropertyChanged
{

	private string nombre, apellido, nombre_completo;

    public event PropertyChangedEventHandler? PropertyChanged;

    private void OnPropertyChanged(string property)
    {
        if (PropertyChanged != null)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(property));
        }
    }

    public string Nombre
    { 
        get { return nombre; }
        set 
        { 
            nombre = value;
            OnPropertyChanged("Nombre_Completo"); 
        }
    }

    public string Apellido
    {
        get { return apellido; }
        set
        {
            apellido = value;
            OnPropertyChanged("Nombre_Completo");
        }
    }

    public string Nombre_Completo
    {
        get
        {
            nombre_completo = Nombre + " " + Apellido;
            return nombre_completo;
        }
        set { }
    }
}
