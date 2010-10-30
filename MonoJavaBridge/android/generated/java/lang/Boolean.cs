namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Boolean : java.lang.Object, java.io.Serializable, Comparable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Boolean(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override bool equals(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Boolean.staticClass, "equals", "(Ljava/lang/Object;)Z", ref global::java.lang.Boolean._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public sealed override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::java.lang.Boolean.staticClass, "toString", "()Ljava/lang/String;", ref global::java.lang.Boolean._m1) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.String toString(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Boolean._m2.native == global::System.IntPtr.Zero)
				global::java.lang.Boolean._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "toString", "(Z)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public sealed override int hashCode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Boolean.staticClass, "hashCode", "()I", ref global::java.lang.Boolean._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public int compareTo(java.lang.Boolean arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Boolean;)I", ref global::java.lang.Boolean._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public int compareTo(java.lang.Object arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.lang.Boolean.staticClass, "compareTo", "(Ljava/lang/Object;)I", ref global::java.lang.Boolean._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static bool getBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Boolean._m6.native == global::System.IntPtr.Zero)
				global::java.lang.Boolean._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "getBoolean", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static global::java.lang.Boolean valueOf(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Boolean._m7.native == global::System.IntPtr.Zero)
				global::java.lang.Boolean._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Z)Ljava/lang/Boolean;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Boolean>(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static global::java.lang.Boolean valueOf(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Boolean._m8.native == global::System.IntPtr.Zero)
				global::java.lang.Boolean._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "valueOf", "(Ljava/lang/String;)Ljava/lang/Boolean;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Boolean>(@__env.CallStaticObjectMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Boolean;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public bool booleanValue()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.lang.Boolean.staticClass, "booleanValue", "()Z", ref global::java.lang.Boolean._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static bool parseBoolean(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Boolean._m10.native == global::System.IntPtr.Zero)
				global::java.lang.Boolean._m10 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Boolean.staticClass, "parseBoolean", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Boolean.staticClass, global::java.lang.Boolean._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public Boolean(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Boolean._m11.native == global::System.IntPtr.Zero)
				global::java.lang.Boolean._m11 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Z)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public Boolean(java.lang.String arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Boolean._m12.native == global::System.IntPtr.Zero)
				global::java.lang.Boolean._m12 = @__env.GetMethodIDNoThrow(global::java.lang.Boolean.staticClass, "<init>", "(Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.Boolean.staticClass, global::java.lang.Boolean._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _TRUE6383;
		public static global::java.lang.Boolean TRUE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Boolean>(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _TRUE6383)) as java.lang.Boolean;
			}
		}
		internal static global::MonoJavaBridge.FieldId _FALSE6384;
		public static global::java.lang.Boolean FALSE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Boolean>(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _FALSE6384)) as java.lang.Boolean;
			}
		}
		internal static global::MonoJavaBridge.FieldId _TYPE6385;
		public static global::java.lang.Class TYPE
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.Class>(@__env.GetStaticObjectField(global::java.lang.Boolean.staticClass, _TYPE6385)) as java.lang.Class;
			}
		}
		static Boolean()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Boolean.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Boolean"));
			global::java.lang.Boolean._TRUE6383 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "TRUE", "Ljava/lang/Boolean;");
			global::java.lang.Boolean._FALSE6384 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "FALSE", "Ljava/lang/Boolean;");
			global::java.lang.Boolean._TYPE6385 = @__env.GetStaticFieldIDNoThrow(global::java.lang.Boolean.staticClass, "TYPE", "Ljava/lang/Class;");
		}
		internal static void InitJNI()
		{
		}
	}
}
