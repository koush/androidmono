namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class HideReturnsTransformationMethod : android.text.method.ReplacementTransformationMethod
	{ 
		internal new static global::java.lang.Class staticClass; 
		static HideReturnsTransformationMethod() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.HideReturnsTransformationMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.HideReturnsTransformationMethod(@__env); 
			} 
		} 
		protected HideReturnsTransformationMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6797; 
		public static android.text.method.HideReturnsTransformationMethod getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.HideReturnsTransformationMethod>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.HideReturnsTransformationMethod.staticClass, _getInstance6797)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginal6798; 
		protected override char[] getOriginal() 
		{ 
			if (GetType() == typeof(android.text.method.HideReturnsTransformationMethod)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getOriginal6798)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.HideReturnsTransformationMethod.staticClass, _getOriginal6798)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReplacement6799; 
		protected override char[] getReplacement() 
		{ 
			if (GetType() == typeof(android.text.method.HideReturnsTransformationMethod)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getReplacement6799)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.HideReturnsTransformationMethod.staticClass, _getReplacement6799)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _HideReturnsTransformationMethod6800; 
		public HideReturnsTransformationMethod()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.HideReturnsTransformationMethod.staticClass, _HideReturnsTransformationMethod6800, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.HideReturnsTransformationMethod.staticClass = @__class; 
			global::android.text.method.HideReturnsTransformationMethod._getInstance6797 = @__env.GetStaticMethodID(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/HideReturnsTransformationMethod;"); 
			global::android.text.method.HideReturnsTransformationMethod._getOriginal6798 = @__env.GetMethodID(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getOriginal", "()[C"); 
			global::android.text.method.HideReturnsTransformationMethod._getReplacement6799 = @__env.GetMethodID(global::android.text.method.HideReturnsTransformationMethod.staticClass, "getReplacement", "()[C"); 
			global::android.text.method.HideReturnsTransformationMethod._HideReturnsTransformationMethod6800 = @__env.GetMethodID(global::android.text.method.HideReturnsTransformationMethod.staticClass, "<init>", "()V"); 
		} 
	} 
} 
