namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ProviderTestCase2_))]
	public abstract partial class ProviderTestCase2 : android.test.AndroidTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProviderTestCase2()
		{
			InitJNI();
		}
		protected ProviderTestCase2(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProvider12223;
		public virtual global::android.content.ContentProvider getProvider() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase2._getProvider12223)) as android.content.ContentProvider;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase2.staticClass, global::android.test.ProviderTestCase2._getProvider12223)) as android.content.ContentProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12224;
		protected override void setUp() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.test.ProviderTestCase2._setUp12224);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.test.ProviderTestCase2.staticClass, global::android.test.ProviderTestCase2._setUp12224);
		}
		internal static global::MonoJavaBridge.MethodId _getMockContentResolver12225;
		public virtual global::android.test.mock.MockContentResolver getMockContentResolver() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase2._getMockContentResolver12225)) as android.test.mock.MockContentResolver;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase2.staticClass, global::android.test.ProviderTestCase2._getMockContentResolver12225)) as android.test.mock.MockContentResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getMockContext12226;
		public virtual global::android.test.IsolatedContext getMockContext() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase2._getMockContext12226)) as android.test.IsolatedContext;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.test.ProviderTestCase2.staticClass, global::android.test.ProviderTestCase2._getMockContext12226)) as android.test.IsolatedContext;
		}
		internal static global::MonoJavaBridge.MethodId _newResolverWithContentProviderFromSql12227;
		public static global::android.content.ContentResolver newResolverWithContentProviderFromSql(android.content.Context arg0, java.lang.String arg1, java.lang.Class arg2, java.lang.String arg3, java.lang.String arg4, int arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.test.ProviderTestCase2.staticClass, global::android.test.ProviderTestCase2._newResolverWithContentProviderFromSql12227, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.content.ContentResolver;
		}
		internal static global::MonoJavaBridge.MethodId _ProviderTestCase212228;
		public ProviderTestCase2(java.lang.Class arg0, java.lang.String arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ProviderTestCase2.staticClass, global::android.test.ProviderTestCase2._ProviderTestCase212228, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ProviderTestCase2.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ProviderTestCase2"));
			global::android.test.ProviderTestCase2._getProvider12223 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase2.staticClass, "getProvider", "()Landroid/content/ContentProvider;");
			global::android.test.ProviderTestCase2._setUp12224 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase2.staticClass, "setUp", "()V");
			global::android.test.ProviderTestCase2._getMockContentResolver12225 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase2.staticClass, "getMockContentResolver", "()Landroid/test/mock/MockContentResolver;");
			global::android.test.ProviderTestCase2._getMockContext12226 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase2.staticClass, "getMockContext", "()Landroid/test/IsolatedContext;");
			global::android.test.ProviderTestCase2._newResolverWithContentProviderFromSql12227 = @__env.GetStaticMethodIDNoThrow(global::android.test.ProviderTestCase2.staticClass, "newResolverWithContentProviderFromSql", "(Landroid/content/Context;Ljava/lang/String;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Landroid/content/ContentResolver;");
			global::android.test.ProviderTestCase2._ProviderTestCase212228 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase2.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ProviderTestCase2))]
	public sealed partial class ProviderTestCase2_ : android.test.ProviderTestCase2
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static ProviderTestCase2_()
		{
			InitJNI();
		}
		internal ProviderTestCase2_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ProviderTestCase2_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ProviderTestCase2"));
		}
	}
}
