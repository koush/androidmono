namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AsyncPlayer : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AsyncPlayer() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.AsyncPlayer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.AsyncPlayer(@__env); 
			} 
		} 
		protected AsyncPlayer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4128; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AsyncPlayer)) 
				@__env.CallVoidMethod(this, _stop4128); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AsyncPlayer.staticClass, _stop4128); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4129; 
		public virtual void play(android.content.Context arg0, android.net.Uri arg1, bool arg2, int arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AsyncPlayer)) 
				@__env.CallVoidMethod(this, _play4129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AsyncPlayer.staticClass, _play4129, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AsyncPlayer4130; 
		public AsyncPlayer(java.lang.String arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.media.AsyncPlayer.staticClass, _AsyncPlayer4130, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.AsyncPlayer.staticClass = @__class; 
			global::android.media.AsyncPlayer._stop4128 = @__env.GetMethodID(global::android.media.AsyncPlayer.staticClass, "stop", "()V"); 
			global::android.media.AsyncPlayer._play4129 = @__env.GetMethodID(global::android.media.AsyncPlayer.staticClass, "play", "(Landroid/content/Context;Landroid/net/Uri;ZI)V"); 
			global::android.media.AsyncPlayer._AsyncPlayer4130 = @__env.GetMethodID(global::android.media.AsyncPlayer.staticClass, "<init>", "(Ljava/lang/String;)V"); 
		} 
	} 
} 
