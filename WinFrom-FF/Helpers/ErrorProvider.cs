using SoundProvider = WinFrom_FF.Helpers.SoundProvider;

namespace WinFrom_FF.Helpers
{
    public static class ErrorProvider
    {
        private static readonly Dictionary<int, string> ErrorMessages = new()
        {
          {100, "Continue: The server has received the request headers and the client can proceed to send the body."},
          {101, "Switching Protocols: The server is switching protocols as requested by the client."},
          {102, "Processing: The request is being processed but not completed yet."},
          
          {200, "OK: The request was successful."},
          {201, "Created: The resource was successfully created."},
          {202, "Accepted: The request has been accepted for processing, but it's not completed yet."},
          {203, "Non-Authoritative Information: Metadata is from a third party, not the original server."},
          {204, "No Content: The product was successfully deleted."},
          {205, "Reset Content: The request was successful, and the client should reset the view."},
          {206, "Partial Content: Partial data is returned due to a range request."},
          
          {300, "Multiple Choices: Multiple representations exist; the client can choose one."},
          {301, "Moved Permanently: The resource has been permanently moved to a new URL."},
          {302, "Found: The resource is temporarily at a different URL."},
          {303, "See Other: The resource can be fetched from another URL using GET."},
          {304, "Not Modified: The resource has not changed since the last request."},
          {307, "Temporary Redirect: The resource is temporarily moved but the method must not change."},
          {308, "Permanent Redirect: The resource is permanently moved, method and body must not change."},
          
          {400, "Bad Request: Invalid request syntax or malformed data."},
          {401, "Unauthorized: Authentication is required or invalid."},
          {403, "Forbidden: The client does not have permission to access the resource."},
          {404, "Not Found: The requested resource could not be found."},
          {405, "Method Not Allowed: The HTTP method is not supported for the resource."},
          {406, "Not Acceptable: The resource is not available in an acceptable format."},
          {409, "Conflict: The request conflicts with the current state of the resource (e.g., data already exists)."},
          {410, "Gone: The resource is no longer available and will not be available again."},
          {411, "Length Required: The content-length header is missing in the request."},
          {412, "Precondition Failed: A precondition in the request headers was not met."},
          {413, "Payload Too Large: The request payload is too large for the server to process."},
          {414, "URI Too Long: The request URI is too long for the server to process."},
          {415, "Unsupported Media Type: The server does not support the media format of the data."},
          {416, "Range Not Satisfiable: The range specified in the request is invalid."},
          {417, "Expectation Failed: The server cannot meet the requirements of the Expect header."},
          {418, "I'm a teapot: A joke response indicating the server refuses to brew coffee."},
          {422, "Unprocessable Entity: The request is well-formed but contains semantic errors."},
          {429, "Too Many Requests: The client has sent too many requests in a short period."},
          
          {500, "Internal Server Error: The server encountered an unexpected condition."},
          {501, "Not Implemented: The server does not support the required functionality."},
          {502, "Bad Gateway: The server received an invalid response from an upstream server."},
          {503, "Service Unavailable: The server is temporarily unable to handle the request."},
          {504, "Gateway Timeout: The upstream server failed to respond in time."},
          {505, "HTTP Version Not Supported: The server does not support the HTTP version used in the request."},
          {511, "Network Authentication Required: The client must authenticate to gain network access."}
        };

        public static string GetErrorMessages(int key)
        {
            if (ErrorMessages.Keys.Any(s => s == key))
            {
                if(key % 200 <100 && key / 200 != 0 && key/200<2)
                {
                    System.Media.SoundPlayer Player = new System.Media.
                        SoundPlayer(SoundProvider.PlaySound(SoundProvider.Correct));
                    Player.Play();
                }
                else if (key / 400 >= 1)
                {
                    System.Media.SoundPlayer Player = new System.Media.
                        SoundPlayer(SoundProvider.PlaySound(SoundProvider.Wrong));
                    Player.Play();
                }
                 return ErrorMessages[key];
            }
            return ErrorMessages[500];
        }

    }
}
