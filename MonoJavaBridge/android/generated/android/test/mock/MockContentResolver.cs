namespace android.test.mock
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class MockContentResolver : android.content.ContentResolver
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected MockContentResolver(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _addProvider12395;
		public virtual void addProvider(java.lang.String arg0, android.content.ContentProvider arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContentResolver._addProvider12395.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContentResolver._addProvider12395 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentResolver.staticClass, "addProvider", "(Ljava/lang/String;Landroid/content/ContentProvider;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContentResolver.staticClass, global::android.test.mock.MockContentResolver._addProvider12395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _notifyChange12396;
		public override void notifyChange(android.net.Uri arg0, android.database.ContentObserver arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContentResolver._notifyChange12396.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContentResolver._notifyChange12396 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentResolver.staticClass, "notifyChange", "(Landroid/net/Uri;Landroid/database/ContentObserver;Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.mock.MockContentResolver.staticClass, global::android.test.mock.MockContentResolver._notifyChange12396, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _MockContentResolver12397;
		public MockContentResolver() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.mock.MockContentResolver._MockContentResolver12397.native == global::System.IntPtr.Zero)
				global::android.test.mock.MockContentResolver._MockContentResolver12397 = @__env.GetMethodIDNoThrow(global::android.test.mock.MockContentResolver.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.mock.MockContentResolver.staticClass, global::android.test.mock.MockContentResolver._MockContentResolver12397);
			Init(@__env, handle);
		}
		static MockContentResolver()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.mock.MockContentResolver.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/mock/MockContentResolver"));
		}
		internal static void InitJNI()
		{
		}
	}
}
