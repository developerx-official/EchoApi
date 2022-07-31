# EchoApi
This is a test api that can be accessed by sending a <strong>[GET request](https://www.w3schools.com/tags/ref_httpmethods.asp)</strong> to `https://dexeloper.com:5555/echo`.

You can also send a <strong>[query parameter](https://www.abstractapi.com/api-glossary/query-parameters)</strong> called `text`.

<strong>Requests are ratelimited to 2 per 1 second, and 100 per 1 minute.</strong>

<br />

With text parameter:
---

```
GET https://dexeloper.com:5555/echo?text=Pizza!
```

Returns:

```json
{
    "echo": "Pizza!",
    "dateTime": "yyyy-mm-ddT00:00:00.0000000-00:00"
}
```
<br />

Without text parameter:
---

```
GET https://dexeloper.com:5555/echo
```

Returns:

```json
{
    "echo": "Hello, World!",
    "dateTime": "yyyy-mm-ddT00:00:00.0000000-00:00"
}
```

<br />

<strong>That's all really! I hope this helps people test or get introduced to [API](https://dotnet.microsoft.com/en-us/apps/aspnet/apis)'s and [ASP.NET](https://dotnet.microsoft.com/en-us/apps/aspnet)!</strong>
