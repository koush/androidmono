namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComparisonFailure : android.test.AssertionFailedError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ComparisonFailure(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::java.lang.String Message
		{
			get
			{
				return getMessage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMessage12179;
		public override global::java.lang.String getMessage()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.test.ComparisonFailure.staticClass, "getMessage", "()Ljava/lang/String;", ref global::android.test.ComparisonFailure._getMessage12179) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ComparisonFailure12180;
		public ComparisonFailure(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ComparisonFailure._ComparisonFailure12180.native == global::System.IntPtr.Zero)
				global::android.test.ComparisonFailure._ComparisonFailure12180 = @__env.GetMethodIDNoThrow(global::android.test.ComparisonFailure.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ComparisonFailure.staticClass, global::android.test.ComparisonFailure._ComparisonFailure12180, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		static ComparisonFailure()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ComparisonFailure.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ComparisonFailure"));
		}
		internal static void InitJNI()
		{
		}
	}
}
