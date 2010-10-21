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
		internal static global::MonoJavaBridge.MethodId _getContext12083;
		public virtual global::android.content.Context getContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.AndroidTestCase._getContext12083)) as android.content.Context;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._getContext12083)) as android.content.Context;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12084;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._setUp12084);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._setUp12084);
		}
		internal static global::MonoJavaBridge.MethodId _tearDown12085;
		protected override void tearDown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._tearDown12085);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._tearDown12085);
		}
		internal static global::MonoJavaBridge.MethodId _scrubClass12086;
		protected virtual void scrubClass(java.lang.Class arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._scrubClass12086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._scrubClass12086, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _testAndroidTestCaseSetupProperly12087;
		public virtual void testAndroidTestCaseSetupProperly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly12087);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly12087);
		}
		internal static global::MonoJavaBridge.MethodId _setContext12088;
		public virtual void setContext(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._setContext12088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._setContext12088, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _assertActivityRequiresPermission12089;
		public virtual void assertActivityRequiresPermission(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertActivityRequiresPermission12089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertActivityRequiresPermission12089, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _assertReadingContentUriRequiresPermission12090;
		public virtual void assertReadingContentUriRequiresPermission(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission12090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission12090, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _assertWritingContentUriRequiresPermission12091;
		public virtual void assertWritingContentUriRequiresPermission(android.net.Uri arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission12091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission12091, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _AndroidTestCase12092;
		public AndroidTestCase()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.AndroidTestCase.staticClass, global::android.test.AndroidTestCase._AndroidTestCase12092);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.AndroidTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/AndroidTestCase"));
			global::android.test.AndroidTestCase._getContext12083 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "getContext", "()Landroid/content/Context;");
			global::android.test.AndroidTestCase._setUp12084 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "setUp", "()V");
			global::android.test.AndroidTestCase._tearDown12085 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "tearDown", "()V");
			global::android.test.AndroidTestCase._scrubClass12086 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "scrubClass", "(Ljava/lang/Class;)V");
			global::android.test.AndroidTestCase._testAndroidTestCaseSetupProperly12087 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "testAndroidTestCaseSetupProperly", "()V");
			global::android.test.AndroidTestCase._setContext12088 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "setContext", "(Landroid/content/Context;)V");
			global::android.test.AndroidTestCase._assertActivityRequiresPermission12089 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertActivityRequiresPermission", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._assertReadingContentUriRequiresPermission12090 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertReadingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._assertWritingContentUriRequiresPermission12091 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "assertWritingContentUriRequiresPermission", "(Landroid/net/Uri;Ljava/lang/String;)V");
			global::android.test.AndroidTestCase._AndroidTestCase12092 = @__env.GetMethodIDNoThrow(global::android.test.AndroidTestCase.staticClass, "<init>", "()V");
		}
	}
}
