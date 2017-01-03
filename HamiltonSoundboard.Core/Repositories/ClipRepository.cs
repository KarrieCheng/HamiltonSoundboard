using System;
using System.Collections.Generic;
using System.Linq;

namespace HamiltonSoundboard.Core
{
	public class ClipRepository
	{
		public ClipRepository()
		{
		}

		public List<Clip> GetAllClips()
		{
			IEnumerable<Clip> clips =

				from clip in Clips
				select clip;
			return clips.ToList<Clip>();
		}

		public Clip GetClipById(int clipId)
		{
			IEnumerable<Clip> clips =
				from clip in Clips
				where clip.ClipID == clipId
				select clip;
			return clips.FirstOrDefault();
		}


		private static List<Clip> Clips = new List<Clip>()
		{
			new Clip()
			{
				ClipID = 1,
				Quote = "How'd you graduate so fast",
				Song = "Aaron Burr, Sir",
				Filename = "ab1.mp3",
				Character = "Alexander Hamilton",
				LastUsed = DateTime.Now
			},
			new Clip()
			{
				ClipID = 2,
				Quote = "It was my parent's dying wish before they passed",
				Song = "Aaron Burr, Sir",
				Filename = "ab2.mp3",
				Character = "Aaron Burr",
				LastUsed = DateTime.Now
			}
		};
	}
}