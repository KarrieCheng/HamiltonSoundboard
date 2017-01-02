using System;
namespace Hamilton.PCL
{
	public class Clip
	{
		public Clip()
		{
		}
		public int ClipID { get; set; }
		public String Quote { get; set; }
		public String Song { get; set; }
		public String Filename { get; set; }
		public String Character { get; set; }
		public DateTime LastUsed { get; set; }
	}
}