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
			internal static global::net.sf.jni4net.jni.MethodId _Engine6130; 
			public Engine(android.speech.tts.TextToSpeech arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.speech.tts.TextToSpeech.Engine.staticClass, _Engine6130, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
				global::android.speech.tts.TextToSpeech.Engine._Engine6130 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.Engine.staticClass, "<init>", "(Landroid/speech/tts/TextToSpeech;)V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnInitListener 
		{ 
			void onInit(int arg0); 
		} 
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
		public interface OnUtteranceCompletedListener 
		{ 
			void onUtteranceCompleted(java.lang.String arg0); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _shutdown6131; 
		public virtual void shutdown() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				@__env.CallVoidMethod(this, _shutdown6131); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.speech.tts.TextToSpeech.staticClass, _shutdown6131); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLanguage6132; 
		public virtual java.util.Locale getLanguage() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallObjectMethodPtr(this, _getLanguage6132)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.util.Locale>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.speech.tts.TextToSpeech.staticClass, _getLanguage6132)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _stop6133; 
		public virtual int stop() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _stop6133); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _stop6133); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSpeech6134; 
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _addSpeech6134, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _addSpeech6134, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addSpeech6135; 
		public virtual int addSpeech(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _addSpeech6135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _addSpeech6135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addEarcon6136; 
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _addEarcon6136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _addEarcon6136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _addEarcon6137; 
		public virtual int addEarcon(java.lang.String arg0, java.lang.String arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _addEarcon6137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _addEarcon6137, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _speak6138; 
		public virtual int speak(java.lang.String arg0, int arg1, java.util.HashMap arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _speak6138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _speak6138, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playEarcon6139; 
		public virtual int playEarcon(java.lang.String arg0, int arg1, java.util.HashMap arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _playEarcon6139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _playEarcon6139, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _playSilence6140; 
		public virtual int playSilence(long arg0, int arg1, java.util.HashMap arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _playSilence6140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _playSilence6140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isSpeaking6141; 
		public virtual bool isSpeaking() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallBooleanMethod(this, _isSpeaking6141); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.speech.tts.TextToSpeech.staticClass, _isSpeaking6141); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setSpeechRate6142; 
		public virtual int setSpeechRate(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _setSpeechRate6142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _setSpeechRate6142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setPitch6143; 
		public virtual int setPitch(float arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _setPitch6143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _setPitch6143, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setLanguage6144; 
		public virtual int setLanguage(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _setLanguage6144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _setLanguage6144, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLanguageAvailable6145; 
		public virtual int isLanguageAvailable(java.util.Locale arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _isLanguageAvailable6145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _isLanguageAvailable6145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _synthesizeToFile6146; 
		public virtual int synthesizeToFile(java.lang.String arg0, java.util.HashMap arg1, java.lang.String arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _synthesizeToFile6146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _synthesizeToFile6146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setOnUtteranceCompletedListener6147; 
		public virtual int setOnUtteranceCompletedListener(android.speech.tts.TextToSpeech.OnUtteranceCompletedListener arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.speech.tts.TextToSpeech)) 
				return @__env.CallIntMethod(this, _setOnUtteranceCompletedListener6147, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.speech.tts.TextToSpeech.staticClass, _setOnUtteranceCompletedListener6147, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _TextToSpeech6148; 
		public TextToSpeech(android.content.Context arg0, android.speech.tts.TextToSpeech.OnInitListener arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.speech.tts.TextToSpeech.staticClass, _TextToSpeech6148, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)); 
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
			global::android.speech.tts.TextToSpeech._shutdown6131 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "shutdown", "()V"); 
			global::android.speech.tts.TextToSpeech._getLanguage6132 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "getLanguage", "()Ljava/util/Locale;"); 
			global::android.speech.tts.TextToSpeech._stop6133 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "stop", "()I"); 
			global::android.speech.tts.TextToSpeech._addSpeech6134 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.speech.tts.TextToSpeech._addSpeech6135 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addSpeech", "(Ljava/lang/String;Ljava/lang/String;I)I"); 
			global::android.speech.tts.TextToSpeech._addEarcon6136 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;)I"); 
			global::android.speech.tts.TextToSpeech._addEarcon6137 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "addEarcon", "(Ljava/lang/String;Ljava/lang/String;I)I"); 
			global::android.speech.tts.TextToSpeech._speak6138 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "speak", "(Ljava/lang/String;ILjava/util/HashMap;)I"); 
			global::android.speech.tts.TextToSpeech._playEarcon6139 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "playEarcon", "(Ljava/lang/String;ILjava/util/HashMap;)I"); 
			global::android.speech.tts.TextToSpeech._playSilence6140 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "playSilence", "(JILjava/util/HashMap;)I"); 
			global::android.speech.tts.TextToSpeech._isSpeaking6141 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "isSpeaking", "()Z"); 
			global::android.speech.tts.TextToSpeech._setSpeechRate6142 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setSpeechRate", "(F)I"); 
			global::android.speech.tts.TextToSpeech._setPitch6143 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setPitch", "(F)I"); 
			global::android.speech.tts.TextToSpeech._setLanguage6144 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setLanguage", "(Ljava/util/Locale;)I"); 
			global::android.speech.tts.TextToSpeech._isLanguageAvailable6145 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "isLanguageAvailable", "(Ljava/util/Locale;)I"); 
			global::android.speech.tts.TextToSpeech._synthesizeToFile6146 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "synthesizeToFile", "(Ljava/lang/String;Ljava/util/HashMap;Ljava/lang/String;)I"); 
			global::android.speech.tts.TextToSpeech._setOnUtteranceCompletedListener6147 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "setOnUtteranceCompletedListener", "(Landroid/speech/tts/TextToSpeech$OnUtteranceCompletedListener;)I"); 
			global::android.speech.tts.TextToSpeech._TextToSpeech6148 = @__env.GetMethodID(global::android.speech.tts.TextToSpeech.staticClass, "<init>", "(Landroid/content/Context;Landroid/speech/tts/TextToSpeech$OnInitListener;)V"); 
		} 
	} 
} 
