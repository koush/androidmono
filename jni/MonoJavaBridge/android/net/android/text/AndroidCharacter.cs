namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AndroidCharacter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AndroidCharacter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.AndroidCharacter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.AndroidCharacter(@__env); 
			} 
		} 
		protected AndroidCharacter(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _mirror6399; 
		public static bool mirror(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.AndroidCharacter.staticClass, _mirror6399, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDirectionalities6400; 
		public static void getDirectionalities(char[] arg0, byte[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.AndroidCharacter.staticClass, _getDirectionalities6400, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMirror6401; 
		public static char getMirror(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticCharMethod(android.text.AndroidCharacter.staticClass, _getMirror6401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AndroidCharacter6402; 
		public AndroidCharacter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.AndroidCharacter.staticClass, _AndroidCharacter6402, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.AndroidCharacter.staticClass = @__class; 
			global::android.text.AndroidCharacter._mirror6399 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "mirror", "([CII)Z"); 
			global::android.text.AndroidCharacter._getDirectionalities6400 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "getDirectionalities", "([C[BI)V"); 
			global::android.text.AndroidCharacter._getMirror6401 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "getMirror", "(C)C"); 
			global::android.text.AndroidCharacter._AndroidCharacter6402 = @__env.GetMethodID(global::android.text.AndroidCharacter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
