using System;
using System.Collections;

namespace Humana.H1.JobService.Common
{
	/// <summary>
	/// Summary description for CMMessage.
	/// </summary>
	public class STSMessages
	{
		public STSMessages()
		{
			//
			// TODO: Add constructor logic here
			//
			EmptyMessages();
		}

		public void AddError(object err)
		{
			AddMessage(new STSMessage(err,MessageTypes.Error));
		}

		public void AddInfo(object info)
		{
			AddMessage(new STSMessage(info,MessageTypes.Information));
		}

		public void AddWarning(object warning)
		{
			AddMessage(new STSMessage(warning,MessageTypes.Warning));
		}

		public void AddSqlQuery(object sqlQuery)
		{
			AddMessage(new STSMessage(sqlQuery,MessageTypes.SqlQuery));
		}

		public void AddDebug(object debug)
		{
			AddMessage(new STSMessage(debug,MessageTypes.Debug));
		}

		public void AddMessages(STSMessage [] cmMsgs)
		{
			msgs.AddRange(cmMsgs);
		}
        
        public void AddMessages(STSMessages cmMsgs)
        {
            msgs.AddRange(cmMsgs.msgs);
        }

		public void AddMessage(STSMessage cmMsg)
		{
			msgs.Add(cmMsg);
		}

		public virtual void Clear()
		{
			EmptyMessages();
		}

		public virtual void EmptyMessages()
		{
			if (msgs==null)
				msgs=new ArrayList();
			else
				msgs.Clear();
		}

		public virtual int  MessageCount
		{
			get
			{
				return msgs.Count;
			}
		}

		public virtual ArrayList GetMessages()
		{
			return msgs;
		}

		public virtual string LastMessage
		{
			get
			{
				string errMsg=string.Empty;
				foreach(STSMessage item in msgs)
				{
					errMsg+=item.Message+System.Environment.NewLine;
				}
                if (msgs.Count > 0)
                    errMsg += "Message Counts: " + msgs.Count.ToString();
				return errMsg;
			}
		}

		//for backward compatibility
		public virtual string LastErrMsg
		{
			get
			{
				string errMsg=string.Empty;
				foreach(STSMessage item in msgs)
				{
					if (item.IsError)
						errMsg+=item.Message+System.Environment.NewLine;
				}
				return errMsg;
			}
		}

		public virtual bool IsAnyError
		{
			get
			{
				return msgs.Count>0;
			}
		}

		private ArrayList msgs;
	}
}
