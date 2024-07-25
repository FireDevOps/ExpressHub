// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated input type of RemoveEnterpriseIdentityProvider
	/// </summary>
	public class RemoveEnterpriseIdentityProviderInput
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The ID of the enterprise from which to remove the identity provider.
		/// </summary>
		public ID EnterpriseId { get; set; }
	}
}
