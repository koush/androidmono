namespace android.speech.tts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class TextToSpeech : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static TextToSpeech() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.speech.tts.TextToSpeech), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.speech.tts.TextToSpeech.Engine), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _Engine6416; 
			public Engine(android.speech.tts.TextToSpeech arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.speech.tts.TextToSpeech.Engine.staticClass, _Engine6416, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
			public static java.lang.String ACTION_INSTALL_TTS_DATA
			{ 
				get 
				{ 
					return "android.speech.tts.engine.INSTALL_TTS_DATA"; 
				} 
			} 
			public static java.lang.String ACTION_TTS_DATA_INSTALLED
			{ 
				get 
				{ 
					return "android.speech.tts.engine.TTS_DATA_INSTALLED"; 
				} 
			} 
			public static java.lang.String ACTION_CHECK_TTS_DATA
			{ 
				get 
				{ 
					return "android.speech.tts.engine.CHECK_TTS_DATA"; 
				} 
			} 
			public static java.lang.String EXTRA_VOICE_DATA_ROOT_DIRECTORY
			{ 
				get 
				{ 
					return "dataRoot"; 
				} 
			} 
			public static java.lang.String EXTRA_VOICE_DATA_FILES
			{ 
				get 
				{ 
					return "dataFiles"; 
				} 
			} 
			public static java.lang.String EXTRA_VOICE_DATA_FILES_INFO
			{ 
				get 
				{ 
					return "dataFilesInfo"; 
				} 
			} 
			public static java.lang.String EXTRA_TTS_DATA_INSTALLED
			{ 
				get 
				{ 
					return "dataInstalled"; 
				} 
			} 
			public static java.lang.String KEY_PARAM_STREAM
			{ 
				get 
				{ 
					return "streamType"; 
				} 
			} 
			public static java.lang.String KEY_PARAM_UTTERANCE_ID
			{ 
				get 
				{ 
					return "utteranceId"; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.speech.tts.TextToSpeech.Engine.staticClass = @__class; 
				global::android.speech.tts.TextToSpeech.Engine._Engine6416 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.Engine.staticClass, "<init>", "(Landroid/speech/tts/TextToSpeech;)V"); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.speech.tts.TextToSpeech.__OnInitListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onInit6417; 
			 void android.speech.tts.TextToSpeech.OnInitListener.onInit(int arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.speech.tts.TextToSpeech.__OnInitListener)) 
					@__env.CallVoidMethod(this, _onInit6417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.speech.tts.TextToSpeech.__OnInitListener.staticClass, _onInit6417, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.speech.tts.TextToSpeech.__OnInitListener.staticClass = @__class; 
				global::android.speech.tts.TextToSpeech.__OnInitListener._onInit6417 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.__OnInitListener.staticClass, "android.speech.tts.TextToSpeech.OnInitListener.onInit", "(I)V"); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _onUtteranceCompleted6418; 
			 void android.speech.tts.TextToSpeech.OnUtteranceCompletedListener.onUtteranceCompleted(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener)) 
					@__env.CallVoidMethod(this, _onUtteranceCompleted6418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener.staticClass, _onUtteranceCompleted6418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener.staticClass = @__class; 
				global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener._onUtteranceCompleted6418 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.__OnUtteranceCompletedListener.staticClass, "android.speech.tts.TextToSpeech.OnUtteranceCompletedListener.onUtteranceCompleted", "(Ljava/lang/String;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdown6419; 
		public virtual void shutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				@__env.CallVoidMethod(this, _shutdown6419); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.speech.tts.TextToSpeech.staticClass, _shutdown6419); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLanguage6420; 
		public virtual java.util.Locale getLanguage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, _getLanguage6420)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.speech.tts.TextToSpeech.staticClass, _getLanguage6420)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop6421; 
		public virtual int stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _stop6421); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _stop6421); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSpeech6422; 
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _addSpeech6422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _addSpeech6422, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSpeech6423; 
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _addSpeech6423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _addSpeech6423, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addEarcon6424; 
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _addEarcon6424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _addEarcon6424, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addEarcon6425; 
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _addEarcon6425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _addEarcon6425, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _speak6426; 
		public virtual int speak(java.lang.String arg0, int arg1, java.util.HashMap arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _speak6426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _speak6426, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playEarcon6427; 
		public virtual int playEarcon(java.lang.String arg0, int arg1, java.util.HashMap arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _playEarcon6427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _playEarcon6427, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playSilence6428; 
		public virtual int playSilence(long arg0, int arg1, java.util.HashMap arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _playSilence6428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _playSilence6428, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSpeaking6429; 
		public virtual bool isSpeaking() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallBooleanMethod(this, _isSpeaking6429); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.speech.tts.TextToSpeech.staticClass, _isSpeaking6429); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpeechRate6430; 
		public virtual int setSpeechRate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _setSpeechRate6430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _setSpeechRate6430, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPitch6431; 
		public virtual int setPitch(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _setPitch6431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _setPitch6431, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLanguage6432; 
		public virtual int setLanguage(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _setLanguage6432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _setLanguage6432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLanguageAvailable6433; 
		public virtual int isLanguageAvailable(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _isLanguageAvailable6433, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _isLanguageAvailable6433, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _synthesizeToFile6434; 
		public virtual int synthesizeToFile(java.lang.String arg0, java.util.HashMap arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _synthesizeToFile6434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _synthesizeToFile6434, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnUtteranceCompletedListener6435; 
		public virtual int setOnUtteranceCompletedListener(android.speech.tts.TextToSpeech.OnUtteranceCompletedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _setOnUtteranceCompletedListener6435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _setOnUtteranceCompletedListener6435, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextToSpeech6436; 
		public TextToSpeech(android.content.Context arg0, android.speech.tts.TextToSpeech.OnInitListener arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.speech.tts.TextToSpeech.staticClass, _TextToSpeech6436, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
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
		public static java.lang.String ACTION_TTS_QUEUE_PROCESSING_COMPLETED
		{ 
			get 
			{ 
				return "android.speech.tts.TTS_QUEUE_PROCESSING_COMPLETED"; 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.speech.tts.TextToSpeech.staticClass = @__class; 
			global::android.speech.tts.TextToSpeech._shutdown6419 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "shutdown", "()V"); 
			global::android.speech.tts.TextToSpeech._getLanguage6420 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "getLanguage", "()Ljava/util/Locale;"); 
			global::android.speech.tts.TextToSpeech._stop6421 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "stop", "()I"); 
			global::android.speech.tts.TextToSpeech._addSpeech6422 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.speech.tts.TextToSpeech._addSpeech6423 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;I)I"); 
			global::android.speech.tts.TextToSpeech._addEarcon6424 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.speech.tts.TextToSpeech._addEarcon6425 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;I)I"); 
			global::android.speech.tts.TextToSpeech._speak6426 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "speak", "(Ljava/lang/String;ILjava/util/HashMap;)I"); 
			global::android.speech.tts.TextToSpeech._playEarcon6427 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "playEarcon", "(Ljava/lang/String;ILjava/util/HashMap;)I"); 
			global::android.speech.tts.TextToSpeech._playSilence6428 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "playSilence", "(JILjava/util/HashMap;)I"); 
			global::android.speech.tts.TextToSpeech._isSpeaking6429 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "isSpeaking", "()Z"); 
			global::android.speech.tts.TextToSpeech._setSpeechRate6430 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setSpeechRate", "(F)I"); 
			global::android.speech.tts.TextToSpeech._setPitch6431 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setPitch", "(F)I"); 
			global::android.speech.tts.TextToSpeech._setLanguage6432 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setLanguage", "(Ljava/util/Locale;)I"); 
			global::android.speech.tts.TextToSpeech._isLanguageAvailable6433 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "isLanguageAvailable", "(Ljava/util/Locale;)I"); 
			global::android.speech.tts.TextToSpeech._synthesizeToFile6434 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "synthesizeToFile", "(Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)I"); 
			global::android.speech.tts.TextToSpeech._setOnUtteranceCompletedListener6435 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setOnUtteranceCompletedListener", "(Landroid/speech/tts/TextToSpeech$OnUtteranceCompletedListener;)I"); 
			global::android.speech.tts.TextToSpeech._TextToSpeech6436 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;)V"); 
		} 
	} 
} 
