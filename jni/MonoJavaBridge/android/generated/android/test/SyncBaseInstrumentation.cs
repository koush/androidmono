namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncBaseInstrumentation : android.test.InstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncBaseInstrumentation()
		{
			InitJNI();
		}
		protected SyncBaseInstrumentation(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _setUp12262;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation._setUp12262);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._setUp12262);
		}
		internal static global::MonoJavaBridge.MethodId _syncProvider12263;
		protected virtual void syncProvider(android.net.Uri arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation._syncProvider12263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._syncProvider12263, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _cancelSyncsandDisableAutoSync12264;
		protected virtual void cancelSyncsandDisableAutoSync() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation._cancelSyncsandDisableAutoSync12264);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._cancelSyncsandDisableAutoSync12264);
		}
		internal static global::MonoJavaBridge.MethodId _SyncBaseInstrumentation12265;
		public SyncBaseInstrumentation()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.SyncBaseInstrumentation.staticClass, global::android.test.SyncBaseInstrumentation._SyncBaseInstrumentation12265);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.SyncBaseInstrumentation.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/SyncBaseInstrumentation"));
			global::android.test.SyncBaseInstrumentation._setUp12262 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "setUp", "()V");
			global::android.test.SyncBaseInstrumentation._syncProvider12263 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "syncProvider", "(Landroid/net/Uri;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.SyncBaseInstrumentation._cancelSyncsandDisableAutoSync12264 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "cancelSyncsandDisableAutoSync", "()V");
			global::android.test.SyncBaseInstrumentation._SyncBaseInstrumentation12265 = @__env.GetMethodIDNoThrow(global::android.test.SyncBaseInstrumentation.staticClass, "<init>", "()V");
		}
	}
}
