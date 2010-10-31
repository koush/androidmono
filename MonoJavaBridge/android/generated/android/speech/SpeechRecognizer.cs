namespace android.speech
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SpeechRecognizer : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SpeechRecognizer(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual void destroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, "destroy", "()V", ref global::android.speech.SpeechRecognizer._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, "cancel", "()V", ref global::android.speech.SpeechRecognizer._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void startListening(android.content.Intent arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, "startListening", "(Landroid/content/Intent;)V", ref global::android.speech.SpeechRecognizer._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void stopListening()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, "stopListening", "()V", ref global::android.speech.SpeechRecognizer._m3);
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static bool isRecognitionAvailable(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.speech.SpeechRecognizer._m4.native == global::System.IntPtr.Zero)
				global::android.speech.SpeechRecognizer._m4 = @__env.GetStaticMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "isRecognitionAvailable", "(Landroid/content/Context;)Z");
			return @__env.CallStaticBooleanMethod(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public static global::android.speech.SpeechRecognizer createSpeechRecognizer(android.content.Context arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.speech.SpeechRecognizer._m5.native == global::System.IntPtr.Zero)
				global::android.speech.SpeechRecognizer._m5 = @__env.GetStaticMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "createSpeechRecognizer", "(Landroid/content/Context;)Landroid/speech/SpeechRecognizer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.speech.SpeechRecognizer;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public static global::android.speech.SpeechRecognizer createSpeechRecognizer(android.content.Context arg0, android.content.ComponentName arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.speech.SpeechRecognizer._m6.native == global::System.IntPtr.Zero)
				global::android.speech.SpeechRecognizer._m6 = @__env.GetStaticMethodIDNoThrow(global::android.speech.SpeechRecognizer.staticClass, "createSpeechRecognizer", "(Landroid/content/Context;Landroid/content/ComponentName;)Landroid/speech/SpeechRecognizer;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.speech.SpeechRecognizer;
		}
		public new global::android.speech.RecognitionListener RecognitionListener
		{
			set
			{
				setRecognitionListener(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual void setRecognitionListener(android.speech.RecognitionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, "setRecognitionListener", "(Landroid/speech/RecognitionListener;)V", ref global::android.speech.SpeechRecognizer._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static global::java.lang.String RESULTS_RECOGNITION
		{
			get
			{
				return "results_recognition";
			}
		}
		public static int ERROR_NETWORK_TIMEOUT
		{
			get
			{
				return 1;
			}
		}
		public static int ERROR_NETWORK
		{
			get
			{
				return 2;
			}
		}
		public static int ERROR_AUDIO
		{
			get
			{
				return 3;
			}
		}
		public static int ERROR_SERVER
		{
			get
			{
				return 4;
			}
		}
		public static int ERROR_CLIENT
		{
			get
			{
				return 5;
			}
		}
		public static int ERROR_SPEECH_TIMEOUT
		{
			get
			{
				return 6;
			}
		}
		public static int ERROR_NO_MATCH
		{
			get
			{
				return 7;
			}
		}
		public static int ERROR_RECOGNIZER_BUSY
		{
			get
			{
				return 8;
			}
		}
		public static int ERROR_INSUFFICIENT_PERMISSIONS
		{
			get
			{
				return 9;
			}
		}
		static SpeechRecognizer()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.SpeechRecognizer.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/SpeechRecognizer"));
		}
	}
}
