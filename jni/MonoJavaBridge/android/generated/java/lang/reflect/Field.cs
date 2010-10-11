namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Field : java.lang.reflect.AccessibleObject, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Field()
		{
			InitJNI();
		}
		internal Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get13454;
		public global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._get13454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._get13454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals13455;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._equals13455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._equals13455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString13456;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._toString13456)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._toString13456)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode13457;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._hashCode13457);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._hashCode13457);
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers13458;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._getModifiers13458);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getModifiers13458);
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean13459;
		public bool getBoolean(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._getBoolean13459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getBoolean13459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte13460;
		public byte getByte(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.reflect.Field._getByte13460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getByte13460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort13461;
		public short getShort(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.reflect.Field._getShort13461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getShort13461, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChar13462;
		public char getChar(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.reflect.Field._getChar13462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getChar13462, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt13463;
		public int getInt(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._getInt13463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getInt13463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong13464;
		public long getLong(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.reflect.Field._getLong13464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getLong13464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat13465;
		public float getFloat(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.reflect.Field._getFloat13465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getFloat13465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble13466;
		public double getDouble(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.reflect.Field._getDouble13466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDouble13466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getName13467;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getName13467)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getName13467)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic13468;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._isSynthetic13468);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._isSynthetic13468);
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass13469;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getDeclaringClass13469)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDeclaringClass13469)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation13470;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getAnnotation13470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getAnnotation13470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations13471;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getDeclaredAnnotations13471)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDeclaredAnnotations13471)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _isEnumConstant13472;
		public bool isEnumConstant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._isEnumConstant13472);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._isEnumConstant13472);
		}
		internal static global::MonoJavaBridge.MethodId _getType13473;
		public global::java.lang.Class getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getType13473)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getType13473)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getGenericType13474;
		public global::java.lang.reflect.Type getGenericType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getGenericType13474)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getGenericType13474)) as java.lang.reflect.Type;
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString13475;
		public global::java.lang.String toGenericString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._toGenericString13475)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._toGenericString13475)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set13476;
		public void set(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._set13476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._set13476, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean13477;
		public void setBoolean(java.lang.Object arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setBoolean13477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setBoolean13477, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte13478;
		public void setByte(java.lang.Object arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setByte13478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setByte13478, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChar13479;
		public void setChar(java.lang.Object arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setChar13479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setChar13479, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort13480;
		public void setShort(java.lang.Object arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setShort13480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setShort13480, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt13481;
		public void setInt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setInt13481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setInt13481, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong13482;
		public void setLong(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setLong13482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setLong13482, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat13483;
		public void setFloat(java.lang.Object arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setFloat13483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setFloat13483, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble13484;
		public void setDouble(java.lang.Object arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setDouble13484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setDouble13484, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Field"));
			global::java.lang.reflect.Field._get13454 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.reflect.Field._equals13455 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Field._toString13456 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._hashCode13457 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "hashCode", "()I");
			global::java.lang.reflect.Field._getModifiers13458 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Field._getBoolean13459 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getBoolean", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Field._getByte13460 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getByte", "(Ljava/lang/Object;)B");
			global::java.lang.reflect.Field._getShort13461 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getShort", "(Ljava/lang/Object;)S");
			global::java.lang.reflect.Field._getChar13462 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getChar", "(Ljava/lang/Object;)C");
			global::java.lang.reflect.Field._getInt13463 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getInt", "(Ljava/lang/Object;)I");
			global::java.lang.reflect.Field._getLong13464 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getLong", "(Ljava/lang/Object;)J");
			global::java.lang.reflect.Field._getFloat13465 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getFloat", "(Ljava/lang/Object;)F");
			global::java.lang.reflect.Field._getDouble13466 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDouble", "(Ljava/lang/Object;)D");
			global::java.lang.reflect.Field._getName13467 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._isSynthetic13468 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Field._getDeclaringClass13469 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.reflect.Field._getAnnotation13470 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Field._getDeclaredAnnotations13471 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Field._isEnumConstant13472 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "isEnumConstant", "()Z");
			global::java.lang.reflect.Field._getType13473 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getType", "()Ljava/lang/Class;");
			global::java.lang.reflect.Field._getGenericType13474 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getGenericType", "()Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Field._toGenericString13475 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "toGenericString", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._set13476 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.lang.reflect.Field._setBoolean13477 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setBoolean", "(Ljava/lang/Object;Z)V");
			global::java.lang.reflect.Field._setByte13478 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setByte", "(Ljava/lang/Object;B)V");
			global::java.lang.reflect.Field._setChar13479 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setChar", "(Ljava/lang/Object;C)V");
			global::java.lang.reflect.Field._setShort13480 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setShort", "(Ljava/lang/Object;S)V");
			global::java.lang.reflect.Field._setInt13481 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setInt", "(Ljava/lang/Object;I)V");
			global::java.lang.reflect.Field._setLong13482 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setLong", "(Ljava/lang/Object;J)V");
			global::java.lang.reflect.Field._setFloat13483 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setFloat", "(Ljava/lang/Object;F)V");
			global::java.lang.reflect.Field._setDouble13484 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setDouble", "(Ljava/lang/Object;D)V");
		}
	}
}
