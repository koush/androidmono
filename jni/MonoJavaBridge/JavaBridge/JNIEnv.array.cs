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

namespace MonoJavaBridge
{
    unsafe partial class JNIEnv
    {
        #region SetRegion

        public void SetIntArrayRegion(JniHandle array, int start, int len, int[] buf)
        {
            fixed (int* ptr = &buf[0])
            {
                setIntArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void SetBooleanArrayRegion(JniHandle array, int start, int len, bool[] buf)
        {
            fixed (bool* ptr = &buf[0])
            {
                setBooleanArrayRegion(envPtr, array, start, len, (byte*) ptr);
            }
            ExceptionTest();
        }

        public void SetByteArrayRegion(JniHandle array, int start, int len, byte[] buf)
        {
            fixed (byte* ptr = &buf[0])
            {
                setByteArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void SetCharArrayRegion(JniHandle array, int start, int len, char[] buf)
        {
            fixed (char* ptr = &buf[0])
            {
                setCharArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void SetShortArrayRegion(JniHandle array, int start, int len, short[] buf)
        {
            fixed (short* ptr = &buf[0])
            {
                setShortArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void SetLongArrayRegion(JniHandle array, int start, int len, long[] buf)
        {
            fixed (long* ptr = &buf[0])
            {
                setLongArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void SetFloatArrayRegion(JniHandle array, int start, int len, float[] buf)
        {
            fixed (float* ptr = &buf[0])
            {
                setFloatArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void SetDoubleArrayRegion(JniHandle array, int start, int len, double[] buf)
        {
            fixed (double* ptr = &buf[0])
            {
                setDoubleArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        #endregion

        #region GetRegion

        public void GetIntArrayRegion(JniHandle array, int start, int len, int[] buf)
        {
            fixed (int* ptr = &buf[0])
            {
                getIntArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void GetCharArrayRegion(JniHandle array, int start, int len, char[] buf)
        {
            fixed (char* ptr = &buf[0])
            {
                getCharArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void GetByteArrayRegion(JniHandle array, int start, int len, byte[] buf)
        {
            fixed (byte* ptr = &buf[0])
            {
                getByteArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void GetShortArrayRegion(JniHandle array, int start, int len, short[] buf)
        {
            fixed (short* ptr = &buf[0])
            {
                getShortArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void GetLongArrayRegion(JniHandle array, int start, int len, long[] buf)
        {
            fixed (long* ptr = &buf[0])
            {
                getLongArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void GetFloatArrayRegion(JniHandle array, int start, int len, float[] buf)
        {
            fixed (float* ptr = &buf[0])
            {
                getFloatArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void GetDoubleArrayRegion(JniHandle array, int start, int len, double[] buf)
        {
            fixed (double* ptr = &buf[0])
            {
                getDoubleArrayRegion(envPtr, array, start, len, ptr);
            }
            ExceptionTest();
        }

        public void GetBooleanArrayRegion(JniHandle array, int start, int len, bool[] buf)
        {
            fixed (bool* ptr = &buf[0])
            {
                getBooleanArrayRegion(envPtr, array, start, len, (byte*) ptr);
            }
            ExceptionTest();
        }

        #endregion

        public int GetArrayLength(JniHandle array)
        {
            int res = getArrayLength(envPtr, array);
            ExceptionTest();
            return res;
        }

        public void SetObjectArrayElement(JniHandle array, int index, JniHandle val)
        {
            setObjectArrayElement(envPtr, array, index, val);
            ExceptionTest();
        }
    }
}