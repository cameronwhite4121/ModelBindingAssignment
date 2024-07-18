using System.ComponentModel.DataAnnotations;
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
		[Required(ErrorMessage = "Song name can't be empty")]
		public string Name { get; set; }

		/// <summary>
		/// Album song was featured in. If the song was a single,
		/// "Single" should be the value for Album.
		/// </summary>
		[Required(ErrorMessage = "Song album can't be empty")]
		public string Album { get; set; }

		/// <summary>
		/// Name of the band or the artist that the song
		/// is credited to.
		/// </summary>
		[Required(ErrorMessage = "Song artist can't be empty")]
		public string Artist { get; set; }

		/// <summary>
		/// Length of the song in minutes. Rounded off to 2
		/// decimal places. Length can't be negative but can
		/// be 0 for cases when song length isn't known yet.
		/// Max value is 8400 or 140 hrs. Worlds longest song
		/// is 138 hours long. That's a real fact.
		/// </summary>
		[Range(0, 8400)]
		public double Length 
		{
			get { return Length; }
			set { Length = Math.Round(value, 2); }
		}

	}
}
