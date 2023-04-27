using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public int GameNo { get; set; }
        public string GameName { get; set; }
        public string GameDescription { get; set; }
        public byte GamePicture { get; set; }
        public DateTime DateReleased { get; set; }
        public double Price { get; set; }
        public int Available { get; set; }
    }
}