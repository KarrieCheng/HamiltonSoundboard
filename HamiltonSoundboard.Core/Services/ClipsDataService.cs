using System;
using System.Collections.Generic;

namespace HamiltonSoundboard.Core
{
	public class ClipsDataService
	{
		private static ClipRepository clipsRepository = new ClipRepository();
		public ClipsDataService()
		{
		}
		public List<Clip> GetAllClips()
		{
			return clipsRepository.GetAllClips();
		}
        public Clip GetClipById(int clipId)
        {
            return clipsRepository.GetClipById(clipId);
        }
	}
}