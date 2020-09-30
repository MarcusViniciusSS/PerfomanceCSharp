using System;
using System.Text;

namespace CallCenter.Extensions
{
    public static class DateTimeExtensions
    {
        private static readonly Random RND = new Random();

        public static string GenerateProtocolOriginal(this DateTime entity)
        {
            var year = entity.Year;
            var month = entity.Month;
            var day = entity.Day;
            var hour = entity.Hour;
            var minute = entity.Minute;
            var second = entity.Second;

            Random rnd = new Random();
            int rndNumber = rnd.Next(12, 999999);

            return $"{year}{month}{day}{hour}{minute}{second}{rndNumber}";
        }


        public static string GenerateProtocolV1(this DateTime entity)
        {
            Random rnd = new Random();
            int rndNumber = rnd.Next(12, 999999);

            return $"{entity.Year}{entity.Month}{entity.Day}{entity.Hour}{entity.Minute}{entity.Second}{rndNumber}";
        }

        public static string GenerateProtocolV2(this DateTime entity) => $"{entity.Year}{entity.Month}{entity.Day}{entity.Hour}{entity.Minute}{entity.Second}{RND.Next(12, 999999)}";

        public static string GenerateProtocolV3(this DateTime entity)
        {
            var sb = new StringBuilder()
                 .Append(entity.Year)
                 .Append(entity.Month)
                 .Append(entity.Day)
                 .Append(entity.Hour)
                 .Append(entity.Minute)
                 .Append(entity.Second)
                 .Append(RND.Next(12, 999999));

            return sb.ToString();
        }

        public static string GenerateProtocolLastest(this DateTime entity)
        {
            return new StringBuilder()
                 .Append(entity.Year)
                 .Append(entity.Month)
                 .Append(entity.Day)
                 .Append(entity.Hour)
                 .Append(entity.Minute)
                 .Append(entity.Second)
                 .Append(RND.Next(12, 999999))
                 .ToString();
        }
    }
}
