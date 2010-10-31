namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AudioManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AudioManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.AudioManager.OnAudioFocusChangeListener_))]
		public partial interface OnAudioFocusChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onAudioFocusChange(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.AudioManager.OnAudioFocusChangeListener))]
		internal sealed partial class OnAudioFocusChangeListener_ : java.lang.Object, OnAudioFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal OnAudioFocusChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			void android.media.AudioManager.OnAudioFocusChangeListener.onAudioFocusChange(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass, "onAudioFocusChange", "(I)V", ref global::android.media.AudioManager.OnAudioFocusChangeListener_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnAudioFocusChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioManager$OnAudioFocusChangeListener"));
			}
		}

		public delegate void OnAudioFocusChangeListenerDelegate(int arg0);

		internal partial class OnAudioFocusChangeListenerDelegateWrapper : java.lang.Object, OnAudioFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnAudioFocusChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public OnAudioFocusChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper.staticClass, global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static OnAudioFocusChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioManager_OnAudioFocusChangeListenerDelegateWrapper"));
			}
		}
		internal partial class OnAudioFocusChangeListenerDelegateWrapper
		{
			private OnAudioFocusChangeListenerDelegate myDelegate;
			public void onAudioFocusChange(int arg0)
			{
				myDelegate(arg0);
			}
			public static implicit operator OnAudioFocusChangeListenerDelegateWrapper(OnAudioFocusChangeListenerDelegate d)
			{
				global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper ret = new global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.String getParameters(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.media.AudioManager.staticClass, "getParameters", "(Ljava/lang/String;)Ljava/lang/String;", ref global::android.media.AudioManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void setMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setMode", "(I)V", ref global::android.media.AudioManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int Mode
		{
			get
			{
				return getMode();
			}
			set
			{
				setMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioManager.staticClass, "getMode", "()I", ref global::android.media.AudioManager._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void playSoundEffect(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "playSoundEffect", "(I)V", ref global::android.media.AudioManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void playSoundEffect(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "playSoundEffect", "(IF)V", ref global::android.media.AudioManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Parameters
		{
			set
			{
				setParameters(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void setParameters(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setParameters", "(Ljava/lang/String;)V", ref global::android.media.AudioManager._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void adjustStreamVolume(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "adjustStreamVolume", "(III)V", ref global::android.media.AudioManager._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void adjustVolume(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "adjustVolume", "(II)V", ref global::android.media.AudioManager._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void adjustSuggestedStreamVolume(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "adjustSuggestedStreamVolume", "(III)V", ref global::android.media.AudioManager._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public new int RingerMode
		{
			get
			{
				return getRingerMode();
			}
			set
			{
				setRingerMode(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual int getRingerMode()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioManager.staticClass, "getRingerMode", "()I", ref global::android.media.AudioManager._m9);
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getStreamMaxVolume(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioManager.staticClass, "getStreamMaxVolume", "(I)I", ref global::android.media.AudioManager._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual int getStreamVolume(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioManager.staticClass, "getStreamVolume", "(I)I", ref global::android.media.AudioManager._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual void setRingerMode(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setRingerMode", "(I)V", ref global::android.media.AudioManager._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual void setStreamVolume(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setStreamVolume", "(III)V", ref global::android.media.AudioManager._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setStreamSolo(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setStreamSolo", "(IZ)V", ref global::android.media.AudioManager._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setStreamMute(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setStreamMute", "(IZ)V", ref global::android.media.AudioManager._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public virtual bool shouldVibrate(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.AudioManager.staticClass, "shouldVibrate", "(I)Z", ref global::android.media.AudioManager._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public virtual int getVibrateSetting(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioManager.staticClass, "getVibrateSetting", "(I)I", ref global::android.media.AudioManager._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		public virtual void setVibrateSetting(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setVibrateSetting", "(II)V", ref global::android.media.AudioManager._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool SpeakerphoneOn
		{
			set
			{
				setSpeakerphoneOn(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public virtual void setSpeakerphoneOn(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setSpeakerphoneOn", "(Z)V", ref global::android.media.AudioManager._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual bool isSpeakerphoneOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.AudioManager.staticClass, "isSpeakerphoneOn", "()Z", ref global::android.media.AudioManager._m20);
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual bool isBluetoothScoAvailableOffCall()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.AudioManager.staticClass, "isBluetoothScoAvailableOffCall", "()Z", ref global::android.media.AudioManager._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void startBluetoothSco()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "startBluetoothSco", "()V", ref global::android.media.AudioManager._m22);
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void stopBluetoothSco()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "stopBluetoothSco", "()V", ref global::android.media.AudioManager._m23);
		}
		public new bool BluetoothScoOn
		{
			set
			{
				setBluetoothScoOn(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setBluetoothScoOn(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setBluetoothScoOn", "(Z)V", ref global::android.media.AudioManager._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool isBluetoothScoOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.AudioManager.staticClass, "isBluetoothScoOn", "()Z", ref global::android.media.AudioManager._m25);
		}
		public new bool BluetoothA2dpOn
		{
			set
			{
				setBluetoothA2dpOn(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual void setBluetoothA2dpOn(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setBluetoothA2dpOn", "(Z)V", ref global::android.media.AudioManager._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool isBluetoothA2dpOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.AudioManager.staticClass, "isBluetoothA2dpOn", "()Z", ref global::android.media.AudioManager._m27);
		}
		public new bool WiredHeadsetOn
		{
			set
			{
				setWiredHeadsetOn(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual void setWiredHeadsetOn(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setWiredHeadsetOn", "(Z)V", ref global::android.media.AudioManager._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool isWiredHeadsetOn()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.AudioManager.staticClass, "isWiredHeadsetOn", "()Z", ref global::android.media.AudioManager._m29);
		}
		public new bool MicrophoneMute
		{
			set
			{
				setMicrophoneMute(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual void setMicrophoneMute(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setMicrophoneMute", "(Z)V", ref global::android.media.AudioManager._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual bool isMicrophoneMute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.AudioManager.staticClass, "isMicrophoneMute", "()Z", ref global::android.media.AudioManager._m31);
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public virtual void setRouting(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "setRouting", "(III)V", ref global::android.media.AudioManager._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual int getRouting(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioManager.staticClass, "getRouting", "(I)I", ref global::android.media.AudioManager._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual bool isMusicActive()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.media.AudioManager.staticClass, "isMusicActive", "()Z", ref global::android.media.AudioManager._m34);
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual void loadSoundEffects()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "loadSoundEffects", "()V", ref global::android.media.AudioManager._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void unloadSoundEffects()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "unloadSoundEffects", "()V", ref global::android.media.AudioManager._m36);
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual int requestAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0, int arg1, int arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioManager.staticClass, "requestAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;II)I", ref global::android.media.AudioManager._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public int requestAudioFocus(global::android.media.AudioManager.OnAudioFocusChangeListenerDelegate arg0, int arg1, int arg2)
		{
			return requestAudioFocus((global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper)arg0, arg1, arg2);
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual int abandonAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.media.AudioManager.staticClass, "abandonAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;)I", ref global::android.media.AudioManager._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public int abandonAudioFocus(global::android.media.AudioManager.OnAudioFocusChangeListenerDelegate arg0)
		{
			return abandonAudioFocus((global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public virtual void registerMediaButtonEventReceiver(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "registerMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V", ref global::android.media.AudioManager._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual void unregisterMediaButtonEventReceiver(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.media.AudioManager.staticClass, "unregisterMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V", ref global::android.media.AudioManager._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String ACTION_AUDIO_BECOMING_NOISY
		{
			get
			{
				return "android.media.AUDIO_BECOMING_NOISY";
			}
		}
		public static global::java.lang.String RINGER_MODE_CHANGED_ACTION
		{
			get
			{
				return "android.media.RINGER_MODE_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_RINGER_MODE
		{
			get
			{
				return "android.media.EXTRA_RINGER_MODE";
			}
		}
		public static global::java.lang.String VIBRATE_SETTING_CHANGED_ACTION
		{
			get
			{
				return "android.media.VIBRATE_SETTING_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_VIBRATE_SETTING
		{
			get
			{
				return "android.media.EXTRA_VIBRATE_SETTING";
			}
		}
		public static global::java.lang.String EXTRA_VIBRATE_TYPE
		{
			get
			{
				return "android.media.EXTRA_VIBRATE_TYPE";
			}
		}
		public static int STREAM_VOICE_CALL
		{
			get
			{
				return 0;
			}
		}
		public static int STREAM_SYSTEM
		{
			get
			{
				return 1;
			}
		}
		public static int STREAM_RING
		{
			get
			{
				return 2;
			}
		}
		public static int STREAM_MUSIC
		{
			get
			{
				return 3;
			}
		}
		public static int STREAM_ALARM
		{
			get
			{
				return 4;
			}
		}
		public static int STREAM_NOTIFICATION
		{
			get
			{
				return 5;
			}
		}
		public static int STREAM_DTMF
		{
			get
			{
				return 8;
			}
		}
		public static int NUM_STREAMS
		{
			get
			{
				return 5;
			}
		}
		public static int ADJUST_RAISE
		{
			get
			{
				return 1;
			}
		}
		public static int ADJUST_LOWER
		{
			get
			{
				return -1;
			}
		}
		public static int ADJUST_SAME
		{
			get
			{
				return 0;
			}
		}
		public static int FLAG_SHOW_UI
		{
			get
			{
				return 1;
			}
		}
		public static int FLAG_ALLOW_RINGER_MODES
		{
			get
			{
				return 2;
			}
		}
		public static int FLAG_PLAY_SOUND
		{
			get
			{
				return 4;
			}
		}
		public static int FLAG_REMOVE_SOUND_AND_VIBRATE
		{
			get
			{
				return 8;
			}
		}
		public static int FLAG_VIBRATE
		{
			get
			{
				return 16;
			}
		}
		public static int RINGER_MODE_SILENT
		{
			get
			{
				return 0;
			}
		}
		public static int RINGER_MODE_VIBRATE
		{
			get
			{
				return 1;
			}
		}
		public static int RINGER_MODE_NORMAL
		{
			get
			{
				return 2;
			}
		}
		public static int VIBRATE_TYPE_RINGER
		{
			get
			{
				return 0;
			}
		}
		public static int VIBRATE_TYPE_NOTIFICATION
		{
			get
			{
				return 1;
			}
		}
		public static int VIBRATE_SETTING_OFF
		{
			get
			{
				return 0;
			}
		}
		public static int VIBRATE_SETTING_ON
		{
			get
			{
				return 1;
			}
		}
		public static int VIBRATE_SETTING_ONLY_SILENT
		{
			get
			{
				return 2;
			}
		}
		public static int USE_DEFAULT_STREAM_TYPE
		{
			get
			{
				return -2147483648;
			}
		}
		public static global::java.lang.String ACTION_SCO_AUDIO_STATE_CHANGED
		{
			get
			{
				return "android.media.SCO_AUDIO_STATE_CHANGED";
			}
		}
		public static global::java.lang.String EXTRA_SCO_AUDIO_STATE
		{
			get
			{
				return "android.media.extra.SCO_AUDIO_STATE";
			}
		}
		public static int SCO_AUDIO_STATE_DISCONNECTED
		{
			get
			{
				return 0;
			}
		}
		public static int SCO_AUDIO_STATE_CONNECTED
		{
			get
			{
				return 1;
			}
		}
		public static int SCO_AUDIO_STATE_ERROR
		{
			get
			{
				return -1;
			}
		}
		public static int MODE_INVALID
		{
			get
			{
				return -2;
			}
		}
		public static int MODE_CURRENT
		{
			get
			{
				return -1;
			}
		}
		public static int MODE_NORMAL
		{
			get
			{
				return 0;
			}
		}
		public static int MODE_RINGTONE
		{
			get
			{
				return 1;
			}
		}
		public static int MODE_IN_CALL
		{
			get
			{
				return 2;
			}
		}
		public static int ROUTE_EARPIECE
		{
			get
			{
				return 1;
			}
		}
		public static int ROUTE_SPEAKER
		{
			get
			{
				return 2;
			}
		}
		public static int ROUTE_BLUETOOTH
		{
			get
			{
				return 4;
			}
		}
		public static int ROUTE_BLUETOOTH_SCO
		{
			get
			{
				return 4;
			}
		}
		public static int ROUTE_HEADSET
		{
			get
			{
				return 8;
			}
		}
		public static int ROUTE_BLUETOOTH_A2DP
		{
			get
			{
				return 16;
			}
		}
		public static int ROUTE_ALL
		{
			get
			{
				return -1;
			}
		}
		public static int FX_KEY_CLICK
		{
			get
			{
				return 0;
			}
		}
		public static int FX_FOCUS_NAVIGATION_UP
		{
			get
			{
				return 1;
			}
		}
		public static int FX_FOCUS_NAVIGATION_DOWN
		{
			get
			{
				return 2;
			}
		}
		public static int FX_FOCUS_NAVIGATION_LEFT
		{
			get
			{
				return 3;
			}
		}
		public static int FX_FOCUS_NAVIGATION_RIGHT
		{
			get
			{
				return 4;
			}
		}
		public static int FX_KEYPRESS_STANDARD
		{
			get
			{
				return 5;
			}
		}
		public static int FX_KEYPRESS_SPACEBAR
		{
			get
			{
				return 6;
			}
		}
		public static int FX_KEYPRESS_DELETE
		{
			get
			{
				return 7;
			}
		}
		public static int FX_KEYPRESS_RETURN
		{
			get
			{
				return 8;
			}
		}
		public static int AUDIOFOCUS_GAIN
		{
			get
			{
				return 1;
			}
		}
		public static int AUDIOFOCUS_GAIN_TRANSIENT
		{
			get
			{
				return 2;
			}
		}
		public static int AUDIOFOCUS_GAIN_TRANSIENT_MAY_DUCK
		{
			get
			{
				return 3;
			}
		}
		public static int AUDIOFOCUS_LOSS
		{
			get
			{
				return -1;
			}
		}
		public static int AUDIOFOCUS_LOSS_TRANSIENT
		{
			get
			{
				return -2;
			}
		}
		public static int AUDIOFOCUS_LOSS_TRANSIENT_CAN_DUCK
		{
			get
			{
				return -3;
			}
		}
		public static int AUDIOFOCUS_REQUEST_FAILED
		{
			get
			{
				return 0;
			}
		}
		public static int AUDIOFOCUS_REQUEST_GRANTED
		{
			get
			{
				return 1;
			}
		}
		static AudioManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.AudioManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioManager"));
		}
	}
}
