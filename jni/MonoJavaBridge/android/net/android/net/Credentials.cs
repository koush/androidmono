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
		internal static global::net.sf.jni4net.jni.MethodId _getUid4374; 
		public virtual int getUid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Credentials)) 
				return @__env.CallIntMethod(this, _getUid4374); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Credentials.staticClass, _getUid4374); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPid4375; 
		public virtual int getPid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Credentials)) 
				return @__env.CallIntMethod(this, _getPid4375); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Credentials.staticClass, _getPid4375); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getGid4376; 
		public virtual int getGid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.Credentials)) 
				return @__env.CallIntMethod(this, _getGid4376); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.Credentials.staticClass, _getGid4376); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Credentials4377; 
		public Credentials(int arg0, int arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.net.Credentials.staticClass, _Credentials4377, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.Credentials.staticClass = @__class; 
			global::android.net.Credentials._getUid4374 = @__env.GetMethodID(global::android.net.Credentials.staticClass, "getUid", "()I"); 
			global::android.net.Credentials._getPid4375 = @__env.GetMethodID(global::android.net.Credentials.staticClass, "getPid", "()I"); 
			global::android.net.Credentials._getGid4376 = @__env.GetMethodID(global::android.net.Credentials.staticClass, "getGid", "()I"); 
			global::android.net.Credentials._Credentials4377 = @__env.GetMethodID(global::android.net.Credentials.staticClass, "<init>", "(III)V"); 
		} 
	} 
} 
