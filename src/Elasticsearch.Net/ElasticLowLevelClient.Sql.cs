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
namespace Elasticsearch.Net.Apis.SqlApi
{
	///<summary>
	/// Logically groups all Sql API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticLowLevelClient.Sql"/> property
	/// on <see cref = "IElasticLowLevelClient"/>.
	///</para>
	///</summary>
	public class LowLevelSqlNamespace : NamespacedClientProxy
	{
		internal LowLevelSqlNamespace(ElasticLowLevelClient client): base(client)
		{
		}

		///<summary>POST on /_sql/close <para>Clear SQL cursor</para></summary>
		///<param name = "body">Specify the cursor value in the `cursor` element to clean the cursor.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse ClearSqlCursor<TResponse>(PostData body, ClearSqlCursorRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_sql/close", body, RequestParams(requestParameters));
		///<summary>POST on /_sql/close <para>Clear SQL cursor</para></summary>
		///<param name = "body">Specify the cursor value in the `cursor` element to clean the cursor.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> ClearSqlCursorAsync<TResponse>(PostData body, ClearSqlCursorRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_sql/close", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_sql <para>Execute SQL</para></summary>
		///<param name = "body">Use the `query` element to start a query. Use the `cursor` element to continue a query.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse QuerySql<TResponse>(PostData body, QuerySqlRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_sql", body, RequestParams(requestParameters));
		///<summary>POST on /_sql <para>Execute SQL</para></summary>
		///<param name = "body">Use the `query` element to start a query. Use the `cursor` element to continue a query.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> QuerySqlAsync<TResponse>(PostData body, QuerySqlRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_sql", ctx, body, RequestParams(requestParameters));
		///<summary>POST on /_sql/translate <para>Translate SQL into Elasticsearch queries</para></summary>
		///<param name = "body">Specify the query in the `query` element.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public TResponse TranslateSql<TResponse>(PostData body, TranslateSqlRequestParameters requestParameters = null)
			where TResponse : class, IElasticsearchResponse, new() => DoRequest<TResponse>(POST, "_sql/translate", body, RequestParams(requestParameters));
		///<summary>POST on /_sql/translate <para>Translate SQL into Elasticsearch queries</para></summary>
		///<param name = "body">Specify the query in the `query` element.</param>
		///<param name = "requestParameters">Request specific configuration such as querystring parameters &amp; request specific connection settings.</param>
		public Task<TResponse> TranslateSqlAsync<TResponse>(PostData body, TranslateSqlRequestParameters requestParameters = null, CancellationToken ctx = default)
			where TResponse : class, IElasticsearchResponse, new() => DoRequestAsync<TResponse>(POST, "_sql/translate", ctx, body, RequestParams(requestParameters));
	}
}