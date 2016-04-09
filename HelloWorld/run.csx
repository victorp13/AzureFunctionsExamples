using System.Net;

public static HttpResponseMessage Run(HttpRequestMessage req, TraceWriter log)
{
    // Log the full request URL
    log.Verbose($"Requested URL: {req.RequestUri}");
    // Log a request header
    log.Verbose($"User agent: {req.Headers.UserAgent.ToString()}");

    // Access the query string variables
    var queryStrings = req.GetQueryNameValuePairs();
    
    var name = queryStrings.Where(
        q => q.Key.Equals("name", StringComparison.OrdinalIgnoreCase)
        ).FirstOrDefault().Value;

    if (string.IsNullOrEmpty(name))
        return req.CreateResponse(HttpStatusCode.BadRequest, "Please pass a 'name' parameter in the querystring");
    else
        return req.CreateResponse(HttpStatusCode.OK, "Hello " + name);
}