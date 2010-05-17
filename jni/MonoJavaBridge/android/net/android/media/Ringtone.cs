namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Ringtone : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Ringtone() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.Ringtone), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.Ringtone(@__env); 
			} 
		} 
		protected Ringtone(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop4318; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.Ringtone)) 
				@__env.CallVoidMethod(this, _stop4318); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.Ringtone.staticClass, _stop4318); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle4319; 
		public virtual java.lang.String getTitle(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.Ringtone)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getTitle4319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.media.Ringtone.staticClass, _getTitle4319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4320; 
		public virtual void play() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.Ringtone)) 
				@__env.CallVoidMethod(this, _play4320); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.Ringtone.staticClass, _play4320); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStreamType4321; 
		public virtual int getStreamType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.Ringtone)) 
				return @__env.CallIntMethod(this, _getStreamType4321); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.Ringtone.staticClass, _getStreamType4321); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPlaying4322; 
		public virtual bool isPlaying() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.Ringtone)) 
				return @__env.CallBooleanMethod(this, _isPlaying4322); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.Ringtone.staticClass, _isPlaying4322); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStreamType4323; 
		public virtual void setStreamType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.Ringtone)) 
				@__env.CallVoidMethod(this, _setStreamType4323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.Ringtone.staticClass, _setStreamType4323, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.Ringtone.staticClass = @__class; 
			global::android.media.Ringtone._stop4318 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "stop", "()V"); 
			global::android.media.Ringtone._getTitle4319 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "getTitle", "(Landroid/content/Context;)Ljava/lang/String;"); 
			global::android.media.Ringtone._play4320 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "play", "()V"); 
			global::android.media.Ringtone._getStreamType4321 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "getStreamType", "()I"); 
			global::android.media.Ringtone._isPlaying4322 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "isPlaying", "()Z"); 
			global::android.media.Ringtone._setStreamType4323 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "setStreamType", "(I)V"); 
		} 
	} 
} 
