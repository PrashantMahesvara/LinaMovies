namespace LinaMovies.Web.Dto
{
    public class MovieDto
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string AltTitle { get; set; }

        public int Released { get; set; }

        public int? RunningTimeInMinutes { get; set; }

        public string Description { get; set; }

        public bool Animated { get; set; }

        public GenreDto Genre { get; set; }
        public byte GenreId { get; set; }

        public FormatDto Format { get; set; }
        public byte FormatId { get; set; }
    }
}