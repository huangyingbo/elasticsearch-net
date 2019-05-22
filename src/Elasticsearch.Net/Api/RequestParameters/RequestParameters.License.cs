using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

//This file contains all the typed querystring parameters that are generated of the client spec.
//This file is automatically generated from https://github.com/elastic/elasticsearch/tree/master/rest-api-spec
// ReSharper disable once CheckNamespace
namespace Elasticsearch.Net.Apis.LicenseApi
{
	///<summary>Request options for DeleteLicense<pre>https://www.elastic.co/guide/en/x-pack/current/license-management.html</pre></summary>
	public class DeleteLicenseRequestParameters : RequestParameters<DeleteLicenseRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.DELETE;
	}

	///<summary>Request options for GetLicense<pre>https://www.elastic.co/guide/en/x-pack/current/license-management.html</pre></summary>
	public class GetLicenseRequestParameters : RequestParameters<GetLicenseRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
		///<summary>Return local information, do not retrieve the state from master node (default: false)</summary>
		public bool? Local
		{
			get => Q<bool? >("local");
			set => Q("local", value);
		}
	}

	///<summary>Request options for GetBasicLicenseStatus<pre>https://www.elastic.co/guide/en/x-pack/current/license-management.html</pre></summary>
	public class GetBasicLicenseStatusRequestParameters : RequestParameters<GetBasicLicenseStatusRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
	}

	///<summary>Request options for GetTrialLicenseStatus<pre>https://www.elastic.co/guide/en/x-pack/current/license-management.html</pre></summary>
	public class GetTrialLicenseStatusRequestParameters : RequestParameters<GetTrialLicenseStatusRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.GET;
	}

	///<summary>Request options for PostLicense<pre>https://www.elastic.co/guide/en/x-pack/current/license-management.html</pre></summary>
	public class PostLicenseRequestParameters : RequestParameters<PostLicenseRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.PUT;
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public bool? Acknowledge
		{
			get => Q<bool? >("acknowledge");
			set => Q("acknowledge", value);
		}
	}

	///<summary>Request options for StartBasicLicense<pre>https://www.elastic.co/guide/en/x-pack/current/license-management.html</pre></summary>
	public class StartBasicLicenseRequestParameters : RequestParameters<StartBasicLicenseRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public bool? Acknowledge
		{
			get => Q<bool? >("acknowledge");
			set => Q("acknowledge", value);
		}
	}

	///<summary>Request options for StartTrialLicense<pre>https://www.elastic.co/guide/en/x-pack/current/license-management.html</pre></summary>
	public class StartTrialLicenseRequestParameters : RequestParameters<StartTrialLicenseRequestParameters>
	{
		public override HttpMethod DefaultHttpMethod => HttpMethod.POST;
		///<summary>whether the user has acknowledged acknowledge messages (default: false)</summary>
		public bool? Acknowledge
		{
			get => Q<bool? >("acknowledge");
			set => Q("acknowledge", value);
		}

		///<summary>The type of trial license to generate (default: "trial")</summary>
		public string TypeQueryString
		{
			get => Q<string>("type");
			set => Q("type", value);
		}
	}
}