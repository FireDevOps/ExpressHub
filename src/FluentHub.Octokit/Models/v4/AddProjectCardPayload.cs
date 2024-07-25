// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Autogenerated return type of AddProjectCard
	/// </summary>
	public class AddProjectCardPayload
	{
		/// <summary>
		/// The edge from the ProjectColumn's card connection.
		/// </summary>
		public ProjectCardEdge CardEdge { get; set; }

		/// <summary>
		/// A unique identifier for the client performing the mutation.
		/// </summary>
		public string ClientMutationId { get; set; }

		/// <summary>
		/// The ProjectColumn
		/// </summary>
		public ProjectColumn ProjectColumn { get; set; }
	}
}
