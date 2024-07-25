// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of CreateCommitOnBranch
	/// </summary>
	public class CreateCommitOnBranchPayload
	{
		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The new commit.
		/// </summary>
		public Commit Commit { get; set; }

		/// <summary>
		/// The ref which has been updated to point to the new commit.
		/// </summary>
		public Ref Ref { get; set; }
	}
}
