// Code generated by Microsoft (R) AutoRest Code Generator 1.0.1.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace AutorestClient
{
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for UpdateSessioneditCustomName.
    /// </summary>
    public static partial class UpdateSessioneditCustomNameExtensions
    {
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customName'>
            /// </param>
            public static GetSessionResponse Get(this IUpdateSessioneditCustomName operations, string customName)
            {
                return operations.GetAsync(customName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSessionResponse> GetAsync(this IUpdateSessioneditCustomName operations, string customName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(customName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customName'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static GetSessionResponse Create(this IUpdateSessioneditCustomName operations, string customName, UpdateSession body = default(UpdateSession))
            {
                return operations.CreateAsync(customName, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customName'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSessionResponse> CreateAsync(this IUpdateSessioneditCustomName operations, string customName, UpdateSession body = default(UpdateSession), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(customName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customName'>
            /// </param>
            /// <param name='body'>
            /// </param>
            public static GetSessionResponse Post(this IUpdateSessioneditCustomName operations, string customName, UpdateSession body = default(UpdateSession))
            {
                return operations.PostAsync(customName, body).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customName'>
            /// </param>
            /// <param name='body'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSessionResponse> PostAsync(this IUpdateSessioneditCustomName operations, string customName, UpdateSession body = default(UpdateSession), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.PostWithHttpMessagesAsync(customName, body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customName'>
            /// </param>
            public static GetSessionResponse Delete(this IUpdateSessioneditCustomName operations, string customName)
            {
                return operations.DeleteAsync(customName).GetAwaiter().GetResult();
            }

            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='customName'>
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<GetSessionResponse> DeleteAsync(this IUpdateSessioneditCustomName operations, string customName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(customName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
