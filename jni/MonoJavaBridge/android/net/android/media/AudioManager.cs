namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AudioManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AudioManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.AudioManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.media.AudioManager(@__env); 
			} 
		} 
		protected AudioManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getParameters4361; 
		public virtual global::java.lang.String getParameters(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.media.AudioManager._getParameters4361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getParameters4361, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMode4362; 
		public virtual void setMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setMode4362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMode4362, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMode4363; 
		public virtual int getMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getMode4363); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getMode4363); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect4364; 
		public virtual void playSoundEffect(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._playSoundEffect4364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect4364, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect4365; 
		public virtual void playSoundEffect(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._playSoundEffect4365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect4365, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setParameters4366; 
		public virtual void setParameters(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setParameters4366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setParameters4366, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _adjustStreamVolume4367; 
		public virtual void adjustStreamVolume(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._adjustStreamVolume4367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustStreamVolume4367, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _adjustVolume4368; 
		public virtual void adjustVolume(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._adjustVolume4368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustVolume4368, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _adjustSuggestedStreamVolume4369; 
		public virtual void adjustSuggestedStreamVolume(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._adjustSuggestedStreamVolume4369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustSuggestedStreamVolume4369, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRingerMode4370; 
		public virtual int getRingerMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getRingerMode4370); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRingerMode4370); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStreamMaxVolume4371; 
		public virtual int getStreamMaxVolume(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getStreamMaxVolume4371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamMaxVolume4371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStreamVolume4372; 
		public virtual int getStreamVolume(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getStreamVolume4372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamVolume4372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRingerMode4373; 
		public virtual void setRingerMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setRingerMode4373, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRingerMode4373, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStreamVolume4374; 
		public virtual void setStreamVolume(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setStreamVolume4374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamVolume4374, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStreamSolo4375; 
		public virtual void setStreamSolo(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setStreamSolo4375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamSolo4375, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStreamMute4376; 
		public virtual void setStreamMute(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setStreamMute4376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamMute4376, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldVibrate4377; 
		public virtual bool shouldVibrate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._shouldVibrate4377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._shouldVibrate4377, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVibrateSetting4378; 
		public virtual int getVibrateSetting(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getVibrateSetting4378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getVibrateSetting4378, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVibrateSetting4379; 
		public virtual void setVibrateSetting(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setVibrateSetting4379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setVibrateSetting4379, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpeakerphoneOn4380; 
		public virtual void setSpeakerphoneOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setSpeakerphoneOn4380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setSpeakerphoneOn4380, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSpeakerphoneOn4381; 
		public virtual bool isSpeakerphoneOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isSpeakerphoneOn4381); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isSpeakerphoneOn4381); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBluetoothScoOn4382; 
		public virtual void setBluetoothScoOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setBluetoothScoOn4382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothScoOn4382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBluetoothScoOn4383; 
		public virtual bool isBluetoothScoOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isBluetoothScoOn4383); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoOn4383); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBluetoothA2dpOn4384; 
		public virtual void setBluetoothA2dpOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setBluetoothA2dpOn4384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothA2dpOn4384, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBluetoothA2dpOn4385; 
		public virtual bool isBluetoothA2dpOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isBluetoothA2dpOn4385); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothA2dpOn4385); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWiredHeadsetOn4386; 
		public virtual void setWiredHeadsetOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setWiredHeadsetOn4386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setWiredHeadsetOn4386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWiredHeadsetOn4387; 
		public virtual bool isWiredHeadsetOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isWiredHeadsetOn4387); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isWiredHeadsetOn4387); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMicrophoneMute4388; 
		public virtual void setMicrophoneMute(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setMicrophoneMute4388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMicrophoneMute4388, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMicrophoneMute4389; 
		public virtual bool isMicrophoneMute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isMicrophoneMute4389); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMicrophoneMute4389); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRouting4390; 
		public virtual void setRouting(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setRouting4390, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRouting4390, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRouting4391; 
		public virtual int getRouting(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getRouting4391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRouting4391, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMusicActive4392; 
		public virtual bool isMusicActive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isMusicActive4392); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMusicActive4392); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadSoundEffects4393; 
		public virtual void loadSoundEffects() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._loadSoundEffects4393); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._loadSoundEffects4393); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unloadSoundEffects4394; 
		public virtual void unloadSoundEffects() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.media.AudioManager._unloadSoundEffects4394); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unloadSoundEffects4394); 
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.media.AudioManager.staticClass = @__class; 
			global::android.media.AudioManager._getParameters4361 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getParameters", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.media.AudioManager._setMode4362 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setMode", "(I)V"); 
			global::android.media.AudioManager._getMode4363 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getMode", "()I"); 
			global::android.media.AudioManager._playSoundEffect4364 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "playSoundEffect", "(I)V"); 
			global::android.media.AudioManager._playSoundEffect4365 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "playSoundEffect", "(IF)V"); 
			global::android.media.AudioManager._setParameters4366 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setParameters", "(Ljava/lang/String;)V"); 
			global::android.media.AudioManager._adjustStreamVolume4367 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustStreamVolume", "(III)V"); 
			global::android.media.AudioManager._adjustVolume4368 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustVolume", "(II)V"); 
			global::android.media.AudioManager._adjustSuggestedStreamVolume4369 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustSuggestedStreamVolume", "(III)V"); 
			global::android.media.AudioManager._getRingerMode4370 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getRingerMode", "()I"); 
			global::android.media.AudioManager._getStreamMaxVolume4371 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getStreamMaxVolume", "(I)I"); 
			global::android.media.AudioManager._getStreamVolume4372 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getStreamVolume", "(I)I"); 
			global::android.media.AudioManager._setRingerMode4373 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setRingerMode", "(I)V"); 
			global::android.media.AudioManager._setStreamVolume4374 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamVolume", "(III)V"); 
			global::android.media.AudioManager._setStreamSolo4375 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamSolo", "(IZ)V"); 
			global::android.media.AudioManager._setStreamMute4376 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamMute", "(IZ)V"); 
			global::android.media.AudioManager._shouldVibrate4377 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "shouldVibrate", "(I)Z"); 
			global::android.media.AudioManager._getVibrateSetting4378 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getVibrateSetting", "(I)I"); 
			global::android.media.AudioManager._setVibrateSetting4379 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setVibrateSetting", "(II)V"); 
			global::android.media.AudioManager._setSpeakerphoneOn4380 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setSpeakerphoneOn", "(Z)V"); 
			global::android.media.AudioManager._isSpeakerphoneOn4381 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isSpeakerphoneOn", "()Z"); 
			global::android.media.AudioManager._setBluetoothScoOn4382 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setBluetoothScoOn", "(Z)V"); 
			global::android.media.AudioManager._isBluetoothScoOn4383 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isBluetoothScoOn", "()Z"); 
			global::android.media.AudioManager._setBluetoothA2dpOn4384 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setBluetoothA2dpOn", "(Z)V"); 
			global::android.media.AudioManager._isBluetoothA2dpOn4385 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isBluetoothA2dpOn", "()Z"); 
			global::android.media.AudioManager._setWiredHeadsetOn4386 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setWiredHeadsetOn", "(Z)V"); 
			global::android.media.AudioManager._isWiredHeadsetOn4387 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isWiredHeadsetOn", "()Z"); 
			global::android.media.AudioManager._setMicrophoneMute4388 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setMicrophoneMute", "(Z)V"); 
			global::android.media.AudioManager._isMicrophoneMute4389 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isMicrophoneMute", "()Z"); 
			global::android.media.AudioManager._setRouting4390 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setRouting", "(III)V"); 
			global::android.media.AudioManager._getRouting4391 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getRouting", "(I)I"); 
			global::android.media.AudioManager._isMusicActive4392 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isMusicActive", "()Z"); 
			global::android.media.AudioManager._loadSoundEffects4393 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "loadSoundEffects", "()V"); 
			global::android.media.AudioManager._unloadSoundEffects4394 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "unloadSoundEffects", "()V"); 
		} 
	} 
} 
