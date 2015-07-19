﻿using System;

namespace Protobuild
{
    public interface IPackageLocator
    {
        string DiscoverExistingPackagePath(string moduleRoot, PackageRef package, string platform);
    }
}

