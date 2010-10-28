namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Parcel : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Parcel(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _writeInt9977;
		public void writeInt(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeInt9977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInt9977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readInt9978;
		public int readInt()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._readInt9978);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readInt9978);
		}
		internal static global::MonoJavaBridge.MethodId _readLong9979;
		public long readLong()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Parcel._readLong9979);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLong9979);
		}
		internal static global::MonoJavaBridge.MethodId _readByte9980;
		public byte readByte()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::android.os.Parcel._readByte9980);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByte9980);
		}
		internal static global::MonoJavaBridge.MethodId _writeLong9981;
		public void writeLong(long arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeLong9981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLong9981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte9982;
		public void writeByte(byte arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByte9982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByte9982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat9983;
		public void writeFloat(float arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFloat9983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloat9983, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFloat9984;
		public float readFloat()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.os.Parcel._readFloat9984);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloat9984);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble9985;
		public double readDouble()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.os.Parcel._readDouble9985);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDouble9985);
		}
		internal static global::MonoJavaBridge.MethodId _readString9986;
		public global::java.lang.String readString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readString9986)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readString9986)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dataSize9987;
		public int dataSize()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataSize9987);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataSize9987);
		}
		internal static global::MonoJavaBridge.MethodId _writeValue9988;
		public void writeValue(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeValue9988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeValue9988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeString9989;
		public void writeString(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeString9989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeString9989, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtain9990;
		public static global::android.os.Parcel obtain()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Parcel>(@__env.CallStaticObjectMethod(android.os.Parcel.staticClass, global::android.os.Parcel._obtain9990)) as android.os.Parcel;
		}
		internal static global::MonoJavaBridge.MethodId _recycle9991;
		public void recycle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._recycle9991);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._recycle9991);
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors9992;
		public bool hasFileDescriptors()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Parcel._hasFileDescriptors9992);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._hasFileDescriptors9992);
		}
		internal static global::MonoJavaBridge.MethodId _dataAvail9993;
		public int dataAvail()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataAvail9993);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataAvail9993);
		}
		internal static global::MonoJavaBridge.MethodId _dataPosition9994;
		public int dataPosition()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataPosition9994);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataPosition9994);
		}
		internal static global::MonoJavaBridge.MethodId _dataCapacity9995;
		public int dataCapacity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataCapacity9995);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataCapacity9995);
		}
		internal static global::MonoJavaBridge.MethodId _setDataSize9996;
		public void setDataSize(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataSize9996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataSize9996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataPosition9997;
		public void setDataPosition(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataPosition9997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataPosition9997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataCapacity9998;
		public void setDataCapacity(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataCapacity9998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataCapacity9998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _marshall9999;
		public byte[] marshall()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._marshall9999)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._marshall9999)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _unmarshall10000;
		public void unmarshall(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._unmarshall10000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._unmarshall10000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _appendFrom10001;
		public void appendFrom(android.os.Parcel arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._appendFrom10001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._appendFrom10001, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeInterfaceToken10002;
		public void writeInterfaceToken(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeInterfaceToken10002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInterfaceToken10002, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforceInterface10003;
		public void enforceInterface(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._enforceInterface10003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._enforceInterface10003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByteArray10004;
		public void writeByteArray(byte[] arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByteArray10004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray10004, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeByteArray10005;
		public void writeByteArray(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByteArray10005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray10005, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble10006;
		public void writeDouble(double arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeDouble10006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDouble10006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStrongBinder10007;
		public void writeStrongBinder(android.os.IBinder arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStrongBinder10007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongBinder10007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStrongInterface10008;
		public void writeStrongInterface(android.os.IInterface arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStrongInterface10008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongInterface10008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public void writeStrongInterface(global::android.os.IInterfaceDelegate arg0)
		{
			writeStrongInterface((global::android.os.IInterfaceDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _writeFileDescriptor10009;
		public void writeFileDescriptor(java.io.FileDescriptor arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFileDescriptor10009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFileDescriptor10009, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeMap10010;
		public void writeMap(java.util.Map arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeMap10010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeMap10010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBundle10011;
		public void writeBundle(android.os.Bundle arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBundle10011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBundle10011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeList10012;
		public void writeList(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeList10012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeList10012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeArray10013;
		public void writeArray(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeArray10013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeArray10013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeSparseArray10014;
		public void writeSparseArray(android.util.SparseArray arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSparseArray10014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseArray10014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeSparseBooleanArray10015;
		public void writeSparseBooleanArray(android.util.SparseBooleanArray arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSparseBooleanArray10015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseBooleanArray10015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBooleanArray10016;
		public void writeBooleanArray(bool[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBooleanArray10016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBooleanArray10016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createBooleanArray10017;
		public bool[] createBooleanArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBooleanArray10017)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBooleanArray10017)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _readBooleanArray10018;
		public void readBooleanArray(bool[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBooleanArray10018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBooleanArray10018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeCharArray10019;
		public void writeCharArray(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeCharArray10019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeCharArray10019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createCharArray10020;
		public char[] createCharArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createCharArray10020)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createCharArray10020)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _readCharArray10021;
		public void readCharArray(char[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readCharArray10021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readCharArray10021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeIntArray10022;
		public void writeIntArray(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeIntArray10022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeIntArray10022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createIntArray10023;
		public int[] createIntArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createIntArray10023)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createIntArray10023)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _readIntArray10024;
		public void readIntArray(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readIntArray10024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readIntArray10024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLongArray10025;
		public void writeLongArray(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeLongArray10025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLongArray10025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createLongArray10026;
		public long[] createLongArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createLongArray10026)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createLongArray10026)) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _readLongArray10027;
		public void readLongArray(long[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readLongArray10027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLongArray10027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloatArray10028;
		public void writeFloatArray(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFloatArray10028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloatArray10028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFloatArray10029;
		public float[] createFloatArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createFloatArray10029)) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createFloatArray10029)) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _readFloatArray10030;
		public void readFloatArray(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readFloatArray10030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloatArray10030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDoubleArray10031;
		public void writeDoubleArray(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeDoubleArray10031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDoubleArray10031, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createDoubleArray10032;
		public double[] createDoubleArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createDoubleArray10032)) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createDoubleArray10032)) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _readDoubleArray10033;
		public void readDoubleArray(double[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readDoubleArray10033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDoubleArray10033, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStringArray10034;
		public void writeStringArray(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStringArray10034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringArray10034, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createStringArray10035;
		public global::java.lang.String[] createStringArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createStringArray10035)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArray10035)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _readStringArray10036;
		public void readStringArray(java.lang.String[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readStringArray10036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringArray10036, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinderArray10037;
		public void writeBinderArray(android.os.IBinder[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBinderArray10037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderArray10037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createBinderArray10038;
		public global::android.os.IBinder[] createBinderArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBinderArray10038)) as android.os.IBinder[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArray10038)) as android.os.IBinder[];
		}
		internal static global::MonoJavaBridge.MethodId _readBinderArray10039;
		public void readBinderArray(android.os.IBinder[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBinderArray10039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderArray10039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTypedList10040;
		public void writeTypedList(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeTypedList10040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedList10040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStringList10041;
		public void writeStringList(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStringList10041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringList10041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinderList10042;
		public void writeBinderList(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBinderList10042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderList10042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTypedArray10043;
		public void writeTypedArray(android.os.Parcelable[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeTypedArray10043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedArray10043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeParcelable10044;
		public void writeParcelable(android.os.Parcelable arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeParcelable10044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelable10044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeSerializable10045;
		public void writeSerializable(java.io.Serializable arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSerializable10045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSerializable10045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeException10046;
		public void writeException(java.lang.Exception arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeException10046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeException10046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeNoException10047;
		public void writeNoException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeNoException10047);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeNoException10047);
		}
		internal static global::MonoJavaBridge.MethodId _readException10048;
		public void readException()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readException10048);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException10048);
		}
		internal static global::MonoJavaBridge.MethodId _readException10049;
		public void readException(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readException10049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException10049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readStrongBinder10050;
		public global::android.os.IBinder readStrongBinder()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readStrongBinder10050)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStrongBinder10050)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _readFileDescriptor10051;
		public global::android.os.ParcelFileDescriptor readFileDescriptor()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readFileDescriptor10051)) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFileDescriptor10051)) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _readMap10052;
		public void readMap(java.util.Map arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readMap10052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readMap10052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readList10053;
		public void readList(java.util.List arg0, java.lang.ClassLoader arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readList10053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readList10053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readHashMap10054;
		public global::java.util.HashMap readHashMap(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readHashMap10054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.HashMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readHashMap10054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.HashMap;
		}
		internal static global::MonoJavaBridge.MethodId _readBundle10055;
		public global::android.os.Bundle readBundle()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readBundle10055)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle10055)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _readBundle10056;
		public global::android.os.Bundle readBundle(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readBundle10056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.Bundle>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle10056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _createByteArray10057;
		public byte[] createByteArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createByteArray10057)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createByteArray10057)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _readByteArray10058;
		public void readByteArray(byte[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readByteArray10058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByteArray10058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readArrayList10059;
		public global::java.util.ArrayList readArrayList(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readArrayList10059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArrayList10059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readArray10060;
		public global::java.lang.Object[] readArray(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readArray10060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArray10060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _readSparseArray10061;
		public global::android.util.SparseArray readSparseArray(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSparseArray10061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseArray10061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
		}
		internal static global::MonoJavaBridge.MethodId _readSparseBooleanArray10062;
		public global::android.util.SparseBooleanArray readSparseBooleanArray()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSparseBooleanArray10062)) as android.util.SparseBooleanArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseBooleanArray10062)) as android.util.SparseBooleanArray;
		}
		internal static global::MonoJavaBridge.MethodId _createTypedArrayList10063;
		public global::java.util.ArrayList createTypedArrayList(android.os.Parcelable_Creator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createTypedArrayList10063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArrayList10063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readTypedList10064;
		public void readTypedList(java.util.List arg0, android.os.Parcelable_Creator arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readTypedList10064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedList10064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createStringArrayList10065;
		public global::java.util.ArrayList createStringArrayList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createStringArrayList10065)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArrayList10065)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _createBinderArrayList10066;
		public global::java.util.ArrayList createBinderArrayList()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBinderArrayList10066)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArrayList10066)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readStringList10067;
		public void readStringList(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readStringList10067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringList10067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBinderList10068;
		public void readBinderList(java.util.List arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBinderList10068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderList10068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createTypedArray10069;
		public global::java.lang.Object[] createTypedArray(android.os.Parcelable_Creator arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createTypedArray10069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArray10069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _readTypedArray10070;
		public void readTypedArray(java.lang.Object[] arg0, android.os.Parcelable_Creator arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readTypedArray10070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedArray10070, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeParcelableArray10071;
		public void writeParcelableArray(android.os.Parcelable[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeParcelableArray10071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelableArray10071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readValue10072;
		public global::java.lang.Object readValue(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readValue10072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readValue10072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readParcelable10073;
		public global::android.os.Parcelable readParcelable(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readParcelable10073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelable10073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _readParcelableArray10074;
		public global::android.os.Parcelable[] readParcelableArray(java.lang.ClassLoader arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readParcelableArray10074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelableArray10074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _readSerializable10075;
		public global::java.io.Serializable readSerializable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSerializable10075)) as java.io.Serializable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSerializable10075)) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.FieldId _STRING_CREATOR10076;
		public static global::android.os.Parcelable_Creator STRING_CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Parcel.staticClass, _STRING_CREATOR10076)) as android.os.Parcelable_Creator;
			}
		}
		static Parcel()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Parcel.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Parcel"));
			global::android.os.Parcel._writeInt9977 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeInt", "(I)V");
			global::android.os.Parcel._readInt9978 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readInt", "()I");
			global::android.os.Parcel._readLong9979 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readLong", "()J");
			global::android.os.Parcel._readByte9980 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readByte", "()B");
			global::android.os.Parcel._writeLong9981 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeLong", "(J)V");
			global::android.os.Parcel._writeByte9982 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByte", "(B)V");
			global::android.os.Parcel._writeFloat9983 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFloat", "(F)V");
			global::android.os.Parcel._readFloat9984 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFloat", "()F");
			global::android.os.Parcel._readDouble9985 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readDouble", "()D");
			global::android.os.Parcel._readString9986 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readString", "()Ljava/lang/String;");
			global::android.os.Parcel._dataSize9987 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataSize", "()I");
			global::android.os.Parcel._writeValue9988 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeValue", "(Ljava/lang/Object;)V");
			global::android.os.Parcel._writeString9989 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeString", "(Ljava/lang/String;)V");
			global::android.os.Parcel._obtain9990 = @__env.GetStaticMethodIDNoThrow(global::android.os.Parcel.staticClass, "obtain", "()Landroid/os/Parcel;");
			global::android.os.Parcel._recycle9991 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "recycle", "()V");
			global::android.os.Parcel._hasFileDescriptors9992 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "hasFileDescriptors", "()Z");
			global::android.os.Parcel._dataAvail9993 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataAvail", "()I");
			global::android.os.Parcel._dataPosition9994 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataPosition", "()I");
			global::android.os.Parcel._dataCapacity9995 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataCapacity", "()I");
			global::android.os.Parcel._setDataSize9996 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataSize", "(I)V");
			global::android.os.Parcel._setDataPosition9997 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataPosition", "(I)V");
			global::android.os.Parcel._setDataCapacity9998 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataCapacity", "(I)V");
			global::android.os.Parcel._marshall9999 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "marshall", "()[B");
			global::android.os.Parcel._unmarshall10000 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "unmarshall", "([BII)V");
			global::android.os.Parcel._appendFrom10001 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "appendFrom", "(Landroid/os/Parcel;II)V");
			global::android.os.Parcel._writeInterfaceToken10002 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeInterfaceToken", "(Ljava/lang/String;)V");
			global::android.os.Parcel._enforceInterface10003 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "enforceInterface", "(Ljava/lang/String;)V");
			global::android.os.Parcel._writeByteArray10004 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByteArray", "([BII)V");
			global::android.os.Parcel._writeByteArray10005 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByteArray", "([B)V");
			global::android.os.Parcel._writeDouble10006 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeDouble", "(D)V");
			global::android.os.Parcel._writeStrongBinder10007 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStrongBinder", "(Landroid/os/IBinder;)V");
			global::android.os.Parcel._writeStrongInterface10008 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStrongInterface", "(Landroid/os/IInterface;)V");
			global::android.os.Parcel._writeFileDescriptor10009 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFileDescriptor", "(Ljava/io/FileDescriptor;)V");
			global::android.os.Parcel._writeMap10010 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeMap", "(Ljava/util/Map;)V");
			global::android.os.Parcel._writeBundle10011 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBundle", "(Landroid/os/Bundle;)V");
			global::android.os.Parcel._writeList10012 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeArray10013 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeArray", "([Ljava/lang/Object;)V");
			global::android.os.Parcel._writeSparseArray10014 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSparseArray", "(Landroid/util/SparseArray;)V");
			global::android.os.Parcel._writeSparseBooleanArray10015 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V");
			global::android.os.Parcel._writeBooleanArray10016 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBooleanArray", "([Z)V");
			global::android.os.Parcel._createBooleanArray10017 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBooleanArray", "()[Z");
			global::android.os.Parcel._readBooleanArray10018 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBooleanArray", "([Z)V");
			global::android.os.Parcel._writeCharArray10019 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeCharArray", "([C)V");
			global::android.os.Parcel._createCharArray10020 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createCharArray", "()[C");
			global::android.os.Parcel._readCharArray10021 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readCharArray", "([C)V");
			global::android.os.Parcel._writeIntArray10022 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeIntArray", "([I)V");
			global::android.os.Parcel._createIntArray10023 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createIntArray", "()[I");
			global::android.os.Parcel._readIntArray10024 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readIntArray", "([I)V");
			global::android.os.Parcel._writeLongArray10025 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeLongArray", "([J)V");
			global::android.os.Parcel._createLongArray10026 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createLongArray", "()[J");
			global::android.os.Parcel._readLongArray10027 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readLongArray", "([J)V");
			global::android.os.Parcel._writeFloatArray10028 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFloatArray", "([F)V");
			global::android.os.Parcel._createFloatArray10029 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createFloatArray", "()[F");
			global::android.os.Parcel._readFloatArray10030 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFloatArray", "([F)V");
			global::android.os.Parcel._writeDoubleArray10031 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeDoubleArray", "([D)V");
			global::android.os.Parcel._createDoubleArray10032 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createDoubleArray", "()[D");
			global::android.os.Parcel._readDoubleArray10033 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readDoubleArray", "([D)V");
			global::android.os.Parcel._writeStringArray10034 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStringArray", "([Ljava/lang/String;)V");
			global::android.os.Parcel._createStringArray10035 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createStringArray", "()[Ljava/lang/String;");
			global::android.os.Parcel._readStringArray10036 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStringArray", "([Ljava/lang/String;)V");
			global::android.os.Parcel._writeBinderArray10037 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBinderArray", "([Landroid/os/IBinder;)V");
			global::android.os.Parcel._createBinderArray10038 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBinderArray", "()[Landroid/os/IBinder;");
			global::android.os.Parcel._readBinderArray10039 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBinderArray", "([Landroid/os/IBinder;)V");
			global::android.os.Parcel._writeTypedList10040 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeTypedList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeStringList10041 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStringList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeBinderList10042 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBinderList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeTypedArray10043 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeTypedArray", "([Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._writeParcelable10044 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeParcelable", "(Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._writeSerializable10045 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSerializable", "(Ljava/io/Serializable;)V");
			global::android.os.Parcel._writeException10046 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeException", "(Ljava/lang/Exception;)V");
			global::android.os.Parcel._writeNoException10047 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeNoException", "()V");
			global::android.os.Parcel._readException10048 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readException", "()V");
			global::android.os.Parcel._readException10049 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readException", "(ILjava/lang/String;)V");
			global::android.os.Parcel._readStrongBinder10050 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStrongBinder", "()Landroid/os/IBinder;");
			global::android.os.Parcel._readFileDescriptor10051 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
			global::android.os.Parcel._readMap10052 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V");
			global::android.os.Parcel._readList10053 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V");
			global::android.os.Parcel._readHashMap10054 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;");
			global::android.os.Parcel._readBundle10055 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBundle", "()Landroid/os/Bundle;");
			global::android.os.Parcel._readBundle10056 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;");
			global::android.os.Parcel._createByteArray10057 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createByteArray", "()[B");
			global::android.os.Parcel._readByteArray10058 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readByteArray", "([B)V");
			global::android.os.Parcel._readArrayList10059 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;");
			global::android.os.Parcel._readArray10060 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;");
			global::android.os.Parcel._readSparseArray10061 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;");
			global::android.os.Parcel._readSparseBooleanArray10062 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;");
			global::android.os.Parcel._createTypedArrayList10063 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;");
			global::android.os.Parcel._readTypedList10064 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V");
			global::android.os.Parcel._createStringArrayList10065 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createStringArrayList", "()Ljava/util/ArrayList;");
			global::android.os.Parcel._createBinderArrayList10066 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBinderArrayList", "()Ljava/util/ArrayList;");
			global::android.os.Parcel._readStringList10067 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStringList", "(Ljava/util/List;)V");
			global::android.os.Parcel._readBinderList10068 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBinderList", "(Ljava/util/List;)V");
			global::android.os.Parcel._createTypedArray10069 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;");
			global::android.os.Parcel._readTypedArray10070 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V");
			global::android.os.Parcel._writeParcelableArray10071 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeParcelableArray", "([Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._readValue10072 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;");
			global::android.os.Parcel._readParcelable10073 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;");
			global::android.os.Parcel._readParcelableArray10074 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;");
			global::android.os.Parcel._readSerializable10075 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSerializable", "()Ljava/io/Serializable;");
			global::android.os.Parcel._STRING_CREATOR10076 = @__env.GetStaticFieldIDNoThrow(global::android.os.Parcel.staticClass, "STRING_CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
