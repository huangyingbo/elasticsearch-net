using System;
using System.Threading;
using System.Threading.Tasks;
using Elasticsearch.Net.Specification.TasksApi;

//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Nest.Specification.TasksApi
{
	///<summary>
	/// Logically groups all Tasks API's together so that they may be discovered more naturally.
	/// <para>Not intended to be instantiated directly please defer to the <see cref = "IElasticClient.Tasks"/> property
	/// on <see cref = "IElasticClient"/>.
	///</para>
	///</summary>
	public class TasksNamespace : NamespacedClientProxy
	{
		internal TasksNamespace(ElasticClient client): base(client)
		{
		}

		///<inheritdoc cref = "ICancelTasksRequest"/>
		public CancelTasksResponse CancelTasks(Func<CancelTasksDescriptor, ICancelTasksRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "ICancelTasksRequest"/>
		public Task<CancelTasksResponse> CancelTasksAsync(Func<CancelTasksDescriptor, ICancelTasksRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "ICancelTasksRequest"/>
		public CancelTasksResponse CancelTasks(ICancelTasksRequest request) => DoRequest<ICancelTasksRequest, CancelTasksResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "ICancelTasksRequest"/>
		public Task<CancelTasksResponse> CancelTasksAsync(ICancelTasksRequest request, CancellationToken ct = default) => DoRequestAsync<ICancelTasksRequest, CancelTasksResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IGetTaskRequest"/>
		public GetTaskResponse GetTask(TaskId taskId, Func<GetTaskDescriptor, IGetTaskRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetTaskRequest"/>
		public Task<GetTaskResponse> GetTaskAsync(TaskId taskId, Func<GetTaskDescriptor, IGetTaskRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IGetTaskRequest"/>
		public GetTaskResponse GetTask(IGetTaskRequest request) => DoRequest<IGetTaskRequest, GetTaskResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IGetTaskRequest"/>
		public Task<GetTaskResponse> GetTaskAsync(IGetTaskRequest request, CancellationToken ct = default) => DoRequestAsync<IGetTaskRequest, GetTaskResponse>(request, request.RequestParameters, ct);
		///<inheritdoc cref = "IListTasksRequest"/>
		public ListTasksResponse ListTasks(Func<ListTasksDescriptor, IListTasksRequest> selector = null) => throw new NotImplementedException();
		///<inheritdoc cref = "IListTasksRequest"/>
		public Task<ListTasksResponse> ListTasksAsync(Func<ListTasksDescriptor, IListTasksRequest> selector = null, CancellationToken ct = default) => throw new NotImplementedException();
		///<inheritdoc cref = "IListTasksRequest"/>
		public ListTasksResponse ListTasks(IListTasksRequest request) => DoRequest<IListTasksRequest, ListTasksResponse>(request, request.RequestParameters);
		///<inheritdoc cref = "IListTasksRequest"/>
		public Task<ListTasksResponse> ListTasksAsync(IListTasksRequest request, CancellationToken ct = default) => DoRequestAsync<IListTasksRequest, ListTasksResponse>(request, request.RequestParameters, ct);
	}
}