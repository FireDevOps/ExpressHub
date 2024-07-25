// Copyright (c) 2023 0x5BFA
// Licensed under the MIT License. See the LICENSE.

namespace FluentHub.Octokit.Models.v4
{
	/// <summary>
	/// Represents a Git tree entry.
	/// </summary>
	public class TreeEntry
	{
		/// <summary>
		/// The extension of the file
		/// </summary>
		public string Extension { get; set; }

		/// <summary>
		/// Whether or not this tree entry is generated
		/// </summary>
		public bool IsGenerated { get; set; }

		/// <summary>
		/// The programming language this file is written in.
		/// </summary>
		public Language Language { get; set; }

		/// <summary>
		/// Number of lines in the file.
		/// </summary>
		public int? LineCount { get; set; }

		/// <summary>
		/// Entry file mode.
		/// </summary>
		public int Mode { get; set; }

		/// <summary>
		/// Entry file name.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Entry file name. (Base64-encoded)
		/// </summary>
		public string NameRaw { get; set; }

		/// <summary>
		/// Entry file object.
		/// </summary>
		public IGitObject Object { get; set; }

		/// <summary>
		/// Entry file Git object ID.
		/// </summary>
		public string Oid { get; set; }

		/// <summary>
		/// The full path of the file.
		/// </summary>
		public string Path { get; set; }

		/// <summary>
		/// The full path of the file. (Base64-encoded)
		/// </summary>
		public string PathRaw { get; set; }

		/// <summary>
		/// The Repository the tree entry belongs to
		/// </summary>
		public Repository Repository { get; set; }

		/// <summary>
		/// Entry byte size
		/// </summary>
		public int Size { get; set; }

		/// <summary>
		/// If the TreeEntry is for a directory occupied by a submodule project, this returns the corresponding submodule
		/// </summary>
		public Submodule Submodule { get; set; }

		/// <summary>
		/// Entry file type.
		/// </summary>
		public string Type { get; set; }
	}
}
