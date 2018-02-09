[![Build Status](https://travis-ci.org/ketanjawahire/Facebook.ApiClient.svg?branch=master)](https://travis-ci.org/ketanjawahire/FacebookClient)

# C# SDK for Facebook Marketing API
The Facebook SDK for .NET helps developers build applications interacting with Facebook Marketing API.

## NuGet

* API Engine
```    
	Install-Package Facebook.ApiClient
```
* API Entities
```    
	Install-Package Facebook.ApiClient.Entities
```

## How to use it?
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
