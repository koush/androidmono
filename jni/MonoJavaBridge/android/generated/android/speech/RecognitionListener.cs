namespace android.speech
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::android.speech.RecognitionListener_))]
	public partial interface RecognitionListener  : global::MonoJavaBridge.IJavaObject 
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
		internal static global::MonoJavaBridge.MethodId _onError11591;
		 void android.speech.RecognitionListener.onError(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onError11591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onError11591, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEvent11592;
		 void android.speech.RecognitionListener.onEvent(int arg0, android.os.Bundle arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onEvent11592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onEvent11592, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _onReadyForSpeech11593;
		 void android.speech.RecognitionListener.onReadyForSpeech(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onReadyForSpeech11593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onReadyForSpeech11593, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBeginningOfSpeech11594;
		 void android.speech.RecognitionListener.onBeginningOfSpeech() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onBeginningOfSpeech11594);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onBeginningOfSpeech11594);
		}
		internal static global::MonoJavaBridge.MethodId _onRmsChanged11595;
		 void android.speech.RecognitionListener.onRmsChanged(float arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onRmsChanged11595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onRmsChanged11595, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onBufferReceived11596;
		 void android.speech.RecognitionListener.onBufferReceived(byte[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onBufferReceived11596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onBufferReceived11596, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onEndOfSpeech11597;
		 void android.speech.RecognitionListener.onEndOfSpeech() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onEndOfSpeech11597);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onEndOfSpeech11597);
		}
		internal static global::MonoJavaBridge.MethodId _onResults11598;
		 void android.speech.RecognitionListener.onResults(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onResults11598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onResults11598, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onPartialResults11599;
		 void android.speech.RecognitionListener.onPartialResults(android.os.Bundle arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_._onPartialResults11599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.speech.RecognitionListener_.staticClass, global::android.speech.RecognitionListener_._onPartialResults11599, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionListener_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionListener"));
			global::android.speech.RecognitionListener_._onError11591 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onError", "(I)V");
			global::android.speech.RecognitionListener_._onEvent11592 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onEvent", "(ILandroid/os/Bundle;)V");
			global::android.speech.RecognitionListener_._onReadyForSpeech11593 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onReadyForSpeech", "(Landroid/os/Bundle;)V");
			global::android.speech.RecognitionListener_._onBeginningOfSpeech11594 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onBeginningOfSpeech", "()V");
			global::android.speech.RecognitionListener_._onRmsChanged11595 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onRmsChanged", "(F)V");
			global::android.speech.RecognitionListener_._onBufferReceived11596 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onBufferReceived", "([B)V");
			global::android.speech.RecognitionListener_._onEndOfSpeech11597 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onEndOfSpeech", "()V");
			global::android.speech.RecognitionListener_._onResults11598 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onResults", "(Landroid/os/Bundle;)V");
			global::android.speech.RecognitionListener_._onPartialResults11599 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionListener_.staticClass, "onPartialResults", "(Landroid/os/Bundle;)V");
		}
	}
}
