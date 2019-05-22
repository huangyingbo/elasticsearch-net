using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net;
using static Elasticsearch.Net.HttpMethod;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Apis.CrossClusterReplicationApi
{
	///<summary>
	/// Logically groups all CrossClusterReplication API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticLowLevelClient.CrossClusterReplication"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelCrossClusterReplicationNamespace : NamespacedClientProxy
	{
		internal LowLevelCrossClusterReplicationNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>DELETE on /_ccr/auto_follow/{name} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html</para></summary>
		///<param name = "name">The name of the auto follow pattern.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse DeleteAutoFollowPattern<TResponse>(string name, DeleteAutoFollowPatternRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(DELETE, Url($"_ccr/auto_follow/{name:name}"), null, RequestParams(requestParameters));
		///<summary>DELETE on /_ccr/auto_follow/{name} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-delete-auto-follow-pattern.html</para></summary>
		///<param name = "name">The name of the auto follow pattern.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> DeleteAutoFollowPatternAsync<TResponse>(string name, DeleteAutoFollowPatternRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(DELETE, Url($"_ccr/auto_follow/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_ccr/follow <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html</para></summary>
		///<param name = "index">The name of the follower index</param>
		///<param name = "body">The name of the leader index and other optional ccr related parameters</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse CreateFollowIndex<TResponse>(string index, PostData body, CreateFollowIndexRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"{index:index}/_ccr/follow"), body, RequestParams(requestParameters));
		///<summary>PUT on /{index}/_ccr/follow <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-follow.html</para></summary>
		///<param name = "index">The name of the follower index</param>
		///<param name = "body">The name of the leader index and other optional ccr related parameters</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> CreateFollowIndexAsync<TResponse>(string index, PostData body, CreateFollowIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"{index:index}/_ccr/follow"), ctx, body, RequestParams(requestParameters));
		///<summary>GET on /{index}/_ccr/stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html</para></summary>
		///<param name = "index">A comma-separated list of index patterns; use `_all` to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse FollowIndexStats<TResponse>(string index, FollowIndexStatsRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"{index:index}/_ccr/stats"), null, RequestParams(requestParameters));
		///<summary>GET on /{index}/_ccr/stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-follow-stats.html</para></summary>
		///<param name = "index">A comma-separated list of index patterns; use `_all` to perform the operation on all indices</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> FollowIndexStatsAsync<TResponse>(string index, FollowIndexStatsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"{index:index}/_ccr/stats"), ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ccr/auto_follow <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetAutoFollowPattern<TResponse>(GetAutoFollowPatternRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_ccr/auto_follow", null, RequestParams(requestParameters));
		///<summary>GET on /_ccr/auto_follow <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GetAutoFollowPatternAsync<TResponse>(GetAutoFollowPatternRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_ccr/auto_follow", ctx, null, RequestParams(requestParameters));
		///<summary>GET on /_ccr/auto_follow/{name} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</para></summary>
		///<param name = "name">The name of the auto follow pattern.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse GetAutoFollowPattern<TResponse>(string name, GetAutoFollowPatternRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, Url($"_ccr/auto_follow/{name:name}"), null, RequestParams(requestParameters));
		///<summary>GET on /_ccr/auto_follow/{name} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-auto-follow-pattern.html</para></summary>
		///<param name = "name">The name of the auto follow pattern.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> GetAutoFollowPatternAsync<TResponse>(string name, GetAutoFollowPatternRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, Url($"_ccr/auto_follow/{name:name}"), ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ccr/pause_follow <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html</para></summary>
		///<param name = "index">The name of the follower index that should pause following its leader index.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse PauseFollowIndex<TResponse>(string index, PauseFollowIndexRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_ccr/pause_follow"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ccr/pause_follow <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-pause-follow.html</para></summary>
		///<param name = "index">The name of the follower index that should pause following its leader index.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> PauseFollowIndexAsync<TResponse>(string index, PauseFollowIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_ccr/pause_follow"), ctx, null, RequestParams(requestParameters));
		///<summary>PUT on /_ccr/auto_follow/{name} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html</para></summary>
		///<param name = "name">The name of the auto follow pattern.</param>
		///<param name = "body">The specification of the auto follow pattern</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse CreateAutoFollowPattern<TResponse>(string name, PostData body, CreateAutoFollowPatternRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(PUT, Url($"_ccr/auto_follow/{name:name}"), body, RequestParams(requestParameters));
		///<summary>PUT on /_ccr/auto_follow/{name} <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-put-auto-follow-pattern.html</para></summary>
		///<param name = "name">The name of the auto follow pattern.</param>
		///<param name = "body">The specification of the auto follow pattern</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> CreateAutoFollowPatternAsync<TResponse>(string name, PostData body, CreateAutoFollowPatternRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(PUT, Url($"_ccr/auto_follow/{name:name}"), ctx, body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ccr/resume_follow <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html</para></summary>
		///<param name = "index">The name of the follow index to resume following.</param>
		///<param name = "body">The name of the leader index and other optional ccr related parameters</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ResumeFollowIndex<TResponse>(string index, PostData body, ResumeFollowIndexRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_ccr/resume_follow"), body, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ccr/resume_follow <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-post-resume-follow.html</para></summary>
		///<param name = "index">The name of the follow index to resume following.</param>
		///<param name = "body">The name of the leader index and other optional ccr related parameters</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> ResumeFollowIndexAsync<TResponse>(string index, PostData body, ResumeFollowIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_ccr/resume_follow"), ctx, body, RequestParams(requestParameters));
		///<summary>GET on /_ccr/stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse CcrStats<TResponse>(CcrStatsRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(GET, "_ccr/stats", null, RequestParams(requestParameters));
		///<summary>GET on /_ccr/stats <para>https://www.elastic.co/guide/en/elasticsearch/reference/current/ccr-get-stats.html</para></summary>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> CcrStatsAsync<TResponse>(CcrStatsRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(GET, "_ccr/stats", ctx, null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ccr/unfollow <para>http://www.elastic.co/guide/en/elasticsearch/reference/current</para></summary>
		///<param name = "index">The name of the follower index that should be turned into a regular index.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse UnfollowIndex<TResponse>(string index, UnfollowIndexRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, Url($"{index:index}/_ccr/unfollow"), null, RequestParams(requestParameters));
		///<summary>POST on /{index}/_ccr/unfollow <para>http://www.elastic.co/guide/en/elasticsearch/reference/current</para></summary>
		///<param name = "index">The name of the follower index that should be turned into a regular index.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> UnfollowIndexAsync<TResponse>(string index, UnfollowIndexRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, Url($"{index:index}/_ccr/unfollow"), ctx, null, RequestParams(requestParameters));
	}
}