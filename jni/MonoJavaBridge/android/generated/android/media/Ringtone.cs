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
		internal static global::MonoJavaBridge.MethodId _stop5067;
		public virtual void stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._stop5067);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._stop5067);
		}
		internal static global::MonoJavaBridge.MethodId _getTitle5068;
		public virtual global::java.lang.String getTitle(android.content.Context arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.media.Ringtone._getTitle5068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._getTitle5068, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _play5069;
		public virtual void play() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._play5069);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._play5069);
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
		internal static global::MonoJavaBridge.MethodId _getStreamType5070;
		public virtual int getStreamType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.Ringtone._getStreamType5070);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._getStreamType5070);
		}
		internal static global::MonoJavaBridge.MethodId _isPlaying5071;
		public virtual bool isPlaying() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.Ringtone._isPlaying5071);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._isPlaying5071);
		}
		internal static global::MonoJavaBridge.MethodId _setStreamType5072;
		public virtual void setStreamType(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.Ringtone._setStreamType5072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.Ringtone.staticClass, global::android.media.Ringtone._setStreamType5072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.Ringtone.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/Ringtone"));
			global::android.media.Ringtone._stop5067 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "stop", "()V");
			global::android.media.Ringtone._getTitle5068 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "getTitle", "(Landroid/content/Context;)Ljava/lang/String;");
			global::android.media.Ringtone._play5069 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "play", "()V");
			global::android.media.Ringtone._getStreamType5070 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "getStreamType", "()I");
			global::android.media.Ringtone._isPlaying5071 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "isPlaying", "()Z");
			global::android.media.Ringtone._setStreamType5072 = @__env.GetMethodIDNoThrow(global::android.media.Ringtone.staticClass, "setStreamType", "(I)V");
		}
	}
}
