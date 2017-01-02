using System;
using System.Collections.Generic;

namespace Hamilton.PCL
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
	}
}