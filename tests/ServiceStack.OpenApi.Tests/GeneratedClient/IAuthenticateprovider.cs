// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Authenticateprovider operations.
    /// </summary>
    public partial interface IAuthenticateprovider
    {
        /// <param name='provider'>
        /// </param>
        /// <param name='state'>
        /// </param>
        /// <param name='oauthToken'>
        /// </param>
        /// <param name='oauthVerifier'>
        /// </param>
        /// <param name='userName'>
        /// </param>
        /// <param name='password'>
        /// </param>
        /// <param name='rememberMe'>
        /// </param>
        /// <param name='continueParameter'>
        /// </param>
        /// <param name='nonce'>
        /// </param>
        /// <param name='uri'>
        /// </param>
        /// <param name='response'>
        /// </param>
        /// <param name='qop'>
        /// </param>
        /// <param name='nc'>
        /// </param>
        /// <param name='cnonce'>
        /// </param>
        /// <param name='useTokenCookie'>
        /// </param>
        /// <param name='meta'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AuthenticateResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AuthenticateResponse>> GetWithHttpMessagesAsync(string provider, string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='provider'>
        /// </param>
        /// <param name='state'>
        /// </param>
        /// <param name='oauthToken'>
        /// </param>
        /// <param name='oauthVerifier'>
        /// </param>
        /// <param name='userName'>
        /// </param>
        /// <param name='password'>
        /// </param>
        /// <param name='rememberMe'>
        /// </param>
        /// <param name='continueParameter'>
        /// </param>
        /// <param name='nonce'>
        /// </param>
        /// <param name='uri'>
        /// </param>
        /// <param name='response'>
        /// </param>
        /// <param name='qop'>
        /// </param>
        /// <param name='nc'>
        /// </param>
        /// <param name='cnonce'>
        /// </param>
        /// <param name='useTokenCookie'>
        /// </param>
        /// <param name='meta'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AuthenticateResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AuthenticateResponse>> CreateWithHttpMessagesAsync(string provider, string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), Authenticate body = default(Authenticate), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='provider'>
        /// </param>
        /// <param name='state'>
        /// </param>
        /// <param name='oauthToken'>
        /// </param>
        /// <param name='oauthVerifier'>
        /// </param>
        /// <param name='userName'>
        /// </param>
        /// <param name='password'>
        /// </param>
        /// <param name='rememberMe'>
        /// </param>
        /// <param name='continueParameter'>
        /// </param>
        /// <param name='nonce'>
        /// </param>
        /// <param name='uri'>
        /// </param>
        /// <param name='response'>
        /// </param>
        /// <param name='qop'>
        /// </param>
        /// <param name='nc'>
        /// </param>
        /// <param name='cnonce'>
        /// </param>
        /// <param name='useTokenCookie'>
        /// </param>
        /// <param name='meta'>
        /// </param>
        /// <param name='body'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AuthenticateResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AuthenticateResponse>> PostWithHttpMessagesAsync(string provider, string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), Authenticate body = default(Authenticate), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <param name='provider'>
        /// </param>
        /// <param name='state'>
        /// </param>
        /// <param name='oauthToken'>
        /// </param>
        /// <param name='oauthVerifier'>
        /// </param>
        /// <param name='userName'>
        /// </param>
        /// <param name='password'>
        /// </param>
        /// <param name='rememberMe'>
        /// </param>
        /// <param name='continueParameter'>
        /// </param>
        /// <param name='nonce'>
        /// </param>
        /// <param name='uri'>
        /// </param>
        /// <param name='response'>
        /// </param>
        /// <param name='qop'>
        /// </param>
        /// <param name='nc'>
        /// </param>
        /// <param name='cnonce'>
        /// </param>
        /// <param name='useTokenCookie'>
        /// </param>
        /// <param name='meta'>
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="AuthenticateResponseException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<AuthenticateResponse>> DeleteWithHttpMessagesAsync(string provider, string state = default(string), string oauthToken = default(string), string oauthVerifier = default(string), string userName = default(string), string password = default(string), bool? rememberMe = default(bool?), string continueParameter = default(string), string nonce = default(string), string uri = default(string), string response = default(string), string qop = default(string), string nc = default(string), string cnonce = default(string), bool? useTokenCookie = default(bool?), string meta = default(string), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
