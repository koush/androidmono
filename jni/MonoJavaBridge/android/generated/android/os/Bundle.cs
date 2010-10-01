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
		internal static global::net.sf.jni4net.jni.MethodId _get5391;
		public global::java.lang.Object get(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._get5391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._get5391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString5392;
		public sealed override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._toString5392));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._toString5392));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clone5393;
		public global::java.lang.Object clone() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._clone5393));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._clone5393));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean5394;
		public bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._getBoolean5394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBoolean5394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBoolean5395;
		public bool getBoolean(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._getBoolean5395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBoolean5395, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putBoolean5396;
		public void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putBoolean5396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBoolean5396, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getByte5397;
		public byte getByte(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this, global::android.os.Bundle._getByte5397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByte5397, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getByte5398;
		public global::java.lang.Byte getByte(java.lang.String arg0, byte arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getByte5398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.Byte>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByte5398, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putByte5399;
		public void putByte(java.lang.String arg0, byte arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putByte5399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putByte5399, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort5400;
		public short getShort(java.lang.String arg0, short arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.os.Bundle._getShort5400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShort5400, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort5401;
		public short getShort(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.os.Bundle._getShort5401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShort5401, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putShort5402;
		public void putShort(java.lang.String arg0, short arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putShort5402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putShort5402, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChar5403;
		public char getChar(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.os.Bundle._getChar5403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getChar5403, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getChar5404;
		public char getChar(java.lang.String arg0, char arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this, global::android.os.Bundle._getChar5404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getChar5404, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putChar5405;
		public void putChar(java.lang.String arg0, char arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putChar5405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putChar5405, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt5406;
		public int getInt(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Bundle._getInt5406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getInt5406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt5407;
		public int getInt(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Bundle._getInt5407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getInt5407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putInt5408;
		public void putInt(java.lang.String arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putInt5408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putInt5408, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong5409;
		public long getLong(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.os.Bundle._getLong5409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLong5409, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong5410;
		public long getLong(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.os.Bundle._getLong5410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLong5410, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putLong5411;
		public void putLong(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putLong5411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putLong5411, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat5412;
		public float getFloat(java.lang.String arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.os.Bundle._getFloat5412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloat5412, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat5413;
		public float getFloat(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.os.Bundle._getFloat5413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloat5413, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putFloat5414;
		public void putFloat(java.lang.String arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putFloat5414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putFloat5414, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble5415;
		public double getDouble(java.lang.String arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.os.Bundle._getDouble5415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDouble5415, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble5416;
		public double getDouble(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.os.Bundle._getDouble5416, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDouble5416, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putDouble5417;
		public void putDouble(java.lang.String arg0, double arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putDouble5417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putDouble5417, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _clear5418;
		public void clear() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._clear5418);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._clear5418);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isEmpty5419;
		public bool isEmpty() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._isEmpty5419);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._isEmpty5419);
		}
		internal static global::net.sf.jni4net.jni.MethodId _size5420;
		public int size() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Bundle._size5420);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._size5420);
		}
		internal static global::net.sf.jni4net.jni.MethodId _putAll5421;
		public void putAll(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putAll5421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putAll5421, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _remove5422;
		public void remove(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._remove5422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._remove5422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _keySet5423;
		public global::java.util.Set keySet() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._keySet5423));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Set>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._keySet5423));
		}
		internal static global::net.sf.jni4net.jni.MethodId _containsKey5424;
		public bool containsKey(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._containsKey5424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._containsKey5424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBundle5425;
		public global::android.os.Bundle getBundle(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getBundle5425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBundle5425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString5426;
		public global::java.lang.String getString(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getString5426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getString5426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5427;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._writeToParcel5427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._writeToParcel5427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5428;
		public int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.Bundle._describeContents5428);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._describeContents5428);
		}
		internal static global::net.sf.jni4net.jni.MethodId _hasFileDescriptors5429;
		public bool hasFileDescriptors() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.Bundle._hasFileDescriptors5429);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._hasFileDescriptors5429);
		}
		internal static global::net.sf.jni4net.jni.MethodId _readFromParcel5430;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._readFromParcel5430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._readFromParcel5430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStringArray5431;
		public global::java.lang.String[] getStringArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getStringArray5431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getStringArray5431, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntArray5432;
		public int[] getIntArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getIntArray5432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getIntArray5432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setClassLoader5433;
		public void setClassLoader(java.lang.ClassLoader arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._setClassLoader5433, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._setClassLoader5433, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putString5434;
		public void putString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putString5434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putString5434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putCharSequence5435;
		public void putCharSequence(java.lang.String arg0, java.lang.CharSequence arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putCharSequence5435, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequence5435, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		public void putCharSequence(java.lang.String arg0, string arg1)
		{
			putCharSequence(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::net.sf.jni4net.jni.MethodId _putParcelable5436;
		public void putParcelable(java.lang.String arg0, android.os.Parcelable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putParcelable5436, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelable5436, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putParcelableArray5437;
		public void putParcelableArray(java.lang.String arg0, android.os.Parcelable[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putParcelableArray5437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelableArray5437, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<android.os.Parcelable[], android.os.Parcelable>(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putParcelableArrayList5438;
		public void putParcelableArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putParcelableArrayList5438, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelableArrayList5438, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putSparseParcelableArray5439;
		public void putSparseParcelableArray(java.lang.String arg0, android.util.SparseArray arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putSparseParcelableArray5439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putSparseParcelableArray5439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putIntegerArrayList5440;
		public void putIntegerArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putIntegerArrayList5440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putIntegerArrayList5440, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putStringArrayList5441;
		public void putStringArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putStringArrayList5441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putStringArrayList5441, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putSerializable5442;
		public void putSerializable(java.lang.String arg0, java.io.Serializable arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putSerializable5442, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putSerializable5442, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putBooleanArray5443;
		public void putBooleanArray(java.lang.String arg0, bool[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putBooleanArray5443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBooleanArray5443, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putByteArray5444;
		public void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putByteArray5444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putByteArray5444, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putShortArray5445;
		public void putShortArray(java.lang.String arg0, short[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putShortArray5445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putShortArray5445, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putCharArray5446;
		public void putCharArray(java.lang.String arg0, char[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putCharArray5446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharArray5446, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putIntArray5447;
		public void putIntArray(java.lang.String arg0, int[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putIntArray5447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putIntArray5447, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putLongArray5448;
		public void putLongArray(java.lang.String arg0, long[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putLongArray5448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putLongArray5448, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putFloatArray5449;
		public void putFloatArray(java.lang.String arg0, float[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putFloatArray5449, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putFloatArray5449, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putDoubleArray5450;
		public void putDoubleArray(java.lang.String arg0, double[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putDoubleArray5450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putDoubleArray5450, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putStringArray5451;
		public void putStringArray(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putStringArray5451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putStringArray5451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _putBundle5452;
		public void putBundle(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.Bundle._putBundle5452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBundle5452, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCharSequence5453;
		public global::java.lang.CharSequence getCharSequence(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getCharSequence5453, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.CharSequence>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequence5453, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelable5454;
		public global::android.os.Parcelable getParcelable(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getParcelable5454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.Parcelable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelable5454, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableArray5455;
		public global::android.os.Parcelable[] getParcelableArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getParcelableArray5455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelableArray5455, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParcelableArrayList5456;
		public global::java.util.ArrayList getParcelableArrayList(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getParcelableArrayList5456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelableArrayList5456, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSparseParcelableArray5457;
		public global::android.util.SparseArray getSparseParcelableArray(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getSparseParcelableArray5457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.util.SparseArray>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getSparseParcelableArray5457, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSerializable5458;
		public global::java.io.Serializable getSerializable(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getSerializable5458, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.io.Serializable>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getSerializable5458, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getIntegerArrayList5459;
		public global::java.util.ArrayList getIntegerArrayList(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getIntegerArrayList5459, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getIntegerArrayList5459, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStringArrayList5460;
		public global::java.util.ArrayList getStringArrayList(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getStringArrayList5460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.ArrayList>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getStringArrayList5460, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBooleanArray5461;
		public bool[] getBooleanArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getBooleanArray5461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBooleanArray5461, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getByteArray5462;
		public byte[] getByteArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getByteArray5462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByteArray5462, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShortArray5463;
		public short[] getShortArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getShortArray5463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShortArray5463, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCharArray5464;
		public char[] getCharArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getCharArray5464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharArray5464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLongArray5465;
		public long[] getLongArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getLongArray5465, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLongArray5465, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloatArray5466;
		public float[] getFloatArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getFloatArray5466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloatArray5466, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDoubleArray5467;
		public double[] getDoubleArray(java.lang.String arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.os.Bundle._getDoubleArray5467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDoubleArray5467, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Bundle5468;
		public Bundle(java.lang.ClassLoader arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle5468, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Bundle5469;
		public Bundle(int arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle5469, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Bundle5470;
		public Bundle(android.os.Bundle arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle5470, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _Bundle5471;
		public Bundle()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle5471, this);
		}
		internal static global::net.sf.jni4net.jni.FieldId _EMPTY5472;
		public static global::android.os.Bundle EMPTY
		{
			get
			{
				return default(global::android.os.Bundle);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR5473;
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
			global::android.os.Bundle._get5391 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.os.Bundle._toString5392 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Bundle._clone5393 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.os.Bundle._getBoolean5394 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::android.os.Bundle._getBoolean5395 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::android.os.Bundle._putBoolean5396 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::android.os.Bundle._getByte5397 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::android.os.Bundle._getByte5398 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;");
			global::android.os.Bundle._putByte5399 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putByte", "(Ljava/lang/String;B)V");
			global::android.os.Bundle._getShort5400 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;S)S");
			global::android.os.Bundle._getShort5401 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::android.os.Bundle._putShort5402 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putShort", "(Ljava/lang/String;S)V");
			global::android.os.Bundle._getChar5403 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;)C");
			global::android.os.Bundle._getChar5404 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;C)C");
			global::android.os.Bundle._putChar5405 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putChar", "(Ljava/lang/String;C)V");
			global::android.os.Bundle._getInt5406 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::android.os.Bundle._getInt5407 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::android.os.Bundle._putInt5408 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::android.os.Bundle._getLong5409 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::android.os.Bundle._getLong5410 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::android.os.Bundle._putLong5411 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::android.os.Bundle._getFloat5412 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::android.os.Bundle._getFloat5413 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::android.os.Bundle._putFloat5414 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::android.os.Bundle._getDouble5415 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::android.os.Bundle._getDouble5416 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::android.os.Bundle._putDouble5417 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::android.os.Bundle._clear5418 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "clear", "()V");
			global::android.os.Bundle._isEmpty5419 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "isEmpty", "()Z");
			global::android.os.Bundle._size5420 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "size", "()I");
			global::android.os.Bundle._putAll5421 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putAll", "(Landroid/os/Bundle;)V");
			global::android.os.Bundle._remove5422 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "remove", "(Ljava/lang/String;)V");
			global::android.os.Bundle._keySet5423 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "keySet", "()Ljava/util/Set;");
			global::android.os.Bundle._containsKey5424 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::android.os.Bundle._getBundle5425 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.os.Bundle._getString5426 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.os.Bundle._writeToParcel5427 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Bundle._describeContents5428 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "describeContents", "()I");
			global::android.os.Bundle._hasFileDescriptors5429 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "hasFileDescriptors", "()Z");
			global::android.os.Bundle._readFromParcel5430 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.os.Bundle._getStringArray5431 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::android.os.Bundle._getIntArray5432 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getIntArray", "(Ljava/lang/String;)[I");
			global::android.os.Bundle._setClassLoader5433 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "setClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::android.os.Bundle._putString5434 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.os.Bundle._putCharSequence5435 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V");
			global::android.os.Bundle._putParcelable5436 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V");
			global::android.os.Bundle._putParcelableArray5437 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V");
			global::android.os.Bundle._putParcelableArrayList5438 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putSparseParcelableArray5439 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V");
			global::android.os.Bundle._putIntegerArrayList5440 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putStringArrayList5441 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putSerializable5442 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V");
			global::android.os.Bundle._putBooleanArray5443 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBooleanArray", "(Ljava/lang/String;[Z)V");
			global::android.os.Bundle._putByteArray5444 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::android.os.Bundle._putShortArray5445 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putShortArray", "(Ljava/lang/String;[S)V");
			global::android.os.Bundle._putCharArray5446 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putCharArray", "(Ljava/lang/String;[C)V");
			global::android.os.Bundle._putIntArray5447 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putIntArray", "(Ljava/lang/String;[I)V");
			global::android.os.Bundle._putLongArray5448 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putLongArray", "(Ljava/lang/String;[J)V");
			global::android.os.Bundle._putFloatArray5449 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putFloatArray", "(Ljava/lang/String;[F)V");
			global::android.os.Bundle._putDoubleArray5450 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putDoubleArray", "(Ljava/lang/String;[D)V");
			global::android.os.Bundle._putStringArray5451 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.os.Bundle._putBundle5452 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.os.Bundle._getCharSequence5453 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.os.Bundle._getParcelable5454 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;");
			global::android.os.Bundle._getParcelableArray5455 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;");
			global::android.os.Bundle._getParcelableArrayList5456 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getSparseParcelableArray5457 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;");
			global::android.os.Bundle._getSerializable5458 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;");
			global::android.os.Bundle._getIntegerArrayList5459 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getStringArrayList5460 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getBooleanArray5461 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getBooleanArray", "(Ljava/lang/String;)[Z");
			global::android.os.Bundle._getByteArray5462 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getByteArray", "(Ljava/lang/String;)[B");
			global::android.os.Bundle._getShortArray5463 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getShortArray", "(Ljava/lang/String;)[S");
			global::android.os.Bundle._getCharArray5464 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getCharArray", "(Ljava/lang/String;)[C");
			global::android.os.Bundle._getLongArray5465 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getLongArray", "(Ljava/lang/String;)[J");
			global::android.os.Bundle._getFloatArray5466 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getFloatArray", "(Ljava/lang/String;)[F");
			global::android.os.Bundle._getDoubleArray5467 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "getDoubleArray", "(Ljava/lang/String;)[D");
			global::android.os.Bundle._Bundle5468 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::android.os.Bundle._Bundle5469 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(I)V");
			global::android.os.Bundle._Bundle5470 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::android.os.Bundle._Bundle5471 = @__env.GetMethodID(global::android.os.Bundle.staticClass, "<init>", "()V");
		}
	}
}
