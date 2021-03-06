﻿using System.Threading.Tasks;
using Elastic.Xunit.XunitPlumbing;
using Nest;
using Tests.Domain;
using Tests.Framework;
using static Tests.Framework.UrlTester;

namespace Tests.Search.MultiSearch
{
	public class MultiSearchUrlTests
	{
		[U] public async Task Urls()
		{
			var index = "indexx";
			await POST($"/_msearch")
					.Fluent(c => c.MultiSearch(s => s))
					.Request(c => c.MultiSearch(new MultiSearchRequest()))
					.FluentAsync(c => c.MultiSearchAsync(s => s))
					.RequestAsync(c => c.MultiSearchAsync(new MultiSearchRequest()))
				;

			await POST($"/{index}/_msearch")
					.Fluent(c => c.MultiSearch(s => s.Index(index)))
					.Request(c => c.MultiSearch(new MultiSearchRequest(index)))
					.FluentAsync(c => c.MultiSearchAsync(s => s.Index(index)))
					.RequestAsync(c => c.MultiSearchAsync(new MultiSearchRequest(index)))
				;
		}
	}
}
