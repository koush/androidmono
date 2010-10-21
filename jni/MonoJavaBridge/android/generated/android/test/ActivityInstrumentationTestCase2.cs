namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ActivityInstrumentationTestCase2_))]
	public abstract partial class ActivityInstrumentationTestCase2 : android.test.ActivityTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityInstrumentationTestCase2()
		{
			InitJNI();
		}
		protected ActivityInstrumentationTestCase2(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getActivity12059;
		public virtual global::android.app.Activity getActivity() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2._getActivity12059)) as android.app.Activity;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._getActivity12059)) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12060;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2._setUp12060);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._setUp12060);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12061;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2._tearDown12061);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._tearDown12061);
		}
		internal static global::MonoJavaBridge.MethodId _runTest12062;
		protected override void runTest() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2._runTest12062);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._runTest12062);
		}
		internal static global::MonoJavaBridge.MethodId _setActivityIntent12063;
		public virtual void setActivityIntent(android.content.Intent arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2._setActivityIntent12063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._setActivityIntent12063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setActivityInitialTouchMode12064;
		public virtual void setActivityInitialTouchMode(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2._setActivityInitialTouchMode12064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._setActivityInitialTouchMode12064, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInstrumentationTestCase212065;
		public ActivityInstrumentationTestCase2(java.lang.Class arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInstrumentationTestCase212066;
		public ActivityInstrumentationTestCase2(java.lang.String arg0, java.lang.Class arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212066, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityInstrumentationTestCase2.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityInstrumentationTestCase2"));
			global::android.test.ActivityInstrumentationTestCase2._getActivity12059 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "getActivity", "()Landroid/app/Activity;");
			global::android.test.ActivityInstrumentationTestCase2._setUp12060 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "setUp", "()V");
			global::android.test.ActivityInstrumentationTestCase2._tearDown12061 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "tearDown", "()V");
			global::android.test.ActivityInstrumentationTestCase2._runTest12062 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "runTest", "()V");
			global::android.test.ActivityInstrumentationTestCase2._setActivityIntent12063 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "setActivityIntent", "(Landroid/content/Intent;)V");
			global::android.test.ActivityInstrumentationTestCase2._setActivityInitialTouchMode12064 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "setActivityInitialTouchMode", "(Z)V");
			global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212065 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212066 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ActivityInstrumentationTestCase2))]
	public sealed partial class ActivityInstrumentationTestCase2_ : android.test.ActivityInstrumentationTestCase2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ActivityInstrumentationTestCase2_()
		{
			InitJNI();
		}
		internal ActivityInstrumentationTestCase2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityInstrumentationTestCase2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityInstrumentationTestCase2"));
		}
	}
}
