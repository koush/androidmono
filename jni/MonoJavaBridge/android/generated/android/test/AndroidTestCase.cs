namespace android.test
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AndroidTestCase : junit.framework.TestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AndroidTestCase()
		{
			InitJNI();
		}
		protected AndroidTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		public new global::android.content.Context Context
		{
			get
			{
				return getContext();
			}
			set
			{
				setContext(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getContext12140;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.AndroidTestCase._getContext12140)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._getContext12140)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12141;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._setUp12141);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._setUp12141);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12142;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._tearDown12142);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._tearDown12142);
		}
		internal static global::MonoJavaBridge.MethodId _scrubClass12143;
		protected virtual void scrubClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._scrubClass12143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._scrubClass12143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testAndroidTestCaseSetupProperly12144;
		public virtual void testAndroidTestCaseSetupProperly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly12144);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly12144);
		}
		internal static global::MonoJavaBridge.MethodId _setContext12145;
		public virtual void setContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._setContext12145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._setContext12145, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertActivityRequiresPermission12146;
		public virtual void assertActivityRequiresPermission(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertActivityRequiresPermission12146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertActivityRequiresPermission12146, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertReadingContentUriRequiresPermission12147;
		public virtual void assertReadingContentUriRequiresPermission(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission12147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission12147, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertWritingContentUriRequiresPermission12148;
		public virtual void assertWritingContentUriRequiresPermission(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission12148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission12148, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AndroidTestCase12149;
		public AndroidTestCase()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._AndroidTestCase12149);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.AndroidTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/AndroidTestCase"));
			global::android.test.AndroidTestCase._getContext12140 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.test.AndroidTestCase._setUp12141 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "setUp", "()V");
			global::android.test.AndroidTestCase._tearDown12142 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "tearDown", "()V");
			global::android.test.AndroidTestCase._scrubClass12143 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "scrubClass", "(Ljava/lang/Class;)V");
			global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly12144 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "testAndroidTestCaseSetupProperly", "()V");
			global::android.test.AndroidTestCase._setContext12145 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "setContext", "(Landroid/content/Context;)V");
			global::android.test.AndroidTestCase._assertActivityRequiresPermission12146 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertActivityRequiresPermission", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission12147 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertReadingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission12148 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertWritingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._AndroidTestCase12149 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "<init>", "()V");
		}
	}
}
