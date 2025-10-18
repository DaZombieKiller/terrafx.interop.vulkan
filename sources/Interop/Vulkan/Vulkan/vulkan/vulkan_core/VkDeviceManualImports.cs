// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/vulkan/vulkan_core.h in the KhronosGroup/Vulkan-Headers repository for tag v1.3.268
// Original source is Copyright © 2015-2022 The Khronos Group Inc. Licensed under the Apache License v2.0 (Apache-2.0)

namespace TerraFX.Interop.Vulkan;

public unsafe partial struct VkDeviceManualImports
{
    public delegate* unmanaged[Stdcall]<VkDevice, VkVideoSessionCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionKHR*, VkResult> vkCreateVideoSessionKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkVideoSessionKHR, VkAllocationCallbacks*, void> vkDestroyVideoSessionKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkVideoSessionKHR, uint*, VkVideoSessionMemoryRequirementsKHR*, VkResult> vkGetVideoSessionMemoryRequirementsKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkVideoSessionKHR, uint, VkBindVideoSessionMemoryInfoKHR*, VkResult> vkBindVideoSessionMemoryKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkVideoSessionParametersCreateInfoKHR*, VkAllocationCallbacks*, VkVideoSessionParametersKHR*, VkResult> vkCreateVideoSessionParametersKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkVideoSessionParametersKHR, VkVideoSessionParametersUpdateInfoKHR*, VkResult> vkUpdateVideoSessionParametersKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkVideoSessionParametersKHR, VkAllocationCallbacks*, void> vkDestroyVideoSessionParametersKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, uint, uint, uint, VkPeerMemoryFeatureFlags*, void> vkGetDeviceGroupPeerMemoryFeaturesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkCommandPool, VkCommandPoolTrimFlags, void> vkTrimCommandPoolKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkMemoryGetFdInfoKHR*, int*, VkResult> vkGetMemoryFdKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkExternalMemoryHandleTypeFlags, int, VkMemoryFdPropertiesKHR*, VkResult> vkGetMemoryFdPropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImportSemaphoreFdInfoKHR*, VkResult> vkImportSemaphoreFdKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSemaphoreGetFdInfoKHR*, int*, VkResult> vkGetSemaphoreFdKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDescriptorUpdateTemplateCreateInfo*, VkAllocationCallbacks*, VkDescriptorUpdateTemplate*, VkResult> vkCreateDescriptorUpdateTemplateKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDescriptorUpdateTemplate, VkAllocationCallbacks*, void> vkDestroyDescriptorUpdateTemplateKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDescriptorSet, VkDescriptorUpdateTemplate, void*, void> vkUpdateDescriptorSetWithTemplateKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkRenderPassCreateInfo2*, VkAllocationCallbacks*, VkRenderPass*, VkResult> vkCreateRenderPass2KHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSwapchainKHR, VkResult> vkGetSwapchainStatusKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImportFenceFdInfoKHR*, VkResult> vkImportFenceFdKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkFenceGetFdInfoKHR*, int*, VkResult> vkGetFenceFdKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAcquireProfilingLockInfoKHR*, VkResult> vkAcquireProfilingLockKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, void> vkReleaseProfilingLockKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImageMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetImageMemoryRequirements2KHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferMemoryRequirementsInfo2*, VkMemoryRequirements2*, void> vkGetBufferMemoryRequirements2KHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImageSparseMemoryRequirementsInfo2*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetImageSparseMemoryRequirements2KHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSamplerYcbcrConversionCreateInfo*, VkAllocationCallbacks*, VkSamplerYcbcrConversion*, VkResult> vkCreateSamplerYcbcrConversionKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSamplerYcbcrConversion, VkAllocationCallbacks*, void> vkDestroySamplerYcbcrConversionKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, uint, VkBindBufferMemoryInfo*, VkResult> vkBindBufferMemory2KHR;

    public delegate* unmanaged[Stdcall]<VkDevice, uint, VkBindImageMemoryInfo*, VkResult> vkBindImageMemory2KHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDescriptorSetLayoutCreateInfo*, VkDescriptorSetLayoutSupport*, void> vkGetDescriptorSetLayoutSupportKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSemaphore, ulong*, VkResult> vkGetSemaphoreCounterValueKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSemaphoreWaitInfo*, ulong, VkResult> vkWaitSemaphoresKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSemaphoreSignalInfo*, VkResult> vkSignalSemaphoreKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSwapchainKHR, ulong, ulong, VkResult> vkWaitForPresentKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferDeviceAddressKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferOpaqueCaptureAddressKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeviceMemoryOpaqueCaptureAddressInfo*, ulong> vkGetDeviceMemoryOpaqueCaptureAddressKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAllocationCallbacks*, VkDeferredOperationKHR*, VkResult> vkCreateDeferredOperationKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, VkAllocationCallbacks*, void> vkDestroyDeferredOperationKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, uint> vkGetDeferredOperationMaxConcurrencyKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, VkResult> vkGetDeferredOperationResultKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, VkResult> vkDeferredOperationJoinKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipelineInfoKHR*, uint*, VkPipelineExecutablePropertiesKHR*, VkResult> vkGetPipelineExecutablePropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableStatisticKHR*, VkResult> vkGetPipelineExecutableStatisticsKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipelineExecutableInfoKHR*, uint*, VkPipelineExecutableInternalRepresentationKHR*, VkResult> vkGetPipelineExecutableInternalRepresentationsKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeviceBufferMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceBufferMemoryRequirementsKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeviceImageMemoryRequirements*, VkMemoryRequirements2*, void> vkGetDeviceImageMemoryRequirementsKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeviceImageMemoryRequirements*, uint*, VkSparseImageMemoryRequirements2*, void> vkGetDeviceImageSparseMemoryRequirementsKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDebugMarkerObjectTagInfoEXT*, VkResult> vkDebugMarkerSetObjectTagEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDebugMarkerObjectNameInfoEXT*, VkResult> vkDebugMarkerSetObjectNameEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkCuModuleCreateInfoNVX*, VkAllocationCallbacks*, VkCuModuleNVX*, VkResult> vkCreateCuModuleNVX;

