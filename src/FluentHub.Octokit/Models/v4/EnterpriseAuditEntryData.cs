// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{

	/// <summary>
	/// Metadata for an audit entry containing enterprise account information.
	/// </summary>
	public interface IEnterpriseAuditEntryData
	{
		/// <summary>
		/// The HTTP path for this enterprise.
		/// </summary>
		string EnterpriseResourcePath { get; set; }

		/// <summary>
		/// The slug of the enterprise.
		/// </summary>
		string EnterpriseSlug { get; set; }

		/// <summary>
		/// The HTTP URL for this enterprise.
		/// </summary>
		string EnterpriseUrl { get; set; }
	}
}

namespace FluentHub.Octokit.Models.v4
{
	public class EnterpriseAuditEntryData : IEnterpriseAuditEntryData
	{
		public string EnterpriseResourcePath { get; set; }

		public string EnterpriseSlug { get; set; }

		public string EnterpriseUrl { get; set; }
	}
}

