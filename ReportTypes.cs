using System;

namespace Humana.H1.JobService.Common
{
	/// <summary>
	/// Summary description for ReportTypes.
	/// </summary>
	[Flags]
	public enum ReportTypes
	{
		None=0x00,
		Debug=0x01,
		EventLog=0x02,
		LogFile=0x04,
		ToolTip=0x08,
		Dialog=0x10,
		Database=0x20,
		Email=0x40,
		Ftp=0x80
	}
}
