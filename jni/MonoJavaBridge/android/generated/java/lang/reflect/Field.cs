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
		internal static global::MonoJavaBridge.MethodId _get15409;
		public global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._get15409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._get15409, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals15410;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._equals15410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._equals15410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString15411;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._toString15411)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._toString15411)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode15412;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._hashCode15412);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._hashCode15412);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers15413;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._getModifiers15413);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getModifiers15413);
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean15414;
		public bool getBoolean(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._getBoolean15414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getBoolean15414, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte15415;
		public byte getByte(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.reflect.Field._getByte15415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getByte15415, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort15416;
		public short getShort(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.reflect.Field._getShort15416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getShort15416, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChar15417;
		public char getChar(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.reflect.Field._getChar15417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getChar15417, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt15418;
		public int getInt(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._getInt15418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getInt15418, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong15419;
		public long getLong(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.reflect.Field._getLong15419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getLong15419, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat15420;
		public float getFloat(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.reflect.Field._getFloat15420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getFloat15420, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble15421;
		public double getDouble(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.reflect.Field._getDouble15421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDouble15421, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName15422;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getName15422)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getName15422)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic15423;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._isSynthetic15423);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._isSynthetic15423);
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass15424;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getDeclaringClass15424)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDeclaringClass15424)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation15425;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getAnnotation15425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getAnnotation15425, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations15426;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getDeclaredAnnotations15426)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDeclaredAnnotations15426)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _isEnumConstant15427;
		public bool isEnumConstant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._isEnumConstant15427);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._isEnumConstant15427);
		}
		public new global::java.lang.Class Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType15428;
		public global::java.lang.Class getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getType15428)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getType15428)) as java.lang.Class;
		}
		public new global::java.lang.reflect.Type GenericType
		{
			get
			{
				return getGenericType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericType15429;
		public global::java.lang.reflect.Type getGenericType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getGenericType15429)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getGenericType15429)) as java.lang.reflect.Type;
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString15430;
		public global::java.lang.String toGenericString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._toGenericString15430)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._toGenericString15430)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set15431;
		public void set(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._set15431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._set15431, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean15432;
		public void setBoolean(java.lang.Object arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setBoolean15432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setBoolean15432, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte15433;
		public void setByte(java.lang.Object arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setByte15433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setByte15433, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChar15434;
		public void setChar(java.lang.Object arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setChar15434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setChar15434, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort15435;
		public void setShort(java.lang.Object arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setShort15435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setShort15435, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt15436;
		public void setInt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setInt15436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setInt15436, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong15437;
		public void setLong(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setLong15437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setLong15437, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat15438;
		public void setFloat(java.lang.Object arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setFloat15438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setFloat15438, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble15439;
		public void setDouble(java.lang.Object arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setDouble15439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setDouble15439, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Field"));
			global::java.lang.reflect.Field._get15409 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.reflect.Field._equals15410 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Field._toString15411 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._hashCode15412 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "hashCode", "()I");
			global::java.lang.reflect.Field._getModifiers15413 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Field._getBoolean15414 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getBoolean", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Field._getByte15415 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getByte", "(Ljava/lang/Object;)B");
			global::java.lang.reflect.Field._getShort15416 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getShort", "(Ljava/lang/Object;)S");
			global::java.lang.reflect.Field._getChar15417 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getChar", "(Ljava/lang/Object;)C");
			global::java.lang.reflect.Field._getInt15418 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getInt", "(Ljava/lang/Object;)I");
			global::java.lang.reflect.Field._getLong15419 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getLong", "(Ljava/lang/Object;)J");
			global::java.lang.reflect.Field._getFloat15420 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getFloat", "(Ljava/lang/Object;)F");
			global::java.lang.reflect.Field._getDouble15421 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDouble", "(Ljava/lang/Object;)D");
			global::java.lang.reflect.Field._getName15422 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._isSynthetic15423 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Field._getDeclaringClass15424 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.reflect.Field._getAnnotation15425 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Field._getDeclaredAnnotations15426 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Field._isEnumConstant15427 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "isEnumConstant", "()Z");
			global::java.lang.reflect.Field._getType15428 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getType", "()Ljava/lang/Class;");
			global::java.lang.reflect.Field._getGenericType15429 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getGenericType", "()Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Field._toGenericString15430 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "toGenericString", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._set15431 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.lang.reflect.Field._setBoolean15432 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setBoolean", "(Ljava/lang/Object;Z)V");
			global::java.lang.reflect.Field._setByte15433 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setByte", "(Ljava/lang/Object;B)V");
			global::java.lang.reflect.Field._setChar15434 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setChar", "(Ljava/lang/Object;C)V");
			global::java.lang.reflect.Field._setShort15435 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setShort", "(Ljava/lang/Object;S)V");
			global::java.lang.reflect.Field._setInt15436 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setInt", "(Ljava/lang/Object;I)V");
			global::java.lang.reflect.Field._setLong15437 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setLong", "(Ljava/lang/Object;J)V");
			global::java.lang.reflect.Field._setFloat15438 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setFloat", "(Ljava/lang/Object;F)V");
			global::java.lang.reflect.Field._setDouble15439 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setDouble", "(Ljava/lang/Object;D)V");
		}
	}
}
