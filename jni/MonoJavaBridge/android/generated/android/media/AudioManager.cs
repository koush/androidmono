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
			internal static global::MonoJavaBridge.MethodId _onAudioFocusChange7010;
			 void android.media.AudioManager.OnAudioFocusChangeListener.onAudioFocusChange(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange7010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass, global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange7010, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/media/AudioManager$OnAudioFocusChangeListener"));
				global::android.media.AudioManager.OnAudioFocusChangeListener_._onAudioFocusChange7010 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.OnAudioFocusChangeListener_.staticClass, "onAudioFocusChange", "(I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getParameters7011;
		public virtual global::java.lang.String getParameters(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.media.AudioManager._getParameters7011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getParameters7011, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _setMode7012;
		public virtual void setMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setMode7012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMode7012, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getMode7013;
		public virtual int getMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getMode7013);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getMode7013);
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect7014;
		public virtual void playSoundEffect(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._playSoundEffect7014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect7014, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _playSoundEffect7015;
		public virtual void playSoundEffect(int arg0, float arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._playSoundEffect7015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect7015, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setParameters7016;
		public virtual void setParameters(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setParameters7016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setParameters7016, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _adjustStreamVolume7017;
		public virtual void adjustStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustStreamVolume7017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustStreamVolume7017, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _adjustVolume7018;
		public virtual void adjustVolume(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustVolume7018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustVolume7018, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _adjustSuggestedStreamVolume7019;
		public virtual void adjustSuggestedStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._adjustSuggestedStreamVolume7019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustSuggestedStreamVolume7019, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
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
		internal static global::MonoJavaBridge.MethodId _getRingerMode7020;
		public virtual int getRingerMode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getRingerMode7020);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRingerMode7020);
		}
		internal static global::MonoJavaBridge.MethodId _getStreamMaxVolume7021;
		public virtual int getStreamMaxVolume(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getStreamMaxVolume7021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamMaxVolume7021, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getStreamVolume7022;
		public virtual int getStreamVolume(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getStreamVolume7022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamVolume7022, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRingerMode7023;
		public virtual void setRingerMode(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setRingerMode7023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRingerMode7023, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamVolume7024;
		public virtual void setStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamVolume7024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamVolume7024, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamSolo7025;
		public virtual void setStreamSolo(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamSolo7025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamSolo7025, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setStreamMute7026;
		public virtual void setStreamMute(int arg0, bool arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setStreamMute7026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamMute7026, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _shouldVibrate7027;
		public virtual bool shouldVibrate(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._shouldVibrate7027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._shouldVibrate7027, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _getVibrateSetting7028;
		public virtual int getVibrateSetting(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getVibrateSetting7028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getVibrateSetting7028, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setVibrateSetting7029;
		public virtual void setVibrateSetting(int arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setVibrateSetting7029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setVibrateSetting7029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _setSpeakerphoneOn7030;
		public virtual void setSpeakerphoneOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setSpeakerphoneOn7030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setSpeakerphoneOn7030, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isSpeakerphoneOn7031;
		public virtual bool isSpeakerphoneOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isSpeakerphoneOn7031);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isSpeakerphoneOn7031);
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothScoAvailableOffCall7032;
		public virtual bool isBluetoothScoAvailableOffCall() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothScoAvailableOffCall7032);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoAvailableOffCall7032);
		}
		internal static global::MonoJavaBridge.MethodId _startBluetoothSco7033;
		public virtual void startBluetoothSco() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._startBluetoothSco7033);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._startBluetoothSco7033);
		}
		internal static global::MonoJavaBridge.MethodId _stopBluetoothSco7034;
		public virtual void stopBluetoothSco() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._stopBluetoothSco7034);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._stopBluetoothSco7034);
		}
		internal static global::MonoJavaBridge.MethodId _setBluetoothScoOn7035;
		public virtual void setBluetoothScoOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setBluetoothScoOn7035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothScoOn7035, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothScoOn7036;
		public virtual bool isBluetoothScoOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothScoOn7036);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoOn7036);
		}
		internal static global::MonoJavaBridge.MethodId _setBluetoothA2dpOn7037;
		public virtual void setBluetoothA2dpOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setBluetoothA2dpOn7037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothA2dpOn7037, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isBluetoothA2dpOn7038;
		public virtual bool isBluetoothA2dpOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isBluetoothA2dpOn7038);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothA2dpOn7038);
		}
		internal static global::MonoJavaBridge.MethodId _setWiredHeadsetOn7039;
		public virtual void setWiredHeadsetOn(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setWiredHeadsetOn7039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setWiredHeadsetOn7039, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isWiredHeadsetOn7040;
		public virtual bool isWiredHeadsetOn() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isWiredHeadsetOn7040);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isWiredHeadsetOn7040);
		}
		internal static global::MonoJavaBridge.MethodId _setMicrophoneMute7041;
		public virtual void setMicrophoneMute(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setMicrophoneMute7041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMicrophoneMute7041, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMicrophoneMute7042;
		public virtual bool isMicrophoneMute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isMicrophoneMute7042);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMicrophoneMute7042);
		}
		internal static global::MonoJavaBridge.MethodId _setRouting7043;
		public virtual void setRouting(int arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._setRouting7043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRouting7043, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _getRouting7044;
		public virtual int getRouting(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._getRouting7044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRouting7044, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isMusicActive7045;
		public virtual bool isMusicActive() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.media.AudioManager._isMusicActive7045);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMusicActive7045);
		}
		internal static global::MonoJavaBridge.MethodId _loadSoundEffects7046;
		public virtual void loadSoundEffects() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._loadSoundEffects7046);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._loadSoundEffects7046);
		}
		internal static global::MonoJavaBridge.MethodId _unloadSoundEffects7047;
		public virtual void unloadSoundEffects() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._unloadSoundEffects7047);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unloadSoundEffects7047);
		}
		internal static global::MonoJavaBridge.MethodId _requestAudioFocus7048;
		public virtual int requestAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0, int arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._requestAudioFocus7048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._requestAudioFocus7048, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _abandonAudioFocus7049;
		public virtual int abandonAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.media.AudioManager._abandonAudioFocus7049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._abandonAudioFocus7049, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _registerMediaButtonEventReceiver7050;
		public virtual void registerMediaButtonEventReceiver(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._registerMediaButtonEventReceiver7050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._registerMediaButtonEventReceiver7050, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _unregisterMediaButtonEventReceiver7051;
		public virtual void unregisterMediaButtonEventReceiver(android.content.ComponentName arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.media.AudioManager._unregisterMediaButtonEventReceiver7051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unregisterMediaButtonEventReceiver7051, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
			global::android.media.AudioManager._getParameters7011 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getParameters", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.media.AudioManager._setMode7012 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setMode", "(I)V");
			global::android.media.AudioManager._getMode7013 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getMode", "()I");
			global::android.media.AudioManager._playSoundEffect7014 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "playSoundEffect", "(I)V");
			global::android.media.AudioManager._playSoundEffect7015 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "playSoundEffect", "(IF)V");
			global::android.media.AudioManager._setParameters7016 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setParameters", "(Ljava/lang/String;)V");
			global::android.media.AudioManager._adjustStreamVolume7017 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustStreamVolume", "(III)V");
			global::android.media.AudioManager._adjustVolume7018 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustVolume", "(II)V");
			global::android.media.AudioManager._adjustSuggestedStreamVolume7019 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "adjustSuggestedStreamVolume", "(III)V");
			global::android.media.AudioManager._getRingerMode7020 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getRingerMode", "()I");
			global::android.media.AudioManager._getStreamMaxVolume7021 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getStreamMaxVolume", "(I)I");
			global::android.media.AudioManager._getStreamVolume7022 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getStreamVolume", "(I)I");
			global::android.media.AudioManager._setRingerMode7023 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setRingerMode", "(I)V");
			global::android.media.AudioManager._setStreamVolume7024 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamVolume", "(III)V");
			global::android.media.AudioManager._setStreamSolo7025 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamSolo", "(IZ)V");
			global::android.media.AudioManager._setStreamMute7026 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setStreamMute", "(IZ)V");
			global::android.media.AudioManager._shouldVibrate7027 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "shouldVibrate", "(I)Z");
			global::android.media.AudioManager._getVibrateSetting7028 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getVibrateSetting", "(I)I");
			global::android.media.AudioManager._setVibrateSetting7029 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setVibrateSetting", "(II)V");
			global::android.media.AudioManager._setSpeakerphoneOn7030 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setSpeakerphoneOn", "(Z)V");
			global::android.media.AudioManager._isSpeakerphoneOn7031 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isSpeakerphoneOn", "()Z");
			global::android.media.AudioManager._isBluetoothScoAvailableOffCall7032 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothScoAvailableOffCall", "()Z");
			global::android.media.AudioManager._startBluetoothSco7033 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "startBluetoothSco", "()V");
			global::android.media.AudioManager._stopBluetoothSco7034 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "stopBluetoothSco", "()V");
			global::android.media.AudioManager._setBluetoothScoOn7035 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setBluetoothScoOn", "(Z)V");
			global::android.media.AudioManager._isBluetoothScoOn7036 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothScoOn", "()Z");
			global::android.media.AudioManager._setBluetoothA2dpOn7037 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setBluetoothA2dpOn", "(Z)V");
			global::android.media.AudioManager._isBluetoothA2dpOn7038 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isBluetoothA2dpOn", "()Z");
			global::android.media.AudioManager._setWiredHeadsetOn7039 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setWiredHeadsetOn", "(Z)V");
			global::android.media.AudioManager._isWiredHeadsetOn7040 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isWiredHeadsetOn", "()Z");
			global::android.media.AudioManager._setMicrophoneMute7041 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setMicrophoneMute", "(Z)V");
			global::android.media.AudioManager._isMicrophoneMute7042 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isMicrophoneMute", "()Z");
			global::android.media.AudioManager._setRouting7043 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "setRouting", "(III)V");
			global::android.media.AudioManager._getRouting7044 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "getRouting", "(I)I");
			global::android.media.AudioManager._isMusicActive7045 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "isMusicActive", "()Z");
			global::android.media.AudioManager._loadSoundEffects7046 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "loadSoundEffects", "()V");
			global::android.media.AudioManager._unloadSoundEffects7047 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "unloadSoundEffects", "()V");
			global::android.media.AudioManager._requestAudioFocus7048 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "requestAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;II)I");
			global::android.media.AudioManager._abandonAudioFocus7049 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "abandonAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;)I");
			global::android.media.AudioManager._registerMediaButtonEventReceiver7050 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "registerMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V");
			global::android.media.AudioManager._unregisterMediaButtonEventReceiver7051 = @__env.GetMethodIDNoThrow(global::android.media.AudioManager.staticClass, "unregisterMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V");
		}
	}
}
