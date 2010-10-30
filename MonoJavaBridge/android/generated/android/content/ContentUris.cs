namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentUris : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentUris(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static long parseId(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentUris._m0.native == global::System.IntPtr.Zero)
				global::android.content.ContentUris._m0 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentUris.staticClass, "parseId", "(Landroid/net/Uri;)J");
			return @__env.CallStaticLongMethod(android.content.ContentUris.staticClass, global::android.content.ContentUris._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.net.Uri.Builder appendId(android.net.Uri.Builder arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentUris._m1.native == global::System.IntPtr.Zero)
				global::android.content.ContentUris._m1 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentUris.staticClass, "appendId", "(Landroid/net/Uri$Builder;J)Landroid/net/Uri$Builder;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.Uri.Builder>(@__env.CallStaticObjectMethod(android.content.ContentUris.staticClass, global::android.content.ContentUris._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri.Builder;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static global::android.net.Uri withAppendedId(android.net.Uri arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentUris._m2.native == global::System.IntPtr.Zero)
				global::android.content.ContentUris._m2 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentUris.staticClass, "withAppendedId", "(Landroid/net/Uri;J)Landroid/net/Uri;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentUris.staticClass, global::android.content.ContentUris._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public ContentUris() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.ContentUris._m3.native == global::System.IntPtr.Zero)
				global::android.content.ContentUris._m3 = @__env.GetMethodIDNoThrow(global::android.content.ContentUris.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentUris.staticClass, global::android.content.ContentUris._m3);
			Init(@__env, handle);
		}
		static ContentUris()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentUris.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentUris"));
		}
		internal static void InitJNI()
		{
		}
	}
}
