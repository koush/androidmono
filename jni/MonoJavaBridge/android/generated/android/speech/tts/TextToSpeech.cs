namespace android.speech.tts
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class TextToSpeech : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static TextToSpeech()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.tts.TextToSpeech), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.speech.tts.TextToSpeech(@__env);
			}
		}
		protected TextToSpeech(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Engine : java.lang.Object
		{
			internal static global::java.lang.Class staticClass;
			static Engine()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.tts.TextToSpeech.Engine), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.speech.tts.TextToSpeech.Engine(@__env);
				}
			}
			protected Engine(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _Engine7037;
			public Engine(android.speech.tts.TextToSpeech arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.speech.tts.TextToSpeech.Engine.staticClass, global::android.speech.tts.TextToSpeech.Engine._Engine7037, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
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
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.speech.tts.TextToSpeech.Engine.staticClass = @__class;
				global::android.speech.tts.TextToSpeech.Engine._Engine7037 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.Engine.staticClass, "<init>", "(Landroid/speech/tts/TextToSpeech;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnInitListener 
		{
			void onInit(int arg0);
		}

		public partial class OnInitListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnInitListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnInitListener : java.lang.Object, OnInitListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnInitListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.tts.TextToSpeech.__OnInitListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.speech.tts.TextToSpeech.__OnInitListener(@__env);
				}
			}
			internal __OnInitListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onInit7038;
			 void android.speech.tts.TextToSpeech.OnInitListener.onInit(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.tts.TextToSpeech.__OnInitListener._onInit7038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.tts.TextToSpeech.__OnInitListener.staticClass, global::android.speech.tts.TextToSpeech.__OnInitListener._onInit7038, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.speech.tts.TextToSpeech.__OnInitListener.staticClass = @__class;
				global::android.speech.tts.TextToSpeech.__OnInitListener._onInit7038 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.__OnInitListener.staticClass, "android.speech.tts.TextToSpeech.OnInitListener.onInit", "(I)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface OnUtteranceCompletedListener 
		{
			void onUtteranceCompleted(java.lang.String arg0);
		}

		public partial class OnUtteranceCompletedListener_
		{
			public static global::java.lang.Class _class
			{
				get { return __OnUtteranceCompletedListener.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __OnUtteranceCompletedListener : java.lang.Object, OnUtteranceCompletedListener
		{
			internal static global::java.lang.Class staticClass;
			static __OnUtteranceCompletedListener()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener(@__env);
				}
			}
			internal __OnUtteranceCompletedListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _onUtteranceCompleted7039;
			 void android.speech.tts.TextToSpeech.OnUtteranceCompletedListener.onUtteranceCompleted(java.lang.String arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener._onUtteranceCompleted7039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener.staticClass, global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener._onUtteranceCompleted7039, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener.staticClass = @__class;
				global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener._onUtteranceCompleted7039 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener.staticClass, "android.speech.tts.TextToSpeech.OnUtteranceCompletedListener.onUtteranceCompleted", "(Ljava/lang/String;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _shutdown7040;
		public virtual void shutdown() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.tts.TextToSpeech._shutdown7040);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._shutdown7040);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLanguage7041;
		public virtual global::java.util.Locale getLanguage() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, global::android.speech.tts.TextToSpeech._getLanguage7041));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._getLanguage7041));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stop7042;
		public virtual int stop() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._stop7042);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._stop7042);
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSpeech7043;
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._addSpeech7043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._addSpeech7043, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addSpeech7044;
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._addSpeech7044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._addSpeech7044, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addEarcon7045;
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._addEarcon7045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._addEarcon7045, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addEarcon7046;
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._addEarcon7046, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._addEarcon7046, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _speak7047;
		public virtual int speak(java.lang.String arg0, int arg1, java.util.HashMap arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._speak7047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._speak7047, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _playEarcon7048;
		public virtual int playEarcon(java.lang.String arg0, int arg1, java.util.HashMap arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._playEarcon7048, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._playEarcon7048, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _playSilence7049;
		public virtual int playSilence(long arg0, int arg1, java.util.HashMap arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._playSilence7049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._playSilence7049, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isSpeaking7050;
		public virtual bool isSpeaking() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.speech.tts.TextToSpeech._isSpeaking7050);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._isSpeaking7050);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setSpeechRate7051;
		public virtual int setSpeechRate(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._setSpeechRate7051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setSpeechRate7051, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPitch7052;
		public virtual int setPitch(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._setPitch7052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setPitch7052, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLanguage7053;
		public virtual int setLanguage(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._setLanguage7053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setLanguage7053, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLanguageAvailable7054;
		public virtual int isLanguageAvailable(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._isLanguageAvailable7054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._isLanguageAvailable7054, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _synthesizeToFile7055;
		public virtual int synthesizeToFile(java.lang.String arg0, java.util.HashMap arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._synthesizeToFile7055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._synthesizeToFile7055, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setOnUtteranceCompletedListener7056;
		public virtual int setOnUtteranceCompletedListener(android.speech.tts.TextToSpeech.OnUtteranceCompletedListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._setOnUtteranceCompletedListener7056, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setOnUtteranceCompletedListener7056, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setEngineByPackageName7057;
		public virtual int setEngineByPackageName(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.speech.tts.TextToSpeech._setEngineByPackageName7057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._setEngineByPackageName7057, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDefaultEngine7058;
		public virtual global::java.lang.String getDefaultEngine() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.speech.tts.TextToSpeech._getDefaultEngine7058));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._getDefaultEngine7058));
		}
		internal static global::net.sf.jni4net.jni.MethodId _areDefaultsEnforced7059;
		public virtual bool areDefaultsEnforced() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.speech.tts.TextToSpeech._areDefaultsEnforced7059);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._areDefaultsEnforced7059);
		}
		internal static global::net.sf.jni4net.jni.MethodId _TextToSpeech7060;
		public TextToSpeech(android.content.Context arg0, android.speech.tts.TextToSpeech.OnInitListener arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.speech.tts.TextToSpeech.staticClass, global::android.speech.tts.TextToSpeech._TextToSpeech7060, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.speech.tts.TextToSpeech.staticClass = @__class;
			global::android.speech.tts.TextToSpeech._shutdown7040 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "shutdown", "()V");
			global::android.speech.tts.TextToSpeech._getLanguage7041 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "getLanguage", "()Ljava/util/Locale;");
			global::android.speech.tts.TextToSpeech._stop7042 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "stop", "()I");
			global::android.speech.tts.TextToSpeech._addSpeech7043 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.speech.tts.TextToSpeech._addSpeech7044 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.speech.tts.TextToSpeech._addEarcon7045 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;I)I");
			global::android.speech.tts.TextToSpeech._addEarcon7046 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;)I");
			global::android.speech.tts.TextToSpeech._speak7047 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "speak", "(Ljava/lang/String;ILjava/util/HashMap;)I");
			global::android.speech.tts.TextToSpeech._playEarcon7048 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "playEarcon", "(Ljava/lang/String;ILjava/util/HashMap;)I");
			global::android.speech.tts.TextToSpeech._playSilence7049 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "playSilence", "(JILjava/util/HashMap;)I");
			global::android.speech.tts.TextToSpeech._isSpeaking7050 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "isSpeaking", "()Z");
			global::android.speech.tts.TextToSpeech._setSpeechRate7051 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setSpeechRate", "(F)I");
			global::android.speech.tts.TextToSpeech._setPitch7052 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setPitch", "(F)I");
			global::android.speech.tts.TextToSpeech._setLanguage7053 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setLanguage", "(Ljava/util/Locale;)I");
			global::android.speech.tts.TextToSpeech._isLanguageAvailable7054 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "isLanguageAvailable", "(Ljava/util/Locale;)I");
			global::android.speech.tts.TextToSpeech._synthesizeToFile7055 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "synthesizeToFile", "(Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)I");
			global::android.speech.tts.TextToSpeech._setOnUtteranceCompletedListener7056 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setOnUtteranceCompletedListener", "(Landroid/speech/tts/TextToSpeech$OnUtteranceCompletedListener;)I");
			global::android.speech.tts.TextToSpeech._setEngineByPackageName7057 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setEngineByPackageName", "(Ljava/lang/String;)I");
			global::android.speech.tts.TextToSpeech._getDefaultEngine7058 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "getDefaultEngine", "()Ljava/lang/String;");
			global::android.speech.tts.TextToSpeech._areDefaultsEnforced7059 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "areDefaultsEnforced", "()Z");
			global::android.speech.tts.TextToSpeech._TextToSpeech7060 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;)V");
		}
	}
}
