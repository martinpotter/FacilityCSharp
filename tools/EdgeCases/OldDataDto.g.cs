// DO NOT EDIT: generated by fsdgencsharp
// <auto-generated />
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

#pragma warning disable 612, 618 // member is obsolete

namespace EdgeCases
{
	/// <summary>
	/// An old DTO.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class OldDataDto : ServiceDto<OldDataDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public OldDataDto()
		{
		}

		/// <summary>
		/// An old field.
		/// </summary>
		[Obsolete]
		public string Old { get; set; }

		[Obsolete]
		public string Older { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(OldDataDto other)
		{
			return other != null &&
				Old == other.Old &&
				Older == other.Older;
		}
	}
}
