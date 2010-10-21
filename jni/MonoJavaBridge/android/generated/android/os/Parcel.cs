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
		internal static global::MonoJavaBridge.MethodId _writeInt9931;
		public void writeInt(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeInt9931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInt9931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readInt9932;
		public int readInt() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._readInt9932);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readInt9932);
		}
		internal static global::MonoJavaBridge.MethodId _readLong9933;
		public long readLong() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Parcel._readLong9933);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLong9933);
		}
		internal static global::MonoJavaBridge.MethodId _readByte9934;
		public byte readByte() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::android.os.Parcel._readByte9934);
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByte9934);
		}
		internal static global::MonoJavaBridge.MethodId _writeLong9935;
		public void writeLong(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeLong9935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLong9935, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByte9936;
		public void writeByte(byte arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByte9936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByte9936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloat9937;
		public void writeFloat(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFloat9937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloat9937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readFloat9938;
		public float readFloat() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.os.Parcel._readFloat9938);
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloat9938);
		}
		internal static global::MonoJavaBridge.MethodId _readDouble9939;
		public double readDouble() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.os.Parcel._readDouble9939);
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDouble9939);
		}
		internal static global::MonoJavaBridge.MethodId _readString9940;
		public global::java.lang.String readString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readString9940)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readString9940)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _dataSize9941;
		public int dataSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataSize9941);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataSize9941);
		}
		internal static global::MonoJavaBridge.MethodId _writeValue9942;
		public void writeValue(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeValue9942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeValue9942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeString9943;
		public void writeString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeString9943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeString9943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _obtain9944;
		public static global::android.os.Parcel obtain() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.Parcel.staticClass, global::android.os.Parcel._obtain9944)) as android.os.Parcel;
		}
		internal static global::MonoJavaBridge.MethodId _recycle9945;
		public void recycle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._recycle9945);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._recycle9945);
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors9946;
		public bool hasFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Parcel._hasFileDescriptors9946);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._hasFileDescriptors9946);
		}
		internal static global::MonoJavaBridge.MethodId _dataAvail9947;
		public int dataAvail() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataAvail9947);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataAvail9947);
		}
		internal static global::MonoJavaBridge.MethodId _dataPosition9948;
		public int dataPosition() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataPosition9948);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataPosition9948);
		}
		internal static global::MonoJavaBridge.MethodId _dataCapacity9949;
		public int dataCapacity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Parcel._dataCapacity9949);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataCapacity9949);
		}
		internal static global::MonoJavaBridge.MethodId _setDataSize9950;
		public void setDataSize(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataSize9950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataSize9950, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataPosition9951;
		public void setDataPosition(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataPosition9951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataPosition9951, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setDataCapacity9952;
		public void setDataCapacity(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._setDataCapacity9952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataCapacity9952, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _marshall9953;
		public byte[] marshall() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._marshall9953)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._marshall9953)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _unmarshall9954;
		public void unmarshall(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._unmarshall9954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._unmarshall9954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _appendFrom9955;
		public void appendFrom(android.os.Parcel arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._appendFrom9955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._appendFrom9955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeInterfaceToken9956;
		public void writeInterfaceToken(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeInterfaceToken9956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInterfaceToken9956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _enforceInterface9957;
		public void enforceInterface(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._enforceInterface9957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._enforceInterface9957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeByteArray9958;
		public void writeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByteArray9958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray9958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _writeByteArray9959;
		public void writeByteArray(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeByteArray9959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray9959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDouble9960;
		public void writeDouble(double arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeDouble9960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDouble9960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStrongBinder9961;
		public void writeStrongBinder(android.os.IBinder arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStrongBinder9961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongBinder9961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStrongInterface9962;
		public void writeStrongInterface(android.os.IInterface arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStrongInterface9962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongInterface9962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFileDescriptor9963;
		public void writeFileDescriptor(java.io.FileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFileDescriptor9963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFileDescriptor9963, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeMap9964;
		public void writeMap(java.util.Map arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeMap9964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeMap9964, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBundle9965;
		public void writeBundle(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBundle9965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBundle9965, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeList9966;
		public void writeList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeList9966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeList9966, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeArray9967;
		public void writeArray(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeArray9967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeArray9967, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeSparseArray9968;
		public void writeSparseArray(android.util.SparseArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSparseArray9968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseArray9968, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeSparseBooleanArray9969;
		public void writeSparseBooleanArray(android.util.SparseBooleanArray arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSparseBooleanArray9969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseBooleanArray9969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBooleanArray9970;
		public void writeBooleanArray(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBooleanArray9970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBooleanArray9970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createBooleanArray9971;
		public bool[] createBooleanArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBooleanArray9971)) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBooleanArray9971)) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _readBooleanArray9972;
		public void readBooleanArray(bool[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBooleanArray9972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBooleanArray9972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeCharArray9973;
		public void writeCharArray(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeCharArray9973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeCharArray9973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createCharArray9974;
		public char[] createCharArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createCharArray9974)) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createCharArray9974)) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _readCharArray9975;
		public void readCharArray(char[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readCharArray9975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readCharArray9975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeIntArray9976;
		public void writeIntArray(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeIntArray9976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeIntArray9976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createIntArray9977;
		public int[] createIntArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createIntArray9977)) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createIntArray9977)) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _readIntArray9978;
		public void readIntArray(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readIntArray9978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readIntArray9978, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeLongArray9979;
		public void writeLongArray(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeLongArray9979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLongArray9979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createLongArray9980;
		public long[] createLongArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createLongArray9980)) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createLongArray9980)) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _readLongArray9981;
		public void readLongArray(long[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readLongArray9981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLongArray9981, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeFloatArray9982;
		public void writeFloatArray(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeFloatArray9982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloatArray9982, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createFloatArray9983;
		public float[] createFloatArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createFloatArray9983)) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createFloatArray9983)) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _readFloatArray9984;
		public void readFloatArray(float[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readFloatArray9984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloatArray9984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeDoubleArray9985;
		public void writeDoubleArray(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeDoubleArray9985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDoubleArray9985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createDoubleArray9986;
		public double[] createDoubleArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createDoubleArray9986)) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createDoubleArray9986)) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _readDoubleArray9987;
		public void readDoubleArray(double[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readDoubleArray9987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDoubleArray9987, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStringArray9988;
		public void writeStringArray(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStringArray9988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringArray9988, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createStringArray9989;
		public global::java.lang.String[] createStringArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createStringArray9989)) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArray9989)) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _readStringArray9990;
		public void readStringArray(java.lang.String[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readStringArray9990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringArray9990, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinderArray9991;
		public void writeBinderArray(android.os.IBinder[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBinderArray9991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderArray9991, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createBinderArray9992;
		public global::android.os.IBinder[] createBinderArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBinderArray9992)) as android.os.IBinder[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArray9992)) as android.os.IBinder[];
		}
		internal static global::MonoJavaBridge.MethodId _readBinderArray9993;
		public void readBinderArray(android.os.IBinder[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBinderArray9993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderArray9993, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTypedList9994;
		public void writeTypedList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeTypedList9994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedList9994, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeStringList9995;
		public void writeStringList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeStringList9995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringList9995, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeBinderList9996;
		public void writeBinderList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeBinderList9996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderList9996, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeTypedArray9997;
		public void writeTypedArray(android.os.Parcelable[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeTypedArray9997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedArray9997, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeParcelable9998;
		public void writeParcelable(android.os.Parcelable arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeParcelable9998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelable9998, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeSerializable9999;
		public void writeSerializable(java.io.Serializable arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeSerializable9999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSerializable9999, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeException10000;
		public void writeException(java.lang.Exception arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeException10000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeException10000, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _writeNoException10001;
		public void writeNoException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeNoException10001);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeNoException10001);
		}
		internal static global::MonoJavaBridge.MethodId _readException10002;
		public void readException() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readException10002);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException10002);
		}
		internal static global::MonoJavaBridge.MethodId _readException10003;
		public void readException(int arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readException10003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException10003, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readStrongBinder10004;
		public global::android.os.IBinder readStrongBinder() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readStrongBinder10004)) as android.os.IBinder;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.IBinder>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStrongBinder10004)) as android.os.IBinder;
		}
		internal static global::MonoJavaBridge.MethodId _readFileDescriptor10005;
		public global::android.os.ParcelFileDescriptor readFileDescriptor() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readFileDescriptor10005)) as android.os.ParcelFileDescriptor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFileDescriptor10005)) as android.os.ParcelFileDescriptor;
		}
		internal static global::MonoJavaBridge.MethodId _readMap10006;
		public void readMap(java.util.Map arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readMap10006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readMap10006, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readList10007;
		public void readList(java.util.List arg0, java.lang.ClassLoader arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readList10007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readList10007, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readHashMap10008;
		public global::java.util.HashMap readHashMap(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readHashMap10008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.HashMap;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readHashMap10008, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.HashMap;
		}
		internal static global::MonoJavaBridge.MethodId _readBundle10009;
		public global::android.os.Bundle readBundle() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readBundle10009)) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle10009)) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _readBundle10010;
		public global::android.os.Bundle readBundle(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readBundle10010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle10010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _createByteArray10011;
		public byte[] createByteArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createByteArray10011)) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createByteArray10011)) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _readByteArray10012;
		public void readByteArray(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readByteArray10012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByteArray10012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readArrayList10013;
		public global::java.util.ArrayList readArrayList(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readArrayList10013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArrayList10013, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readArray10014;
		public global::java.lang.Object[] readArray(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readArray10014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArray10014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _readSparseArray10015;
		public global::android.util.SparseArray readSparseArray(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSparseArray10015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseArray10015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
		}
		internal static global::MonoJavaBridge.MethodId _readSparseBooleanArray10016;
		public global::android.util.SparseBooleanArray readSparseBooleanArray() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSparseBooleanArray10016)) as android.util.SparseBooleanArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseBooleanArray10016)) as android.util.SparseBooleanArray;
		}
		internal static global::MonoJavaBridge.MethodId _createTypedArrayList10017;
		public global::java.util.ArrayList createTypedArrayList(android.os.Parcelable_Creator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createTypedArrayList10017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArrayList10017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readTypedList10018;
		public void readTypedList(java.util.List arg0, android.os.Parcelable_Creator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readTypedList10018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedList10018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _createStringArrayList10019;
		public global::java.util.ArrayList createStringArrayList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createStringArrayList10019)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArrayList10019)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _createBinderArrayList10020;
		public global::java.util.ArrayList createBinderArrayList() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createBinderArrayList10020)) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArrayList10020)) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _readStringList10021;
		public void readStringList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readStringList10021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringList10021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _readBinderList10022;
		public void readBinderList(java.util.List arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readBinderList10022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderList10022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createTypedArray10023;
		public global::java.lang.Object[] createTypedArray(android.os.Parcelable_Creator arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._createTypedArray10023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.Object>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArray10023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object[];
		}
		internal static global::MonoJavaBridge.MethodId _readTypedArray10024;
		public void readTypedArray(java.lang.Object[] arg0, android.os.Parcelable_Creator arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._readTypedArray10024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedArray10024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _writeParcelableArray10025;
		public void writeParcelableArray(android.os.Parcelable[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Parcel._writeParcelableArray10025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelableArray10025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _readValue10026;
		public global::java.lang.Object readValue(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readValue10026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readValue10026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _readParcelable10027;
		public global::android.os.Parcelable readParcelable(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readParcelable10027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelable10027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _readParcelableArray10028;
		public global::android.os.Parcelable[] readParcelableArray(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readParcelableArray10028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelableArray10028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _readSerializable10029;
		public global::java.io.Serializable readSerializable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Parcel._readSerializable10029)) as java.io.Serializable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSerializable10029)) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.FieldId _STRING_CREATOR10030;
		public static global::android.os.Parcelable_Creator STRING_CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Parcel.staticClass, _STRING_CREATOR10030)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Parcel.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Parcel"));
			global::android.os.Parcel._writeInt9931 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeInt", "(I)V");
			global::android.os.Parcel._readInt9932 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readInt", "()I");
			global::android.os.Parcel._readLong9933 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readLong", "()J");
			global::android.os.Parcel._readByte9934 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readByte", "()B");
			global::android.os.Parcel._writeLong9935 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeLong", "(J)V");
			global::android.os.Parcel._writeByte9936 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByte", "(B)V");
			global::android.os.Parcel._writeFloat9937 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFloat", "(F)V");
			global::android.os.Parcel._readFloat9938 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFloat", "()F");
			global::android.os.Parcel._readDouble9939 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readDouble", "()D");
			global::android.os.Parcel._readString9940 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readString", "()Ljava/lang/String;");
			global::android.os.Parcel._dataSize9941 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataSize", "()I");
			global::android.os.Parcel._writeValue9942 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeValue", "(Ljava/lang/Object;)V");
			global::android.os.Parcel._writeString9943 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeString", "(Ljava/lang/String;)V");
			global::android.os.Parcel._obtain9944 = @__env.GetStaticMethodIDNoThrow(global::android.os.Parcel.staticClass, "obtain", "()Landroid/os/Parcel;");
			global::android.os.Parcel._recycle9945 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "recycle", "()V");
			global::android.os.Parcel._hasFileDescriptors9946 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "hasFileDescriptors", "()Z");
			global::android.os.Parcel._dataAvail9947 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataAvail", "()I");
			global::android.os.Parcel._dataPosition9948 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataPosition", "()I");
			global::android.os.Parcel._dataCapacity9949 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "dataCapacity", "()I");
			global::android.os.Parcel._setDataSize9950 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataSize", "(I)V");
			global::android.os.Parcel._setDataPosition9951 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataPosition", "(I)V");
			global::android.os.Parcel._setDataCapacity9952 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "setDataCapacity", "(I)V");
			global::android.os.Parcel._marshall9953 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "marshall", "()[B");
			global::android.os.Parcel._unmarshall9954 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "unmarshall", "([BII)V");
			global::android.os.Parcel._appendFrom9955 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "appendFrom", "(Landroid/os/Parcel;II)V");
			global::android.os.Parcel._writeInterfaceToken9956 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeInterfaceToken", "(Ljava/lang/String;)V");
			global::android.os.Parcel._enforceInterface9957 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "enforceInterface", "(Ljava/lang/String;)V");
			global::android.os.Parcel._writeByteArray9958 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByteArray", "([BII)V");
			global::android.os.Parcel._writeByteArray9959 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeByteArray", "([B)V");
			global::android.os.Parcel._writeDouble9960 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeDouble", "(D)V");
			global::android.os.Parcel._writeStrongBinder9961 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStrongBinder", "(Landroid/os/IBinder;)V");
			global::android.os.Parcel._writeStrongInterface9962 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStrongInterface", "(Landroid/os/IInterface;)V");
			global::android.os.Parcel._writeFileDescriptor9963 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFileDescriptor", "(Ljava/io/FileDescriptor;)V");
			global::android.os.Parcel._writeMap9964 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeMap", "(Ljava/util/Map;)V");
			global::android.os.Parcel._writeBundle9965 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBundle", "(Landroid/os/Bundle;)V");
			global::android.os.Parcel._writeList9966 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeArray9967 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeArray", "([Ljava/lang/Object;)V");
			global::android.os.Parcel._writeSparseArray9968 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSparseArray", "(Landroid/util/SparseArray;)V");
			global::android.os.Parcel._writeSparseBooleanArray9969 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V");
			global::android.os.Parcel._writeBooleanArray9970 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBooleanArray", "([Z)V");
			global::android.os.Parcel._createBooleanArray9971 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBooleanArray", "()[Z");
			global::android.os.Parcel._readBooleanArray9972 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBooleanArray", "([Z)V");
			global::android.os.Parcel._writeCharArray9973 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeCharArray", "([C)V");
			global::android.os.Parcel._createCharArray9974 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createCharArray", "()[C");
			global::android.os.Parcel._readCharArray9975 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readCharArray", "([C)V");
			global::android.os.Parcel._writeIntArray9976 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeIntArray", "([I)V");
			global::android.os.Parcel._createIntArray9977 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createIntArray", "()[I");
			global::android.os.Parcel._readIntArray9978 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readIntArray", "([I)V");
			global::android.os.Parcel._writeLongArray9979 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeLongArray", "([J)V");
			global::android.os.Parcel._createLongArray9980 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createLongArray", "()[J");
			global::android.os.Parcel._readLongArray9981 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readLongArray", "([J)V");
			global::android.os.Parcel._writeFloatArray9982 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeFloatArray", "([F)V");
			global::android.os.Parcel._createFloatArray9983 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createFloatArray", "()[F");
			global::android.os.Parcel._readFloatArray9984 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFloatArray", "([F)V");
			global::android.os.Parcel._writeDoubleArray9985 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeDoubleArray", "([D)V");
			global::android.os.Parcel._createDoubleArray9986 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createDoubleArray", "()[D");
			global::android.os.Parcel._readDoubleArray9987 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readDoubleArray", "([D)V");
			global::android.os.Parcel._writeStringArray9988 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStringArray", "([Ljava/lang/String;)V");
			global::android.os.Parcel._createStringArray9989 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createStringArray", "()[Ljava/lang/String;");
			global::android.os.Parcel._readStringArray9990 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStringArray", "([Ljava/lang/String;)V");
			global::android.os.Parcel._writeBinderArray9991 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBinderArray", "([Landroid/os/IBinder;)V");
			global::android.os.Parcel._createBinderArray9992 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBinderArray", "()[Landroid/os/IBinder;");
			global::android.os.Parcel._readBinderArray9993 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBinderArray", "([Landroid/os/IBinder;)V");
			global::android.os.Parcel._writeTypedList9994 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeTypedList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeStringList9995 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeStringList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeBinderList9996 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeBinderList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeTypedArray9997 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeTypedArray", "([Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._writeParcelable9998 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeParcelable", "(Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._writeSerializable9999 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeSerializable", "(Ljava/io/Serializable;)V");
			global::android.os.Parcel._writeException10000 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeException", "(Ljava/lang/Exception;)V");
			global::android.os.Parcel._writeNoException10001 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeNoException", "()V");
			global::android.os.Parcel._readException10002 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readException", "()V");
			global::android.os.Parcel._readException10003 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readException", "(ILjava/lang/String;)V");
			global::android.os.Parcel._readStrongBinder10004 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStrongBinder", "()Landroid/os/IBinder;");
			global::android.os.Parcel._readFileDescriptor10005 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
			global::android.os.Parcel._readMap10006 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V");
			global::android.os.Parcel._readList10007 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V");
			global::android.os.Parcel._readHashMap10008 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;");
			global::android.os.Parcel._readBundle10009 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBundle", "()Landroid/os/Bundle;");
			global::android.os.Parcel._readBundle10010 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;");
			global::android.os.Parcel._createByteArray10011 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createByteArray", "()[B");
			global::android.os.Parcel._readByteArray10012 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readByteArray", "([B)V");
			global::android.os.Parcel._readArrayList10013 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;");
			global::android.os.Parcel._readArray10014 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;");
			global::android.os.Parcel._readSparseArray10015 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;");
			global::android.os.Parcel._readSparseBooleanArray10016 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;");
			global::android.os.Parcel._createTypedArrayList10017 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;");
			global::android.os.Parcel._readTypedList10018 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V");
			global::android.os.Parcel._createStringArrayList10019 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createStringArrayList", "()Ljava/util/ArrayList;");
			global::android.os.Parcel._createBinderArrayList10020 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createBinderArrayList", "()Ljava/util/ArrayList;");
			global::android.os.Parcel._readStringList10021 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readStringList", "(Ljava/util/List;)V");
			global::android.os.Parcel._readBinderList10022 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readBinderList", "(Ljava/util/List;)V");
			global::android.os.Parcel._createTypedArray10023 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;");
			global::android.os.Parcel._readTypedArray10024 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V");
			global::android.os.Parcel._writeParcelableArray10025 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "writeParcelableArray", "([Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._readValue10026 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;");
			global::android.os.Parcel._readParcelable10027 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;");
			global::android.os.Parcel._readParcelableArray10028 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;");
			global::android.os.Parcel._readSerializable10029 = @__env.GetMethodIDNoThrow(global::android.os.Parcel.staticClass, "readSerializable", "()Ljava/io/Serializable;");
			global::android.os.Parcel._STRING_CREATOR10030 = @__env.GetStaticFieldIDNoThrow(global::android.os.Parcel.staticClass, "STRING_CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
