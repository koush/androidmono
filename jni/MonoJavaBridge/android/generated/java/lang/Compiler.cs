namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Compiler : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Compiler()
		{
			InitJNI();
		}
		internal Compiler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _compileClass20079;
		public static bool compileClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._compileClass20079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _compileClasses20080;
		public static bool compileClasses(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._compileClasses20080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _command20081;
		public static global::java.lang.Object command(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._command20081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _enable20082;
		public static void enable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._enable20082);
		}
		internal static global::MonoJavaBridge.MethodId _disable20083;
		public static void disable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			@__env.CallStaticVoidMethod(java.lang.Compiler.staticClass, global::java.lang.Compiler._disable20083);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.Compiler.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/Compiler"));
			global::java.lang.Compiler._compileClass20079 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "compileClass", "(Ljava/lang/Class;)Z");
			global::java.lang.Compiler._compileClasses20080 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "compileClasses", "(Ljava/lang/String;)Z");
			global::java.lang.Compiler._command20081 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "command", "(Ljava/lang/Object;)Ljava/lang/Object;");
			global::java.lang.Compiler._enable20082 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "enable", "()V");
			global::java.lang.Compiler._disable20083 = @__env.GetStaticMethodIDNoThrow(global::java.lang.Compiler.staticClass, "disable", "()V");
		}
	}
}
