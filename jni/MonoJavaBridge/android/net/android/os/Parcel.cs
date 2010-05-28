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
		internal static global::net.sf.jni4net.jni.MethodId _writeInt5690; 
		public void writeInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeInt5690, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInt5690, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readInt5691; 
		public int readInt() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, global::android.os.Parcel._readInt5691); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readInt5691); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readLong5692; 
		public long readLong() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallLongMethod(this, global::android.os.Parcel._readLong5692); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLong5692); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readByte5693; 
		public byte readByte() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallByteMethod(this, global::android.os.Parcel._readByte5693); 
			else 
				return @__env.CallNonVirtualByteMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByte5693); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeLong5694; 
		public void writeLong(long arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeLong5694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLong5694, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeByte5695; 
		public void writeByte(byte arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeByte5695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByte5695, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeFloat5696; 
		public void writeFloat(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeFloat5696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloat5696, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFloat5697; 
		public float readFloat() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallFloatMethod(this, global::android.os.Parcel._readFloat5697); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloat5697); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readDouble5698; 
		public double readDouble() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallDoubleMethod(this, global::android.os.Parcel._readDouble5698); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDouble5698); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readString5699; 
		public global::java.lang.String readString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readString5699)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readString5699)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dataSize5700; 
		public int dataSize() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, global::android.os.Parcel._dataSize5700); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataSize5700); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeValue5701; 
		public void writeValue(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeValue5701, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeValue5701, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeString5702; 
		public void writeString(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeString5702, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeString5702, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _obtain5703; 
		public static global::android.os.Parcel obtain() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Parcel>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Parcel.staticClass, global::android.os.Parcel._obtain5703)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _recycle5704; 
		public void recycle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._recycle5704); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._recycle5704); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasFileDescriptors5705; 
		public bool hasFileDescriptors() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallBooleanMethod(this, global::android.os.Parcel._hasFileDescriptors5705); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._hasFileDescriptors5705); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dataAvail5706; 
		public int dataAvail() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, global::android.os.Parcel._dataAvail5706); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataAvail5706); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dataPosition5707; 
		public int dataPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, global::android.os.Parcel._dataPosition5707); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataPosition5707); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dataCapacity5708; 
		public int dataCapacity() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return @__env.CallIntMethod(this, global::android.os.Parcel._dataCapacity5708); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._dataCapacity5708); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataSize5709; 
		public void setDataSize(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._setDataSize5709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataSize5709, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataPosition5710; 
		public void setDataPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._setDataPosition5710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataPosition5710, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setDataCapacity5711; 
		public void setDataCapacity(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._setDataCapacity5711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._setDataCapacity5711, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _marshall5712; 
		public byte[] marshall() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._marshall5712)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._marshall5712)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unmarshall5713; 
		public void unmarshall(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._unmarshall5713, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._unmarshall5713, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _appendFrom5714; 
		public void appendFrom(android.os.Parcel arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._appendFrom5714, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._appendFrom5714, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeInterfaceToken5715; 
		public void writeInterfaceToken(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeInterfaceToken5715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeInterfaceToken5715, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _enforceInterface5716; 
		public void enforceInterface(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._enforceInterface5716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._enforceInterface5716, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeByteArray5717; 
		public void writeByteArray(byte[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeByteArray5717, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray5717, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeByteArray5718; 
		public void writeByteArray(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeByteArray5718, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeByteArray5718, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeDouble5719; 
		public void writeDouble(double arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeDouble5719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDouble5719, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeStrongBinder5720; 
		public void writeStrongBinder(android.os.IBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeStrongBinder5720, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongBinder5720, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeStrongInterface5721; 
		public void writeStrongInterface(android.os.IInterface arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeStrongInterface5721, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStrongInterface5721, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeFileDescriptor5722; 
		public void writeFileDescriptor(java.io.FileDescriptor arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeFileDescriptor5722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFileDescriptor5722, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeMap5723; 
		public void writeMap(java.util.Map arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeMap5723, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeMap5723, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBundle5724; 
		public void writeBundle(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeBundle5724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBundle5724, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeList5725; 
		public void writeList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeList5725, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeList5725, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeArray5726; 
		public void writeArray(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeArray5726, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeArray5726, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeSparseArray5727; 
		public void writeSparseArray(android.util.SparseArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeSparseArray5727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseArray5727, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeSparseBooleanArray5728; 
		public void writeSparseBooleanArray(android.util.SparseBooleanArray arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeSparseBooleanArray5728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSparseBooleanArray5728, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBooleanArray5729; 
		public void writeBooleanArray(bool[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeBooleanArray5729, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBooleanArray5729, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBooleanArray5730; 
		public bool[] createBooleanArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createBooleanArray5730)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBooleanArray5730)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBooleanArray5731; 
		public void readBooleanArray(bool[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readBooleanArray5731, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBooleanArray5731, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeCharArray5732; 
		public void writeCharArray(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeCharArray5732, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeCharArray5732, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createCharArray5733; 
		public char[] createCharArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createCharArray5733)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createCharArray5733)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readCharArray5734; 
		public void readCharArray(char[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readCharArray5734, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readCharArray5734, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeIntArray5735; 
		public void writeIntArray(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeIntArray5735, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeIntArray5735, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createIntArray5736; 
		public int[] createIntArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createIntArray5736)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createIntArray5736)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readIntArray5737; 
		public void readIntArray(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readIntArray5737, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readIntArray5737, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeLongArray5738; 
		public void writeLongArray(long[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeLongArray5738, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeLongArray5738, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createLongArray5739; 
		public long[] createLongArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createLongArray5739)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createLongArray5739)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readLongArray5740; 
		public void readLongArray(long[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readLongArray5740, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readLongArray5740, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeFloatArray5741; 
		public void writeFloatArray(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeFloatArray5741, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeFloatArray5741, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFloatArray5742; 
		public float[] createFloatArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createFloatArray5742)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createFloatArray5742)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFloatArray5743; 
		public void readFloatArray(float[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readFloatArray5743, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFloatArray5743, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeDoubleArray5744; 
		public void writeDoubleArray(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeDoubleArray5744, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeDoubleArray5744, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createDoubleArray5745; 
		public double[] createDoubleArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createDoubleArray5745)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createDoubleArray5745)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readDoubleArray5746; 
		public void readDoubleArray(double[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readDoubleArray5746, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readDoubleArray5746, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeStringArray5747; 
		public void writeStringArray(java.lang.String[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeStringArray5747, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringArray5747, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createStringArray5748; 
		public global::java.lang.String[] createStringArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createStringArray5748)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArray5748)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readStringArray5749; 
		public void readStringArray(java.lang.String[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readStringArray5749, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringArray5749, global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBinderArray5750; 
		public void writeBinderArray(android.os.IBinder[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeBinderArray5750, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderArray5750, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBinderArray5751; 
		public global::android.os.IBinder[] createBinderArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createBinderArray5751)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArray5751)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBinderArray5752; 
		public void readBinderArray(android.os.IBinder[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readBinderArray5752, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderArray5752, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.IBinder[], android.os.IBinder>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeTypedList5753; 
		public void writeTypedList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeTypedList5753, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedList5753, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeStringList5754; 
		public void writeStringList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeStringList5754, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeStringList5754, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeBinderList5755; 
		public void writeBinderList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeBinderList5755, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeBinderList5755, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeTypedArray5756; 
		public void writeTypedArray(android.os.Parcelable[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeTypedArray5756, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeTypedArray5756, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeParcelable5757; 
		public void writeParcelable(android.os.Parcelable arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeParcelable5757, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelable5757, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeSerializable5758; 
		public void writeSerializable(java.io.Serializable arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeSerializable5758, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeSerializable5758, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeException5759; 
		public void writeException(java.lang.Exception arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeException5759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeException5759, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeNoException5760; 
		public void writeNoException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeNoException5760); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeNoException5760); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readException5761; 
		public void readException() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readException5761); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException5761); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readException5762; 
		public void readException(int arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readException5762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readException5762, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readStrongBinder5763; 
		public global::android.os.IBinder readStrongBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readStrongBinder5763)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStrongBinder5763)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readFileDescriptor5764; 
		public global::android.os.ParcelFileDescriptor readFileDescriptor() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readFileDescriptor5764)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readFileDescriptor5764)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readMap5765; 
		public void readMap(java.util.Map arg0, java.lang.ClassLoader arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readMap5765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readMap5765, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readList5766; 
		public void readList(java.util.List arg0, java.lang.ClassLoader arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readList5766, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readList5766, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readHashMap5767; 
		public global::java.util.HashMap readHashMap(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.HashMap>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readHashMap5767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.HashMap>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readHashMap5767, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBundle5768; 
		public global::android.os.Bundle readBundle() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readBundle5768)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle5768)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBundle5769; 
		public global::android.os.Bundle readBundle(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readBundle5769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBundle5769, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createByteArray5770; 
		public byte[] createByteArray() 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createByteArray5770)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createByteArray5770)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readByteArray5771; 
		public void readByteArray(byte[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readByteArray5771, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readByteArray5771, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readArrayList5772; 
		public global::java.util.ArrayList readArrayList(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readArrayList5772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArrayList5772, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readArray5773; 
		public global::java.lang.Object[] readArray(java.lang.ClassLoader arg0) 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readArray5773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readArray5773, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readSparseArray5774; 
		public global::android.util.SparseArray readSparseArray(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readSparseArray5774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseArray5774, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readSparseBooleanArray5775; 
		public global::android.util.SparseBooleanArray readSparseBooleanArray() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readSparseBooleanArray5775)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseBooleanArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSparseBooleanArray5775)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createTypedArrayList5776; 
		public global::java.util.ArrayList createTypedArrayList(android.os.Parcelable_Creator arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createTypedArrayList5776, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArrayList5776, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readTypedList5777; 
		public void readTypedList(java.util.List arg0, android.os.Parcelable_Creator arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readTypedList5777, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedList5777, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createStringArrayList5778; 
		public global::java.util.ArrayList createStringArrayList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createStringArrayList5778)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createStringArrayList5778)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createBinderArrayList5779; 
		public global::java.util.ArrayList createBinderArrayList() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createBinderArrayList5779)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createBinderArrayList5779)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readStringList5780; 
		public void readStringList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readStringList5780, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readStringList5780, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readBinderList5781; 
		public void readBinderList(java.util.List arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readBinderList5781, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readBinderList5781, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createTypedArray5782; 
		public global::java.lang.Object[] createTypedArray(android.os.Parcelable_Creator arg0) 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._createTypedArray5782, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._createTypedArray5782, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readTypedArray5783; 
		public void readTypedArray(java.lang.Object[] arg0, android.os.Parcelable_Creator arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._readTypedArray5783, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readTypedArray5783, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeParcelableArray5784; 
		public void writeParcelableArray(android.os.Parcelable[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				@__env.CallVoidMethod(this, global::android.os.Parcel._writeParcelableArray5784, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._writeParcelableArray5784, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readValue5785; 
		public global::java.lang.Object readValue(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readValue5785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readValue5785, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readParcelable5786; 
		public global::android.os.Parcelable readParcelable(java.lang.ClassLoader arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readParcelable5786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelable5786, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readParcelableArray5787; 
		public global::android.os.Parcelable[] readParcelableArray(java.lang.ClassLoader arg0) 
		{ 
			if (GetType() == typeof(android.os.Parcel)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readParcelableArray5787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readParcelableArray5787, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readSerializable5788; 
		public global::java.io.Serializable readSerializable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Parcel)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Parcel._readSerializable5788)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Parcel.staticClass, global::android.os.Parcel._readSerializable5788)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _STRING_CREATOR5789; 
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
			global::android.os.Parcel._writeInt5690 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeInt", "(I)V"); 
			global::android.os.Parcel._readInt5691 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readInt", "()I"); 
			global::android.os.Parcel._readLong5692 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readLong", "()J"); 
			global::android.os.Parcel._readByte5693 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readByte", "()B"); 
			global::android.os.Parcel._writeLong5694 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeLong", "(J)V"); 
			global::android.os.Parcel._writeByte5695 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByte", "(B)V"); 
			global::android.os.Parcel._writeFloat5696 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFloat", "(F)V"); 
			global::android.os.Parcel._readFloat5697 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFloat", "()F"); 
			global::android.os.Parcel._readDouble5698 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readDouble", "()D"); 
			global::android.os.Parcel._readString5699 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readString", "()Ljava/lang/String;"); 
			global::android.os.Parcel._dataSize5700 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataSize", "()I"); 
			global::android.os.Parcel._writeValue5701 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeValue", "(Ljava/lang/Object;)V"); 
			global::android.os.Parcel._writeString5702 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeString", "(Ljava/lang/String;)V"); 
			global::android.os.Parcel._obtain5703 = @__env.GetStaticMethodID(global::android.os.Parcel.staticClass, "obtain", "()Landroid/os/Parcel;"); 
			global::android.os.Parcel._recycle5704 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "recycle", "()V"); 
			global::android.os.Parcel._hasFileDescriptors5705 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "hasFileDescriptors", "()Z"); 
			global::android.os.Parcel._dataAvail5706 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataAvail", "()I"); 
			global::android.os.Parcel._dataPosition5707 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataPosition", "()I"); 
			global::android.os.Parcel._dataCapacity5708 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "dataCapacity", "()I"); 
			global::android.os.Parcel._setDataSize5709 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataSize", "(I)V"); 
			global::android.os.Parcel._setDataPosition5710 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataPosition", "(I)V"); 
			global::android.os.Parcel._setDataCapacity5711 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "setDataCapacity", "(I)V"); 
			global::android.os.Parcel._marshall5712 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "marshall", "()[B"); 
			global::android.os.Parcel._unmarshall5713 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "unmarshall", "([BII)V"); 
			global::android.os.Parcel._appendFrom5714 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "appendFrom", "(Landroid/os/Parcel;II)V"); 
			global::android.os.Parcel._writeInterfaceToken5715 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeInterfaceToken", "(Ljava/lang/String;)V"); 
			global::android.os.Parcel._enforceInterface5716 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "enforceInterface", "(Ljava/lang/String;)V"); 
			global::android.os.Parcel._writeByteArray5717 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByteArray", "([BII)V"); 
			global::android.os.Parcel._writeByteArray5718 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeByteArray", "([B)V"); 
			global::android.os.Parcel._writeDouble5719 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeDouble", "(D)V"); 
			global::android.os.Parcel._writeStrongBinder5720 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStrongBinder", "(Landroid/os/IBinder;)V"); 
			global::android.os.Parcel._writeStrongInterface5721 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStrongInterface", "(Landroid/os/IInterface;)V"); 
			global::android.os.Parcel._writeFileDescriptor5722 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFileDescriptor", "(Ljava/io/FileDescriptor;)V"); 
			global::android.os.Parcel._writeMap5723 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeMap", "(Ljava/util/Map;)V"); 
			global::android.os.Parcel._writeBundle5724 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBundle", "(Landroid/os/Bundle;)V"); 
			global::android.os.Parcel._writeList5725 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._writeArray5726 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeArray", "([Ljava/lang/Object;)V"); 
			global::android.os.Parcel._writeSparseArray5727 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSparseArray", "(Landroid/util/SparseArray;)V"); 
			global::android.os.Parcel._writeSparseBooleanArray5728 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSparseBooleanArray", "(Landroid/util/SparseBooleanArray;)V"); 
			global::android.os.Parcel._writeBooleanArray5729 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBooleanArray", "([Z)V"); 
			global::android.os.Parcel._createBooleanArray5730 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBooleanArray", "()[Z"); 
			global::android.os.Parcel._readBooleanArray5731 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBooleanArray", "([Z)V"); 
			global::android.os.Parcel._writeCharArray5732 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeCharArray", "([C)V"); 
			global::android.os.Parcel._createCharArray5733 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createCharArray", "()[C"); 
			global::android.os.Parcel._readCharArray5734 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readCharArray", "([C)V"); 
			global::android.os.Parcel._writeIntArray5735 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeIntArray", "([I)V"); 
			global::android.os.Parcel._createIntArray5736 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createIntArray", "()[I"); 
			global::android.os.Parcel._readIntArray5737 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readIntArray", "([I)V"); 
			global::android.os.Parcel._writeLongArray5738 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeLongArray", "([J)V"); 
			global::android.os.Parcel._createLongArray5739 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createLongArray", "()[J"); 
			global::android.os.Parcel._readLongArray5740 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readLongArray", "([J)V"); 
			global::android.os.Parcel._writeFloatArray5741 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeFloatArray", "([F)V"); 
			global::android.os.Parcel._createFloatArray5742 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createFloatArray", "()[F"); 
			global::android.os.Parcel._readFloatArray5743 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFloatArray", "([F)V"); 
			global::android.os.Parcel._writeDoubleArray5744 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeDoubleArray", "([D)V"); 
			global::android.os.Parcel._createDoubleArray5745 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createDoubleArray", "()[D"); 
			global::android.os.Parcel._readDoubleArray5746 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readDoubleArray", "([D)V"); 
			global::android.os.Parcel._writeStringArray5747 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStringArray", "([Ljava/lang/String;)V"); 
			global::android.os.Parcel._createStringArray5748 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createStringArray", "()[Ljava/lang/String;"); 
			global::android.os.Parcel._readStringArray5749 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStringArray", "([Ljava/lang/String;)V"); 
			global::android.os.Parcel._writeBinderArray5750 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBinderArray", "([Landroid/os/IBinder;)V"); 
			global::android.os.Parcel._createBinderArray5751 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBinderArray", "()[Landroid/os/IBinder;"); 
			global::android.os.Parcel._readBinderArray5752 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBinderArray", "([Landroid/os/IBinder;)V"); 
			global::android.os.Parcel._writeTypedList5753 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeTypedList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._writeStringList5754 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeStringList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._writeBinderList5755 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeBinderList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._writeTypedArray5756 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeTypedArray", "([Landroid/os/Parcelable;I)V"); 
			global::android.os.Parcel._writeParcelable5757 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeParcelable", "(Landroid/os/Parcelable;I)V"); 
			global::android.os.Parcel._writeSerializable5758 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeSerializable", "(Ljava/io/Serializable;)V"); 
			global::android.os.Parcel._writeException5759 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeException", "(Ljava/lang/Exception;)V"); 
			global::android.os.Parcel._writeNoException5760 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeNoException", "()V"); 
			global::android.os.Parcel._readException5761 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readException", "()V"); 
			global::android.os.Parcel._readException5762 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readException", "(ILjava/lang/String;)V"); 
			global::android.os.Parcel._readStrongBinder5763 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStrongBinder", "()Landroid/os/IBinder;"); 
			global::android.os.Parcel._readFileDescriptor5764 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readFileDescriptor", "()Landroid/os/ParcelFileDescriptor;"); 
			global::android.os.Parcel._readMap5765 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readMap", "(Ljava/util/Map;Ljava/lang/ClassLoader;)V"); 
			global::android.os.Parcel._readList5766 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readList", "(Ljava/util/List;Ljava/lang/ClassLoader;)V"); 
			global::android.os.Parcel._readHashMap5767 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readHashMap", "(Ljava/lang/ClassLoader;)Ljava/util/HashMap;"); 
			global::android.os.Parcel._readBundle5768 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBundle", "()Landroid/os/Bundle;"); 
			global::android.os.Parcel._readBundle5769 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBundle", "(Ljava/lang/ClassLoader;)Landroid/os/Bundle;"); 
			global::android.os.Parcel._createByteArray5770 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createByteArray", "()[B"); 
			global::android.os.Parcel._readByteArray5771 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readByteArray", "([B)V"); 
			global::android.os.Parcel._readArrayList5772 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readArrayList", "(Ljava/lang/ClassLoader;)Ljava/util/ArrayList;"); 
			global::android.os.Parcel._readArray5773 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readArray", "(Ljava/lang/ClassLoader;)[Ljava/lang/Object;"); 
			global::android.os.Parcel._readSparseArray5774 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSparseArray", "(Ljava/lang/ClassLoader;)Landroid/util/SparseArray;"); 
			global::android.os.Parcel._readSparseBooleanArray5775 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSparseBooleanArray", "()Landroid/util/SparseBooleanArray;"); 
			global::android.os.Parcel._createTypedArrayList5776 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createTypedArrayList", "(Landroid/os/Parcelable$Creator;)Ljava/util/ArrayList;"); 
			global::android.os.Parcel._readTypedList5777 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readTypedList", "(Ljava/util/List;Landroid/os/Parcelable$Creator;)V"); 
			global::android.os.Parcel._createStringArrayList5778 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createStringArrayList", "()Ljava/util/ArrayList;"); 
			global::android.os.Parcel._createBinderArrayList5779 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createBinderArrayList", "()Ljava/util/ArrayList;"); 
			global::android.os.Parcel._readStringList5780 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readStringList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._readBinderList5781 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readBinderList", "(Ljava/util/List;)V"); 
			global::android.os.Parcel._createTypedArray5782 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "createTypedArray", "(Landroid/os/Parcelable$Creator;)[Ljava/lang/Object;"); 
			global::android.os.Parcel._readTypedArray5783 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readTypedArray", "([Ljava/lang/Object;Landroid/os/Parcelable$Creator;)V"); 
			global::android.os.Parcel._writeParcelableArray5784 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "writeParcelableArray", "([Landroid/os/Parcelable;I)V"); 
			global::android.os.Parcel._readValue5785 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readValue", "(Ljava/lang/ClassLoader;)Ljava/lang/Object;"); 
			global::android.os.Parcel._readParcelable5786 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readParcelable", "(Ljava/lang/ClassLoader;)Landroid/os/Parcelable;"); 
			global::android.os.Parcel._readParcelableArray5787 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readParcelableArray", "(Ljava/lang/ClassLoader;)[Landroid/os/Parcelable;"); 
			global::android.os.Parcel._readSerializable5788 = @__env.GetMethodID(global::android.os.Parcel.staticClass, "readSerializable", "()Ljava/io/Serializable;"); 
		} 
	} 
} 
