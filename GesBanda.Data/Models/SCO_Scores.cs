namespace GesBanda.Data.Models
{
    public class SCO_Scores
    {
        public int Id { get; set; }
        public int? ComposerId { get; set; }
        public int? ComposerArrId { get; set; }
        public int? GenreId { get; set; }
        public int? CXArchive { get; set; }
        public int? PartNumber { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public string DataOfAcquisition { get; set; }
    }

}
