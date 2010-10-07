namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class Bundle : java.lang.Object, Parcelable, java.lang.Cloneable
	{
		internal static global::java.lang.Class staticClass;
		static Bundle()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.Bundle), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.Bundle(@__env);
			}
		}
		internal Bundle(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _get5925;
		public global::java.lang.Object get(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._get5925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._get5925, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString5926;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._toString5926));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._toString5926));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone5927;
		public global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._clone5927));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._clone5927));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean5928;
		public bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._getBoolean5928, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBoolean5928, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean5929;
		public bool getBoolean(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._getBoolean5929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBoolean5929, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putBoolean5930;
		public void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putBoolean5930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBoolean5930, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getByte5931;
		public byte getByte(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this, global::android.os.Bundle._getByte5931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByte5931, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getByte5932;
		public global::java.lang.Byte getByte(java.lang.String arg0, byte arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getByte5932, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByte5932, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putByte5933;
		public void putByte(java.lang.String arg0, byte arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putByte5933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putByte5933, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort5934;
		public short getShort(java.lang.String arg0, short arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.os.Bundle._getShort5934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShort5934, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort5935;
		public short getShort(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.os.Bundle._getShort5935, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShort5935, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putShort5936;
		public void putShort(java.lang.String arg0, short arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putShort5936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putShort5936, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChar5937;
		public char getChar(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.os.Bundle._getChar5937, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getChar5937, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChar5938;
		public char getChar(java.lang.String arg0, char arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.os.Bundle._getChar5938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getChar5938, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putChar5939;
		public void putChar(java.lang.String arg0, char arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putChar5939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putChar5939, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt5940;
		public int getInt(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Bundle._getInt5940, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getInt5940, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt5941;
		public int getInt(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Bundle._getInt5941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getInt5941, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putInt5942;
		public void putInt(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putInt5942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putInt5942, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong5943;
		public long getLong(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.os.Bundle._getLong5943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLong5943, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong5944;
		public long getLong(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.os.Bundle._getLong5944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLong5944, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putLong5945;
		public void putLong(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putLong5945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putLong5945, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat5946;
		public float getFloat(java.lang.String arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.os.Bundle._getFloat5946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloat5946, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat5947;
		public float getFloat(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.os.Bundle._getFloat5947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloat5947, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putFloat5948;
		public void putFloat(java.lang.String arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putFloat5948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putFloat5948, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble5949;
		public double getDouble(java.lang.String arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.os.Bundle._getDouble5949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDouble5949, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble5950;
		public double getDouble(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.os.Bundle._getDouble5950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDouble5950, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putDouble5951;
		public void putDouble(java.lang.String arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putDouble5951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putDouble5951, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear5952;
		public void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._clear5952);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._clear5952);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty5953;
		public bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._isEmpty5953);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._isEmpty5953);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size5954;
		public int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Bundle._size5954);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._size5954);
		}
		internal static global::net.sf.jni4net.jni.MethodId _putAll5955;
		public void putAll(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putAll5955, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putAll5955, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove5956;
		public void remove(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._remove5956, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._remove5956, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keySet5957;
		public global::java.util.Set keySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._keySet5957));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._keySet5957));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsKey5958;
		public bool containsKey(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._containsKey5958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._containsKey5958, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBundle5959;
		public global::android.os.Bundle getBundle(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getBundle5959, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBundle5959, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString5960;
		public global::java.lang.String getString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getString5960, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getString5960, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5961;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._writeToParcel5961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._writeToParcel5961, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5962;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Bundle._describeContents5962);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._describeContents5962);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFileDescriptors5963;
		public bool hasFileDescriptors() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._hasFileDescriptors5963);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._hasFileDescriptors5963);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel5964;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._readFromParcel5964, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._readFromParcel5964, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStringArray5965;
		public global::java.lang.String[] getStringArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getStringArray5965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getStringArray5965, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntArray5966;
		public int[] getIntArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getIntArray5966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getIntArray5966, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClassLoader5967;
		public void setClassLoader(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._setClassLoader5967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._setClassLoader5967, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putString5968;
		public void putString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putString5968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putString5968, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putCharSequence5969;
		public void putCharSequence(java.lang.String arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putCharSequence5969, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequence5969, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		public void putCharSequence(java.lang.String arg0, string arg1)
		{
			putCharSequence(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _putParcelable5970;
		public void putParcelable(java.lang.String arg0, android.os.Parcelable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putParcelable5970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelable5970, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putParcelableArray5971;
		public void putParcelableArray(java.lang.String arg0, android.os.Parcelable[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putParcelableArray5971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelableArray5971, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putParcelableArrayList5972;
		public void putParcelableArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putParcelableArrayList5972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelableArrayList5972, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putSparseParcelableArray5973;
		public void putSparseParcelableArray(java.lang.String arg0, android.util.SparseArray arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putSparseParcelableArray5973, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putSparseParcelableArray5973, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putIntegerArrayList5974;
		public void putIntegerArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putIntegerArrayList5974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putIntegerArrayList5974, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putStringArrayList5975;
		public void putStringArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putStringArrayList5975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putStringArrayList5975, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putCharSequenceArrayList5976;
		public void putCharSequenceArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putCharSequenceArrayList5976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequenceArrayList5976, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putSerializable5977;
		public void putSerializable(java.lang.String arg0, java.io.Serializable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putSerializable5977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putSerializable5977, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putBooleanArray5978;
		public void putBooleanArray(java.lang.String arg0, bool[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putBooleanArray5978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBooleanArray5978, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putByteArray5979;
		public void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putByteArray5979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putByteArray5979, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putShortArray5980;
		public void putShortArray(java.lang.String arg0, short[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putShortArray5980, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putShortArray5980, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putCharArray5981;
		public void putCharArray(java.lang.String arg0, char[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putCharArray5981, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharArray5981, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putIntArray5982;
		public void putIntArray(java.lang.String arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putIntArray5982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putIntArray5982, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putLongArray5983;
		public void putLongArray(java.lang.String arg0, long[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putLongArray5983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putLongArray5983, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putFloatArray5984;
		public void putFloatArray(java.lang.String arg0, float[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putFloatArray5984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putFloatArray5984, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putDoubleArray5985;
		public void putDoubleArray(java.lang.String arg0, double[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putDoubleArray5985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putDoubleArray5985, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putStringArray5986;
		public void putStringArray(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putStringArray5986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putStringArray5986, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putCharSequenceArray5987;
		public void putCharSequenceArray(java.lang.String arg0, java.lang.CharSequence[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putCharSequenceArray5987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequenceArray5987, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.CharSequence[], java.lang.CharSequence>(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putBundle5988;
		public void putBundle(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putBundle5988, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBundle5988, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCharSequence5989;
		public global::java.lang.CharSequence getCharSequence(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getCharSequence5989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequence5989, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelable5990;
		public global::android.os.Parcelable getParcelable(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getParcelable5990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelable5990, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableArray5991;
		public global::android.os.Parcelable[] getParcelableArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getParcelableArray5991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelableArray5991, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableArrayList5992;
		public global::java.util.ArrayList getParcelableArrayList(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getParcelableArrayList5992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelableArrayList5992, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSparseParcelableArray5993;
		public global::android.util.SparseArray getSparseParcelableArray(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getSparseParcelableArray5993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getSparseParcelableArray5993, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSerializable5994;
		public global::java.io.Serializable getSerializable(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getSerializable5994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getSerializable5994, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerArrayList5995;
		public global::java.util.ArrayList getIntegerArrayList(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getIntegerArrayList5995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getIntegerArrayList5995, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStringArrayList5996;
		public global::java.util.ArrayList getStringArrayList(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getStringArrayList5996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getStringArrayList5996, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCharSequenceArrayList5997;
		public global::java.util.ArrayList getCharSequenceArrayList(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getCharSequenceArrayList5997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequenceArrayList5997, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBooleanArray5998;
		public bool[] getBooleanArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getBooleanArray5998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBooleanArray5998, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getByteArray5999;
		public byte[] getByteArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getByteArray5999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByteArray5999, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShortArray6000;
		public short[] getShortArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getShortArray6000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShortArray6000, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCharArray6001;
		public char[] getCharArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getCharArray6001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharArray6001, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLongArray6002;
		public long[] getLongArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getLongArray6002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLongArray6002, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloatArray6003;
		public float[] getFloatArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getFloatArray6003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloatArray6003, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleArray6004;
		public double[] getDoubleArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getDoubleArray6004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDoubleArray6004, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCharSequenceArray6005;
		public global::java.lang.CharSequence[] getCharSequenceArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getCharSequenceArray6005, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequenceArray6005, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Bundle6006;
		public Bundle(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle6006, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Bundle6007;
		public Bundle(java.lang.ClassLoader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle6007, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Bundle6008;
		public Bundle(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle6008, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Bundle6009;
		public Bundle()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle6009, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _EMPTY6010;
		public static global::android.os.Bundle EMPTY
		{
			get
			{
				return default(global::android.os.Bundle);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR6011;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.Bundle.staticClass = @__class;
			global::android.os.Bundle._get5925 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.os.Bundle._toString5926 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Bundle._clone5927 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.os.Bundle._getBoolean5928 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::android.os.Bundle._getBoolean5929 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::android.os.Bundle._putBoolean5930 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::android.os.Bundle._getByte5931 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::android.os.Bundle._getByte5932 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;");
			global::android.os.Bundle._putByte5933 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putByte", "(Ljava/lang/String;B)V");
			global::android.os.Bundle._getShort5934 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;S)S");
			global::android.os.Bundle._getShort5935 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::android.os.Bundle._putShort5936 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putShort", "(Ljava/lang/String;S)V");
			global::android.os.Bundle._getChar5937 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;)C");
			global::android.os.Bundle._getChar5938 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;C)C");
			global::android.os.Bundle._putChar5939 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putChar", "(Ljava/lang/String;C)V");
			global::android.os.Bundle._getInt5940 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::android.os.Bundle._getInt5941 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::android.os.Bundle._putInt5942 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::android.os.Bundle._getLong5943 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::android.os.Bundle._getLong5944 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::android.os.Bundle._putLong5945 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::android.os.Bundle._getFloat5946 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::android.os.Bundle._getFloat5947 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::android.os.Bundle._putFloat5948 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::android.os.Bundle._getDouble5949 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::android.os.Bundle._getDouble5950 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::android.os.Bundle._putDouble5951 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::android.os.Bundle._clear5952 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "clear", "()V");
			global::android.os.Bundle._isEmpty5953 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "isEmpty", "()Z");
			global::android.os.Bundle._size5954 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "size", "()I");
			global::android.os.Bundle._putAll5955 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putAll", "(Landroid/os/Bundle;)V");
			global::android.os.Bundle._remove5956 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "remove", "(Ljava/lang/String;)V");
			global::android.os.Bundle._keySet5957 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "keySet", "()Ljava/util/Set;");
			global::android.os.Bundle._containsKey5958 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::android.os.Bundle._getBundle5959 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.os.Bundle._getString5960 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.os.Bundle._writeToParcel5961 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Bundle._describeContents5962 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "describeContents", "()I");
			global::android.os.Bundle._hasFileDescriptors5963 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "hasFileDescriptors", "()Z");
			global::android.os.Bundle._readFromParcel5964 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.os.Bundle._getStringArray5965 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::android.os.Bundle._getIntArray5966 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getIntArray", "(Ljava/lang/String;)[I");
			global::android.os.Bundle._setClassLoader5967 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "setClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::android.os.Bundle._putString5968 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.os.Bundle._putCharSequence5969 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V");
			global::android.os.Bundle._putParcelable5970 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V");
			global::android.os.Bundle._putParcelableArray5971 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V");
			global::android.os.Bundle._putParcelableArrayList5972 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putSparseParcelableArray5973 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V");
			global::android.os.Bundle._putIntegerArrayList5974 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putStringArrayList5975 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putCharSequenceArrayList5976 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putCharSequenceArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putSerializable5977 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V");
			global::android.os.Bundle._putBooleanArray5978 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBooleanArray", "(Ljava/lang/String;[Z)V");
			global::android.os.Bundle._putByteArray5979 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::android.os.Bundle._putShortArray5980 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putShortArray", "(Ljava/lang/String;[S)V");
			global::android.os.Bundle._putCharArray5981 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putCharArray", "(Ljava/lang/String;[C)V");
			global::android.os.Bundle._putIntArray5982 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putIntArray", "(Ljava/lang/String;[I)V");
			global::android.os.Bundle._putLongArray5983 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putLongArray", "(Ljava/lang/String;[J)V");
			global::android.os.Bundle._putFloatArray5984 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putFloatArray", "(Ljava/lang/String;[F)V");
			global::android.os.Bundle._putDoubleArray5985 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putDoubleArray", "(Ljava/lang/String;[D)V");
			global::android.os.Bundle._putStringArray5986 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.os.Bundle._putCharSequenceArray5987 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putCharSequenceArray", "(Ljava/lang/String;[Ljava/lang/CharSequence;)V");
			global::android.os.Bundle._putBundle5988 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.os.Bundle._getCharSequence5989 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.os.Bundle._getParcelable5990 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;");
			global::android.os.Bundle._getParcelableArray5991 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;");
			global::android.os.Bundle._getParcelableArrayList5992 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getSparseParcelableArray5993 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;");
			global::android.os.Bundle._getSerializable5994 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;");
			global::android.os.Bundle._getIntegerArrayList5995 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getStringArrayList5996 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getCharSequenceArrayList5997 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getCharSequenceArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getBooleanArray5998 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBooleanArray", "(Ljava/lang/String;)[Z");
			global::android.os.Bundle._getByteArray5999 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByteArray", "(Ljava/lang/String;)[B");
			global::android.os.Bundle._getShortArray6000 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShortArray", "(Ljava/lang/String;)[S");
			global::android.os.Bundle._getCharArray6001 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getCharArray", "(Ljava/lang/String;)[C");
			global::android.os.Bundle._getLongArray6002 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLongArray", "(Ljava/lang/String;)[J");
			global::android.os.Bundle._getFloatArray6003 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloatArray", "(Ljava/lang/String;)[F");
			global::android.os.Bundle._getDoubleArray6004 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDoubleArray", "(Ljava/lang/String;)[D");
			global::android.os.Bundle._getCharSequenceArray6005 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getCharSequenceArray", "(Ljava/lang/String;)[Ljava/lang/CharSequence;");
			global::android.os.Bundle._Bundle6006 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::android.os.Bundle._Bundle6007 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::android.os.Bundle._Bundle6008 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(I)V");
			global::android.os.Bundle._Bundle6009 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "()V");
		}
	}
}
