﻿using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	[StringEnum]
	public enum DateInterval
	{
		[EnumMember(Value = "second")]
		Second,

		[EnumMember(Value = "minute")]
		Minute,

		[EnumMember(Value = "hour")]
		Hour,

		[EnumMember(Value = "day")]
		Day,

		[EnumMember(Value = "week")]
		Week,

		[EnumMember(Value = "month")]
		Month,

		[EnumMember(Value = "quarter")]
		Quarter,

		[EnumMember(Value = "year")]
		Year
	}
}
