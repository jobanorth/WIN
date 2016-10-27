using System;

namespace Humana.H1.JobService.Common.DataTransferObjects
{
	/// <summary>
	/// Summary description for JobQ.
	/// </summary>
	public class JobQDTO
	{
		public JobQDTO()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private int _JobQID;
		private int _UserID;
		private int _JobID;
		private string _JobDefIdent;
		private DateTime _JobSubmitted;
		private DateTime _JobStarted;
		private DateTime _JobEnded;
		private string _JobErrorStatus;
		private string _JobMessages;
		private string _Progress;
		private bool _SuccessfulCompletion;
		private string _Param1;
		private string _Param2;
		private string _Param3;
		private string _Param4;
		private string _Param5;
		private string _Param6;
		private string _Param7;
		private string _Param8;
		private string _Param9;
		private string _Param10;
		private string _XMLDocument;
		private DateTime _RunAfter;
		private int _RetryMax;
		private int _RetryDelay;
		private bool _AllowRetries;
		private bool _JobOwnsRetries; 
		private int _RetryCount;
		


	
		public struct JobUpdateOptions
		{
			public const string SUBJOB_PASS = "1";
			public const string SUBJOB_FAIL = "2";
			public const string JOB_SUCCESS = "3";
		}


		public  int JobQID
		{
			set{_JobQID = value;}
			get{return _JobQID;}
		}
		public int UserID
		{
			set{_UserID = value;}
			get{return _UserID;}
		}
		public int JobID
		{
			set{_JobID = value;}
			get{return _JobID;}
		}
		public string JobDefIdent
		{
			set{_JobDefIdent = value;}
			get{return _JobDefIdent;}
		}
		public DateTime JobSubmitted
		{
			set{_JobSubmitted = value;}
			get{return _JobSubmitted;}
		}
		public DateTime JobStarted
		{
			set{_JobStarted = value;}
			get{return _JobStarted;}
		}
		public DateTime JobEnded
		{
			set{_JobEnded = value;}
			get{return _JobEnded;}
		}
		public string JobErrorStatus
		{
			set{_JobErrorStatus = value;}
			get{return _JobErrorStatus;}
		}
		public string JobMessages
		{
			set{_JobMessages = value;}
			get{return _JobMessages;}
		}
		public string Progress
		{
			set{_Progress = value;}
			get{return _Progress;}
		}
		public bool SuccessfulCompletion
		{
			set{_SuccessfulCompletion = value;}
			get{return _SuccessfulCompletion;}
		}
		public string Param1
		{
			set{_Param1 = value;}
			get{return _Param1;}
		}
		public string Param2
		{
			set{_Param2 = value;}
			get{return _Param2;}
		}
		public string Param3
		{
			set{_Param3 = value;}
			get{return _Param3;}
		}
		public string Param4
		{
			set{_Param4 = value;}
			get{return _Param4;}
		}
		public string Param5
		{
			set{_Param5 = value;}
			get{return _Param5;}
		}
		public string Param6
		{
			set{_Param6 = value;}
			get{return _Param6;}
		}
		public string Param7
		{
			set{_Param7 = value;}
			get{return _Param7;}
		}
		public string Param8
		{
			set{_Param8 = value;}
			get{return _Param8;}
		}
		public string Param9
		{
			set{_Param9 = value;}
			get{return _Param9;}
		}
		public string Param10
		{
			set{_Param10 = value;}
			get{return _Param10;}
		}
		public string XMLDocument
		{
			set{_XMLDocument = value;}
			get{return _XMLDocument;}
		}
		public DateTime RunAfter
		{
			set{_RunAfter = value;}
			get{return _RunAfter;}
		}

		public int RetryMax
		{
			set{_RetryMax = value;}
			get{return _RetryMax;}
		}

		public int RetryDelay
		{
			set{_RetryDelay = value;}
			get{return _RetryDelay;}
		}
		
		public bool AllowRetries
		{
			set{_AllowRetries = value;}
			get{return _AllowRetries;}
		}

		public bool JobOwnsRetries
		{
			set{_JobOwnsRetries = value;}
			get{return _JobOwnsRetries;}
		}

		public int RetryCount
		{
			set{_RetryCount = value;}
			get{return _RetryCount;}
		}
		
	}
}
