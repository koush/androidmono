namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class Ringtone : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected Ringtone(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void stop()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.Ringtone.staticClass, "stop", "()V", ref global::android.media.Ringtone._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.String getTitle(android.content.Context arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.media.Ringtone.staticClass, "getTitle", "(Landroid/content/Context;)Ljava/lang/String;", ref global::android.media.Ringtone._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void play()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.Ringtone.staticClass, "play", "()V", ref global::android.media.Ringtone._m2);
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getStreamType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.Ringtone.staticClass, "getStreamType", "()I", ref global::android.media.Ringtone._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isPlaying()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.Ringtone.staticClass, "isPlaying", "()Z", ref global::android.media.Ringtone._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setStreamType(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.Ringtone.staticClass, "setStreamType", "(I)V", ref global::android.media.Ringtone._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static Ringtone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.Ringtone.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/Ringtone"));
		}
		internal static void InitJNI()
		{
		}
	}
}
