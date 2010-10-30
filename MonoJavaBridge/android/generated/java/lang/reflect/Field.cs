namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Field : java.lang.reflect.AccessibleObject, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _get21050;
		public global::java.lang.Object get(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._get21050.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._get21050 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._get21050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals21051;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._equals21051.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._equals21051 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "equals", "(Ljava/lang/Object;)Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._equals21051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString21052;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._toString21052.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._toString21052 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "toString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._toString21052)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode21053;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._hashCode21053.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._hashCode21053 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "hashCode", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._hashCode21053);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers21054;
		public int getModifiers()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getModifiers21054.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getModifiers21054 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getModifiers", "()I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getModifiers21054);
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean21055;
		public bool getBoolean(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getBoolean21055.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getBoolean21055 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getBoolean", "(Ljava/lang/Object;)Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getBoolean21055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte21056;
		public byte getByte(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getByte21056.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getByte21056 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getByte", "(Ljava/lang/Object;)B");
			return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getByte21056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort21057;
		public short getShort(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getShort21057.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getShort21057 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getShort", "(Ljava/lang/Object;)S");
			return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getShort21057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChar21058;
		public char getChar(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getChar21058.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getChar21058 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getChar", "(Ljava/lang/Object;)C");
			return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getChar21058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt21059;
		public int getInt(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getInt21059.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getInt21059 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getInt", "(Ljava/lang/Object;)I");
			return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getInt21059, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong21060;
		public long getLong(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getLong21060.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getLong21060 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getLong", "(Ljava/lang/Object;)J");
			return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getLong21060, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat21061;
		public float getFloat(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getFloat21061.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getFloat21061 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getFloat", "(Ljava/lang/Object;)F");
			return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getFloat21061, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble21062;
		public double getDouble(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getDouble21062.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getDouble21062 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDouble", "(Ljava/lang/Object;)D");
			return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDouble21062, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName21063;
		public global::java.lang.String getName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getName21063.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getName21063 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getName", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getName21063)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic21064;
		public bool isSynthetic()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._isSynthetic21064.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._isSynthetic21064 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "isSynthetic", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._isSynthetic21064);
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass21065;
		public global::java.lang.Class getDeclaringClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getDeclaringClass21065.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getDeclaringClass21065 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDeclaringClass21065)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation21066;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getAnnotation21066.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getAnnotation21066 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getAnnotation21066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations21067;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getDeclaredAnnotations21067.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getDeclaredAnnotations21067 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDeclaredAnnotations21067)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _isEnumConstant21068;
		public bool isEnumConstant()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._isEnumConstant21068.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._isEnumConstant21068 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "isEnumConstant", "()Z");
			return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._isEnumConstant21068);
		}
		public new global::java.lang.Class Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType21069;
		public global::java.lang.Class getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getType21069.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getType21069 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getType", "()Ljava/lang/Class;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getType21069)) as java.lang.Class;
		}
		public new global::java.lang.reflect.Type GenericType
		{
			get
			{
				return getGenericType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericType21070;
		public global::java.lang.reflect.Type getGenericType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._getGenericType21070.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._getGenericType21070 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getGenericType", "()Ljava/lang/reflect/Type;");
			return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getGenericType21070)) as java.lang.reflect.Type;
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString21071;
		public global::java.lang.String toGenericString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._toGenericString21071.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._toGenericString21071 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "toGenericString", "()Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._toGenericString21071)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set21072;
		public void set(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._set21072.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._set21072 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._set21072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean21073;
		public void setBoolean(java.lang.Object arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._setBoolean21073.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._setBoolean21073 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setBoolean", "(Ljava/lang/Object;Z)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setBoolean21073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte21074;
		public void setByte(java.lang.Object arg0, byte arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._setByte21074.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._setByte21074 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setByte", "(Ljava/lang/Object;B)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setByte21074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChar21075;
		public void setChar(java.lang.Object arg0, char arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._setChar21075.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._setChar21075 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setChar", "(Ljava/lang/Object;C)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setChar21075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort21076;
		public void setShort(java.lang.Object arg0, short arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._setShort21076.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._setShort21076 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setShort", "(Ljava/lang/Object;S)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setShort21076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt21077;
		public void setInt(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._setInt21077.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._setInt21077 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setInt", "(Ljava/lang/Object;I)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setInt21077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong21078;
		public void setLong(java.lang.Object arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._setLong21078.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._setLong21078 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setLong", "(Ljava/lang/Object;J)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setLong21078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat21079;
		public void setFloat(java.lang.Object arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._setFloat21079.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._setFloat21079 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setFloat", "(Ljava/lang/Object;F)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setFloat21079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble21080;
		public void setDouble(java.lang.Object arg0, double arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Field._setDouble21080.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Field._setDouble21080 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setDouble", "(Ljava/lang/Object;D)V");
			@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setDouble21080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Field()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Field"));
		}
		internal static void InitJNI()
		{
		}
	}
}
