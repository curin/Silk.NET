// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDCompositionVirtualSurface"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDCompositionVirtualSurfaceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDCompositionVirtualSurface"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDCompositionVirtualSurface).GUID, Is.EqualTo(IID_IDCompositionVirtualSurface));
    }

    /// <summary>Validates that the <see cref = "IDCompositionVirtualSurface"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDCompositionVirtualSurface>(), Is.EqualTo(sizeof(IDCompositionVirtualSurface)));
    }

    /// <summary>Validates that the <see cref = "IDCompositionVirtualSurface"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionVirtualSurface).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDCompositionVirtualSurface"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionVirtualSurface), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionVirtualSurface), Is.EqualTo(4));
        }
    }
}