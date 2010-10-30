namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ActivityInstrumentationTestCase2_))]
	public abstract partial class ActivityInstrumentationTestCase2 : android.test.ActivityTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ActivityInstrumentationTestCase2(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getActivity12116;
		public virtual global::android.app.Activity getActivity()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase2._getActivity12116.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase2._getActivity12116 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "getActivity", "()Landroid/app/Activity;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._getActivity12116) as android.app.Activity;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12117;
		protected override void setUp()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase2._setUp12117.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase2._setUp12117 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "setUp", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._setUp12117);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12118;
		protected override void tearDown()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase2._tearDown12118.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase2._tearDown12118 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "tearDown", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._tearDown12118);
		}
		internal static global::MonoJavaBridge.MethodId _runTest12119;
		protected override void runTest()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase2._runTest12119.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase2._runTest12119 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "runTest", "()V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._runTest12119);
		}
		internal static global::MonoJavaBridge.MethodId _setActivityIntent12120;
		public virtual void setActivityIntent(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase2._setActivityIntent12120.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase2._setActivityIntent12120 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "setActivityIntent", "(Landroid/content/Intent;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._setActivityIntent12120, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setActivityInitialTouchMode12121;
		public virtual void setActivityInitialTouchMode(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase2._setActivityInitialTouchMode12121.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase2._setActivityInitialTouchMode12121 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "setActivityInitialTouchMode", "(Z)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._setActivityInitialTouchMode12121, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInstrumentationTestCase212122;
		public ActivityInstrumentationTestCase2(java.lang.Class arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212122.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212122 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "<init>", "(Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212122, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _ActivityInstrumentationTestCase212123;
		public ActivityInstrumentationTestCase2(java.lang.String arg0, java.lang.Class arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212123.native == global::System.IntPtr.Zero)
				global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212123 = @__env.GetMethodIDNoThrow(global::android.test.ActivityInstrumentationTestCase2.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/Class;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ActivityInstrumentationTestCase2.staticClass, global::android.test.ActivityInstrumentationTestCase2._ActivityInstrumentationTestCase212123, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ActivityInstrumentationTestCase2()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityInstrumentationTestCase2.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityInstrumentationTestCase2"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ActivityInstrumentationTestCase2))]
	internal sealed partial class ActivityInstrumentationTestCase2_ : android.test.ActivityInstrumentationTestCase2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ActivityInstrumentationTestCase2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ActivityInstrumentationTestCase2_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ActivityInstrumentationTestCase2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ActivityInstrumentationTestCase2"));
		}
		internal static void InitJNI()
		{
		}
	}
}
