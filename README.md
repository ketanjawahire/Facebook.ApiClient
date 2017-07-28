# C# SDK for Facebook Marketing API
The Facebook SDK for .NET helps developers build applications interacting with Facebook Marketing API.

## NuGet

    Install-Package Facebook.ApiClient

## How to use it?
* Single object request
```C#
	var apiEngine1 = new ApiClient("<ACCESS_TOKEN_HERE>");
	var testRequest1 = new ApiRequest("{id}/", apiEngine1);
	testRequest1.AddUrlSegmentParameter("id", "<AD_OBJECT_ID_HERE>");
	testRequest1.AddGetOrPostParameter("fields", string.Join(",", Ad.GetApiSelectors(true, false, false)));
	var testRequest1Response = testRequest1.Execute<Ad>(ApiRequestHttpMethod.GET);
```
* Paged API request
```C#
	var apiEngine1 = new ApiClient("<ACCESS_TOKEN_HERE>");
	var testRequest2 = new PagedApiRequest("{account_id}/ads", apiEngine1);
	testRequest2.AddUrlSegmentParameter("account_id", "<ACCOUNT_ID_HERE>");
	testRequest2.AddGetOrPostParameter("fields", string.Join(",", Ad.GetApiSelectors(true, true, true)));
	testRequest2.AddPageLimit(25);

	var result = new List<Ad>();
	var testRequest2Response = testRequest2.ExecutePage<Ad>();

	result.AddRange(testRequest2Response.GetResultData());

	while (testRequest2Response.IsNextPageDataAvailable())
	{
		var pagedData = testRequest2Response.GetNextPageData();
		result.AddRange(pagedData.GetResultData());
	}
```	

## Supported Platforms
* .NET 4.5.2
