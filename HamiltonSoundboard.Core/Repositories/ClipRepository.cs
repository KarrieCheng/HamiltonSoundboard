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
				Quote = "I am not throwing away my shot \n I am not throwing away my shot",
				Song = "Aaron Burr, Sir",
				Filename = "1-03_1",
				Character ="Alexander Hamilton",
				LastUsed = DateTime.Now
			},
			new Clip()
			{
				ClipID = 2,
				Quote = "Yo, I’m just like my country \n I’m young, scrappy and hungry \n And I’m not throwing away my shot",
				Song = "Aaron Burr, Sir",
				Filename = "1-03_2",
				Character = "Aaron Burr",
				LastUsed = DateTime.Now
			},
            new Clip(){
                ClipID = 3,
                Quote = "You’ve got to be carefully taught \n If you talk, you’re gonna get shot",
                Song = "Aaron Burr, Sir",
                Filename = "1-03_3",
                Character = "Alexander Hamilton",
                LastUsed = DateTime.Now
            },
            new Clip(){
                ClipID = 4,
                Quote = "We’ll bleed and fight for you, we’ll make it right for you",
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