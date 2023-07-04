using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;
using UNAN.Logica;

namespace UNAN.Datos
{
    public class DRecuperacion
    {
        private SmtpClient smtpClient;
        protected string remitenteCorreo { get; set; }
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port{ get; set; }
        protected bool ssl { get; set; }

        protected void initialzeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials=new NetworkCredential(remitenteCorreo, password);
            smtpClient.Host=host;
            smtpClient.Port=port;
            smtpClient.EnableSsl=ssl;
        }

        public void enviarCorreo(string subject,string body,List<string> destinatarioCorreo)
        {
            var MsjCorreo = new MailMessage();
            try
            {
                MsjCorreo.From = new MailAddress(remitenteCorreo);
                foreach (string mail in destinatarioCorreo)
                {
                    MsjCorreo.To.Add(mail);
                }
                MsjCorreo.Subject = subject;
                MsjCorreo.Body=body;
                MsjCorreo.Priority = MailPriority.Normal;
                smtpClient.Send(MsjCorreo);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                MsjCorreo.Dispose();
                smtpClient.Dispose();
            }
        }
        public string recoverPassword(string usuarioSolicitado)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("Correo", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dato", usuarioSolicitado);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.CommandType = CommandType.Text;

                if (reader.HasRows)
                {
                    reader.Read();
                    string estadoUsuario = reader.GetString(reader.GetOrdinal("Estado"));
                    if (estadoUsuario == "ACTIVO")
                    {
                        string nombreUsuario = reader.GetString(1);
                        string correoUsuario = reader.GetString(2);
                        string passUsuario = reader.GetString(6);

                        var mailservice = new DCorreoSoporte();
                        mailservice.enviarCorreo(
                            subject: "KFDAsist: Solicitud de recuperación de Contraseña",
                            body: "Hola, " + nombreUsuario + "\nUsted solicitó recuperar su contraseña.\n" +
                            "\nSu contraseña actual es: " + Encrip.DesEncriptar(Encrip.DesEncriptar(passUsuario)) +
                            "\n" +
                            "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez ingrese al sistema..." +
                            "\n" +
                            "\nSi no está seguro de si usted o su administrador ha realizado este restablecimiento," +
                            " debe ponerse en contacto con su administrador inmediatamente",
                            destinatarioCorreo: new List<string> { correoUsuario });

                        return "Hola, " + nombreUsuario + "\nUsted solicitó recuperar su contraseña.\n" +
                            "Por favor revise su correo: " + correoUsuario +
                            "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez ingrese al sistema...";
                    }
                    else
                    {
                        return "Este usuario no cuenta con una cuenta activa";
                    }
                }
                else
                {
                    return "Lo sentimos, no tiene una cuenta con ese correo o nombre de usuario";
                }
            }
            catch (Exception ex)
            {
                return "ERROR, Algo anda mal: " + ex.Message;
            }
            finally
            {
                Conexion.cerrar();
            }
        }
        public string NotificacionCambio(string usuarioSolicitado)
        {
            try
            {
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("Correo", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dato", usuarioSolicitado);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.CommandType = CommandType.Text;

                if (reader.HasRows)
                {
                    reader.Read();
                    string estadoUsuario = reader.GetString(reader.GetOrdinal("Estado"));
                    if (estadoUsuario == "ACTIVO")
                    {
                        string nombreUsuario = reader.GetString(1);
                        string correoUsuario = reader.GetString(2);
                        string passUsuario = reader.GetString(6);

                        var mailservice = new DCorreoSoporte();
                        mailservice.enviarCorreo(
                            subject: "KFDAsist: Notificación de seguridad",
                            body: "Hola, estimado/a " + nombreUsuario + "\nLos datos de su cuenta en KFDAsist ha cambiado recientemente.\n" +
                            "\nLe informamos que se ha hecho un cambio en su cuenta, si usted realizó dicho cambio ignore este correo," +
                            "\nPero si usted no ha realizado ningún cambio en su cuenta," +
                            "\n" +
                            "\nLe pedimos que cambie su contraseña inmediatamente una vez ingrese al sistema..." +
                            "\n" +
                            "\nSi no está seguro de si usted o su administrador ha realizado este cambio," +
                            " debe ponerse en contacto con su administrador inmediatamente",
                            destinatarioCorreo: new List<string> { correoUsuario });

                        return "Hola, " + nombreUsuario + "\nUsted solicitó recuperar su contraseña.\n" +
                            "Por favor revise su correo: " + correoUsuario +
                            "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez ingrese al sistema...";
                    }
                    else
                    {
                        return "Este usuario no cuenta con una cuenta activa";
                    }
                }
                else
                {
                    return "Lo sentimos, no tiene una cuenta con ese correo o nombre de usuario";
                }
            }
            catch (Exception ex)
            {
                return "ERROR, Algo anda mal: " + ex.Message;
            }
            finally
            {
                Conexion.cerrar();
            }
        }

    }
}
