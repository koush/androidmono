namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Parcel : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Parcel()
		{
			InitJNI();
		}
		internal Parcel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeInt6534;
		public void writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeInt6534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInt6534, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readInt6535;
		public int readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._readInt6535);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readInt6535);
		}
		internal static global::MonoJavaBridge.MethodId _readLong6536;
		public long readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Parcel._readLong6536);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLong6536);
		}
		internal static global::MonoJavaBridge.MethodId _readByte6537;
		public byte readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::android.os.Parcel._readByte6537);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByte6537);
		}
		internal static global::MonoJavaBridge.MethodId _writeLong6538;
		public void writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeLong6538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLong6538, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte6539;
		public void writeByte(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByte6539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByte6539, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat6540;
		public void writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFloat6540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloat6540, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFloat6541;
		public float readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.os.Parcel._readFloat6541);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloat6541);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble6542;
		public double readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.os.Parcel._readDouble6542);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDouble6542);
		}
		internal static global::MonoJavaBridge.MethodId _readString6543;
		public global::java.lang.String readString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readString6543)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readString6543)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dataSize6544;
		public int dataSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataSize6544);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataSize6544);
		}
		internal static global::MonoJavaBridge.MethodId _writeValue6545;
		public void writeValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeValue6545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeValue6545, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeString6546;
		public void writeString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeString6546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeString6546, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtain6547;
		public static global::android.os.Parcel obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Parcel.staticClass, global::android.os.Parcel._obtain6547)) as android.os.Parcel;
		}
		internal static global::MonoJavaBridge.MethodId _recycle6548;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._recycle6548);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._recycle6548);
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors6549;
		public bool hasFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Parcel._hasFileDescriptors6549);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._hasFileDescriptors6549);
		}
		internal static global::MonoJavaBridge.MethodId _dataAvail6550;
		public int dataAvail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataAvail6550);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataAvail6550);
		}
		internal static global::MonoJavaBridge.MethodId _dataPosition6551;
		public int dataPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataPosition6551);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataPosition6551);
		}
		internal static global::MonoJavaBridge.MethodId _dataCapacity6552;
		public int dataCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataCapacity6552);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataCapacity6552);
		}
		internal static global::MonoJavaBridge.MethodId _setDataSize6553;
		public void setDataSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataSize6553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataSize6553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataPosition6554;
		public void setDataPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataPosition6554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataPosition6554, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataCapacity6555;
		public void setDataCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataCapacity6555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataCapacity6555, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _marshall6556;
		public byte[] marshall() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._marshall6556)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._marshall6556)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _unmarshall6557;
		public void unmarshall(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._unmarshall6557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._unmarshall6557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _appendFrom6558;
		public void appendFrom(android.os.Parcel arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._appendFrom6558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._appendFrom6558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeInterfaceToken6559;
		public void writeInterfaceToken(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeInterfaceToken6559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInterfaceToken6559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforceInterface6560;
		public void enforceInterface(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._enforceInterface6560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._enforceInterface6560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByteArray6561;
		public void writeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByteArray6561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray6561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeByteArray6562;
		public void writeByteArray(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByteArray6562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray6562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble6563;
		public void writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeDouble6563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDouble6563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStrongBinder6564;
		public void writeStrongBinder(android.os.IBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStrongBinder6564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongBinder6564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStrongInterface6565;
		public void writeStrongInterface(android.os.IInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStrongInterface6565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongInterface6565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFileDescriptor6566;
		public void writeFileDescriptor(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFileDescriptor6566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFileDescriptor6566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeMap6567;
		public void writeMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeMap6567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeMap6567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBundle6568;
		public void writeBundle(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBundle6568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBundle6568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeList6569;
		public void writeList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeList6569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeList6569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeArray6570;
		public void writeArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeArray6570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeArray6570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeSparseArray6571;
		public void writeSparseArray(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSparseArray6571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseArray6571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeSparseBooleanArray6572;
		public void writeSparseBooleanArray(android.util.SparseBooleanArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSparseBooleanArray6572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseBooleanArray6572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBooleanArray6573;
		public void writeBooleanArray(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBooleanArray6573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBooleanArray6573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createBooleanArray6574;
		public bool[] createBooleanArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBooleanArray6574)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBooleanArray6574)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _readBooleanArray6575;
		public void readBooleanArray(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBooleanArray6575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBooleanArray6575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeCharArray6576;
		public void writeCharArray(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeCharArray6576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeCharArray6576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createCharArray6577;
		public char[] createCharArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createCharArray6577)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createCharArray6577)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _readCharArray6578;
		public void readCharArray(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readCharArray6578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readCharArray6578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeIntArray6579;
		public void writeIntArray(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeIntArray6579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeIntArray6579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createIntArray6580;
		public int[] createIntArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createIntArray6580)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createIntArray6580)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _readIntArray6581;
		public void readIntArray(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readIntArray6581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readIntArray6581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLongArray6582;
		public void writeLongArray(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeLongArray6582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLongArray6582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createLongArray6583;
		public long[] createLongArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createLongArray6583)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createLongArray6583)) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _readLongArray6584;
		public void readLongArray(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readLongArray6584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLongArray6584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloatArray6585;
		public void writeFloatArray(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFloatArray6585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloatArray6585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFloatArray6586;
		public float[] createFloatArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createFloatArray6586)) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createFloatArray6586)) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _readFloatArray6587;
		public void readFloatArray(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readFloatArray6587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloatArray6587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDoubleArray6588;
		public void writeDoubleArray(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeDoubleArray6588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDoubleArray6588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createDoubleArray6589;
		public double[] createDoubleArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createDoubleArray6589)) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createDoubleArray6589)) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _readDoubleArray6590;
		public void readDoubleArray(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readDoubleArray6590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDoubleArray6590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStringArray6591;
		public void writeStringArray(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStringArray6591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringArray6591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createStringArray6592;
		public global::java.lang.String[] createStringArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createStringArray6592)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArray6592)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _readStringArray6593;
		public void readStringArray(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readStringArray6593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringArray6593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinderArray6594;
		public void writeBinderArray(android.os.IBinder[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBinderArray6594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderArray6594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createBinderArray6595;
		public global::android.os.IBinder[] createBinderArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBinderArray6595)) as android.os.IBinder[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArray6595)) as android.os.IBinder[];
		}
		internal static global::MonoJavaBridge.MethodId _readBinderArray6596;
		public void readBinderArray(android.os.IBinder[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBinderArray6596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderArray6596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTypedList6597;
		public void writeTypedList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeTypedList6597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedList6597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStringList6598;
		public void writeStringList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStringList6598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringList6598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinderList6599;
		public void writeBinderList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBinderList6599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderList6599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTypedArray6600;
		public void writeTypedArray(android.os.Parcelable[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeTypedArray6600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedArray6600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeParcelable6601;
		public void writeParcelable(android.os.Parcelable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeParcelable6601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelable6601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeSerializable6602;
		public void writeSerializable(java.io.Serializable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSerializable6602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSerializable6602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeException6603;
		public void writeException(java.lang.Exception arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeException6603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeException6603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeNoException6604;
		public void writeNoException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeNoException6604);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeNoException6604);
		}
		internal static global::MonoJavaBridge.MethodId _readException6605;
		public void readException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readException6605);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException6605);
		}
		internal static global::MonoJavaBridge.MethodId _readException6606;
		public void readException(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readException6606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException6606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readStrongBinder6607;
		public global::android.os.IBinder readStrongBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readStrongBinder6607)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStrongBinder6607)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _readFileDescriptor6608;
		public global::android.os.ParcelFileDescriptor readFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readFileDescriptor6608)) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFileDescriptor6608)) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _readMap6609;
		public void readMap(java.util.Map arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readMap6609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readMap6609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readList6610;
		public void readList(java.util.List arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readList6610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readList6610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readHashMap6611;
		public global::java.util.HashMap readHashMap(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readHashMap6611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.HashMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readHashMap6611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.HashMap;
		}
		internal static global::MonoJavaBridge.MethodId _readBundle6612;
		public global::android.os.Bundle readBundle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readBundle6612)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle6612)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _readBundle6613;
		public global::android.os.Bundle readBundle(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readBundle6613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle6613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _createByteArray6614;
		public byte[] createByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createByteArray6614)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createByteArray6614)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _readByteArray6615;
		public void readByteArray(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readByteArray6615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByteArray6615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readArrayList6616;
		public global::java.util.ArrayList readArrayList(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readArrayList6616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArrayList6616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readArray6617;
		public global::java.lang.Object[] readArray(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readArray6617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArray6617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _readSparseArray6618;
		public global::android.util.SparseArray readSparseArray(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSparseArray6618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseArray6618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
		}
		internal static global::MonoJavaBridge.MethodId _readSparseBooleanArray6619;
		public global::android.util.SparseBooleanArray readSparseBooleanArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSparseBooleanArray6619)) as android.util.SparseBooleanArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseBooleanArray6619)) as android.util.SparseBooleanArray;
		}
		internal static global::MonoJavaBridge.MethodId _createTypedArrayList6620;
		public global::java.util.ArrayList createTypedArrayList(android.os.Parcelable_Creator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createTypedArrayList6620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArrayList6620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readTypedList6621;
		public void readTypedList(java.util.List arg0, android.os.Parcelable_Creator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readTypedList6621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedList6621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createStringArrayList6622;
		public global::java.util.ArrayList createStringArrayList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createStringArrayList6622)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArrayList6622)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _createBinderArrayList6623;
		public global::java.util.ArrayList createBinderArrayList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBinderArrayList6623)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArrayList6623)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readStringList6624;
		public void readStringList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readStringList6624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringList6624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBinderList6625;
		public void readBinderList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBinderList6625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderList6625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createTypedArray6626;
		public global::java.lang.Object[] createTypedArray(android.os.Parcelable_Creator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createTypedArray6626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArray6626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _readTypedArray6627;
		public void readTypedArray(java.lang.Object[] arg0, android.os.Parcelable_Creator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readTypedArray6627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedArray6627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeParcelableArray6628;
		public void writeParcelableArray(android.os.Parcelable[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeParcelableArray6628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelableArray6628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readValue6629;
		public global::java.lang.Object readValue(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readValue6629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readValue6629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readParcelable6630;
		public global::android.os.Parcelable readParcelable(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readParcelable6630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelable6630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _readParcelableArray6631;
		public global::android.os.Parcelable[] readParcelableArray(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readParcelableArray6631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelableArray6631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _readSerializable6632;
		public global::java.io.Serializable readSerializable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSerializable6632)) as java.io.Serializable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSerializable6632)) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.FieldId _STRING_CREATOR6633;
		public static global::android.os.Parcelable_Creator STRING_CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Parcel.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Parcel"));
			global::android.os.Parcel._writeInt6534 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeInt", "(I)V");
			global::android.os.Parcel._readInt6535 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readInt", "()I");
			global::android.os.Parcel._readLong6536 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readLong", "()J");
			global::android.os.Parcel._readByte6537 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readByte", "()B");
			global::android.os.Parcel._writeLong6538 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeLong", "(J)V");
			global::android.os.Parcel._writeByte6539 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByte", "(B)V");
			global::android.os.Parcel._writeFloat6540 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFloat", "(F)V");
			global::android.os.Parcel._readFloat6541 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFloat", "()F");
			global::android.os.Parcel._readDouble6542 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readDouble", "()D");
			global::android.os.Parcel._readString6543 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readString", "()Ljava/lang/String;");
			global::android.os.Parcel._dataSize6544 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataSize", "()I");
			global::android.os.Parcel._writeValue6545 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeValue", "(Ljava/lang/Object;)V");
			global::android.os.Parcel._writeString6546 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeString", "(Ljava/lang/String;)V");
			global::android.os.Parcel._obtain6547 = @__env.GetStaticMethodIDNoThrow(global::android.os.Parcel.staticClass, "obtain", "()Landroid/os/Parcel;");
			global::android.os.Parcel._recycle6548 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "recycle", "()V");
			global::android.os.Parcel._hasFileDescriptors6549 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "hasFileDescriptors", "()Z");
			global::android.os.Parcel._dataAvail6550 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataAvail", "()I");
			global::android.os.Parcel._dataPosition6551 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataPosition", "()I");
			global::android.os.Parcel._dataCapacity6552 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataCapacity", "()I");
			global::android.os.Parcel._setDataSize6553 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataSize", "(I)V");
			global::android.os.Parcel._setDataPosition6554 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataPosition", "(I)V");
			global::android.os.Parcel._setDataCapacity6555 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataCapacity", "(I)V");
			global::android.os.Parcel._marshall6556 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "marshall", "()[B");
			global::android.os.Parcel._unmarshall6557 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "unmarshall", "([BII)V");
			global::android.os.Parcel._appendFrom6558 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "appendFrom", "(Landroid/os/Parcel;II)V");
			global::android.os.Parcel._writeInterfaceToken6559 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeInterfaceToken", "(Ljava/lang/String;)V");
			global::android.os.Parcel._enforceInterface6560 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "enforceInterface", "(Ljava/lang/String;)V");
			global::android.os.Parcel._writeByteArray6561 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByteArray", "([BII)V");
			global::android.os.Parcel._writeByteArray6562 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByteArray", "([B)V");
			global::android.os.Parcel._writeDouble6563 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeDouble", "(D)V");
			global::android.os.Parcel._writeStrongBinder6564 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStrongBinder", "(Landroid/os/IBinder;)V");
			global::android.os.Parcel._writeStrongInterface6565 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStrongInterface", "(Landroid/os/IInterface;)V");
			global::android.os.Parcel._writeFileDescriptor6566 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFileDescriptor", "(Ljava/io/FileDescriptor;)V");
			global::android.os.Parcel._writeMap6567 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeMap", "(Ljava/util/Map;)V");
			global::android.os.Parcel._writeBundle6568 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBundle", "(Landroid/os/Bundle;)V");
			global::android.os.Parcel._writeList6569 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeArray6570 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeArray", "([Ljava/lang/Object;)V");
			global::android.os.Parcel._writeSparseArray6571 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSparseArray", "(Landroid/util/SparseArray;)V");
			global::android.os.Parcel._writeSparseBooleanArray6572 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V");
			global::android.os.Parcel._writeBooleanArray6573 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBooleanArray", "([Z)V");
			global::android.os.Parcel._createBooleanArray6574 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBooleanArray", "()[Z");
			global::android.os.Parcel._readBooleanArray6575 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBooleanArray", "([Z)V");
			global::android.os.Parcel._writeCharArray6576 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeCharArray", "([C)V");
			global::android.os.Parcel._createCharArray6577 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createCharArray", "()[C");
			global::android.os.Parcel._readCharArray6578 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readCharArray", "([C)V");
			global::android.os.Parcel._writeIntArray6579 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeIntArray", "([I)V");
			global::android.os.Parcel._createIntArray6580 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createIntArray", "()[I");
			global::android.os.Parcel._readIntArray6581 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readIntArray", "([I)V");
			global::android.os.Parcel._writeLongArray6582 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeLongArray", "([J)V");
			global::android.os.Parcel._createLongArray6583 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createLongArray", "()[J");
			global::android.os.Parcel._readLongArray6584 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readLongArray", "([J)V");
			global::android.os.Parcel._writeFloatArray6585 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFloatArray", "([F)V");
			global::android.os.Parcel._createFloatArray6586 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createFloatArray", "()[F");
			global::android.os.Parcel._readFloatArray6587 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFloatArray", "([F)V");
			global::android.os.Parcel._writeDoubleArray6588 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeDoubleArray", "([D)V");
			global::android.os.Parcel._createDoubleArray6589 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createDoubleArray", "()[D");
			global::android.os.Parcel._readDoubleArray6590 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readDoubleArray", "([D)V");
			global::android.os.Parcel._writeStringArray6591 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStringArray", "([Ljava/lang/String;)V");
			global::android.os.Parcel._createStringArray6592 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createStringArray", "()[Ljava/lang/String;");
			global::android.os.Parcel._readStringArray6593 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStringArray", "([Ljava/lang/String;)V");
			global::android.os.Parcel._writeBinderArray6594 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBinderArray", "([Landroid/os/IBinder;)V");
			global::android.os.Parcel._createBinderArray6595 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBinderArray", "()[Landroid/os/IBinder;");
			global::android.os.Parcel._readBinderArray6596 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBinderArray", "([Landroid/os/IBinder;)V");
			global::android.os.Parcel._writeTypedList6597 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeTypedList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeStringList6598 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStringList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeBinderList6599 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBinderList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeTypedArray6600 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeTypedArray", "([Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._writeParcelable6601 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeParcelable", "(Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._writeSerializable6602 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSerializable", "(Ljava/io/Serializable;)V");
			global::android.os.Parcel._writeException6603 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeException", "(Ljava/lang/Exception;)V");
			global::android.os.Parcel._writeNoException6604 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeNoException", "()V");
			global::android.os.Parcel._readException6605 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readException", "()V");
			global::android.os.Parcel._readException6606 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readException", "(ILjava/lang/String;)V");
			global::android.os.Parcel._readStrongBinder6607 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStrongBinder", "()Landroid/os/IBinder;");
			global::android.os.Parcel._readFileDescriptor6608 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
			global::android.os.Parcel._readMap6609 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V");
			global::android.os.Parcel._readList6610 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V");
			global::android.os.Parcel._readHashMap6611 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;");
			global::android.os.Parcel._readBundle6612 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBundle", "()Landroid/os/Bundle;");
			global::android.os.Parcel._readBundle6613 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;");
			global::android.os.Parcel._createByteArray6614 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createByteArray", "()[B");
			global::android.os.Parcel._readByteArray6615 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readByteArray", "([B)V");
			global::android.os.Parcel._readArrayList6616 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;");
			global::android.os.Parcel._readArray6617 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;");
			global::android.os.Parcel._readSparseArray6618 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;");
			global::android.os.Parcel._readSparseBooleanArray6619 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;");
			global::android.os.Parcel._createTypedArrayList6620 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;");
			global::android.os.Parcel._readTypedList6621 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V");
			global::android.os.Parcel._createStringArrayList6622 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createStringArrayList", "()Ljava/util/ArrayList;");
			global::android.os.Parcel._createBinderArrayList6623 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBinderArrayList", "()Ljava/util/ArrayList;");
			global::android.os.Parcel._readStringList6624 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStringList", "(Ljava/util/List;)V");
			global::android.os.Parcel._readBinderList6625 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBinderList", "(Ljava/util/List;)V");
			global::android.os.Parcel._createTypedArray6626 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;");
			global::android.os.Parcel._readTypedArray6627 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V");
			global::android.os.Parcel._writeParcelableArray6628 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeParcelableArray", "([Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._readValue6629 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;");
			global::android.os.Parcel._readParcelable6630 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;");
			global::android.os.Parcel._readParcelableArray6631 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;");
			global::android.os.Parcel._readSerializable6632 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSerializable", "()Ljava/io/Serializable;");
		}
	}
}
