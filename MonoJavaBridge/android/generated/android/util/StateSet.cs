namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StateSet : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected StateSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::java.lang.String dump(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._m0.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._m0 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "dump", "([I)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.util.StateSet.staticClass, global::android.util.StateSet._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static bool isWildCard(int[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._m1.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._m1 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "isWildCard", "([I)Z");
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static bool stateSetMatches(int[] arg0, int[] arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._m2.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._m2 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "stateSetMatches", "([I[I)Z");
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static bool stateSetMatches(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._m3.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._m3 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "stateSetMatches", "([II)Z");
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static int[] trimStateSet(int[] arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._m4.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._m4 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "trimStateSet", "([II)[I");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.util.StateSet.staticClass, global::android.util.StateSet._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public StateSet() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.util.StateSet._m5.native == global::System.IntPtr.Zero)
				global::android.util.StateSet._m5 = @__env.GetMethodIDNoThrow(global::android.util.StateSet.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.StateSet.staticClass, global::android.util.StateSet._m5);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _WILD_CARD5411;
		public static int[] WILD_CARD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetStaticObjectField(global::android.util.StateSet.staticClass, _WILD_CARD5411)) as int[];
			}
		}
		static StateSet()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.StateSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/StateSet"));
			global::android.util.StateSet._WILD_CARD5411 = @__env.GetStaticFieldIDNoThrow(global::android.util.StateSet.staticClass, "WILD_CARD", "[I");
		}
	}
}
