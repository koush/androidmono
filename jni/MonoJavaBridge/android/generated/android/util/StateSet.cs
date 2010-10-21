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
		internal static global::MonoJavaBridge.MethodId _dump13813;
		public static global::java.lang.String dump(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.util.StateSet.staticClass, global::android.util.StateSet._dump13813, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isWildCard13814;
		public static bool isWildCard(int[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._isWildCard13814, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _stateSetMatches13815;
		public static bool stateSetMatches(int[] arg0, int[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._stateSetMatches13815, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stateSetMatches13816;
		public static bool stateSetMatches(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, global::android.util.StateSet._stateSetMatches13816, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _trimStateSet13817;
		public static int[] trimStateSet(int[] arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.CallStaticObjectMethod(android.util.StateSet.staticClass, global::android.util.StateSet._trimStateSet13817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as int[];
		}
		internal static global::MonoJavaBridge.MethodId _StateSet13818;
		public StateSet()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.util.StateSet.staticClass, global::android.util.StateSet._StateSet13818);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _WILD_CARD13819;
		public static int[] WILD_CARD
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<int>(@__env.GetStaticObjectField(global::android.util.StateSet.staticClass, _WILD_CARD13819)) as int[];
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.util.StateSet.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/util/StateSet"));
			global::android.util.StateSet._dump13813 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "dump", "([I)Ljava/lang/String;");
			global::android.util.StateSet._isWildCard13814 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "isWildCard", "([I)Z");
			global::android.util.StateSet._stateSetMatches13815 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "stateSetMatches", "([I[I)Z");
			global::android.util.StateSet._stateSetMatches13816 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "stateSetMatches", "([II)Z");
			global::android.util.StateSet._trimStateSet13817 = @__env.GetStaticMethodIDNoThrow(global::android.util.StateSet.staticClass, "trimStateSet", "([II)[I");
			global::android.util.StateSet._StateSet13818 = @__env.GetMethodIDNoThrow(global::android.util.StateSet.staticClass, "<init>", "()V");
			global::android.util.StateSet._WILD_CARD13819 = @__env.GetStaticFieldIDNoThrow(global::android.util.StateSet.staticClass, "WILD_CARD", "[I");
		}
	}
}