    public delegate* unmanaged[Stdcall]<VkDevice, VkCuFunctionCreateInfoNVX*, VkAllocationCallbacks*, VkCuFunctionNVX*, VkResult> vkCreateCuFunctionNVX;

    public delegate* unmanaged[Stdcall]<VkDevice, VkCuModuleNVX, VkAllocationCallbacks*, void> vkDestroyCuModuleNVX;

    public delegate* unmanaged[Stdcall]<VkDevice, VkCuFunctionNVX, VkAllocationCallbacks*, void> vkDestroyCuFunctionNVX;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImageViewHandleInfoNVX*, uint> vkGetImageViewHandleNVX;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImageView, VkImageViewAddressPropertiesNVX*, VkResult> vkGetImageViewAddressNVX;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipeline, VkShaderStageFlags, VkShaderInfoTypeAMD, nuint*, void*, VkResult> vkGetShaderInfoAMD;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDisplayKHR, VkDisplayPowerInfoEXT*, VkResult> vkDisplayPowerControlEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeviceEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> vkRegisterDeviceEventEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDisplayKHR, VkDisplayEventInfoEXT*, VkAllocationCallbacks*, VkFence*, VkResult> vkRegisterDisplayEventEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSwapchainKHR, VkSurfaceCounterFlagsEXT, ulong*, VkResult> vkGetSwapchainCounterEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSwapchainKHR, VkRefreshCycleDurationGOOGLE*, VkResult> vkGetRefreshCycleDurationGOOGLE;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSwapchainKHR, uint*, VkPastPresentationTimingGOOGLE*, VkResult> vkGetPastPresentationTimingGOOGLE;

    public delegate* unmanaged[Stdcall]<VkDevice, uint, VkSwapchainKHR*, VkHdrMetadataEXT*, void> vkSetHdrMetadataEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDebugUtilsObjectNameInfoEXT*, VkResult> vkSetDebugUtilsObjectNameEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDebugUtilsObjectTagInfoEXT*, VkResult> vkSetDebugUtilsObjectTagEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImage, VkImageDrmFormatModifierPropertiesEXT*, VkResult> vkGetImageDrmFormatModifierPropertiesEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkValidationCacheCreateInfoEXT*, VkAllocationCallbacks*, VkValidationCacheEXT*, VkResult> vkCreateValidationCacheEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkValidationCacheEXT, VkAllocationCallbacks*, void> vkDestroyValidationCacheEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkValidationCacheEXT, uint, VkValidationCacheEXT*, VkResult> vkMergeValidationCachesEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkValidationCacheEXT, nuint*, void*, VkResult> vkGetValidationCacheDataEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureCreateInfoNV*, VkAllocationCallbacks*, VkAccelerationStructureNV*, VkResult> vkCreateAccelerationStructureNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureNV, VkAllocationCallbacks*, void> vkDestroyAccelerationStructureNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetAccelerationStructureMemoryRequirementsNV;

    public delegate* unmanaged[Stdcall]<VkDevice, uint, VkBindAccelerationStructureMemoryInfoNV*, VkResult> vkBindAccelerationStructureMemoryNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoNV*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateRayTracingPipelinesNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> vkGetRayTracingShaderGroupHandlesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> vkGetRayTracingShaderGroupHandlesNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureNV, nuint, void*, VkResult> vkGetAccelerationStructureHandleNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipeline, uint, VkResult> vkCompileDeferredNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkExternalMemoryHandleTypeFlags, void*, VkMemoryHostPointerPropertiesEXT*, VkResult> vkGetMemoryHostPointerPropertiesEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, uint, VkCalibratedTimestampInfoEXT*, ulong*, ulong*, VkResult> vkGetCalibratedTimestampsEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkInitializePerformanceApiInfoINTEL*, VkResult> vkInitializePerformanceApiINTEL;

    public delegate* unmanaged[Stdcall]<VkDevice, void> vkUninitializePerformanceApiINTEL;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPerformanceConfigurationAcquireInfoINTEL*, VkPerformanceConfigurationINTEL*, VkResult> vkAcquirePerformanceConfigurationINTEL;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPerformanceConfigurationINTEL, VkResult> vkReleasePerformanceConfigurationINTEL;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPerformanceParameterTypeINTEL, VkPerformanceValueINTEL*, VkResult> vkGetPerformanceParameterINTEL;

