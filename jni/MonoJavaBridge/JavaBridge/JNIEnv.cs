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
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using Exception=System.Exception;

namespace MonoJavaBridge
{
    [SecurityPermission(SecurityAction.Assert, Flags = SecurityPermissionFlag.Execution | SecurityPermissionFlag.UnmanagedCode | SecurityPermissionFlag.SkipVerification)]
    public unsafe partial class JNIEnv
    {
        #region JNI methods

        public int GetVersion()
        {
            int version = getVersion(envPtr);
            ExceptionTest();
            return version;
        }

        public JavaVM GetJavaVM()
        {
            if (javaVM == null)
            {
                IntPtr jvm;
                getJavaVM.Invoke(envPtr, out jvm);
                ExceptionTest();
                javaVM = new JavaVM(jvm);
            }
            return javaVM;
        }

        #endregion

        #region reflection

        public JniLocalHandle FindClassPtr(string name)
        {
            JniLocalHandle clazz = findClass.Invoke(envPtr, name);
            ExceptionTest();
            return clazz;
        }

        public JniLocalHandle FindClass(string name)
        {
            JniLocalHandle clazz = findClass.Invoke(envPtr, name);
            ExceptionTest();
            return clazz;
        }

        public JniLocalHandle FindClassPtrNoThrow(string name)
        {
            JniLocalHandle clazz = findClass.Invoke(envPtr, name);
            if (ExceptionRead())
            {
                return JniLocalHandle.Zero;
            }
            return clazz;
        }

        public JniLocalHandle FindClassNoThrow(string name)
        {
            JniLocalHandle clazz = findClass.Invoke(envPtr, name);
            if (ExceptionRead())
            {
                return JniLocalHandle.Zero;
            }
            return clazz;
        }

        public JniLocalHandle GetObjectClass(JniHandle obj)
        {
            if (JniHandle.IsNull(obj))
            {
                return JniLocalHandle.Zero;
            }
            JniLocalHandle res = getObjectClass.Invoke(envPtr, obj);
            ExceptionTest();
            return res;
        }

        public MethodId GetStaticMethodID(JniHandle clazz, string name, string sig)
        {
            IntPtr res = getStaticMethodID.Invoke(envPtr, clazz, name, sig);
            ExceptionTest();
            return new MethodId(res);
        }

        public MethodId GetStaticMethodIDNoThrow(JniHandle clazz, string name, string sig)
        {
            IntPtr res = getStaticMethodID.Invoke(envPtr, clazz, name, sig);
            if (ExceptionRead())
            {
                return new MethodId(IntPtr.Zero);
            }
            return new MethodId(res);
        }

        public MethodId GetMethodID(JniHandle clazz, string name, string sig)
        {
            IntPtr res = getMethodID.Invoke(envPtr, clazz, name, sig);
            ExceptionTest();
            return new MethodId(res);
        }

        public MethodId GetMethodIDNoThrow(JniHandle clazz, string name, string sig)
        {
            IntPtr res = getMethodID.Invoke(envPtr, clazz, name, sig);
            if (ExceptionRead())
            {
                return new MethodId(IntPtr.Zero);
            }
            return new MethodId(res);
        }

        public FieldId GetFieldID(JniHandle clazz, string name, string sig)
        {
            IntPtr res = getFieldID.Invoke(envPtr, clazz, name, sig);
            ExceptionTest();
            return new FieldId(res);
        }

        public FieldId GetFieldIDNoThrow(JniHandle clazz, string name, string sig)
        {
            IntPtr res = getFieldID.Invoke(envPtr, clazz, name, sig);
            if (ExceptionRead())
            {
                return new FieldId(IntPtr.Zero);
            }
            return new FieldId(res);
        }
#if !JNI4NET_MINI

