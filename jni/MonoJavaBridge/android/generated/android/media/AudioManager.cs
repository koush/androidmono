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
			internal static global::MonoJavaBridge.MethodId _onAudioFocusChange7037;
			void android.media.AudioManager.OnAudioFocusChangeListener.onAudioFocusChange(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange7037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass, global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange7037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static OnAudioFocusChangeListener_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioManager$OnAudioFocusChangeListener"));
				global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange7037 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass, "onAudioFocusChange", "(I)V");
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate void OnAudioFocusChangeListenerDelegate(int arg0);

		internal partial class OnAudioFocusChangeListenerDelegateWrapper : java.lang.Object, OnAudioFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected OnAudioFocusChangeListenerDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _OnAudioFocusChangeListenerDelegateWrapper7038;
			public OnAudioFocusChangeListenerDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper.staticClass, global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper._OnAudioFocusChangeListenerDelegateWrapper7038);
				Init(@__env, handle);
			}
			static OnAudioFocusChangeListenerDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioManager_OnAudioFocusChangeListenerDelegateWrapper"));
				global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper._OnAudioFocusChangeListenerDelegateWrapper7038 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper.staticClass, "<init>", "()V");
			}
			internal static void InitJNI()
			{
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
		internal static global::MonoJavaBridge.MethodId _getParameters7039;
		public virtual global::java.lang.String getParameters(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.media.AudioManager._getParameters7039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getParameters7039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setMode7040;
		public virtual void setMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setMode7040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMode7040, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMode7041;
		public virtual int getMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getMode7041);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getMode7041);
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect7042;
		public virtual void playSoundEffect(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._playSoundEffect7042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect7042, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect7043;
		public virtual void playSoundEffect(int arg0, float arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._playSoundEffect7043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect7043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new global::java.lang.String Parameters
		{
			set
			{
				setParameters(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setParameters7044;
		public virtual void setParameters(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setParameters7044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setParameters7044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adjustStreamVolume7045;
		public virtual void adjustStreamVolume(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustStreamVolume7045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustStreamVolume7045, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _adjustVolume7046;
		public virtual void adjustVolume(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustVolume7046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustVolume7046, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _adjustSuggestedStreamVolume7047;
		public virtual void adjustSuggestedStreamVolume(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustSuggestedStreamVolume7047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustSuggestedStreamVolume7047, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static global::MonoJavaBridge.MethodId _getRingerMode7048;
		public virtual int getRingerMode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getRingerMode7048);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRingerMode7048);
		}
		internal static global::MonoJavaBridge.MethodId _getStreamMaxVolume7049;
		public virtual int getStreamMaxVolume(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getStreamMaxVolume7049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamMaxVolume7049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStreamVolume7050;
		public virtual int getStreamVolume(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getStreamVolume7050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamVolume7050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRingerMode7051;
		public virtual void setRingerMode(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setRingerMode7051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRingerMode7051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamVolume7052;
		public virtual void setStreamVolume(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamVolume7052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamVolume7052, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamSolo7053;
		public virtual void setStreamSolo(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamSolo7053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamSolo7053, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamMute7054;
		public virtual void setStreamMute(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamMute7054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamMute7054, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shouldVibrate7055;
		public virtual bool shouldVibrate(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._shouldVibrate7055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._shouldVibrate7055, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVibrateSetting7056;
		public virtual int getVibrateSetting(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getVibrateSetting7056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getVibrateSetting7056, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVibrateSetting7057;
		public virtual void setVibrateSetting(int arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setVibrateSetting7057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setVibrateSetting7057, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		public new bool SpeakerphoneOn
		{
			set
			{
				setSpeakerphoneOn(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setSpeakerphoneOn7058;
		public virtual void setSpeakerphoneOn(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setSpeakerphoneOn7058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setSpeakerphoneOn7058, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpeakerphoneOn7059;
		public virtual bool isSpeakerphoneOn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isSpeakerphoneOn7059);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isSpeakerphoneOn7059);
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothScoAvailableOffCall7060;
		public virtual bool isBluetoothScoAvailableOffCall()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothScoAvailableOffCall7060);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoAvailableOffCall7060);
		}
		internal static global::MonoJavaBridge.MethodId _startBluetoothSco7061;
		public virtual void startBluetoothSco()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._startBluetoothSco7061);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._startBluetoothSco7061);
		}
		internal static global::MonoJavaBridge.MethodId _stopBluetoothSco7062;
		public virtual void stopBluetoothSco()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._stopBluetoothSco7062);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._stopBluetoothSco7062);
		}
		public new bool BluetoothScoOn
		{
			set
			{
				setBluetoothScoOn(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBluetoothScoOn7063;
		public virtual void setBluetoothScoOn(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setBluetoothScoOn7063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothScoOn7063, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothScoOn7064;
		public virtual bool isBluetoothScoOn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothScoOn7064);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoOn7064);
		}
		public new bool BluetoothA2dpOn
		{
			set
			{
				setBluetoothA2dpOn(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setBluetoothA2dpOn7065;
		public virtual void setBluetoothA2dpOn(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setBluetoothA2dpOn7065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothA2dpOn7065, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothA2dpOn7066;
		public virtual bool isBluetoothA2dpOn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothA2dpOn7066);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothA2dpOn7066);
		}
		public new bool WiredHeadsetOn
		{
			set
			{
				setWiredHeadsetOn(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setWiredHeadsetOn7067;
		public virtual void setWiredHeadsetOn(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setWiredHeadsetOn7067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setWiredHeadsetOn7067, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWiredHeadsetOn7068;
		public virtual bool isWiredHeadsetOn()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isWiredHeadsetOn7068);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isWiredHeadsetOn7068);
		}
		public new bool MicrophoneMute
		{
			set
			{
				setMicrophoneMute(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _setMicrophoneMute7069;
		public virtual void setMicrophoneMute(bool arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setMicrophoneMute7069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMicrophoneMute7069, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMicrophoneMute7070;
		public virtual bool isMicrophoneMute()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isMicrophoneMute7070);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMicrophoneMute7070);
		}
		internal static global::MonoJavaBridge.MethodId _setRouting7071;
		public virtual void setRouting(int arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setRouting7071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRouting7071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRouting7072;
		public virtual int getRouting(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getRouting7072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRouting7072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMusicActive7073;
		public virtual bool isMusicActive()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isMusicActive7073);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMusicActive7073);
		}
		internal static global::MonoJavaBridge.MethodId _loadSoundEffects7074;
		public virtual void loadSoundEffects()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._loadSoundEffects7074);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._loadSoundEffects7074);
		}
		internal static global::MonoJavaBridge.MethodId _unloadSoundEffects7075;
		public virtual void unloadSoundEffects()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._unloadSoundEffects7075);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unloadSoundEffects7075);
		}
		internal static global::MonoJavaBridge.MethodId _requestAudioFocus7076;
		public virtual int requestAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0, int arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._requestAudioFocus7076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._requestAudioFocus7076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		public int requestAudioFocus(global::android.media.AudioManager.OnAudioFocusChangeListenerDelegate arg0, int arg1, int arg2)
		{
			return requestAudioFocus((global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper)arg0, arg1, arg2);
		}
		internal static global::MonoJavaBridge.MethodId _abandonAudioFocus7077;
		public virtual int abandonAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._abandonAudioFocus7077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._abandonAudioFocus7077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public int abandonAudioFocus(global::android.media.AudioManager.OnAudioFocusChangeListenerDelegate arg0)
		{
			return abandonAudioFocus((global::android.media.AudioManager.OnAudioFocusChangeListenerDelegateWrapper)arg0);
		}
		internal static global::MonoJavaBridge.MethodId _registerMediaButtonEventReceiver7078;
		public virtual void registerMediaButtonEventReceiver(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._registerMediaButtonEventReceiver7078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._registerMediaButtonEventReceiver7078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterMediaButtonEventReceiver7079;
		public virtual void unregisterMediaButtonEventReceiver(android.content.ComponentName arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._unregisterMediaButtonEventReceiver7079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unregisterMediaButtonEventReceiver7079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.media.AudioManager._getParameters7039 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getParameters", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.media.AudioManager._setMode7040 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setMode", "(I)V");
			global::android.media.AudioManager._getMode7041 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getMode", "()I");
			global::android.media.AudioManager._playSoundEffect7042 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "playSoundEffect", "(I)V");
			global::android.media.AudioManager._playSoundEffect7043 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "playSoundEffect", "(IF)V");
			global::android.media.AudioManager._setParameters7044 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setParameters", "(Ljava/lang/String;)V");
			global::android.media.AudioManager._adjustStreamVolume7045 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustStreamVolume", "(III)V");
			global::android.media.AudioManager._adjustVolume7046 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustVolume", "(II)V");
			global::android.media.AudioManager._adjustSuggestedStreamVolume7047 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustSuggestedStreamVolume", "(III)V");
			global::android.media.AudioManager._getRingerMode7048 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getRingerMode", "()I");
			global::android.media.AudioManager._getStreamMaxVolume7049 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getStreamMaxVolume", "(I)I");
			global::android.media.AudioManager._getStreamVolume7050 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getStreamVolume", "(I)I");
			global::android.media.AudioManager._setRingerMode7051 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setRingerMode", "(I)V");
			global::android.media.AudioManager._setStreamVolume7052 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamVolume", "(III)V");
			global::android.media.AudioManager._setStreamSolo7053 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamSolo", "(IZ)V");
			global::android.media.AudioManager._setStreamMute7054 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamMute", "(IZ)V");
			global::android.media.AudioManager._shouldVibrate7055 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "shouldVibrate", "(I)Z");
			global::android.media.AudioManager._getVibrateSetting7056 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getVibrateSetting", "(I)I");
			global::android.media.AudioManager._setVibrateSetting7057 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setVibrateSetting", "(II)V");
			global::android.media.AudioManager._setSpeakerphoneOn7058 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setSpeakerphoneOn", "(Z)V");
			global::android.media.AudioManager._isSpeakerphoneOn7059 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isSpeakerphoneOn", "()Z");
			global::android.media.AudioManager._isBluetoothScoAvailableOffCall7060 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothScoAvailableOffCall", "()Z");
			global::android.media.AudioManager._startBluetoothSco7061 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "startBluetoothSco", "()V");
			global::android.media.AudioManager._stopBluetoothSco7062 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "stopBluetoothSco", "()V");
			global::android.media.AudioManager._setBluetoothScoOn7063 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setBluetoothScoOn", "(Z)V");
			global::android.media.AudioManager._isBluetoothScoOn7064 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothScoOn", "()Z");
			global::android.media.AudioManager._setBluetoothA2dpOn7065 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setBluetoothA2dpOn", "(Z)V");
			global::android.media.AudioManager._isBluetoothA2dpOn7066 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothA2dpOn", "()Z");
			global::android.media.AudioManager._setWiredHeadsetOn7067 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setWiredHeadsetOn", "(Z)V");
			global::android.media.AudioManager._isWiredHeadsetOn7068 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isWiredHeadsetOn", "()Z");
			global::android.media.AudioManager._setMicrophoneMute7069 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setMicrophoneMute", "(Z)V");
			global::android.media.AudioManager._isMicrophoneMute7070 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isMicrophoneMute", "()Z");
			global::android.media.AudioManager._setRouting7071 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setRouting", "(III)V");
			global::android.media.AudioManager._getRouting7072 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getRouting", "(I)I");
			global::android.media.AudioManager._isMusicActive7073 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isMusicActive", "()Z");
			global::android.media.AudioManager._loadSoundEffects7074 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "loadSoundEffects", "()V");
			global::android.media.AudioManager._unloadSoundEffects7075 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "unloadSoundEffects", "()V");
			global::android.media.AudioManager._requestAudioFocus7076 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "requestAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;II)I");
			global::android.media.AudioManager._abandonAudioFocus7077 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "abandonAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;)I");
			global::android.media.AudioManager._registerMediaButtonEventReceiver7078 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "registerMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V");
			global::android.media.AudioManager._unregisterMediaButtonEventReceiver7079 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "unregisterMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V");
		}
		internal static void InitJNI()
		{
		}
	}
}
