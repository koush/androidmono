namespace android.speech
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.speech.RecognitionService_))]
	public abstract partial class RecognitionService : android.app.Service
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected RecognitionService(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Callback : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Callback(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void error(int arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, "error", "(I)V", ref global::android.speech.RecognitionService.Callback._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual void results(android.os.Bundle arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, "results", "(Landroid/os/Bundle;)V", ref global::android.speech.RecognitionService.Callback._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual void beginningOfSpeech()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, "beginningOfSpeech", "()V", ref global::android.speech.RecognitionService.Callback._m2);
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual void bufferReceived(byte[] arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, "bufferReceived", "([B)V", ref global::android.speech.RecognitionService.Callback._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual void endOfSpeech()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, "endOfSpeech", "()V", ref global::android.speech.RecognitionService.Callback._m4);
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual void partialResults(android.os.Bundle arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, "partialResults", "(Landroid/os/Bundle;)V", ref global::android.speech.RecognitionService.Callback._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual void readyForSpeech(android.os.Bundle arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, "readyForSpeech", "(Landroid/os/Bundle;)V", ref global::android.speech.RecognitionService.Callback._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual void rmsChanged(float arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.Callback.staticClass, "rmsChanged", "(F)V", ref global::android.speech.RecognitionService.Callback._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			static Callback()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.speech.RecognitionService.Callback.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService$Callback"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public sealed override global::android.os.IBinder onBind(android.content.Intent arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.os.IBinder>(this, global::android.speech.RecognitionService.staticClass, "onBind", "(Landroid/content/Intent;)Landroid/os/IBinder;", ref global::android.speech.RecognitionService._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.IBinder;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public override void onDestroy()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService.staticClass, "onDestroy", "()V", ref global::android.speech.RecognitionService._m1);
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected abstract void onCancel(android.speech.RecognitionService.Callback arg0);
		private static global::MonoJavaBridge.MethodId _m3;
		protected abstract void onStartListening(android.content.Intent arg0, android.speech.RecognitionService.Callback arg1);
		private static global::MonoJavaBridge.MethodId _m4;
		protected abstract void onStopListening(android.speech.RecognitionService.Callback arg0);
		private static global::MonoJavaBridge.MethodId _m5;
		public RecognitionService() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.speech.RecognitionService._m5.native == global::System.IntPtr.Zero)
				global::android.speech.RecognitionService._m5 = @__env.GetMethodIDNoThrow(global::android.speech.RecognitionService.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.speech.RecognitionService.staticClass, global::android.speech.RecognitionService._m5);
			Init(@__env, handle);
		}
		public static global::java.lang.String SERVICE_INTERFACE
		{
			get
			{
				return "android.speech.RecognitionService";
			}
		}
		public static global::java.lang.String SERVICE_META_DATA
		{
			get
			{
				return "android.speech";
			}
		}
		static RecognitionService()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionService.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.speech.RecognitionService))]
	internal sealed partial class RecognitionService_ : android.speech.RecognitionService
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal RecognitionService_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void onCancel(android.speech.RecognitionService.Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService_.staticClass, "onCancel", "(Landroid/speech/RecognitionService$Callback;)V", ref global::android.speech.RecognitionService_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected override void onStartListening(android.content.Intent arg0, android.speech.RecognitionService.Callback arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService_.staticClass, "onStartListening", "(Landroid/content/Intent;Landroid/speech/RecognitionService$Callback;)V", ref global::android.speech.RecognitionService_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		protected override void onStopListening(android.speech.RecognitionService.Callback arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.speech.RecognitionService_.staticClass, "onStopListening", "(Landroid/speech/RecognitionService$Callback;)V", ref global::android.speech.RecognitionService_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		static RecognitionService_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.speech.RecognitionService_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/speech/RecognitionService"));
		}
	}
}
