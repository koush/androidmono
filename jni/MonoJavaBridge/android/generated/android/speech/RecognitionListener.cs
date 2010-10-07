namespace android.speech
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface RecognitionListener 
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

	public partial class RecognitionListener_
	{
		public static global::java.lang.Class _class
		{
			get { return __RecognitionListener.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __RecognitionListener : java.lang.Object, RecognitionListener
	{
		internal static global::java.lang.Class staticClass;
		static __RecognitionListener()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.speech.__RecognitionListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.speech.__RecognitionListener(@__env);
			}
		}
		internal __RecognitionListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _onError7005;
		 void android.speech.RecognitionListener.onError(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onError7005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onError7005, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEvent7006;
		 void android.speech.RecognitionListener.onEvent(int arg0, android.os.Bundle arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onEvent7006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onEvent7006, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onReadyForSpeech7007;
		 void android.speech.RecognitionListener.onReadyForSpeech(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onReadyForSpeech7007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onReadyForSpeech7007, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBeginningOfSpeech7008;
		 void android.speech.RecognitionListener.onBeginningOfSpeech() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onBeginningOfSpeech7008);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onBeginningOfSpeech7008);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onRmsChanged7009;
		 void android.speech.RecognitionListener.onRmsChanged(float arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onRmsChanged7009, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onRmsChanged7009, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onBufferReceived7010;
		 void android.speech.RecognitionListener.onBufferReceived(byte[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onBufferReceived7010, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onBufferReceived7010, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onEndOfSpeech7011;
		 void android.speech.RecognitionListener.onEndOfSpeech() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onEndOfSpeech7011);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onEndOfSpeech7011);
		}
		internal static global::net.sf.jni4net.jni.MethodId _onResults7012;
		 void android.speech.RecognitionListener.onResults(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onResults7012, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onResults7012, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onPartialResults7013;
		 void android.speech.RecognitionListener.onPartialResults(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.speech.__RecognitionListener._onPartialResults7013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.speech.__RecognitionListener.staticClass, global::android.speech.__RecognitionListener._onPartialResults7013, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.speech.__RecognitionListener.staticClass = @__class;
			global::android.speech.__RecognitionListener._onError7005 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onError", "(I)V");
			global::android.speech.__RecognitionListener._onEvent7006 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onEvent", "(ILandroid/os/Bundle;)V");
			global::android.speech.__RecognitionListener._onReadyForSpeech7007 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onReadyForSpeech", "(Landroid/os/Bundle;)V");
			global::android.speech.__RecognitionListener._onBeginningOfSpeech7008 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onBeginningOfSpeech", "()V");
			global::android.speech.__RecognitionListener._onRmsChanged7009 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onRmsChanged", "(F)V");
			global::android.speech.__RecognitionListener._onBufferReceived7010 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onBufferReceived", "([B)V");
			global::android.speech.__RecognitionListener._onEndOfSpeech7011 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onEndOfSpeech", "()V");
			global::android.speech.__RecognitionListener._onResults7012 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onResults", "(Landroid/os/Bundle;)V");
			global::android.speech.__RecognitionListener._onPartialResults7013 = @__env.GetMethodID(global::android.speech.__RecognitionListener.staticClass, "android.speech.RecognitionListener.onPartialResults", "(Landroid/os/Bundle;)V");
		}
	}
}
