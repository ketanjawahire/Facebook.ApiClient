# Facebook.ApiClient [![Build Status](https://travis-ci.org/ketanjawahire/FacebookClient.svg?branch=development)](https://travis-ci.org/ketanjawahire/FacebookClient)

# C# SDK for Facebook Marketing API
The Facebook SDK for .NET helps developers build applications interacting with Facebook Marketing API.

## Nuget [![NuGet](https://img.shields.io/nuget/v/Facebook.ApiClient.svg?maxAge=25000)](http://www.nuget.org/packages/Facebook.ApiClient/) [![Nuget](https://img.shields.io/nuget/dt/Facebook.ApiClient.svg?maxAge=25000)](https://www.nuget.org/packages/Facebook.ApiClient/)

```    
	Install-Package Facebook.ApiClient
```

## 
This project aims to help developers working with Facebook marketing API. Facebook supports REST API endpoints to interact with core object models. This SDK will help you in doing various API calls & converting API response into structured response.
For Facebook entity classes you can refer to [Facebook.ApiClient.Entities](https://github.com/ketanjawahire/Facebook.ApiClient.Entities) project.

Currently SDK supports GET, POST & Paged API requests. Batch API request support is planned in future release.

## Code Example
Here is a short version of how to use this SDK. For more details check SampleApplication.

```C#
var accessToken = "<ACCESS_TOKEN>";
var apiClient = new ApiClient(accessToken);


//GET API request 
var getRequestUrl = "<GET_REQUEST_URL>";
var getRequest = (IGetRequest) ApiRequest.Create(ApiRequest.RequestType.Get, getRequestUrl, apiClient);
getRequest.AddQueryParameter("param1","value1");
getRequest.AddQueryParameter("param2","value2");

var getRequestResponse = getRequest.Execute();


//POST API Request
var postRequestUrl = "<POST_REQUEST_URL>";
var postRequest = (IPostRequest) ApiRequest.Create(ApiRequest.RequestType.Post, postRequestUrl, apiClient);
postRequest.AddParameter("param1","value1");
postRequest.AddParameter("param2","value2");
postRequest.AddFile("<filename>", <fileBytes>, <contentType>)

var postRequestResponse = postRequest.Execute();


//Paged API request
var pagedRequestUrl = "<PAGED_REQUEST_URL>";
var pagedRequest = (IPagedRequest) ApiRequest.Create(ApiRequest.RequestType.Paged, pagedRequestUrl, apiClient);
pagedRequest.AddQueryParameter("param1", "value1");
pagedRequest.AddUrlSegment("param2", "value2");
pagedRequest.AddPageLimit(20);

var result = new List<Class1>();
var pagedRequestResponse = pagedRequest.ExecutePage<Class1>();

if (pagedRequestResponse.IsDataAvailable())
{
	result.AddRange(pagedRequestResponse.GetResultData());

	while (pagedRequestResponse.IsNextPageDataAvailable())
	{
		pagedRequestResponse = pagedRequestResponse.GetNextPageData();
		result.AddRange(pagedRequestResponse.GetResultData());
	}
}
```	



## Supported Platforms
* .NET 4.5.2
* .NETStandard 2.0