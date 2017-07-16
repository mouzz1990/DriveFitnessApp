using System;

namespace MPK_Calendar
{
	/// <summary>
	/// Event argument class.
	/// </summary>
	public class SelectedDateChangedEventArgs:EventArgs
	{
		private DateTime pSelectedDate;

		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="dateSelected">Date</param>
		public SelectedDateChangedEventArgs(DateTime dateSelected)
		{
			pSelectedDate = dateSelected;
		}

		/// <summary>
		/// The selected date.
		/// </summary>
		public DateTime SelectedDate
		{
			get
			{
				return pSelectedDate;
			}
		}

	}
}
