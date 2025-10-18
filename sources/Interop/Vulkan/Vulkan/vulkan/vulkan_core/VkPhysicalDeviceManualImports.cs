// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkPhysicalDeviceManualImports
{
    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkVideoProfileInfoKHR*, VkVideoCapabilitiesKHR*, VkResult> vkGetPhysicalDeviceVideoCapabilitiesKHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceVideoFormatInfoKHR*, uint*, VkVideoFormatPropertiesKHR*, VkResult> vkGetPhysicalDeviceVideoFormatPropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceFeatures2*, void> vkGetPhysicalDeviceFeatures2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceProperties2*, void> vkGetPhysicalDeviceProperties2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkFormat, VkFormatProperties2*, void> vkGetPhysicalDeviceFormatProperties2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceImageFormatInfo2*, VkImageFormatProperties2*, VkResult> vkGetPhysicalDeviceImageFormatProperties2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, uint*, VkQueueFamilyProperties2*, void> vkGetPhysicalDeviceQueueFamilyProperties2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceMemoryProperties2*, void> vkGetPhysicalDeviceMemoryProperties2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceSparseImageFormatInfo2*, uint*, VkSparseImageFormatProperties2*, void> vkGetPhysicalDeviceSparseImageFormatProperties2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceExternalBufferInfo*, VkExternalBufferProperties*, void> vkGetPhysicalDeviceExternalBufferPropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceExternalSemaphoreInfo*, VkExternalSemaphoreProperties*, void> vkGetPhysicalDeviceExternalSemaphorePropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceExternalFenceInfo*, VkExternalFenceProperties*, void> vkGetPhysicalDeviceExternalFencePropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, uint, uint*, VkPerformanceCounterKHR*, VkPerformanceCounterDescriptionKHR*, VkResult> vkEnumeratePhysicalDeviceQueueFamilyPerformanceQueryCountersKHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkQueryPoolPerformanceCreateInfoKHR*, uint*, void> vkGetPhysicalDeviceQueueFamilyPerformanceQueryPassesKHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, VkSurfaceCapabilities2KHR*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkPhysicalDeviceSurfaceInfo2KHR*, uint*, VkSurfaceFormat2KHR*, VkResult> vkGetPhysicalDeviceSurfaceFormats2KHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, uint*, VkPhysicalDeviceFragmentShadingRateKHR*, VkResult> vkGetPhysicalDeviceFragmentShadingRatesKHR;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkFormat, VkImageType, VkImageTiling, VkImageUsageFlags, VkImageCreateFlags, VkExternalMemoryHandleTypeFlagsNV, VkExternalImageFormatPropertiesNV*, VkResult> vkGetPhysicalDeviceExternalImageFormatPropertiesNV;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkDisplayKHR, VkResult> vkReleaseDisplayEXT;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkSurfaceKHR, VkSurfaceCapabilities2EXT*, VkResult> vkGetPhysicalDeviceSurfaceCapabilities2EXT;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, VkSampleCountFlags, VkMultisamplePropertiesEXT*, void> vkGetPhysicalDeviceMultisamplePropertiesEXT;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, uint*, VkTimeDomainEXT*, VkResult> vkGetPhysicalDeviceCalibrateableTimeDomainsEXT;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, uint*, VkPhysicalDeviceToolProperties*, VkResult> vkGetPhysicalDeviceToolPropertiesEXT;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, uint*, VkCooperativeMatrixPropertiesNV*, VkResult> vkGetPhysicalDeviceCooperativeMatrixPropertiesNV;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, uint*, VkFramebufferMixedSamplesCombinationNV*, VkResult> vkGetPhysicalDeviceSupportedFramebufferMixedSamplesCombinationsNV;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, int, VkDisplayKHR, VkResult> vkAcquireDrmDisplayEXT;

    public delegate* unmanaged[Stdcall]<VkPhysicalDevice, int, uint, VkDisplayKHR*, VkResult> vkGetDrmDisplayEXT;
}
