#define ICALL_TABLE_corlib 1

static int corlib_icall_indexes [] = {
227,
239,
240,
241,
242,
243,
244,
245,
246,
247,
250,
251,
252,
427,
428,
429,
458,
459,
460,
480,
481,
482,
483,
600,
601,
602,
605,
649,
650,
651,
654,
655,
657,
659,
660,
662,
667,
675,
676,
677,
678,
679,
680,
681,
682,
683,
684,
685,
686,
687,
688,
689,
690,
691,
693,
694,
695,
696,
697,
698,
699,
795,
796,
797,
798,
799,
800,
801,
802,
803,
804,
805,
806,
807,
808,
809,
810,
811,
813,
814,
815,
816,
817,
818,
819,
886,
887,
956,
963,
966,
968,
973,
974,
976,
977,
981,
982,
984,
986,
987,
990,
991,
992,
995,
997,
1000,
1002,
1004,
1013,
1081,
1083,
1085,
1095,
1096,
1097,
1098,
1100,
1107,
1108,
1109,
1110,
1111,
1119,
1120,
1121,
1125,
1126,
1128,
1132,
1133,
1134,
1418,
1613,
1614,
10079,
10080,
10082,
10083,
10084,
10085,
10086,
10088,
10090,
10092,
10093,
10104,
10106,
10114,
10116,
10118,
10120,
10171,
10177,
10178,
10180,
10181,
10182,
10183,
10184,
10186,
10188,
11377,
11381,
11383,
11384,
11385,
11386,
11649,
11650,
11651,
11652,
11673,
11674,
11675,
11676,
11678,
11680,
11681,
11739,
11833,
11835,
11837,
11847,
11848,
11849,
11850,
11851,
12346,
12347,
12352,
12353,
12390,
12410,
12417,
12424,
12435,
12439,
12464,
12489,
12555,
12557,
12568,
12570,
12571,
12572,
12579,
12593,
12613,
12614,
12622,
12624,
12631,
12632,
12635,
12637,
12642,
12649,
12650,
12657,
12659,
12670,
12673,
12676,
12677,
12678,
12690,
12700,
12706,
12707,
12708,
12710,
12711,
12729,
12731,
12747,
12769,
12770,
12771,
12796,
12801,
12802,
12803,
12840,
12841,
13423,
13437,
13540,
13541,
13805,
13806,
13814,
13815,
13816,
13822,
13932,
14633,
14634,
15377,
15379,
15380,
15385,
15395,
16415,
16436,
16438,
16440,
};
void ves_icall_System_Array_InternalCreate (int,int,int,int,int);
int ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal (int);
int ves_icall_System_Array_IsValueOfElementTypeInternal (int,int);
int ves_icall_System_Array_CanChangePrimitive (int,int,int);
int ves_icall_System_Array_FastCopy (int,int,int,int,int);
int ves_icall_System_Array_GetLengthInternal_raw (int,int,int);
int ves_icall_System_Array_GetLowerBoundInternal_raw (int,int,int);
void ves_icall_System_Array_GetGenericValue_icall (int,int,int);
void ves_icall_System_Array_GetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_SetGenericValue_icall (int,int,int);
void ves_icall_System_Array_SetValueImpl_raw (int,int,int,int);
void ves_icall_System_Array_InitializeInternal_raw (int,int);
void ves_icall_System_Array_SetValueRelaxedImpl_raw (int,int,int,int);
void ves_icall_System_Runtime_RuntimeImports_ZeroMemory (int,int);
void ves_icall_System_Runtime_RuntimeImports_Memmove (int,int,int);
void ves_icall_System_Buffer_BulkMoveWithWriteBarrier (int,int,int,int);
int ves_icall_System_Delegate_AllocDelegateLike_internal_raw (int,int);
int ves_icall_System_Delegate_CreateDelegate_internal_raw (int,int,int,int,int);
int ves_icall_System_Delegate_GetVirtualMethod_internal_raw (int,int);
void ves_icall_System_Enum_GetEnumValuesAndNames_raw (int,int,int,int);
void ves_icall_System_Enum_InternalBoxEnum_raw (int,int,int64_t,int);
int ves_icall_System_Enum_InternalGetCorElementType (int);
void ves_icall_System_Enum_InternalGetUnderlyingType_raw (int,int,int);
int ves_icall_System_Environment_get_ProcessorCount ();
int ves_icall_System_Environment_get_TickCount ();
int64_t ves_icall_System_Environment_get_TickCount64 ();
void ves_icall_System_Environment_FailFast_raw (int,int,int,int);
int ves_icall_System_GC_GetCollectionCount (int);
void ves_icall_System_GC_register_ephemeron_array_raw (int,int);
int ves_icall_System_GC_get_ephemeron_tombstone_raw (int);
void ves_icall_System_GC_WaitForPendingFinalizers ();
void ves_icall_System_GC_SuppressFinalize_raw (int,int);
void ves_icall_System_GC_ReRegisterForFinalize_raw (int,int);
int64_t ves_icall_System_GC_GetTotalMemory (int);
void ves_icall_System_GC_GetGCMemoryInfo (int,int,int,int,int,int);
int ves_icall_System_GC_AllocPinnedArray_raw (int,int,int);
int ves_icall_System_Object_MemberwiseClone_raw (int,int);
double ves_icall_System_Math_Acos (double);
double ves_icall_System_Math_Acosh (double);
double ves_icall_System_Math_Asin (double);
double ves_icall_System_Math_Asinh (double);
double ves_icall_System_Math_Atan (double);
double ves_icall_System_Math_Atan2 (double,double);
double ves_icall_System_Math_Atanh (double);
double ves_icall_System_Math_Cbrt (double);
double ves_icall_System_Math_Ceiling (double);
double ves_icall_System_Math_Cos (double);
double ves_icall_System_Math_Cosh (double);
double ves_icall_System_Math_Exp (double);
double ves_icall_System_Math_Floor (double);
double ves_icall_System_Math_Log (double);
double ves_icall_System_Math_Log10 (double);
double ves_icall_System_Math_Pow (double,double);
double ves_icall_System_Math_Sin (double);
double ves_icall_System_Math_Sinh (double);
double ves_icall_System_Math_Sqrt (double);
double ves_icall_System_Math_Tan (double);
double ves_icall_System_Math_Tanh (double);
double ves_icall_System_Math_FusedMultiplyAdd (double,double,double);
double ves_icall_System_Math_Log2 (double);
double ves_icall_System_Math_ModF (double,int);
float ves_icall_System_MathF_Acos (float);
float ves_icall_System_MathF_Acosh (float);
float ves_icall_System_MathF_Asin (float);
float ves_icall_System_MathF_Asinh (float);
float ves_icall_System_MathF_Atan (float);
float ves_icall_System_MathF_Atan2 (float,float);
float ves_icall_System_MathF_Atanh (float);
float ves_icall_System_MathF_Cbrt (float);
float ves_icall_System_MathF_Ceiling (float);
float ves_icall_System_MathF_Cos (float);
float ves_icall_System_MathF_Cosh (float);
float ves_icall_System_MathF_Exp (float);
float ves_icall_System_MathF_Floor (float);
float ves_icall_System_MathF_Log (float);
float ves_icall_System_MathF_Log10 (float);
float ves_icall_System_MathF_Pow (float,float);
float ves_icall_System_MathF_Sin (float);
float ves_icall_System_MathF_Sinh (float);
float ves_icall_System_MathF_Sqrt (float);
float ves_icall_System_MathF_Tan (float);
float ves_icall_System_MathF_Tanh (float);
float ves_icall_System_MathF_FusedMultiplyAdd (float,float,float);
float ves_icall_System_MathF_Log2 (float);
float ves_icall_System_MathF_ModF (float,int);
void ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw (int,int,int);
void ves_icall_RuntimeMethodHandle_ReboxToNullable_raw (int,int,int,int);
int ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw (int,int,int);
void ves_icall_RuntimeType_make_array_type_raw (int,int,int,int);
void ves_icall_RuntimeType_make_byref_type_raw (int,int,int);
void ves_icall_RuntimeType_make_pointer_type_raw (int,int,int);
void ves_icall_RuntimeType_MakeGenericType_raw (int,int,int,int);
int ves_icall_RuntimeType_GetMethodsByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetPropertiesByName_native_raw (int,int,int,int,int);
int ves_icall_RuntimeType_GetConstructors_native_raw (int,int,int);
int ves_icall_System_RuntimeType_CreateInstanceInternal_raw (int,int);
void ves_icall_System_RuntimeType_AllocateValueType_raw (int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringMethod_raw (int,int,int);
void ves_icall_System_RuntimeType_getFullName_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetGenericArgumentsInternal_raw (int,int,int,int);
int ves_icall_RuntimeType_GetGenericParameterPosition (int);
int ves_icall_RuntimeType_GetEvents_native_raw (int,int,int,int);
int ves_icall_RuntimeType_GetFields_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetInterfaces_raw (int,int,int);
int ves_icall_RuntimeType_GetNestedTypes_native_raw (int,int,int,int,int);
void ves_icall_RuntimeType_GetDeclaringType_raw (int,int,int);
void ves_icall_RuntimeType_GetName_raw (int,int,int);
void ves_icall_RuntimeType_GetNamespace_raw (int,int,int);
int ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetAttributes (int);
int ves_icall_RuntimeTypeHandle_GetMetadataToken_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_GetCorElementType (int);
int ves_icall_RuntimeTypeHandle_HasInstantiation (int);
int ves_icall_RuntimeTypeHandle_IsComObject_raw (int,int);
int ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_HasReferences_raw (int,int);
int ves_icall_RuntimeTypeHandle_GetArrayRank_raw (int,int);
void ves_icall_RuntimeTypeHandle_GetAssembly_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetElementType_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetModule_raw (int,int,int);
void ves_icall_RuntimeTypeHandle_GetBaseType_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition (int);
int ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw (int,int);
int ves_icall_RuntimeTypeHandle_is_subclass_of_raw (int,int,int);
int ves_icall_RuntimeTypeHandle_IsByRefLike_raw (int,int);
void ves_icall_System_RuntimeTypeHandle_internal_from_name_raw (int,int,int,int,int,int);
int ves_icall_System_String_FastAllocateString_raw (int,int);
int ves_icall_System_String_InternalIsInterned_raw (int,int);
int ves_icall_System_String_InternalIntern_raw (int,int);
int ves_icall_System_Type_internal_from_handle_raw (int,int);
int ves_icall_System_ValueType_InternalGetHashCode_raw (int,int,int);
int ves_icall_System_ValueType_Equals_raw (int,int,int,int);
int ves_icall_System_Threading_Interlocked_CompareExchange_Int (int,int,int);
void ves_icall_System_Threading_Interlocked_CompareExchange_Object (int,int,int,int);
int ves_icall_System_Threading_Interlocked_Decrement_Int (int);
int ves_icall_System_Threading_Interlocked_Increment_Int (int);
int64_t ves_icall_System_Threading_Interlocked_Increment_Long (int);
int ves_icall_System_Threading_Interlocked_Exchange_Int (int,int);
void ves_icall_System_Threading_Interlocked_Exchange_Object (int,int,int);
int64_t ves_icall_System_Threading_Interlocked_CompareExchange_Long (int,int64_t,int64_t);
int64_t ves_icall_System_Threading_Interlocked_Exchange_Long (int,int64_t);
int ves_icall_System_Threading_Interlocked_Add_Int (int,int);
int64_t ves_icall_System_Threading_Interlocked_Add_Long (int,int64_t);
void ves_icall_System_Threading_Monitor_Monitor_Enter_raw (int,int);
void mono_monitor_exit_icall_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_raw (int,int);
void ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw (int,int);
int ves_icall_System_Threading_Monitor_Monitor_wait_raw (int,int,int,int);
void ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw (int,int,int,int,int);
void ves_icall_System_Threading_Thread_StartInternal_raw (int,int,int);
void ves_icall_System_Threading_Thread_InitInternal_raw (int,int);
int ves_icall_System_Threading_Thread_GetCurrentThread ();
void ves_icall_System_Threading_InternalThread_Thread_free_internal_raw (int,int);
int ves_icall_System_Threading_Thread_GetState_raw (int,int);
void ves_icall_System_Threading_Thread_SetState_raw (int,int,int);
void ves_icall_System_Threading_Thread_ClrState_raw (int,int,int);
void ves_icall_System_Threading_Thread_SetName_icall_raw (int,int,int,int);
int ves_icall_System_Threading_Thread_YieldInternal ();
void ves_icall_System_Threading_Thread_SetPriority_raw (int,int,int);
void ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw (int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw (int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw (int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw (int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw (int);
int ves_icall_System_GCHandle_InternalAlloc_raw (int,int,int);
void ves_icall_System_GCHandle_InternalFree_raw (int,int);
int ves_icall_System_GCHandle_InternalGet_raw (int,int);
void ves_icall_System_GCHandle_InternalSet_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError ();
void ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError (int);
void ves_icall_System_Runtime_InteropServices_Marshal_DestroyStructure_raw (int,int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw (int,int,int,int);
void ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw (int,int,int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_GetFunctionPointerForDelegateInternal_raw (int,int);
int ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw (int,int,int);
int ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw (int,int,int,int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw (int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw (int,int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw (int,int,int,int);
void ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw (int,int);
int ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack ();
int ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw (int,int);
int ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw (int);
int ves_icall_System_Reflection_Assembly_InternalLoad_raw (int,int,int,int);
int ves_icall_System_Reflection_Assembly_InternalGetType_raw (int,int,int,int,int,int);
int ves_icall_System_Reflection_AssemblyName_GetNativeName (int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw (int,int,int,int);
int ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw (int,int);
int ves_icall_MonoCustomAttrs_IsDefinedInternal_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw (int,int);
int ves_icall_System_Reflection_LoaderAllocatorScout_Destroy (int);
int ves_icall_GetCurrentMethod_raw (int);
void ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw (int,int,int,int);
int ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw (int,int,int,int,int);
void ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw (int,int,int);
void ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw (int,int,int,int,int,int,int);
void ves_icall_RuntimeEventInfo_get_event_info_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_ResolveType_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetParentType_raw (int,int,int);
int ves_icall_RuntimeFieldInfo_GetFieldOffset_raw (int,int);
int ves_icall_RuntimeFieldInfo_GetValueInternal_raw (int,int,int);
void ves_icall_RuntimeFieldInfo_SetValueInternal_raw (int,int,int,int);
int ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
void ves_icall_get_method_info_raw (int,int,int);
int ves_icall_get_method_attributes (int);
int ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw (int,int,int);
int ves_icall_System_MonoMethodInfo_get_retval_marshal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodBodyInternal_raw (int,int);
int ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw (int,int,int,int);
int ves_icall_RuntimeMethodInfo_get_name_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_base_method_raw (int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
void ves_icall_RuntimeMethodInfo_GetPInvoke_raw (int,int,int,int,int);
int ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw (int,int,int);
int ves_icall_RuntimeMethodInfo_GetGenericArguments_raw (int,int);
int ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw (int,int);
int ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw (int,int);
void ves_icall_InvokeClassConstructor_raw (int,int);
int ves_icall_InternalInvoke_raw (int,int,int,int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw (int,int);
void ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw (int,int,int);
int ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw (int,int,int,int,int,int);
int ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw (int,int,int,int,int,int);
void ves_icall_RuntimePropertyInfo_get_property_info_raw (int,int,int,int);
int ves_icall_RuntimePropertyInfo_GetTypeModifiers_raw (int,int,int,int);
int ves_icall_property_info_get_default_value_raw (int,int);
int ves_icall_reflection_get_token_raw (int,int);
int ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw (int,int,int);
int ves_icall_CustomAttributeBuilder_GetBlob_raw (int,int,int,int,int,int,int,int);
void ves_icall_DynamicMethod_create_dynamic_method_raw (int,int,int,int,int);
void ves_icall_AssemblyBuilder_basic_init_raw (int,int);
void ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw (int,int);
void ves_icall_ModuleBuilder_basic_init_raw (int,int);
void ves_icall_ModuleBuilder_set_wrappers_type_raw (int,int,int);
int ves_icall_ModuleBuilder_getUSIndex_raw (int,int,int);
int ves_icall_ModuleBuilder_getToken_raw (int,int,int,int);
int ves_icall_ModuleBuilder_getMethodToken_raw (int,int,int,int);
void ves_icall_ModuleBuilder_RegisterToken_raw (int,int,int,int);
int ves_icall_TypeBuilder_create_runtime_class_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw (int,int);
int ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw (int,int);
int ves_icall_System_Diagnostics_Debugger_IsAttached_internal ();
int ves_icall_System_Diagnostics_Debugger_IsLogging ();
void ves_icall_System_Diagnostics_Debugger_Log (int,int,int);
int ves_icall_System_Diagnostics_StackFrame_GetFrameInfo (int,int,int,int,int,int,int,int);
void ves_icall_System_Diagnostics_StackTrace_GetTrace (int,int,int,int);
int ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass (int);
void ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree (int);
int ves_icall_Mono_SafeStringMarshal_StringToUtf8 (int);
void ves_icall_Mono_SafeStringMarshal_GFree (int);
static void *corlib_icall_funcs [] = {
// token 227,
ves_icall_System_Array_InternalCreate,
// token 239,
ves_icall_System_Array_GetCorElementTypeOfElementTypeInternal,
// token 240,
ves_icall_System_Array_IsValueOfElementTypeInternal,
// token 241,
ves_icall_System_Array_CanChangePrimitive,
// token 242,
ves_icall_System_Array_FastCopy,
// token 243,
ves_icall_System_Array_GetLengthInternal_raw,
// token 244,
ves_icall_System_Array_GetLowerBoundInternal_raw,
// token 245,
ves_icall_System_Array_GetGenericValue_icall,
// token 246,
ves_icall_System_Array_GetValueImpl_raw,
// token 247,
ves_icall_System_Array_SetGenericValue_icall,
// token 250,
ves_icall_System_Array_SetValueImpl_raw,
// token 251,
ves_icall_System_Array_InitializeInternal_raw,
// token 252,
ves_icall_System_Array_SetValueRelaxedImpl_raw,
// token 427,
ves_icall_System_Runtime_RuntimeImports_ZeroMemory,
// token 428,
ves_icall_System_Runtime_RuntimeImports_Memmove,
// token 429,
ves_icall_System_Buffer_BulkMoveWithWriteBarrier,
// token 458,
ves_icall_System_Delegate_AllocDelegateLike_internal_raw,
// token 459,
ves_icall_System_Delegate_CreateDelegate_internal_raw,
// token 460,
ves_icall_System_Delegate_GetVirtualMethod_internal_raw,
// token 480,
ves_icall_System_Enum_GetEnumValuesAndNames_raw,
// token 481,
ves_icall_System_Enum_InternalBoxEnum_raw,
// token 482,
ves_icall_System_Enum_InternalGetCorElementType,
// token 483,
ves_icall_System_Enum_InternalGetUnderlyingType_raw,
// token 600,
ves_icall_System_Environment_get_ProcessorCount,
// token 601,
ves_icall_System_Environment_get_TickCount,
// token 602,
ves_icall_System_Environment_get_TickCount64,
// token 605,
ves_icall_System_Environment_FailFast_raw,
// token 649,
ves_icall_System_GC_GetCollectionCount,
// token 650,
ves_icall_System_GC_register_ephemeron_array_raw,
// token 651,
ves_icall_System_GC_get_ephemeron_tombstone_raw,
// token 654,
ves_icall_System_GC_WaitForPendingFinalizers,
// token 655,
ves_icall_System_GC_SuppressFinalize_raw,
// token 657,
ves_icall_System_GC_ReRegisterForFinalize_raw,
// token 659,
ves_icall_System_GC_GetTotalMemory,
// token 660,
ves_icall_System_GC_GetGCMemoryInfo,
// token 662,
ves_icall_System_GC_AllocPinnedArray_raw,
// token 667,
ves_icall_System_Object_MemberwiseClone_raw,
// token 675,
ves_icall_System_Math_Acos,
// token 676,
ves_icall_System_Math_Acosh,
// token 677,
ves_icall_System_Math_Asin,
// token 678,
ves_icall_System_Math_Asinh,
// token 679,
ves_icall_System_Math_Atan,
// token 680,
ves_icall_System_Math_Atan2,
// token 681,
ves_icall_System_Math_Atanh,
// token 682,
ves_icall_System_Math_Cbrt,
// token 683,
ves_icall_System_Math_Ceiling,
// token 684,
ves_icall_System_Math_Cos,
// token 685,
ves_icall_System_Math_Cosh,
// token 686,
ves_icall_System_Math_Exp,
// token 687,
ves_icall_System_Math_Floor,
// token 688,
ves_icall_System_Math_Log,
// token 689,
ves_icall_System_Math_Log10,
// token 690,
ves_icall_System_Math_Pow,
// token 691,
ves_icall_System_Math_Sin,
// token 693,
ves_icall_System_Math_Sinh,
// token 694,
ves_icall_System_Math_Sqrt,
// token 695,
ves_icall_System_Math_Tan,
// token 696,
ves_icall_System_Math_Tanh,
// token 697,
ves_icall_System_Math_FusedMultiplyAdd,
// token 698,
ves_icall_System_Math_Log2,
// token 699,
ves_icall_System_Math_ModF,
// token 795,
ves_icall_System_MathF_Acos,
// token 796,
ves_icall_System_MathF_Acosh,
// token 797,
ves_icall_System_MathF_Asin,
// token 798,
ves_icall_System_MathF_Asinh,
// token 799,
ves_icall_System_MathF_Atan,
// token 800,
ves_icall_System_MathF_Atan2,
// token 801,
ves_icall_System_MathF_Atanh,
// token 802,
ves_icall_System_MathF_Cbrt,
// token 803,
ves_icall_System_MathF_Ceiling,
// token 804,
ves_icall_System_MathF_Cos,
// token 805,
ves_icall_System_MathF_Cosh,
// token 806,
ves_icall_System_MathF_Exp,
// token 807,
ves_icall_System_MathF_Floor,
// token 808,
ves_icall_System_MathF_Log,
// token 809,
ves_icall_System_MathF_Log10,
// token 810,
ves_icall_System_MathF_Pow,
// token 811,
ves_icall_System_MathF_Sin,
// token 813,
ves_icall_System_MathF_Sinh,
// token 814,
ves_icall_System_MathF_Sqrt,
// token 815,
ves_icall_System_MathF_Tan,
// token 816,
ves_icall_System_MathF_Tanh,
// token 817,
ves_icall_System_MathF_FusedMultiplyAdd,
// token 818,
ves_icall_System_MathF_Log2,
// token 819,
ves_icall_System_MathF_ModF,
// token 886,
ves_icall_RuntimeMethodHandle_ReboxFromNullable_raw,
// token 887,
ves_icall_RuntimeMethodHandle_ReboxToNullable_raw,
// token 956,
ves_icall_RuntimeType_GetCorrespondingInflatedMethod_raw,
// token 963,
ves_icall_RuntimeType_make_array_type_raw,
// token 966,
ves_icall_RuntimeType_make_byref_type_raw,
// token 968,
ves_icall_RuntimeType_make_pointer_type_raw,
// token 973,
ves_icall_RuntimeType_MakeGenericType_raw,
// token 974,
ves_icall_RuntimeType_GetMethodsByName_native_raw,
// token 976,
ves_icall_RuntimeType_GetPropertiesByName_native_raw,
// token 977,
ves_icall_RuntimeType_GetConstructors_native_raw,
// token 981,
ves_icall_System_RuntimeType_CreateInstanceInternal_raw,
// token 982,
ves_icall_System_RuntimeType_AllocateValueType_raw,
// token 984,
ves_icall_RuntimeType_GetDeclaringMethod_raw,
// token 986,
ves_icall_System_RuntimeType_getFullName_raw,
// token 987,
ves_icall_RuntimeType_GetGenericArgumentsInternal_raw,
// token 990,
ves_icall_RuntimeType_GetGenericParameterPosition,
// token 991,
ves_icall_RuntimeType_GetEvents_native_raw,
// token 992,
ves_icall_RuntimeType_GetFields_native_raw,
// token 995,
ves_icall_RuntimeType_GetInterfaces_raw,
// token 997,
ves_icall_RuntimeType_GetNestedTypes_native_raw,
// token 1000,
ves_icall_RuntimeType_GetDeclaringType_raw,
// token 1002,
ves_icall_RuntimeType_GetName_raw,
// token 1004,
ves_icall_RuntimeType_GetNamespace_raw,
// token 1013,
ves_icall_RuntimeType_FunctionPointerReturnAndParameterTypes_raw,
// token 1081,
ves_icall_RuntimeTypeHandle_GetAttributes,
// token 1083,
ves_icall_RuntimeTypeHandle_GetMetadataToken_raw,
// token 1085,
ves_icall_RuntimeTypeHandle_GetGenericTypeDefinition_impl_raw,
// token 1095,
ves_icall_RuntimeTypeHandle_GetCorElementType,
// token 1096,
ves_icall_RuntimeTypeHandle_HasInstantiation,
// token 1097,
ves_icall_RuntimeTypeHandle_IsComObject_raw,
// token 1098,
ves_icall_RuntimeTypeHandle_IsInstanceOfType_raw,
// token 1100,
ves_icall_RuntimeTypeHandle_HasReferences_raw,
// token 1107,
ves_icall_RuntimeTypeHandle_GetArrayRank_raw,
// token 1108,
ves_icall_RuntimeTypeHandle_GetAssembly_raw,
// token 1109,
ves_icall_RuntimeTypeHandle_GetElementType_raw,
// token 1110,
ves_icall_RuntimeTypeHandle_GetModule_raw,
// token 1111,
ves_icall_RuntimeTypeHandle_GetBaseType_raw,
// token 1119,
ves_icall_RuntimeTypeHandle_type_is_assignable_from_raw,
// token 1120,
ves_icall_RuntimeTypeHandle_IsGenericTypeDefinition,
// token 1121,
ves_icall_RuntimeTypeHandle_GetGenericParameterInfo_raw,
// token 1125,
ves_icall_RuntimeTypeHandle_is_subclass_of_raw,
// token 1126,
ves_icall_RuntimeTypeHandle_IsByRefLike_raw,
// token 1128,
ves_icall_System_RuntimeTypeHandle_internal_from_name_raw,
// token 1132,
ves_icall_System_String_FastAllocateString_raw,
// token 1133,
ves_icall_System_String_InternalIsInterned_raw,
// token 1134,
ves_icall_System_String_InternalIntern_raw,
// token 1418,
ves_icall_System_Type_internal_from_handle_raw,
// token 1613,
ves_icall_System_ValueType_InternalGetHashCode_raw,
// token 1614,
ves_icall_System_ValueType_Equals_raw,
// token 10079,
ves_icall_System_Threading_Interlocked_CompareExchange_Int,
// token 10080,
ves_icall_System_Threading_Interlocked_CompareExchange_Object,
// token 10082,
ves_icall_System_Threading_Interlocked_Decrement_Int,
// token 10083,
ves_icall_System_Threading_Interlocked_Increment_Int,
// token 10084,
ves_icall_System_Threading_Interlocked_Increment_Long,
// token 10085,
ves_icall_System_Threading_Interlocked_Exchange_Int,
// token 10086,
ves_icall_System_Threading_Interlocked_Exchange_Object,
// token 10088,
ves_icall_System_Threading_Interlocked_CompareExchange_Long,
// token 10090,
ves_icall_System_Threading_Interlocked_Exchange_Long,
// token 10092,
ves_icall_System_Threading_Interlocked_Add_Int,
// token 10093,
ves_icall_System_Threading_Interlocked_Add_Long,
// token 10104,
ves_icall_System_Threading_Monitor_Monitor_Enter_raw,
// token 10106,
mono_monitor_exit_icall_raw,
// token 10114,
ves_icall_System_Threading_Monitor_Monitor_pulse_raw,
// token 10116,
ves_icall_System_Threading_Monitor_Monitor_pulse_all_raw,
// token 10118,
ves_icall_System_Threading_Monitor_Monitor_wait_raw,
// token 10120,
ves_icall_System_Threading_Monitor_Monitor_try_enter_with_atomic_var_raw,
// token 10171,
ves_icall_System_Threading_Thread_StartInternal_raw,
// token 10177,
ves_icall_System_Threading_Thread_InitInternal_raw,
// token 10178,
ves_icall_System_Threading_Thread_GetCurrentThread,
// token 10180,
ves_icall_System_Threading_InternalThread_Thread_free_internal_raw,
// token 10181,
ves_icall_System_Threading_Thread_GetState_raw,
// token 10182,
ves_icall_System_Threading_Thread_SetState_raw,
// token 10183,
ves_icall_System_Threading_Thread_ClrState_raw,
// token 10184,
ves_icall_System_Threading_Thread_SetName_icall_raw,
// token 10186,
ves_icall_System_Threading_Thread_YieldInternal,
// token 10188,
ves_icall_System_Threading_Thread_SetPriority_raw,
// token 11377,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_PrepareForAssemblyLoadContextRelease_raw,
// token 11381,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_GetLoadContextForAssembly_raw,
// token 11383,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFile_raw,
// token 11384,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalInitializeNativeALC_raw,
// token 11385,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalLoadFromStream_raw,
// token 11386,
ves_icall_System_Runtime_Loader_AssemblyLoadContext_InternalGetLoadedAssemblies_raw,
// token 11649,
ves_icall_System_GCHandle_InternalAlloc_raw,
// token 11650,
ves_icall_System_GCHandle_InternalFree_raw,
// token 11651,
ves_icall_System_GCHandle_InternalGet_raw,
// token 11652,
ves_icall_System_GCHandle_InternalSet_raw,
// token 11673,
ves_icall_System_Runtime_InteropServices_Marshal_GetLastPInvokeError,
// token 11674,
ves_icall_System_Runtime_InteropServices_Marshal_SetLastPInvokeError,
// token 11675,
ves_icall_System_Runtime_InteropServices_Marshal_DestroyStructure_raw,
// token 11676,
ves_icall_System_Runtime_InteropServices_Marshal_StructureToPtr_raw,
// token 11678,
ves_icall_System_Runtime_InteropServices_Marshal_PtrToStructureInternal_raw,
// token 11680,
ves_icall_System_Runtime_InteropServices_Marshal_GetFunctionPointerForDelegateInternal_raw,
// token 11681,
ves_icall_System_Runtime_InteropServices_Marshal_SizeOfHelper_raw,
// token 11739,
ves_icall_System_Runtime_InteropServices_NativeLibrary_LoadByName_raw,
// token 11833,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalGetHashCode_raw,
// token 11835,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InternalTryGetHashCode_raw,
// token 11837,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetObjectValue_raw,
// token 11847,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetUninitializedObjectInternal_raw,
// token 11848,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_InitializeArray_raw,
// token 11849,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_GetSpanDataFrom_raw,
// token 11850,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_RunClassConstructor_raw,
// token 11851,
ves_icall_System_Runtime_CompilerServices_RuntimeHelpers_SufficientExecutionStack,
// token 12346,
ves_icall_System_Reflection_Assembly_GetExecutingAssembly_raw,
// token 12347,
ves_icall_System_Reflection_Assembly_GetEntryAssembly_raw,
// token 12352,
ves_icall_System_Reflection_Assembly_InternalLoad_raw,
// token 12353,
ves_icall_System_Reflection_Assembly_InternalGetType_raw,
// token 12390,
ves_icall_System_Reflection_AssemblyName_GetNativeName,
// token 12410,
ves_icall_MonoCustomAttrs_GetCustomAttributesInternal_raw,
// token 12417,
ves_icall_MonoCustomAttrs_GetCustomAttributesDataInternal_raw,
// token 12424,
ves_icall_MonoCustomAttrs_IsDefinedInternal_raw,
// token 12435,
ves_icall_System_Reflection_FieldInfo_internal_from_handle_type_raw,
// token 12439,
ves_icall_System_Reflection_FieldInfo_get_marshal_info_raw,
// token 12464,
ves_icall_System_Reflection_LoaderAllocatorScout_Destroy,
// token 12489,
ves_icall_GetCurrentMethod_raw,
// token 12555,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceNames_raw,
// token 12557,
ves_icall_System_Reflection_RuntimeAssembly_GetExportedTypes_raw,
// token 12568,
ves_icall_System_Reflection_RuntimeAssembly_GetInfo_raw,
// token 12570,
ves_icall_System_Reflection_RuntimeAssembly_GetManifestResourceInternal_raw,
// token 12571,
ves_icall_System_Reflection_Assembly_GetManifestModuleInternal_raw,
// token 12572,
ves_icall_System_Reflection_RuntimeAssembly_GetModulesInternal_raw,
// token 12579,
ves_icall_System_Reflection_RuntimeCustomAttributeData_ResolveArgumentsInternal_raw,
// token 12593,
ves_icall_RuntimeEventInfo_get_event_info_raw,
// token 12613,
ves_icall_reflection_get_token_raw,
// token 12614,
ves_icall_System_Reflection_EventInfo_internal_from_handle_type_raw,
// token 12622,
ves_icall_RuntimeFieldInfo_ResolveType_raw,
// token 12624,
ves_icall_RuntimeFieldInfo_GetParentType_raw,
// token 12631,
ves_icall_RuntimeFieldInfo_GetFieldOffset_raw,
// token 12632,
ves_icall_RuntimeFieldInfo_GetValueInternal_raw,
// token 12635,
ves_icall_RuntimeFieldInfo_SetValueInternal_raw,
// token 12637,
ves_icall_RuntimeFieldInfo_GetRawConstantValue_raw,
// token 12642,
ves_icall_reflection_get_token_raw,
// token 12649,
ves_icall_get_method_info_raw,
// token 12650,
ves_icall_get_method_attributes,
// token 12657,
ves_icall_System_Reflection_MonoMethodInfo_get_parameter_info_raw,
// token 12659,
ves_icall_System_MonoMethodInfo_get_retval_marshal_raw,
// token 12670,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodBodyInternal_raw,
// token 12673,
ves_icall_System_Reflection_RuntimeMethodInfo_GetMethodFromHandleInternalType_native_raw,
// token 12676,
ves_icall_RuntimeMethodInfo_get_name_raw,
// token 12677,
ves_icall_RuntimeMethodInfo_get_base_method_raw,
// token 12678,
ves_icall_reflection_get_token_raw,
// token 12690,
ves_icall_InternalInvoke_raw,
// token 12700,
ves_icall_RuntimeMethodInfo_GetPInvoke_raw,
// token 12706,
ves_icall_RuntimeMethodInfo_MakeGenericMethod_impl_raw,
// token 12707,
ves_icall_RuntimeMethodInfo_GetGenericArguments_raw,
// token 12708,
ves_icall_RuntimeMethodInfo_GetGenericMethodDefinition_raw,
// token 12710,
ves_icall_RuntimeMethodInfo_get_IsGenericMethodDefinition_raw,
// token 12711,
ves_icall_RuntimeMethodInfo_get_IsGenericMethod_raw,
// token 12729,
ves_icall_InvokeClassConstructor_raw,
// token 12731,
ves_icall_InternalInvoke_raw,
// token 12747,
ves_icall_reflection_get_token_raw,
// token 12769,
ves_icall_System_Reflection_RuntimeModule_InternalGetTypes_raw,
// token 12770,
ves_icall_System_Reflection_RuntimeModule_GetGuidInternal_raw,
// token 12771,
ves_icall_System_Reflection_RuntimeModule_ResolveMethodToken_raw,
// token 12796,
ves_icall_RuntimeParameterInfo_GetTypeModifiers_raw,
// token 12801,
ves_icall_RuntimePropertyInfo_get_property_info_raw,
// token 12802,
ves_icall_RuntimePropertyInfo_GetTypeModifiers_raw,
// token 12803,
ves_icall_property_info_get_default_value_raw,
// token 12840,
ves_icall_reflection_get_token_raw,
// token 12841,
ves_icall_System_Reflection_RuntimePropertyInfo_internal_from_handle_type_raw,
// token 13423,
ves_icall_CustomAttributeBuilder_GetBlob_raw,
// token 13437,
ves_icall_DynamicMethod_create_dynamic_method_raw,
// token 13540,
ves_icall_AssemblyBuilder_basic_init_raw,
// token 13541,
ves_icall_AssemblyBuilder_UpdateNativeCustomAttributes_raw,
// token 13805,
ves_icall_ModuleBuilder_basic_init_raw,
// token 13806,
ves_icall_ModuleBuilder_set_wrappers_type_raw,
// token 13814,
ves_icall_ModuleBuilder_getUSIndex_raw,
// token 13815,
ves_icall_ModuleBuilder_getToken_raw,
// token 13816,
ves_icall_ModuleBuilder_getMethodToken_raw,
// token 13822,
ves_icall_ModuleBuilder_RegisterToken_raw,
// token 13932,
ves_icall_TypeBuilder_create_runtime_class_raw,
// token 14633,
ves_icall_System_IO_Stream_HasOverriddenBeginEndRead_raw,
// token 14634,
ves_icall_System_IO_Stream_HasOverriddenBeginEndWrite_raw,
// token 15377,
ves_icall_System_Diagnostics_Debugger_IsAttached_internal,
// token 15379,
ves_icall_System_Diagnostics_Debugger_IsLogging,
// token 15380,
ves_icall_System_Diagnostics_Debugger_Log,
// token 15385,
ves_icall_System_Diagnostics_StackFrame_GetFrameInfo,
// token 15395,
ves_icall_System_Diagnostics_StackTrace_GetTrace,
// token 16415,
ves_icall_Mono_RuntimeClassHandle_GetTypeFromClass,
// token 16436,
ves_icall_Mono_RuntimeGPtrArrayHandle_GPtrArrayFree,
// token 16438,
ves_icall_Mono_SafeStringMarshal_StringToUtf8,
// token 16440,
ves_icall_Mono_SafeStringMarshal_GFree,
};
static uint8_t corlib_icall_flags [] = {
0,
0,
0,
0,
0,
4,
4,
0,
4,
0,
4,
4,
4,
0,
0,
0,
4,
4,
4,
4,
4,
0,
4,
0,
0,
0,
4,
0,
4,
4,
0,
4,
4,
0,
0,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
4,
0,
0,
0,
0,
0,
0,
0,
0,
0,
};
