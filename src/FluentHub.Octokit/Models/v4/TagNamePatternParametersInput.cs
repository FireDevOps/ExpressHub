// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Parameters to be used for the tag_name_pattern rule
	/// </summary>
	public class TagNamePatternParametersInput
	{
		/// <summary>
		/// How this rule will appear to users.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// If true, the rule will fail if the pattern matches.
		/// </summary>
		public bool? Negate { get; set; }

		/// <summary>
		/// The operator to use for matching.
		/// </summary>
		public string Operator { get; set; }

		/// <summary>
		/// The pattern to match with.
		/// </summary>
		public string Pattern { get; set; }
	}
}
