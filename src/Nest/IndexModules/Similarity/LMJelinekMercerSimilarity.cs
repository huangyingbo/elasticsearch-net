﻿using System.Runtime.Serialization;
using Elasticsearch.Net;

namespace Nest
{
	/// <summary>
	/// A similarity that attempts to capture important patterns in the text,
	/// while leaving out noise.
	/// </summary>
	public interface ILMJelinekMercerSimilarity : ISimilarity
	{
		/// <summary>
		/// The lambda parameter
		/// </summary>
		[DataMember(Name ="lambda")]
		[JsonFormatter(typeof(NullableStringDoubleFormatter))]
		double? Lambda { get; set; }
	}

	/// <inheritdoc />
	public class LMJelinekMercerSimilarity : ILMJelinekMercerSimilarity
	{
		/// <inheritdoc />
		public double? Lambda { get; set; }

		public string Type => "LMJelinekMercer";
	}

	/// <inheritdoc />
	public class LMJelinekMercerSimilarityDescriptor
		: DescriptorBase<LMJelinekMercerSimilarityDescriptor, ILMJelinekMercerSimilarity>, ILMJelinekMercerSimilarity
	{
		double? ILMJelinekMercerSimilarity.Lambda { get; set; }
		string ISimilarity.Type => "LMJelinekMercer";

		/// <inheritdoc />
		public LMJelinekMercerSimilarityDescriptor Lamdba(double? lamda) => Assign(lamda, (a, v) => a.Lambda = v);
	}
}