        public JniLocalHandle ToReflectedField(JniHandle cls, FieldId fieldID, bool isStatic)
        {
            JniLocalHandle res = toReflectedField.Invoke(envPtr, cls, fieldID.native,
                                                 isStatic ? (byte) 1 : (byte) 0);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle ToReflectedMethod(JniHandle cls, MethodId methodId, bool isStatic)
        {
            JniLocalHandle res = toReflectedMethod.Invoke(envPtr, cls, methodId.native,
                                                  isStatic ? (byte) 1 : (byte) 0);
            ExceptionTest();
            return res;
        }

        public MethodId FromReflectedMethod(JniLocalHandle methodId)
        {
            IntPtr res = fromReflectedMethod.Invoke(envPtr, methodId);
            ExceptionTest();
            return new MethodId(res);
        }

        public FieldId FromReflectedField(JavaObject field)
        {
            IntPtr res = fromReflectedField.Invoke(envPtr, field.mJvmHandle);
            ExceptionTest();
            return new FieldId(res);
        }

#endif

        public FieldId GetStaticFieldID(JniHandle clazz, string name, string sig)
        {
            IntPtr res = getStaticFieldID.Invoke(envPtr, clazz, name, sig);
            ExceptionTest();
            return new FieldId(res);
        }

        public FieldId GetStaticFieldIDNoThrow(JniHandle clazz, string name, string sig)
        {
            IntPtr res = getStaticFieldID.Invoke(envPtr, clazz, name, sig);
            if (ExceptionRead())
            {
                return new FieldId(IntPtr.Zero);
            }
            return new FieldId(res);
        }
        
        public JNIResult RegisterNatives(JniHandle clazz, JNINativeMethod[] methods, int nMethods)
        {
            JNIResult natives = registerNatives.Invoke(envPtr, clazz, methods, nMethods);
            ExceptionTest();
            return natives;
        }

        public JNIResult UnregisterNatives(JniHandle clazz)
        {
            JNIResult natives = unregisterNatives.Invoke(envPtr, clazz);
            ExceptionTest();
            return natives;
        }

        #endregion

        #region call static

        public void CallStaticVoidMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            callStaticVoidMethod(envPtr, clazz, methodIdNative.native, args);
            //TODO result could be tested in Java 1.6
            ExceptionTest();
        }

