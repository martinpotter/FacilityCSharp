// <auto-generated>
// DO NOT EDIT: generated by fsdgencsharp
// </auto-generated>
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ConformanceApi
{
	/// <summary>
	/// Response for GetApiInfo.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class GetApiInfoResponseDto : ServiceDto<GetApiInfoResponseDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public GetApiInfoResponseDto()
		{
		}

		/// <summary>
		/// The name of the service.
		/// </summary>
		public string Service { get; set; }

		/// <summary>
		/// The version of the service.
		/// </summary>
		public string Version { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(GetApiInfoResponseDto other)
		{
			return other != null &&
				Service == other.Service &&
				Version == other.Version;
		}
	}
}
