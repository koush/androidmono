namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class JetPlayer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected JetPlayer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.JetPlayer.OnJetEventListener_))]
		public partial interface OnJetEventListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5);
			void onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2);
			void onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1);
			void onJetPauseUpdate(android.media.JetPlayer arg0, int arg1);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.JetPlayer.OnJetEventListener))]
		internal sealed partial class OnJetEventListener_ : java.lang.Object, OnJetEventListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnJetEventListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onJetEvent7293;
			void android.media.JetPlayer.OnJetEventListener.onJetEvent(android.media.JetPlayer arg0, short arg1, byte arg2, byte arg3, byte arg4, byte arg5)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetEvent", "(Landroid/media/JetPlayer;SBBBB)V", ref global::android.media.JetPlayer.OnJetEventListener_._onJetEvent7293, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			}
			internal static global::MonoJavaBridge.MethodId _onJetUserIdUpdate7294;
			void android.media.JetPlayer.OnJetEventListener.onJetUserIdUpdate(android.media.JetPlayer arg0, int arg1, int arg2)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetUserIdUpdate", "(Landroid/media/JetPlayer;II)V", ref global::android.media.JetPlayer.OnJetEventListener_._onJetUserIdUpdate7294, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			}
			internal static global::MonoJavaBridge.MethodId _onJetNumQueuedSegmentUpdate7295;
			void android.media.JetPlayer.OnJetEventListener.onJetNumQueuedSegmentUpdate(android.media.JetPlayer arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetNumQueuedSegmentUpdate", "(Landroid/media/JetPlayer;I)V", ref global::android.media.JetPlayer.OnJetEventListener_._onJetNumQueuedSegmentUpdate7295, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _onJetPauseUpdate7296;
			void android.media.JetPlayer.OnJetEventListener.onJetPauseUpdate(android.media.JetPlayer arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.OnJetEventListener_.staticClass, "onJetPauseUpdate", "(Landroid/media/JetPlayer;I)V", ref global::android.media.JetPlayer.OnJetEventListener_._onJetPauseUpdate7296, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			static OnJetEventListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.JetPlayer.OnJetEventListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/JetPlayer$OnJetEventListener"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize7297;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.staticClass, "finalize", "()V", ref global::android.media.JetPlayer._finalize7297);
		}
		internal static global::MonoJavaBridge.MethodId _clone7298;
		public virtual global::java.lang.Object clone()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.media.JetPlayer.staticClass, "clone", "()Ljava/lang/Object;", ref global::android.media.JetPlayer._clone7298) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _release7299;
		public virtual void release()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.staticClass, "release", "()V", ref global::android.media.JetPlayer._release7299);
		}
		internal static global::MonoJavaBridge.MethodId _play7300;
		public virtual bool play()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "play", "()Z", ref global::android.media.JetPlayer._play7300);
		}
		internal static global::MonoJavaBridge.MethodId _pause7301;
		public virtual bool pause()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "pause", "()Z", ref global::android.media.JetPlayer._pause7301);
		}
		internal static global::MonoJavaBridge.MethodId _getJetPlayer7302;
		public static global::android.media.JetPlayer getJetPlayer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.JetPlayer._getJetPlayer7302.native == global::System.IntPtr.Zero)
				global::android.media.JetPlayer._getJetPlayer7302 = @__env.GetStaticMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "getJetPlayer", "()Landroid/media/JetPlayer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getJetPlayer7302)) as android.media.JetPlayer;
		}
		public static int MaxTracks
		{
			get
			{
				return getMaxTracks();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaxTracks7303;
		public static int getMaxTracks()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.media.JetPlayer._getMaxTracks7303.native == global::System.IntPtr.Zero)
				global::android.media.JetPlayer._getMaxTracks7303 = @__env.GetStaticMethodIDNoThrow(global::android.media.JetPlayer.staticClass, "getMaxTracks", "()I");
			return @__env.CallStaticIntMethod(android.media.JetPlayer.staticClass, global::android.media.JetPlayer._getMaxTracks7303);
		}
		internal static global::MonoJavaBridge.MethodId _loadJetFile7304;
		public virtual bool loadJetFile(android.content.res.AssetFileDescriptor arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "loadJetFile", "(Landroid/content/res/AssetFileDescriptor;)Z", ref global::android.media.JetPlayer._loadJetFile7304, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _loadJetFile7305;
		public virtual bool loadJetFile(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "loadJetFile", "(Ljava/lang/String;)Z", ref global::android.media.JetPlayer._loadJetFile7305, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _closeJetFile7306;
		public virtual bool closeJetFile()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "closeJetFile", "()Z", ref global::android.media.JetPlayer._closeJetFile7306);
		}
		internal static global::MonoJavaBridge.MethodId _queueJetSegment7307;
		public virtual bool queueJetSegment(int arg0, int arg1, int arg2, int arg3, int arg4, byte arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "queueJetSegment", "(IIIIIB)Z", ref global::android.media.JetPlayer._queueJetSegment7307, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _queueJetSegmentMuteArray7308;
		public virtual bool queueJetSegmentMuteArray(int arg0, int arg1, int arg2, int arg3, bool[] arg4, byte arg5)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "queueJetSegmentMuteArray", "(IIII[ZB)Z", ref global::android.media.JetPlayer._queueJetSegmentMuteArray7308, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteFlags7309;
		public virtual bool setMuteFlags(int arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "setMuteFlags", "(IZ)Z", ref global::android.media.JetPlayer._setMuteFlags7309, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteArray7310;
		public virtual bool setMuteArray(bool[] arg0, bool arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "setMuteArray", "([ZZ)Z", ref global::android.media.JetPlayer._setMuteArray7310, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setMuteFlag7311;
		public virtual bool setMuteFlag(int arg0, bool arg1, bool arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "setMuteFlag", "(IZZ)Z", ref global::android.media.JetPlayer._setMuteFlag7311, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _triggerClip7312;
		public virtual bool triggerClip(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "triggerClip", "(I)Z", ref global::android.media.JetPlayer._triggerClip7312, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _clearQueue7313;
		public virtual bool clearQueue()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.JetPlayer.staticClass, "clearQueue", "()Z", ref global::android.media.JetPlayer._clearQueue7313);
		}
		public new global::android.media.JetPlayer.OnJetEventListener EventListener
		{
			set
			{
				setEventListener(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setEventListener7314;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;)V", ref global::android.media.JetPlayer._setEventListener7314, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEventListener7315;
		public virtual void setEventListener(android.media.JetPlayer.OnJetEventListener arg0, android.os.Handler arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.JetPlayer.staticClass, "setEventListener", "(Landroid/media/JetPlayer$OnJetEventListener;Landroid/os/Handler;)V", ref global::android.media.JetPlayer._setEventListener7315, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		static JetPlayer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.JetPlayer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/JetPlayer"));
		}
		internal static void InitJNI()
		{
		}
	}
}
