using System;
using System.Collections.Generic;
using UIKit;

namespace WayFinding
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			var news = new List<News> {
				new News{
					FullName = "News1",
					infor = "The chart below shows information about changes in 1989."
				},
			    new News{
					FullName = "News2",
					infor = "wqeqwewqeqweqweqweqweqweqweqweqweqweqweqw"
				},new News{
					FullName = "News1",
					infor = "wqeqwewqeqweqweqweqweqweqweqweqweqweqweqw"
				},
				new News{
					FullName = "News2",
					infor = "wqeqwewqeqweqweqweqweqweqweqweqweqweqweqw"
				},
				new News{
					FullName = "News1",
					infor = "wqeqwewqeqweqweqweqweqweqweqweqweqweqweqw"
				},
				new News{
					FullName = "News2",
					infor = "wqeqwewqeqweqweqweqweqweqweqweqweqweqweqw"
				},
				new News{
					FullName = "News1",
					infor = "wqeq wewqeq weqweqweqw eqweqweqweqweqweqweqw"
				},
				new News{
					FullName = "News2",
					infor = "wqeqwewqeqweqweqweqweqweqweqweqweqweqweqw"
				},

			};
			NewsTableView.Source = new NewsTVS(news);

			NewsTableView.RowHeight = UITableView.AutomaticDimension;
			NewsTableView.EstimatedRowHeight = 40f;
			NewsTableView.ReloadData();
		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
