#ifndef ANDROIDICALL_H
#define ANDROIDICALL_H

#include <mono/metadata/class.h>
#include <mono/metadata/object-internals.h>
#include <mono/metadata/class-internals.h>
#include <mono/metadata/opcodes.h>
#include <mono/metadata/reflection.h>

void ves_icall_DalvikBridge_SetMonoHooks(gpointer ensureMarshalBufferLength, gpointer handleInvoke) MONO_INTERNAL;
void ves_icall_DalvikBridge_Log(int priority, MonoString* tag, MonoString *s) MONO_INTERNAL;
void ves_icall_DalvikBridge_InvokeInternal(char *buffer) MONO_INTERNAL;

#endif