#region Copyright (C) 2009 by Pavel Savara

/*
This file is part of jni4net library - bridge between Java and .NET
http://jni4net.sourceforge.net/

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Lesser General Public License as 
published by the Free Software Foundation, either version 3 
of the License, or (at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Lesser General Public License for more details.

You should have received a copy of the GNU Lesser General Public License
along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

#endregion

using System;
using System.Runtime.InteropServices;

namespace MonoJavaBridge
{
    unsafe partial class JNIEnv
    {
        public JniLocalHandle NewIntArray(int len)
        {
            JniLocalHandle res = newIntArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle GetObjectArrayElement(JniHandle array, int index)
        {
            JniLocalHandle res = getObjectArrayElement(envPtr, array, index);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle NewString(string unicode)
        {
            IntPtr uni = Marshal.StringToHGlobalUni(unicode);
            JniLocalHandle res = newString(envPtr, uni, unicode.Length);
            ExceptionTest();
            Marshal.FreeHGlobal(uni);
            return res;
        }

        public IntPtr GetStringChars(JniHandle str, byte* isCopy)
        {
            IntPtr res = getStringChars(envPtr, str, isCopy);
            ExceptionTest();
            return res;
        }

        public void ReleaseStringChars(JniHandle str, IntPtr chars)
        {
            releaseStringChars(envPtr, str, chars);
            ExceptionTest();
        }

        public JniLocalHandle NewObjectArray(int len, JniHandle clazz, JniHandle init)
        {
            JniLocalHandle res = newObjectArray(envPtr, len, clazz, init);
            ExceptionTest();
            return res;
        }

        internal JniLocalHandle NewCharArray(int len)
        {
            JniLocalHandle res = newCharArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle NewShortArray(int len)
        {
            JniLocalHandle res = newShortArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle NewByteArray(int len)
        {
            JniLocalHandle res = newByteArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle NewBooleanArray(int len)
        {
            JniLocalHandle res = newBooleanArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle NewLongArray(int len)
        {
            JniLocalHandle res = newLongArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle NewFloatArray(int len)
        {
            JniLocalHandle res = newFloatArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle NewDoubleArray(int len)
        {
            JniLocalHandle res = newDoubleArray(envPtr, len);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle CallObjectMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            JniLocalHandle res = callObjectMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle GetObjectField(JniHandle obj, FieldId fieldID)
        {
            JniLocalHandle res = getObjectField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle GetStaticObjectField(JniHandle clazz, FieldId fieldID)
        {
            JniLocalHandle res = getStaticObjectField(envPtr, clazz, fieldID.native);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle CallStaticObjectMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            JniLocalHandle res = callStaticObjectMethod(envPtr, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
    }
}