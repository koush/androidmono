namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ComparisonFailure : android.test.AssertionFailedError
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ComparisonFailure()
		{
			InitJNI();
		}
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
		internal static global::MonoJavaBridge.MethodId _getMessage12122;
		public override global::java.lang.String getMessage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ComparisonFailure._getMessage12122)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ComparisonFailure.staticClass, global::android.test.ComparisonFailure._getMessage12122)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _ComparisonFailure12123;
		public ComparisonFailure(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ComparisonFailure.staticClass, global::android.test.ComparisonFailure._ComparisonFailure12123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ComparisonFailure.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ComparisonFailure"));
			global::android.test.ComparisonFailure._getMessage12122 = @__env.GetMethodIDNoThrow(global::android.test.ComparisonFailure.staticClass, "getMessage", "()Ljava/lang/String;");
			global::android.test.ComparisonFailure._ComparisonFailure12123 = @__env.GetMethodIDNoThrow(global::android.test.ComparisonFailure.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
		}
	}
}
