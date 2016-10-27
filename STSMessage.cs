using System;
using System.Collections;

namespace Humana.H1.JobService.Common
{
	/// <summary>
	/// Summary description for CMMessage.
	/// </summary>
	public class STSMessage
	{
		private STSMessage()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		public STSMessage(object msg,MessageTypes msgType)
		{
			_msg=msg;
			_msgType=msgType;
		}

		public override string ToString()
		{
			if (_msg!=null)
                return _msgType.ToString() + ":: " + Message;
			else
				return string.Empty;
		}

		public string Message
		{
			get
			{
				if (_msg!=null)
				{
					Exception exc=_msg as Exception;
					if (exc!=null)
						return exc.Message;
					else
						return _msg.ToString();
				}
				else
					return string.Empty;
			}
		}
		
		public object MessageObj
		{
			get
			{
				if (_msg!=null)
					return _msg;
				else
					return string.Empty;
			}
		}
		
		public MessageTypes MessageType
		{
			get
			{
				return _msgType;
			}
		}

		public bool IsError
		{
			get
			{
				return (MessageType&MessageTypes.Error)==MessageTypes.Error;
			}
		}

		public ReportTypes SetReportTypes(ReportTypes rptType)
		{
			return SetReportTypes(rptType,true);
		}

		public ReportTypes SetReportTypes(ReportTypes rptType, bool val)
		{
			if (val)
				_rptType|=rptType;
			else
			{
				//TO DO: reset code comes here
			}
			return _rptType;
		}

		public void ResetReportTypes()
		{
			_rptType=ReportTypes.None;
		}

		private object _msg=null;
		private MessageTypes _msgType=MessageTypes.None;
		private ReportTypes _rptType=ReportTypes.None;
		
		public virtual void Clear()
		{
			_msg=null;
			_msgType=MessageTypes.None;
		}
	}
}
