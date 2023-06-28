using System;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

public static class Validaciones
{
    private static readonly Random random = new Random();
    private const string UpperCaseLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    private const string LowerCaseLetters = "abcdefghijklmnopqrstuvwxyz";
    private const string Numbers = "0123456789";
    private const string SpecialCharacters = "!@#$%^&*()";

    public static void ActualizarVisibilidadEtiquetas(string contra, Label lblMayu, Label lblMin, Label lblNum, Label lblCarEsp)
    {
        bool mayuscula = false, minuscula = false, numero = false, caracespecial = false;

        foreach (char c in contra)
        {
            if (char.IsUpper(c))
            {
                mayuscula = true;
            }
            else if (char.IsLower(c))
            {
                minuscula = true;
            }
            else if (char.IsDigit(c))
            {
                numero = true;
            }
            else if (SpecialCharacters.Contains(c))
            {
                caracespecial = true;
            }
        }

        lblMayu.Visible = !mayuscula;
        lblMin.Visible = !minuscula;
        lblNum.Visible = !numero;
        lblCarEsp.Visible = !caracespecial;
    }

    public static string GenerarContraseñaAleatoria()
    {
        int longitud = 8; // Longitud mínima de la contraseña
        string caracteres = UpperCaseLetters + LowerCaseLetters + Numbers + SpecialCharacters;

        // Asegurarse de que la contraseña cumpla con los criterios mínimos
        while (true)
        {
            StringBuilder contraseña = new StringBuilder();
            contraseña.Append(RandomCharacter(UpperCaseLetters));
            contraseña.Append(RandomCharacter(LowerCaseLetters));
            contraseña.Append(RandomCharacter(Numbers));
            contraseña.Append(RandomCharacter(SpecialCharacters));

            // Generar caracteres aleatorios adicionales
            for (int i = 4; i < longitud; i++)
            {
                contraseña.Append(RandomCharacter(caracteres));
            }

            // Mezclar los caracteres aleatoriamente
            contraseña = new StringBuilder(new string(contraseña.ToString().ToCharArray().OrderBy(c => random.Next()).ToArray()));

            // Comprobar si la contraseña cumple con los criterios
            if (ContraseñaCumpleCriterios(contraseña.ToString()))
            {
                return contraseña.ToString();
            }
        }
    }

    private static char RandomCharacter(string caracteres)
    {
        int indice = random.Next(0, caracteres.Length);
        return caracteres[indice];
    }

    public static bool ContraseñaCumpleCriterios(string contraseña)
    {
        bool mayuscula = false, minuscula = false, numero = false, caracespecial = false;

        foreach (char c in contraseña)
        {
            if (char.IsUpper(c))
            {
                mayuscula = true;
            }
            else if (char.IsLower(c))
            {
                minuscula = true;
            }
            else if (char.IsDigit(c))
            {
                numero = true;
            }
            else if (SpecialCharacters.Contains(c))
            {
                caracespecial = true;
            }
        }
        return mayuscula && minuscula && numero && caracespecial;
    }
    public static bool EsCorreoValido(string correo)
    {
        // Expresión regular para validar el formato del correo
        string patronCorreo = @"^[a-zA-Z0-9_.+-]+@(gmail\.com|yahoo\.com|hotmail\.com|estu\.unan\.edu\.ni|\w+\.(com|es|net|org))$";

        // Realizar la validación del formato utilizando la expresión regular
        bool formatoValido = System.Text.RegularExpressions.Regex.IsMatch(correo, patronCorreo);

        // Retorna el resultado de la validación de formato
        return formatoValido;
    }

    public static string GenerarUsuario(string nombreApellidos)
    {
        // Obtener los nombres y apellidos separados
        var partes = nombreApellidos.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        // Validar que exista al menos un nombre y un apellido
        if (partes.Length < 2)
        {
            return string.Empty;
        }

        // Generar el usuario con el primer nombre, un punto y las iniciales del segundo nombre y los apellidos
        string usuario = partes[0] + ".";

        for (int i = 1; i < partes.Length; i++)
        {
            usuario += partes[i][0];
        }

        return usuario;
    }

    public static bool ValidarLabelsVerdes(Label lblNombreApellidos, Label lblIdentificacion, Label lblCelular, Label lblCorreo, Label lblUsuario)
    {
        return lblNombreApellidos.ForeColor == Color.Green
            && lblIdentificacion.ForeColor == Color.Green
            && lblCelular.ForeColor == Color.Green
            && lblCorreo.ForeColor == Color.Green
            && lblUsuario.ForeColor == Color.Green;
    }
}
