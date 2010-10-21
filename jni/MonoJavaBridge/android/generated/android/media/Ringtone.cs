namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Ringtone : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static Ringtone()
		{
			InitJNI();
		}
		protected Ringtone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _stop7405;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._stop7405);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._stop7405);
		}
		internal static global::MonoJavaBridge.MethodId _getTitle7406;
		public virtual global::java.lang.String getTitle(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.media.Ringtone._getTitle7406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._getTitle7406, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _play7407;
		public virtual void play() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._play7407);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._play7407);
		}
		public new int StreamType
		{
			get
			{
				return getStreamType();
			}
			set
			{
				setStreamType(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getStreamType7408;
		public virtual int getStreamType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.Ringtone._getStreamType7408);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._getStreamType7408);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying7409;
		public virtual bool isPlaying() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.Ringtone._isPlaying7409);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._isPlaying7409);
		}
		internal static global::MonoJavaBridge.MethodId _setStreamType7410;
		public virtual void setStreamType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._setStreamType7410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._setStreamType7410, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.Ringtone.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/Ringtone"));
			global::android.media.Ringtone._stop7405 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "stop", "()V");
			global::android.media.Ringtone._getTitle7406 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "getTitle", "(Landroid/content/Context;)Ljava/lang/String;");
			global::android.media.Ringtone._play7407 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "play", "()V");
			global::android.media.Ringtone._getStreamType7408 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "getStreamType", "()I");
			global::android.media.Ringtone._isPlaying7409 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "isPlaying", "()Z");
			global::android.media.Ringtone._setStreamType7410 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "setStreamType", "(I)V");
		}
	}
}
