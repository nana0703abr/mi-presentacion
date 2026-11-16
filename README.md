# MiPresentacion

Aplicación de escritorio hecha con Avalonia UI 11 y C#. Permite escribir nombre, apellido y edad, valida los datos y muestra una presentación personalizada.

## Controles utilizados

- **TextBlock**: muestra el título y el mensaje de resultado.
- **TextBox** (TxtNombre, TxtApellido, TxtEdad): cajas donde el usuario escribe sus datos.
- **Button** (Presentarme, Limpiar, Cambiar saludo): ejecutan acciones al presionarlos.
- **StackPanel**: organiza los controles uno debajo del otro (y los botones en horizontal), usando Margin y Spacing.

## Funcionamiento de los eventos

- **Presentarme**: lee los datos, verifica que nombre y apellido no estén vacíos, comprueba con `int.TryParse()` que la edad sea un número mayor que cero, y muestra la presentación o una advertencia.
- **Limpiar**: vacía los tres campos, restaura el mensaje inicial y pone el cursor en el nombre con `Focus()`.
- **Cambiar saludo**: alterna entre dos mensajes de presentación usando una variable `bool`, sin cerrar la aplicación.

## Cómo ejecutar

Requiere .NET 8 SDK.

    dotnet run

## Capturas

![Formulario](capturas/formulario.png)
![Presentación correcta](capturas/caso1.png)
![Advertencia](capturas/caso2.png)

## Reflexión

(pendiente)