// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// AuthorizationVoidRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Voids, or cancels, an authorization, by ID. You cannot void a fully captured authorization.
    /// </summary>
    public class AuthorizationVoidRequest : HttpRequest
    {
        public AuthorizationVoidRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/void?", HttpMethod.Post, typeof(Authorization))
        {
            try {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
    }
}
