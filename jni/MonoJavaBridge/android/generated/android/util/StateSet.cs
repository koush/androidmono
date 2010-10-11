namespace android.util
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class StateSet : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static StateSet()
		{
			InitJNI();
		}
		protected StateSet(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _dump8618;
		public static global::java.lang.String dump(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.StateSet.staticClass, global::android.util.StateSet._dump8618, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isWildCard8619;
		public static bool isWildCard(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._isWildCard8619, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stateSetMatches8620;
		public static bool stateSetMatches(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._stateSetMatches8620, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stateSetMatches8621;
		public static bool stateSetMatches(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._stateSetMatches8621, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _trimStateSet8622;
		public static int[] trimStateSet(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.util.StateSet.staticClass, global::android.util.StateSet._trimStateSet8622, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _StateSet8623;
		public StateSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.StateSet.staticClass, global::android.util.StateSet._StateSet8623);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _WILD_CARD8624;
		public static int[] WILD_CARD
		{
			get
			{
				return default(int[]);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.StateSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/StateSet"));
			global::android.util.StateSet._dump8618 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "dump", "([I)Ljava/lang/String;");
			global::android.util.StateSet._isWildCard8619 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "isWildCard", "([I)Z");
			global::android.util.StateSet._stateSetMatches8620 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "stateSetMatches", "([I[I)Z");
			global::android.util.StateSet._stateSetMatches8621 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "stateSetMatches", "([II)Z");
			global::android.util.StateSet._trimStateSet8622 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "trimStateSet", "([II)[I");
			global::android.util.StateSet._StateSet8623 = @__env.GetMethodIDNoThrow(global::android.util.StateSet.staticClass, "<init>", "()V");
		}
	}
}
