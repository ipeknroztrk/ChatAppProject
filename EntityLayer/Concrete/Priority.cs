using System;

namespace EntityLayer.Concrete
{
    public class Priority
    {
        public int Id { get; set; } // Birincil anahtar

        public string Name { get; set; }

        public PriorityLevel Level { get; set; }

        public enum PriorityLevel
        {
            Düşük,
            Orta,
            Yüksek
        }
        public string GetColorCode()
        {
            switch (Level)
            {
                case PriorityLevel.Düşük:
                    return "#32CD32"; // Yeşil
                case PriorityLevel.Orta:
                    return "#FFA500"; // Turuncu
                case PriorityLevel.Yüksek
:
                    return "#FF0000"; // Kırmızı
                default:
                    return "#000000"; // Varsayılan olarak siyah
            }
        }
    }
}
