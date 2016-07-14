﻿using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Colu.Client.Models
{
    public class IssueAssetRequest : Response, IRequest
    {
        [JsonProperty("params")]
        public IssueAssetParams Param { get; set; }

        [JsonProperty("to")]
        public IList<To> to { get; set; }

        public IssueAssetRequest()
        {
            this.jsonrpc = "2.0";
            this.Method = "issueAsset";
            this.Param = new IssueAssetParams();
            this.to = new List<To>();
        }

        public IssueAssetRequest(Int32 n)
        {
            this.jsonrpc = "2.0";
            this.Method = "issueAsset";
            this.Param = new IssueAssetParams();
            this.to = new List<To>(n);
        }
    }
}