namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SoundPool : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SoundPool()
		{
			InitJNI();
		}
		protected SoundPool(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.SoundPool.OnLoadCompleteListener_))]
		public interface OnLoadCompleteListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onLoadComplete(android.media.SoundPool arg0, int arg1, int arg2);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.SoundPool.OnLoadCompleteListener))]
		public sealed partial class OnLoadCompleteListener_ : java.lang.Object, OnLoadCompleteListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnLoadCompleteListener_()
			{
				InitJNI();
			}
			internal OnLoadCompleteListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onLoadComplete7447;
			 void android.media.SoundPool.OnLoadCompleteListener.onLoadComplete(android.media.SoundPool arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool.OnLoadCompleteListener_._onLoadComplete7447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.OnLoadCompleteListener_.staticClass, global::android.media.SoundPool.OnLoadCompleteListener_._onLoadComplete7447, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.SoundPool.OnLoadCompleteListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/SoundPool$OnLoadCompleteListener"));
				global::android.media.SoundPool.OnLoadCompleteListener_._onLoadComplete7447 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.OnLoadCompleteListener_.staticClass, "onLoadComplete", "(Landroid/media/SoundPool;II)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7448;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._finalize7448);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._finalize7448);
		}
		internal static global::MonoJavaBridge.MethodId _load7449;
		public virtual int load(android.content.Context arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.SoundPool._load7449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load7449, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _load7450;
		public virtual int load(android.content.res.AssetFileDescriptor arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.SoundPool._load7450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load7450, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _load7451;
		public virtual int load(java.io.FileDescriptor arg0, long arg1, long arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.SoundPool._load7451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load7451, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _load7452;
		public virtual int load(java.lang.String arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.SoundPool._load7452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._load7452, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setPriority7453;
		public virtual void setPriority(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._setPriority7453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setPriority7453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _stop7454;
		public virtual void stop(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._stop7454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._stop7454, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _resume7455;
		public virtual void resume(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._resume7455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._resume7455, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _release7456;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._release7456);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._release7456);
		}
		internal static global::MonoJavaBridge.MethodId _unload7457;
		public virtual bool unload(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.SoundPool._unload7457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._unload7457, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _play7458;
		public virtual int play(int arg0, float arg1, float arg2, int arg3, int arg4, float arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.SoundPool._play7458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._play7458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _pause7459;
		public virtual void pause(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._pause7459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._pause7459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVolume7460;
		public virtual void setVolume(int arg0, float arg1, float arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._setVolume7460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setVolume7460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _autoPause7461;
		public virtual void autoPause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._autoPause7461);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._autoPause7461);
		}
		internal static global::MonoJavaBridge.MethodId _autoResume7462;
		public virtual void autoResume() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._autoResume7462);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._autoResume7462);
		}
		internal static global::MonoJavaBridge.MethodId _setLoop7463;
		public virtual void setLoop(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._setLoop7463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setLoop7463, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setRate7464;
		public virtual void setRate(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._setRate7464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setRate7464, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setOnLoadCompleteListener7465;
		public virtual void setOnLoadCompleteListener(android.media.SoundPool.OnLoadCompleteListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.SoundPool._setOnLoadCompleteListener7465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.SoundPool.staticClass, global::android.media.SoundPool._setOnLoadCompleteListener7465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _SoundPool7466;
		public SoundPool(int arg0, int arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.SoundPool.staticClass, global::android.media.SoundPool._SoundPool7466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.SoundPool.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/SoundPool"));
			global::android.media.SoundPool._finalize7448 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "finalize", "()V");
			global::android.media.SoundPool._load7449 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/Context;II)I");
			global::android.media.SoundPool._load7450 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "load", "(Landroid/content/res/AssetFileDescriptor;I)I");
			global::android.media.SoundPool._load7451 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "load", "(Ljava/io/FileDescriptor;JJI)I");
			global::android.media.SoundPool._load7452 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "load", "(Ljava/lang/String;I)I");
			global::android.media.SoundPool._setPriority7453 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setPriority", "(II)V");
			global::android.media.SoundPool._stop7454 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "stop", "(I)V");
			global::android.media.SoundPool._resume7455 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "resume", "(I)V");
			global::android.media.SoundPool._release7456 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "release", "()V");
			global::android.media.SoundPool._unload7457 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "unload", "(I)Z");
			global::android.media.SoundPool._play7458 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "play", "(IFFIIF)I");
			global::android.media.SoundPool._pause7459 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "pause", "(I)V");
			global::android.media.SoundPool._setVolume7460 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setVolume", "(IFF)V");
			global::android.media.SoundPool._autoPause7461 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "autoPause", "()V");
			global::android.media.SoundPool._autoResume7462 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "autoResume", "()V");
			global::android.media.SoundPool._setLoop7463 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setLoop", "(II)V");
			global::android.media.SoundPool._setRate7464 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setRate", "(IF)V");
			global::android.media.SoundPool._setOnLoadCompleteListener7465 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "setOnLoadCompleteListener", "(Landroid/media/SoundPool$OnLoadCompleteListener;)V");
			global::android.media.SoundPool._SoundPool7466 = @__env.GetMethodIDNoThrow(global::android.media.SoundPool.staticClass, "<init>", "(III)V");
		}
	}
}
