#ifndef BRIDGE_H
#define BRIDGE_H

typedef char *(*EnsureMarshalBufferLengthFn)(int length);
typedef char *(*HandleInvokeFn)();

#endif