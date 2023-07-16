// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDirectManipulationManager3"/> struct.</summary>
[SupportedOSPlatform("windows10.0")]
public static unsafe partial class IDirectManipulationManager3Tests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDirectManipulationManager3"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDirectManipulationManager3).GUID, Is.EqualTo(IID_IDirectManipulationManager3));
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationManager3"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDirectManipulationManager3>(), Is.EqualTo(sizeof(IDirectManipulationManager3)));
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationManager3"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDirectManipulationManager3).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDirectManipulationManager3"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDirectManipulationManager3), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDirectManipulationManager3), Is.EqualTo(4));
        }
    }
}