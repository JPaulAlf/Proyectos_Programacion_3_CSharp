using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UTN.Winform.SnackMachines.Util
{

    static class Utilitarios
    {

        /// <summary>
        /// Configura el CultureInfo de la Pc para fechas y decimales
        /// </summary>
        public static void CulturaInfo()
        {
            // Colocar Cultura Estandar para Costa Rica
            // esto me permite no tener problemas con (.) de los decimales
            CultureInfo Micultura = new CultureInfo("es-CR", false);
            Micultura.NumberFormat.CurrencySymbol = "¢";
            Micultura.NumberFormat.CurrencyDecimalDigits = 2;
            Micultura.NumberFormat.CurrencyDecimalSeparator = ".";
            Micultura.NumberFormat.CurrencyGroupSeparator = ",";
            int[] grupo = new int[] { 3, 3, 3 };
            Micultura.NumberFormat.CurrencyGroupSizes = grupo;
            Micultura.NumberFormat.NumberDecimalDigits = 2;
            Micultura.NumberFormat.NumberGroupSeparator = ",";
            Micultura.NumberFormat.NumberDecimalSeparator = ".";
            Micultura.NumberFormat.NumberGroupSizes = grupo;
            //Micultura.DateTimeFormat.
            Thread.CurrentThread.CurrentCulture = Micultura;

        }

        /// <summary>
        /// Envía un correo electrónico
        /// </summary>
        //public static void EnviarCorreo(string pSubject,
        //                               string pBody,
        //                               string pFrom,
        //                               string pEmailDestino,
        //                               string pUsuario,
        //                               string pContrasena,
        //                               string pRutaArchivo)        //{

        //    MailMessage mensaje = new MailMessage();
        //    mensaje.IsBodyHtml = true; 
        //    mensaje.Subject = pSubject
        //    mensaje.Body = pBody
        //    mensaje.From = new MailAddress(pFrom);  
        //    mensaje.To.Add(pEmailDestino);  
        //    SmtpClient smtp = new SmtpClient("smtp.gmail.com"); // NO TOCAR
        //    smtp.Port = 587;  //  NO TOCAR
        //    smtp.Credentials = new NetworkCredential(pUsuario, pContrasena); // Usuario y  Contrasena de la cuenta de su correo.
        //    smtp.EnableSsl = true; // NO TOCAR
        //    if (!string.IsNullOrEmpty(pRutaArchivo)){
        //        Attachment attachment = new Attachment(@"c:\temp\archivo.xml"); //
        //        mensaje.Attachments.Add(attachment);
        //    } 
        //    smtp.Send(mensaje);
        //}


        /// <summary>
        /// Sirve para reproducir por los parlante el mensaje
        /// </summary>
        ///// <param name="pMensaje">Cadena de Texto</param>
        //public void Speak(string pMensaje)
        //{
        //    SpeechSynthesizer voice = new SpeechSynthesizer();
        //    voice.Volume = 90;
        //    voice.Rate = -3;
        //    voice.SpeakAsync(pMensaje);
        //}


        // Acceso a Dll
        [DllImport("winmm.dll")]
        private static extern long mciSendString(string strCommand, StringBuilder strReturn, int iReturnLength, IntPtr hwndCallback);
        /// <summary>
        /// Reproduce un sonido utilizando el API de Windows
        /// Más APIS en https://msdn.microsoft.com/en-us/library/windows/desktop/hh920508(v=vs.85).aspx
        /// </summary>
        /// <param name="pRutaArchivo"></param>
        public static void PlaySoundApi(string pRutaArchivo)
        {
            mciSendString("open \"" + pRutaArchivo + "\" type mpegvideo alias MediaFile", null, 0, IntPtr.Zero);
            mciSendString("play MediaFile", null, 0, IntPtr.Zero);
        }


        /// <summary>
        /// Reproduce un sonido utilizando .NET
        /// </summary>
        /// <param name="pRutaArchivo"></param>
        public static void PlaySound(string pRutaArchivo)
        {
            SoundPlayer sonido = new SoundPlayer(pRutaArchivo);
            sonido.Play();

        }

        /// <summary>
        /// Utiliza el speaker para reproducir los datos incluidos.
        /// </summary>
        /// <param name="pDatos">Datos para reproducir</param>
        //public static void Hablar(string pDatos)
        //{

        //    SpeechSynthesizer voice = new SpeechSynthesizer();
        //    voice.Volume = 80;
        //    voice.Rate = -3;
        //    voice.SpeakAsync(pDatos);

        //}

        public static void Hablar(string pDatos)
        {
            SpeechSynthesizer voice = new SpeechSynthesizer();
            voice.Volume = 80;
            voice.Rate = -3;
            voice.SpeakAsync(pDatos);
        }
    }
}
