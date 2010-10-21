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
		internal static global::MonoJavaBridge.MethodId _AssertionError19599;
		public AssertionError(double arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19600;
		public AssertionError(java.lang.Object arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19600, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19601;
		public AssertionError(bool arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19601, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19602;
		public AssertionError(char arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19602, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19603;
		public AssertionError(int arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19603, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19604;
		public AssertionError(long arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19604, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19605;
		public AssertionError(float arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19605, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19606;
		public AssertionError()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19606);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AssertionError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AssertionError"));
			global::java.lang.AssertionError._AssertionError19599 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(D)V");
			global::java.lang.AssertionError._AssertionError19600 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::java.lang.AssertionError._AssertionError19601 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(Z)V");
			global::java.lang.AssertionError._AssertionError19602 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(C)V");
			global::java.lang.AssertionError._AssertionError19603 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(I)V");
			global::java.lang.AssertionError._AssertionError19604 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(J)V");
			global::java.lang.AssertionError._AssertionError19605 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(F)V");
			global::java.lang.AssertionError._AssertionError19606 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "()V");
		}
	}
}
