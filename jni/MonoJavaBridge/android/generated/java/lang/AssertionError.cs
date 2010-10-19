namespace java.lang
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AssertionError : java.lang.Error
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AssertionError()
		{
			InitJNI();
		}
		protected AssertionError(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError14093;
		public AssertionError(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError14093, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError14094;
		public AssertionError(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError14094, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError14095;
		public AssertionError(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError14095, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError14096;
		public AssertionError(char arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError14096, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError14097;
		public AssertionError(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError14097, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError14098;
		public AssertionError(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError14098, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError14099;
		public AssertionError(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError14099, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError14100;
		public AssertionError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError14100);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AssertionError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AssertionError"));
			global::java.lang.AssertionError._AssertionError14093 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(D)V");
			global::java.lang.AssertionError._AssertionError14094 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::java.lang.AssertionError._AssertionError14095 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(Z)V");
			global::java.lang.AssertionError._AssertionError14096 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(C)V");
			global::java.lang.AssertionError._AssertionError14097 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(I)V");
			global::java.lang.AssertionError._AssertionError14098 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(J)V");
			global::java.lang.AssertionError._AssertionError14099 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(F)V");
			global::java.lang.AssertionError._AssertionError14100 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "()V");
		}
	}
}
