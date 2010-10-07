namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Parcel : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static Parcel()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Parcel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.Parcel(@__env);
			}
		}
		internal Parcel(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeInt6263;
		public void writeInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeInt6263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInt6263, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readInt6264;
		public int readInt() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Parcel._readInt6264);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readInt6264);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readLong6265;
		public long readLong() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.os.Parcel._readLong6265);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLong6265);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readByte6266;
		public byte readByte() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this, global::android.os.Parcel._readByte6266);
			else
				return @__env.CallNonVirtualByteMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByte6266);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeLong6267;
		public void writeLong(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeLong6267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLong6267, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeByte6268;
		public void writeByte(byte arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeByte6268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByte6268, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeFloat6269;
		public void writeFloat(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeFloat6269, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloat6269, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFloat6270;
		public float readFloat() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.os.Parcel._readFloat6270);
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloat6270);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readDouble6271;
		public double readDouble() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.os.Parcel._readDouble6271);
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDouble6271);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readString6272;
		public global::java.lang.String readString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readString6272));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readString6272));
		}
		internal static global::net.sf.jni4net.jni.MethodId _dataSize6273;
		public int dataSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Parcel._dataSize6273);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataSize6273);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeValue6274;
		public void writeValue(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeValue6274, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeValue6274, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeString6275;
		public void writeString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeString6275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeString6275, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _obtain6276;
		public static global::android.os.Parcel obtain() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Parcel>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Parcel.staticClass, global::android.os.Parcel._obtain6276));
		}
		internal static global::net.sf.jni4net.jni.MethodId _recycle6277;
		public void recycle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._recycle6277);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._recycle6277);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFileDescriptors6278;
		public bool hasFileDescriptors() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Parcel._hasFileDescriptors6278);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._hasFileDescriptors6278);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dataAvail6279;
		public int dataAvail() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Parcel._dataAvail6279);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataAvail6279);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dataPosition6280;
		public int dataPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Parcel._dataPosition6280);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataPosition6280);
		}
		internal static global::net.sf.jni4net.jni.MethodId _dataCapacity6281;
		public int dataCapacity() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Parcel._dataCapacity6281);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataCapacity6281);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDataSize6282;
		public void setDataSize(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._setDataSize6282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataSize6282, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDataPosition6283;
		public void setDataPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._setDataPosition6283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataPosition6283, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setDataCapacity6284;
		public void setDataCapacity(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._setDataCapacity6284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataCapacity6284, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _marshall6285;
		public byte[] marshall() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._marshall6285));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._marshall6285));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unmarshall6286;
		public void unmarshall(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._unmarshall6286, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._unmarshall6286, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _appendFrom6287;
		public void appendFrom(android.os.Parcel arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._appendFrom6287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._appendFrom6287, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeInterfaceToken6288;
		public void writeInterfaceToken(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeInterfaceToken6288, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInterfaceToken6288, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _enforceInterface6289;
		public void enforceInterface(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._enforceInterface6289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._enforceInterface6289, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeByteArray6290;
		public void writeByteArray(byte[] arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeByteArray6290, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray6290, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeByteArray6291;
		public void writeByteArray(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeByteArray6291, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray6291, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeDouble6292;
		public void writeDouble(double arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeDouble6292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDouble6292, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeStrongBinder6293;
		public void writeStrongBinder(android.os.IBinder arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeStrongBinder6293, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongBinder6293, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeStrongInterface6294;
		public void writeStrongInterface(android.os.IInterface arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeStrongInterface6294, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongInterface6294, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeFileDescriptor6295;
		public void writeFileDescriptor(java.io.FileDescriptor arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeFileDescriptor6295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFileDescriptor6295, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeMap6296;
		public void writeMap(java.util.Map arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeMap6296, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeMap6296, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeBundle6297;
		public void writeBundle(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeBundle6297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBundle6297, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeList6298;
		public void writeList(java.util.List arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeList6298, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeList6298, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeArray6299;
		public void writeArray(java.lang.Object[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeArray6299, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeArray6299, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeSparseArray6300;
		public void writeSparseArray(android.util.SparseArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeSparseArray6300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseArray6300, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeSparseBooleanArray6301;
		public void writeSparseBooleanArray(android.util.SparseBooleanArray arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeSparseBooleanArray6301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseBooleanArray6301, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeBooleanArray6302;
		public void writeBooleanArray(bool[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeBooleanArray6302, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBooleanArray6302, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBooleanArray6303;
		public bool[] createBooleanArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createBooleanArray6303));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBooleanArray6303));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readBooleanArray6304;
		public void readBooleanArray(bool[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readBooleanArray6304, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBooleanArray6304, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeCharArray6305;
		public void writeCharArray(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeCharArray6305, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeCharArray6305, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createCharArray6306;
		public char[] createCharArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createCharArray6306));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createCharArray6306));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readCharArray6307;
		public void readCharArray(char[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readCharArray6307, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readCharArray6307, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeIntArray6308;
		public void writeIntArray(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeIntArray6308, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeIntArray6308, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createIntArray6309;
		public int[] createIntArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createIntArray6309));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createIntArray6309));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readIntArray6310;
		public void readIntArray(int[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readIntArray6310, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readIntArray6310, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeLongArray6311;
		public void writeLongArray(long[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeLongArray6311, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLongArray6311, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createLongArray6312;
		public long[] createLongArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createLongArray6312));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createLongArray6312));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readLongArray6313;
		public void readLongArray(long[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readLongArray6313, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLongArray6313, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeFloatArray6314;
		public void writeFloatArray(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeFloatArray6314, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloatArray6314, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createFloatArray6315;
		public float[] createFloatArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createFloatArray6315));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createFloatArray6315));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFloatArray6316;
		public void readFloatArray(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readFloatArray6316, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloatArray6316, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeDoubleArray6317;
		public void writeDoubleArray(double[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeDoubleArray6317, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDoubleArray6317, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createDoubleArray6318;
		public double[] createDoubleArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createDoubleArray6318));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createDoubleArray6318));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readDoubleArray6319;
		public void readDoubleArray(double[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readDoubleArray6319, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDoubleArray6319, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeStringArray6320;
		public void writeStringArray(java.lang.String[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeStringArray6320, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringArray6320, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createStringArray6321;
		public global::java.lang.String[] createStringArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createStringArray6321));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArray6321));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readStringArray6322;
		public void readStringArray(java.lang.String[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readStringArray6322, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringArray6322, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeBinderArray6323;
		public void writeBinderArray(android.os.IBinder[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeBinderArray6323, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderArray6323, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBinderArray6324;
		public global::android.os.IBinder[] createBinderArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createBinderArray6324));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArray6324));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readBinderArray6325;
		public void readBinderArray(android.os.IBinder[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readBinderArray6325, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderArray6325, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeTypedList6326;
		public void writeTypedList(java.util.List arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeTypedList6326, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedList6326, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeStringList6327;
		public void writeStringList(java.util.List arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeStringList6327, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringList6327, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeBinderList6328;
		public void writeBinderList(java.util.List arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeBinderList6328, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderList6328, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeTypedArray6329;
		public void writeTypedArray(android.os.Parcelable[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeTypedArray6329, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedArray6329, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeParcelable6330;
		public void writeParcelable(android.os.Parcelable arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeParcelable6330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelable6330, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeSerializable6331;
		public void writeSerializable(java.io.Serializable arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeSerializable6331, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSerializable6331, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeException6332;
		public void writeException(java.lang.Exception arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeException6332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeException6332, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeNoException6333;
		public void writeNoException() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeNoException6333);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeNoException6333);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readException6334;
		public void readException() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readException6334);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException6334);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readException6335;
		public void readException(int arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readException6335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException6335, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readStrongBinder6336;
		public global::android.os.IBinder readStrongBinder() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readStrongBinder6336));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStrongBinder6336));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFileDescriptor6337;
		public global::android.os.ParcelFileDescriptor readFileDescriptor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readFileDescriptor6337));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFileDescriptor6337));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readMap6338;
		public void readMap(java.util.Map arg0, java.lang.ClassLoader arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readMap6338, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readMap6338, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readList6339;
		public void readList(java.util.List arg0, java.lang.ClassLoader arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readList6339, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readList6339, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readHashMap6340;
		public global::java.util.HashMap readHashMap(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.HashMap>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readHashMap6340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.HashMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readHashMap6340, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readBundle6341;
		public global::android.os.Bundle readBundle() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readBundle6341));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle6341));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readBundle6342;
		public global::android.os.Bundle readBundle(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readBundle6342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle6342, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createByteArray6343;
		public byte[] createByteArray() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createByteArray6343));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createByteArray6343));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readByteArray6344;
		public void readByteArray(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readByteArray6344, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByteArray6344, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readArrayList6345;
		public global::java.util.ArrayList readArrayList(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readArrayList6345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArrayList6345, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readArray6346;
		public global::java.lang.Object[] readArray(java.lang.ClassLoader arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readArray6346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArray6346, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readSparseArray6347;
		public global::android.util.SparseArray readSparseArray(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readSparseArray6347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseArray6347, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readSparseBooleanArray6348;
		public global::android.util.SparseBooleanArray readSparseBooleanArray() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readSparseBooleanArray6348));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseBooleanArray6348));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createTypedArrayList6349;
		public global::java.util.ArrayList createTypedArrayList(android.os.Parcelable_Creator arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createTypedArrayList6349, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArrayList6349, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readTypedList6350;
		public void readTypedList(java.util.List arg0, android.os.Parcelable_Creator arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readTypedList6350, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedList6350, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createStringArrayList6351;
		public global::java.util.ArrayList createStringArrayList() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createStringArrayList6351));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArrayList6351));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createBinderArrayList6352;
		public global::java.util.ArrayList createBinderArrayList() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createBinderArrayList6352));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArrayList6352));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readStringList6353;
		public void readStringList(java.util.List arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readStringList6353, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringList6353, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readBinderList6354;
		public void readBinderList(java.util.List arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readBinderList6354, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderList6354, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createTypedArray6355;
		public global::java.lang.Object[] createTypedArray(android.os.Parcelable_Creator arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createTypedArray6355, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArray6355, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readTypedArray6356;
		public void readTypedArray(java.lang.Object[] arg0, android.os.Parcelable_Creator arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._readTypedArray6356, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedArray6356, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeParcelableArray6357;
		public void writeParcelableArray(android.os.Parcelable[] arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeParcelableArray6357, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelableArray6357, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readValue6358;
		public global::java.lang.Object readValue(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readValue6358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readValue6358, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readParcelable6359;
		public global::android.os.Parcelable readParcelable(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readParcelable6359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelable6359, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readParcelableArray6360;
		public global::android.os.Parcelable[] readParcelableArray(java.lang.ClassLoader arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readParcelableArray6360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelableArray6360, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _readSerializable6361;
		public global::java.io.Serializable readSerializable() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readSerializable6361));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSerializable6361));
		}
		internal static global::net.sf.jni4net.jni.FieldId _STRING_CREATOR6362;
		public static global::android.os.Parcelable_Creator STRING_CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Parcel.staticClass = @__class;
			global::android.os.Parcel._writeInt6263 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeInt", "(I)V");
			global::android.os.Parcel._readInt6264 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readInt", "()I");
			global::android.os.Parcel._readLong6265 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readLong", "()J");
			global::android.os.Parcel._readByte6266 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readByte", "()B");
			global::android.os.Parcel._writeLong6267 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeLong", "(J)V");
			global::android.os.Parcel._writeByte6268 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByte", "(B)V");
			global::android.os.Parcel._writeFloat6269 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFloat", "(F)V");
			global::android.os.Parcel._readFloat6270 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFloat", "()F");
			global::android.os.Parcel._readDouble6271 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readDouble", "()D");
			global::android.os.Parcel._readString6272 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readString", "()Ljava/lang/String;");
			global::android.os.Parcel._dataSize6273 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataSize", "()I");
			global::android.os.Parcel._writeValue6274 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeValue", "(Ljava/lang/Object;)V");
			global::android.os.Parcel._writeString6275 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeString", "(Ljava/lang/String;)V");
			global::android.os.Parcel._obtain6276 = @__env.GetStaticMethodID(global::android.os.Parcel.staticClass, "obtain", "()Landroid/os/Parcel;");
			global::android.os.Parcel._recycle6277 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "recycle", "()V");
			global::android.os.Parcel._hasFileDescriptors6278 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "hasFileDescriptors", "()Z");
			global::android.os.Parcel._dataAvail6279 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataAvail", "()I");
			global::android.os.Parcel._dataPosition6280 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataPosition", "()I");
			global::android.os.Parcel._dataCapacity6281 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataCapacity", "()I");
			global::android.os.Parcel._setDataSize6282 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataSize", "(I)V");
			global::android.os.Parcel._setDataPosition6283 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataPosition", "(I)V");
			global::android.os.Parcel._setDataCapacity6284 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataCapacity", "(I)V");
			global::android.os.Parcel._marshall6285 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "marshall", "()[B");
			global::android.os.Parcel._unmarshall6286 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "unmarshall", "([BII)V");
			global::android.os.Parcel._appendFrom6287 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "appendFrom", "(Landroid/os/Parcel;II)V");
			global::android.os.Parcel._writeInterfaceToken6288 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeInterfaceToken", "(Ljava/lang/String;)V");
			global::android.os.Parcel._enforceInterface6289 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "enforceInterface", "(Ljava/lang/String;)V");
			global::android.os.Parcel._writeByteArray6290 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByteArray", "([BII)V");
			global::android.os.Parcel._writeByteArray6291 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByteArray", "([B)V");
			global::android.os.Parcel._writeDouble6292 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeDouble", "(D)V");
			global::android.os.Parcel._writeStrongBinder6293 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStrongBinder", "(Landroid/os/IBinder;)V");
			global::android.os.Parcel._writeStrongInterface6294 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStrongInterface", "(Landroid/os/IInterface;)V");
			global::android.os.Parcel._writeFileDescriptor6295 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFileDescriptor", "(Ljava/io/FileDescriptor;)V");
			global::android.os.Parcel._writeMap6296 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeMap", "(Ljava/util/Map;)V");
			global::android.os.Parcel._writeBundle6297 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBundle", "(Landroid/os/Bundle;)V");
			global::android.os.Parcel._writeList6298 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeArray6299 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeArray", "([Ljava/lang/Object;)V");
			global::android.os.Parcel._writeSparseArray6300 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSparseArray", "(Landroid/util/SparseArray;)V");
			global::android.os.Parcel._writeSparseBooleanArray6301 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V");
			global::android.os.Parcel._writeBooleanArray6302 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBooleanArray", "([Z)V");
			global::android.os.Parcel._createBooleanArray6303 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBooleanArray", "()[Z");
			global::android.os.Parcel._readBooleanArray6304 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBooleanArray", "([Z)V");
			global::android.os.Parcel._writeCharArray6305 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeCharArray", "([C)V");
			global::android.os.Parcel._createCharArray6306 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createCharArray", "()[C");
			global::android.os.Parcel._readCharArray6307 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readCharArray", "([C)V");
			global::android.os.Parcel._writeIntArray6308 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeIntArray", "([I)V");
			global::android.os.Parcel._createIntArray6309 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createIntArray", "()[I");
			global::android.os.Parcel._readIntArray6310 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readIntArray", "([I)V");
			global::android.os.Parcel._writeLongArray6311 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeLongArray", "([J)V");
			global::android.os.Parcel._createLongArray6312 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createLongArray", "()[J");
			global::android.os.Parcel._readLongArray6313 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readLongArray", "([J)V");
			global::android.os.Parcel._writeFloatArray6314 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFloatArray", "([F)V");
			global::android.os.Parcel._createFloatArray6315 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createFloatArray", "()[F");
			global::android.os.Parcel._readFloatArray6316 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFloatArray", "([F)V");
			global::android.os.Parcel._writeDoubleArray6317 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeDoubleArray", "([D)V");
			global::android.os.Parcel._createDoubleArray6318 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createDoubleArray", "()[D");
			global::android.os.Parcel._readDoubleArray6319 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readDoubleArray", "([D)V");
			global::android.os.Parcel._writeStringArray6320 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStringArray", "([Ljava/lang/String;)V");
			global::android.os.Parcel._createStringArray6321 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createStringArray", "()[Ljava/lang/String;");
			global::android.os.Parcel._readStringArray6322 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStringArray", "([Ljava/lang/String;)V");
			global::android.os.Parcel._writeBinderArray6323 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBinderArray", "([Landroid/os/IBinder;)V");
			global::android.os.Parcel._createBinderArray6324 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBinderArray", "()[Landroid/os/IBinder;");
			global::android.os.Parcel._readBinderArray6325 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBinderArray", "([Landroid/os/IBinder;)V");
			global::android.os.Parcel._writeTypedList6326 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeTypedList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeStringList6327 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStringList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeBinderList6328 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBinderList", "(Ljava/util/List;)V");
			global::android.os.Parcel._writeTypedArray6329 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeTypedArray", "([Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._writeParcelable6330 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeParcelable", "(Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._writeSerializable6331 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSerializable", "(Ljava/io/Serializable;)V");
			global::android.os.Parcel._writeException6332 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeException", "(Ljava/lang/Exception;)V");
			global::android.os.Parcel._writeNoException6333 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeNoException", "()V");
			global::android.os.Parcel._readException6334 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readException", "()V");
			global::android.os.Parcel._readException6335 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readException", "(ILjava/lang/String;)V");
			global::android.os.Parcel._readStrongBinder6336 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStrongBinder", "()Landroid/os/IBinder;");
			global::android.os.Parcel._readFileDescriptor6337 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;");
			global::android.os.Parcel._readMap6338 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V");
			global::android.os.Parcel._readList6339 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V");
			global::android.os.Parcel._readHashMap6340 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;");
			global::android.os.Parcel._readBundle6341 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBundle", "()Landroid/os/Bundle;");
			global::android.os.Parcel._readBundle6342 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;");
			global::android.os.Parcel._createByteArray6343 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createByteArray", "()[B");
			global::android.os.Parcel._readByteArray6344 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readByteArray", "([B)V");
			global::android.os.Parcel._readArrayList6345 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;");
			global::android.os.Parcel._readArray6346 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;");
			global::android.os.Parcel._readSparseArray6347 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;");
			global::android.os.Parcel._readSparseBooleanArray6348 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;");
			global::android.os.Parcel._createTypedArrayList6349 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;");
			global::android.os.Parcel._readTypedList6350 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V");
			global::android.os.Parcel._createStringArrayList6351 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createStringArrayList", "()Ljava/util/ArrayList;");
			global::android.os.Parcel._createBinderArrayList6352 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBinderArrayList", "()Ljava/util/ArrayList;");
			global::android.os.Parcel._readStringList6353 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStringList", "(Ljava/util/List;)V");
			global::android.os.Parcel._readBinderList6354 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBinderList", "(Ljava/util/List;)V");
			global::android.os.Parcel._createTypedArray6355 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;");
			global::android.os.Parcel._readTypedArray6356 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V");
			global::android.os.Parcel._writeParcelableArray6357 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeParcelableArray", "([Landroid/os/Parcelable;I)V");
			global::android.os.Parcel._readValue6358 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;");
			global::android.os.Parcel._readParcelable6359 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;");
			global::android.os.Parcel._readParcelableArray6360 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;");
			global::android.os.Parcel._readSerializable6361 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSerializable", "()Ljava/io/Serializable;");
		}
	}
}
