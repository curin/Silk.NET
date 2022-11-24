// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkDescriptorSetLayoutCreateFlags")]
    public enum DescriptorSetLayoutCreateFlags : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"PushDescriptorBitKhr\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR")]
        DescriptorSetLayoutCreatePushDescriptorBitKhr = 1,
        [Obsolete("Deprecated in favour of \"UpdateAfterBindPoolBitExt\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT")]
        DescriptorSetLayoutCreateUpdateAfterBindPoolBitExt = 2,
        [Obsolete("Deprecated in favour of \"Reserved4BitAmd\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_4_BIT_AMD")]
        DescriptorSetLayoutCreateReserved4BitAmd = 16,
        [Obsolete("Deprecated in favour of \"Reserved5BitAmd\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_5_BIT_AMD")]
        DescriptorSetLayoutCreateReserved5BitAmd = 32,
        [Obsolete("Deprecated in favour of \"Reserved3BitAmd\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_3_BIT_AMD")]
        DescriptorSetLayoutCreateReserved3BitAmd = 8,
        [Obsolete("Deprecated in favour of \"HostOnlyPoolBitValve\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE")]
        DescriptorSetLayoutCreateHostOnlyPoolBitValve = 4,
        [Obsolete("Deprecated in favour of \"HostOnlyPoolBitExt\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT")]
        DescriptorSetLayoutCreateHostOnlyPoolBitExt = 4,
        [Obsolete("Deprecated in favour of \"UpdateAfterBindPoolBit\"")]
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT")]
        DescriptorSetLayoutCreateUpdateAfterBindPoolBit = 2,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_PUSH_DESCRIPTOR_BIT_KHR")]
        PushDescriptorBitKhr = 1,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT_EXT")]
        UpdateAfterBindPoolBitExt = 2,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_4_BIT_AMD")]
        Reserved4BitAmd = 16,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_5_BIT_AMD")]
        Reserved5BitAmd = 32,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_RESERVED_3_BIT_AMD")]
        Reserved3BitAmd = 8,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_VALVE")]
        HostOnlyPoolBitValve = 4,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_HOST_ONLY_POOL_BIT_EXT")]
        HostOnlyPoolBitExt = 4,
        [NativeName("Name", "VK_DESCRIPTOR_SET_LAYOUT_CREATE_UPDATE_AFTER_BIND_POOL_BIT")]
        UpdateAfterBindPoolBit = 2,
    }
}
