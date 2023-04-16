﻿using Version = NuGet.Versioning.SemanticVersion;

namespace Versionize.Changelog;

public interface IChangelogLinkBuilder
{
    string BuildCommitLink(ConventionalCommit commit);

    string BuildVersionTagLink(Version newVersion, Version previousVersion, string urlFormat);
}
