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
		internal static global::MonoJavaBridge.MethodId _get9553;
		public global::java.lang.Object get(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._get9553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._get9553, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _toString9554;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._toString9554)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._toString9554)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _clone9555;
		public global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._clone9555)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._clone9555)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean9556;
		public bool getBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._getBoolean9556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBoolean9556, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean9557;
		public bool getBoolean(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._getBoolean9557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBoolean9557, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putBoolean9558;
		public void putBoolean(java.lang.String arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putBoolean9558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBoolean9558, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getByte9559;
		public byte getByte(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::android.os.Bundle._getByte9559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByte9559, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte9560;
		public global::java.lang.Byte getByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getByte9560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByte9560, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Byte;
		}
		internal static global::MonoJavaBridge.MethodId _putByte9561;
		public void putByte(java.lang.String arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putByte9561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putByte9561, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort9562;
		public short getShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.os.Bundle._getShort9562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShort9562, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getShort9563;
		public short getShort(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::android.os.Bundle._getShort9563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShort9563, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putShort9564;
		public void putShort(java.lang.String arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putShort9564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putShort9564, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getChar9565;
		public char getChar(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.os.Bundle._getChar9565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getChar9565, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChar9566;
		public char getChar(java.lang.String arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::android.os.Bundle._getChar9566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getChar9566, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putChar9567;
		public void putChar(java.lang.String arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putChar9567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putChar9567, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt9568;
		public int getInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Bundle._getInt9568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getInt9568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getInt9569;
		public int getInt(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Bundle._getInt9569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getInt9569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putInt9570;
		public void putInt(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putInt9570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putInt9570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getLong9571;
		public long getLong(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Bundle._getLong9571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLong9571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong9572;
		public long getLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.os.Bundle._getLong9572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLong9572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLong9573;
		public void putLong(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putLong9573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putLong9573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat9574;
		public float getFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.os.Bundle._getFloat9574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloat9574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat9575;
		public float getFloat(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::android.os.Bundle._getFloat9575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloat9575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putFloat9576;
		public void putFloat(java.lang.String arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putFloat9576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putFloat9576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble9577;
		public double getDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.os.Bundle._getDouble9577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDouble9577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble9578;
		public double getDouble(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::android.os.Bundle._getDouble9578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDouble9578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putDouble9579;
		public void putDouble(java.lang.String arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putDouble9579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putDouble9579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _clear9580;
		public void clear() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._clear9580);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._clear9580);
		}
		internal static global::MonoJavaBridge.MethodId _isEmpty9581;
		public bool isEmpty() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._isEmpty9581);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._isEmpty9581);
		}
		internal static global::MonoJavaBridge.MethodId _size9582;
		public int size() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Bundle._size9582);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._size9582);
		}
		internal static global::MonoJavaBridge.MethodId _putAll9583;
		public void putAll(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putAll9583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putAll9583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _remove9584;
		public void remove(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._remove9584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._remove9584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _keySet9585;
		public global::java.util.Set keySet() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._keySet9585)) as java.util.Set;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Set>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._keySet9585)) as java.util.Set;
		}
		internal static global::MonoJavaBridge.MethodId _containsKey9586;
		public bool containsKey(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._containsKey9586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._containsKey9586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getBundle9587;
		public global::android.os.Bundle getBundle(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getBundle9587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBundle9587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Bundle;
		}
		internal static global::MonoJavaBridge.MethodId _getString9588;
		public global::java.lang.String getString(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getString9588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getString9588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel9589;
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._writeToParcel9589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._writeToParcel9589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents9590;
		public int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.os.Bundle._describeContents9590);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._describeContents9590);
		}
		internal static global::MonoJavaBridge.MethodId _hasFileDescriptors9591;
		public bool hasFileDescriptors() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.Bundle._hasFileDescriptors9591);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._hasFileDescriptors9591);
		}
		internal static global::MonoJavaBridge.MethodId _readFromParcel9592;
		public void readFromParcel(android.os.Parcel arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._readFromParcel9592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._readFromParcel9592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStringArray9593;
		public global::java.lang.String[] getStringArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getStringArray9593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getStringArray9593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String[];
		}
		internal static global::MonoJavaBridge.MethodId _getIntArray9594;
		public int[] getIntArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getIntArray9594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getIntArray9594, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _setClassLoader9595;
		public void setClassLoader(java.lang.ClassLoader arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._setClassLoader9595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._setClassLoader9595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _putString9596;
		public void putString(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putString9596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putString9596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequence9597;
		public void putCharSequence(java.lang.String arg0, java.lang.CharSequence arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putCharSequence9597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequence9597, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public void putCharSequence(java.lang.String arg0, string arg1)
		{
			putCharSequence(arg0, (global::java.lang.CharSequence)(global::java.lang.String)arg1);
		}
		internal static global::MonoJavaBridge.MethodId _putParcelable9598;
		public void putParcelable(java.lang.String arg0, android.os.Parcelable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putParcelable9598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelable9598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArray9599;
		public void putParcelableArray(java.lang.String arg0, android.os.Parcelable[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putParcelableArray9599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelableArray9599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putParcelableArrayList9600;
		public void putParcelableArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putParcelableArrayList9600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putParcelableArrayList9600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putSparseParcelableArray9601;
		public void putSparseParcelableArray(java.lang.String arg0, android.util.SparseArray arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putSparseParcelableArray9601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putSparseParcelableArray9601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putIntegerArrayList9602;
		public void putIntegerArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putIntegerArrayList9602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putIntegerArrayList9602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putStringArrayList9603;
		public void putStringArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putStringArrayList9603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putStringArrayList9603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArrayList9604;
		public void putCharSequenceArrayList(java.lang.String arg0, java.util.ArrayList arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putCharSequenceArrayList9604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequenceArrayList9604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putSerializable9605;
		public void putSerializable(java.lang.String arg0, java.io.Serializable arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putSerializable9605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putSerializable9605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBooleanArray9606;
		public void putBooleanArray(java.lang.String arg0, bool[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putBooleanArray9606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBooleanArray9606, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putByteArray9607;
		public void putByteArray(java.lang.String arg0, byte[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putByteArray9607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putByteArray9607, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putShortArray9608;
		public void putShortArray(java.lang.String arg0, short[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putShortArray9608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putShortArray9608, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharArray9609;
		public void putCharArray(java.lang.String arg0, char[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putCharArray9609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharArray9609, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putIntArray9610;
		public void putIntArray(java.lang.String arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putIntArray9610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putIntArray9610, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putLongArray9611;
		public void putLongArray(java.lang.String arg0, long[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putLongArray9611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putLongArray9611, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putFloatArray9612;
		public void putFloatArray(java.lang.String arg0, float[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putFloatArray9612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putFloatArray9612, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putDoubleArray9613;
		public void putDoubleArray(java.lang.String arg0, double[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putDoubleArray9613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putDoubleArray9613, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putStringArray9614;
		public void putStringArray(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putStringArray9614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putStringArray9614, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putCharSequenceArray9615;
		public void putCharSequenceArray(java.lang.String arg0, java.lang.CharSequence[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putCharSequenceArray9615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putCharSequenceArray9615, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _putBundle9616;
		public void putBundle(java.lang.String arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.Bundle._putBundle9616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._putBundle9616, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequence9617;
		public global::java.lang.CharSequence getCharSequence(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getCharSequence9617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequence9617, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelable9618;
		public global::android.os.Parcelable getParcelable(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getParcelable9618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelable9618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable;
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArray9619;
		public global::android.os.Parcelable[] getParcelableArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getParcelableArray9619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.Parcelable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelableArray9619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Parcelable[];
		}
		internal static global::MonoJavaBridge.MethodId _getParcelableArrayList9620;
		public global::java.util.ArrayList getParcelableArrayList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getParcelableArrayList9620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getParcelableArrayList9620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getSparseParcelableArray9621;
		public global::android.util.SparseArray getSparseParcelableArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getSparseParcelableArray9621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getSparseParcelableArray9621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.util.SparseArray;
		}
		internal static global::MonoJavaBridge.MethodId _getSerializable9622;
		public global::java.io.Serializable getSerializable(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getSerializable9622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Serializable;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.io.Serializable>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getSerializable9622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.io.Serializable;
		}
		internal static global::MonoJavaBridge.MethodId _getIntegerArrayList9623;
		public global::java.util.ArrayList getIntegerArrayList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getIntegerArrayList9623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getIntegerArrayList9623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getStringArrayList9624;
		public global::java.util.ArrayList getStringArrayList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getStringArrayList9624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getStringArrayList9624, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArrayList9625;
		public global::java.util.ArrayList getCharSequenceArrayList(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getCharSequenceArrayList9625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequenceArrayList9625, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.util.ArrayList;
		}
		internal static global::MonoJavaBridge.MethodId _getBooleanArray9626;
		public bool[] getBooleanArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getBooleanArray9626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<bool>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getBooleanArray9626, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as bool[];
		}
		internal static global::MonoJavaBridge.MethodId _getByteArray9627;
		public byte[] getByteArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getByteArray9627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<byte>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getByteArray9627, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as byte[];
		}
		internal static global::MonoJavaBridge.MethodId _getShortArray9628;
		public short[] getShortArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getShortArray9628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as short[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<short>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getShortArray9628, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as short[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharArray9629;
		public char[] getCharArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getCharArray9629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<char>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharArray9629, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as char[];
		}
		internal static global::MonoJavaBridge.MethodId _getLongArray9630;
		public long[] getLongArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getLongArray9630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as long[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<long>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getLongArray9630, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as long[];
		}
		internal static global::MonoJavaBridge.MethodId _getFloatArray9631;
		public float[] getFloatArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getFloatArray9631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as float[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getFloatArray9631, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as float[];
		}
		internal static global::MonoJavaBridge.MethodId _getDoubleArray9632;
		public double[] getDoubleArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getDoubleArray9632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as double[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<double>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getDoubleArray9632, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as double[];
		}
		internal static global::MonoJavaBridge.MethodId _getCharSequenceArray9633;
		public global::java.lang.CharSequence[] getCharSequenceArray(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.Bundle._getCharSequenceArray9633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.CharSequence>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.Bundle.staticClass, global::android.os.Bundle._getCharSequenceArray9633, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.CharSequence[];
		}
		internal static global::MonoJavaBridge.MethodId _Bundle9634;
		public Bundle(android.os.Bundle arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle9634, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle9635;
		public Bundle(java.lang.ClassLoader arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle9635, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle9636;
		public Bundle(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle9636, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _Bundle9637;
		public Bundle()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.Bundle.staticClass, global::android.os.Bundle._Bundle9637);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _EMPTY9638;
		public static global::android.os.Bundle EMPTY
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetStaticObjectField(global::android.os.Bundle.staticClass, _EMPTY9638)) as android.os.Bundle;
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR9639;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.Bundle.staticClass, _CREATOR9639)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.Bundle.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/Bundle"));
			global::android.os.Bundle._get9553 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "get", "(Ljava/lang/String;)Ljava/lang/Object;");
			global::android.os.Bundle._toString9554 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.Bundle._clone9555 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.os.Bundle._getBoolean9556 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;Z)Z");
			global::android.os.Bundle._getBoolean9557 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			global::android.os.Bundle._putBoolean9558 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putBoolean", "(Ljava/lang/String;Z)V");
			global::android.os.Bundle._getByte9559 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;)B");
			global::android.os.Bundle._getByte9560 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getByte", "(Ljava/lang/String;B)Ljava/lang/Byte;");
			global::android.os.Bundle._putByte9561 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putByte", "(Ljava/lang/String;B)V");
			global::android.os.Bundle._getShort9562 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;S)S");
			global::android.os.Bundle._getShort9563 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getShort", "(Ljava/lang/String;)S");
			global::android.os.Bundle._putShort9564 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putShort", "(Ljava/lang/String;S)V");
			global::android.os.Bundle._getChar9565 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;)C");
			global::android.os.Bundle._getChar9566 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getChar", "(Ljava/lang/String;C)C");
			global::android.os.Bundle._putChar9567 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putChar", "(Ljava/lang/String;C)V");
			global::android.os.Bundle._getInt9568 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;I)I");
			global::android.os.Bundle._getInt9569 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getInt", "(Ljava/lang/String;)I");
			global::android.os.Bundle._putInt9570 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putInt", "(Ljava/lang/String;I)V");
			global::android.os.Bundle._getLong9571 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;)J");
			global::android.os.Bundle._getLong9572 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getLong", "(Ljava/lang/String;J)J");
			global::android.os.Bundle._putLong9573 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putLong", "(Ljava/lang/String;J)V");
			global::android.os.Bundle._getFloat9574 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;F)F");
			global::android.os.Bundle._getFloat9575 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getFloat", "(Ljava/lang/String;)F");
			global::android.os.Bundle._putFloat9576 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putFloat", "(Ljava/lang/String;F)V");
			global::android.os.Bundle._getDouble9577 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;D)D");
			global::android.os.Bundle._getDouble9578 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getDouble", "(Ljava/lang/String;)D");
			global::android.os.Bundle._putDouble9579 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putDouble", "(Ljava/lang/String;D)V");
			global::android.os.Bundle._clear9580 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "clear", "()V");
			global::android.os.Bundle._isEmpty9581 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "isEmpty", "()Z");
			global::android.os.Bundle._size9582 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "size", "()I");
			global::android.os.Bundle._putAll9583 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putAll", "(Landroid/os/Bundle;)V");
			global::android.os.Bundle._remove9584 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "remove", "(Ljava/lang/String;)V");
			global::android.os.Bundle._keySet9585 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "keySet", "()Ljava/util/Set;");
			global::android.os.Bundle._containsKey9586 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "containsKey", "(Ljava/lang/String;)Z");
			global::android.os.Bundle._getBundle9587 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getBundle", "(Ljava/lang/String;)Landroid/os/Bundle;");
			global::android.os.Bundle._getString9588 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getString", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.os.Bundle._writeToParcel9589 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.Bundle._describeContents9590 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "describeContents", "()I");
			global::android.os.Bundle._hasFileDescriptors9591 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "hasFileDescriptors", "()Z");
			global::android.os.Bundle._readFromParcel9592 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "readFromParcel", "(Landroid/os/Parcel;)V");
			global::android.os.Bundle._getStringArray9593 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getStringArray", "(Ljava/lang/String;)[Ljava/lang/String;");
			global::android.os.Bundle._getIntArray9594 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getIntArray", "(Ljava/lang/String;)[I");
			global::android.os.Bundle._setClassLoader9595 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "setClassLoader", "(Ljava/lang/ClassLoader;)V");
			global::android.os.Bundle._putString9596 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putString", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.os.Bundle._putCharSequence9597 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putCharSequence", "(Ljava/lang/String;Ljava/lang/CharSequence;)V");
			global::android.os.Bundle._putParcelable9598 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putParcelable", "(Ljava/lang/String;Landroid/os/Parcelable;)V");
			global::android.os.Bundle._putParcelableArray9599 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putParcelableArray", "(Ljava/lang/String;[Landroid/os/Parcelable;)V");
			global::android.os.Bundle._putParcelableArrayList9600 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putParcelableArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putSparseParcelableArray9601 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putSparseParcelableArray", "(Ljava/lang/String;Landroid/util/SparseArray;)V");
			global::android.os.Bundle._putIntegerArrayList9602 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putIntegerArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putStringArrayList9603 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putStringArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putCharSequenceArrayList9604 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putCharSequenceArrayList", "(Ljava/lang/String;Ljava/util/ArrayList;)V");
			global::android.os.Bundle._putSerializable9605 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putSerializable", "(Ljava/lang/String;Ljava/io/Serializable;)V");
			global::android.os.Bundle._putBooleanArray9606 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putBooleanArray", "(Ljava/lang/String;[Z)V");
			global::android.os.Bundle._putByteArray9607 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putByteArray", "(Ljava/lang/String;[B)V");
			global::android.os.Bundle._putShortArray9608 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putShortArray", "(Ljava/lang/String;[S)V");
			global::android.os.Bundle._putCharArray9609 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putCharArray", "(Ljava/lang/String;[C)V");
			global::android.os.Bundle._putIntArray9610 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putIntArray", "(Ljava/lang/String;[I)V");
			global::android.os.Bundle._putLongArray9611 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putLongArray", "(Ljava/lang/String;[J)V");
			global::android.os.Bundle._putFloatArray9612 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putFloatArray", "(Ljava/lang/String;[F)V");
			global::android.os.Bundle._putDoubleArray9613 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putDoubleArray", "(Ljava/lang/String;[D)V");
			global::android.os.Bundle._putStringArray9614 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putStringArray", "(Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.os.Bundle._putCharSequenceArray9615 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putCharSequenceArray", "(Ljava/lang/String;[Ljava/lang/CharSequence;)V");
			global::android.os.Bundle._putBundle9616 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "putBundle", "(Ljava/lang/String;Landroid/os/Bundle;)V");
			global::android.os.Bundle._getCharSequence9617 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getCharSequence", "(Ljava/lang/String;)Ljava/lang/CharSequence;");
			global::android.os.Bundle._getParcelable9618 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getParcelable", "(Ljava/lang/String;)Landroid/os/Parcelable;");
			global::android.os.Bundle._getParcelableArray9619 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getParcelableArray", "(Ljava/lang/String;)[Landroid/os/Parcelable;");
			global::android.os.Bundle._getParcelableArrayList9620 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getParcelableArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getSparseParcelableArray9621 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getSparseParcelableArray", "(Ljava/lang/String;)Landroid/util/SparseArray;");
			global::android.os.Bundle._getSerializable9622 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getSerializable", "(Ljava/lang/String;)Ljava/io/Serializable;");
			global::android.os.Bundle._getIntegerArrayList9623 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getIntegerArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getStringArrayList9624 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getStringArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getCharSequenceArrayList9625 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getCharSequenceArrayList", "(Ljava/lang/String;)Ljava/util/ArrayList;");
			global::android.os.Bundle._getBooleanArray9626 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getBooleanArray", "(Ljava/lang/String;)[Z");
			global::android.os.Bundle._getByteArray9627 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getByteArray", "(Ljava/lang/String;)[B");
			global::android.os.Bundle._getShortArray9628 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getShortArray", "(Ljava/lang/String;)[S");
			global::android.os.Bundle._getCharArray9629 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getCharArray", "(Ljava/lang/String;)[C");
			global::android.os.Bundle._getLongArray9630 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getLongArray", "(Ljava/lang/String;)[J");
			global::android.os.Bundle._getFloatArray9631 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getFloatArray", "(Ljava/lang/String;)[F");
			global::android.os.Bundle._getDoubleArray9632 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getDoubleArray", "(Ljava/lang/String;)[D");
			global::android.os.Bundle._getCharSequenceArray9633 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "getCharSequenceArray", "(Ljava/lang/String;)[Ljava/lang/CharSequence;");
			global::android.os.Bundle._Bundle9634 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(Landroid/os/Bundle;)V");
			global::android.os.Bundle._Bundle9635 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(Ljava/lang/ClassLoader;)V");
			global::android.os.Bundle._Bundle9636 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "(I)V");
			global::android.os.Bundle._Bundle9637 = @__env.GetMethodIDNoThrow(global::android.os.Bundle.staticClass, "<init>", "()V");
			global::android.os.Bundle._EMPTY9638 = @__env.GetStaticFieldIDNoThrow(global::android.os.Bundle.staticClass, "EMPTY", "Landroid/os/Bundle;");
			global::android.os.Bundle._CREATOR9639 = @__env.GetStaticFieldIDNoThrow(global::android.os.Bundle.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
