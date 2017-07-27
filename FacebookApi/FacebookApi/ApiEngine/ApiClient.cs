using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using FacebookApi.Constants;
using FacebookApi.Enums;
using FacebookApi.Exceptions;
using FacebookApi.Interfaces.IApiEngine;
using RestSharp;
using RestSharp.Extensions.MonoHttp;
using RestSharp.Newtonsoft.Json;
using RestRequest = RestSharp.RestRequest;

namespace FacebookApi.ApiEngine
{
    public class ApiClient : IApiClient
    {
        
        public string AccessToken { get; private set; }

        public string ApiVersion { get; private set; }

        public string AppId { get; private set; }

        public string AppSecret { get; private set; }


        public ApiClient(string accessToken)
        {
            _setAccessToken(accessToken);
            _setApiVersion(FacebookApiVersions.DEFAULT);
        }

        public ApiClient(string accessToken, string apiVersion)
        {
            _setApiVersion(apiVersion);
            _setAccessToken(accessToken);
        }

        public ApiClient(string appId, string appSecret, string accessToken)
        {
            _setApiVersion(FacebookApiVersions.DEFAULT);
            _setAccessToken(accessToken);
            _setAppId(appId, appSecret);
        }

        public ApiClient(string appId, string appSecret, string accessToken, string apiVersion)
        {
            _setApiVersion(apiVersion);
            _setAccessToken(accessToken);
            _setAppId(appId, appSecret);
        }

        private void _setApiVersion(string version)
        {
            if (FacebookApiVersions.IsValidVersion(version))
            {
                ApiVersion = version;
            }
            else
            {
                throw new InvalidApiVersionException();
            }
        }

        private void _setAccessToken(string accessToken)
        {
            this.AccessToken = accessToken;
        }

        public void _setAppId(string appId, string appSecret)
        {
            AppId = appId;
            AppSecret = appSecret;
        }
    }
}
