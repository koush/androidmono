cur_path := $(call my-dir)
APP_PROJECT_PATH := $(shell cd $(cur_path)/../.. ; pwd)
APP_BUILD_SCRIPT := $(cur_path)/Android.mk
APP_MODULES      := mono monodriver fwdstdin
APP_ABI := armeabi armeabi-v7a
