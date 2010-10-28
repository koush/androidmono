namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class ContentUris : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ContentUris(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _parseId2771;
		public static long parseId(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticLongMethod(android.content.ContentUris.staticClass, global::android.content.ContentUris._parseId2771, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _appendId2772;
		public static global::android.net.Uri.Builder appendId(android.net.Uri.Builder arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.Uri.Builder>(@__env.CallStaticObjectMethod(android.content.ContentUris.staticClass, global::android.content.ContentUris._appendId2772, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri.Builder;
		}
		internal static global::MonoJavaBridge.MethodId _withAppendedId2773;
		public static global::android.net.Uri withAppendedId(android.net.Uri arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.ContentUris.staticClass, global::android.content.ContentUris._withAppendedId2773, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.net.Uri;
		}
		internal static global::MonoJavaBridge.MethodId _ContentUris2774;
		public ContentUris() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.ContentUris.staticClass, global::android.content.ContentUris._ContentUris2774);
			Init(@__env, handle);
		}
		static ContentUris()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.ContentUris.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/ContentUris"));
			global::android.content.ContentUris._parseId2771 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentUris.staticClass, "parseId", "(Landroid/net/Uri;)J");
			global::android.content.ContentUris._appendId2772 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentUris.staticClass, "appendId", "(Landroid/net/Uri$Builder;J)Landroid/net/Uri$Builder;");
			global::android.content.ContentUris._withAppendedId2773 = @__env.GetStaticMethodIDNoThrow(global::android.content.ContentUris.staticClass, "withAppendedId", "(Landroid/net/Uri;J)Landroid/net/Uri;");
			global::android.content.ContentUris._ContentUris2774 = @__env.GetMethodIDNoThrow(global::android.content.ContentUris.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
