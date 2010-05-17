namespace android.util 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class StateSet : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static StateSet() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.util.StateSet), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.util.StateSet(@__env); 
			} 
		} 
		protected StateSet(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump7237; 
		public static java.lang.String dump(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.util.StateSet.staticClass, _dump7237, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWildCard7238; 
		public static bool isWildCard(int[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, _isWildCard7238, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stateSetMatches7239; 
		public static bool stateSetMatches(int[] arg0, int[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, _stateSetMatches7239, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stateSetMatches7240; 
		public static bool stateSetMatches(int[] arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.util.StateSet.staticClass, _stateSetMatches7240, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _trimStateSet7241; 
		public static int[] trimStateSet(int[] arg0, int arg1) 
		{ 
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.util.StateSet.staticClass, _trimStateSet7241, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _StateSet7242; 
		public StateSet()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.util.StateSet.staticClass, _StateSet7242, this); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _WILD_CARD7243; 
		public static int[] WILD_CARD
		{ 
			get 
			{ 
				return default(int[]); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.util.StateSet.staticClass = @__class; 
			global::android.util.StateSet._dump7237 = @__env.GetStaticMethodID(global::android.util.StateSet.staticClass, "dump", "([I)Ljava/lang/String;"); 
			global::android.util.StateSet._isWildCard7238 = @__env.GetStaticMethodID(global::android.util.StateSet.staticClass, "isWildCard", "([I)Z"); 
			global::android.util.StateSet._stateSetMatches7239 = @__env.GetStaticMethodID(global::android.util.StateSet.staticClass, "stateSetMatches", "([I[I)Z"); 
			global::android.util.StateSet._stateSetMatches7240 = @__env.GetStaticMethodID(global::android.util.StateSet.staticClass, "stateSetMatches", "([II)Z"); 
			global::android.util.StateSet._trimStateSet7241 = @__env.GetStaticMethodID(global::android.util.StateSet.staticClass, "trimStateSet", "([II)[I"); 
			global::android.util.StateSet._StateSet7242 = @__env.GetMethodID(global::android.util.StateSet.staticClass, "<init>", "()V"); 
		} 
	} 
} 
