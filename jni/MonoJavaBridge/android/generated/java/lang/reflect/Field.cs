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
		internal static global::MonoJavaBridge.MethodId _get20931;
		public global::java.lang.Object get(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._get20931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._get20931, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _equals20932;
		public sealed override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._equals20932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._equals20932, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString20933;
		public sealed override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._toString20933)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._toString20933)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode20934;
		public sealed override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._hashCode20934);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._hashCode20934);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getModifiers20935;
		public int getModifiers() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._getModifiers20935);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getModifiers20935);
		}
		internal static global::MonoJavaBridge.MethodId _getBoolean20936;
		public bool getBoolean(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._getBoolean20936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getBoolean20936, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getByte20937;
		public byte getByte(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallByteMethod(this.JvmHandle, global::java.lang.reflect.Field._getByte20937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualByteMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getByte20937, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getShort20938;
		public short getShort(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this.JvmHandle, global::java.lang.reflect.Field._getShort20938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getShort20938, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getChar20939;
		public char getChar(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallCharMethod(this.JvmHandle, global::java.lang.reflect.Field._getChar20939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualCharMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getChar20939, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getInt20940;
		public int getInt(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::java.lang.reflect.Field._getInt20940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getInt20940, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getLong20941;
		public long getLong(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::java.lang.reflect.Field._getLong20941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getLong20941, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getFloat20942;
		public float getFloat(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this.JvmHandle, global::java.lang.reflect.Field._getFloat20942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getFloat20942, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getDouble20943;
		public double getDouble(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this.JvmHandle, global::java.lang.reflect.Field._getDouble20943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDouble20943, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getName20944;
		public global::java.lang.String getName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getName20944)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getName20944)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isSynthetic20945;
		public bool isSynthetic() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._isSynthetic20945);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._isSynthetic20945);
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaringClass20946;
		public global::java.lang.Class getDeclaringClass() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getDeclaringClass20946)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDeclaringClass20946)) as java.lang.Class;
		}
		internal static global::MonoJavaBridge.MethodId _getAnnotation20947;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getAnnotation20947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getAnnotation20947, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeclaredAnnotations20948;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getDeclaredAnnotations20948)) as java.lang.annotation.Annotation[];
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.annotation.Annotation>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getDeclaredAnnotations20948)) as java.lang.annotation.Annotation[];
		}
		internal static global::MonoJavaBridge.MethodId _isEnumConstant20949;
		public bool isEnumConstant() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field._isEnumConstant20949);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._isEnumConstant20949);
		}
		public new global::java.lang.Class Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType20950;
		public global::java.lang.Class getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getType20950)) as java.lang.Class;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getType20950)) as java.lang.Class;
		}
		public new global::java.lang.reflect.Type GenericType
		{
			get
			{
				return getGenericType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getGenericType20951;
		public global::java.lang.reflect.Type getGenericType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._getGenericType20951)) as java.lang.reflect.Type;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.lang.reflect.Type>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._getGenericType20951)) as java.lang.reflect.Type;
		}
		internal static global::MonoJavaBridge.MethodId _toGenericString20952;
		public global::java.lang.String toGenericString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::java.lang.reflect.Field._toGenericString20952)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._toGenericString20952)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _set20953;
		public void set(java.lang.Object arg0, java.lang.Object arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._set20953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._set20953, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setBoolean20954;
		public void setBoolean(java.lang.Object arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setBoolean20954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setBoolean20954, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setByte20955;
		public void setByte(java.lang.Object arg0, byte arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setByte20955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setByte20955, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setChar20956;
		public void setChar(java.lang.Object arg0, char arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setChar20956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setChar20956, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setShort20957;
		public void setShort(java.lang.Object arg0, short arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setShort20957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setShort20957, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setInt20958;
		public void setInt(java.lang.Object arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setInt20958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setInt20958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setLong20959;
		public void setLong(java.lang.Object arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setLong20959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setLong20959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setFloat20960;
		public void setFloat(java.lang.Object arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setFloat20960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setFloat20960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setDouble20961;
		public void setDouble(java.lang.Object arg0, double arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::java.lang.reflect.Field._setDouble20961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::java.lang.reflect.Field.staticClass, global::java.lang.reflect.Field._setDouble20961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Field"));
			global::java.lang.reflect.Field._get20931 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.reflect.Field._equals20932 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Field._toString20933 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "toString", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._hashCode20934 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "hashCode", "()I");
			global::java.lang.reflect.Field._getModifiers20935 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getModifiers", "()I");
			global::java.lang.reflect.Field._getBoolean20936 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getBoolean", "(Ljava/lang/Object;)Z");
			global::java.lang.reflect.Field._getByte20937 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getByte", "(Ljava/lang/Object;)B");
			global::java.lang.reflect.Field._getShort20938 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getShort", "(Ljava/lang/Object;)S");
			global::java.lang.reflect.Field._getChar20939 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getChar", "(Ljava/lang/Object;)C");
			global::java.lang.reflect.Field._getInt20940 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getInt", "(Ljava/lang/Object;)I");
			global::java.lang.reflect.Field._getLong20941 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getLong", "(Ljava/lang/Object;)J");
			global::java.lang.reflect.Field._getFloat20942 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getFloat", "(Ljava/lang/Object;)F");
			global::java.lang.reflect.Field._getDouble20943 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDouble", "(Ljava/lang/Object;)D");
			global::java.lang.reflect.Field._getName20944 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getName", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._isSynthetic20945 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "isSynthetic", "()Z");
			global::java.lang.reflect.Field._getDeclaringClass20946 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDeclaringClass", "()Ljava/lang/Class;");
			global::java.lang.reflect.Field._getAnnotation20947 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Field._getDeclaredAnnotations20948 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;");
			global::java.lang.reflect.Field._isEnumConstant20949 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "isEnumConstant", "()Z");
			global::java.lang.reflect.Field._getType20950 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getType", "()Ljava/lang/Class;");
			global::java.lang.reflect.Field._getGenericType20951 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "getGenericType", "()Ljava/lang/reflect/Type;");
			global::java.lang.reflect.Field._toGenericString20952 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "toGenericString", "()Ljava/lang/String;");
			global::java.lang.reflect.Field._set20953 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V");
			global::java.lang.reflect.Field._setBoolean20954 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setBoolean", "(Ljava/lang/Object;Z)V");
			global::java.lang.reflect.Field._setByte20955 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setByte", "(Ljava/lang/Object;B)V");
			global::java.lang.reflect.Field._setChar20956 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setChar", "(Ljava/lang/Object;C)V");
			global::java.lang.reflect.Field._setShort20957 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setShort", "(Ljava/lang/Object;S)V");
			global::java.lang.reflect.Field._setInt20958 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setInt", "(Ljava/lang/Object;I)V");
			global::java.lang.reflect.Field._setLong20959 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setLong", "(Ljava/lang/Object;J)V");
			global::java.lang.reflect.Field._setFloat20960 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setFloat", "(Ljava/lang/Object;F)V");
			global::java.lang.reflect.Field._setDouble20961 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Field.staticClass, "setDouble", "(Ljava/lang/Object;D)V");
		}
	}
}
