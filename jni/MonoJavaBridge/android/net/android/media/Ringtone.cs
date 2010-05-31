namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Ringtone : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Ringtone() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.Ringtone), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _stop4566; 
		public virtual void stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.Ringtone._stop4566); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._stop4566); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTitle4567; 
		public virtual global::java.lang.String getTitle(android.content.Context arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.media.Ringtone._getTitle4567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._getTitle4567, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _play4568; 
		public virtual void play() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.Ringtone._play4568); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._play4568); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStreamType4569; 
		public virtual int getStreamType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.Ringtone._getStreamType4569); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._getStreamType4569); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isPlaying4570; 
		public virtual bool isPlaying() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.Ringtone._isPlaying4570); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._isPlaying4570); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStreamType4571; 
		public virtual void setStreamType(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.Ringtone._setStreamType4571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._setStreamType4571, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.Ringtone.staticClass = @__class; 
			global::android.media.Ringtone._stop4566 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "stop", "()V"); 
			global::android.media.Ringtone._getTitle4567 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "getTitle", "(Landroid/content/Context;)Ljava/lang/String;"); 
			global::android.media.Ringtone._play4568 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "play", "()V"); 
			global::android.media.Ringtone._getStreamType4569 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "getStreamType", "()I"); 
			global::android.media.Ringtone._isPlaying4570 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "isPlaying", "()Z"); 
			global::android.media.Ringtone._setStreamType4571 = @__env.GetMethodID(global::android.media.Ringtone.staticClass, "setStreamType", "(I)V"); 
		} 
	} 
} 