    public delegate* unmanaged[Stdcall]<VkDevice, VkSwapchainKHR, uint, void> vkSetLocalDimmingAMD;

    public delegate* unmanaged[Stdcall]<VkDevice, VkBufferDeviceAddressInfo*, ulong> vkGetBufferDeviceAddressEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkQueryPool, uint, uint, void> vkResetQueryPoolEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkImage, VkImageSubresource2KHR*, VkSubresourceLayout2KHR*, void> vkGetImageSubresourceLayout2EXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkGeneratedCommandsMemoryRequirementsInfoNV*, VkMemoryRequirements2*, void> vkGetGeneratedCommandsMemoryRequirementsNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkIndirectCommandsLayoutCreateInfoNV*, VkAllocationCallbacks*, VkIndirectCommandsLayoutNV*, VkResult> vkCreateIndirectCommandsLayoutNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkIndirectCommandsLayoutNV, VkAllocationCallbacks*, void> vkDestroyIndirectCommandsLayoutNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPrivateDataSlotCreateInfo*, VkAllocationCallbacks*, VkPrivateDataSlot*, VkResult> vkCreatePrivateDataSlotEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPrivateDataSlot, VkAllocationCallbacks*, void> vkDestroyPrivateDataSlotEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong, VkResult> vkSetPrivateDataEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkObjectType, ulong, VkPrivateDataSlot, ulong*, void> vkGetPrivateDataEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkRenderPass, VkExtent2D*, VkResult> vkGetDeviceSubpassShadingMaxWorkgroupSizeHUAWEI;

    public delegate* unmanaged[Stdcall]<VkDevice, VkMemoryGetRemoteAddressInfoNV*, void**, VkResult> vkGetMemoryRemoteAddressNV;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipelineInfoKHR*, VkBaseOutStructure*, VkResult> vkGetPipelinePropertiesEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeviceMemory, float, void> vkSetDeviceMemoryPriorityEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDescriptorSetBindingReferenceVALVE*, VkDescriptorSetLayoutHostMappingInfoVALVE*, void> vkGetDescriptorSetLayoutHostMappingInfoVALVE;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDescriptorSet, void**, void> vkGetDescriptorSetHostMappingVALVE;

    public delegate* unmanaged[Stdcall]<VkDevice, VkShaderModule, VkShaderModuleIdentifierEXT*, void> vkGetShaderModuleIdentifierEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkShaderModuleCreateInfo*, VkShaderModuleIdentifierEXT*, void> vkGetShaderModuleCreateInfoIdentifierEXT;

    public delegate* unmanaged[Stdcall]<VkDevice, VkFramebuffer, uint*, VkTilePropertiesQCOM*, VkResult> vkGetFramebufferTilePropertiesQCOM;

    public delegate* unmanaged[Stdcall]<VkDevice, VkRenderingInfo*, VkTilePropertiesQCOM*, VkResult> vkGetDynamicRenderingTilePropertiesQCOM;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureCreateInfoKHR*, VkAllocationCallbacks*, VkAccelerationStructureKHR*, VkResult> vkCreateAccelerationStructureKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureKHR, VkAllocationCallbacks*, void> vkDestroyAccelerationStructureKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, uint, VkAccelerationStructureBuildGeometryInfoKHR*, VkAccelerationStructureBuildRangeInfoKHR**, VkResult> vkBuildAccelerationStructuresKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureInfoKHR*, VkResult> vkCopyAccelerationStructureKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, VkCopyAccelerationStructureToMemoryInfoKHR*, VkResult> vkCopyAccelerationStructureToMemoryKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, VkCopyMemoryToAccelerationStructureInfoKHR*, VkResult> vkCopyMemoryToAccelerationStructureKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, uint, VkAccelerationStructureKHR*, VkQueryType, nuint, void*, nuint, VkResult> vkWriteAccelerationStructuresPropertiesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureDeviceAddressInfoKHR*, ulong> vkGetAccelerationStructureDeviceAddressKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureVersionInfoKHR*, VkAccelerationStructureCompatibilityKHR*, void> vkGetDeviceAccelerationStructureCompatibilityKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkAccelerationStructureBuildTypeKHR, VkAccelerationStructureBuildGeometryInfoKHR*, uint*, VkAccelerationStructureBuildSizesInfoKHR*, void> vkGetAccelerationStructureBuildSizesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkDeferredOperationKHR, VkPipelineCache, uint, VkRayTracingPipelineCreateInfoKHR*, VkAllocationCallbacks*, VkPipeline*, VkResult> vkCreateRayTracingPipelinesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipeline, uint, uint, nuint, void*, VkResult> vkGetRayTracingCaptureReplayShaderGroupHandlesKHR;

    public delegate* unmanaged[Stdcall]<VkDevice, VkPipeline, uint, VkShaderGroupShaderKHR, ulong> vkGetRayTracingShaderGroupStackSizeKHR;
}
