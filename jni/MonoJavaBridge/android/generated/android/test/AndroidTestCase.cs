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
		internal static global::MonoJavaBridge.MethodId _getContext7615;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.AndroidTestCase._getContext7615)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._getContext7615)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setUp7616;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._setUp7616);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._setUp7616);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown7617;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._tearDown7617);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._tearDown7617);
		}
		internal static global::MonoJavaBridge.MethodId _scrubClass7618;
		protected virtual void scrubClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._scrubClass7618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._scrubClass7618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testAndroidTestCaseSetupProperly7619;
		public virtual void testAndroidTestCaseSetupProperly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly7619);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly7619);
		}
		internal static global::MonoJavaBridge.MethodId _setContext7620;
		public virtual void setContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._setContext7620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._setContext7620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertActivityRequiresPermission7621;
		public virtual void assertActivityRequiresPermission(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertActivityRequiresPermission7621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertActivityRequiresPermission7621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertReadingContentUriRequiresPermission7622;
		public virtual void assertReadingContentUriRequiresPermission(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission7622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission7622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertWritingContentUriRequiresPermission7623;
		public virtual void assertWritingContentUriRequiresPermission(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission7623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission7623, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AndroidTestCase7624;
		public AndroidTestCase()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._AndroidTestCase7624);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.AndroidTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/AndroidTestCase"));
			global::android.test.AndroidTestCase._getContext7615 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.test.AndroidTestCase._setUp7616 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "setUp", "()V");
			global::android.test.AndroidTestCase._tearDown7617 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "tearDown", "()V");
			global::android.test.AndroidTestCase._scrubClass7618 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "scrubClass", "(Ljava/lang/Class;)V");
			global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly7619 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "testAndroidTestCaseSetupProperly", "()V");
			global::android.test.AndroidTestCase._setContext7620 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "setContext", "(Landroid/content/Context;)V");
			global::android.test.AndroidTestCase._assertActivityRequiresPermission7621 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertActivityRequiresPermission", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission7622 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertReadingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission7623 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertWritingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._AndroidTestCase7624 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "<init>", "()V");
		}
	}
}
