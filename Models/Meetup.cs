using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Microsoft.AspNet.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace meetups.Models 
{
	public class Meetup 
	{
		[JsonProperty("name")]
		public string Name { get; set; }
		
		[JsonProperty("link")]
		public Uri Link { get; set; }
		
		[JsonProperty("image")]
		public string Image { get; set; }
		
		[JsonProperty("description")]
		public string Description { get; set; }
		
		public string SafeDescription 
		{ 
			get 
			{
				return Regex.Replace(Description, @"<[^>]+>|&nbsp;", "").Trim();
			}
		}
		
		public static IEnumerable<Meetup> GetAll(string path) {
			//var dataDir = AppDomain.CurrentDomain.GetData("DataDirectory");
			var jsonText = File.ReadAllText(path);
			var meetupList = JsonConvert.DeserializeObject<IList<Meetup>>(jsonText);
			return meetupList;
			
			// using(var reader = File.OpenText("~/doc/meetups-lisbon.json"))
			// {
			// 	var meetupsJson = (JObject) JToken.ReadFrom(new JsonTextReader(reader));
			// }
			
			// return new Meetup[] {
			// 	new Meetup { Name = "Meetup 1", Description = "Desc" }
			// 	
			// };
		}	
	}
}