namespace android.text.format
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class Formatter : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Formatter()
		{
			InitJNI();
		}
		internal Formatter(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _formatFileSize7984;
		public static global::java.lang.String formatFileSize(android.content.Context arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._formatFileSize7984, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatShortFileSize7985;
		public static global::java.lang.String formatShortFileSize(android.content.Context arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._formatShortFileSize7985, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _formatIpAddress7986;
		public static global::java.lang.String formatIpAddress(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._formatIpAddress7986, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _Formatter7987;
		public Formatter()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.text.format.Formatter.staticClass, global::android.text.format.Formatter._Formatter7987);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.text.format.Formatter.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/text/format/Formatter"));
			global::android.text.format.Formatter._formatFileSize7984 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Formatter.staticClass, "formatFileSize", "(Landroid/content/Context;J)Ljava/lang/String;");
			global::android.text.format.Formatter._formatShortFileSize7985 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Formatter.staticClass, "formatShortFileSize", "(Landroid/content/Context;J)Ljava/lang/String;");
			global::android.text.format.Formatter._formatIpAddress7986 = @__env.GetStaticMethodIDNoThrow(global::android.text.format.Formatter.staticClass, "formatIpAddress", "(I)Ljava/lang/String;");
			global::android.text.format.Formatter._Formatter7987 = @__env.GetMethodIDNoThrow(global::android.text.format.Formatter.staticClass, "<init>", "()V");
		}
	}
}
