using System.Reflection.Metadata.Ecma335;

namespace ModelBindingAssignment.Models
{
	/// <summary>
	/// Represents one song
	/// </summary>
	public class Song
	{
		/// <summary>
		/// Song's title, or name
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Album song was featured in. If the song was a single,
		/// "Single" should be the value for Album.
		/// </summary>
		public string Album { get; set; }

		/// <summary>
		/// Name of the band or the artist that the song
		/// is credited to.
		/// </summary>
		public string Artist { get; set; }

		/// <summary>
		/// Length of the song in minutes. Rounded off to 2
		/// decimal places.
		/// </summary>
		public double Length 
		{
			get { return Length; }
			set { Length = Math.Round(value, 2); }
		}

	}
}
