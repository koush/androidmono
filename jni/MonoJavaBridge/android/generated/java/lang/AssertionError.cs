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
		internal static global::MonoJavaBridge.MethodId _AssertionError19717;
		public AssertionError(double arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19717, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19718;
		public AssertionError(java.lang.Object arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19718, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19719;
		public AssertionError(bool arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19719, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19720;
		public AssertionError(char arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19721;
		public AssertionError(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19721, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19722;
		public AssertionError(long arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19722, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19723;
		public AssertionError(float arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _AssertionError19724;
		public AssertionError() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(java.lang.AssertionError.staticClass, global::java.lang.AssertionError._AssertionError19724);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.lang.AssertionError.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/lang/AssertionError"));
			global::java.lang.AssertionError._AssertionError19717 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(D)V");
			global::java.lang.AssertionError._AssertionError19718 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(Ljava/lang/Object;)V");
			global::java.lang.AssertionError._AssertionError19719 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(Z)V");
			global::java.lang.AssertionError._AssertionError19720 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(C)V");
			global::java.lang.AssertionError._AssertionError19721 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(I)V");
			global::java.lang.AssertionError._AssertionError19722 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(J)V");
			global::java.lang.AssertionError._AssertionError19723 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "(F)V");
			global::java.lang.AssertionError._AssertionError19724 = @__env.GetMethodIDNoThrow(global::java.lang.AssertionError.staticClass, "<init>", "()V");
		}
	}
}
