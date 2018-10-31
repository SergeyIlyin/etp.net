// ------------------------------------------------------------------------------
// <auto-generated>
//    Generated by avrogen.exe, version 0.9.0.0
//    Changes to this file may cause incorrect behavior and will be lost if code
//    is regenerated
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Energistics.Etp.v12.Protocol.ChannelSubscribe
{
	using System;
	using System.Collections.Generic;
	using System.Text;
	using Avro;
	using Avro.Specific;
	
	public partial class SubscriptionStopped : ISpecificRecord
	{
		public static Schema _SCHEMA = Avro.Schema.Parse(@"{""type"":""record"",""name"":""SubscriptionStopped"",""namespace"":""Energistics.Etp.v12.Protocol.ChannelSubscribe"",""fields"":[{""name"":""channelIds"",""type"":{""type"":""array"",""items"":""long""}}],""protocol"":""21"",""messageType"":""8"",""senderRole"":""consumer"",""protocolRoles"":""producer,consumer"",""multipartFlag"":""True"",""fullName"":""Energistics.Etp.v12.Protocol.ChannelSubscribe.SubscriptionStopped"",""depends"":[]}");
		private IList<System.Int64> _channelIds;
		public virtual Schema Schema
		{
			get
			{
				return SubscriptionStopped._SCHEMA;
			}
		}
		public IList<System.Int64> ChannelIds
		{
			get
			{
				return this._channelIds;
			}
			set
			{
				this._channelIds = value;
			}
		}
		public virtual object Get(int fieldPos)
		{
			switch (fieldPos)
			{
			case 0: return this._channelIds;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Get()");
			};
		}
		public virtual void Put(int fieldPos, object fieldValue)
		{
			switch (fieldPos)
			{
			case 0: this._channelIds = (IList<System.Int64>)fieldValue; break;
			default: throw new AvroRuntimeException("Bad index " + fieldPos + " in Put()");
			};
		}
	}
}