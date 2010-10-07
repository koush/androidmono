namespace android.speech
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SpeechRecognizer : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static SpeechRecognizer()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.SpeechRecognizer), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.speech.SpeechRecognizer(@__env);
			}
		}
		protected SpeechRecognizer(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _destroy7029;
		public virtual void destroy() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.SpeechRecognizer._destroy7029);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._destroy7029);
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancel7030;
		public virtual void cancel() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.SpeechRecognizer._cancel7030);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._cancel7030);
		}
		internal static global::net.sf.jni4net.jni.MethodId _startListening7031;
		public virtual void startListening(android.content.Intent arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.SpeechRecognizer._startListening7031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._startListening7031, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _stopListening7032;
		public virtual void stopListening() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.SpeechRecognizer._stopListening7032);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._stopListening7032);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isRecognitionAvailable7033;
		public static bool isRecognitionAvailable(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticBooleanMethod(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._isRecognitionAvailable7033, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createSpeechRecognizer7034;
		public static global::android.speech.SpeechRecognizer createSpeechRecognizer(android.content.Context arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.speech.SpeechRecognizer>(@__env, @__env.CallStaticObjectMethodPtr(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._createSpeechRecognizer7034, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createSpeechRecognizer7035;
		public static global::android.speech.SpeechRecognizer createSpeechRecognizer(android.content.Context arg0, android.content.ComponentName arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.speech.SpeechRecognizer>(@__env, @__env.CallStaticObjectMethodPtr(android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._createSpeechRecognizer7035, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRecognitionListener7036;
		public virtual void setRecognitionListener(android.speech.RecognitionListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.SpeechRecognizer._setRecognitionListener7036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.SpeechRecognizer.staticClass, global::android.speech.SpeechRecognizer._setRecognitionListener7036, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.speech.SpeechRecognizer.staticClass = @__class;
			global::android.speech.SpeechRecognizer._destroy7029 = @__env.GetMethodID(global::android.speech.SpeechRecognizer.staticClass, "destroy", "()V");
			global::android.speech.SpeechRecognizer._cancel7030 = @__env.GetMethodID(global::android.speech.SpeechRecognizer.staticClass, "cancel", "()V");
			global::android.speech.SpeechRecognizer._startListening7031 = @__env.GetMethodID(global::android.speech.SpeechRecognizer.staticClass, "startListening", "(Landroid/content/Intent;)V");
			global::android.speech.SpeechRecognizer._stopListening7032 = @__env.GetMethodID(global::android.speech.SpeechRecognizer.staticClass, "stopListening", "()V");
			global::android.speech.SpeechRecognizer._isRecognitionAvailable7033 = @__env.GetStaticMethodID(global::android.speech.SpeechRecognizer.staticClass, "isRecognitionAvailable", "(Landroid/content/Context;)Z");
			global::android.speech.SpeechRecognizer._createSpeechRecognizer7034 = @__env.GetStaticMethodID(global::android.speech.SpeechRecognizer.staticClass, "createSpeechRecognizer", "(Landroid/content/Context;)Landroid/speech/SpeechRecognizer;");
			global::android.speech.SpeechRecognizer._createSpeechRecognizer7035 = @__env.GetStaticMethodID(global::android.speech.SpeechRecognizer.staticClass, "createSpeechRecognizer", "(Landroid/content/Context;Landroid/content/ComponentName;)Landroid/speech/SpeechRecognizer;");
			global::android.speech.SpeechRecognizer._setRecognitionListener7036 = @__env.GetMethodID(global::android.speech.SpeechRecognizer.staticClass, "setRecognitionListener", "(Landroid/speech/RecognitionListener;)V");
		}
	}
}
