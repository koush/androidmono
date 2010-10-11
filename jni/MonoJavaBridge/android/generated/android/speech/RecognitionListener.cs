namespace android.speech
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.speech.RecognitionListener_))]
	public interface RecognitionListener  : global::MonoJavaBridge.IJavaObject 
	{
		void onError(int arg0);
		void onEvent(int arg0, android.os.Bundle arg1);
		void onReadyForSpeech(android.os.Bundle arg0);
		void onBeginningOfSpeech();
		void onRmsChanged(float arg0);
		void onBufferReceived(byte[] arg0);
		void onEndOfSpeech();
		void onResults(android.os.Bundle arg0);
		void onPartialResults(android.os.Bundle arg0);
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.RecognitionListener))]
	public sealed partial class RecognitionListener_ : java.lang.Object, RecognitionListener
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static RecognitionListener_()
		{
			InitJNI();
		}
		internal RecognitionListener_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _onError7282;
		 void android.speech.RecognitionListener.onError(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onError7282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onError7282, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEvent7283;
		 void android.speech.RecognitionListener.onEvent(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onEvent7283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onEvent7283, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onReadyForSpeech7284;
		 void android.speech.RecognitionListener.onReadyForSpeech(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onReadyForSpeech7284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onReadyForSpeech7284, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBeginningOfSpeech7285;
		 void android.speech.RecognitionListener.onBeginningOfSpeech() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onBeginningOfSpeech7285);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onBeginningOfSpeech7285);
		}
		internal static global::MonoJavaBridge.MethodId _onRmsChanged7286;
		 void android.speech.RecognitionListener.onRmsChanged(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onRmsChanged7286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onRmsChanged7286, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBufferReceived7287;
		 void android.speech.RecognitionListener.onBufferReceived(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onBufferReceived7287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onBufferReceived7287, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEndOfSpeech7288;
		 void android.speech.RecognitionListener.onEndOfSpeech() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onEndOfSpeech7288);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onEndOfSpeech7288);
		}
		internal static global::MonoJavaBridge.MethodId _onResults7289;
		 void android.speech.RecognitionListener.onResults(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onResults7289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onResults7289, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPartialResults7290;
		 void android.speech.RecognitionListener.onPartialResults(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onPartialResults7290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onPartialResults7290, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionListener"));
			global::android.speech.RecognitionListener_._onError7282 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onError", "(I)V");
			global::android.speech.RecognitionListener_._onEvent7283 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onEvent", "(ILandroid/os/Bundle;)V");
			global::android.speech.RecognitionListener_._onReadyForSpeech7284 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onReadyForSpeech", "(Landroid/os/Bundle;)V");
			global::android.speech.RecognitionListener_._onBeginningOfSpeech7285 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onBeginningOfSpeech", "()V");
			global::android.speech.RecognitionListener_._onRmsChanged7286 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onRmsChanged", "(F)V");
			global::android.speech.RecognitionListener_._onBufferReceived7287 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onBufferReceived", "([B)V");
			global::android.speech.RecognitionListener_._onEndOfSpeech7288 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onEndOfSpeech", "()V");
			global::android.speech.RecognitionListener_._onResults7289 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onResults", "(Landroid/os/Bundle;)V");
			global::android.speech.RecognitionListener_._onPartialResults7290 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onPartialResults", "(Landroid/os/Bundle;)V");
		}
	}
}
