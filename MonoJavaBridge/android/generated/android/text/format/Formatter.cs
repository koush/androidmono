namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Formatter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal Formatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String formatFileSize(android.content.Context arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Formatter._m0.native == global::System.IntPtr.Zero)
				global::android.text.format.Formatter._m0 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Formatter.staticClass, "formatFileSize", "(Landroid/content/Context;J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::java.lang.String formatShortFileSize(android.content.Context arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Formatter._m1.native == global::System.IntPtr.Zero)
				global::android.text.format.Formatter._m1 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Formatter.staticClass, "formatShortFileSize", "(Landroid/content/Context;J)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::java.lang.String formatIpAddress(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Formatter._m2.native == global::System.IntPtr.Zero)
				global::android.text.format.Formatter._m2 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Formatter.staticClass, "formatIpAddress", "(I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public Formatter() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.text.format.Formatter._m3.native == global::System.IntPtr.Zero)
				global::android.text.format.Formatter._m3 = @__env.GetMethodIDNoThrow(global::android.text.format.Formatter.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._m3);
			Init(@__env, handle);
		}
		static Formatter()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.Formatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/Formatter"));
		}
	}
}
