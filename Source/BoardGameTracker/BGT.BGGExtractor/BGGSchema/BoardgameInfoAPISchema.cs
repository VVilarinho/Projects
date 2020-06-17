using System;
using System.Xml.Serialization;
using System.Collections.Generic;


namespace BGT.BGG.Extractor.BGGSchema.BoardgameResult
{
	[XmlRoot(ElementName = "name")]
	public class Name
	{
		[XmlAttribute(AttributeName = "primary")]
		public string Primary { get; set; }
		[XmlAttribute(AttributeName = "sortindex")]
		public string Sortindex { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "description")]
	public class Description
	{
		[XmlElement(ElementName = "br")]
		public List<string> Br { get; set; }
	}

	[XmlRoot(ElementName = "boardgamepodcastepisode")]
	public class Boardgamepodcastepisode
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgamemechanic")]
	public class Boardgamemechanic
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgamepublisher")]
	public class Boardgamepublisher
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgamedesigner")]
	public class Boardgamedesigner
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgamecategory")]
	public class Boardgamecategory
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgamefamily")]
	public class Boardgamefamily
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgameartist")]
	public class Boardgameartist
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgameversion")]
	public class Boardgameversion
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgameaccessory")]
	public class Boardgameaccessory
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "boardgamesubdomain")]
	public class Boardgamesubdomain
	{
		[XmlAttribute(AttributeName = "objectid")]
		public string Objectid { get; set; }
		[XmlText]
		public string Text { get; set; }
	}

	[XmlRoot(ElementName = "result")]
	public class Result
	{
		[XmlAttribute(AttributeName = "value")]
		public string Value { get; set; }
		[XmlAttribute(AttributeName = "numvotes")]
		public string Numvotes { get; set; }
		[XmlAttribute(AttributeName = "level")]
		public string Level { get; set; }
	}

	[XmlRoot(ElementName = "results")]
	public class Results
	{
		[XmlElement(ElementName = "result")]
		public List<Result> Result { get; set; }
		[XmlAttribute(AttributeName = "numplayers")]
		public string Numplayers { get; set; }
	}

	[XmlRoot(ElementName = "poll")]
	public class Poll
	{
		[XmlElement(ElementName = "results")]
		public List<Results> Results { get; set; }
		[XmlAttribute(AttributeName = "name")]
		public string Name { get; set; }
		[XmlAttribute(AttributeName = "title")]
		public string Title { get; set; }
		[XmlAttribute(AttributeName = "totalvotes")]
		public string Totalvotes { get; set; }
	}

	[XmlRoot(ElementName = "boardgame")]
	public class Boardgame
	{
		[XmlElement(ElementName = "yearpublished")]
		public string Yearpublished { get; set; }
		[XmlElement(ElementName = "minplayers")]
		public string Minplayers { get; set; }
		[XmlElement(ElementName = "maxplayers")]
		public string Maxplayers { get; set; }
		[XmlElement(ElementName = "playingtime")]
		public string Playingtime { get; set; }
		[XmlElement(ElementName = "minplaytime")]
		public string Minplaytime { get; set; }
		[XmlElement(ElementName = "maxplaytime")]
		public string Maxplaytime { get; set; }
		[XmlElement(ElementName = "age")]
		public string Age { get; set; }
		[XmlElement(ElementName = "name")]
		public Name Name { get; set; }
		[XmlElement(ElementName = "description")]
		public string Description { get; set; }
		[XmlElement(ElementName = "thumbnail")]
		public string ThumbnailURL { get; set; }
		[XmlElement(ElementName = "image")]
		public string Image { get; set; }
		[XmlElement(ElementName = "boardgamepodcastepisode")]
		public List<Boardgamepodcastepisode> Boardgamepodcastepisode { get; set; }
		[XmlElement(ElementName = "boardgamemechanic")]
		public List<Boardgamemechanic> Boardgamemechanic { get; set; }
		[XmlElement(ElementName = "boardgamepublisher")]
		public Boardgamepublisher Boardgamepublisher { get; set; }
		[XmlElement(ElementName = "boardgamedesigner")]
		public Boardgamedesigner Boardgamedesigner { get; set; }
		[XmlElement(ElementName = "boardgamecategory")]
		public List<Boardgamecategory> Boardgamecategory { get; set; }
		[XmlElement(ElementName = "boardgamefamily")]
		public List<Boardgamefamily> Boardgamefamily { get; set; }
		[XmlElement(ElementName = "boardgameartist")]
		public List<Boardgameartist> Boardgameartist { get; set; }
		[XmlElement(ElementName = "boardgameversion")]
		public Boardgameversion Boardgameversion { get; set; }
		[XmlElement(ElementName = "boardgameaccessory")]
		public List<Boardgameaccessory> Boardgameaccessory { get; set; }
		[XmlElement(ElementName = "boardgamesubdomain")]
		public Boardgamesubdomain Boardgamesubdomain { get; set; }
		[XmlElement(ElementName = "poll")]
		public List<Poll> Poll { get; set; }
		[XmlAttribute(AttributeName = "objectid")]
		public string Id { get; set; }
	}

	[XmlRoot(ElementName = "boardgames")]
	public class Boardgames
	{
		[XmlElement(ElementName = "boardgame")]
		public Boardgame Boardgame { get; set; }
		[XmlAttribute(AttributeName = "termsofuse")]
		public string Termsofuse { get; set; }
	}

}