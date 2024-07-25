// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of DeleteVerifiableDomain
	/// </summary>
	public class DeleteVerifiableDomainPayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The owning account from which the domain was deleted.
		/// </summary>
		public VerifiableDomainOwner Owner { get; set; }
	}
}
