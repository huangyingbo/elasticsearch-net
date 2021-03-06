﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using Elasticsearch.Net;


namespace Nest
{
	public class MigrationAssistanceResponse : ResponseBase
	{
		[DataMember(Name ="indices")]
		public IReadOnlyDictionary<IndexName, IndexUpgradeCheck> Indices { get; internal set; } =
			EmptyReadOnly<IndexName, IndexUpgradeCheck>.Dictionary;
	}

	public class IndexUpgradeCheck
	{
		[DataMember(Name ="action_required")]
		public UpgradeActionRequired ActionRequired { get; internal set; }
	}

	[StringEnum]
	public enum UpgradeActionRequired
	{
		[EnumMember(Value = "not_applicable")]
		NotApplicable,

		[EnumMember(Value = "up_to_date")]
		UpToDate,

		[EnumMember(Value = "reindex")]
		Reindex,

		[EnumMember(Value = "upgrade")]
		Upgrade
	}
}
