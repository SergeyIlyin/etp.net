// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.Core
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class ProtocolException : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""ProtocolException"",""namespace"":""Energistics.Etp.v12.Protocol.Core"",""fields"":[{""name"":""errorCode"",""type"":""int""},{""name"":""errorMessage"",""type"":""string""}],""messageType"":""1000"",""protocol"":""0"",""senderRole"":""*"",""protocolRoles"":""client,server"",""fullName"":""Energistics.Etp.v12.Protocol.Core.ProtocolException"",""depends"":[]}");
		private int _errorCode;
		private string _errorMessage;
		public virtual Schema Schema
		{
			get
			{
				return ProtocolException._SCHEMA;
			}
		}
		public int ErrorCode
		{
			get
			{
				return this._errorCode;
			}
			set
			{
				this._errorCode = value;
			}
		}
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
			set
			{
				this._errorMessage = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._errorCode;
			case 1: return this._errorMessage;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._errorCode = (System.Int32)fieldValue; break;
			case 1: this._errorMessage = (System.String)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}