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
				Quote = "How'd you do, how'd you graduate so fast",
				Song = "Aaron Burr, Sir",
				Filename = "1-03_1",
				Character ="Alexander Hamilton",
				LastUsed = DateTime.Now
			},
			new Clip()
			{
				ClipID = 2,
				Quote = "It was my parent's dying wish before they passed",
				Song = "Aaron Burr, Sir",
				Filename = "1-03_2",
				Character = "Aaron Burr",
				LastUsed = DateTime.Now
			},
            new Clip(){
                ClipID = 3,
                Quote = "I'm not stupid",
                Song = "Aaron Burr, Sir",
                Filename = "1-03_3",
                Character = "Alexander Hamilton",
                LastUsed = DateTime.Now
            },
            new Clip(){
                ClipID = 4,
                Quote = "CLICK MEEEEE",
                Song = "Dear Theodosia",
                Filename = "1-22_2",
                Character = "Alexander Hamilton",
                LastUsed = DateTime.Now
            },
            new Clip(){
                ClipID = 144,
                Quote = "Take a break!",
                Song = "Take a Break",
                Filename = "2-03_2",
                Character = "Alexander Hamilton",
                LastUsed = DateTime.Now
            }
		};
	}
}