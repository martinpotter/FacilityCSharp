// DO NOT EDIT: generated by fsdgencsharp
// <auto-generated />
using System;
using System.Collections.Generic;
using Facility.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Facility.ConformanceApi
{
	/// <summary>
	/// Request for DeleteWidget.
	/// </summary>
	[System.CodeDom.Compiler.GeneratedCode("fsdgencsharp", "")]
	public sealed partial class DeleteWidgetRequestDto : ServiceDto<DeleteWidgetRequestDto>
	{
		/// <summary>
		/// Creates an instance.
		/// </summary>
		public DeleteWidgetRequestDto()
		{
		}

		/// <summary>
		/// The widget ID.
		/// </summary>
		public int? Id { get; set; }

		/// <summary>
		/// Don't delete the widget unless it has this ETag.
		/// </summary>
		public string IfETag { get; set; }

		/// <summary>
		/// Determines if two DTOs are equivalent.
		/// </summary>
		public override bool IsEquivalentTo(DeleteWidgetRequestDto other)
		{
			return other != null &&
				Id == other.Id &&
				IfETag == other.IfETag;
		}
	}
}
