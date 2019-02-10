using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Stimulsoft.Report;
using Stimulsoft.Report.Dictionary;
using Stimulsoft.Report.Mvc;
using Stimulsoft.Report.Web;
using System;
using System.Data;
using System.IO;

namespace NetCoreApplication.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}

		public IActionResult GetReport()
		{
			var report = new StiReport();
			var path = StiNetCoreHelper.MapPath(this, "Reports/Report.mrt");
			report.Load(path);

			return StiNetCoreViewer.GetReportResult(this, report);
		}

		public IActionResult ViewerEvent()
		{
			return StiNetCoreViewer.ViewerEventResult(this);
		}
	}
}