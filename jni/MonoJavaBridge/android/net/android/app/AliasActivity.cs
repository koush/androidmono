namespace android.app 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AliasActivity : android.app.Activity
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AliasActivity() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.app.AliasActivity), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.app.AliasActivity(@__env); 
			} 
		} 
		protected AliasActivity(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCreate420; 
		protected override void onCreate(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.app.AliasActivity)) 
				@__env.CallVoidMethod(this, _onCreate420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.app.AliasActivity.staticClass, _onCreate420, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AliasActivity421; 
		public AliasActivity()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.app.AliasActivity.staticClass, _AliasActivity421, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.app.AliasActivity.staticClass = @__class; 
			global::android.app.AliasActivity._onCreate420 = @__env.GetMethodID(global::android.app.AliasActivity.staticClass, "onCreate", "(Landroid/os/Bundle;)V"); 
			global::android.app.AliasActivity._AliasActivity421 = @__env.GetMethodID(global::android.app.AliasActivity.staticClass, "<init>", "()V"); 
		} 
	} 
} 
