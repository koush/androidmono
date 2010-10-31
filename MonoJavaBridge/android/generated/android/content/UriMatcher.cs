namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class UriMatcher : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected UriMatcher(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual int match(android.net.Uri arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.content.UriMatcher.staticClass, "match", "(Landroid/net/Uri;)I", ref global::android.content.UriMatcher._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void addURI(java.lang.String arg0, java.lang.String arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.UriMatcher.staticClass, "addURI", "(Ljava/lang/String;Ljava/lang/String;I)V", ref global::android.content.UriMatcher._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public UriMatcher(int arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.UriMatcher._m2.native == global::System.IntPtr.Zero)
				global::android.content.UriMatcher._m2 = @__env.GetMethodIDNoThrow(global::android.content.UriMatcher.staticClass, "<init>", "(I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.UriMatcher.staticClass, global::android.content.UriMatcher._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
	}
}
