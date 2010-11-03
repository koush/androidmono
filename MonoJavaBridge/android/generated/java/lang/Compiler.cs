namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Compiler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Compiler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static bool compileClass(java.lang.Class arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Compiler._m0.native == global::System.IntPtr.Zero)
				global::java.lang.Compiler._m0 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "compileClass", "(Ljava/lang/Class;)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool compileClasses(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Compiler._m1.native == global::System.IntPtr.Zero)
				global::java.lang.Compiler._m1 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "compileClasses", "(Ljava/lang/String;)Z");
			return @__env.CallStaticBooleanMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.Object command(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Compiler._m2.native == global::System.IntPtr.Zero)
				global::java.lang.Compiler._m2 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "command", "(Ljava/lang/Object;)Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static void enable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Compiler._m3.native == global::System.IntPtr.Zero)
				global::java.lang.Compiler._m3 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "enable", "()V");
			@__env.CallStaticVoidMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static void disable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::java.lang.Compiler._m4.native == global::System.IntPtr.Zero)
				global::java.lang.Compiler._m4 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "disable", "()V");
			@__env.CallStaticVoidMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._m4);
		}
		static Compiler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Compiler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Compiler"));
		}
	}
}
