﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
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
                //SqlCommand cmd = new SqlCommand();
                //cmd.CommandText = "select * from Profesores where Usuario=@Usuario or CorreoP=@CorreoP";
                //string con = "select * from Profesores where Usuario=@Usuario or CorreoP=@CorreoP";
                //cmd = new SqlCommand(con, Conexion.conectar);
                Conexion.abrir();
                SqlCommand cmd = new SqlCommand("Correo", Conexion.conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Dato", usuarioSolicitado);
                SqlDataReader reader = cmd.ExecuteReader();
                cmd.CommandType = CommandType.Text;
                if (reader.Read() == true)
                {
                    string nombreUsuario = reader.GetString(5);
                    string correoUsuario = reader.GetString(2);
                    string passUsuario = reader.GetString(6);
                    var mailservice = new DCorreoSoporte();
                    mailservice.enviarCorreo(
                        subject: "KFDAsist: Solicitud de recuperación de Contraseña",
                        body: "Hola, " + nombreUsuario + "\nUsted solicitó recuperar su contraseña.\n" +
                        "\nsu contraseña actual es: " + Encrip.DesEncriptar(Encrip.DesEncriptar(passUsuario)) +
                        "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez ingrese al sistema...",
                        destinatarioCorreo: new List<string> { correoUsuario });
                    return "Hola, " + nombreUsuario + "\nUsted solicitó recuperar su contraseña.\n" +
                        "Por favor revise su correo: " + correoUsuario +
                        "\nSin embargo, le pedimos que cambie su contraseña inmediatamente una vez ingrese al sistema...";
                }
                else
                {
                    return "Lo sentimos, no tiene una cuenta con ese correo o nombre del usuario";
                }
            }
            catch (Exception ex)
            {
                return "ERROR, Algo anda mal " + ex.Message;
            }
            finally
            {
                Conexion.cerrar();
            }
            
        }
    }
}