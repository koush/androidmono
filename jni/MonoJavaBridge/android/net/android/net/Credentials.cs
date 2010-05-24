namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Credentials : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Credentials() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.Credentials), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.Credentials(@__env); 
			} 
		} 
		protected Credentials(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUid4622; 
		public virtual int getUid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Credentials)) 
				return @__env.CallIntMethod(this, _getUid4622); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Credentials.staticClass, _getUid4622); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPid4623; 
		public virtual int getPid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Credentials)) 
				return @__env.CallIntMethod(this, _getPid4623); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Credentials.staticClass, _getPid4623); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGid4624; 
		public virtual int getGid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Credentials)) 
				return @__env.CallIntMethod(this, _getGid4624); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Credentials.staticClass, _getGid4624); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Credentials4625; 
		public Credentials(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.Credentials.staticClass, _Credentials4625, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.Credentials.staticClass = @__class; 
			global::android.net.Credentials._getUid4622 = @__env.GetMethodID(global::android.net.Credentials.staticClass, "getUid", "()I"); 
			global::android.net.Credentials._getPid4623 = @__env.GetMethodID(global::android.net.Credentials.staticClass, "getPid", "()I"); 
			global::android.net.Credentials._getGid4624 = @__env.GetMethodID(global::android.net.Credentials.staticClass, "getGid", "()I"); 
			global::android.net.Credentials._Credentials4625 = @__env.GetMethodID(global::android.net.Credentials.staticClass, "<init>", "(III)V"); 
		} 
	} 
} 
