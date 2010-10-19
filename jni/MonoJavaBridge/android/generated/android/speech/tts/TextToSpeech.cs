namespace android.speech.tts
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class TextToSpeech : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static TextToSpeech()
		{
			InitJNI();
		}
		protected TextToSpeech(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Engine : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Engine()
			{
				InitJNI();
			}
			protected Engine(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Engine7317;
			public Engine(android.speech.tts.TextToSpeech arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.tts.TextToSpeech.Engine.staticClass, global::android.speech.tts.TextToSpeech.Engine._Engine7317, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				Init(@__env, handle);
			}
			public static int DEFAULT_STREAM
			{
				get
				{
					return 3;
				}
			}
			public static int CHECK_VOICE_DATA_PASS
			{
				get
				{
					return 1;
				}
			}
			public static int CHECK_VOICE_DATA_FAIL
			{
				get
				{
					return 0;
				}
			}
			public static int CHECK_VOICE_DATA_BAD_DATA
			{
				get
				{
					return -1;
				}
			}
			public static int CHECK_VOICE_DATA_MISSING_DATA
			{
				get
				{
					return -2;
				}
			}
			public static int CHECK_VOICE_DATA_MISSING_VOLUME
			{
				get
				{
					return -3;
				}
			}
			public static global::java.lang.String ACTION_INSTALL_TTS_DATA
			{
				get
				{
					return "android.speech.tts.engine.INSTALL_TTS_DATA";
				}
			}
			public static global::java.lang.String ACTION_TTS_DATA_INSTALLED
			{
				get
				{
					return "android.speech.tts.engine.TTS_DATA_INSTALLED";
				}
			}
			public static global::java.lang.String ACTION_CHECK_TTS_DATA
			{
				get
				{
					return "android.speech.tts.engine.CHECK_TTS_DATA";
				}
			}
			public static global::java.lang.String EXTRA_VOICE_DATA_ROOT_DIRECTORY
			{
				get
				{
					return "dataRoot";
				}
			}
			public static global::java.lang.String EXTRA_VOICE_DATA_FILES
			{
				get
				{
					return "dataFiles";
				}
			}
			public static global::java.lang.String EXTRA_VOICE_DATA_FILES_INFO
			{
				get
				{
					return "dataFilesInfo";
				}
			}
			public static global::java.lang.String EXTRA_AVAILABLE_VOICES
			{
				get
				{
					return "availableVoices";
				}
			}
			public static global::java.lang.String EXTRA_UNAVAILABLE_VOICES
			{
				get
				{
					return "unavailableVoices";
				}
			}
			public static global::java.lang.String EXTRA_CHECK_VOICE_DATA_FOR
			{
				get
				{
					return "checkVoiceDataFor";
				}
			}
			public static global::java.lang.String EXTRA_TTS_DATA_INSTALLED
			{
				get
				{
					return "dataInstalled";
				}
			}
			public static global::java.lang.String KEY_PARAM_STREAM
			{
				get
				{
					return "streamType";
				}
			}
			public static global::java.lang.String KEY_PARAM_UTTERANCE_ID
			{
				get
				{
					return "utteranceId";
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.tts.TextToSpeech.Engine.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech$Engine"));
				global::android.speech.tts.TextToSpeech.Engine._Engine7317 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.Engine.staticClass, "<init>", "(Landroid/speech/tts/TextToSpeech;)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.speech.tts.TextToSpeech.OnInitListener_))]
		public interface OnInitListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onInit(int arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.tts.TextToSpeech.OnInitListener))]
		public sealed partial class OnInitListener_ : java.lang.Object, OnInitListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnInitListener_()
			{
				InitJNI();
			}
			internal OnInitListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onInit7318;
			 void android.speech.tts.TextToSpeech.OnInitListener.onInit(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.OnInitListener_._onInit7318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.OnInitListener_.staticClass, global::android.speech.tts.TextToSpeech.OnInitListener_._onInit7318, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.tts.TextToSpeech.OnInitListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech$OnInitListener"));
				global::android.speech.tts.TextToSpeech.OnInitListener_._onInit7318 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.OnInitListener_.staticClass, "onInit", "(I)V");
			}
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_))]
		public interface OnUtteranceCompletedListener  : global::MonoJavaBridge.IJavaObject 
		{
			void onUtteranceCompleted(java.lang.String arg0);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener))]
		public sealed partial class OnUtteranceCompletedListener_ : java.lang.Object, OnUtteranceCompletedListener
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static OnUtteranceCompletedListener_()
			{
				InitJNI();
			}
			internal OnUtteranceCompletedListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _onUtteranceCompleted7319;
			 void android.speech.tts.TextToSpeech.OnUtteranceCompletedListener.onUtteranceCompleted(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_._onUtteranceCompleted7319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_.staticClass, global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_._onUtteranceCompleted7319, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech$OnUtteranceCompletedListener"));
				global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_._onUtteranceCompleted7319 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.OnUtteranceCompletedListener_.staticClass, "onUtteranceCompleted", "(Ljava/lang/String;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _shutdown7320;
		public virtual void shutdown() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._shutdown7320);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._shutdown7320);
		}
		public new global::java.util.Locale Language
		{
			get
			{
				return getLanguage();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLanguage7321;
		public virtual global::java.util.Locale getLanguage() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._getLanguage7321)) as java.util.Locale;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._getLanguage7321)) as java.util.Locale;
		}
		internal static global::MonoJavaBridge.MethodId _stop7322;
		public virtual int stop() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._stop7322);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._stop7322);
		}
		internal static global::MonoJavaBridge.MethodId _addSpeech7323;
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._addSpeech7323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._addSpeech7323, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addSpeech7324;
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._addSpeech7324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._addSpeech7324, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addEarcon7325;
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._addEarcon7325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._addEarcon7325, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addEarcon7326;
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._addEarcon7326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._addEarcon7326, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _speak7327;
		public virtual int speak(java.lang.String arg0, int arg1, java.util.HashMap arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._speak7327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._speak7327, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _playEarcon7328;
		public virtual int playEarcon(java.lang.String arg0, int arg1, java.util.HashMap arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._playEarcon7328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._playEarcon7328, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _playSilence7329;
		public virtual int playSilence(long arg0, int arg1, java.util.HashMap arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._playSilence7329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._playSilence7329, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isSpeaking7330;
		public virtual bool isSpeaking() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._isSpeaking7330);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._isSpeaking7330);
		}
		internal static global::MonoJavaBridge.MethodId _setSpeechRate7331;
		public virtual int setSpeechRate(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._setSpeechRate7331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setSpeechRate7331, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setPitch7332;
		public virtual int setPitch(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._setPitch7332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setPitch7332, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLanguage7333;
		public virtual int setLanguage(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._setLanguage7333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setLanguage7333, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isLanguageAvailable7334;
		public virtual int isLanguageAvailable(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._isLanguageAvailable7334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._isLanguageAvailable7334, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _synthesizeToFile7335;
		public virtual int synthesizeToFile(java.lang.String arg0, java.util.HashMap arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._synthesizeToFile7335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._synthesizeToFile7335, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _setOnUtteranceCompletedListener7336;
		public virtual int setOnUtteranceCompletedListener(android.speech.tts.TextToSpeech.OnUtteranceCompletedListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._setOnUtteranceCompletedListener7336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setOnUtteranceCompletedListener7336, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setEngineByPackageName7337;
		public virtual int setEngineByPackageName(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._setEngineByPackageName7337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setEngineByPackageName7337, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.lang.String DefaultEngine
		{
			get
			{
				return getDefaultEngine();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDefaultEngine7338;
		public virtual global::java.lang.String getDefaultEngine() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._getDefaultEngine7338)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._getDefaultEngine7338)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _areDefaultsEnforced7339;
		public virtual bool areDefaultsEnforced() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech._areDefaultsEnforced7339);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._areDefaultsEnforced7339);
		}
		internal static global::MonoJavaBridge.MethodId _TextToSpeech7340;
		public TextToSpeech(android.content.Context arg0, android.speech.tts.TextToSpeech.OnInitListener arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._TextToSpeech7340, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		public static int SUCCESS
		{
			get
			{
				return 0;
			}
		}
		public static int ERROR
		{
			get
			{
				return -1;
			}
		}
		public static int QUEUE_FLUSH
		{
			get
			{
				return 0;
			}
		}
		public static int QUEUE_ADD
		{
			get
			{
				return 1;
			}
		}
		public static int LANG_COUNTRY_VAR_AVAILABLE
		{
			get
			{
				return 2;
			}
		}
		public static int LANG_COUNTRY_AVAILABLE
		{
			get
			{
				return 1;
			}
		}
		public static int LANG_AVAILABLE
		{
			get
			{
				return 0;
			}
		}
		public static int LANG_MISSING_DATA
		{
			get
			{
				return -1;
			}
		}
		public static int LANG_NOT_SUPPORTED
		{
			get
			{
				return -2;
			}
		}
		public static global::java.lang.String ACTION_TTS_QUEUE_PROCESSING_COMPLETED
		{
			get
			{
				return "android.speech.tts.TTS_QUEUE_PROCESSING_COMPLETED";
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.tts.TextToSpeech.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/tts/TextToSpeech"));
			global::android.speech.tts.TextToSpeech._shutdown7320 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "shutdown", "()V");
			global::android.speech.tts.TextToSpeech._getLanguage7321 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "getLanguage", "()Ljava/util/Locale;");
			global::android.speech.tts.TextToSpeech._stop7322 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "stop", "()I");
			global::android.speech.tts.TextToSpeech._addSpeech7323 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.speech.tts.TextToSpeech._addSpeech7324 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.speech.tts.TextToSpeech._addEarcon7325 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.speech.tts.TextToSpeech._addEarcon7326 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.speech.tts.TextToSpeech._speak7327 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "speak", "(Ljava/lang/String;ILjava/util/HashMap;)I");
			global::android.speech.tts.TextToSpeech._playEarcon7328 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "playEarcon", "(Ljava/lang/String;ILjava/util/HashMap;)I");
			global::android.speech.tts.TextToSpeech._playSilence7329 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "playSilence", "(JILjava/util/HashMap;)I");
			global::android.speech.tts.TextToSpeech._isSpeaking7330 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "isSpeaking", "()Z");
			global::android.speech.tts.TextToSpeech._setSpeechRate7331 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "setSpeechRate", "(F)I");
			global::android.speech.tts.TextToSpeech._setPitch7332 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "setPitch", "(F)I");
			global::android.speech.tts.TextToSpeech._setLanguage7333 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "setLanguage", "(Ljava/util/Locale;)I");
			global::android.speech.tts.TextToSpeech._isLanguageAvailable7334 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "isLanguageAvailable", "(Ljava/util/Locale;)I");
			global::android.speech.tts.TextToSpeech._synthesizeToFile7335 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "synthesizeToFile", "(Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)I");
			global::android.speech.tts.TextToSpeech._setOnUtteranceCompletedListener7336 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "setOnUtteranceCompletedListener", "(Landroid/speech/tts/TextToSpeech$OnUtteranceCompletedListener;)I");
			global::android.speech.tts.TextToSpeech._setEngineByPackageName7337 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "setEngineByPackageName", "(Ljava/lang/String;)I");
			global::android.speech.tts.TextToSpeech._getDefaultEngine7338 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "getDefaultEngine", "()Ljava/lang/String;");
			global::android.speech.tts.TextToSpeech._areDefaultsEnforced7339 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "areDefaultsEnforced", "()Z");
			global::android.speech.tts.TextToSpeech._TextToSpeech7340 = @__env.GetMethodIDNoThrow(global::android.speech.tts.TextToSpeech.staticClass, "<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;)V");
		}
	}
}
