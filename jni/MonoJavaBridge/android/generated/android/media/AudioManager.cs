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
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnAudioFocusChangeListener 
		{
			void onAudioFocusChange(int arg0);
		}

		public partial class OnAudioFocusChangeListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnAudioFocusChangeListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnAudioFocusChangeListener : java.lang.Object, OnAudioFocusChangeListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnAudioFocusChangeListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.media.AudioManager.__OnAudioFocusChangeListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.media.AudioManager.__OnAudioFocusChangeListener(@__env);
				}
			}
			internal __OnAudioFocusChangeListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onAudioFocusChange4593;
			 void android.media.AudioManager.OnAudioFocusChangeListener.onAudioFocusChange(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.media.AudioManager.__OnAudioFocusChangeListener._onAudioFocusChange4593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.__OnAudioFocusChangeListener.staticClass, global::android.media.AudioManager.__OnAudioFocusChangeListener._onAudioFocusChange4593, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.media.AudioManager.__OnAudioFocusChangeListener.staticClass = @__class;
				global::android.media.AudioManager.__OnAudioFocusChangeListener._onAudioFocusChange4593 = @__env.GetMethodID(global::android.media.AudioManager.__OnAudioFocusChangeListener.staticClass, "android.media.AudioManager.OnAudioFocusChangeListener.onAudioFocusChange", "(I)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getParameters4594;
		public virtual global::java.lang.String getParameters(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.media.AudioManager._getParameters4594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getParameters4594, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMode4595;
		public virtual void setMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setMode4595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMode4595, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMode4596;
		public virtual int getMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getMode4596);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getMode4596);
		}
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect4597;
		public virtual void playSoundEffect(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._playSoundEffect4597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect4597, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _playSoundEffect4598;
		public virtual void playSoundEffect(int arg0, float arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._playSoundEffect4598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._playSoundEffect4598, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setParameters4599;
		public virtual void setParameters(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setParameters4599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setParameters4599, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _adjustStreamVolume4600;
		public virtual void adjustStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._adjustStreamVolume4600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustStreamVolume4600, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _adjustVolume4601;
		public virtual void adjustVolume(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._adjustVolume4601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustVolume4601, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _adjustSuggestedStreamVolume4602;
		public virtual void adjustSuggestedStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._adjustSuggestedStreamVolume4602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._adjustSuggestedStreamVolume4602, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRingerMode4603;
		public virtual int getRingerMode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getRingerMode4603);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRingerMode4603);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStreamMaxVolume4604;
		public virtual int getStreamMaxVolume(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getStreamMaxVolume4604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamMaxVolume4604, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStreamVolume4605;
		public virtual int getStreamVolume(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getStreamVolume4605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getStreamVolume4605, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRingerMode4606;
		public virtual void setRingerMode(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setRingerMode4606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRingerMode4606, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStreamVolume4607;
		public virtual void setStreamVolume(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setStreamVolume4607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamVolume4607, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStreamSolo4608;
		public virtual void setStreamSolo(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setStreamSolo4608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamSolo4608, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setStreamMute4609;
		public virtual void setStreamMute(int arg0, bool arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setStreamMute4609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setStreamMute4609, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _shouldVibrate4610;
		public virtual bool shouldVibrate(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._shouldVibrate4610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._shouldVibrate4610, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVibrateSetting4611;
		public virtual int getVibrateSetting(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getVibrateSetting4611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getVibrateSetting4611, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVibrateSetting4612;
		public virtual void setVibrateSetting(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setVibrateSetting4612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setVibrateSetting4612, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSpeakerphoneOn4613;
		public virtual void setSpeakerphoneOn(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setSpeakerphoneOn4613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setSpeakerphoneOn4613, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSpeakerphoneOn4614;
		public virtual bool isSpeakerphoneOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isSpeakerphoneOn4614);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isSpeakerphoneOn4614);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBluetoothScoAvailableOffCall4615;
		public virtual bool isBluetoothScoAvailableOffCall() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isBluetoothScoAvailableOffCall4615);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoAvailableOffCall4615);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startBluetoothSco4616;
		public virtual void startBluetoothSco() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._startBluetoothSco4616);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._startBluetoothSco4616);
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopBluetoothSco4617;
		public virtual void stopBluetoothSco() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._stopBluetoothSco4617);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._stopBluetoothSco4617);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBluetoothScoOn4618;
		public virtual void setBluetoothScoOn(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setBluetoothScoOn4618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothScoOn4618, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBluetoothScoOn4619;
		public virtual bool isBluetoothScoOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isBluetoothScoOn4619);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothScoOn4619);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setBluetoothA2dpOn4620;
		public virtual void setBluetoothA2dpOn(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setBluetoothA2dpOn4620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setBluetoothA2dpOn4620, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBluetoothA2dpOn4621;
		public virtual bool isBluetoothA2dpOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isBluetoothA2dpOn4621);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isBluetoothA2dpOn4621);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setWiredHeadsetOn4622;
		public virtual void setWiredHeadsetOn(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setWiredHeadsetOn4622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setWiredHeadsetOn4622, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isWiredHeadsetOn4623;
		public virtual bool isWiredHeadsetOn() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isWiredHeadsetOn4623);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isWiredHeadsetOn4623);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMicrophoneMute4624;
		public virtual void setMicrophoneMute(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setMicrophoneMute4624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setMicrophoneMute4624, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMicrophoneMute4625;
		public virtual bool isMicrophoneMute() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isMicrophoneMute4625);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMicrophoneMute4625);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRouting4626;
		public virtual void setRouting(int arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._setRouting4626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._setRouting4626, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRouting4627;
		public virtual int getRouting(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioManager._getRouting4627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._getRouting4627, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isMusicActive4628;
		public virtual bool isMusicActive() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.media.AudioManager._isMusicActive4628);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._isMusicActive4628);
		}
		internal static global::net.sf.jni4net.jni.MethodId _loadSoundEffects4629;
		public virtual void loadSoundEffects() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._loadSoundEffects4629);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._loadSoundEffects4629);
		}
		internal static global::net.sf.jni4net.jni.MethodId _unloadSoundEffects4630;
		public virtual void unloadSoundEffects() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._unloadSoundEffects4630);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unloadSoundEffects4630);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requestAudioFocus4631;
		public virtual int requestAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0, int arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioManager._requestAudioFocus4631, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._requestAudioFocus4631, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _abandonAudioFocus4632;
		public virtual int abandonAudioFocus(android.media.AudioManager.OnAudioFocusChangeListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.media.AudioManager._abandonAudioFocus4632, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._abandonAudioFocus4632, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerMediaButtonEventReceiver4633;
		public virtual void registerMediaButtonEventReceiver(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._registerMediaButtonEventReceiver4633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._registerMediaButtonEventReceiver4633, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterMediaButtonEventReceiver4634;
		public virtual void unregisterMediaButtonEventReceiver(android.content.ComponentName arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.media.AudioManager._unregisterMediaButtonEventReceiver4634, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.media.AudioManager.staticClass, global::android.media.AudioManager._unregisterMediaButtonEventReceiver4634, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.media.AudioManager.staticClass = @__class;
			global::android.media.AudioManager._getParameters4594 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getParameters", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.media.AudioManager._setMode4595 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setMode", "(I)V");
			global::android.media.AudioManager._getMode4596 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getMode", "()I");
			global::android.media.AudioManager._playSoundEffect4597 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "playSoundEffect", "(I)V");
			global::android.media.AudioManager._playSoundEffect4598 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "playSoundEffect", "(IF)V");
			global::android.media.AudioManager._setParameters4599 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setParameters", "(Ljava/lang/String;)V");
			global::android.media.AudioManager._adjustStreamVolume4600 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustStreamVolume", "(III)V");
			global::android.media.AudioManager._adjustVolume4601 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustVolume", "(II)V");
			global::android.media.AudioManager._adjustSuggestedStreamVolume4602 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "adjustSuggestedStreamVolume", "(III)V");
			global::android.media.AudioManager._getRingerMode4603 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getRingerMode", "()I");
			global::android.media.AudioManager._getStreamMaxVolume4604 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getStreamMaxVolume", "(I)I");
			global::android.media.AudioManager._getStreamVolume4605 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getStreamVolume", "(I)I");
			global::android.media.AudioManager._setRingerMode4606 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setRingerMode", "(I)V");
			global::android.media.AudioManager._setStreamVolume4607 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamVolume", "(III)V");
			global::android.media.AudioManager._setStreamSolo4608 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamSolo", "(IZ)V");
			global::android.media.AudioManager._setStreamMute4609 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setStreamMute", "(IZ)V");
			global::android.media.AudioManager._shouldVibrate4610 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "shouldVibrate", "(I)Z");
			global::android.media.AudioManager._getVibrateSetting4611 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getVibrateSetting", "(I)I");
			global::android.media.AudioManager._setVibrateSetting4612 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setVibrateSetting", "(II)V");
			global::android.media.AudioManager._setSpeakerphoneOn4613 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setSpeakerphoneOn", "(Z)V");
			global::android.media.AudioManager._isSpeakerphoneOn4614 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isSpeakerphoneOn", "()Z");
			global::android.media.AudioManager._isBluetoothScoAvailableOffCall4615 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isBluetoothScoAvailableOffCall", "()Z");
			global::android.media.AudioManager._startBluetoothSco4616 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "startBluetoothSco", "()V");
			global::android.media.AudioManager._stopBluetoothSco4617 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "stopBluetoothSco", "()V");
			global::android.media.AudioManager._setBluetoothScoOn4618 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setBluetoothScoOn", "(Z)V");
			global::android.media.AudioManager._isBluetoothScoOn4619 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isBluetoothScoOn", "()Z");
			global::android.media.AudioManager._setBluetoothA2dpOn4620 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setBluetoothA2dpOn", "(Z)V");
			global::android.media.AudioManager._isBluetoothA2dpOn4621 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isBluetoothA2dpOn", "()Z");
			global::android.media.AudioManager._setWiredHeadsetOn4622 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setWiredHeadsetOn", "(Z)V");
			global::android.media.AudioManager._isWiredHeadsetOn4623 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isWiredHeadsetOn", "()Z");
			global::android.media.AudioManager._setMicrophoneMute4624 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setMicrophoneMute", "(Z)V");
			global::android.media.AudioManager._isMicrophoneMute4625 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isMicrophoneMute", "()Z");
			global::android.media.AudioManager._setRouting4626 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "setRouting", "(III)V");
			global::android.media.AudioManager._getRouting4627 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "getRouting", "(I)I");
			global::android.media.AudioManager._isMusicActive4628 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "isMusicActive", "()Z");
			global::android.media.AudioManager._loadSoundEffects4629 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "loadSoundEffects", "()V");
			global::android.media.AudioManager._unloadSoundEffects4630 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "unloadSoundEffects", "()V");
			global::android.media.AudioManager._requestAudioFocus4631 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "requestAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;II)I");
			global::android.media.AudioManager._abandonAudioFocus4632 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "abandonAudioFocus", "(Landroid/media/AudioManager$OnAudioFocusChangeListener;)I");
			global::android.media.AudioManager._registerMediaButtonEventReceiver4633 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "registerMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V");
			global::android.media.AudioManager._unregisterMediaButtonEventReceiver4634 = @__env.GetMethodID(global::android.media.AudioManager.staticClass, "unregisterMediaButtonEventReceiver", "(Landroid/content/ComponentName;)V");
		}
	}
}
