using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop_2
{
    internal static class ConvertitoreLitriGalloni
    {
        private const double coefficienteConversioneLitriInGallone = 0.264172;
        private const double coefficienteConversioneGalloneInLitri = 3.78541;
        public static double ConvertiLitriGalloni(double litriDaConvertire)
        {
            double litriConvertiti = litriDaConvertire * coefficienteConversioneLitriInGallone;
            return litriConvertiti;
        }
        public static double ConvertiGalloniLitri(double GalloniDaConvertire)
        {
            double GalloniConvertiti = GalloniDaConvertire * coefficienteConversioneGalloneInLitri;
            return GalloniConvertiti;
        }
    }
}
