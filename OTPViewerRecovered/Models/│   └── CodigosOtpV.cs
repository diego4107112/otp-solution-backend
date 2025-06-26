using Microsoft.EntityFrameworkCore; // Asegúrate de tener este using
using System.ComponentModel.DataAnnotations.Schema;

namespace OTPViewerRecovered.Models
{
    [Keyless]
    [Table("CODIGOS_OTP_V", Schema = "DW")]
    public class CodigosOtpV
    {
        public DateTime Fecha { get; set; }
        public string CodigoOtp { get; set; }
        public string Estatus { get; set; }
        public string OrigenOperacion { get; set; }
        public string TiempoExpiracion { get; set; }
        public string TelefonoCelular { get; set; }
    }
}