        public int CallStaticIntMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            int res = callStaticIntMethod(envPtr, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallStaticLongMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            long res = callStaticLongMethod(envPtr, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallStaticDoubleMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            double res = callStaticDoubleMethod(envPtr, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallStaticFloatMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            float res = callStaticFloatMethod(envPtr, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallStaticShortMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            short res = callStaticShortMethod(envPtr, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallStaticCharMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callStaticCharMethod(envPtr, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public bool CallStaticBooleanMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            bool res = callStaticBooleanMethod(envPtr, clazz, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public byte CallStaticByteMethod(JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            byte res = callStaticByteMethod(envPtr, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        internal void CallStaticVoidMethod(JniHandle clazz, string method, string sig, params Value[] args)
        {
            MethodId idNative = GetStaticMethodID(clazz, method, sig);
            CallStaticVoidMethod(clazz, idNative, args);
        }

        #endregion

        #region call instance
        
        public bool CallNonVirtualBooleanMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = 0 != callNonvirtualBooleanMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public bool CallNonVirtualBooleanMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = 0 != callNonvirtualBooleanMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
        public void CallNonVirtualVoidMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            callNonvirtualVoidMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
        }

        public void CallNonVirtualVoidMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            callNonvirtualVoidMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
        }
        public IntPtr CallNonVirtualObjectMethodPtr(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualObjectMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public IntPtr CallNonVirtualObjectMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualObjectMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
        public byte CallNonVirtualByteMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualByteMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public byte CallNonVirtualByteMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualByteMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
        public char CallNonVirtualCharMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = (char)callNonvirtualCharMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallNonVirtualCharMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = (char)callNonvirtualCharMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
        public short CallNonVirtualShortMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualShortMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallNonVirtualShortMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualShortMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
        public int CallNonVirtualIntMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualIntMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public int CallNonVirtualIntMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualIntMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
        public long CallNonVirtualLongMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualLongMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallNonVirtualLongMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualLongMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
        public float CallNonVirtualFloatMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualFloatMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallNonVirtualFloatMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualFloatMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }
        public double CallNonVirtualDoubleMethod(JavaObject obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualDoubleMethod(envPtr, obj.JvmHandle, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallNonVirtualDoubleMethod(JniHandle obj, JniHandle clazz, MethodId methodIdNative, params Value[] args)
        {
            var res = callNonvirtualDoubleMethod(envPtr, obj, clazz, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public void CallVoidMethod(JniHandle obj, MethodId methodId, params Value[] args)
        {
            callVoidMethod(envPtr, obj, methodId.native, args);
            //TODO result could be tested in Java 1.6
            ExceptionTest();
        }
        
        public bool CallBooleanMethod(JavaObject obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callBooleanMethod(envPtr, obj.JvmHandle, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public bool CallBooleanMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            bool res = callBooleanMethod(envPtr, obj, methodIdNative.native, args) != 0;
            ExceptionTest();
            return res;
        }

        public int CallIntMethod(JavaObject obj, MethodId methodIdNative, params Value[] args)
        {
            int res = callIntMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public int CallIntMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            int res = callIntMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallShortMethod(JavaObject obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callShortMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public short CallShortMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            short res = callShortMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallLongMethod(JavaObject obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callLongMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public long CallLongMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            long res = callLongMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public byte CallByteMethod(JavaObject obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callByteMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public byte CallByteMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            byte res = callByteMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallDoubleMethod(JavaObject obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callDoubleMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public double CallDoubleMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            double res = callDoubleMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallFloatMethod(JavaObject obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callFloatMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public float CallFloatMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            float res = callFloatMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallCharMethod(JavaObject obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char)callCharMethod(envPtr, obj.JvmHandle, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        public char CallCharMethod(JniHandle obj, MethodId methodIdNative, params Value[] args)
        {
            var res = (char) callCharMethod(envPtr, obj, methodIdNative.native, args);
            ExceptionTest();
            return res;
        }

        #endregion

        #region getters instance

        public bool GetBooleanField(JniHandle obj, FieldId fieldID)
        {
            bool res = getBooleanField(envPtr, obj, fieldID.native) != 0;
            ExceptionTest();
            return res;
        }

        public byte GetByteField(JniHandle obj, FieldId fieldID)
        {
            byte res = getByteField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public short GetShortField(JniHandle obj, FieldId fieldID)
        {
            short res = getShortField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public long GetLongField(JniHandle obj, FieldId fieldID)
        {
            long res = getLongField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public int GetIntField(JniHandle obj, FieldId fieldID)
        {
            int res = getIntField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public double GetDoubleField(JniHandle obj, FieldId fieldID)
        {
            double res = getDoubleField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public float GetFloatField(JniHandle obj, FieldId fieldID)
        {
            float res = getFloatField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        public char GetCharField(JniHandle obj, FieldId fieldID)
        {
            var res = (char) getCharField(envPtr, obj, fieldID.native);
            ExceptionTest();
            return res;
        }

        #endregion

        #region setters instance

        internal void SetObjectField(JniHandle obj, FieldId fieldID, JniHandle value)
        {
            setObjectField(envPtr, obj, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetIntField(JniHandle obj, FieldId fieldID, int value)
        {
            setIntField(envPtr, obj, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetBooleanField(JniHandle obj, FieldId fieldID, bool value)
        {
            setBooleanField(envPtr, obj, fieldID.native, value ? (byte) 1 : (byte) 0);
            ExceptionTest();
        }

        internal void SetByteField(JniHandle obj, FieldId fieldID, byte value)
        {
            setByteField(envPtr, obj, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetCharField(JniHandle obj, FieldId fieldID, char value)
        {
            setCharField(envPtr, obj, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetShortField(JniHandle obj, FieldId fieldID, short value)
        {
            setShortField(envPtr, obj, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetLongField(JniHandle obj, FieldId fieldID, long value)
        {
            setLongField(envPtr, obj, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetFloatField(JniHandle obj, FieldId fieldID, float value)
        {
            setFloatField(envPtr, obj, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetDoubleField(JniHandle obj, FieldId fieldID, double value)
        {
            setDoubleField(envPtr, obj, fieldID.native, value);
            ExceptionTest();
        }


        #endregion

        #region setters static

        internal void SetStaticObjectField(JniHandle clazz, FieldId fieldID, JavaObject value)
        {
            setStaticObjectField(envPtr, clazz, fieldID.native, value.JvmHandle);
            ExceptionTest();
        }

        internal void SetStaticIntField(JniHandle clazz, FieldId fieldID, int value)
        {
            setStaticIntField(envPtr, clazz, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticBooleanField(JniHandle clazz, IntPtr fieldID, bool value)
        {
            setStaticBooleanField(envPtr, clazz, fieldID, value ? (byte)1 : (byte)0);
            ExceptionTest();
        }

        internal void SetStaticBooleanField(JniHandle clazz, FieldId fieldID, bool value)
        {
            SetStaticBooleanField(clazz, fieldID.native, value);
        }

        internal void SetStaticByteField(JniHandle clazz, FieldId fieldID, byte value)
        {
            setStaticByteField(envPtr, clazz, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticCharField(JniHandle clazz, FieldId fieldID, char value)
        {
            setStaticCharField(envPtr, clazz, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticShortField(JniHandle clazz, FieldId fieldID, short value)
        {
            setStaticShortField(envPtr, clazz, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticLongField(JniHandle clazz, FieldId fieldID, long value)
        {
            setStaticLongField(envPtr, clazz, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticFloatField(JniHandle clazz, FieldId fieldID, float value)
        {
            setStaticFloatField(envPtr, clazz, fieldID.native, value);
            ExceptionTest();
        }

        internal void SetStaticDoubleField(JniHandle clazz, FieldId fieldID, double value)
        {
            setStaticDoubleField(envPtr, clazz, fieldID.native, value);
            ExceptionTest();
        }

        #endregion

        #region getters static

        public bool GetStaticBooleanField(JniHandle clazz, IntPtr fieldID)
        {
            bool res = getStaticBooleanField(envPtr, clazz, fieldID) != 0;
            ExceptionTest();
            return res;
        }

        public bool GetStaticBooleanField(JniHandle clazz, FieldId fieldID)
        {
            return GetStaticBooleanField(clazz, fieldID.native);
        }

        public byte GetStaticByteField(JniHandle clazz, FieldId fieldID)
        {
            byte res = getStaticByteField(envPtr, clazz, fieldID.native);
            ExceptionTest();
            return res;
        }

        public short GetStaticShortField(JniHandle clazz, FieldId fieldID)
        {
            short res = getStaticShortField(envPtr, clazz, fieldID.native);
            ExceptionTest();
            return res;
        }

        public long GetStaticLongField(JniHandle clazz, FieldId fieldID)
        {
            long res = getStaticLongField(envPtr, clazz, fieldID.native);
            ExceptionTest();
            return res;
        }

        public int GetStaticIntField(JniHandle clazz, FieldId fieldID)
        {
            int res = getStaticIntField(envPtr, clazz, fieldID.native);
            ExceptionTest();
            return res;
        }

        public double GetStaticDoubleField(JniHandle clazz, FieldId fieldID)
        {
            double res = getStaticDoubleField(envPtr, clazz, fieldID.native);
            ExceptionTest();
            return res;
        }

        public float GetStaticFloatField(JniHandle clazz, FieldId fieldID)
        {
            float res = getStaticFloatField(envPtr, clazz, fieldID.native);
            ExceptionTest();
            return res;
        }

        public char GetStaticCharField(JniHandle clazz, FieldId fieldID)
        {
            var res = (char) getStaticCharField(envPtr, clazz, fieldID.native);
            ExceptionTest();
            return res;
        }

        #endregion

        #region buffer

        public JniLocalHandle NewDirectByteBuffer(IntPtr address, long capacity)
        {
            JniLocalHandle res = newDirectByteBuffer.Invoke(envPtr, address, capacity);
            ExceptionTest();
            return res;
        }

        public IntPtr GetDirectBufferAddress(JniGlobalHandle buf)
        {
            IntPtr res = getDirectBufferAddress.Invoke(envPtr, buf);
            ExceptionTest();
            return res;
        }

        public long GetDirectBufferCapacity(JniGlobalHandle buf)
        {
            long res = getDirectBufferCapacity.Invoke(envPtr, buf);
            ExceptionTest();
            return res;
        }

        #endregion

        #region string

        public string ConvertToString(JniHandle javaString)
        {
            byte b = 0;
            IntPtr chars = GetStringChars(javaString, &b);
            string result = Marshal.PtrToStringUni(chars, getStringLength(envPtr, javaString));
            ReleaseStringChars(javaString, chars);
            return result;
        }

        #endregion

        #region references

        [SuppressUnmanagedCodeSecurity]
        public JniGlobalHandle NewGlobalRef(JniHandle lobj)
        {
            if (JniLocalHandle.IsNull(lobj))
            {
                throw new ArgumentNullException("lobj");
            }
            JniGlobalHandleNs res = newGlobalRef(envPtr, lobj);
            return new JniGlobalHandle(res.handle, GetJavaVM());
        }

        [SuppressUnmanagedCodeSecurity]
        internal JniLocalHandle NewLocalRef(JniHandle lobj)
        {
            if (JniHandle.IsNull(lobj))
            {
                throw new ArgumentNullException("lobj");
            }
            JniLocalHandle res = newLocalRef(envPtr, lobj);
            //optimized away ExceptionTest();
            return res;
        }

        internal JniLocalHandle PopLocalFrame(JniHandle result)
        {
            JniLocalHandle res = popLocalFrame(envPtr, result);
            ExceptionTest();
            return res;
        }

        internal void PushLocalFrame(int capacity)
        {
            int res = pushLocalFrame(envPtr, capacity);
            ExceptionTest();
            if (res != 0)
            {
                throw new JNIException("Can't allocate local frame" + res);
            }
        }

        internal void EnsureLocalCapacity(int capacity)
        {
            int res = ensureLocalCapacity(envPtr, capacity);
            ExceptionTest();
            if (res != 0)
            {
                throw new JNIException("Can't allocate local frame" + res);
            }
        }

        [SuppressUnmanagedCodeSecurity]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        internal void DeleteGlobalRef(JniGlobalHandle gref)
        {
            if (JniGlobalHandle.IsNull(gref))
            {
                throw new ArgumentNullException("gref");
            }
            deleteGlobalRef(envPtr, gref);
            //optimized away ExceptionTest();
        }

        [SuppressUnmanagedCodeSecurity]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        internal void DeleteLocalRef(JniLocalHandle lref)
        {
            if (JniLocalHandle.IsNull(lref))
            {
                throw new ArgumentNullException("lref");
            }
            deleteLocalRef(envPtr, lref);
            //optimized away ExceptionTest();
        }

        [SuppressUnmanagedCodeSecurity]
        public bool IsSameObject(JniGlobalHandle o1, JniGlobalHandle o2)
        {
            bool res = isSameObject(envPtr, o1, o2) != 0;
            ExceptionTest();
            return res;
        }

        #endregion

        #region allocation

        internal JniLocalHandle AllocObject(JniHandle clazz)
        {
            JniLocalHandle res = allocObject(envPtr, clazz);
            ExceptionTest();
            return res;
        }

        public JniLocalHandle NewObject(JniHandle clazz, MethodId methodID, params Value[] args)
        {
            JniLocalHandle res = newObject(envPtr, clazz, methodID.native, args);
            ExceptionTest();
            return res;
        }

        #endregion

        #region exceptions

        public void Throw(JavaException ex)
        {
            JniHandle ptr = ex.mJvmHandle;
            Throw(ptr);
        }

        internal void Throw(JniHandle ptr)
        {
            if (@throw(envPtr, ptr) != JNIResult.JNI_OK)
            {
                throw new JNIException("Can't throw");
            }
        }

        public void ThrowNew(JniHandle clazz, string message)
        {
            IntPtr uni = Marshal.StringToHGlobalAnsi(message);
            if (throwNew(envPtr, clazz, uni) != JNIResult.JNI_OK)
            {
                throw new JNIException("Can't throw");
            }
            Marshal.FreeHGlobal(uni);
        }

        public JniLocalHandle ExceptionOccurred()
        {
            return exceptionOccurred(envPtr);
        }

        public void FatalError(string message)
        {
            fatalError(envPtr, Marshal.StringToHGlobalUni(message));
        }

        public void ExceptionClear()
        {
            exceptionClear(envPtr);
        }

        public void ExceptionDescribe()
        {
            exceptionDescribe(envPtr);
        }

        public void ExceptionTest()
        {
            JniLocalHandle occurred = ExceptionOccurred();
            if (!JniLocalHandle.IsNull(occurred))
            {
                ExceptionDescribe();
                ExceptionClear();
                throw new Exception("fail in exception test. need to use typed exception");
                //Exception exception = Convertor.FullJ2C<Exception>(this, occurred);
                //throw exception;
            }
        }

        public bool ExceptionRead()
        {
            JniLocalHandle occurred = ExceptionOccurred();
            if (!JniLocalHandle.IsNull(occurred))
            {
#if DEBUG
                ExceptionDescribe();
#endif
                ExceptionClear();
                return true;
            }
            return false;
        }

        public bool ExceptionCheck()
        {
            return exceptionCheck(envPtr) != 0;
        }

        #endregion
    }
}