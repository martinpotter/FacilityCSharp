// DO NOT EDIT: generated by fsdgencsharp
using System;
using System.Threading;
using System.Threading.Tasks;
using Facility.Core;
using Facility.Core.Http;

namespace Facility.TestServerApi.Http
{
	/// <summary>
	/// API for a Facility test server.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class HttpClientTestServerApi : HttpClientService, ITestServerApi
	{
		/// <summary>
		/// Creates the service.
		/// </summary>
		public HttpClientTestServerApi(HttpClientServiceSettings settings = null)
			: base(settings, defaultBaseUri: null)
		{
		}

		/// <summary>
		/// Gets API information.
		/// </summary>
		public Task<ServiceResult<GetApiInfoResponseDto>> GetApiInfoAsync(GetApiInfoRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(TestServerApiHttpMapping.GetApiInfoMapping, request, cancellationToken);
		}

		/// <summary>
		/// Creates a new widget.
		/// </summary>
		public Task<ServiceResult<CreateWidgetResponseDto>> CreateWidgetAsync(CreateWidgetRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(TestServerApiHttpMapping.CreateWidgetMapping, request, cancellationToken);
		}

		/// <summary>
		/// Gets the specified widget.
		/// </summary>
		public Task<ServiceResult<GetWidgetResponseDto>> GetWidgetAsync(GetWidgetRequestDto request, CancellationToken cancellationToken)
		{
			return TrySendRequestAsync(TestServerApiHttpMapping.GetWidgetMapping, request, cancellationToken);
		}
	}
}
