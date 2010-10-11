namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JetPlayer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static JetPlayer()
		{
			InitJNI();
		}
		protected JetPlayer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.JetPlayer.OnJetEventListener_))]
		public interface OnJetEventListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5);
			void onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2);
			void onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1);
			void onJetPauseUpdate(android.media.JetPlayer arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.JetPlayer.OnJetEventListener))]
		public sealed partial class OnJetEventListener_ : java.lang.Object, OnJetEventListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnJetEventListener_()
			{
				InitJNI();
			}
			internal OnJetEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onJetEvent4958;
			 void android.media.JetPlayer.OnJetEventListener.onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_._onJetEvent4958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_.staticClass, global::android.media.JetPlayer.OnJetEventListener_._onJetEvent4958, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _onJetUserIdUpdate4959;
			 void android.media.JetPlayer.OnJetEventListener.onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_._onJetUserIdUpdate4959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_.staticClass, global::android.media.JetPlayer.OnJetEventListener_._onJetUserIdUpdate4959, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onJetNumQueuedSegmentUpdate4960;
			 void android.media.JetPlayer.OnJetEventListener.onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_._onJetNumQueuedSegmentUpdate4960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_.staticClass, global::android.media.JetPlayer.OnJetEventListener_._onJetNumQueuedSegmentUpdate4960, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onJetPauseUpdate4961;
			 void android.media.JetPlayer.OnJetEventListener.onJetPauseUpdate(android.media.JetPlayer arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_._onJetPauseUpdate4961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.OnJetEventListener_.staticClass, global::android.media.JetPlayer.OnJetEventListener_._onJetPauseUpdate4961, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.JetPlayer.OnJetEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/JetPlayer$OnJetEventListener"));
				global::android.media.JetPlayer.OnJetEventListener_._onJetEvent4958 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetEvent", "(Landroid/media/JetPlayer;SBBBB)V");
				global::android.media.JetPlayer.OnJetEventListener_._onJetUserIdUpdate4959 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetUserIdUpdate", "(Landroid/media/JetPlayer;II)V");
				global::android.media.JetPlayer.OnJetEventListener_._onJetNumQueuedSegmentUpdate4960 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetNumQueuedSegmentUpdate", "(Landroid/media/JetPlayer;I)V");
				global::android.media.JetPlayer.OnJetEventListener_._onJetPauseUpdate4961 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetPauseUpdate", "(Landroid/media/JetPlayer;I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize4962;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer._finalize4962);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._finalize4962);
		}
		internal static global::MonoJavaBridge.MethodId _clone4963;
		public virtual new global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.media.JetPlayer._clone4963)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._clone4963)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _release4964;
		public virtual void release() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer._release4964);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._release4964);
		}
		internal static global::MonoJavaBridge.MethodId _play4965;
		public virtual bool play() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._play4965);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._play4965);
		}
		internal static global::MonoJavaBridge.MethodId _pause4966;
		public virtual bool pause() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._pause4966);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._pause4966);
		}
		internal static global::MonoJavaBridge.MethodId _getJetPlayer4967;
		public static global::android.media.JetPlayer getJetPlayer() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getJetPlayer4967)) as android.media.JetPlayer;
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTracks4968;
		public static int getMaxTracks() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getMaxTracks4968);
		}
		internal static global::MonoJavaBridge.MethodId _loadJetFile4969;
		public virtual bool loadJetFile(android.content.res.AssetFileDescriptor arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._loadJetFile4969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._loadJetFile4969, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadJetFile4970;
		public virtual bool loadJetFile(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._loadJetFile4970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._loadJetFile4970, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeJetFile4971;
		public virtual bool closeJetFile() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._closeJetFile4971);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._closeJetFile4971);
		}
		internal static global::MonoJavaBridge.MethodId _queueJetSegment4972;
		public virtual bool queueJetSegment(int arg0, int arg1, int arg2, int arg3, int arg4, byte arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._queueJetSegment4972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._queueJetSegment4972, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _queueJetSegmentMuteArray4973;
		public virtual bool queueJetSegmentMuteArray(int arg0, int arg1, int arg2, int arg3, bool[] arg4, byte arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._queueJetSegmentMuteArray4973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._queueJetSegmentMuteArray4973, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteFlags4974;
		public virtual bool setMuteFlags(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._setMuteFlags4974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteFlags4974, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteArray4975;
		public virtual bool setMuteArray(bool[] arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._setMuteArray4975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteArray4975, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteFlag4976;
		public virtual bool setMuteFlag(int arg0, bool arg1, bool arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._setMuteFlag4976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setMuteFlag4976, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _triggerClip4977;
		public virtual bool triggerClip(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._triggerClip4977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._triggerClip4977, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearQueue4978;
		public virtual bool clearQueue() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.JetPlayer._clearQueue4978);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._clearQueue4978);
		}
		internal static global::MonoJavaBridge.MethodId _setEventListener4979;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer._setEventListener4979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setEventListener4979, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEventListener4980;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0, android.os.Handler arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.JetPlayer._setEventListener4980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.JetPlayer.staticClass, global::android.media.JetPlayer._setEventListener4980, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.JetPlayer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/JetPlayer"));
			global::android.media.JetPlayer._finalize4962 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "finalize", "()V");
			global::android.media.JetPlayer._clone4963 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.media.JetPlayer._release4964 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "release", "()V");
			global::android.media.JetPlayer._play4965 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "play", "()Z");
			global::android.media.JetPlayer._pause4966 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "pause", "()Z");
			global::android.media.JetPlayer._getJetPlayer4967 = @__env.GetStaticMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "getJetPlayer", "()Landroid/media/JetPlayer;");
			global::android.media.JetPlayer._getMaxTracks4968 = @__env.GetStaticMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "getMaxTracks", "()I");
			global::android.media.JetPlayer._loadJetFile4969 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z");
			global::android.media.JetPlayer._loadJetFile4970 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "loadJetFile", "(Ljava/lang/String;)Z");
			global::android.media.JetPlayer._closeJetFile4971 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "closeJetFile", "()Z");
			global::android.media.JetPlayer._queueJetSegment4972 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "queueJetSegment", "(IIIIIB)Z");
			global::android.media.JetPlayer._queueJetSegmentMuteArray4973 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "queueJetSegmentMuteArray", "(IIII[ZB)Z");
			global::android.media.JetPlayer._setMuteFlags4974 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setMuteFlags", "(IZ)Z");
			global::android.media.JetPlayer._setMuteArray4975 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setMuteArray", "([ZZ)Z");
			global::android.media.JetPlayer._setMuteFlag4976 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setMuteFlag", "(IZZ)Z");
			global::android.media.JetPlayer._triggerClip4977 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "triggerClip", "(I)Z");
			global::android.media.JetPlayer._clearQueue4978 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "clearQueue", "()Z");
			global::android.media.JetPlayer._setEventListener4979 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V");
			global::android.media.JetPlayer._setEventListener4980 = @__env.GetMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V");
		}
	}
}
