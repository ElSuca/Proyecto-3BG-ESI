using System;

namespace ApiPublicidad
{
    public class AddManager
    {
        public int getBanner()
        {
            Random random = new Random();
            int BannerSelection = random.Next(3);
            return BannerSelection;
        }
    }
}
