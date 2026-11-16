using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion;

public partial class MainWindow : Window
{
    private bool saludoAlterno = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void BtnPresentarme_Click(object? sender, RoutedEventArgs e)
    {
        string nombre = TxtNombre.Text ?? "";
        string apellido = TxtApellido.Text ?? "";

        if (string.IsNullOrWhiteSpace(nombre))
        {
            TxtResultado.Text = "⚠ Debes escribir tu nombre.";
            return;
        }

        if (string.IsNullOrWhiteSpace(apellido))
        {
            TxtResultado.Text = "⚠ Debes escribir tu apellido.";
            return;
        }

        int edad;
        if (!int.TryParse(TxtEdad.Text, out edad))
        {
            TxtResultado.Text = "⚠ La edad debe ser un número.";
            return;
        }

        if (edad <= 0)
        {
            TxtResultado.Text = "⚠ La edad debe ser mayor que cero.";
            return;
        }

        if (saludoAlterno)
        {
            TxtResultado.Text = $"¡Buenas! Soy {nombre.Trim()} {apellido.Trim()},\n" +
                                $"tengo {edad} años y me gusta\n" +
                                "crear aplicaciones con Avalonia.";
        }
        else
        {
            TxtResultado.Text = $"¡Hola! Mi nombre es {nombre.Trim()} {apellido.Trim()},\n" +
                                $"tengo {edad} años y estoy aprendiendo\n" +
                                "a desarrollar interfaces gráficas con C#.";
        }
    }

    private void BtnLimpiar_Click(object? sender, RoutedEventArgs e)
    {
        TxtNombre.Text = "";
        TxtApellido.Text = "";
        TxtEdad.Text = "";
        TxtResultado.Text = "Completa tus datos y presiona Presentarme.";
        TxtNombre.Focus();
    }

    private void BtnCambiarSaludo_Click(object? sender, RoutedEventArgs e)
    {
        saludoAlterno = !saludoAlterno;
        BtnPresentarme_Click(sender, e);
    }
}
