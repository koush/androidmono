namespace java.lang.reflect
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Modifier : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Modifier(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String toString(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m0.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "toString", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool isInterface(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m1.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isInterface", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool isAbstract(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m2.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isAbstract", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool isProtected(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m3.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isProtected", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool isFinal(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m4.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isFinal", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static bool isStatic(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m5.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m5 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isStatic", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static bool isPublic(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m6.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m6 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isPublic", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public static bool isPrivate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m7.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m7 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isPrivate", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public static bool isSynchronized(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m8.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m8 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isSynchronized", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public static bool isVolatile(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m9.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m9 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isVolatile", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static bool isTransient(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m10.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m10 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isTransient", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public static bool isNative(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m11.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m11 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isNative", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public static bool isStrict(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m12.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m12 = @__env.GetStaticMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "isStrict", "(I)Z");
			return @__env.CallStaticBooleanMethod(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public Modifier() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.reflect.Modifier._m13.native == global::System.IntPtr.Zero)
				global::java.lang.reflect.Modifier._m13 = @__env.GetMethodIDNoThrow(global::java.lang.reflect.Modifier.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.reflect.Modifier.staticClass, global::java.lang.reflect.Modifier._m13);
			Init(@__env, handle);
		}
		public static int PUBLIC
		{
			get
			{
				return 1;
			}
		}
		public static int PRIVATE
		{
			get
			{
				return 2;
			}
		}
		public static int PROTECTED
		{
			get
			{
				return 4;
			}
		}
		public static int STATIC
		{
			get
			{
				return 8;
			}
		}
		public static int FINAL
		{
			get
			{
				return 16;
			}
		}
		public static int SYNCHRONIZED
		{
			get
			{
				return 32;
			}
		}
		public static int VOLATILE
		{
			get
			{
				return 64;
			}
		}
		public static int TRANSIENT
		{
			get
			{
				return 128;
			}
		}
		public static int NATIVE
		{
			get
			{
				return 256;
			}
		}
		public static int INTERFACE
		{
			get
			{
				return 512;
			}
		}
		public static int ABSTRACT
		{
			get
			{
				return 1024;
			}
		}
		public static int STRICT
		{
			get
			{
				return 2048;
			}
		}
		static Modifier()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.reflect.Modifier.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/reflect/Modifier"));
		}
	}
}
