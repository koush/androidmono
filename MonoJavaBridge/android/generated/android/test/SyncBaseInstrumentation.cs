namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncBaseInstrumentation : android.test.InstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SyncBaseInstrumentation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setUp12319;
		protected override void setUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation._setUp12319);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._setUp12319);
		}
		internal static global::MonoJavaBridge.MethodId _syncProvider12320;
		protected virtual void syncProvider(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation._syncProvider12320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._syncProvider12320, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cancelSyncsandDisableAutoSync12321;
		protected virtual void cancelSyncsandDisableAutoSync()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation._cancelSyncsandDisableAutoSync12321);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._cancelSyncsandDisableAutoSync12321);
		}
		internal static global::MonoJavaBridge.MethodId _SyncBaseInstrumentation12322;
		public SyncBaseInstrumentation() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._SyncBaseInstrumentation12322);
			Init(@__env, handle);
		}
		static SyncBaseInstrumentation()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.SyncBaseInstrumentation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/SyncBaseInstrumentation"));
			global::android.test.SyncBaseInstrumentation._setUp12319 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "setUp", "()V");
			global::android.test.SyncBaseInstrumentation._syncProvider12320 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "syncProvider", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.SyncBaseInstrumentation._cancelSyncsandDisableAutoSync12321 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "cancelSyncsandDisableAutoSync", "()V");
			global::android.test.SyncBaseInstrumentation._SyncBaseInstrumentation12322 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}
}
