using System;

namespace Humana.H1.JobService.Common.DataTransferObjects
{
	/// <summary>
	/// Summary description for JobQDefDTO.
	/// </summary>
	public class JobQDefDTO
	{
		public JobQDefDTO()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private int _JobID;
		private string _JobDefIdent;
		private string _Title;
		private string _Description; 
		private string _XMLLocation; 
		private string _PDFLocation;
		private string _ScriptToCall;
		private string _WebServiceURL;			//added on 2007/06/29 by Jason McKee (JMM3599)
		private int    _MaxTimeToCompletion; 
		private string _OnErrorEmail; 
		private bool   _JobOwnsStatuses;
		private bool   _UseJobQIDasOnlyParam; 
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
		private string _Param1Type;
		private string _Param2Type;
		private string _Param3Type;
		private string _Param4Type;
		private string _Param5Type;
		private string _Param6Type;
		private string _Param7Type;
		private string _Param8Type;
		private string _Param9Type;
		private string _Param10Type;
		private string _XMLDocument;
		private DateTime _RunAfter;
		private int _RetryMax;
		private int _RetryDelay;
		private bool _AllowRetries;
		private bool _JobOwnsRetries; 
		private bool _JobOwnsErrorEmail;
	
	
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

		public string Title
		{
			set{_Title = value;}
			get{return _Title;}
		}

		public string Description
		{
			set{_Description = value;}
			get{return _Description;}
		}	
	
		public string XMLLocation
		{
			set{_XMLLocation = value;}
			get{return _XMLLocation;}
		}

		public string PDFLocation
		{
			set{_PDFLocation = value;}
			get{return _PDFLocation;}
		}

		public string ScriptToCall
		{
			set{_ScriptToCall = value;}
			get{return _ScriptToCall;}
		}	
	
		/// <summary>
		/// Added by Jason McKee (JMM3599) adding ability for JobService to call a web service
		/// </summary>			
		public string WebServiceURL
		{
			get{ return _WebServiceURL;}
			set{ _WebServiceURL = value;}
		}

		public int MaxTimeToCompletion
		{
			set{_MaxTimeToCompletion = value;}
			get{return _MaxTimeToCompletion;}
		}	

		public string OnErrorEmail
		{
			set{_OnErrorEmail = value;}
			get{return _OnErrorEmail;}
		}	
		
		public bool JobOwnsStatuses
		{
			set{_JobOwnsStatuses = value;}
			get{return _JobOwnsStatuses;}
		}	

		public bool UseJobQIDasOnlyParam
		{
			set{_UseJobQIDasOnlyParam = value;}
			get{return _UseJobQIDasOnlyParam;}
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

		public string Param1Type
		{
			set{_Param1Type = value;}
			get{return _Param1Type;}
		}
		public string Param2Type
		{
			set{_Param2Type = value;}
			get{return _Param2Type;}
		}
		public string Param3Type
		{
			set{_Param3Type = value;}
			get{return _Param3Type;}
		}
		public string Param4Type
		{
			set{_Param4Type = value;}
			get{return _Param4Type;}
		}
		public string Param5Type
		{
			set{_Param5Type = value;}
			get{return _Param5Type;}
		}
		public string Param6Type
		{
			set{_Param6Type = value;}
			get{return _Param6Type;}
		}
		public string Param7Type
		{
			set{_Param7Type = value;}
			get{return _Param7Type;}
		}
		public string Param8Type
		{
			set{_Param8Type = value;}
			get{return _Param8Type;}
		}
		public string Param9Type
		{
			set{_Param9Type = value;}
			get{return _Param9Type;}
		}
		public string Param10Type
		{
			set{_Param10Type = value;}
			get{return _Param10Type;}
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

		public bool JobOwnsErrorEmail
		{
			set{_JobOwnsErrorEmail = value;}
			get{return _JobOwnsErrorEmail;}
		}
		
	}
}

