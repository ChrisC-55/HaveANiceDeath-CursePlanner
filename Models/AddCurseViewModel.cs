namespace HaveANiceDeath.Models
{
    public class AddCurseViewModel
    {
        public string CurseName { get; set; }
        public string CurseColor { get; set; }
        public string CurseRarity { get; set; }
        public string CurseType { get; set; }
        public string CurseDescription { get; set; }
        public int CurseRank { get; set; }
        public IFormFile CurseImage { get; set; }
    }
}
