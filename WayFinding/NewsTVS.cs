using System;
using System.Collections.Generic;
using Foundation;
using UIKit;

namespace WayFinding
{
	class NewsTVS : UITableViewSource
	{
		List<News> news;

		public NewsTVS(List<News> news)
		{
			this.news = news;
		}

		public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
		{
			var cell =(NewsCell) tableView.DequeueReusableCell("cell_id", indexPath);
			var news_s = news[indexPath.Row];
			cell.UpdateCell(news_s);
			return cell;
		}

		public override nint RowsInSection(UITableView tableview, nint section)
		{
			return news.Count;	
			
			}
		
	}
}