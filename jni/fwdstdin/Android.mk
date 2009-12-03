BASE_PATH := $(call my-dir)
include $(CLEAR_VARS)
LOCAL_MODULE := fwdstdin
LOCAL_PATH := $(BASE_PATH)
LOCAL_SRC_FILES := main.c
LOCAL_PRELINK_MODULE := false
LOCAL_SHARED_LIBRARIES += libdl libc libm 
include $(BUILD_EXECUTABLE)