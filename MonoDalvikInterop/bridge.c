#include "metadata/marshal.h"
#include "metadata/method-builder.h"
#include "metadata/tabledefs.h"
#include "metadata/exception.h"
#include "metadata/appdomain.h"
#include "mono/metadata/debug-helpers.h"
#include "mono/metadata/threadpool.h"
#include "mono/metadata/threads.h"
#include "mono/metadata/monitor.h"
#include "mono/metadata/metadata-internals.h"
#include "mono/metadata/domain-internals.h"
#include "mono/metadata/gc-internal.h"
#include "mono/metadata/threads-types.h"
#include "mono/metadata/string-icalls.h"
#include "mono/metadata/attrdefs.h"
#include "mono/metadata/gc-internal.h"
#include "mono/utils/mono-counters.h"
#include "mono/mini/mini.h"
#include <string.h>
#include <errno.h>
#include <cutils/log.h>

#include "bridge.h"

// this file is here out of necessity because mono uses C++ keywords in the header which cause
// referencing the headers to fail.

void ves_icall_DalvikBridge_SetMonoHooks(EnsureMarshalBufferLengthFn ensureMarshalBufferLength, HandleInvokeFn handleInvoke);
void ves_icall_DalvikBridge_Log(int priority, MonoString* tag, MonoString *s);
void ves_icall_DalvikBridge_InvokeInternal(char *buffer);

void register_icall (gpointer func, const char *name, const char *sigstr, gboolean save)
{
	MonoMethodSignature *sig = mono_create_icall_signature (sigstr);

	mono_register_jit_icall (func, name, sig, save);
}

void register_icalls ()
{
	mono_add_internal_call("MonoDalvikBridge.DalvikBridge::InvokeInternal", ves_icall_DalvikBridge_InvokeInternal);
	mono_add_internal_call("MonoDalvikBridge.DalvikBridge::Log", ves_icall_DalvikBridge_Log);
	mono_add_internal_call("MonoDalvikBridge.DalvikBridge::SetMonoHooks", ves_icall_DalvikBridge_SetMonoHooks);
}

void ves_icall_DalvikBridge_Log(int priority, MonoString* tag, MonoString *s)
{
	gpointer str = mono_string_to_utf8(s);
	gpointer strTag = mono_string_to_utf8(tag);
	//LOGI(strTag, str);
	android_writeLog(priority, strTag, str);
	g_free(strTag);
	g_free(str);
}
