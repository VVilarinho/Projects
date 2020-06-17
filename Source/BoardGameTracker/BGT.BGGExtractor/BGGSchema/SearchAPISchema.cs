using System.Collections.Generic;
using System.Xml.Serialization;

namespace BGT.BGG.Extractor.BGGSchema.SearchResult
{
	[XmlRoot(ElementName = "name")]
	public class Name
	{
		[XmlAttribute(AttributeName = "primary")]
		public string Primary { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgame")]
	public class Boardgame
	{
		[XmlElement(ElementName = "name")]
		public Name Name { get; set; }
		[XmlElement(ElementName = "yearpublished")]
		public string Yearpublished { get; set; }
		[XmlAttribute(AttributeName = "objectid")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "boardgames")]
	public class Boardgames
	{
		[XmlElement(ElementName = "boardgame")]
		public List<Boardgame> Boardgame { get; set; }
		[XmlAttribute(AttributeName = "termsofuse")]
		public string Termsofuse { get; set; }
	}

}
