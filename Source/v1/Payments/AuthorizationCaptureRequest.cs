// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// AuthorizationCaptureRequest.cs
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
    /// Captures and processes an authorization, by ID. The original payment call must specify an intent of `authorize`.
    /// </summary>
    public class AuthorizationCaptureRequest : HttpRequest
    {
        public AuthorizationCaptureRequest(string AuthorizationId) : base("/v1/payments/authorization/{authorization_id}/capture?", HttpMethod.Post, typeof(Capture))
        {
            try {
                this.Path = this.Path.Replace("{authorization_id}", Uri.EscapeDataString(Convert.ToString(AuthorizationId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
        public AuthorizationCaptureRequest RequestBody(Capture Capture)
        {
            this.Body = Capture;
            return this;
        }
    }
}
