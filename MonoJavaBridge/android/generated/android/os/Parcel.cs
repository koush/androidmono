namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Parcel : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Parcel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public void writeInt(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeInt", "(I)V", ref global::android.os.Parcel._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public int readInt()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Parcel.staticClass, "readInt", "()I", ref global::android.os.Parcel._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public long readLong()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.os.Parcel.staticClass, "readLong", "()J", ref global::android.os.Parcel._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public byte readByte()
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::android.os.Parcel.staticClass, "readByte", "()B", ref global::android.os.Parcel._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public void writeLong(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeLong", "(J)V", ref global::android.os.Parcel._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public void writeByte(byte arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeByte", "(B)V", ref global::android.os.Parcel._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public void writeFloat(float arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeFloat", "(F)V", ref global::android.os.Parcel._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public float readFloat()
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::android.os.Parcel.staticClass, "readFloat", "()F", ref global::android.os.Parcel._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public double readDouble()
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::android.os.Parcel.staticClass, "readDouble", "()D", ref global::android.os.Parcel._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public global::java.lang.String readString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.Parcel.staticClass, "readString", "()Ljava/lang/String;", ref global::android.os.Parcel._m9) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public int dataSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Parcel.staticClass, "dataSize", "()I", ref global::android.os.Parcel._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public void writeValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeValue", "(Ljava/lang/Object;)V", ref global::android.os.Parcel._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public void writeString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeString", "(Ljava/lang/String;)V", ref global::android.os.Parcel._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public static global::android.os.Parcel obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.Parcel._m13.native == global::System.IntPtr.Zero)
				global::android.os.Parcel._m13 = @__env.GetStaticMethodIDNoThrow(global::android.os.Parcel.staticClass, "obtain", "()Landroid/os/Parcel;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Parcel>(@__env.CallStaticObjectMethod(android.os.Parcel.staticClass, global::android.os.Parcel._m13)) as android.os.Parcel;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public void recycle()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "recycle", "()V", ref global::android.os.Parcel._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public bool hasFileDescriptors()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.Parcel.staticClass, "hasFileDescriptors", "()Z", ref global::android.os.Parcel._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public int dataAvail()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Parcel.staticClass, "dataAvail", "()I", ref global::android.os.Parcel._m16);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public int dataPosition()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Parcel.staticClass, "dataPosition", "()I", ref global::android.os.Parcel._m17);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public int dataCapacity()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.Parcel.staticClass, "dataCapacity", "()I", ref global::android.os.Parcel._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public void setDataSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "setDataSize", "(I)V", ref global::android.os.Parcel._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public void setDataPosition(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "setDataPosition", "(I)V", ref global::android.os.Parcel._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public void setDataCapacity(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "setDataCapacity", "(I)V", ref global::android.os.Parcel._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public byte[] marshall()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.os.Parcel.staticClass, "marshall", "()[B", ref global::android.os.Parcel._m22) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public void unmarshall(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "unmarshall", "([BII)V", ref global::android.os.Parcel._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public void appendFrom(android.os.Parcel arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "appendFrom", "(Landroid/os/Parcel;II)V", ref global::android.os.Parcel._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public void writeInterfaceToken(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeInterfaceToken", "(Ljava/lang/String;)V", ref global::android.os.Parcel._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public void enforceInterface(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "enforceInterface", "(Ljava/lang/String;)V", ref global::android.os.Parcel._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public void writeByteArray(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeByteArray", "([BII)V", ref global::android.os.Parcel._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public void writeByteArray(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeByteArray", "([B)V", ref global::android.os.Parcel._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public void writeDouble(double arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeDouble", "(D)V", ref global::android.os.Parcel._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public void writeStrongBinder(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeStrongBinder", "(Landroid/os/IBinder;)V", ref global::android.os.Parcel._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public void writeStrongInterface(android.os.IInterface arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeStrongInterface", "(Landroid/os/IInterface;)V", ref global::android.os.Parcel._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void writeStrongInterface(global::android.os.IInterfaceDelegate arg0)
		{
			writeStrongInterface((global::android.os.IInterfaceDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public void writeFileDescriptor(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeFileDescriptor", "(Ljava/io/FileDescriptor;)V", ref global::android.os.Parcel._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public void writeMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeMap", "(Ljava/util/Map;)V", ref global::android.os.Parcel._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public void writeBundle(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeBundle", "(Landroid/os/Bundle;)V", ref global::android.os.Parcel._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public void writeList(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeList", "(Ljava/util/List;)V", ref global::android.os.Parcel._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public void writeArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeArray", "([Ljava/lang/Object;)V", ref global::android.os.Parcel._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public void writeSparseArray(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeSparseArray", "(Landroid/util/SparseArray;)V", ref global::android.os.Parcel._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public void writeSparseBooleanArray(android.util.SparseBooleanArray arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V", ref global::android.os.Parcel._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public void writeBooleanArray(bool[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeBooleanArray", "([Z)V", ref global::android.os.Parcel._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public bool[] createBooleanArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<bool>(this, global::android.os.Parcel.staticClass, "createBooleanArray", "()[Z", ref global::android.os.Parcel._m40) as bool[];
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public void readBooleanArray(bool[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readBooleanArray", "([Z)V", ref global::android.os.Parcel._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public void writeCharArray(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeCharArray", "([C)V", ref global::android.os.Parcel._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public char[] createCharArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<char>(this, global::android.os.Parcel.staticClass, "createCharArray", "()[C", ref global::android.os.Parcel._m43) as char[];
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public void readCharArray(char[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readCharArray", "([C)V", ref global::android.os.Parcel._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public void writeIntArray(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeIntArray", "([I)V", ref global::android.os.Parcel._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public int[] createIntArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::android.os.Parcel.staticClass, "createIntArray", "()[I", ref global::android.os.Parcel._m46) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public void readIntArray(int[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readIntArray", "([I)V", ref global::android.os.Parcel._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public void writeLongArray(long[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeLongArray", "([J)V", ref global::android.os.Parcel._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public long[] createLongArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<long>(this, global::android.os.Parcel.staticClass, "createLongArray", "()[J", ref global::android.os.Parcel._m49) as long[];
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public void readLongArray(long[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readLongArray", "([J)V", ref global::android.os.Parcel._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		public void writeFloatArray(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeFloatArray", "([F)V", ref global::android.os.Parcel._m51, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m52;
		public float[] createFloatArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<float>(this, global::android.os.Parcel.staticClass, "createFloatArray", "()[F", ref global::android.os.Parcel._m52) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m53;
		public void readFloatArray(float[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readFloatArray", "([F)V", ref global::android.os.Parcel._m53, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m54;
		public void writeDoubleArray(double[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeDoubleArray", "([D)V", ref global::android.os.Parcel._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		public double[] createDoubleArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<double>(this, global::android.os.Parcel.staticClass, "createDoubleArray", "()[D", ref global::android.os.Parcel._m55) as double[];
		}
		private static global::MonoJavaBridge.MethodId _m56;
		public void readDoubleArray(double[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readDoubleArray", "([D)V", ref global::android.os.Parcel._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		public void writeStringArray(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeStringArray", "([Ljava/lang/String;)V", ref global::android.os.Parcel._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		public global::java.lang.String[] createStringArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.String>(this, global::android.os.Parcel.staticClass, "createStringArray", "()[Ljava/lang/String;", ref global::android.os.Parcel._m58) as java.lang.String[];
		}
		private static global::MonoJavaBridge.MethodId _m59;
		public void readStringArray(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readStringArray", "([Ljava/lang/String;)V", ref global::android.os.Parcel._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		public void writeBinderArray(android.os.IBinder[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeBinderArray", "([Landroid/os/IBinder;)V", ref global::android.os.Parcel._m60, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m61;
		public global::android.os.IBinder[] createBinderArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.os.IBinder>(this, global::android.os.Parcel.staticClass, "createBinderArray", "()[Landroid/os/IBinder;", ref global::android.os.Parcel._m61) as android.os.IBinder[];
		}
		private static global::MonoJavaBridge.MethodId _m62;
		public void readBinderArray(android.os.IBinder[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readBinderArray", "([Landroid/os/IBinder;)V", ref global::android.os.Parcel._m62, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m63;
		public void writeTypedList(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeTypedList", "(Ljava/util/List;)V", ref global::android.os.Parcel._m63, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m64;
		public void writeStringList(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeStringList", "(Ljava/util/List;)V", ref global::android.os.Parcel._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		public void writeBinderList(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeBinderList", "(Ljava/util/List;)V", ref global::android.os.Parcel._m65, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m66;
		public void writeTypedArray(android.os.Parcelable[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeTypedArray", "([Landroid/os/Parcelable;I)V", ref global::android.os.Parcel._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		public void writeParcelable(android.os.Parcelable arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeParcelable", "(Landroid/os/Parcelable;I)V", ref global::android.os.Parcel._m67, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m68;
		public void writeSerializable(java.io.Serializable arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeSerializable", "(Ljava/io/Serializable;)V", ref global::android.os.Parcel._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m69;
		public void writeException(java.lang.Exception arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeException", "(Ljava/lang/Exception;)V", ref global::android.os.Parcel._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		public void writeNoException()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeNoException", "()V", ref global::android.os.Parcel._m70);
		}
		private static global::MonoJavaBridge.MethodId _m71;
		public void readException()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readException", "()V", ref global::android.os.Parcel._m71);
		}
		private static global::MonoJavaBridge.MethodId _m72;
		public void readException(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readException", "(ILjava/lang/String;)V", ref global::android.os.Parcel._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		public global::android.os.IBinder readStrongBinder()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.os.Parcel.staticClass, "readStrongBinder", "()Landroid/os/IBinder;", ref global::android.os.Parcel._m73) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m74;
		public global::android.os.ParcelFileDescriptor readFileDescriptor()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;", ref global::android.os.Parcel._m74) as android.os.ParcelFileDescriptor;
		}
		private static global::MonoJavaBridge.MethodId _m75;
		public void readMap(java.util.Map arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V", ref global::android.os.Parcel._m75, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m76;
		public void readList(java.util.List arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V", ref global::android.os.Parcel._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		public global::java.util.HashMap readHashMap(java.lang.ClassLoader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;", ref global::android.os.Parcel._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.HashMap;
		}
		private static global::MonoJavaBridge.MethodId _m78;
		public global::android.os.Bundle readBundle()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.os.Parcel.staticClass, "readBundle", "()Landroid/os/Bundle;", ref global::android.os.Parcel._m78) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m79;
		public global::android.os.Bundle readBundle(java.lang.ClassLoader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.Bundle>(this, global::android.os.Parcel.staticClass, "readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;", ref global::android.os.Parcel._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Bundle;
		}
		private static global::MonoJavaBridge.MethodId _m80;
		public byte[] createByteArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<byte>(this, global::android.os.Parcel.staticClass, "createByteArray", "()[B", ref global::android.os.Parcel._m80) as byte[];
		}
		private static global::MonoJavaBridge.MethodId _m81;
		public void readByteArray(byte[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readByteArray", "([B)V", ref global::android.os.Parcel._m81, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m82;
		public global::java.util.ArrayList readArrayList(java.lang.ClassLoader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;", ref global::android.os.Parcel._m82, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m83;
		public global::java.lang.Object[] readArray(java.lang.ClassLoader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.os.Parcel.staticClass, "readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;", ref global::android.os.Parcel._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m84;
		public global::android.util.SparseArray readSparseArray(java.lang.ClassLoader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;", ref global::android.os.Parcel._m84, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.util.SparseArray;
		}
		private static global::MonoJavaBridge.MethodId _m85;
		public global::android.util.SparseBooleanArray readSparseBooleanArray()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;", ref global::android.os.Parcel._m85) as android.util.SparseBooleanArray;
		}
		private static global::MonoJavaBridge.MethodId _m86;
		public global::java.util.ArrayList createTypedArrayList(android.os.Parcelable_Creator arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;", ref global::android.os.Parcel._m86, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m87;
		public void readTypedList(java.util.List arg0, android.os.Parcelable_Creator arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V", ref global::android.os.Parcel._m87, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m88;
		public global::java.util.ArrayList createStringArrayList()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "createStringArrayList", "()Ljava/util/ArrayList;", ref global::android.os.Parcel._m88) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m89;
		public global::java.util.ArrayList createBinderArrayList()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "createBinderArrayList", "()Ljava/util/ArrayList;", ref global::android.os.Parcel._m89) as java.util.ArrayList;
		}
		private static global::MonoJavaBridge.MethodId _m90;
		public void readStringList(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readStringList", "(Ljava/util/List;)V", ref global::android.os.Parcel._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		public void readBinderList(java.util.List arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readBinderList", "(Ljava/util/List;)V", ref global::android.os.Parcel._m91, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m92;
		public global::java.lang.Object[] createTypedArray(android.os.Parcelable_Creator arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.Object>(this, global::android.os.Parcel.staticClass, "createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;", ref global::android.os.Parcel._m92, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object[];
		}
		private static global::MonoJavaBridge.MethodId _m93;
		public void readTypedArray(java.lang.Object[] arg0, android.os.Parcelable_Creator arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V", ref global::android.os.Parcel._m93, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m94;
		public void writeParcelableArray(android.os.Parcelable[] arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.Parcel.staticClass, "writeParcelableArray", "([Landroid/os/Parcelable;I)V", ref global::android.os.Parcel._m94, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m95;
		public global::java.lang.Object readValue(java.lang.ClassLoader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.Parcel.staticClass, "readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;", ref global::android.os.Parcel._m95, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m96;
		public global::android.os.Parcelable readParcelable(java.lang.ClassLoader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.Parcelable>(this, global::android.os.Parcel.staticClass, "readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;", ref global::android.os.Parcel._m96, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable;
		}
		private static global::MonoJavaBridge.MethodId _m97;
		public global::android.os.Parcelable[] readParcelableArray(java.lang.ClassLoader arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<android.os.Parcelable>(this, global::android.os.Parcel.staticClass, "readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;", ref global::android.os.Parcel._m97, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Parcelable[];
		}
		private static global::MonoJavaBridge.MethodId _m98;
		public global::java.io.Serializable readSerializable()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.io.Serializable>(this, global::android.os.Parcel.staticClass, "readSerializable", "()Ljava/io/Serializable;", ref global::android.os.Parcel._m98) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.FieldId _STRING_CREATOR4010;
		public static global::android.os.Parcelable_Creator STRING_CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Parcel.staticClass, _STRING_CREATOR4010)) as android.os.Parcelable_Creator;
			}
		}
		static Parcel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Parcel.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Parcel"));
			global::android.os.Parcel._STRING_CREATOR4010 = @__env.GetStaticFieldIDNoThrow(global::android.os.Parcel.staticClass, "STRING_CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
