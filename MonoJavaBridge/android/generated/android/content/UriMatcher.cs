namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UriMatcher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UriMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _match3590;
		public virtual int match(android.net.Uri arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.UriMatcher._match3590.native == global::System.IntPtr.Zero)
				global::android.content.UriMatcher._match3590 = @__env.GetMethodIDNoThrow(global::android.content.UriMatcher.staticClass, "match", "(Landroid/net/Uri;)I");
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.UriMatcher.staticClass, global::android.content.UriMatcher._match3590, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _addURI3591;
		public virtual void addURI(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.UriMatcher._addURI3591.native == global::System.IntPtr.Zero)
				global::android.content.UriMatcher._addURI3591 = @__env.GetMethodIDNoThrow(global::android.content.UriMatcher.staticClass, "addURI", "(Ljava/lang/String;Ljava/lang/String;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.UriMatcher.staticClass, global::android.content.UriMatcher._addURI3591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _UriMatcher3592;
		public UriMatcher(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.UriMatcher._UriMatcher3592.native == global::System.IntPtr.Zero)
				global::android.content.UriMatcher._UriMatcher3592 = @__env.GetMethodIDNoThrow(global::android.content.UriMatcher.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.UriMatcher.staticClass, global::android.content.UriMatcher._UriMatcher3592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		public static int NO_MATCH
		{
			get
			{
				return -1;
			}
		}
		static UriMatcher()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.UriMatcher.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/UriMatcher"));
		}
		internal static void InitJNI()
		{
		}
	}
}
