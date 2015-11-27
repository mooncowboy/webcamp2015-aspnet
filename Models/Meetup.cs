using System;
using System.Collections.Generic;

namespace meetups.Models 
{
	public class Meetup 
	{
		public string Name { get; set; }
		public Uri Link { get; set; }
		public string Image { get; set; }
		public string Description { get; set; }
		
		public static IEnumerable<Meetup> GetAll() {
			return new Meetup[] {
				new Meetup { Name = "Meetup 1", Description = "Desc" }
				
			};
		}	
	}
}