namespace android.media 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class AudioManager : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AudioManager() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.media.AudioManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getParameters4132; 
		public virtual java.lang.String getParameters(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getParameters4132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.media.AudioManager.staticClass, _getParameters4132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMode4133; 
		public virtual void setMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setMode4133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setMode4133, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMode4134; 
		public virtual int getMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallIntMethod(this, _getMode4134); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioManager.staticClass, _getMode4134); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect4135; 
		public virtual void playSoundEffect(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _playSoundEffect4135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _playSoundEffect4135, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect4136; 
		public virtual void playSoundEffect(int arg0, float arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _playSoundEffect4136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _playSoundEffect4136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setParameters4137; 
		public virtual void setParameters(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setParameters4137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setParameters4137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _adjustStreamVolume4138; 
		public virtual void adjustStreamVolume(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _adjustStreamVolume4138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _adjustStreamVolume4138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _adjustVolume4139; 
		public virtual void adjustVolume(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _adjustVolume4139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _adjustVolume4139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _adjustSuggestedStreamVolume4140; 
		public virtual void adjustSuggestedStreamVolume(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _adjustSuggestedStreamVolume4140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _adjustSuggestedStreamVolume4140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRingerMode4141; 
		public virtual int getRingerMode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallIntMethod(this, _getRingerMode4141); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioManager.staticClass, _getRingerMode4141); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStreamMaxVolume4142; 
		public virtual int getStreamMaxVolume(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallIntMethod(this, _getStreamMaxVolume4142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioManager.staticClass, _getStreamMaxVolume4142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStreamVolume4143; 
		public virtual int getStreamVolume(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallIntMethod(this, _getStreamVolume4143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioManager.staticClass, _getStreamVolume4143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRingerMode4144; 
		public virtual void setRingerMode(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setRingerMode4144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setRingerMode4144, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStreamVolume4145; 
		public virtual void setStreamVolume(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setStreamVolume4145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setStreamVolume4145, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStreamSolo4146; 
		public virtual void setStreamSolo(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setStreamSolo4146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setStreamSolo4146, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setStreamMute4147; 
		public virtual void setStreamMute(int arg0, bool arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setStreamMute4147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setStreamMute4147, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shouldVibrate4148; 
		public virtual bool shouldVibrate(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallBooleanMethod(this, _shouldVibrate4148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.AudioManager.staticClass, _shouldVibrate4148, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getVibrateSetting4149; 
		public virtual int getVibrateSetting(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallIntMethod(this, _getVibrateSetting4149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioManager.staticClass, _getVibrateSetting4149, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setVibrateSetting4150; 
		public virtual void setVibrateSetting(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setVibrateSetting4150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setVibrateSetting4150, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpeakerphoneOn4151; 
		public virtual void setSpeakerphoneOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setSpeakerphoneOn4151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setSpeakerphoneOn4151, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSpeakerphoneOn4152; 
		public virtual bool isSpeakerphoneOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallBooleanMethod(this, _isSpeakerphoneOn4152); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.AudioManager.staticClass, _isSpeakerphoneOn4152); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBluetoothScoOn4153; 
		public virtual void setBluetoothScoOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setBluetoothScoOn4153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setBluetoothScoOn4153, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBluetoothScoOn4154; 
		public virtual bool isBluetoothScoOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallBooleanMethod(this, _isBluetoothScoOn4154); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.AudioManager.staticClass, _isBluetoothScoOn4154); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setBluetoothA2dpOn4155; 
		public virtual void setBluetoothA2dpOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setBluetoothA2dpOn4155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setBluetoothA2dpOn4155, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBluetoothA2dpOn4156; 
		public virtual bool isBluetoothA2dpOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallBooleanMethod(this, _isBluetoothA2dpOn4156); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.AudioManager.staticClass, _isBluetoothA2dpOn4156); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setWiredHeadsetOn4157; 
		public virtual void setWiredHeadsetOn(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setWiredHeadsetOn4157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setWiredHeadsetOn4157, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isWiredHeadsetOn4158; 
		public virtual bool isWiredHeadsetOn() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallBooleanMethod(this, _isWiredHeadsetOn4158); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.AudioManager.staticClass, _isWiredHeadsetOn4158); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setMicrophoneMute4159; 
		public virtual void setMicrophoneMute(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setMicrophoneMute4159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setMicrophoneMute4159, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMicrophoneMute4160; 
		public virtual bool isMicrophoneMute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallBooleanMethod(this, _isMicrophoneMute4160); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.AudioManager.staticClass, _isMicrophoneMute4160); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRouting4161; 
		public virtual void setRouting(int arg0, int arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _setRouting4161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _setRouting4161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRouting4162; 
		public virtual int getRouting(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallIntMethod(this, _getRouting4162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.media.AudioManager.staticClass, _getRouting4162, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isMusicActive4163; 
		public virtual bool isMusicActive() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				return @__env.CallBooleanMethod(this, _isMusicActive4163); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.media.AudioManager.staticClass, _isMusicActive4163); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _loadSoundEffects4164; 
		public virtual void loadSoundEffects() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _loadSoundEffects4164); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _loadSoundEffects4164); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unloadSoundEffects4165; 
		public virtual void unloadSoundEffects() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.media.AudioManager)) 
				@__env.CallVoidMethod(this, _unloadSoundEffects4165); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.media.AudioManager.staticClass, _unloadSoundEffects4165); 
		} 
		public static java.lang.String ACTION_AUDIO_BECOMING_NOISY
		{ 
			get 
			{ 
				return "android.media.AUDIO_BECOMING_NOISY"; 
			} 
		} 
		public static java.lang.String RINGER_MODE_CHANGED_ACTION
		{ 
			get 
			{ 
				return "android.media.RINGER_MODE_CHANGED"; 
			} 
		} 
		public static java.lang.String EXTRA_RINGER_MODE
		{ 
			get 
			{ 
				return "android.media.EXTRA_RINGER_MODE"; 
			} 
		} 
		public static java.lang.String VIBRATE_SETTING_CHANGED_ACTION
		{ 
			get 
			{ 
				return "android.media.VIBRATE_SETTING_CHANGED"; 
			} 
		} 
		public static java.lang.String EXTRA_VIBRATE_SETTING
		{ 
			get 
			{ 
				return "android.media.EXTRA_VIBRATE_SETTING"; 
			} 
		} 
		public static java.lang.String EXTRA_VIBRATE_TYPE
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
			global::android.media.AudioManager._getParameters4132 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getParameters", "(Ljava/lang/String;)Ljava/lang/String;"); 
			global::android.media.AudioManager._setMode4133 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setMode", "(I)V"); 
			global::android.media.AudioManager._getMode4134 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getMode", "()I"); 
			global::android.media.AudioManager._playSoundEffect4135 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "playSoundEffect", "(I)V"); 
			global::android.media.AudioManager._playSoundEffect4136 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "playSoundEffect", "(IF)V"); 
			global::android.media.AudioManager._setParameters4137 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setParameters", "(Ljava/lang/String;)V"); 
			global::android.media.AudioManager._adjustStreamVolume4138 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustStreamVolume", "(III)V"); 
			global::android.media.AudioManager._adjustVolume4139 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustVolume", "(II)V"); 
			global::android.media.AudioManager._adjustSuggestedStreamVolume4140 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustSuggestedStreamVolume", "(III)V"); 
			global::android.media.AudioManager._getRingerMode4141 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getRingerMode", "()I"); 
			global::android.media.AudioManager._getStreamMaxVolume4142 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getStreamMaxVolume", "(I)I"); 
			global::android.media.AudioManager._getStreamVolume4143 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getStreamVolume", "(I)I"); 
			global::android.media.AudioManager._setRingerMode4144 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setRingerMode", "(I)V"); 
			global::android.media.AudioManager._setStreamVolume4145 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamVolume", "(III)V"); 
			global::android.media.AudioManager._setStreamSolo4146 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamSolo", "(IZ)V"); 
			global::android.media.AudioManager._setStreamMute4147 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamMute", "(IZ)V"); 
			global::android.media.AudioManager._shouldVibrate4148 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "shouldVibrate", "(I)Z"); 
			global::android.media.AudioManager._getVibrateSetting4149 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getVibrateSetting", "(I)I"); 
			global::android.media.AudioManager._setVibrateSetting4150 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setVibrateSetting", "(II)V"); 
			global::android.media.AudioManager._setSpeakerphoneOn4151 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setSpeakerphoneOn", "(Z)V"); 
			global::android.media.AudioManager._isSpeakerphoneOn4152 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isSpeakerphoneOn", "()Z"); 
			global::android.media.AudioManager._setBluetoothScoOn4153 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setBluetoothScoOn", "(Z)V"); 
			global::android.media.AudioManager._isBluetoothScoOn4154 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isBluetoothScoOn", "()Z"); 
			global::android.media.AudioManager._setBluetoothA2dpOn4155 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setBluetoothA2dpOn", "(Z)V"); 
			global::android.media.AudioManager._isBluetoothA2dpOn4156 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isBluetoothA2dpOn", "()Z"); 
			global::android.media.AudioManager._setWiredHeadsetOn4157 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setWiredHeadsetOn", "(Z)V"); 
			global::android.media.AudioManager._isWiredHeadsetOn4158 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isWiredHeadsetOn", "()Z"); 
			global::android.media.AudioManager._setMicrophoneMute4159 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setMicrophoneMute", "(Z)V"); 
			global::android.media.AudioManager._isMicrophoneMute4160 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isMicrophoneMute", "()Z"); 
			global::android.media.AudioManager._setRouting4161 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setRouting", "(III)V"); 
			global::android.media.AudioManager._getRouting4162 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getRouting", "(I)I"); 
			global::android.media.AudioManager._isMusicActive4163 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isMusicActive", "()Z"); 
			global::android.media.AudioManager._loadSoundEffects4164 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "loadSoundEffects", "()V"); 
			global::android.media.AudioManager._unloadSoundEffects4165 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "unloadSoundEffects", "()V"); 
		} 
	} 
} 
