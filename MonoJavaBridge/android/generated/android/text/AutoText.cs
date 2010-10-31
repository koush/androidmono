namespace android.text
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AutoText : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AutoText(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String get(java.lang.CharSequence arg0, int arg1, int arg2, android.view.View arg3)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AutoText._m0.native == global::System.IntPtr.Zero)
				global::android.text.AutoText._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.AutoText.staticClass, "get", "(Ljava/lang/CharSequence;IILandroid/view/View;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.AutoText.staticClass, global::android.text.AutoText._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as java.lang.String;
		}
		public static java.lang.String get(string arg0, int arg1, int arg2, android.view.View arg3)
		{
			return get((global::java.lang.CharSequence)(global::java.lang.String)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static int getSize(android.view.View arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.AutoText._m1.native == global::System.IntPtr.Zero)
				global::android.text.AutoText._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.AutoText.staticClass, "getSize", "(Landroid/view/View;)I");
			return @__env.CallStaticIntMethod(android.text.AutoText.staticClass, global::android.text.AutoText._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static AutoText()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.AutoText.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/AutoText"));
		}
	}
}
