using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UNAN.Datos
{
    public class DCorreoSoporte:DRecuperacion
    {
        public DCorreoSoporte()
        {
            remitenteCorreo = "lfelixlopez732@gmail.com";
            password = "ckcfjpjydmpyiwjy";
            host = "smtp,gmail.com";
            port = 587;
            ssl= true;
            initialzeSmtpClient();
        }
    }
}
