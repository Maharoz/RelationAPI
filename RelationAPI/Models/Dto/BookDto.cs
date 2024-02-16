namespace MasjidLibraryAPI.Models.Dto
{
	public class BookDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Volume { get; set; }
		public string Writter { get; set; }
		public string Translator { get; set; }
		public string Editor { get; set; }
		public string Summary { get; set; }
		public string Edition { get; set; }
		public DateTime FirstPublicationDate { get; set; }
		public DateTime CurrentPublicationDate { get; set; }
		public string Language { get; set; }
		public int PageCount { get; set; }
		public decimal Price { get; set; }
		public int CategortyType { get; set; }
		public int BookSubCategortyType { get; set; }
		public string ISBN { get; set; }
		public string Tag { get; set; }
		public string SerialNo { get; set; }
		public DateTime RegistrationDate { get; set; }
		public string CountryOfPublication { get; set; }
		public string EbookLink { get; set; }
        public string Reference { get; set; }
        public string Publication { get; set; }
        public string CoverImageName { get; set; }
        public string TableOfContentImageName { get; set; }
        public string CoverImageUrl { get; set; }

        public string CategortyName { get; set; }
        public List<int> Tags { get; set; }
        public List<string> BookSerial { get; set; }
        public string BookId { get; set; }
    }
}
