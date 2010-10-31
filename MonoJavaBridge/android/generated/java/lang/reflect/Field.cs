namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Field : java.lang.reflect.AccessibleObject, Member
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Field(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public global::java.lang.Object get(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.lang.reflect.Field.staticClass, "get", "(Ljava/lang/Object;)Ljava/lang/Object;", ref global::java.lang.reflect.Field._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Field.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.reflect.Field._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Field.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.reflect.Field._m2) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Field.staticClass, "hashCode", "()I", ref global::java.lang.reflect.Field._m3);
		}
		public new int Modifiers
		{
			get
			{
				return getModifiers();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int getModifiers()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Field.staticClass, "getModifiers", "()I", ref global::java.lang.reflect.Field._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public bool getBoolean(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Field.staticClass, "getBoolean", "(Ljava/lang/Object;)Z", ref global::java.lang.reflect.Field._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public byte getByte(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallByteMethod(this, global::java.lang.reflect.Field.staticClass, "getByte", "(Ljava/lang/Object;)B", ref global::java.lang.reflect.Field._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public short getShort(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallShortMethod(this, global::java.lang.reflect.Field.staticClass, "getShort", "(Ljava/lang/Object;)S", ref global::java.lang.reflect.Field._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public char getChar(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallCharMethod(this, global::java.lang.reflect.Field.staticClass, "getChar", "(Ljava/lang/Object;)C", ref global::java.lang.reflect.Field._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public int getInt(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.reflect.Field.staticClass, "getInt", "(Ljava/lang/Object;)I", ref global::java.lang.reflect.Field._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public long getLong(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::java.lang.reflect.Field.staticClass, "getLong", "(Ljava/lang/Object;)J", ref global::java.lang.reflect.Field._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public float getFloat(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallFloatMethod(this, global::java.lang.reflect.Field.staticClass, "getFloat", "(Ljava/lang/Object;)F", ref global::java.lang.reflect.Field._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public double getDouble(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallDoubleMethod(this, global::java.lang.reflect.Field.staticClass, "getDouble", "(Ljava/lang/Object;)D", ref global::java.lang.reflect.Field._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String Name
		{
			get
			{
				return getName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public global::java.lang.String getName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Field.staticClass, "getName", "()Ljava/lang/String;", ref global::java.lang.reflect.Field._m13) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public bool isSynthetic()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Field.staticClass, "isSynthetic", "()Z", ref global::java.lang.reflect.Field._m14);
		}
		public new global::java.lang.Class DeclaringClass
		{
			get
			{
				return getDeclaringClass();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public global::java.lang.Class getDeclaringClass()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Field.staticClass, "getDeclaringClass", "()Ljava/lang/Class;", ref global::java.lang.reflect.Field._m15) as java.lang.Class;
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public sealed override global::java.lang.annotation.Annotation getAnnotation(java.lang.Class arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.Field.staticClass, "getAnnotation", "(Ljava/lang/Class;)Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Field._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.annotation.Annotation;
		}
		public new global::java.lang.annotation.Annotation[] DeclaredAnnotations
		{
			get
			{
				return getDeclaredAnnotations();
			}
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public sealed override global::java.lang.annotation.Annotation[] getDeclaredAnnotations()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<java.lang.annotation.Annotation>(this, global::java.lang.reflect.Field.staticClass, "getDeclaredAnnotations", "()[Ljava/lang/annotation/Annotation;", ref global::java.lang.reflect.Field._m17) as java.lang.annotation.Annotation[];
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public bool isEnumConstant()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.reflect.Field.staticClass, "isEnumConstant", "()Z", ref global::java.lang.reflect.Field._m18);
		}
		public new global::java.lang.Class Type
		{
			get
			{
				return getType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public global::java.lang.Class getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.Class>(this, global::java.lang.reflect.Field.staticClass, "getType", "()Ljava/lang/Class;", ref global::java.lang.reflect.Field._m19) as java.lang.Class;
		}
		public new global::java.lang.reflect.Type GenericType
		{
			get
			{
				return getGenericType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public global::java.lang.reflect.Type getGenericType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.lang.reflect.Type>(this, global::java.lang.reflect.Field.staticClass, "getGenericType", "()Ljava/lang/reflect/Type;", ref global::java.lang.reflect.Field._m20) as java.lang.reflect.Type;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public global::java.lang.String toGenericString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.reflect.Field.staticClass, "toGenericString", "()Ljava/lang/String;", ref global::java.lang.reflect.Field._m21) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public void set(java.lang.Object arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "set", "(Ljava/lang/Object;Ljava/lang/Object;)V", ref global::java.lang.reflect.Field._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public void setBoolean(java.lang.Object arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "setBoolean", "(Ljava/lang/Object;Z)V", ref global::java.lang.reflect.Field._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public void setByte(java.lang.Object arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "setByte", "(Ljava/lang/Object;B)V", ref global::java.lang.reflect.Field._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public void setChar(java.lang.Object arg0, char arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "setChar", "(Ljava/lang/Object;C)V", ref global::java.lang.reflect.Field._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public void setShort(java.lang.Object arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "setShort", "(Ljava/lang/Object;S)V", ref global::java.lang.reflect.Field._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public void setInt(java.lang.Object arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "setInt", "(Ljava/lang/Object;I)V", ref global::java.lang.reflect.Field._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public void setLong(java.lang.Object arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "setLong", "(Ljava/lang/Object;J)V", ref global::java.lang.reflect.Field._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public void setFloat(java.lang.Object arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "setFloat", "(Ljava/lang/Object;F)V", ref global::java.lang.reflect.Field._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public void setDouble(java.lang.Object arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.lang.reflect.Field.staticClass, "setDouble", "(Ljava/lang/Object;D)V", ref global::java.lang.reflect.Field._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static Field()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Field.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Field"));
		}
	}
}
