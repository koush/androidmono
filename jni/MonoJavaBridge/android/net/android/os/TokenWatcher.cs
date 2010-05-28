namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class TokenWatcher : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TokenWatcher() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.TokenWatcher), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected TokenWatcher(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cleanup5880; 
		public virtual void cleanup(android.os.IBinder arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.TokenWatcher)) 
				@__env.CallVoidMethod(this, global::android.os.TokenWatcher._cleanup5880, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._cleanup5880, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _acquire5881; 
		public virtual void acquire(android.os.IBinder arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.TokenWatcher)) 
				@__env.CallVoidMethod(this, global::android.os.TokenWatcher._acquire5881, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._acquire5881, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _release5882; 
		public virtual void release(android.os.IBinder arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.TokenWatcher)) 
				@__env.CallVoidMethod(this, global::android.os.TokenWatcher._release5882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._release5882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump5883; 
		public virtual void dump() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.TokenWatcher)) 
				@__env.CallVoidMethod(this, global::android.os.TokenWatcher._dump5883); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._dump5883); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _acquired5884; 
		public abstract void acquired(); 
		internal static global::net.sf.jni4net.jni.MethodId _released5885; 
		public abstract void released(); 
		internal static global::net.sf.jni4net.jni.MethodId _isAcquired5886; 
		public virtual bool isAcquired() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.TokenWatcher)) 
				return @__env.CallBooleanMethod(this, global::android.os.TokenWatcher._isAcquired5886); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._isAcquired5886); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TokenWatcher5887; 
		public TokenWatcher(android.os.Handler arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.TokenWatcher.staticClass, global::android.os.TokenWatcher._TokenWatcher5887, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.TokenWatcher.staticClass = @__class; 
			global::android.os.TokenWatcher._cleanup5880 = @__env.GetMethodID(global::android.os.TokenWatcher.staticClass, "cleanup", "(Landroid/os/IBinder;Z)V"); 
			global::android.os.TokenWatcher._acquire5881 = @__env.GetMethodID(global::android.os.TokenWatcher.staticClass, "acquire", "(Landroid/os/IBinder;Ljava/lang/String;)V"); 
			global::android.os.TokenWatcher._release5882 = @__env.GetMethodID(global::android.os.TokenWatcher.staticClass, "release", "(Landroid/os/IBinder;)V"); 
			global::android.os.TokenWatcher._dump5883 = @__env.GetMethodID(global::android.os.TokenWatcher.staticClass, "dump", "()V"); 
			global::android.os.TokenWatcher._acquired5884 = @__env.GetMethodID(global::android.os.TokenWatcher.staticClass, "acquired", "()V"); 
			global::android.os.TokenWatcher._released5885 = @__env.GetMethodID(global::android.os.TokenWatcher.staticClass, "released", "()V"); 
			global::android.os.TokenWatcher._isAcquired5886 = @__env.GetMethodID(global::android.os.TokenWatcher.staticClass, "isAcquired", "()Z"); 
			global::android.os.TokenWatcher._TokenWatcher5887 = @__env.GetMethodID(global::android.os.TokenWatcher.staticClass, "<init>", "(Landroid/os/Handler;Ljava/lang/String;)V"); 
		} 
	} 
} 
