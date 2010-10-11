namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Bundle : java.lang.Object, Parcelable, java.lang.Cloneable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Bundle()
		{
			InitJNI();
		}
		internal Bundle(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get6191;
		public global::java.lang.Object get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._get6191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._get6191, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toString6192;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._toString6192)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._toString6192)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone6193;
		public new global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._clone6193)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._clone6193)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean6194;
		public bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._getBoolean6194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBoolean6194, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean6195;
		public bool getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._getBoolean6195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBoolean6195, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean6196;
		public void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putBoolean6196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBoolean6196, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByte6197;
		public byte getByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::android.os.Bundle._getByte6197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByte6197, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte6198;
		public global::java.lang.Byte getByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getByte6198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByte6198, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _putByte6199;
		public void putByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putByte6199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putByte6199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort6200;
		public short getShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.os.Bundle._getShort6200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShort6200, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort6201;
		public short getShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.os.Bundle._getShort6201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShort6201, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putShort6202;
		public void putShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putShort6202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putShort6202, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChar6203;
		public char getChar(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.os.Bundle._getChar6203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getChar6203, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChar6204;
		public char getChar(java.lang.String arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.os.Bundle._getChar6204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getChar6204, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putChar6205;
		public void putChar(java.lang.String arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putChar6205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putChar6205, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt6206;
		public int getInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Bundle._getInt6206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getInt6206, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt6207;
		public int getInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Bundle._getInt6207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getInt6207, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt6208;
		public void putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putInt6208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putInt6208, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong6209;
		public long getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Bundle._getLong6209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLong6209, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong6210;
		public long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Bundle._getLong6210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLong6210, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong6211;
		public void putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putLong6211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putLong6211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat6212;
		public float getFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.os.Bundle._getFloat6212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloat6212, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat6213;
		public float getFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.os.Bundle._getFloat6213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloat6213, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat6214;
		public void putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putFloat6214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putFloat6214, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble6215;
		public double getDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.os.Bundle._getDouble6215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDouble6215, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble6216;
		public double getDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.os.Bundle._getDouble6216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDouble6216, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble6217;
		public void putDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putDouble6217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putDouble6217, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear6218;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._clear6218);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._clear6218);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty6219;
		public bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._isEmpty6219);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._isEmpty6219);
		}
		internal static global::MonoJavaBridge.MethodId _size6220;
		public int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Bundle._size6220);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._size6220);
		}
		internal static global::MonoJavaBridge.MethodId _putAll6221;
		public void putAll(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putAll6221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putAll6221, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove6222;
		public void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._remove6222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._remove6222, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keySet6223;
		public global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._keySet6223)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._keySet6223)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsKey6224;
		public bool containsKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._containsKey6224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._containsKey6224, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBundle6225;
		public global::android.os.Bundle getBundle(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getBundle6225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBundle6225, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getString6226;
		public global::java.lang.String getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getString6226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getString6226, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel6227;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._writeToParcel6227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._writeToParcel6227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents6228;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Bundle._describeContents6228);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._describeContents6228);
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors6229;
		public bool hasFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._hasFileDescriptors6229);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._hasFileDescriptors6229);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel6230;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._readFromParcel6230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._readFromParcel6230, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray6231;
		public global::java.lang.String[] getStringArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getStringArray6231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getStringArray6231, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArray6232;
		public int[] getIntArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getIntArray6232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getIntArray6232, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setClassLoader6233;
		public void setClassLoader(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._setClassLoader6233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._setClassLoader6233, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putString6234;
		public void putString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putString6234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putString6234, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequence6235;
		public void putCharSequence(java.lang.String arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putCharSequence6235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequence6235, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void putCharSequence(java.lang.String arg0, string arg1)
		{
			putCharSequence(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _putParcelable6236;
		public void putParcelable(java.lang.String arg0, android.os.Parcelable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putParcelable6236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelable6236, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArray6237;
		public void putParcelableArray(java.lang.String arg0, android.os.Parcelable[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putParcelableArray6237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelableArray6237, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArrayList6238;
		public void putParcelableArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putParcelableArrayList6238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelableArrayList6238, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putSparseParcelableArray6239;
		public void putSparseParcelableArray(java.lang.String arg0, android.util.SparseArray arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putSparseParcelableArray6239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putSparseParcelableArray6239, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putIntegerArrayList6240;
		public void putIntegerArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putIntegerArrayList6240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putIntegerArrayList6240, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putStringArrayList6241;
		public void putStringArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putStringArrayList6241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putStringArrayList6241, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArrayList6242;
		public void putCharSequenceArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putCharSequenceArrayList6242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequenceArrayList6242, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putSerializable6243;
		public void putSerializable(java.lang.String arg0, java.io.Serializable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putSerializable6243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putSerializable6243, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBooleanArray6244;
		public void putBooleanArray(java.lang.String arg0, bool[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putBooleanArray6244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBooleanArray6244, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray6245;
		public void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putByteArray6245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putByteArray6245, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putShortArray6246;
		public void putShortArray(java.lang.String arg0, short[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putShortArray6246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putShortArray6246, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharArray6247;
		public void putCharArray(java.lang.String arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putCharArray6247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharArray6247, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putIntArray6248;
		public void putIntArray(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putIntArray6248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putIntArray6248, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLongArray6249;
		public void putLongArray(java.lang.String arg0, long[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putLongArray6249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putLongArray6249, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloatArray6250;
		public void putFloatArray(java.lang.String arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putFloatArray6250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putFloatArray6250, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDoubleArray6251;
		public void putDoubleArray(java.lang.String arg0, double[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putDoubleArray6251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putDoubleArray6251, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putStringArray6252;
		public void putStringArray(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putStringArray6252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putStringArray6252, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArray6253;
		public void putCharSequenceArray(java.lang.String arg0, java.lang.CharSequence[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putCharSequenceArray6253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequenceArray6253, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBundle6254;
		public void putBundle(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putBundle6254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBundle6254, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequence6255;
		public global::java.lang.CharSequence getCharSequence(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getCharSequence6255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequence6255, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelable6256;
		public global::android.os.Parcelable getParcelable(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getParcelable6256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelable6256, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArray6257;
		public global::android.os.Parcelable[] getParcelableArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getParcelableArray6257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelableArray6257, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayList6258;
		public global::java.util.ArrayList getParcelableArrayList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getParcelableArrayList6258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelableArrayList6258, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getSparseParcelableArray6259;
		public global::android.util.SparseArray getSparseParcelableArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getSparseParcelableArray6259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getSparseParcelableArray6259, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
		}
		internal static global::MonoJavaBridge.MethodId _getSerializable6260;
		public global::java.io.Serializable getSerializable(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getSerializable6260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Serializable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getSerializable6260, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerArrayList6261;
		public global::java.util.ArrayList getIntegerArrayList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getIntegerArrayList6261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getIntegerArrayList6261, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayList6262;
		public global::java.util.ArrayList getStringArrayList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getStringArrayList6262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getStringArrayList6262, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayList6263;
		public global::java.util.ArrayList getCharSequenceArrayList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getCharSequenceArrayList6263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequenceArrayList6263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanArray6264;
		public bool[] getBooleanArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getBooleanArray6264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBooleanArray6264, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray6265;
		public byte[] getByteArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getByteArray6265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByteArray6265, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getShortArray6266;
		public short[] getShortArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getShortArray6266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as short[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShortArray6266, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharArray6267;
		public char[] getCharArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getCharArray6267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharArray6267, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getLongArray6268;
		public long[] getLongArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getLongArray6268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLongArray6268, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _getFloatArray6269;
		public float[] getFloatArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getFloatArray6269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloatArray6269, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleArray6270;
		public double[] getDoubleArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getDoubleArray6270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDoubleArray6270, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArray6271;
		public global::java.lang.CharSequence[] getCharSequenceArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getCharSequenceArray6271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequenceArray6271, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _Bundle6272;
		public Bundle(android.os.Bundle arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle6272, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle6273;
		public Bundle(java.lang.ClassLoader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle6273, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle6274;
		public Bundle(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle6274, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle6275;
		public Bundle()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle6275);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY6276;
		public static global::android.os.Bundle EMPTY
		{
			get
			{
				return default(global::android.os.Bundle);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR6277;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Bundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Bundle"));
			global::android.os.Bundle._get6191 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.os.Bundle._toString6192 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Bundle._clone6193 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.os.Bundle._getBoolean6194 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::android.os.Bundle._getBoolean6195 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::android.os.Bundle._putBoolean6196 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::android.os.Bundle._getByte6197 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::android.os.Bundle._getByte6198 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;");
			global::android.os.Bundle._putByte6199 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putByte", "(Ljava/lang/String;B)V");
			global::android.os.Bundle._getShort6200 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;S)S");
			global::android.os.Bundle._getShort6201 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::android.os.Bundle._putShort6202 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putShort", "(Ljava/lang/String;S)V");
			global::android.os.Bundle._getChar6203 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;)C");
			global::android.os.Bundle._getChar6204 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;C)C");
			global::android.os.Bundle._putChar6205 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putChar", "(Ljava/lang/String;C)V");
			global::android.os.Bundle._getInt6206 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::android.os.Bundle._getInt6207 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::android.os.Bundle._putInt6208 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::android.os.Bundle._getLong6209 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::android.os.Bundle._getLong6210 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::android.os.Bundle._putLong6211 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::android.os.Bundle._getFloat6212 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::android.os.Bundle._getFloat6213 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::android.os.Bundle._putFloat6214 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::android.os.Bundle._getDouble6215 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::android.os.Bundle._getDouble6216 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::android.os.Bundle._putDouble6217 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::android.os.Bundle._clear6218 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "clear", "()V");
			global::android.os.Bundle._isEmpty6219 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "isEmpty", "()Z");
			global::android.os.Bundle._size6220 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "size", "()I");
			global::android.os.Bundle._putAll6221 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putAll", "(Landroid/os/Bundle;)V");
			global::android.os.Bundle._remove6222 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "remove", "(Ljava/lang/String;)V");
			global::android.os.Bundle._keySet6223 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "keySet", "()Ljava/util/Set;");
			global::android.os.Bundle._containsKey6224 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::android.os.Bundle._getBundle6225 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.os.Bundle._getString6226 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.os.Bundle._writeToParcel6227 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Bundle._describeContents6228 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "describeContents", "()I");
			global::android.os.Bundle._hasFileDescriptors6229 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "hasFileDescriptors", "()Z");
			global::android.os.Bundle._readFromParcel6230 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.os.Bundle._getStringArray6231 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::android.os.Bundle._getIntArray6232 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getIntArray", "(Ljava/lang/String;)[I");
			global::android.os.Bundle._setClassLoader6233 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "setClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::android.os.Bundle._putString6234 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.os.Bundle._putCharSequence6235 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V");
			global::android.os.Bundle._putParcelable6236 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V");
			global::android.os.Bundle._putParcelableArray6237 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V");
			global::android.os.Bundle._putParcelableArrayList6238 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putSparseParcelableArray6239 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V");
			global::android.os.Bundle._putIntegerArrayList6240 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putStringArrayList6241 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putCharSequenceArrayList6242 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putCharSequenceArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putSerializable6243 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V");
			global::android.os.Bundle._putBooleanArray6244 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putBooleanArray", "(Ljava/lang/String;[Z)V");
			global::android.os.Bundle._putByteArray6245 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::android.os.Bundle._putShortArray6246 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putShortArray", "(Ljava/lang/String;[S)V");
			global::android.os.Bundle._putCharArray6247 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putCharArray", "(Ljava/lang/String;[C)V");
			global::android.os.Bundle._putIntArray6248 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putIntArray", "(Ljava/lang/String;[I)V");
			global::android.os.Bundle._putLongArray6249 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putLongArray", "(Ljava/lang/String;[J)V");
			global::android.os.Bundle._putFloatArray6250 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putFloatArray", "(Ljava/lang/String;[F)V");
			global::android.os.Bundle._putDoubleArray6251 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putDoubleArray", "(Ljava/lang/String;[D)V");
			global::android.os.Bundle._putStringArray6252 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.os.Bundle._putCharSequenceArray6253 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putCharSequenceArray", "(Ljava/lang/String;[Ljava/lang/CharSequence;)V");
			global::android.os.Bundle._putBundle6254 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.os.Bundle._getCharSequence6255 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.os.Bundle._getParcelable6256 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;");
			global::android.os.Bundle._getParcelableArray6257 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;");
			global::android.os.Bundle._getParcelableArrayList6258 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getSparseParcelableArray6259 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;");
			global::android.os.Bundle._getSerializable6260 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;");
			global::android.os.Bundle._getIntegerArrayList6261 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getStringArrayList6262 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getCharSequenceArrayList6263 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getCharSequenceArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getBooleanArray6264 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getBooleanArray", "(Ljava/lang/String;)[Z");
			global::android.os.Bundle._getByteArray6265 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getByteArray", "(Ljava/lang/String;)[B");
			global::android.os.Bundle._getShortArray6266 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getShortArray", "(Ljava/lang/String;)[S");
			global::android.os.Bundle._getCharArray6267 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getCharArray", "(Ljava/lang/String;)[C");
			global::android.os.Bundle._getLongArray6268 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getLongArray", "(Ljava/lang/String;)[J");
			global::android.os.Bundle._getFloatArray6269 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getFloatArray", "(Ljava/lang/String;)[F");
			global::android.os.Bundle._getDoubleArray6270 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getDoubleArray", "(Ljava/lang/String;)[D");
			global::android.os.Bundle._getCharSequenceArray6271 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getCharSequenceArray", "(Ljava/lang/String;)[Ljava/lang/CharSequence;");
			global::android.os.Bundle._Bundle6272 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::android.os.Bundle._Bundle6273 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::android.os.Bundle._Bundle6274 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(I)V");
			global::android.os.Bundle._Bundle6275 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "()V");
		}
	}
}
