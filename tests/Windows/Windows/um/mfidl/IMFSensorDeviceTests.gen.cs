// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IMFSensorDevice"/> struct.</summary>
[SupportedOSPlatform("windows10.0.14393.0")]
public static unsafe partial class IMFSensorDeviceTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMFSensorDevice"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMFSensorDevice).GUID, Is.EqualTo(IID_IMFSensorDevice));
    }

    /// <summary>Validates that the <see cref = "IMFSensorDevice"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMFSensorDevice>(), Is.EqualTo(sizeof(IMFSensorDevice)));
    }

    /// <summary>Validates that the <see cref = "IMFSensorDevice"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMFSensorDevice).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMFSensorDevice"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMFSensorDevice), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMFSensorDevice), Is.EqualTo(4));
        }
    }
}