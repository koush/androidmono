namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Parcel : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Parcel() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Parcel), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _writeInt5420; 
		public void writeInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeInt5420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeInt5420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readInt5421; 
		public int readInt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, _readInt5421); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Parcel.staticClass, _readInt5421); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readLong5422; 
		public long readLong() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallLongMethod(this, _readLong5422); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.os.Parcel.staticClass, _readLong5422); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readByte5423; 
		public byte readByte() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallByteMethod(this, _readByte5423); 
			else 
				return @__env.CallNonVirtualByteMethod(this, android.os.Parcel.staticClass, _readByte5423); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeLong5424; 
		public void writeLong(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeLong5424, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeLong5424, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeByte5425; 
		public void writeByte(byte arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeByte5425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeByte5425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeFloat5426; 
		public void writeFloat(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeFloat5426, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeFloat5426, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFloat5427; 
		public float readFloat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallFloatMethod(this, _readFloat5427); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.os.Parcel.staticClass, _readFloat5427); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readDouble5428; 
		public double readDouble() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallDoubleMethod(this, _readDouble5428); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.os.Parcel.staticClass, _readDouble5428); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readString5429; 
		public java.lang.String readString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _readString5429)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readString5429)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dataSize5430; 
		public int dataSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, _dataSize5430); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Parcel.staticClass, _dataSize5430); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeValue5431; 
		public void writeValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeValue5431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeValue5431, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeString5432; 
		public void writeString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeString5432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeString5432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5433; 
		public static android.os.Parcel obtain() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Parcel>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Parcel.staticClass, _obtain5433)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle5434; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _recycle5434); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _recycle5434); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFileDescriptors5435; 
		public bool hasFileDescriptors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallBooleanMethod(this, _hasFileDescriptors5435); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Parcel.staticClass, _hasFileDescriptors5435); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dataAvail5436; 
		public int dataAvail() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, _dataAvail5436); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Parcel.staticClass, _dataAvail5436); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dataPosition5437; 
		public int dataPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, _dataPosition5437); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Parcel.staticClass, _dataPosition5437); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dataCapacity5438; 
		public int dataCapacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, _dataCapacity5438); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Parcel.staticClass, _dataCapacity5438); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataSize5439; 
		public void setDataSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _setDataSize5439, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _setDataSize5439, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataPosition5440; 
		public void setDataPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _setDataPosition5440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _setDataPosition5440, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataCapacity5441; 
		public void setDataCapacity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _setDataCapacity5441, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _setDataCapacity5441, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _marshall5442; 
		public byte[] marshall() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _marshall5442)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _marshall5442)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unmarshall5443; 
		public void unmarshall(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _unmarshall5443, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _unmarshall5443, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendFrom5444; 
		public void appendFrom(android.os.Parcel arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _appendFrom5444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _appendFrom5444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeInterfaceToken5445; 
		public void writeInterfaceToken(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeInterfaceToken5445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeInterfaceToken5445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforceInterface5446; 
		public void enforceInterface(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _enforceInterface5446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _enforceInterface5446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeByteArray5447; 
		public void writeByteArray(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeByteArray5447, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeByteArray5447, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeByteArray5448; 
		public void writeByteArray(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeByteArray5448, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeByteArray5448, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeDouble5449; 
		public void writeDouble(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeDouble5449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeDouble5449, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeStrongBinder5450; 
		public void writeStrongBinder(android.os.IBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeStrongBinder5450, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeStrongBinder5450, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeStrongInterface5451; 
		public void writeStrongInterface(android.os.IInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeStrongInterface5451, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeStrongInterface5451, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeFileDescriptor5452; 
		public void writeFileDescriptor(java.io.FileDescriptor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeFileDescriptor5452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeFileDescriptor5452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeMap5453; 
		public void writeMap(java.util.Map arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeMap5453, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeMap5453, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBundle5454; 
		public void writeBundle(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeBundle5454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeBundle5454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeList5455; 
		public void writeList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeList5455, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeList5455, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeArray5456; 
		public void writeArray(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeArray5456, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeArray5456, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeSparseArray5457; 
		public void writeSparseArray(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeSparseArray5457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeSparseArray5457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeSparseBooleanArray5458; 
		public void writeSparseBooleanArray(android.util.SparseBooleanArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeSparseBooleanArray5458, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeSparseBooleanArray5458, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBooleanArray5459; 
		public void writeBooleanArray(bool[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeBooleanArray5459, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeBooleanArray5459, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBooleanArray5460; 
		public bool[] createBooleanArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createBooleanArray5460)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createBooleanArray5460)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBooleanArray5461; 
		public void readBooleanArray(bool[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readBooleanArray5461, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readBooleanArray5461, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeCharArray5462; 
		public void writeCharArray(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeCharArray5462, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeCharArray5462, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createCharArray5463; 
		public char[] createCharArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createCharArray5463)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createCharArray5463)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readCharArray5464; 
		public void readCharArray(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readCharArray5464, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readCharArray5464, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeIntArray5465; 
		public void writeIntArray(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeIntArray5465, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeIntArray5465, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createIntArray5466; 
		public int[] createIntArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createIntArray5466)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createIntArray5466)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readIntArray5467; 
		public void readIntArray(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readIntArray5467, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readIntArray5467, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeLongArray5468; 
		public void writeLongArray(long[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeLongArray5468, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeLongArray5468, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createLongArray5469; 
		public long[] createLongArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createLongArray5469)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createLongArray5469)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readLongArray5470; 
		public void readLongArray(long[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readLongArray5470, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readLongArray5470, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeFloatArray5471; 
		public void writeFloatArray(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeFloatArray5471, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeFloatArray5471, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFloatArray5472; 
		public float[] createFloatArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createFloatArray5472)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createFloatArray5472)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFloatArray5473; 
		public void readFloatArray(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readFloatArray5473, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readFloatArray5473, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeDoubleArray5474; 
		public void writeDoubleArray(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeDoubleArray5474, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeDoubleArray5474, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createDoubleArray5475; 
		public double[] createDoubleArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createDoubleArray5475)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createDoubleArray5475)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readDoubleArray5476; 
		public void readDoubleArray(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readDoubleArray5476, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readDoubleArray5476, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeStringArray5477; 
		public void writeStringArray(java.lang.String[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeStringArray5477, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeStringArray5477, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createStringArray5478; 
		public java.lang.String[] createStringArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createStringArray5478)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createStringArray5478)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readStringArray5479; 
		public void readStringArray(java.lang.String[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readStringArray5479, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readStringArray5479, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBinderArray5480; 
		public void writeBinderArray(android.os.IBinder[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeBinderArray5480, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeBinderArray5480, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBinderArray5481; 
		public android.os.IBinder[] createBinderArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createBinderArray5481)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createBinderArray5481)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBinderArray5482; 
		public void readBinderArray(android.os.IBinder[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readBinderArray5482, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readBinderArray5482, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeTypedList5483; 
		public void writeTypedList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeTypedList5483, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeTypedList5483, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeStringList5484; 
		public void writeStringList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeStringList5484, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeStringList5484, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBinderList5485; 
		public void writeBinderList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeBinderList5485, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeBinderList5485, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeTypedArray5486; 
		public void writeTypedArray(android.os.Parcelable[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeTypedArray5486, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeTypedArray5486, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeParcelable5487; 
		public void writeParcelable(android.os.Parcelable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeParcelable5487, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeParcelable5487, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeSerializable5488; 
		public void writeSerializable(java.io.Serializable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeSerializable5488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeSerializable5488, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeException5489; 
		public void writeException(java.lang.Exception arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeException5489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeException5489, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeNoException5490; 
		public void writeNoException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeNoException5490); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeNoException5490); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readException5491; 
		public void readException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readException5491); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readException5491); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readException5492; 
		public void readException(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readException5492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readException5492, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readStrongBinder5493; 
		public android.os.IBinder readStrongBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _readStrongBinder5493)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readStrongBinder5493)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFileDescriptor5494; 
		public android.os.ParcelFileDescriptor readFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, _readFileDescriptor5494)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readFileDescriptor5494)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readMap5495; 
		public void readMap(java.util.Map arg0, java.lang.ClassLoader arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readMap5495, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readMap5495, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readList5496; 
		public void readList(java.util.List arg0, java.lang.ClassLoader arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readList5496, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readList5496, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readHashMap5497; 
		public java.util.HashMap readHashMap(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.HashMap>(@__env, @__env.CallObjectMethodPtr(this, _readHashMap5497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.HashMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readHashMap5497, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBundle5498; 
		public android.os.Bundle readBundle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _readBundle5498)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readBundle5498)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBundle5499; 
		public android.os.Bundle readBundle(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _readBundle5499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readBundle5499, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createByteArray5500; 
		public byte[] createByteArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createByteArray5500)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createByteArray5500)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readByteArray5501; 
		public void readByteArray(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readByteArray5501, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readByteArray5501, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readArrayList5502; 
		public java.util.ArrayList readArrayList(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _readArrayList5502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readArrayList5502, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readArray5503; 
		public java.lang.Object[] readArray(java.lang.ClassLoader arg0) 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _readArray5503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readArray5503, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readSparseArray5504; 
		public android.util.SparseArray readSparseArray(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallObjectMethodPtr(this, _readSparseArray5504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readSparseArray5504, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readSparseBooleanArray5505; 
		public android.util.SparseBooleanArray readSparseBooleanArray() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallObjectMethodPtr(this, _readSparseBooleanArray5505)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readSparseBooleanArray5505)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createTypedArrayList5506; 
		public java.util.ArrayList createTypedArrayList(android.os.Parcelable_Creator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _createTypedArrayList5506, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createTypedArrayList5506, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readTypedList5507; 
		public void readTypedList(java.util.List arg0, android.os.Parcelable_Creator arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readTypedList5507, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readTypedList5507, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createStringArrayList5508; 
		public java.util.ArrayList createStringArrayList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _createStringArrayList5508)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createStringArrayList5508)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBinderArrayList5509; 
		public java.util.ArrayList createBinderArrayList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, _createBinderArrayList5509)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createBinderArrayList5509)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readStringList5510; 
		public void readStringList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readStringList5510, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readStringList5510, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBinderList5511; 
		public void readBinderList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readBinderList5511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readBinderList5511, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createTypedArray5512; 
		public java.lang.Object[] createTypedArray(android.os.Parcelable_Creator arg0) 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _createTypedArray5512, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _createTypedArray5512, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readTypedArray5513; 
		public void readTypedArray(java.lang.Object[] arg0, android.os.Parcelable_Creator arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _readTypedArray5513, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _readTypedArray5513, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeParcelableArray5514; 
		public void writeParcelableArray(android.os.Parcelable[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, _writeParcelableArray5514, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Parcel.staticClass, _writeParcelableArray5514, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readValue5515; 
		public java.lang.Object readValue(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _readValue5515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readValue5515, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readParcelable5516; 
		public android.os.Parcelable readParcelable(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, _readParcelable5516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readParcelable5516, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readParcelableArray5517; 
		public android.os.Parcelable[] readParcelableArray(java.lang.ClassLoader arg0) 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _readParcelableArray5517, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readParcelableArray5517, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readSerializable5518; 
		public java.io.Serializable readSerializable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallObjectMethodPtr(this, _readSerializable5518)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Parcel.staticClass, _readSerializable5518)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _STRING_CREATOR5519; 
		public static android.os.Parcelable_Creator STRING_CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Parcel.staticClass = @__class; 
			global::android.os.Parcel._writeInt5420 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeInt", "(I)V"); 
			global::android.os.Parcel._readInt5421 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readInt", "()I"); 
			global::android.os.Parcel._readLong5422 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readLong", "()J"); 
			global::android.os.Parcel._readByte5423 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readByte", "()B"); 
			global::android.os.Parcel._writeLong5424 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeLong", "(J)V"); 
			global::android.os.Parcel._writeByte5425 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByte", "(B)V"); 
			global::android.os.Parcel._writeFloat5426 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFloat", "(F)V"); 
			global::android.os.Parcel._readFloat5427 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFloat", "()F"); 
			global::android.os.Parcel._readDouble5428 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readDouble", "()D"); 
			global::android.os.Parcel._readString5429 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readString", "()Ljava/lang/String;"); 
			global::android.os.Parcel._dataSize5430 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataSize", "()I"); 
			global::android.os.Parcel._writeValue5431 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeValue", "(Ljava/lang/Object;)V"); 
			global::android.os.Parcel._writeString5432 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeString", "(Ljava/lang/String;)V"); 
			global::android.os.Parcel._obtain5433 = @__env.GetStaticMethodID(global::android.os.Parcel.staticClass, "obtain", "()Landroid/os/Parcel;"); 
			global::android.os.Parcel._recycle5434 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "recycle", "()V"); 
			global::android.os.Parcel._hasFileDescriptors5435 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "hasFileDescriptors", "()Z"); 
			global::android.os.Parcel._dataAvail5436 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataAvail", "()I"); 
			global::android.os.Parcel._dataPosition5437 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataPosition", "()I"); 
			global::android.os.Parcel._dataCapacity5438 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataCapacity", "()I"); 
			global::android.os.Parcel._setDataSize5439 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataSize", "(I)V"); 
			global::android.os.Parcel._setDataPosition5440 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataPosition", "(I)V"); 
			global::android.os.Parcel._setDataCapacity5441 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataCapacity", "(I)V"); 
			global::android.os.Parcel._marshall5442 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "marshall", "()[B"); 
			global::android.os.Parcel._unmarshall5443 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "unmarshall", "([BII)V"); 
			global::android.os.Parcel._appendFrom5444 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "appendFrom", "(Landroid/os/Parcel;II)V"); 
			global::android.os.Parcel._writeInterfaceToken5445 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeInterfaceToken", "(Ljava/lang/String;)V"); 
			global::android.os.Parcel._enforceInterface5446 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "enforceInterface", "(Ljava/lang/String;)V"); 
			global::android.os.Parcel._writeByteArray5447 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByteArray", "([BII)V"); 
			global::android.os.Parcel._writeByteArray5448 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByteArray", "([B)V"); 
			global::android.os.Parcel._writeDouble5449 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeDouble", "(D)V"); 
			global::android.os.Parcel._writeStrongBinder5450 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStrongBinder", "(Landroid/os/IBinder;)V"); 
			global::android.os.Parcel._writeStrongInterface5451 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStrongInterface", "(Landroid/os/IInterface;)V"); 
			global::android.os.Parcel._writeFileDescriptor5452 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFileDescriptor", "(Ljava/io/FileDescriptor;)V"); 
			global::android.os.Parcel._writeMap5453 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeMap", "(Ljava/util/Map;)V"); 
			global::android.os.Parcel._writeBundle5454 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBundle", "(Landroid/os/Bundle;)V"); 
			global::android.os.Parcel._writeList5455 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._writeArray5456 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeArray", "([Ljava/lang/Object;)V"); 
			global::android.os.Parcel._writeSparseArray5457 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSparseArray", "(Landroid/util/SparseArray;)V"); 
			global::android.os.Parcel._writeSparseBooleanArray5458 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V"); 
			global::android.os.Parcel._writeBooleanArray5459 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBooleanArray", "([Z)V"); 
			global::android.os.Parcel._createBooleanArray5460 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBooleanArray", "()[Z"); 
			global::android.os.Parcel._readBooleanArray5461 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBooleanArray", "([Z)V"); 
			global::android.os.Parcel._writeCharArray5462 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeCharArray", "([C)V"); 
			global::android.os.Parcel._createCharArray5463 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createCharArray", "()[C"); 
			global::android.os.Parcel._readCharArray5464 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readCharArray", "([C)V"); 
			global::android.os.Parcel._writeIntArray5465 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeIntArray", "([I)V"); 
			global::android.os.Parcel._createIntArray5466 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createIntArray", "()[I"); 
			global::android.os.Parcel._readIntArray5467 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readIntArray", "([I)V"); 
			global::android.os.Parcel._writeLongArray5468 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeLongArray", "([J)V"); 
			global::android.os.Parcel._createLongArray5469 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createLongArray", "()[J"); 
			global::android.os.Parcel._readLongArray5470 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readLongArray", "([J)V"); 
			global::android.os.Parcel._writeFloatArray5471 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFloatArray", "([F)V"); 
			global::android.os.Parcel._createFloatArray5472 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createFloatArray", "()[F"); 
			global::android.os.Parcel._readFloatArray5473 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFloatArray", "([F)V"); 
			global::android.os.Parcel._writeDoubleArray5474 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeDoubleArray", "([D)V"); 
			global::android.os.Parcel._createDoubleArray5475 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createDoubleArray", "()[D"); 
			global::android.os.Parcel._readDoubleArray5476 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readDoubleArray", "([D)V"); 
			global::android.os.Parcel._writeStringArray5477 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStringArray", "([Ljava/lang/String;)V"); 
			global::android.os.Parcel._createStringArray5478 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createStringArray", "()[Ljava/lang/String;"); 
			global::android.os.Parcel._readStringArray5479 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStringArray", "([Ljava/lang/String;)V"); 
			global::android.os.Parcel._writeBinderArray5480 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBinderArray", "([Landroid/os/IBinder;)V"); 
			global::android.os.Parcel._createBinderArray5481 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBinderArray", "()[Landroid/os/IBinder;"); 
			global::android.os.Parcel._readBinderArray5482 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBinderArray", "([Landroid/os/IBinder;)V"); 
			global::android.os.Parcel._writeTypedList5483 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeTypedList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._writeStringList5484 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStringList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._writeBinderList5485 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBinderList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._writeTypedArray5486 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeTypedArray", "([Landroid/os/Parcelable;I)V"); 
			global::android.os.Parcel._writeParcelable5487 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeParcelable", "(Landroid/os/Parcelable;I)V"); 
			global::android.os.Parcel._writeSerializable5488 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSerializable", "(Ljava/io/Serializable;)V"); 
			global::android.os.Parcel._writeException5489 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeException", "(Ljava/lang/Exception;)V"); 
			global::android.os.Parcel._writeNoException5490 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeNoException", "()V"); 
			global::android.os.Parcel._readException5491 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readException", "()V"); 
			global::android.os.Parcel._readException5492 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readException", "(ILjava/lang/String;)V"); 
			global::android.os.Parcel._readStrongBinder5493 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStrongBinder", "()Landroid/os/IBinder;"); 
			global::android.os.Parcel._readFileDescriptor5494 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;"); 
			global::android.os.Parcel._readMap5495 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V"); 
			global::android.os.Parcel._readList5496 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V"); 
			global::android.os.Parcel._readHashMap5497 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;"); 
			global::android.os.Parcel._readBundle5498 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBundle", "()Landroid/os/Bundle;"); 
			global::android.os.Parcel._readBundle5499 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;"); 
			global::android.os.Parcel._createByteArray5500 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createByteArray", "()[B"); 
			global::android.os.Parcel._readByteArray5501 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readByteArray", "([B)V"); 
			global::android.os.Parcel._readArrayList5502 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;"); 
			global::android.os.Parcel._readArray5503 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;"); 
			global::android.os.Parcel._readSparseArray5504 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;"); 
			global::android.os.Parcel._readSparseBooleanArray5505 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;"); 
			global::android.os.Parcel._createTypedArrayList5506 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;"); 
			global::android.os.Parcel._readTypedList5507 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V"); 
			global::android.os.Parcel._createStringArrayList5508 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createStringArrayList", "()Ljava/util/ArrayList;"); 
			global::android.os.Parcel._createBinderArrayList5509 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBinderArrayList", "()Ljava/util/ArrayList;"); 
			global::android.os.Parcel._readStringList5510 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStringList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._readBinderList5511 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBinderList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._createTypedArray5512 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;"); 
			global::android.os.Parcel._readTypedArray5513 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V"); 
			global::android.os.Parcel._writeParcelableArray5514 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeParcelableArray", "([Landroid/os/Parcelable;I)V"); 
			global::android.os.Parcel._readValue5515 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;"); 
			global::android.os.Parcel._readParcelable5516 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;"); 
			global::android.os.Parcel._readParcelableArray5517 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;"); 
			global::android.os.Parcel._readSerializable5518 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSerializable", "()Ljava/io/Serializable;"); 
		} 
	} 
} 
