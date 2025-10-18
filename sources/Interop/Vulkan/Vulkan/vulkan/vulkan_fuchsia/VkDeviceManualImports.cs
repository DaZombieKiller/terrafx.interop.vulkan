// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_fuchsia.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceManualImports
{
    public delegate* unmanaged[Stdcall]<VkDevice, VkMemoryGetZirconHandleInfoFUCHSIA*, uint*, VkResult> vkGetMemoryZirconHandleFUCHSIA;

    public delegate* unmanaged[Stdcall]<VkDevice, VkExternalMemoryHandleTypeFlags, uint, VkMemoryZirconHandlePropertiesFUCHSIA*, VkResult> vkGetMemoryZirconHandlePropertiesFUCHSIA;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImportSemaphoreZirconHandleInfoFUCHSIA*, VkResult> vkImportSemaphoreZirconHandleFUCHSIA;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSemaphoreGetZirconHandleInfoFUCHSIA*, uint*, VkResult> vkGetSemaphoreZirconHandleFUCHSIA;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferCollectionCreateInfoFUCHSIA*, VkAllocationCallbacks*, VkBufferCollectionFUCHSIA*, VkResult> vkCreateBufferCollectionFUCHSIA;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferCollectionFUCHSIA, VkImageConstraintsInfoFUCHSIA*, VkResult> vkSetBufferCollectionImageConstraintsFUCHSIA;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferConstraintsInfoFUCHSIA*, VkResult> vkSetBufferCollectionBufferConstraintsFUCHSIA;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferCollectionFUCHSIA, VkAllocationCallbacks*, void> vkDestroyBufferCollectionFUCHSIA;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferCollectionFUCHSIA, VkBufferCollectionPropertiesFUCHSIA*, VkResult> vkGetBufferCollectionPropertiesFUCHSIA;
}
