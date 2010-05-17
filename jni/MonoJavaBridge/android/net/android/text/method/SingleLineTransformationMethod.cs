namespace android.text.method 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class SingleLineTransformationMethod : android.text.method.ReplacementTransformationMethod
	{ 
		internal new static global::java.lang.Class staticClass; 
		static SingleLineTransformationMethod() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.method.SingleLineTransformationMethod), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.method.SingleLineTransformationMethod(@__env); 
			} 
		} 
		protected SingleLineTransformationMethod(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInstance6875; 
		public static android.text.method.SingleLineTransformationMethod getInstance() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.text.method.SingleLineTransformationMethod>(@__env, @__env.CallStaticObjectMethodPtr(android.text.method.SingleLineTransformationMethod.staticClass, _getInstance6875)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getOriginal6876; 
		protected override char[] getOriginal() 
		{ 
			if (GetType() == typeof(android.text.method.SingleLineTransformationMethod)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getOriginal6876)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.SingleLineTransformationMethod.staticClass, _getOriginal6876)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReplacement6877; 
		protected override char[] getReplacement() 
		{ 
			if (GetType() == typeof(android.text.method.SingleLineTransformationMethod)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getReplacement6877)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.text.method.SingleLineTransformationMethod.staticClass, _getReplacement6877)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _SingleLineTransformationMethod6878; 
		public SingleLineTransformationMethod()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.text.method.SingleLineTransformationMethod.staticClass, _SingleLineTransformationMethod6878, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.method.SingleLineTransformationMethod.staticClass = @__class; 
			global::android.text.method.SingleLineTransformationMethod._getInstance6875 = @__env.GetStaticMethodID(global::android.text.method.SingleLineTransformationMethod.staticClass, "getInstance", "()Landroid/text/method/SingleLineTransformationMethod;"); 
			global::android.text.method.SingleLineTransformationMethod._getOriginal6876 = @__env.GetMethodID(global::android.text.method.SingleLineTransformationMethod.staticClass, "getOriginal", "()[C"); 
			global::android.text.method.SingleLineTransformationMethod._getReplacement6877 = @__env.GetMethodID(global::android.text.method.SingleLineTransformationMethod.staticClass, "getReplacement", "()[C"); 
			global::android.text.method.SingleLineTransformationMethod._SingleLineTransformationMethod6878 = @__env.GetMethodID(global::android.text.method.SingleLineTransformationMethod.staticClass, "<init>", "()V"); 
		} 
	} 
} 
