namespace android.media
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class AudioManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AudioManager()
		{
			InitJNI();
		}
		protected AudioManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.media.AudioManager.OnAudioFocusChangeListener_))]
		public interface OnAudioFocusChangeListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onAudioFocusChange(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.media.AudioManager.OnAudioFocusChangeListener))]
		public sealed partial class OnAudioFocusChangeListener_ : java.lang.Object, OnAudioFocusChangeListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnAudioFocusChangeListener_()
			{
				InitJNI();
			}
			internal OnAudioFocusChangeListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onAudioFocusChange4824;
			 void android.media.AudioManager.OnAudioFocusChangeListener.onAudioFocusChange(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange4824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass, global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange4824, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioManager$OnAudioFocusChangeListener"));
				global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange4824 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass, "onAudioFocusChange", "(I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters4825;
		public virtual global::java.lang.String getParameters(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.media.AudioManager._getParameters4825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getParameters4825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setMode4826;
		public virtual void setMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setMode4826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMode4826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMode4827;
		public virtual int getMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getMode4827);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getMode4827);
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect4828;
		public virtual void playSoundEffect(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._playSoundEffect4828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect4828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect4829;
		public virtual void playSoundEffect(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._playSoundEffect4829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect4829, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setParameters4830;
		public virtual void setParameters(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setParameters4830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setParameters4830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adjustStreamVolume4831;
		public virtual void adjustStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustStreamVolume4831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustStreamVolume4831, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _adjustVolume4832;
		public virtual void adjustVolume(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustVolume4832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustVolume4832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _adjustSuggestedStreamVolume4833;
		public virtual void adjustSuggestedStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustSuggestedStreamVolume4833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustSuggestedStreamVolume4833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static global::MonoJavaBridge.MethodId _getRingerMode4834;
		public virtual int getRingerMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getRingerMode4834);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRingerMode4834);
		}
		internal static global::MonoJavaBridge.MethodId _getStreamMaxVolume4835;
		public virtual int getStreamMaxVolume(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getStreamMaxVolume4835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamMaxVolume4835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStreamVolume4836;
		public virtual int getStreamVolume(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getStreamVolume4836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamVolume4836, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRingerMode4837;
		public virtual void setRingerMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setRingerMode4837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRingerMode4837, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamVolume4838;
		public virtual void setStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamVolume4838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamVolume4838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamSolo4839;
		public virtual void setStreamSolo(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamSolo4839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamSolo4839, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamMute4840;
		public virtual void setStreamMute(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamMute4840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamMute4840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shouldVibrate4841;
		public virtual bool shouldVibrate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._shouldVibrate4841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._shouldVibrate4841, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVibrateSetting4842;
		public virtual int getVibrateSetting(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getVibrateSetting4842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getVibrateSetting4842, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVibrateSetting4843;
		public virtual void setVibrateSetting(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setVibrateSetting4843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setVibrateSetting4843, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSpeakerphoneOn4844;
		public virtual void setSpeakerphoneOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setSpeakerphoneOn4844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setSpeakerphoneOn4844, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpeakerphoneOn4845;
		public virtual bool isSpeakerphoneOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isSpeakerphoneOn4845);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isSpeakerphoneOn4845);
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothScoAvailableOffCall4846;
		public virtual bool isBluetoothScoAvailableOffCall() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothScoAvailableOffCall4846);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoAvailableOffCall4846);
		}
		internal static global::MonoJavaBridge.MethodId _startBluetoothSco4847;
		public virtual void startBluetoothSco() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._startBluetoothSco4847);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._startBluetoothSco4847);
		}
		internal static global::MonoJavaBridge.MethodId _stopBluetoothSco4848;
		public virtual void stopBluetoothSco() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._stopBluetoothSco4848);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._stopBluetoothSco4848);
		}
		internal static global::MonoJavaBridge.MethodId _setBluetoothScoOn4849;
		public virtual void setBluetoothScoOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setBluetoothScoOn4849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothScoOn4849, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothScoOn4850;
		public virtual bool isBluetoothScoOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothScoOn4850);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoOn4850);
		}
		internal static global::MonoJavaBridge.MethodId _setBluetoothA2dpOn4851;
		public virtual void setBluetoothA2dpOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setBluetoothA2dpOn4851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothA2dpOn4851, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothA2dpOn4852;
		public virtual bool isBluetoothA2dpOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothA2dpOn4852);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothA2dpOn4852);
		}
		internal static global::MonoJavaBridge.MethodId _setWiredHeadsetOn4853;
		public virtual void setWiredHeadsetOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setWiredHeadsetOn4853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setWiredHeadsetOn4853, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWiredHeadsetOn4854;
		public virtual bool isWiredHeadsetOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isWiredHeadsetOn4854);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isWiredHeadsetOn4854);
		}
		internal static global::MonoJavaBridge.MethodId _setMicrophoneMute4855;
		public virtual void setMicrophoneMute(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setMicrophoneMute4855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMicrophoneMute4855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMicrophoneMute4856;
		public virtual bool isMicrophoneMute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isMicrophoneMute4856);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMicrophoneMute4856);
		}
		internal static global::MonoJavaBridge.MethodId _setRouting4857;
		public virtual void setRouting(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setRouting4857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRouting4857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRouting4858;
		public virtual int getRouting(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getRouting4858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRouting4858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMusicActive4859;
		public virtual bool isMusicActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isMusicActive4859);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMusicActive4859);
		}
		internal static global::MonoJavaBridge.MethodId _loadSoundEffects4860;
		public virtual void loadSoundEffects() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._loadSoundEffects4860);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._loadSoundEffects4860);
		}
		internal static global::MonoJavaBridge.MethodId _unloadSoundEffects4861;
		public virtual void unloadSoundEffects() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._unloadSoundEffects4861);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unloadSoundEffects4861);
		}
		internal static global::MonoJavaBridge.MethodId _requestAudioFocus4862;
		public virtual int requestAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._requestAudioFocus4862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._requestAudioFocus4862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _abandonAudioFocus4863;
		public virtual int abandonAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._abandonAudioFocus4863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._abandonAudioFocus4863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerMediaButtonEventReceiver4864;
		public virtual void registerMediaButtonEventReceiver(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._registerMediaButtonEventReceiver4864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._registerMediaButtonEventReceiver4864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterMediaButtonEventReceiver4865;
		public virtual void unregisterMediaButtonEventReceiver(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._unregisterMediaButtonEventReceiver4865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unregisterMediaButtonEventReceiver4865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.media.AudioManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioManager"));
			global::android.media.AudioManager._getParameters4825 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getParameters", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.media.AudioManager._setMode4826 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setMode", "(I)V");
			global::android.media.AudioManager._getMode4827 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getMode", "()I");
			global::android.media.AudioManager._playSoundEffect4828 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "playSoundEffect", "(I)V");
			global::android.media.AudioManager._playSoundEffect4829 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "playSoundEffect", "(IF)V");
			global::android.media.AudioManager._setParameters4830 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setParameters", "(Ljava/lang/String;)V");
			global::android.media.AudioManager._adjustStreamVolume4831 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustStreamVolume", "(III)V");
			global::android.media.AudioManager._adjustVolume4832 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustVolume", "(II)V");
			global::android.media.AudioManager._adjustSuggestedStreamVolume4833 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustSuggestedStreamVolume", "(III)V");
			global::android.media.AudioManager._getRingerMode4834 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getRingerMode", "()I");
			global::android.media.AudioManager._getStreamMaxVolume4835 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getStreamMaxVolume", "(I)I");
			global::android.media.AudioManager._getStreamVolume4836 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getStreamVolume", "(I)I");
			global::android.media.AudioManager._setRingerMode4837 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setRingerMode", "(I)V");
			global::android.media.AudioManager._setStreamVolume4838 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamVolume", "(III)V");
			global::android.media.AudioManager._setStreamSolo4839 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamSolo", "(IZ)V");
			global::android.media.AudioManager._setStreamMute4840 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamMute", "(IZ)V");
			global::android.media.AudioManager._shouldVibrate4841 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "shouldVibrate", "(I)Z");
			global::android.media.AudioManager._getVibrateSetting4842 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getVibrateSetting", "(I)I");
			global::android.media.AudioManager._setVibrateSetting4843 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setVibrateSetting", "(II)V");
			global::android.media.AudioManager._setSpeakerphoneOn4844 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setSpeakerphoneOn", "(Z)V");
			global::android.media.AudioManager._isSpeakerphoneOn4845 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isSpeakerphoneOn", "()Z");
			global::android.media.AudioManager._isBluetoothScoAvailableOffCall4846 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothScoAvailableOffCall", "()Z");
			global::android.media.AudioManager._startBluetoothSco4847 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "startBluetoothSco", "()V");
			global::android.media.AudioManager._stopBluetoothSco4848 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "stopBluetoothSco", "()V");
			global::android.media.AudioManager._setBluetoothScoOn4849 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setBluetoothScoOn", "(Z)V");
			global::android.media.AudioManager._isBluetoothScoOn4850 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothScoOn", "()Z");
			global::android.media.AudioManager._setBluetoothA2dpOn4851 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setBluetoothA2dpOn", "(Z)V");
			global::android.media.AudioManager._isBluetoothA2dpOn4852 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothA2dpOn", "()Z");
			global::android.media.AudioManager._setWiredHeadsetOn4853 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setWiredHeadsetOn", "(Z)V");
			global::android.media.AudioManager._isWiredHeadsetOn4854 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isWiredHeadsetOn", "()Z");
			global::android.media.AudioManager._setMicrophoneMute4855 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setMicrophoneMute", "(Z)V");
			global::android.media.AudioManager._isMicrophoneMute4856 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isMicrophoneMute", "()Z");
			global::android.media.AudioManager._setRouting4857 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setRouting", "(III)V");
			global::android.media.AudioManager._getRouting4858 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getRouting", "(I)I");
			global::android.media.AudioManager._isMusicActive4859 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isMusicActive", "()Z");
			global::android.media.AudioManager._loadSoundEffects4860 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "loadSoundEffects", "()V");
			global::android.media.AudioManager._unloadSoundEffects4861 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "unloadSoundEffects", "()V");
			global::android.media.AudioManager._requestAudioFocus4862 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "requestAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;II)I");
			global::android.media.AudioManager._abandonAudioFocus4863 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "abandonAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;)I");
			global::android.media.AudioManager._registerMediaButtonEventReceiver4864 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "registerMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V");
			global::android.media.AudioManager._unregisterMediaButtonEventReceiver4865 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "unregisterMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V");
		}
	}
}
