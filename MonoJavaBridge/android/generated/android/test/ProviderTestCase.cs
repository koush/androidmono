namespace android.test
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.test.ProviderTestCase_))]
	public abstract partial class ProviderTestCase : android.test.InstrumentationTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected ProviderTestCase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _getProvider12274;
		public virtual global::android.content.ContentProvider getProvider()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._getProvider12274)) as android.content.ContentProvider;
		}
		internal static global::MonoJavaBridge.MethodId _setUp12275;
		protected override void setUp()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._setUp12275);
		}
		internal static global::MonoJavaBridge.MethodId _getMockContentResolver12276;
		public virtual global::android.test.mock.MockContentResolver getMockContentResolver()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._getMockContentResolver12276)) as android.test.mock.MockContentResolver;
		}
		internal static global::MonoJavaBridge.MethodId _getMockContext12277;
		public virtual global::android.test.IsolatedContext getMockContext()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._getMockContext12277)) as android.test.IsolatedContext;
		}
		internal static global::MonoJavaBridge.MethodId _newResolverWithContentProviderFromSql12278;
		public static global::android.content.ContentResolver newResolverWithContentProviderFromSql(android.content.Context arg0, java.lang.Class arg1, java.lang.String arg2, java.lang.String arg3, int arg4, java.lang.String arg5)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._newResolverWithContentProviderFromSql12278, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5))) as android.content.ContentResolver;
		}
		internal static global::MonoJavaBridge.MethodId _ProviderTestCase12279;
		public ProviderTestCase(java.lang.Class arg0, java.lang.String arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.test.ProviderTestCase.staticClass, global::android.test.ProviderTestCase._ProviderTestCase12279, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		static ProviderTestCase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ProviderTestCase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ProviderTestCase"));
			global::android.test.ProviderTestCase._getProvider12274 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "getProvider", "()Landroid/content/ContentProvider;");
			global::android.test.ProviderTestCase._setUp12275 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "setUp", "()V");
			global::android.test.ProviderTestCase._getMockContentResolver12276 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "getMockContentResolver", "()Landroid/test/mock/MockContentResolver;");
			global::android.test.ProviderTestCase._getMockContext12277 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "getMockContext", "()Landroid/test/IsolatedContext;");
			global::android.test.ProviderTestCase._newResolverWithContentProviderFromSql12278 = @__env.GetStaticMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "newResolverWithContentProviderFromSql", "(Landroid/content/Context;Ljava/lang/Class;Ljava/lang/String;Ljava/lang/String;ILjava/lang/String;)Landroid/content/ContentResolver;");
			global::android.test.ProviderTestCase._ProviderTestCase12279 = @__env.GetMethodIDNoThrow(global::android.test.ProviderTestCase.staticClass, "<init>", "(Ljava/lang/Class;Ljava/lang/String;)V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.test.ProviderTestCase))]
	internal sealed partial class ProviderTestCase_ : android.test.ProviderTestCase
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal ProviderTestCase_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static ProviderTestCase_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.test.ProviderTestCase_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/test/ProviderTestCase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
