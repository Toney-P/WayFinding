using Foundation;
using System;
using UIKit;

namespace WayFinding
{
	public partial class NewsCell : UITableViewCell
	{
		public NewsCell(IntPtr handle) : base(handle)
		{
		}

		internal void UpdateCell(News news_s)
		{
			NewsName.Text = news_s.FullName;

			infor.Text = news_s.infor;
		}
	}
}