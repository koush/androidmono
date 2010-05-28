namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AndroidCharacter : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AndroidCharacter() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.text.AndroidCharacter), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _mirror6687; 
		public static bool mirror(char[] arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticBooleanMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._mirror6687, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDirectionalities6688; 
		public static void getDirectionalities(char[] arg0, byte[] arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getDirectionalities6688, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMirror6689; 
		public static char getMirror(char arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return @__env.CallStaticCharMethod(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._getMirror6689, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AndroidCharacter6690; 
		public AndroidCharacter()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.AndroidCharacter.staticClass, global::android.text.AndroidCharacter._AndroidCharacter6690, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.AndroidCharacter.staticClass = @__class; 
			global::android.text.AndroidCharacter._mirror6687 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "mirror", "([CII)Z"); 
			global::android.text.AndroidCharacter._getDirectionalities6688 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "getDirectionalities", "([C[BI)V"); 
			global::android.text.AndroidCharacter._getMirror6689 = @__env.GetStaticMethodID(global::android.text.AndroidCharacter.staticClass, "getMirror", "(C)C"); 
			global::android.text.AndroidCharacter._AndroidCharacter6690 = @__env.GetMethodID(global::android.text.AndroidCharacter.staticClass, "<init>", "()V"); 
		} 
	} 
} 
